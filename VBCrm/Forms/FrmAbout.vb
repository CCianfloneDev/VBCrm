''' <summary>
''' Represents the about form.
''' </summary>
Public Class FrmAbout

#Region "Properties"

    ''' <summary>
    ''' Represents the current theme.
    ''' </summary>
    ''' <returns>Theme.</returns>
    Public Property Theme As Themes

#End Region

#Region "Events"

#Region "Form events"
    ''' <summary>
    ''' Handles the about form load event.
    ''' </summary>
    Private Sub FrmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ApplyColorScheme(form:=Me, theme:=Theme)
            lnkLbl.Font = New Font(lnkLbl.Font.FontFamily, 16, lnkLbl.Font.Style)
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Button events"
    ''' <summary>
    ''' Handles the close button click event.
    ''' </summary>
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Link events"
    ''' <summary>
    ''' Handles the link label link clicked event.
    ''' </summary>
    Private Sub LnkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkLbl.LinkClicked
        Try
            Dim url As String = "https://www.github.com/CCianfloneDev/VBCrm"

            Process.Start(New ProcessStartInfo(url) With {
                .UseShellExecute = True,
                .Verb = "open"
            })
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#End Region

#Region "Functions and subs"
    ''' <summary>
    ''' Sets the about message of the form using the about text.
    ''' </summary>
    ''' <param name="messageText"></param>
    Public Sub SetMessage(messageText As String)
        lblMessage.Text = messageText
    End Sub
#End Region

End Class