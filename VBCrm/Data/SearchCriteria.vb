''' <summary>
''' Represents the criteria used to search for contacts within the CRM system.
''' </summary>
Public Class SearchCriteria

    ''' <summary>
    ''' Gets or sets the name of the contact to search for.
    ''' </summary>
    Public Property Name As String

    ''' <summary>
    ''' Gets or sets the email address of the contact to search for.
    ''' </summary>
    Public Property Email As String

    ''' <summary>
    ''' Gets or sets the phone number of the contact to search for.
    ''' </summary>
    Public Property PhoneNumber As String

    ''' <summary>
    ''' Gets or sets the job title of the contact to search for.
    ''' </summary>
    Public Property JobTitle As String

    ''' <summary>
    ''' Gets or sets any additional notes related to the contact.
    ''' </summary>
    Public Property Notes As String

    ''' <summary>
    ''' Gets or sets the unique identifier of the contact.
    ''' </summary>
    Public Property Id As String

    ''' <summary>
    ''' Gets or sets the contact's address.
    ''' </summary>
    Public Property Address As String

    ''' <summary>
    ''' Gets or sets the contact's company.
    ''' </summary>
    Public Property Company As String

    ''' <summary>
    ''' Gets or sets the contact's date of birth.
    ''' </summary>
    Public Property DateOfBirth As String
End Class
