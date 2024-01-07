''' <summary>
''' Represents the main form.
''' </summary>
Public Class FrmMain

#Region "Properties"
    ''' <summary>
    ''' Represents the currently selected Theme.
    ''' </summary>
    ''' <returns>Color theme.</returns>
    Private Property CurrentTheme As Themes
#End Region

#Region "Events"

#Region "Form events"
    ''' <summary>
    ''' Handles the main form load event.
    ''' </summary>
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Utilities.DbOperations = New DbOperations()

            ' will default to dark mode purple if not set
            CurrentTheme = Utilities.DbOperations.GetSelectedTheme()
            ApplyColorScheme(frm:=Me, theme:=CurrentTheme)

            btnSearch.PerformClick()
            dgvResults.ClearSelection()
        Catch ex As Exception
            Dim errorMessage As String = $"Error in {Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message}"
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the main form closing event.
    ''' </summary>
    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Utilities.DbOperations.CloseConnection()
        Catch ex As Exception
            Dim errorMessage As String = $"Error in {Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message}"
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Menu events"
    ''' <summary>
    ''' Handles the exit menu item click event.
    ''' </summary>
    Private Sub MnuItmExit_Click(sender As Object, e As EventArgs) Handles mnuItmExit.Click
        Try
            Me.Close()
        Catch ex As Exception
            Dim errorMessage As String = $"Error in {Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message}"
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the about menu item click event.
    ''' </summary>
    Private Sub MnuItmAbout_Click(sender As Object, e As EventArgs) Handles mnuItmAbout.Click
        Try
            ShowAboutForm(CurrentTheme)
            ApplyColorScheme(frm:=Me, CurrentTheme)
        Catch ex As Exception
            Dim errorMessage As String = $"Error in {Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message}"
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the attached theme setting menu item click events.
    ''' </summary>
    Private Sub ThemeMenuItem_Click(sender As Object, e As EventArgs) Handles mnuItmDarkModeGreen.Click, mnuItmDarkModePurple.Click, mnuItmLightModeBlue.Click, mnuItmLightModeGreen.Click
        Try
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
        Catch ex As Exception
            Dim errorMessage As String = $"Error in {Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message}"
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the context menu export grid click event.
    ''' </summary>
    Private Sub CMnuExport_Click(sender As Object, e As EventArgs) Handles cMnuExport.Click
        Try
            ExportDataGridViewToCSV(dgvResults)
        Catch ex As Exception
            Dim errorMessage As String = $"Error in {Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message}"
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Grid events"

    ''' <summary>
    ''' Handles the results grid cell double click event.
    ''' </summary>
    Private Sub DgvResults_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResults.CellDoubleClick
        Try
            btnEdit.PerformClick()
        Catch ex As Exception
            Dim errorMessage As String = $"Error in {Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message}"
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Button events"

    ''' <summary>
    ''' Handles the search button click event.
    ''' </summary>
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim name As String = txtName.Text.Trim()
            Dim phoneNumber As String = txtPhoneNumber.Text.Trim()
            Dim email As String = txtEmail.Text.Trim()

            Dim dataTable As DataTable = Utilities.DbOperations.SearchContacts(name, phoneNumber, email)

            dgvResults.DataSource = dataTable
            dgvResults.DefaultCellStyle.ForeColor = Color.Black
        Catch ex As Exception
            Dim errorMessage As String = $"Error in {Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message}"
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the new button click event.
    ''' </summary>
    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Try
            Dim createForm As New FrmCreateEdit With {
                .IsNewRecord = True,
                .Theme = CurrentTheme
            }

            createForm.ShowDialog(Me)
            btnSearch.PerformClick()
        Catch ex As Exception
            Dim errorMessage As String = $"Error in {Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message}"
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the edit button click event.
    ''' </summary>
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
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
        Catch ex As Exception
            Dim errorMessage As String = $"Error in {Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message}"
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the clear button click event.
    ''' </summary>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            ClearFormControls(Me)
        Catch ex As Exception
            Dim errorMessage As String = $"Error in {Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message}"
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Textbox events"

#End Region

#Region "Generic events"
    ''' <summary>
    ''' Handles the attached search textboxs key down event.
    ''' </summary>
    ''' <remarks>Presses the search button if they pressed enter in the control.</remarks>
    Private Sub SearchFields_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown, txtName.KeyDown, txtPhoneNumber.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                btnSearch.PerformClick()
            End If
        Catch ex As Exception
            Dim errorMessage As String = $"Error in {Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message}"
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#End Region

#Region "Functions and subs"

#End Region

End Class
