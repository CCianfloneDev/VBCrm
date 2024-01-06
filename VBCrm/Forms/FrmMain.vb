Imports System.Reflection

Imports System.Text
Imports System.Environment
Imports MaterialSkin.Controls

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

        btnSearch.PerformClick()
        dgvResults.ClearSelection()

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

#Region "Menu events"
    Private Sub MnuItmExit_Click(sender As Object, e As EventArgs) Handles mnuItmExit.Click
        Me.Close()
    End Sub

    Private Sub MnuItmAbout_Click(sender As Object, e As EventArgs) Handles mnuItmAbout.Click
        ShowAboutForm()
    End Sub
#End Region

#Region "Grid events"
    Private Sub dgvResults_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResults.CellDoubleClick
        btnEdit.PerformClick()
    End Sub

#End Region

#Region "Button events"


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim name As String = txtName.Text.Trim()
        Dim phoneNumber As String = txtPhoneNumber.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()

        Try
            Dim dataTable As DataTable = dbOperations.SearchContacts(name, phoneNumber, email)
            dgvResults.DataSource = dataTable

            dgvResults.DefaultCellStyle.ForeColor = Color.Black
        Catch ex As Exception
            MessageBox.Show(Me, "An error occurred while searching contacts: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim createForm As New FrmCreateEdit With {
            .IsNewRecord = True
        }

        createForm.ShowDialog(Me)
        btnSearch.PerformClick()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvResults.SelectedRows.Count <= 0 Then
            MessageBox.Show(Me, "Please select a Contact to edit...",
                            My.Application.Info.Title & " - No Contact selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvResults.SelectedRows(0)

        Dim contact As New Contact With {
            .ContactId = CInt(selectedRow.Cells(colId.Index).Value.ToString().Trim()),
            .ContactName = selectedRow.Cells(colName.Index).Value.ToString().Trim(),
            .ContactPhone = selectedRow.Cells(colPhone.Index).Value.ToString().Trim(),
            .ContactEmail = selectedRow.Cells(colEmail.Index).Value.ToString().Trim()
        }

        Dim editForm As New FrmCreateEdit With {
            .Contact = contact,
            .IsNewRecord = False
        }

        editForm.ShowDialog(Me)
        btnSearch.PerformClick()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFormControls(Me)
    End Sub
#End Region

#Region "Textbox events"
    Private Sub txtPhoneNumber_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown, txtName.KeyDown, txtPhoneNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch.PerformClick()
        End If
    End Sub
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

    Public Sub ClearFormControls(container As Control)
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is MaterialTextBox Then
                DirectCast(ctrl, MaterialTextBox).Clear()
            ElseIf TypeOf ctrl Is ComboBox Then
                DirectCast(ctrl, ComboBox).SelectedIndex = -1
            ElseIf TypeOf ctrl Is DataGridView Then
                DirectCast(ctrl, DataGridView).DataSource = Nothing
            ElseIf TypeOf ctrl Is GroupBox OrElse TypeOf ctrl Is Panel Then
                ' Recursively clear controls inside GroupBox or Panel
                ClearFormControls(ctrl)
            End If
        Next
    End Sub
    Public Function GetAppInfo() As String
        Dim assembly As Assembly = Assembly.GetExecutingAssembly()
        Dim version As Version = assembly.GetName().Version
        Dim title As String = assembly.GetCustomAttributes(GetType(AssemblyTitleAttribute), False).OfType(Of AssemblyTitleAttribute)().FirstOrDefault()?.Title
        Dim description As String = assembly.GetCustomAttributes(GetType(AssemblyDescriptionAttribute), False).OfType(Of AssemblyDescriptionAttribute)().FirstOrDefault()?.Description
        Dim companyName As String = assembly.GetCustomAttributes(GetType(AssemblyCompanyAttribute), False).OfType(Of AssemblyCompanyAttribute)().FirstOrDefault()?.Company

        Dim appInfo As New StringBuilder()
        appInfo.AppendLine($"Application Title: {title}{NewLine}")
        appInfo.AppendLine($"Version: {version}{NewLine}")
        appInfo.AppendLine($"Description: {description}{NewLine}")
        appInfo.AppendLine($"Made by: {companyName}{NewLine}")

        Return appInfo.ToString()
    End Function

    Private Sub ShowAboutForm()
        Dim customDialog As New FrmAbout()
        customDialog.SetMessage(GetAppInfo())
        customDialog.ShowDialog()
    End Sub


#End Region



End Class
