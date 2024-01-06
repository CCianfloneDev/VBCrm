Imports System.Data.SQLite
Imports System.Text

''' <summary>
''' Class responsible for handling database operations.
''' </summary>
Public Class DbOperations
    Private Property ConnectionString As String = "Data Source=mydatabase.db;Version=3;"
    Private Property Connection As SQLiteConnection

    ''' <summary>
    ''' Constructor to initialize the database.
    ''' </summary>
    Public Sub New()
        ' Create the database file if it doesn't exist
        If Not System.IO.File.Exists("mydatabase.db") Then
            SQLiteConnection.CreateFile("mydatabase.db")
        End If
    End Sub

    ''' <summary>
    ''' Opens a connection to the SQLite database.
    ''' </summary>
    Public Sub OpenConnection()
        ' Open a connection to the SQLite database
        Connection = New SQLiteConnection(ConnectionString)
        Connection.Open()
    End Sub

    ''' <summary>
    ''' Closes the connection to the SQLite database.
    ''' </summary>
    Public Sub CloseConnection()
        ' Close the connection if it's open
        If Connection IsNot Nothing AndAlso Connection.State = ConnectionState.Open Then
            Connection.Close()
        End If
    End Sub

    ''' <summary>
    ''' Creates the 'Customers' table if it doesn't exist.
    ''' </summary>
    ''' <remarks>This is needed because the project is built with SQLite, SQLite is a light weight db that 
    ''' will be unique to the user running the application installed locally on their machine.</remarks>
    Public Sub CreateCustomersTable()
        ' Create a table if it doesn't exist
        OpenConnection()
        Dim createTableQuery As String = "CREATE TABLE IF NOT EXISTS Contacts (ContactId INTEGER PRIMARY KEY, ContactName TEXT, ContactPhone TEXT, ContactEmail TEXT)"
        Dim command As New SQLiteCommand(createTableQuery, Connection)
        command.ExecuteNonQuery()
        CloseConnection()
    End Sub

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
End Class
