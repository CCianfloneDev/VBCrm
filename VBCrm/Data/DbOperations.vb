Imports System.Data.SQLite
Imports System.Text

''' <summary>
''' Class responsible for handling database operations.
''' </summary>
Public Class DbOperations

#Region "Properties"
    ''' <summary>
    ''' Represents the connection string to the SQLite database.
    ''' </summary>
    ''' <returns>Connection string.</returns>
    Private Property ConnectionString As String = "Data Source=mydatabase.db;Version=3;"

    ''' <summary>
    ''' Represents the connection instance to the SQLite database.
    ''' </summary>
    ''' <returns>SQLiteConnection.</returns>
    Private Property Connection As SQLiteConnection
#End Region

#Region "Setting up database"
    ''' <summary>
    ''' Constructor to initialize the database.
    ''' </summary>
    Public Sub New()
        If Not IO.File.Exists("mydatabase.db") Then
            SQLiteConnection.CreateFile("mydatabase.db")
        End If

        CreateContactsTable()
        CreateThemes()
        CreateColumnVisibilityTable()
        CreateColumnOrderTable()
    End Sub
#End Region

#Region "Handling connection"
    ''' <summary>
    ''' Opens a connection to the SQLite database.
    ''' </summary>
    Public Sub OpenConnection()
        Connection = New SQLiteConnection(ConnectionString)
        Connection.Open()
    End Sub

    ''' <summary>
    ''' Closes the connection to the SQLite database.
    ''' </summary>
    Public Sub CloseConnection()
        If Connection IsNot Nothing AndAlso Connection.State = ConnectionState.Open Then
            Connection.Close()
        End If
    End Sub
#End Region

#Region "CRUD operations"

#Region "Creating tables"
    ''' <summary>
    ''' Creates the 'Contacts' table if it doesn't exist.
    ''' </summary>
    ''' <remarks>This is needed because the project is built with SQLite, SQLite is a light weight db that 
    ''' will be unique to the user running the application installed locally on their machine.</remarks>
    Private Sub CreateContactsTable()
        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()
            Dim createTableQuery As String = "CREATE TABLE IF NOT EXISTS Contacts (ContactId INTEGER PRIMARY KEY, ContactName TEXT, ContactPhone TEXT, ContactEmail TEXT, " &
                                             "ContactCompany TEXT, ContactJobTitle TEXT, ContactDateOfBirth DATE, ContactNotes TEXT)"
            Using command As New SQLiteCommand(createTableQuery, connection)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ''' <summary>
    ''' Creates the different theme options to be used by the application.
    ''' </summary>
    Private Sub CreateThemes()
        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()

            Dim createThemesQuery As String = "CREATE TABLE IF NOT EXISTS Themes (ThemeId INTEGER PRIMARY KEY, ThemeName TEXT, Selected INTEGER DEFAULT 0)"
            Using command As New SQLiteCommand(createThemesQuery, connection)
                command.ExecuteNonQuery()
            End Using

            Dim insertThemeQuery As String = "INSERT OR IGNORE INTO Themes (ThemeName) VALUES (@ThemeName)"
            Using command As New SQLiteCommand(insertThemeQuery, connection)
                command.Parameters.AddWithValue("@ThemeName", "Dark Mode - Purple")
                command.ExecuteNonQuery()

                command.Parameters.Clear()
                command.Parameters.AddWithValue("@ThemeName", "Light Mode - Blue")
                command.ExecuteNonQuery()

                command.Parameters.Clear()
                command.Parameters.AddWithValue("@ThemeName", "Dark Mode - Green")
                command.ExecuteNonQuery()

                command.Parameters.Clear()
                command.Parameters.AddWithValue("@ThemeName", "Light Mode - Green")
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ''' <summary>
    ''' Creates the table storing the columns of the grid and their visibility state.
    ''' </summary>
    Public Sub CreateColumnVisibilityTable()
        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()

            ' Create the ColumnVisibility table if it doesn't exist
            Dim createColumnVisibilityQuery As String =
            "CREATE TABLE IF NOT EXISTS ColumnVisibility (
            ColumnName TEXT PRIMARY KEY,
            IsVisible INTEGER DEFAULT 1)"

            Using command As New SQLiteCommand(createColumnVisibilityQuery, connection)
                command.ExecuteNonQuery()
            End Using

            ' Check if the table is empty
            Dim checkEmptyTableQuery As String = "SELECT COUNT(*) FROM ColumnVisibility"
            Using command As New SQLiteCommand(checkEmptyTableQuery, connection)
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                If count = 0 Then
                    ' Insert all column names with their visibility set to 1 (visible)
                    Dim insertColumnsQuery As String =
                    "INSERT INTO ColumnVisibility (ColumnName, IsVisible) VALUES 
                    ('ContactId', 0),
                    ('ContactName', 1),
                    ('ContactPhone', 1),
                    ('ContactEmail', 1),
                    ('ContactCompany', 1),
                    ('ContactJobTitle', 1),
                    ('ContactDateOfBirth', 1),
                    ('ContactNotes', 1)"

                    Using insertCommand As New SQLiteCommand(insertColumnsQuery, connection)
                        insertCommand.ExecuteNonQuery()
                    End Using
                End If
            End Using

            connection.Close()
        End Using
    End Sub

    ''' <summary>
    ''' Creates the table storing the columns of the grid and their order.
    ''' </summary>
    Public Sub CreateColumnOrderTable()
        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()

            Dim createTableQuery As String = "CREATE TABLE IF NOT EXISTS ColumnOrder (ColumnId INTEGER PRIMARY KEY, ColumnName TEXT, DisplayIndex INTEGER);"

            Using command As New SQLiteCommand(createTableQuery, connection)
                command.ExecuteNonQuery()
            End Using

            ' Insert default display orders for columns if the table is empty
            Dim checkTableQuery As String = "SELECT COUNT(*) FROM ColumnOrder"
            Using command As New SQLiteCommand(checkTableQuery, connection)
                Dim rowCount As Integer = CInt(command.ExecuteScalar())

                If rowCount = 0 Then
                    InsertDefaultColumnOrders(connection)
                End If
            End Using

            connection.Close()
        End Using
    End Sub

