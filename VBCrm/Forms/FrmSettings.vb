Imports System.Data.Common
Imports MaterialSkin.Controls

''' <summary>
''' Represents the grid settings form.
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
    ''' Handles the about form load event.
    ''' </summary>
    Private Sub FrmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            For Each control As Control In FrmMain.pnlSearchCriteria.Controls
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
            Dim columnIndex As Integer = GetColumnByDataPropertyName(checkBox.Name, ColumnCollection).DisplayIndex

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

            For Each labelTextBoxPair As Control In FrmMain.pnlSearchCriteria.Controls
                If labelTextBoxPair.Tag IsNot Nothing Then
                    If labelTextBoxPair.Tag.ToString() = checkBox.Tag.ToString() Then
                        labelTextBoxPair.Visible = checkBox.Checked
                    End If
                End If
            Next
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
#End Region

End Class