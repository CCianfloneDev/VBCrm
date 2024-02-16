Imports System.Data.Common
Imports MaterialSkin.Controls

''' <summary>
''' Represents the errors form.
''' </summary>
Public Class FrmErrors

#Region "Properties"

    ''' <summary>
    ''' Represents the current theme.
    ''' </summary>
    ''' <returns>Theme.</returns>
    Public Property Theme As Themes

    ''' <summary>
    ''' Error logs.
    ''' </summary>
    ''' <returns>Error logs passed from the database.</returns>
    Public Property Errors As String

#End Region

#Region "Events"

#Region "Form events"
    ''' <summary>
    ''' Handles the about form load event.
    ''' </summary>
    Private Sub FrmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ApplyColorScheme(form:=Me, theme:=Theme)

            txtErrors.Text = Errors
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message} {ex.StackTrace}"
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
            Close()
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message} {ex.StackTrace}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the delete button click event.
    ''' </summary>
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Utilities.DbOperations.DeleteAllLogs()
            txtErrors.Text = ""
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