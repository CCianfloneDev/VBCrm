''' <summary>
''' Represents the main form.
''' </summary>
Public Class FrmMain
    Private dbOperations As DbOperations

#Region "Events"

#Region "Form events"
    ''' <summary>
    ''' Handles the main form load event.
    ''' </summary>
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbOperations = New DbOperations()
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
#End Region

#Region "Grid events"

#End Region

#Region "Button events"


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim name As String = txtName.Text.Trim()
        Dim phoneNumber As String = txtPhoneNumber.Text.Trim()
        Dim email As String

        Try
            Dim dataTable As DataTable = dbOperations.SearchContacts(name, phoneNumber)
            dgvResults.DataSource = dataTable

            dgvResults.DefaultCellStyle.ForeColor = Color.Black
        Catch ex As Exception
            MessageBox.Show("An error occurred while searching contacts: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim createForm As New FrmCreateEdit With {
            .IsNewRecord = True
        }

        createForm.ShowDialog(Me)
        btnSearch.PerformClick()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim contact As New Contact
        Dim createForm As New FrmCreateEdit

        createForm.Contact = contact
    End Sub
#End Region

#Region "Textbox events"

#End Region

#End Region

#Region "Functions and subs"
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



#End Region



End Class
