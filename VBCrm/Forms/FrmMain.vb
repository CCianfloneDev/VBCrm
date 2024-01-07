Imports System.Data.Common
Imports System.Environment
Imports MaterialSkin.Controls

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

            ' will default to light mode green if not set
            CurrentTheme = Utilities.DbOperations.GetSelectedTheme()
            ApplyColorScheme(frm:=Me, theme:=CurrentTheme)
            SetColumnVisibility()
            SetColumnDisplayIndex()

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
    ''' Handles the context menu and menu item export grid click event.
    ''' </summary>
    Private Sub MenuExport_Click(sender As Object, e As EventArgs) Handles cMnuExport.Click, mnuItmExportData.Click
        Try
            ExportDataGridViewToCSV(dgvResults)
        Catch ex As Exception
            Dim errorMessage As String = $"Error in {Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message}"
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
            Dim errorMessage As String = $"Error in {Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message}"
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
            Dim errorMessage As String = $"Error in {Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message}"
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
            Dim errorMessage As String = $"Error in {Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message}"
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
            Dim errorMessage As String = $"Error in {Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message}"
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
            Dim errorMessage As String = $"Error in {Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message}"
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
            Dim errorMessage As String = $"Error in {Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message}"
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the edit grid menu item click event.
    ''' </summary>
    Private Sub MnuItmEditGrid_Click(sender As Object, e As EventArgs) Handles mnuItmEditGrid.Click
        Try
            dgvResults.AllowUserToOrderColumns = True

            Dim settingsPanel As New Panel With {
                .Dock = DockStyle.Top,
                .AutoSize = True
            }

            For Each column As DataGridViewColumn In dgvResults.Columns
                Dim checkBox As New CheckBox With {
                    .Text = column.HeaderText,
                    .Checked = column.Visible
                }

                ' Event handler for checkbox changes
                AddHandler checkBox.CheckedChanged, Sub(chkSender As Object, args As EventArgs)
                                                        column.Visible = checkBox.Checked
                                                        Utilities.DbOperations.UpdateColumnVisibility(column.DataPropertyName, isVisible:=checkBox.Checked)
                                                    End Sub

                checkBox.Top = settingsPanel.Controls.Count * 30 ' Adjust checkbox position
                settingsPanel.Controls.Add(checkBox)
            Next

            Dim closeButton As New MaterialButton
            With closeButton
                .Text = "Close"
                .Left = settingsPanel.Width - closeButton.Width - 10 ' Position the Close button at the top-right corner,
                .Top = 10
                .Cursor = Cursors.Hand
            End With

            settingsPanel.Controls.Add(closeButton)

            ' Event handler for Close button
            AddHandler closeButton.Click, Sub(btnSender As Object, args As EventArgs)
                                              pnlBody.Controls.Remove(settingsPanel)
                                              dgvResults.AllowUserToOrderColumns = False
                                          End Sub

            pnlBody.Controls.Add(settingsPanel)
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

    ''' <summary>
    ''' Handles the column display index changed event.
    ''' </summary>
    Private Sub ColumnDisplayIndexChangedHandler(sender As Object, e As DataGridViewColumnEventArgs) Handles dgvResults.ColumnDisplayIndexChanged
        Try
            Dim columnName As String = e.Column.DataPropertyName
            Dim newIndex As Integer = e.Column.DisplayIndex

            Utilities.DbOperations.UpdateColumnDisplayIndex(columnName, newIndex)
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
            dgvResults.ClearSelection()
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
                MessageBox.Show(Me, "Please select a Contact to edit...", My.Application.Info.Title & " - No Contact selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
    ''' Handles the delete button click event.
    ''' </summary>
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If dgvResults.SelectedRows.Count <= 0 Then
                MessageBox.Show(Me, "Please select a Contact to delete...", My.Application.Info.Title & " - No Contact selected.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim selectedRow As DataGridViewRow = dgvResults.SelectedRows(0)

            Utilities.DbOperations.DeleteContactById(CInt(selectedRow.Cells(colId.Index).Value))
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
#End Region

End Class