#End Region

#Region "Creating data"

    ''' <summary>
    ''' Creates a new contact in the database.
    ''' </summary>
    ''' <param name="contactName">The name of the contact.</param>
    ''' <param name="phoneNumber">The phone number of the contact.</param>
    ''' <param name="email">The email address of the contact.</param>
    ''' <returns>True if the contact was successfully created, otherwise False.</returns>
    Public Function CreateContact(contactName As String, phoneNumber As String, email As String) As Boolean
        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()

            Dim query As String = "INSERT INTO Contacts (ContactName, ContactPhone, ContactEmail, ContactCompany, ContactJobTitle, ContactDateOfBirth, ContactNotes) " &
                                  "VALUES (@Name, @PhoneNumber, @Email, @Company, @JobTitle, @DateOfBirth @Notes)"
            Using command As New SQLiteCommand(query, connection)
                command.Parameters.AddWithValue("@Name", contactName)
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber)
                command.Parameters.AddWithValue("@Email", email)
                command.ExecuteNonQuery()
            End Using

            connection.Close()
            Return True
        End Using

        Return False
    End Function

    ''' <summary>
    ''' Inserts the default column order of the grid.
    ''' </summary>
    ''' <param name="connection">Connection to use for the database action.</param>
    Private Shared Sub InsertDefaultColumnOrders(connection As SQLiteConnection)
        Dim defaultOrders As New Dictionary(Of String, Integer) From {
            {"ContactId", 1},
            {"ContactName", 2},
            {"ContactPhone", 3},
            {"ContactEmail", 4},
            {"ContactCompany", 5},
            {"ContactJobTitle", 6},
            {"ContactDateOfBirth", 7},
            {"ContactNotes", 8}
        }

        For Each kvp As KeyValuePair(Of String, Integer) In defaultOrders
            Dim insertQuery As String = $"INSERT INTO ColumnOrder (ColumnName, DisplayIndex) VALUES (@ColumnName, @DisplayIndex)"

            Using command As New SQLiteCommand(insertQuery, connection)
                command.Parameters.AddWithValue("@ColumnName", kvp.Key)
                command.Parameters.AddWithValue("@DisplayIndex", kvp.Value)
                command.ExecuteNonQuery()
            End Using
        Next
    End Sub

#End Region

#Region "Reading data"
    ''' <summary>
    ''' Searches contacts in the database based on specified criteria.
    ''' </summary>
    ''' <param name="name">The name of the contact (optional).</param>
    ''' <param name="phoneNumber">The phone number of the contact (optional).</param>
    ''' <param name="email">The email address of the contact (optional).</param>
    ''' <returns>A DataTable containing the search results.</returns>
    Public Function SearchContacts(Optional name As String = "", Optional phoneNumber As String = "", Optional email As String = "") As DataTable
        Dim dataTable As New DataTable()

        Using connection As New SQLiteConnection(ConnectionString)
                connection.Open()

            Dim queryBuilder As New StringBuilder("SELECT ContactId, ContactName, ContactPhone, ContactEmail, ContactCompany, " &
                                                         "ContactJobTitle, ContactDateOfBirth, ContactNotes FROM Contacts WHERE 1=1 ")

            Using command As New SQLiteCommand(connection)
                    If Not String.IsNullOrEmpty(name) Then
                        queryBuilder.Append("AND LOWER(ContactName) LIKE @ContactName ")
                        command.Parameters.AddWithValue("@ContactName", name.ToLower & "%")
                    End If

                    If Not String.IsNullOrEmpty(phoneNumber) Then
                        queryBuilder.Append("AND LOWER(ContactPhone) LIKE @ContactPhone ")
                        command.Parameters.AddWithValue("@ContactPhone", phoneNumber.ToLower & "%")
                    End If

                    If Not String.IsNullOrEmpty(email) Then
                        queryBuilder.Append("AND LOWER(ContactEmail) LIKE @ContactEmail ")
                        command.Parameters.AddWithValue("@ContactEmail", email.ToLower & "%")
                    End If

                    command.CommandText = queryBuilder.ToString()

                    Using adapter As New SQLiteDataAdapter(command)
                        adapter.Fill(dataTable)
                    End Using
                End Using

                connection.Close()
            End Using

            Return dataTable
    End Function

    ''' <summary>
    ''' Gets the currently selected theme.
    ''' </summary>
    ''' <returns>Theme currently being used.</returns>
    Public Function GetSelectedTheme() As Themes
        Dim selectedThemeId As Integer = -1
        Dim selectedTheme As Themes = Themes.LightModeGreen

        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()

            Dim query As String = "SELECT ThemeId FROM Themes WHERE Selected = 1"

            Using command As New SQLiteCommand(query, connection)
                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    selectedThemeId = Convert.ToInt32(result)
                End If
            End Using

            connection.Close()

            If selectedThemeId <> -1 Then
                Select Case selectedThemeId
                    Case 1
                        Return Themes.DarkModePurple
                    Case 2
                        Return Themes.LightModeBlue
                    Case 3
                        Return Themes.DarkModeGreen
                    Case 4
                        Return Themes.LightModeGreen
                End Select
            End If
        End Using

        Return selectedTheme
    End Function

    ''' <summary>
    ''' Retrieves column visibility data from the database.
    ''' </summary>
    ''' <returns>A dictionary containing column names as keys and their visibility status as values.</returns>
    Public Function GetColumnVisibility() As Dictionary(Of String, Boolean)
        Dim visibilityData As New Dictionary(Of String, Boolean)()

        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()

            Dim query As String = "SELECT ColumnName, IsVisible FROM ColumnVisibility"

            Using command As New SQLiteCommand(query, connection)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim columnName As String = reader.GetString(0)
                        Dim isVisible As Boolean = reader.GetBoolean(1)
                        visibilityData.Add(columnName, isVisible)
                    End While
                End Using
            End Using

            connection.Close()
        End Using

        Return visibilityData
    End Function

    ''' <summary>
    ''' Retrieves column display index data from the database.
    ''' </summary>
    ''' <returns>A dictionary containing column names as keys and their display indices as values.</returns>
    Public Function GetColumnDisplayIndex() As Dictionary(Of String, Integer)
        Dim displayIndexData As New Dictionary(Of String, Integer)()

        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()

            Dim query As String = "SELECT ColumnName, DisplayIndex FROM ColumnOrder"

            Using command As New SQLiteCommand(query, connection)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim columnName As String = reader.GetString(0)
                        Dim displayIndex As Integer = reader.GetInt32(1)
                        displayIndexData.Add(columnName, displayIndex)
                    End While
                End Using
            End Using

            connection.Close()
        End Using

        Return displayIndexData
    End Function
