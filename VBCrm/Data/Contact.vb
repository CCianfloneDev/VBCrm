''' <summary>
''' Represents a Contact.
''' </summary>
Public Class Contact

    ''' <summary>
    ''' Represents the unique ID of the contact.
    ''' </summary>
    ''' <returns>Contact ID.</returns>
    Public Property ContactId As Integer

    ''' <summary>
    ''' Represents the name of the contact.
    ''' </summary>
    ''' <returns>Contact name.</returns>
    Public Property ContactName As String

    ''' <summary>
    ''' Represents the phone number of the contact.
    ''' </summary>
    ''' <returns>Phone number.</returns>
    Public Property ContactPhone As String

    ''' <summary>
    ''' Represents the email of the contact.
    ''' </summary>
    ''' <returns>Email of contact.</returns>
    Public Property ContactEmail As String

    ''' <summary>
    ''' Represents the address of the contact.
    ''' </summary>
    ''' <returns>Contact address.</returns>
    Public Property ContactAddress As String

    ''' <summary>
    ''' Represents the company of the contact.
    ''' </summary>
    ''' <returns>Contact company.</returns>
    Public Property ContactCompany As String

    ''' <summary>
    ''' Represents the job title of the contact.
    ''' </summary>
    ''' <returns>Contact job title.</returns>
    Public Property ContactJobTitle As String

    ''' <summary>
    ''' Represents the date of birth of the contact.
    ''' </summary>
    ''' <returns>Contact date of birth.</returns>
    Public Property ContactDateOfBirth As Date?

    ''' <summary>
    ''' Represents the notes or additional information about the contact.
    ''' </summary>
    ''' <returns>Contact notes.</returns>
    Public Property ContactNotes As String
End Class
