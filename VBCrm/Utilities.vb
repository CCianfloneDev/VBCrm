﻿Imports MaterialSkin.Controls
Imports System.Reflection
Imports System.Text
Imports System.Environment
Imports System.IO
Imports Microsoft.VisualBasic.FileIO

''' <summary>
''' Represents the different themes offered in the application.
''' </summary>
Public Enum Themes
    DarkModePurple = 1
    LightModeBlue = 2
    DarkModeGreen = 3
    LightModeGreen = 4
End Enum

''' <summary>
''' Utility functions for various application operations.
''' </summary>
Module Utilities
    Public DbOperations As DbOperations

    ''' <summary>
    ''' Applies the chosen color scheme to the specified form.
    ''' </summary>
    ''' <param name="form">The MaterialForm to which the color scheme will be applied.</param>
    ''' <param name="theme">The chosen theme to be applied.</param>
    Public Sub ApplyColorScheme(form As MaterialForm, theme As Themes)
        Dim materialSkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        materialSkinManager.AddFormToManage(form)

        ' Save the selected theme in the user settings
        DbOperations.UpdateSelectedTheme(CInt(theme))

        Select Case theme
            Case Themes.DarkModePurple
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK
                materialSkinManager.ColorScheme = New ColorScheme(
                Primary.Purple800, Primary.Purple900, Primary.Purple500,
                Accent.DeepPurple200, TextShade.WHITE
                )

            Case Themes.DarkModeGreen
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK
                materialSkinManager.ColorScheme = New ColorScheme(
                Primary.Teal500, Primary.Teal700, Primary.Teal200,
                Accent.Yellow200, TextShade.WHITE
                )
            Case Themes.LightModeBlue
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT
                materialSkinManager.ColorScheme = New ColorScheme(
                Primary.Blue600, Primary.Blue700, Primary.Blue500,
                Accent.LightBlue200, TextShade.WHITE
                )
            Case Themes.LightModeGreen
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT
                materialSkinManager.ColorScheme = New ColorScheme(
                Primary.Green600, Primary.Green700, Primary.Green200,
                Accent.Green400, TextShade.BLACK
                )
        End Select

        form.Refresh()
    End Sub

    ''' <summary>
    ''' Clears all controls within the specified container recursively.
    ''' </summary>
    ''' <param name="container">The Control containing the controls to be cleared.</param>
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

    ''' <summary>
    ''' Retrieves the application information.
    ''' </summary>
    ''' <returns>A string containing application information.</returns>
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

    ''' <summary>
    ''' Shows the about form with the specified theme.
    ''' </summary>
    ''' <param name="theme">The theme to be applied to the about form.</param>
    Public Sub ShowAboutForm(theme As Themes)
        Dim aboutFrm As New FrmAbout With {
            .Theme = theme
        }
        aboutFrm.SetMessage(GetAppInfo())
        aboutFrm.ShowDialog()
    End Sub

    ''' <summary>
    ''' Exports the grid data grom the passed datagridview to a .CSV in a location of the users choice.
    ''' </summary>
    ''' <param name="dgv">Datagridview to export.</param>
    Public Sub ExportDataGridViewToCSV(dgv As DataGridView)
        Dim saveFileDialog As New SaveFileDialog With {
            .Filter = "CSV files (*.csv)|*.csv",
            .Title = "Export to CSV"
        }
        saveFileDialog.ShowDialog()

        If saveFileDialog.FileName <> "" Then
            Using streamWriter As New StreamWriter(saveFileDialog.FileName)
                If dgv.DataSource IsNot Nothing AndAlso dgv.RowCount > 0 Then
                    Dim headers As List(Of String) = (From column As DataGridViewColumn In dgv.Columns.Cast(Of DataGridViewColumn)()
                                                      Select CType(dgv.DataSource, DataTable).Columns(column.DataPropertyName).ColumnName).ToList()
                    streamWriter.WriteLine(String.Join(",", headers))
                End If

                For Each row As DataGridViewRow In dgv.Rows
                    For Each cell As DataGridViewCell In row.Cells
                        If cell.Value IsNot Nothing Then
                            streamWriter.Write(cell.Value.ToString())
                        End If

                        ' Check if the current cell is not the last cell in the row
                        If cell.ColumnIndex < row.Cells.Count - 1 Then
                            streamWriter.Write(",")
                        End If
                    Next
                    streamWriter.WriteLine()
                Next
            End Using

            MessageBox.Show("CSV file exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ''' <summary>
    ''' Imports data from a validated CSV file into the database.
    ''' </summary>
    ''' <remarks>
    ''' This function prompts the user to select a CSV file for import. It reads the CSV file, validates that the file has
    ''' the correct column order (ContactId, ContactName, ContactPhone, ContactEmail), processes each record,
    ''' and attempts to add valid records into the SQLite database. The CSV file should contain rows of data with 
    ''' at least a ContactName field. It keeps track of any rows with missing or empty ContactName fields and 
    ''' reports them to the user at the end of the process.
    ''' </remarks>
    Public Sub ImportCSVToDatabase()
        Dim successfulImports As Integer = 0

        ' Prompt user to select a CSV file
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv"
            openFileDialog.Title = "Select a CSV File"
            openFileDialog.Multiselect = False

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim csvPath As String = openFileDialog.FileName

                ' Validate the CSV file's column order
                Dim expectedColumns As String() = {"ContactId", "ContactName", "ContactPhone", "ContactEmail", "ContactAddress", "ContactCompany", "ContactJobTitle", "ContactDateOfBirth", "ContactNotes"}
                Using reader As New StreamReader(csvPath)
                    Dim headers As String = reader.ReadLine()
                    Dim csvColumns = headers.Split(","c).Select(Function(s) s.Trim()).ToArray()

                    For i As Integer = 0 To expectedColumns.Length - 1
                        If csvColumns(i) <> expectedColumns(i) Then
                            MessageBox.Show("Invalid CSV file format. Please ensure the file has the correct column order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If
                    Next
                End Using

                ' Process CSV data
                Dim invalidRows As New List(Of Integer)()
                Using csvReader As New TextFieldParser(csvPath)
                    csvReader.TextFieldType = FieldType.Delimited
                    csvReader.SetDelimiters(",")
                    Dim currentRow As Integer = 0

                    While Not csvReader.EndOfData
                        Dim fields As String() = csvReader.ReadFields()
                        Dim contactName As String = ""
                        Dim phoneNumber As String = ""
                        Dim email As String = ""
                        Dim address As String = ""
                        Dim company As String = ""
                        Dim jobTitle As String = ""
                        Dim dateOfBirth As String = ""
                        Dim notes As String = ""

                        If currentRow > 0 Then ' Skip header row
                            contactName = fields(1).Trim()
                            phoneNumber = fields(2).Trim()
                            email = fields(3).Trim()
                            address = fields(4).Trim()
                            company = fields(5).Trim()
                            jobTitle = fields(6).Trim()
                            dateOfBirth = fields(7).Trim()
                            notes = fields(8).Trim()

                            If String.IsNullOrEmpty(contactName) Then
                                invalidRows.Add(currentRow)
                            Else
                                DbOperations.CreateContact(contactName, phoneNumber, email, address, company, jobTitle, dateOfBirth, notes)
                                successfulImports += 1
                            End If
                        End If

                        currentRow += 1
                    End While
                End Using

                ' Display report on invalid rows
                If invalidRows.Count > 0 Then
                    Dim errorMessage As String = $"The following rows have missing ContactName: {String.Join(", ", invalidRows)}"
                    MessageBox.Show(errorMessage, "Invalid Rows", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show($"Successfully imported {successfulImports} records.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End Using
    End Sub

    ''' <summary>
    ''' Extracts emails from the passed datagridview and provides them in a list of strings.
    ''' </summary>
    ''' <param name="dgv">Datagridview to extract emails from</param>
    ''' <returns>List of emails.</returns>
    Public Function ExtractEmailsFromDataGridView(dgv As DataGridView) As List(Of String)
        Dim emailList As New List(Of String)()

        For Each row As DataGridViewRow In dgv.Rows
            If row.Cells("colEmail").Value.ToString().Trim() <> "" Then
                Dim email As String = row.Cells("colEmail").Value.ToString()
                emailList.Add(email)
            End If
        Next

        Return emailList
    End Function

    ''' <summary>
    ''' Sets the last visible column of a datagridview to be filled and the others to be not set.
    ''' </summary>
    ''' <param name="dgv">Datagridview to apply column settings to.</param>
    Public Sub SetLastVisibleColumnToFill(dgv As DataGridView)
        Dim lastVisibleColumn As DataGridViewColumn = Nothing
        Dim highestDisplayIndex As Integer = Integer.MinValue

        ' Loop through all columns and set its auto size mode to column header autosize mode
        For Each column As DataGridViewColumn In dgv.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            'Debug.Print(column.Name & " - " & column.DisplayIndex & " - " & column.AutoSizeMode)
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        Next

        ' first resize all columns to fit column header
        dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader)


        ' Find the last visible column based on the highest display index
        For Each column As DataGridViewColumn In dgv.Columns
            If column.Visible AndAlso column.DisplayIndex > highestDisplayIndex Then
                highestDisplayIndex = column.DisplayIndex
                lastVisibleColumn = column
            End If
        Next

        ' Set AutoSizeMode of the last visible column to Fill
        If lastVisibleColumn IsNot Nothing Then
            lastVisibleColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End If
    End Sub

End Module
