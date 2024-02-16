Imports System.Data.Common
Imports System.Environment
Imports System.Reflection
Imports MaterialSkin.Controls

''' <summary>
''' Represents the main form.
''' </summary>
Public Class FrmMain

    ''' <summary>
    ''' Indicates if the menu bar is expanded or not.
    ''' </summary>
    ''' <returns>True if the user has clicked the "hamburger icon" and the menu bar is open.</returns>
    Public Property IsMenuExpanded As Boolean = False

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

            ' will default to light mode green if not set
            CurrentTheme = Utilities.DbOperations.GetSelectedTheme()
            ApplyColorScheme(form:=Me, theme:=CurrentTheme)
            SetColumnVisibility()
            SetColumnDisplayIndex()
            SetLastVisibleColumnToFill(dgvResults)
            SetSearchFieldVisibility()
            'ArrangeControlsInTableLayoutPanel(tbplSearchCriteria)

            btnSearch.PerformClick()
            dgvResults.ClearSelection()
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message} {ex.StackTrace}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
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
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message} {ex.StackTrace}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Menu events"

    ''' <summary>
    ''' Handles the main menu item click event.
    ''' </summary>
    Private Sub MnuItmMenu_Click(sender As Object, e As EventArgs) Handles mnuItmMenu.Click
        Try
            Dim assembly As Assembly = Assembly.GetExecutingAssembly()
            Dim image As Image

            If Not Me.IsMenuExpanded Then
                Me.IsMenuExpanded = True

                image = New Bitmap(assembly.GetManifestResourceStream("VBCrm.menu-opened.png"))
            Else
                Me.IsMenuExpanded = False

                image = New Bitmap(assembly.GetManifestResourceStream("VBCrm.menu-closed.png"))
            End If

            mnuItmMenu.Image = image

            For Each menuItem As ToolStripItem In mnuMenuStrip.Items
                If menuItem.Name <> mnuItmMenu.Name Then
                    menuItem.Visible = Me.IsMenuExpanded
                End If
            Next
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message} {ex.StackTrace}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the about menu item click event.
    ''' </summary>
    Private Sub MnuItmAbout_Click(sender As Object, e As EventArgs) Handles mnuItmAbout.Click
        Try
            ShowAboutForm(CurrentTheme)
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message} {ex.StackTrace}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
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
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message} {ex.StackTrace}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the context menu and menu item export grid click event.
    ''' </summary>
    Private Sub MenuExport_Click(sender As Object, e As EventArgs) Handles cMnuExport.Click, mnuItmExportData.Click
        Try
            ExportDataGridViewToCSV(dgvResults)
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message} {ex.StackTrace}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the import data menu item click event.
    ''' </summary>
    Private Sub MnuItmImportData_Click(sender As Object, e As EventArgs) Handles mnuItmImportData.Click
        Try
            ImportCSVToDatabase()
            btnSearch.PerformClick()
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message} {ex.StackTrace}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the mass email menu item click event.
    ''' </summary>
    Private Sub MassEmailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuItmMassEmail.Click
        Try
            Dim emailList As List(Of String) = ExtractEmailsFromDataGridView(dgvResults)

            If emailList.Count > 0 Then
                Dim emailAddresses As String = String.Join(";", emailList)
                Dim mailtoLink As String = $"mailto:{emailAddresses}"

                Process.Start(New ProcessStartInfo(mailtoLink) With {
                    .UseShellExecute = True,
                    .Verb = "open"
                })
            Else
                MessageBox.Show(Me, "No emails found in the grid.", "No Emails", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message} {ex.StackTrace}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the create contact menu item click event.
    ''' </summary>
    Private Sub MnuItmCreateContact_Click(sender As Object, e As EventArgs) Handles mnuItmCreateContact.Click
        Try
            btnNew.PerformClick()
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message} {ex.StackTrace}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the edit contact menu item click event.
    ''' </summary>
    Private Sub MnuItmEditContact_Click(sender As Object, e As EventArgs) Handles mnuItmEditContact.Click
        Try
            btnEdit.PerformClick()
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message} {ex.StackTrace}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the delete contact menu item click event.
    ''' </summary>
    Private Sub MnuItmDeleteContact_Click(sender As Object, e As EventArgs) Handles mnuItmDeleteContact.Click
        Try
            btnDelete.PerformClick()
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message} {ex.StackTrace}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the purge data menu item click event.
    ''' </summary>
    Private Sub MnuItmPurgeData_Click(sender As Object, e As EventArgs) Handles mnuItmPurgeData.Click
        Try
            If MessageBox.Show(Me, $"WARNING: This will delete ALL data and cannot be recovered...{NewLine}{NewLine} Would you like to continue?",
                            My.Application.Info.Title & " - Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                Return
            End If

            Utilities.DbOperations.DeleteAllContacts()
            btnSearch.PerformClick()
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message} {ex.StackTrace}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the edit grid menu item click event.
    ''' </summary>
    Private Sub MnuItmEditGrid_Click(sender As Object, e As EventArgs) Handles mnuItmConfigureFields.Click
        Try
            Dim editGridSettingsForm As New FrmSettings With {
                .Theme = CurrentTheme,
                .ColumnCollection = dgvResults.Columns
            }

            editGridSettingsForm.ShowDialog(Me)
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message} {ex.StackTrace}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the view error logs menu item click event.
    ''' </summary>
    Private Sub MnuItemViewErrorLogs_Click(sender As Object, e As EventArgs) Handles mnuItmViewErrorLogs.Click
        Try
            Dim errorsForm As New FrmErrors With {
                .Theme = Me.CurrentTheme,
                .Errors = Utilities.DbOperations.GetAllErrorLogs()
            }

            errorsForm.ShowDialog(Me)
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message} {ex.StackTrace}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
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
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message} {ex.StackTrace}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the column display index changed event.
    ''' </summary>
    Private Sub ColumnDisplayIndexChangedHandler(sender As Object, e As DataGridViewColumnEventArgs) Handles dgvResults.ColumnDisplayIndexChanged
        Try
            Dim columnName As String = e.Column.DataPropertyName
            Dim newIndex As Integer = e.Column.DisplayIndex

            Utilities.DbOperations.UpdateColumnDisplayIndex(columnName, newIndex)
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message} {ex.StackTrace}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
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
            Dim searchCriteria As New SearchCriteria With {
                .Name = txtName.Text.Trim(),
                .Email = txtEmail.Text.Trim(),
                .PhoneNumber = txtPhoneNumber.Text.Trim(),
                .JobTitle = txtJobTitle.Text.Trim(),
                .Notes = txtNotes.Text.Trim(),
                .Id = txtId.Text.Trim(),
                .Address = txtAddress.Text.Trim(),
                .Company = txtCompany.Text.Trim(),
                .DateOfBirth = txtDateOfBirth.Text.Trim()
                }

            Dim dataTable As DataTable = Utilities.DbOperations.SearchContacts(searchCriteria)

            dgvResults.DataSource = dataTable
            dgvResults.DefaultCellStyle.ForeColor = Color.Black
            dgvResults.ClearSelection()
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message} {ex.StackTrace}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
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
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message} {ex.StackTrace}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the edit button click event.
    ''' </summary>
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If dgvResults.SelectedRows.Count <= 0 Then
                MessageBox.Show(Me, "Please select a Contact to edit...", My.Application.Info.Title & " - No Contact selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim selectedRow As DataGridViewRow = dgvResults.SelectedRows(0)

            Dim contact As New Contact With {
                .ContactId = CInt(selectedRow.Cells(colId.Index).Value.ToString().Trim()),
                .ContactName = selectedRow.Cells(colName.Index).Value.ToString().Trim(),
                .ContactPhone = selectedRow.Cells(colPhone.Index).Value.ToString().Trim(),
                .ContactEmail = selectedRow.Cells(colEmail.Index).Value.ToString().Trim(),
                .ContactAddress = selectedRow.Cells(colAddress.Index).Value.ToString().Trim(),
                .ContactCompany = selectedRow.Cells(colCompany.Index).Value.ToString().Trim(),
                .ContactJobTitle = selectedRow.Cells(colJobTitle.Index).Value.ToString().Trim(),
                .ContactDateOfBirth = selectedRow.Cells(colDateOfBirth.Index).Value.ToString().Trim(),
                .ContactNotes = selectedRow.Cells(colNotes.Index).Value.ToString().Trim()
            }

            Dim editForm As New FrmCreateEdit With {
                .Contact = contact,
                .IsNewRecord = False,
                .Theme = CurrentTheme
            }

            editForm.ShowDialog(Me)
            btnSearch.PerformClick()
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
            If dgvResults.SelectedRows.Count <= 0 Then
                MessageBox.Show(Me, "Please select a Contact to delete...", My.Application.Info.Title & " - No Contact selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim selectedRow As DataGridViewRow = dgvResults.SelectedRows(0)

            Utilities.DbOperations.DeleteContactById(CInt(selectedRow.Cells(colId.Index).Value))
            btnSearch.PerformClick()
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message} {ex.StackTrace}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
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
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message} {ex.StackTrace}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
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
    Private Sub SearchFields_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown, txtName.KeyDown, txtPhoneNumber.KeyDown,
    txtJobTitle.KeyDown, txtNotes.KeyDown, txtId.KeyDown, txtAddress.KeyDown, txtCompany.KeyDown, txtDateOfBirth.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                btnSearch.PerformClick()
            End If
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message} {ex.StackTrace}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


