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
            Dim createTableQuery As String = "CREATE TABLE IF NOT EXISTS Contacts (ContactId INTEGER PRIMARY KEY, ContactName TEXT, ContactPhone TEXT, ContactEmail TEXT)"
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
    ''' <returns>True if the contact was successfully created, otherwise False.</returns>
    Public Function CreateContact(contactName As String, phoneNumber As String, email As String) As Boolean
        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()

            Dim query As String = "INSERT INTO Contacts (ContactName, ContactPhone, ContactEmail) VALUES (@Name, @PhoneNumber, @Email)"
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

                Dim queryBuilder As New StringBuilder("SELECT ContactId, ContactName, ContactPhone, ContactEmail FROM Contacts WHERE 1=1 ")

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
