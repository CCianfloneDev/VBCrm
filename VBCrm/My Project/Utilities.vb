Imports MaterialSkin.Controls
Imports System.Reflection
Imports System.Text
Imports System.Environment

Module Utilities
    Public Sub ApplyDarkModeColorScheme(dgv As DataGridView, frm As MaterialForm)
        Dim materialSkinManager As MaterialSkinManager = MaterialSkinManager.Instance

        materialSkinManager.AddFormToManage(frm)
        materialSkinManager.Theme = MaterialSkinManager.Themes.DARK

        materialSkinManager.ColorScheme = New ColorScheme(
            Primary.Teal500, Primary.Teal700, Primary.Teal200,
            Accent.Yellow200, TextShade.WHITE
        )

        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine

        Dim menuItemTextColor As Color = Color.Black

        frm.MainMenuStrip.ForeColor = menuItemTextColor
    End Sub

    Public Sub ApplyLightModeColorScheme(dgv As DataGridView, frm As MaterialForm)
        Dim materialSkinManager As MaterialSkinManager = MaterialSkinManager.Instance

        materialSkinManager.AddFormToManage(frm)
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT

        materialSkinManager.ColorScheme = New ColorScheme(
            Primary.Blue600, Primary.Blue700, Primary.Blue500,
            Accent.LightBlue200, TextShade.WHITE
        )

        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue

        Dim menuItemTextColor As Color = Color.Black
        Dim subMenuItemBackColor As Color = Color.White

        frm.MainMenuStrip.ForeColor = menuItemTextColor
        frm.MainMenuStrip.BackColor = subMenuItemBackColor
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

    Public Sub ShowAboutForm()
        Dim customDialog As New FrmAbout()
        customDialog.SetMessage(GetAppInfo())
        customDialog.ShowDialog()
    End Sub
End Module