#End Region

#End Region

#Region "Functions and subs"

    ''' <summary>
    ''' Sets the column visibility settings saved in the database.
    ''' </summary>
    Private Sub SetColumnVisibility()
        Dim visibilityData As Dictionary(Of String, Boolean) = Utilities.DbOperations.GetColumnVisibility()

        For Each column As DataGridViewColumn In dgvResults.Columns

            Dim value As Boolean = Nothing

            If visibilityData.TryGetValue(column.DataPropertyName, value) Then
                column.Visible = value
            End If
        Next
    End Sub

    ''' <summary>
    ''' Sets the column display index settings saved in the database.
    ''' </summary>
    Private Sub SetColumnDisplayIndex()
        Dim displayIndexData As Dictionary(Of String, Integer) = Utilities.DbOperations.GetColumnDisplayIndex()

        For Each column As DataGridViewColumn In dgvResults.Columns
            Dim displayIndex As Integer = Nothing

            If displayIndexData.TryGetValue(column.DataPropertyName, displayIndex) Then
                column.DisplayIndex = If(displayIndex > 0, displayIndex - 1, 0)
            End If
        Next
    End Sub

    ''' <summary>
    ''' Sets the search field visibility settings saved in the database.
    ''' </summary>
    Private Sub SetSearchFieldVisibility()
        Dim visibilityData As Dictionary(Of String, Boolean) = Utilities.DbOperations.GetSearchFieldVisibility()

        For Each panel As Control In tbplSearchCriteria.Controls
            Debug.Print(panel.Name)
            If panel.GetType() Is GetType(Panel) Then
                For Each control As Control In panel.Controls
                    Debug.Print(control.Name)
                    If control.GetType() Is GetType(MaterialTextBox) OrElse control.GetType() Is GetType(MaterialLabel) Then
                        Dim value As Boolean = Nothing

                        If visibilityData.TryGetValue(control.Tag.ToString(), value) Then
                            control.Visible = value
                            panel.Visible = value
                        End If
                    End If
                Next
            End If
        Next
    End Sub

#End Region

End Class
