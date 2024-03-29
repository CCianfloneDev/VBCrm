﻿''' <summary>
''' Represents the create edit form.
''' </summary>
Public Class FrmCreateEdit

#Region "Properties"
    ''' <summary>
    ''' Represents a Contact.
    ''' </summary>
    ''' <returns>Contact object holding Cntacts data.</returns>
    Public Property Contact As Contact

    ''' <summary>
    ''' Indicates if the form instance is of a new record to be created.
    ''' </summary>
    ''' <returns>True if it's a new record.</returns>
    Public Property IsNewRecord As Boolean = False

    ''' <summary>
    ''' Represents the theme being used.
    ''' </summary>
    ''' <returns>Theme.</returns>
    Public Property Theme As Themes
#End Region

#Region "Events"

#Region "Forms events"
    ''' <summary>
    ''' Handles the main form load event.
    ''' </summary>
    Private Sub FrmCreateEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ApplyColorScheme(form:=Me, theme:=Theme)

            If IsNewRecord Then
                Return
            End If

            With Contact
                txtName.Text = .ContactName
                txtEmail.Text = .ContactEmail
                txtPhoneNumber.Text = .ContactPhone
                txtAddress.Text = .ContactAddress
                txtCompany.Text = .ContactCompany
                txtJobTitle.Text = .ContactJobTitle
                txtDateOfBirth.Text = .ContactDateOfBirth
                txtNotes.Text = .ContactNotes
            End With
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message} {ex.StackTrace}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the main form closing event.
    ''' </summary>
    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Utilities.DbOperations.CloseConnection()
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message} {ex.StackTrace}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Textbox events"

#End Region

#Region "Button events"
    ''' <summary>
    ''' Handles the save button click event.
    ''' </summary>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim name As String = txtName.Text.Trim()
            Dim phoneNumber As String = txtPhoneNumber.Text.Trim()
            Dim email As String = txtEmail.Text.Trim()
            Dim address As String = txtAddress.Text.Trim()
            Dim company As String = txtCompany.Text.Trim()
            Dim jobTitle As String = txtJobTitle.Text.Trim()
            Dim dateOfBirth As String = txtDateOfBirth.Text.Trim()
            Dim notes As String = txtNotes.Text.Trim()

            If String.IsNullOrEmpty(name) Then
                MessageBox.Show("Please fill in a name.", "Name required", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If IsNewRecord Then
                Utilities.DbOperations.CreateContact(name, phoneNumber, email, address, company, jobTitle, dateOfBirth, notes)
            Else
                Utilities.DbOperations.UpdateContact(Contact.ContactId, name, phoneNumber, email, address, company, jobTitle, dateOfBirth, notes)
            End If

            MessageBox.Show($"Contact {IIf(IsNewRecord, "created", "saved")} successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message} {ex.StackTrace}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the cancel button click event.
    ''' </summary>
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            Me.Close()
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message} {ex.StackTrace}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#End Region

#Region "Functions and subs"

#End Region

End Class