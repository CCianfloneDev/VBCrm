Imports MaterialSkin.Controls
Imports System.Reflection
Imports System.Text
Imports System.Environment

Public Enum Themes
    DarkModeGreen
    DarkModePurple
    LightModeBlue
    LightModeGreen
End Enum

Module Utilities

    Public Sub ApplyColorScheme(frm As MaterialForm, theme As Themes)
        Dim materialSkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        materialSkinManager.AddFormToManage(frm)

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
                Accent.Lime200, TextShade.BLACK
                )
        End Select

        frm.Refresh()

        'If frm.MainMenuStrip IsNot Nothing Then
        '    frm.MainMenuStrip.ForeColor = Color.Black
        'End If
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

    Public Sub ShowAboutForm(theme As Themes)
        Dim aboutFrm As New FrmAbout With {
            .Theme = theme
        }
        aboutFrm.SetMessage(GetAppInfo())
        aboutFrm.ShowDialog()
    End Sub
End Module
