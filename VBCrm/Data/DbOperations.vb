Imports System.Data.SQLite
Imports System.IO
Imports System.Security.AccessControl
Imports System.Text
Imports System.Text.Json

''' <summary>
''' Class responsible for handling database operations.
''' </summary>
Public Class DbOperations

#Region "Properties"
    ''' <summary>
    ''' Represents the connection string to the SQLite database.
    ''' </summary>
    ''' <returns>Connection string.</returns>
    Private Property ConnectionString As String

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
        Dim commonAppDataDir As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)
        Dim databaseFilePath As String = Path.Combine(commonAppDataDir, "VBCrm", "mydatabase.db")

        If Not Directory.Exists(Path.GetDirectoryName(databaseFilePath)) Then
            Directory.CreateDirectory(Path.GetDirectoryName(databaseFilePath))
        End If

        If Not IO.File.Exists(databaseFilePath) Then
            SQLiteConnection.CreateFile(databaseFilePath)
        End If

        ' Ensure the file is not read-only
        If (File.GetAttributes(databaseFilePath) And FileAttributes.ReadOnly) = FileAttributes.ReadOnly Then
            File.SetAttributes(databaseFilePath, File.GetAttributes(databaseFilePath) And Not FileAttributes.ReadOnly)
        End If

        ConnectionString = $"Data Source={databaseFilePath};Version=3;"

        CreateContactsTable()
        CreateThemes()
        CreateColumnVisibilityTable()
        CreateColumnOrderTable()
        CreateErrorLogsTable()
    End Sub
#End Region

#Region "Handling connection"

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
                                             "ContactAddress TEXT, ContactCompany TEXT, ContactJobTitle TEXT, ContactDateOfBirth TEXT, ContactNotes TEXT)"
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
                    ('ContactAddress',1),
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

    ''' <summary>
    ''' Creates the 'ErrorLogs' table if it doesn't exist.
    ''' </summary>
    Private Sub CreateErrorLogsTable()
        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()

            Dim createTableQuery As String = "CREATE TABLE IF NOT EXISTS ErrorLogs (LogId INTEGER PRIMARY KEY, LogTimestamp TEXT, ErrorMessage TEXT)"
            Using command As New SQLiteCommand(createTableQuery, connection)
                command.ExecuteNonQuery()
            End Using
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
    Public Sub CreateContact(contactName As String, phoneNumber As String, email As String, address As String, company As String, jobTitle As String, dateOfBirth As String, notes As String)
        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()

            Dim query As New StringBuilder("INSERT INTO Contacts (ContactName")

            Dim valueQuery As New StringBuilder(" VALUES (@Name")
            Using command As New SQLiteCommand(query.ToString(), connection)
                command.Parameters.AddWithValue("@Name", contactName)

                If Not String.IsNullOrEmpty(phoneNumber) Then
                    query.Append(", ContactPhone")
                    valueQuery.Append(", @PhoneNumber")
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber)
                End If

                If Not String.IsNullOrEmpty(email) Then
                    query.Append(", ContactEmail")
                    valueQuery.Append(", @Email")
                    command.Parameters.AddWithValue("@Email", email)
                End If

                If Not String.IsNullOrEmpty(address) Then
                    query.Append(", ContactAddress")
                    valueQuery.Append(", @Address")
                    command.Parameters.AddWithValue("@Address", address)
                End If

                If Not String.IsNullOrEmpty(company) Then
                    query.Append(", ContactCompany")
                    valueQuery.Append(", @Company")
                    command.Parameters.AddWithValue("@Company", company)
                End If

                If Not String.IsNullOrEmpty(jobTitle) Then
                    query.Append(", ContactJobTitle")
                    valueQuery.Append(", @JobTitle")
                    command.Parameters.AddWithValue("@JobTitle", jobTitle)
                End If

                If Not String.IsNullOrEmpty(dateOfBirth) Then
                    query.Append(", ContactDateOfBirth")
                    valueQuery.Append(", @DateOfBirth")
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth)
                End If

                If Not String.IsNullOrEmpty(notes) Then
                    query.Append(", ContactNotes")
                    valueQuery.Append(", @Notes")
                    command.Parameters.AddWithValue("@Notes", notes)
                End If

                query.Append(")"c)
                valueQuery.Append(")"c)

                command.CommandText = query.ToString() & valueQuery.ToString()

                command.ExecuteNonQuery()
            End Using

            connection.Close()
        End Using
    End Sub

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
            {"ContactAddress", 5},
            {"ContactCompany", 6},
            {"ContactJobTitle", 7},
            {"ContactDateOfBirth", 8},
            {"ContactNotes", 9}
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

    ''' <summary>
    ''' Inserts an error log entry into the 'ErrorLogs' table.
    ''' </summary>
    ''' <param name="errorMessage">The error message to be logged.</param>
    Public Sub InsertErrorLog(errorMessage As String)
        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()

            Dim insertLogQuery As String = "INSERT INTO ErrorLogs (LogTimestamp, ErrorMessage) VALUES (@LogTimestamp, @ErrorMessage)"
            Using command As New SQLiteCommand(insertLogQuery, connection)
                command.Parameters.AddWithValue("@LogTimestamp", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                command.Parameters.AddWithValue("@ErrorMessage", errorMessage)
                command.ExecuteNonQuery()
            End Using
        End Using
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

            Dim queryBuilder As New StringBuilder("SELECT ContactId, ContactName, ContactPhone, ContactEmail, ContactAddress, ContactCompany, " &
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

    ''' <summary>
    ''' Retrieves all the error logs from the database.
    ''' </summary>
    ''' <returns>Error log lines as one string.</returns>
    Public Function GetAllErrorLogs() As String
        Dim logsText As New StringBuilder()

        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()

            Dim getLogsQuery As String = "SELECT * FROM ErrorLogs ORDER BY LogTimestamp DESC"
            Using command As New SQLiteCommand(getLogsQuery, connection)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim logTimestamp As String = Convert.ToString(reader("LogTimestamp"))
                        Dim errorMessage As String = Convert.ToString(reader("ErrorMessage"))

                        logsText.AppendLine($"Timestamp: {logTimestamp}, Message: {errorMessage}")
                    End While
                End Using
            End Using
        End Using

        Return logsText.ToString()
    End Function
#End Region

#Region "Updating data"
    ''' <summary>
    ''' Updates an existing contact in the database.
    ''' </summary>
    ''' <param name="contactId">The ID of the contact to be updated.</param>
    ''' <param name="contactName">The new name for the contact.</param>
    ''' <param name="phoneNumber">The new phone number for the contact.</param>
    ''' <param name="email">The new email address for the contact.</param>
    ''' <param name="address">The  address for the contact.</param>
    ''' <param name="company">The company the contact belongs to.</param>
    ''' <param name="jobTitle">The job title the contact maintains.</param>
    ''' <param name="dateOfBirth">The date of birth of the contact.</param>
    ''' <param name="notes">Any notes pertaining to the contact.</param>
    Public Sub UpdateContact(contactId As Integer, contactName As String, phoneNumber As String, email As String, address As String, company As String, jobTitle As String, dateOfBirth As String, notes As String)
        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()

            Dim query As New StringBuilder("UPDATE Contacts SET ")

            Using command As New SQLiteCommand(query.ToString(), connection)
                If Not String.IsNullOrEmpty(contactName) Then
                    query.Append("ContactName = @ContactName, ")
                    command.Parameters.AddWithValue("@ContactName", contactName)
                End If

                If Not String.IsNullOrEmpty(phoneNumber) Then
                    query.Append("ContactPhone = @PhoneNumber, ")
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber)
                End If

                If Not String.IsNullOrEmpty(email) Then
                    query.Append("ContactEmail = @Email, ")
                    command.Parameters.AddWithValue("@Email", email)
                End If

                If Not String.IsNullOrEmpty(email) Then
                    query.Append("ContactAddress = @ContactAddress, ")
                    command.Parameters.AddWithValue("@ContactAddress", address)
                End If

                If Not String.IsNullOrEmpty(company) Then
                    query.Append("ContactCompany = @Company, ")
                    command.Parameters.AddWithValue("@Company", company)
                End If

                If Not String.IsNullOrEmpty(jobTitle) Then
                    query.Append("ContactJobTitle = @JobTitle, ")
                    command.Parameters.AddWithValue("@JobTitle", jobTitle)
                End If

                If Not String.IsNullOrEmpty(dateOfBirth) Then
                    query.Append("ContactDateOfBirth = @DateOfBirth, ")
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth)
                End If

                If Not String.IsNullOrEmpty(notes) Then
                    query.Append("ContactNotes = @Notes, ")
                    command.Parameters.AddWithValue("@Notes", notes)
                End If

                ' Remove the last comma and space
                query.Length -= 2

                query.Append($" WHERE ContactId = @ContactId")
                command.Parameters.AddWithValue("@ContactId", contactId)

                command.CommandText = query.ToString()
                command.ExecuteNonQuery()
            End Using
            connection.Close()
        End Using
    End Sub

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

    ''' <summary>
    ''' Deletes all logs from the 'ErrorLogs' table.
    ''' </summary>
    Public Sub DeleteAllLogs()
        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()

            Dim deleteLogsQuery As String = "DELETE FROM ErrorLogs"
            Using command As New SQLiteCommand(deleteLogsQuery, connection)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

#End Region

#Region "Functions and subs"

#End Region

End Class
