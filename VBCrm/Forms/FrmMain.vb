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

        ApplyDarkModeColorScheme()
        'ApplyLightModeColorScheme()
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

        dgvResults.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine
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

        dgvResults.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue
    End Sub
End Class
