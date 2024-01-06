''' <summary>
''' Represents the main form.
''' </summary>
Public Class FrmMain
    Private Property CurrentTheme As Themes

#Region "Events"

#Region "Form events"
    ''' <summary>
    ''' Handles the main form load event.
    ''' </summary>
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Utilities.DbOperations = New DbOperations()

        ' will default to dark mode - purple if not set
        CurrentTheme = Utilities.DbOperations.GetSelectedTheme()
        ApplyColorScheme(frm:=Me, CurrentTheme)

        btnSearch.PerformClick()
        dgvResults.ClearSelection()
    End Sub

    ''' <summary>
    ''' Handles the main form closing event.
    ''' </summary>
    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Utilities.DbOperations.CloseConnection()
    End Sub
#End Region

#Region "Menu events"
    Private Sub MnuItmExit_Click(sender As Object, e As EventArgs) Handles mnuItmExit.Click
        Me.Close()
    End Sub

    Private Sub MnuItmAbout_Click(sender As Object, e As EventArgs) Handles mnuItmAbout.Click
        ShowAboutForm(CurrentTheme)
        ApplyColorScheme(frm:=Me, CurrentTheme)
    End Sub

    Private Sub ThemeMenuItem_Click(sender As Object, e As EventArgs) Handles mnuItmDarkModeGreen.Click, mnuItmDarkModePurple.Click, mnuItmLightModeBlue.Click, mnuItmLightModeGreen.Click
        Dim selectedTheme As Themes = Themes.DarkModePurple
        Dim menuItem = DirectCast(sender, ToolStripMenuItem)

        Select Case menuItem.Name
            Case "mnuItmDarkModePurple"
                selectedTheme = Themes.DarkModePurple
            Case "mnuItmDarkModeGreen"
                selectedTheme = Themes.DarkModeGreen
            Case "mnuItmLightModeBlue"
                selectedTheme = Themes.LightModeBlue
            Case "mnuItmLightModeGreen"
                selectedTheme = Themes.LightModeGreen
        End Select

        ApplyColorScheme(Me, selectedTheme)
        CurrentTheme = selectedTheme
    End Sub

#End Region

#Region "Grid events"
    Private Sub DgvResults_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResults.CellDoubleClick
        btnEdit.PerformClick()
    End Sub

#End Region

#Region "Button events"


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim name As String = txtName.Text.Trim()
        Dim phoneNumber As String = txtPhoneNumber.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()

        Try
            Dim dataTable As DataTable = Utilities.DbOperations.SearchContacts(name, phoneNumber, email)
            dgvResults.DataSource = dataTable

            dgvResults.DefaultCellStyle.ForeColor = Color.Black
        Catch ex As Exception
            MessageBox.Show(Me, "An error occurred while searching contacts: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim createForm As New FrmCreateEdit With {
            .IsNewRecord = True,
            .Theme = CurrentTheme
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
            .IsNewRecord = False,
            .Theme = CurrentTheme
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



#End Region



End Class
