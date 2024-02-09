Imports System.Data.Common
Imports MaterialSkin.Controls

''' <summary>
''' Represents the grid settings form.
''' </summary>
Public Class FrmGridSettings

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
                AddHandler checkBox.CheckedChanged, AddressOf CheckBox_CheckedChanged
                pnlBody.Controls.Add(checkBox)

                lblSettings.Select()
            Next
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Button events"
    ''' <summary>
    ''' Handles the close button click event.
    ''' </summary>
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Try
            Close()
        Catch ex As Exception
            Dim errorMessage As String = $"{Reflection.MethodBase.GetCurrentMethod().Name}: {ex.Message}"
            Utilities.DbOperations.InsertErrorLog(errorMessage)
            MessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Checkbox events"
    ''' <summary>
    ''' Handles the checkbox checked changed event.
    ''' </summary>
    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs)
        Try
            Dim checkBox As MaterialCheckbox = CType(sender, MaterialCheckbox)
            Dim columnIndex As Integer = GetColumnByDataPropertyName(checkBox.Name, ColumnCollection).DisplayIndex

            GetColumnByDataPropertyName(checkBox.Name, ColumnCollection).Visible = checkBox.Checked
            Utilities.DbOperations.UpdateColumnVisibility(GetColumnByDataPropertyName(checkBox.Name, ColumnCollection).DataPropertyName, isVisible:=checkBox.Checked)

            FrmMain.dgvResults.Columns(columnIndex).Visible = checkBox.Checked
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