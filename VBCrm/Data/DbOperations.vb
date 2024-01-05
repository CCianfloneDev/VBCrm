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
        Dim createTableQuery As String = "CREATE TABLE IF NOT EXISTS Contacts (contact_id INTEGER PRIMARY KEY, contact_name TEXT, contact_phone TEXT, contact_email TEXT)"
        Dim command As New SQLiteCommand(createTableQuery, Connection)
        command.ExecuteNonQuery()
        CloseConnection()
    End Sub

    Public Function SaveContact(contactName As String, phoneNumber As String, email As String) As Boolean
        Try
            Using connection As New SQLiteConnection(ConnectionString)
                connection.Open()

                Dim query As String = "INSERT INTO Contacts (contact_name, contact_phone, contact_email) VALUES (@Name, @PhoneNumber, @Email)"
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

    Public Function SearchContacts(Optional name As String = "", Optional phoneNumber As String = "", Optional email As String = "") As DataTable
        Dim dataTable As New DataTable()

        Try
            Using connection As New SQLiteConnection(ConnectionString)
                connection.Open()

                Dim queryBuilder As New StringBuilder("SELECT contact_id, contact_name, contact_phone, contact_email FROM Contacts WHERE 1=1 ")

                ' Create parameters and append to the query if search criteria are provided
                Using command As New SQLiteCommand(connection)
                    If Not String.IsNullOrEmpty(name) Then
                        queryBuilder.Append("AND contact_name = @ContactName ")
                        command.Parameters.AddWithValue("@ContactName", name)
                    End If

                    If Not String.IsNullOrEmpty(phoneNumber) Then
                        queryBuilder.Append("AND contact_phone = @ContactPhone ")
                        command.Parameters.AddWithValue("@ContactPhone", phoneNumber)
                    End If

                    If Not String.IsNullOrEmpty(email) Then
                        queryBuilder.Append("AND contact_email = @ContactEmail ")
                        command.Parameters.AddWithValue("@ContactEmail", email)
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
