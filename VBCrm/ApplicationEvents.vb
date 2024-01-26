Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Environment

Namespace My

    ''' <summary>
    ''' Represents the application.
    ''' </summary>
    Partial Friend Class MyApplication

        ''' <summary>
        ''' Handles any unhandled exceptions thrown by the application.
        ''' </summary>
        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            MessageBox.Show($"Unhandled error, contact developer with screenshot and steps of what you did please.{NewLine}{NewLine}{e.Exception.Message}", "VBCRM - Unhandled error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub

    End Class
End Namespace
