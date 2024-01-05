''' <summary>
''' Represents the main form.
''' </summary>
Public Class FrmMain
    Private dbOperations As ClsDbOperations

    ''' <summary>
    ''' Handles the main form load event.
    ''' </summary>
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbOperations = New ClsDbOperations()
        dbOperations.CreateCustomersTable()

        ' Create a MaterialSkinManager instance
        Dim materialSkinManager As MaterialSkinManager = MaterialSkinManager.Instance

        ' Set the color scheme
        materialSkinManager.AddFormToManage(Me)
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT ' Set theme to LIGHT or DARK

        ' Define primary and accent colors
        materialSkinManager.ColorScheme = New ColorScheme(
            Primary.Blue600, Primary.Blue700, Primary.Blue500,
            Accent.LightBlue200, TextShade.WHITE
        )
    End Sub

    ''' <summary>
    ''' Handles the main form closing event.
    ''' </summary>
    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        dbOperations.CloseConnection()
    End Sub
End Class
