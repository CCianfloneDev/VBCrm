Imports System.Data.SQLite

Public Class FrmCreateEdit
    Private dbOperations As New DbOperations()

    Public Property Contact As Contact

    Public Property IsNewRecord As Boolean = False

    ''' <summary>
    ''' Handles the main form load event.
    ''' </summary>
    Private Sub FrmCreateEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyDarkModeColorScheme()
        'ApplyLightModeColorScheme()

        If IsNewRecord Then
            Return
        End If

        With Contact
            txtName.Text = .ContactName
            txtEmail.Text = .ContactEmail
            txtPhoneNumber.Text = .ContactPhone
        End With
    End Sub

    ''' <summary>
    ''' Handles the main form closing event.
    ''' </summary>
    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        dbOperations.CloseConnection()
    End Sub

    Private Sub ApplyDarkModeColorScheme()
        ' Create a MaterialSkinManager instance
        Dim materialSkinManager As MaterialSkinManager = MaterialSkinManager.Instance

        ' Set the color scheme for dark mode
        materialSkinManager.AddFormToManage(Me)
        materialSkinManager.Theme = MaterialSkinManager.Themes.DARK ' Set theme to DARK

        ' Define primary and accent colors for dark mode
        materialSkinManager.ColorScheme = New ColorScheme(
            Primary.Teal500, Primary.Teal700, Primary.Teal200,
            Accent.Yellow200, TextShade.WHITE
        )
    End Sub

    Private Sub ApplyLightModeColorScheme()
        ' Create a MaterialSkinManager instance
        Dim materialSkinManager As MaterialSkinManager = MaterialSkinManager.Instance

        ' Set the color scheme for light mode
        materialSkinManager.AddFormToManage(Me)
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT ' Set theme to LIGHT

        ' Define primary and accent colors for light mode
        materialSkinManager.ColorScheme = New ColorScheme(
            Primary.Blue600, Primary.Blue700, Primary.Blue500,
            Accent.LightBlue200, TextShade.WHITE
        )
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim contactName As String = txtName.Text.Trim()
        Dim phoneNumber As String = txtPhoneNumber.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()

        If String.IsNullOrEmpty(contactName) Then
            MessageBox.Show("Please fill in a name.", "Name required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            If IsNewRecord Then
                If dbOperations.CreateContact(contactName, phoneNumber, email) Then
                    MessageBox.Show("Contact created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed to create contact.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                If dbOperations.UpdateContact(Contact.ContactId, contactName, phoneNumber, email) Then
                    MessageBox.Show("Contact saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed to save contact.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving/creating the contact: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class