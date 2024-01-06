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

        CreateCustomersTable()
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

#Region "Creating data"
    ''' <summary>
    ''' Creates the 'Customers' table if it doesn't exist.
    ''' </summary>
    ''' <remarks>This is needed because the project is built with SQLite, SQLite is a light weight db that 
    ''' will be unique to the user running the application installed locally on their machine.</remarks>
    Public Sub CreateCustomersTable()
        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()
            Dim createTableQuery As String = "CREATE TABLE IF NOT EXISTS Customers (CustomerId INTEGER PRIMARY KEY, CustomerName TEXT, CustomerPhone TEXT, CustomerEmail TEXT)"
            Using command As New SQLiteCommand(createTableQuery, connection)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ''' <summary>
    ''' Creates a new contact in the database.
    ''' </summary>
    ''' <param name="contactName">The name of the contact.</param>
    ''' <param name="phoneNumber">The phone number of the contact.</param>
    ''' <param name="email">The email address of the contact.</param>
    ''' <returns>True if the contact was successfully created, otherwise False.</returns>
    Public Function CreateContact(contactName As String, phoneNumber As String, email As String) As Boolean
        Try
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
        Catch ex As Exception
            Return False
        End Try
    End Function
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

        Try
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
        Catch ex As Exception
            Return dataTable
        End Try
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
        Try
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
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#Region "Deleting data"

#End Region

#End Region

End Class
