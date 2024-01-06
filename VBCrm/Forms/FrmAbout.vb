Imports System.Windows.Forms

Public Class FrmAbout
    Private Sub FrmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyDarkModeColorScheme()
    End Sub
    Public Sub SetMessage(messageText As String)
        lblMessage.Text = messageText
    End Sub

    Private Sub lnkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkLbl.LinkClicked
        Dim url As String = "https://www.github.com/CCianfloneDev/VBCrm"

        ' Open the URL in the default browser
        Process.Start(New ProcessStartInfo(url) With {
        .UseShellExecute = True,
        .Verb = "open"
    })
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ApplyDarkModeColorScheme()
        Dim materialSkinManager As MaterialSkinManager = MaterialSkinManager.Instance

        materialSkinManager.AddFormToManage(Me)
        materialSkinManager.Theme = MaterialSkinManager.Themes.DARK

        materialSkinManager.ColorScheme = New ColorScheme(
            Primary.Teal500, Primary.Teal700, Primary.Teal200,
            Accent.Yellow200, TextShade.WHITE
        )
    End Sub


End Class