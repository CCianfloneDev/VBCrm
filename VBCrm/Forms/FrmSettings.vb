Imports System.Data.Common
Imports MaterialSkin.Controls

''' <summary>
''' Represents the settings form.
''' </summary>
Public Class FrmSettings

#Region "Properties"

    ''' <summary>
    ''' Represents the current theme.
    ''' </summary>
    ''' <returns>Theme.</returns>
    Public Property Theme As Themes

    ''' <summary>
    ''' Collection of columns to base grid settings on.
    ''' </summary>
    ''' <returns>Collection of datagridviewcolumns on the main form.</returns>
    Public Property ColumnCollection As DataGridViewColumnCollection

#End Region

#Region "Events"

#Region "Form events"
    ''' <summary>
    ''' Handles the settings form load event.
    ''' </summary>
    Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ApplyColorScheme(form:=Me, theme:=Theme)

            ' dynamically make checkboxes for each column
            For Each column As DataGridViewColumn In ColumnCollection
                Dim checkBox As New MaterialCheckbox With {
                    .Text = column.HeaderText,
                    .Checked = column.Visible,
                    .Tag = column.Name,
                    .Dock = DockStyle.Top,
                    .AutoSize = True,
                    .Name = column.DataPropertyName
                }
                AddHandler checkBox.CheckedChanged, AddressOf GridSettingCheckBox_CheckedChanged
                pnlGridSettings.Controls.Add(checkBox)
            Next

            ' dynamically make checkboxes for each search field
            For Each panel As Control In FrmMain.tbplSearchCriteria.Controls
                If panel.GetType() Is GetType(Panel) Then
                    For Each control As Control In panel.Controls
                        If control.GetType() Is GetType(MaterialTextBox) Then
                            Dim checkBox As New MaterialCheckbox With {
                                .Text = control.Tag.ToString(),
                                .Checked = control.Visible,
                                .Tag = control.Tag.ToString(),
                                .Dock = DockStyle.Top,
                                .AutoSize = True,
                                .Name = control.Name
                            }
                            AddHandler checkBox.CheckedChanged, AddressOf SearchCriteriaCheckBox_CheckedChanged
                            pnlSearchCriteria.Controls.Add(checkBox)
                        End If
                    Next
                End If
            Next

            lblGridSettings.Select()
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Checkbox events"
    ''' <summary>
    ''' Handles the grid checked changed event.
    ''' </summary>
    Private Sub GridSettingCheckBox_CheckedChanged(sender As Object, e As EventArgs)
        Try
            Dim checkBox As MaterialCheckbox = CType(sender, MaterialCheckbox)
            Dim columnIndex As Integer = GetColumnByDataPropertyName(checkBox.Name, ColumnCollection).Index

            GetColumnByDataPropertyName(checkBox.Name, ColumnCollection).Visible = checkBox.Checked
            Utilities.DbOperations.UpdateColumnVisibility(GetColumnByDataPropertyName(checkBox.Name, ColumnCollection).DataPropertyName, isVisible:=checkBox.Checked)

            ' set the column to be visible
            FrmMain.dgvResults.Columns(columnIndex).Visible = checkBox.Checked

            SetLastVisibleColumnToFill(FrmMain.dgvResults)
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the search criteria checkbox checked changed event.
    ''' </summary>
    Private Sub SearchCriteriaCheckBox_CheckedChanged(sender As Object, e As EventArgs)
        Try
            Dim checkBox As MaterialCheckbox = CType(sender, MaterialCheckbox)

            Utilities.DbOperations.UpdateSearchFieldVisibility(checkBox.Tag.ToString(), isVisible:=checkBox.Checked)

            For Each panel As Control In FrmMain.tbplSearchCriteria.Controls
                If panel.GetType() Is GetType(Panel) Then
                    For Each control As Control In panel.Controls
                        If control.Tag IsNot Nothing Then
                            If control.Tag.ToString() = checkBox.Tag.ToString() Then
                                control.Visible = checkBox.Checked
                                panel.Visible = checkBox.Checked
                            End If
                        End If
                    Next
                End If
            Next

            'ArrangeControlsInTableLayoutPanel(FrmMain.tbplSearchCriteria)

        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region
#End Region

#Region "Functions and subs"

    ''' <summary>
    ''' Retrieves a DataGridViewColumn by its DataPropertyName.
    ''' </summary>
    ''' <param name="dataPropertyName">The DataPropertyName of the column to find.</param>
    ''' <param name="columns">The collection of DataGridViewColumns to search in.</param>
    ''' <returns>The DataGridViewColumn with the specified DataPropertyName, or Nothing if not found.</returns>
    Private Function GetColumnByDataPropertyName(dataPropertyName As String, columns As DataGridViewColumnCollection) As DataGridViewColumn
        For Each column As DataGridViewColumn In columns
            If column.DataPropertyName = dataPropertyName Then
                Return column
            End If
        Next

        Return Nothing
    End Function

    ''' <summary>
    ''' Handles the collapse button(s) click event.
    ''' </summary>
    Private Sub BtnCollapse_Click(sender As Object, e As EventArgs) Handles btnGridSettingsCollapse.Click, btnSearchFieldsCollapse.Click
        Try
            Dim collapseExpandButton As Button = CType(sender, Button)
            Dim settingsPanel As Panel = GetPanel(collapseExpandButton)
            Dim expanded As Boolean = Not settingsPanel.Visible

            settingsPanel.Visible = Not settingsPanel.Visible

            If expanded Then
                collapseExpandButton.Text = "Collapse"
            Else
                collapseExpandButton.Text = "Expand"
            End If
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Gets the settings panel associated with the passed collapsable button.
    ''' </summary>
    ''' <param name="collapseExpandButton">Collapsable button to get panel beside.</param>
    ''' <returns>Panel that belongs to the passed button.</returns>
    Private Function GetPanel(collapseExpandButton As Button) As Panel
        If collapseExpandButton Is btnGridSettingsCollapse Then
            Return pnlGridSettings
        ElseIf collapseExpandButton Is btnSearchFieldsCollapse Then
            Return pnlSearchCriteria
        Else
            Return Nothing
        End If
    End Function

#End Region

End Class