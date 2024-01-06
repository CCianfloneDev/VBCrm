Imports System.Reflection.Emit
Imports System.Windows.Forms

Public Class FrmAbout

    Public Property Theme As Themes
    Private Sub FrmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyColorScheme(frm:=Me, theme:=Theme)
        lnkLbl.Font = New Font(lnkLbl.Font.FontFamily, 16, lnkLbl.Font.Style)
    End Sub
    Public Sub SetMessage(messageText As String)
        lblMessage.Text = messageText
    End Sub

    Private Sub lnkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkLbl.LinkClicked
        Dim url As String = "https://www.github.com/CCianfloneDev/VBCrm"

        Process.Start(New ProcessStartInfo(url) With {
        .UseShellExecute = True,
        .Verb = "open"
    })
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


End Class