#End Region

#Region "Updating data"
    ''' <summary>
    ''' Updates an existing contact in the database.
    ''' </summary>
    ''' <param name="contactId">The ID of the contact to be updated.</param>
    ''' <param name="newContactName">The new name for the contact.</param>
    ''' <param name="newPhoneNumber">The new phone number for the contact.</param>
    ''' <param name="newEmail">The new email address for the contact.</param>
    ''' <returns>True if the contact was successfully updated, otherwise False.</returns>
    Public Function UpdateContact(contactId As Integer, newContactName As String, newPhoneNumber As String, newEmail As String) As Boolean
        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()

            Dim query As String = "UPDATE Contacts SET ContactName = @NewName, ContactPhone = @NewPhoneNumber, ContactEmail = @NewEmail WHERE ContactId = @ContactId"

            Using command As New SQLiteCommand(query, connection)
                command.Parameters.AddWithValue("@NewName", newContactName)
                command.Parameters.AddWithValue("@NewPhoneNumber", newPhoneNumber)
                command.Parameters.AddWithValue("@NewEmail", newEmail)
                command.Parameters.AddWithValue("@ContactId", contactId)
                command.ExecuteNonQuery()
            End Using

            connection.Close()
            Return True
        End Using
    End Function

    ''' <summary>
    ''' Updates the currently selected theme in the database.
    ''' </summary>
    ''' <param name="themeId">ID of theme now being used.</param>
    ''' <returns>True if the theme succesfully updated.</returns>
    Public Function UpdateSelectedTheme(themeId As Integer) As Boolean
        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()

            Dim updateQuery As String = "UPDATE Themes SET Selected = CASE WHEN ThemeId = @ThemeId THEN 1 ELSE 0 END"

            Using command As New SQLiteCommand(updateQuery, connection)
                command.Parameters.AddWithValue("@ThemeId", themeId)
                command.ExecuteNonQuery()
            End Using

            connection.Close()
            Return True
        End Using
    End Function

    ''' <summary>
    ''' Updates the visibility of a column in the ColumnVisibility table.
    ''' If the table is empty, inserts default values for column visibility.
    ''' </summary>
    ''' <param name="columnName">The name of the column to update.</param>
    ''' <param name="isVisible">Boolean value indicating whether the column should be visible.</param>
    Public Sub UpdateColumnVisibility(columnName As String, isVisible As Boolean)
        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()

            ' Check if the ColumnVisibility table is empty
            Dim checkTableQuery As String = "SELECT COUNT(*) FROM ColumnVisibility"

            ' Update the visibility of the column
            Dim updateColumnQuery As String = $"UPDATE ColumnVisibility SET IsVisible = @Visible WHERE ColumnName = @ColumnName"

            Using updateCommand As New SQLiteCommand(updateColumnQuery, connection)
                updateCommand.Parameters.AddWithValue("@Visible", If(isVisible, 1, 0))
                updateCommand.Parameters.AddWithValue("@ColumnName", columnName)
                updateCommand.ExecuteNonQuery()
            End Using

            connection.Close()
        End Using
    End Sub

    ''' <summary>
    ''' Updates the display index of a column in the ColumnOrder table.
    ''' If the table is empty, inserts default values for display index.
    ''' </summary>
    ''' <param name="columnName">The name of the column to update.</param>
    ''' <param name="displayIndex">Display index of the column in the grid.</param>
    Public Sub UpdateColumnDisplayIndex(columnName As String, displayIndex As Integer)
        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()

            ' Update the display index of the column
            Dim updateColumnQuery As String = $"UPDATE ColumnOrder SET DisplayIndex = @DisplayIndex WHERE ColumnName = @ColumnName"

            Using updateCommand As New SQLiteCommand(updateColumnQuery, connection)
                updateCommand.Parameters.AddWithValue("@DisplayIndex", displayIndex)
                updateCommand.Parameters.AddWithValue("@ColumnName", columnName)
                updateCommand.ExecuteNonQuery()
            End Using

            connection.Close()
        End Using
    End Sub
#End Region

#Region "Deleting data"

    ''' <summary>
    ''' Deletes a contact by ContactId from the database.
    ''' </summary>
    ''' <param name="contactId">The ID of the contact to delete.</param>
    ''' <returns>True if the contact was successfully deleted, otherwise False.</returns>
    Public Function DeleteContactById(contactId As Integer) As Boolean
        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()

            Dim query As String = "DELETE FROM Contacts WHERE ContactId = @ContactId"
            Using command As New SQLiteCommand(query, connection)
                command.Parameters.AddWithValue("@ContactId", contactId)
                command.ExecuteNonQuery()
            End Using

            Return True
        End Using
    End Function

    ''' <summary>
    ''' Deletes all contacts from the database.
    ''' </summary>
    ''' <returns>True if all contacts were successfully deleted, otherwise False.</returns>
    Public Function DeleteAllContacts() As Boolean
        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()

            Dim query As String = "DELETE FROM Contacts"
            Using command As New SQLiteCommand(query, connection)
                command.ExecuteNonQuery()
            End Using

            Return True
        End Using
    End Function
#End Region

#End Region

End Class
