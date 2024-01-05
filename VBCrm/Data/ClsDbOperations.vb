Imports System.Data.SQLite

''' <summary>
''' Class responsible for handling database operations.
''' </summary>
Public Class ClsDbOperations
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
End Class
