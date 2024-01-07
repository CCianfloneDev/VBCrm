﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        mnuMenuStrip = New MenuStrip()
        mnuItmFile = New ToolStripMenuItem()
        mnuItmExit = New ToolStripMenuItem()
        mnuItmHelp = New ToolStripMenuItem()
        mnuItmAbout = New ToolStripMenuItem()
        mnuItmPreferences = New ToolStripMenuItem()
        mnuItmTheme = New ToolStripMenuItem()
        mnuItmDarkModePurple = New ToolStripMenuItem()
        mnuItmDarkModeGreen = New ToolStripMenuItem()
        mnuItmLightModeBlue = New ToolStripMenuItem()
        mnuItmLightModeGreen = New ToolStripMenuItem()
        mnuItmData = New ToolStripMenuItem()
        mnuItmExportData = New ToolStripMenuItem()
        mnuItmImportData = New ToolStripMenuItem()
        mnuItmPurgeData = New ToolStripMenuItem()
        mnuItmContacts = New ToolStripMenuItem()
        mnuItmMassEmail = New ToolStripMenuItem()
        staStatusStrip = New StatusStrip()
        pnlSearchCriteria = New Panel()
        lblEmail = New Controls.MaterialLabel()
        txtEmail = New Controls.MaterialTextBox()
        lblName = New Controls.MaterialLabel()
        lblPhoneNumber = New Controls.MaterialLabel()
        txtName = New Controls.MaterialTextBox()
        txtPhoneNumber = New Controls.MaterialTextBox()
        btnClear = New Controls.MaterialButton()
        btnSearch = New Controls.MaterialButton()
        pnlBottom = New Panel()
        btnEdit = New Controls.MaterialButton()
        btnNew = New Controls.MaterialButton()
        pnlBody = New Panel()
        dgvResults = New DataGridView()
        colId = New DataGridViewTextBoxColumn()
        colName = New DataGridViewTextBoxColumn()
        colPhone = New DataGridViewTextBoxColumn()
        colEmail = New DataGridViewTextBoxColumn()
        cMnu = New ContextMenuStrip(components)
        cMnuExport = New ToolStripMenuItem()
        ContactBindingSource = New BindingSource(components)
        lblSearchCriteria = New Controls.MaterialLabel()
        mnuMenuStrip.SuspendLayout()
        pnlSearchCriteria.SuspendLayout()
        pnlBottom.SuspendLayout()
        pnlBody.SuspendLayout()
        CType(dgvResults, ComponentModel.ISupportInitialize).BeginInit()
        cMnu.SuspendLayout()
        CType(ContactBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' mnuMenuStrip
        ' 
        mnuMenuStrip.Items.AddRange(New ToolStripItem() {mnuItmFile, mnuItmHelp, mnuItmPreferences, mnuItmData, mnuItmContacts})
        mnuMenuStrip.Location = New Point(3, 64)
        mnuMenuStrip.Name = "mnuMenuStrip"
        mnuMenuStrip.Size = New Size(794, 24)
        mnuMenuStrip.TabIndex = 0
        mnuMenuStrip.Text = "MenuStrip1"
        ' 
        ' mnuItmFile
        ' 
        mnuItmFile.DropDownItems.AddRange(New ToolStripItem() {mnuItmExit})
        mnuItmFile.Name = "mnuItmFile"
        mnuItmFile.ShortcutKeys = Keys.Alt Or Keys.F
        mnuItmFile.Size = New Size(37, 20)
        mnuItmFile.Text = "&File"
        ' 
        ' mnuItmExit
        ' 
        mnuItmExit.Name = "mnuItmExit"
        mnuItmExit.ShortcutKeys = Keys.Alt Or Keys.E
        mnuItmExit.Size = New Size(129, 22)
        mnuItmExit.Text = "&Exit"
        ' 
        ' mnuItmHelp
        ' 
        mnuItmHelp.DropDownItems.AddRange(New ToolStripItem() {mnuItmAbout})
        mnuItmHelp.Name = "mnuItmHelp"
        mnuItmHelp.ShortcutKeys = Keys.Alt Or Keys.H
        mnuItmHelp.Size = New Size(44, 20)
        mnuItmHelp.Text = "&Help"
        ' 
        ' mnuItmAbout
        ' 
        mnuItmAbout.Name = "mnuItmAbout"
        mnuItmAbout.ShortcutKeys = Keys.Alt Or Keys.A
        mnuItmAbout.Size = New Size(145, 22)
        mnuItmAbout.Text = "&About"
        ' 
        ' mnuItmPreferences
        ' 
        mnuItmPreferences.DropDownItems.AddRange(New ToolStripItem() {mnuItmTheme})
        mnuItmPreferences.Name = "mnuItmPreferences"
        mnuItmPreferences.ShortcutKeys = Keys.Alt Or Keys.P
        mnuItmPreferences.Size = New Size(80, 20)
        mnuItmPreferences.Text = "&Preferences"
        ' 
        ' mnuItmTheme
        ' 
        mnuItmTheme.DropDownItems.AddRange(New ToolStripItem() {mnuItmDarkModePurple, mnuItmDarkModeGreen, mnuItmLightModeBlue, mnuItmLightModeGreen})
        mnuItmTheme.Name = "mnuItmTheme"
        mnuItmTheme.ShortcutKeys = Keys.Alt Or Keys.T
        mnuItmTheme.Size = New Size(146, 22)
        mnuItmTheme.Text = "&Theme"
        ' 
        ' mnuItmDarkModePurple
        ' 
        mnuItmDarkModePurple.Name = "mnuItmDarkModePurple"
        mnuItmDarkModePurple.ShortcutKeys = Keys.Alt Or Keys.P
        mnuItmDarkModePurple.Size = New Size(214, 22)
        mnuItmDarkModePurple.Text = "Dark mode - &Purple"
        ' 
        ' mnuItmDarkModeGreen
        ' 
        mnuItmDarkModeGreen.Name = "mnuItmDarkModeGreen"
        mnuItmDarkModeGreen.ShortcutKeys = Keys.Alt Or Keys.G
        mnuItmDarkModeGreen.Size = New Size(214, 22)
        mnuItmDarkModeGreen.Text = "Dark mode - &Green"
        ' 
        ' mnuItmLightModeBlue
        ' 
        mnuItmLightModeBlue.Name = "mnuItmLightModeBlue"
        mnuItmLightModeBlue.ShortcutKeys = Keys.Alt Or Keys.B
        mnuItmLightModeBlue.Size = New Size(214, 22)
        mnuItmLightModeBlue.Text = "Light mode - &Blue"
        ' 
        ' mnuItmLightModeGreen
        ' 
        mnuItmLightModeGreen.Name = "mnuItmLightModeGreen"
        mnuItmLightModeGreen.ShortcutKeys = Keys.Alt Or Keys.R
        mnuItmLightModeGreen.Size = New Size(214, 22)
        mnuItmLightModeGreen.Text = "Light mode - G&reen"
        ' 
        ' mnuItmData
        ' 
        mnuItmData.DropDownItems.AddRange(New ToolStripItem() {mnuItmExportData, mnuItmImportData, mnuItmPurgeData})
        mnuItmData.Name = "mnuItmData"
        mnuItmData.ShortcutKeys = Keys.Alt Or Keys.D
        mnuItmData.Size = New Size(43, 20)
        mnuItmData.Text = "&Data"
        ' 
        ' mnuItmExportData
        ' 
        mnuItmExportData.Name = "mnuItmExportData"
        mnuItmExportData.ShortcutKeys = Keys.Alt Or Keys.E
        mnuItmExportData.Size = New Size(170, 22)
        mnuItmExportData.Text = "&Export data"
        ' 
        ' mnuItmImportData
        ' 
        mnuItmImportData.Name = "mnuItmImportData"
        mnuItmImportData.ShortcutKeys = Keys.Alt Or Keys.I
        mnuItmImportData.Size = New Size(170, 22)
        mnuItmImportData.Text = "&Import data"
        ' 
        ' mnuItmPurgeData
        ' 
        mnuItmPurgeData.Name = "mnuItmPurgeData"
        mnuItmPurgeData.ShortcutKeys = Keys.Alt Or Keys.P
        mnuItmPurgeData.Size = New Size(170, 22)
        mnuItmPurgeData.Text = "&Purge data"
        ' 
        ' mnuItmContacts
        ' 
        mnuItmContacts.DropDownItems.AddRange(New ToolStripItem() {mnuItmMassEmail})
        mnuItmContacts.Name = "mnuItmContacts"
        mnuItmContacts.ShortcutKeys = Keys.Alt Or Keys.C
        mnuItmContacts.Size = New Size(66, 20)
        mnuItmContacts.Text = "&Contacts"
        ' 
        ' mnuItmMassEmail
        ' 
        mnuItmMassEmail.Name = "mnuItmMassEmail"
        mnuItmMassEmail.ShortcutKeys = Keys.Alt Or Keys.G
        mnuItmMassEmail.Size = New Size(221, 22)
        mnuItmMassEmail.Text = "&Generate mass email"
        ' 
        ' staStatusStrip
        ' 
        staStatusStrip.Location = New Point(3, 494)
        staStatusStrip.Name = "staStatusStrip"
        staStatusStrip.Size = New Size(794, 22)
        staStatusStrip.TabIndex = 1
        staStatusStrip.Text = "StatusStrip1"
        ' 
        ' pnlSearchCriteria
        ' 
        pnlSearchCriteria.Controls.Add(lblEmail)
        pnlSearchCriteria.Controls.Add(txtEmail)
        pnlSearchCriteria.Controls.Add(lblName)
        pnlSearchCriteria.Controls.Add(lblPhoneNumber)
        pnlSearchCriteria.Controls.Add(txtName)
        pnlSearchCriteria.Controls.Add(txtPhoneNumber)
        pnlSearchCriteria.Controls.Add(btnClear)
        pnlSearchCriteria.Controls.Add(btnSearch)
        pnlSearchCriteria.Dock = DockStyle.Top
        pnlSearchCriteria.Location = New Point(3, 112)
        pnlSearchCriteria.Name = "pnlSearchCriteria"
        pnlSearchCriteria.Size = New Size(794, 104)
        pnlSearchCriteria.TabIndex = 3
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Depth = 0
        lblEmail.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblEmail.Location = New Point(272, 11)
        lblEmail.MouseState = MouseState.HOVER
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(41, 19)
        lblEmail.TabIndex = 17
        lblEmail.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.AnimateReadOnly = False
        txtEmail.BorderStyle = BorderStyle.None
        txtEmail.Depth = 0
        txtEmail.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtEmail.LeadingIcon = Nothing
        txtEmail.Location = New Point(321, 9)
        txtEmail.MaxLength = 50
        txtEmail.MouseState = MouseState.OUT
        txtEmail.Multiline = False
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(157, 36)
        txtEmail.TabIndex = 1
        txtEmail.Text = ""
        txtEmail.TrailingIcon = Nothing
        txtEmail.UseTallSize = False
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Depth = 0
        lblName.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblName.Location = New Point(41, 12)
        lblName.MouseState = MouseState.HOVER
        lblName.Name = "lblName"
        lblName.Size = New Size(43, 19)
        lblName.TabIndex = 15
        lblName.Text = "Name"
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Depth = 0
        lblPhoneNumber.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblPhoneNumber.Location = New Point(24, 62)
        lblPhoneNumber.MouseState = MouseState.HOVER
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(60, 19)
        lblPhoneNumber.TabIndex = 14
        lblPhoneNumber.Text = "Phone #"
        ' 
        ' txtName
        ' 
        txtName.AnimateReadOnly = False
        txtName.BorderStyle = BorderStyle.None
        txtName.Depth = 0
        txtName.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtName.LeadingIcon = Nothing
        txtName.Location = New Point(90, 10)
        txtName.MaxLength = 50
        txtName.MouseState = MouseState.OUT
        txtName.Multiline = False
        txtName.Name = "txtName"
        txtName.Size = New Size(157, 36)
        txtName.TabIndex = 0
        txtName.Text = ""
        txtName.TrailingIcon = Nothing
        txtName.UseTallSize = False
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.AnimateReadOnly = False
        txtPhoneNumber.BorderStyle = BorderStyle.None
        txtPhoneNumber.Depth = 0
        txtPhoneNumber.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtPhoneNumber.LeadingIcon = Nothing
        txtPhoneNumber.Location = New Point(90, 62)
        txtPhoneNumber.MaxLength = 50
        txtPhoneNumber.MouseState = MouseState.OUT
        txtPhoneNumber.Multiline = False
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(157, 36)
        txtPhoneNumber.TabIndex = 2
        txtPhoneNumber.Text = ""
        txtPhoneNumber.TrailingIcon = Nothing
        txtPhoneNumber.UseTallSize = False
        ' 
        ' btnClear
        ' 
        btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnClear.BackColor = SystemColors.Control
        btnClear.Cursor = Cursors.Hand
        btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnClear.Depth = 0
        btnClear.ForeColor = SystemColors.ControlText
        btnClear.HighEmphasis = True
        btnClear.Icon = Nothing
        btnClear.Location = New Point(705, 24)
        btnClear.Margin = New Padding(4, 6, 4, 6)
        btnClear.MouseState = MouseState.HOVER
        btnClear.Name = "btnClear"
        btnClear.NoAccentTextColor = Color.Empty
        btnClear.Size = New Size(66, 36)
        btnClear.TabIndex = 4
        btnClear.Text = "Clear"
        btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnClear.UseAccentColor = False
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSearch.BackColor = SystemColors.Control
        btnSearch.Cursor = Cursors.Hand
        btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnSearch.Depth = 0
        btnSearch.ForeColor = SystemColors.ControlText
        btnSearch.HighEmphasis = True
        btnSearch.Icon = Nothing
        btnSearch.Location = New Point(616, 24)
        btnSearch.Margin = New Padding(4, 6, 4, 6)
        btnSearch.MouseState = MouseState.HOVER
        btnSearch.Name = "btnSearch"
        btnSearch.NoAccentTextColor = Color.Empty
        btnSearch.Size = New Size(78, 36)
        btnSearch.TabIndex = 3
        btnSearch.Text = "Search"
        btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnSearch.UseAccentColor = False
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' pnlBottom
        ' 
        pnlBottom.Controls.Add(btnEdit)
        pnlBottom.Controls.Add(btnNew)
        pnlBottom.Dock = DockStyle.Bottom
        pnlBottom.Location = New Point(3, 429)
        pnlBottom.Name = "pnlBottom"
        pnlBottom.Size = New Size(794, 65)
        pnlBottom.TabIndex = 4
        ' 
        ' btnEdit
        ' 
        btnEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnEdit.BackColor = SystemColors.Control
        btnEdit.Cursor = Cursors.Hand
        btnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnEdit.Depth = 0
        btnEdit.ForeColor = SystemColors.ControlText
        btnEdit.HighEmphasis = True
        btnEdit.Icon = Nothing
        btnEdit.Location = New Point(410, 14)
        btnEdit.Margin = New Padding(4, 6, 4, 6)
        btnEdit.MouseState = MouseState.HOVER
        btnEdit.Name = "btnEdit"
        btnEdit.NoAccentTextColor = Color.Empty
        btnEdit.Size = New Size(64, 36)
        btnEdit.TabIndex = 1
        btnEdit.Text = "Edit"
        btnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnEdit.UseAccentColor = False
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnNew
        ' 
        btnNew.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnNew.BackColor = SystemColors.Control
        btnNew.Cursor = Cursors.Hand
        btnNew.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnNew.Depth = 0
        btnNew.ForeColor = SystemColors.ControlText
        btnNew.HighEmphasis = True
        btnNew.Icon = Nothing
        btnNew.Location = New Point(321, 14)
        btnNew.Margin = New Padding(4, 6, 4, 6)
        btnNew.MouseState = MouseState.HOVER
        btnNew.Name = "btnNew"
        btnNew.NoAccentTextColor = Color.Empty
        btnNew.Size = New Size(64, 36)
        btnNew.TabIndex = 0
        btnNew.Text = "New"
        btnNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnNew.UseAccentColor = False
        btnNew.UseVisualStyleBackColor = False
        ' 
        ' pnlBody
        ' 
        pnlBody.Controls.Add(dgvResults)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(3, 216)
        pnlBody.Name = "pnlBody"
        pnlBody.Size = New Size(794, 213)
        pnlBody.TabIndex = 5
        ' 
        ' dgvResults
        ' 
        dgvResults.AllowUserToAddRows = False
        dgvResults.AllowUserToDeleteRows = False
        dgvResults.AutoGenerateColumns = False
        dgvResults.BorderStyle = BorderStyle.None
        dgvResults.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvResults.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvResults.ColumnHeadersHeight = 40
        dgvResults.Columns.AddRange(New DataGridViewColumn() {colId, colName, colPhone, colEmail})
        dgvResults.ContextMenuStrip = cMnu
        dgvResults.DataSource = ContactBindingSource
        dgvResults.Dock = DockStyle.Fill
        dgvResults.Location = New Point(0, 0)
        dgvResults.MultiSelect = False
        dgvResults.Name = "dgvResults"
        dgvResults.ReadOnly = True
        dgvResults.RowHeadersVisible = False
        dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvResults.Size = New Size(794, 213)
        dgvResults.TabIndex = 0
        ' 
        ' colId
        ' 
        colId.DataPropertyName = "ContactId"
        colId.HeaderText = "ID"
        colId.Name = "colId"
        colId.ReadOnly = True
        colId.Width = 50
        ' 
        ' colName
        ' 
        colName.DataPropertyName = "ContactName"
        colName.HeaderText = "Name"
        colName.Name = "colName"
        colName.ReadOnly = True
        colName.Width = 400
        ' 
        ' colPhone
        ' 
        colPhone.DataPropertyName = "ContactPhone"
        colPhone.HeaderText = "Phone #"
        colPhone.Name = "colPhone"
        colPhone.ReadOnly = True
        ' 
        ' colEmail
        ' 
        colEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colEmail.DataPropertyName = "ContactEmail"
        colEmail.HeaderText = "Email"
        colEmail.Name = "colEmail"
        colEmail.ReadOnly = True
        ' 
        ' cMnu
        ' 
        cMnu.Items.AddRange(New ToolStripItem() {cMnuExport})
        cMnu.Name = "cMnu"
        cMnu.Size = New Size(147, 26)
        ' 
        ' cMnuExport
        ' 
        cMnuExport.Name = "cMnuExport"
        cMnuExport.Size = New Size(146, 22)
        cMnuExport.Text = "Export to CSV"
        ' 
        ' ContactBindingSource
        ' 
        ContactBindingSource.DataSource = GetType(Contact)
        ' 
        ' lblSearchCriteria
        ' 
        lblSearchCriteria.AutoSize = True
        lblSearchCriteria.Depth = 0
        lblSearchCriteria.Dock = DockStyle.Top
        lblSearchCriteria.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblSearchCriteria.FontType = MaterialSkinManager.fontType.H6
        lblSearchCriteria.Location = New Point(3, 88)
        lblSearchCriteria.MouseState = MouseState.HOVER
        lblSearchCriteria.Name = "lblSearchCriteria"
        lblSearchCriteria.Size = New Size(134, 24)
        lblSearchCriteria.TabIndex = 16
        lblSearchCriteria.Text = "Search Criteria"
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 519)
        Controls.Add(pnlBody)
        Controls.Add(pnlBottom)
        Controls.Add(pnlSearchCriteria)
        Controls.Add(lblSearchCriteria)
        Controls.Add(staStatusStrip)
        Controls.Add(mnuMenuStrip)
        MainMenuStrip = mnuMenuStrip
        Name = "FrmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Your personal CRM"
        mnuMenuStrip.ResumeLayout(False)
        mnuMenuStrip.PerformLayout()
        pnlSearchCriteria.ResumeLayout(False)
        pnlSearchCriteria.PerformLayout()
        pnlBottom.ResumeLayout(False)
        pnlBottom.PerformLayout()
        pnlBody.ResumeLayout(False)
        CType(dgvResults, ComponentModel.ISupportInitialize).EndInit()
        cMnu.ResumeLayout(False)
        CType(ContactBindingSource, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents mnuMenuStrip As MenuStrip
    Friend WithEvents mnuItmFile As ToolStripMenuItem
    Friend WithEvents mnuItmExit As ToolStripMenuItem
    Friend WithEvents mnuItmHelp As ToolStripMenuItem
    Friend WithEvents mnuItmAbout As ToolStripMenuItem
    Friend WithEvents staStatusStrip As StatusStrip
    Friend WithEvents pnlSearchCriteria As Panel
    Friend WithEvents pnlBottom As Panel
    Friend WithEvents pnlBody As Panel
    Friend WithEvents txtPhoneNumber1 As TextBox
    Friend WithEvents lblPhoneNumber1 As Label
    Friend WithEvents txtName2 As TextBox
    Friend WithEvents lblName1 As Label
    Friend WithEvents ContactnNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnNew As Controls.MaterialButton
    Friend WithEvents btnEdit As Controls.MaterialButton
    Friend WithEvents btnSearch As Controls.MaterialButton
    Friend WithEvents btnClear As Controls.MaterialButton
    Friend WithEvents txtPhoneNumber As Controls.MaterialTextBox
    Friend WithEvents lblPhoneNumber As Controls.MaterialLabel
    Friend WithEvents txtName As Controls.MaterialTextBox
    Friend WithEvents lblName As Controls.MaterialLabel
    Friend WithEvents lblSearchCriteria As Controls.MaterialLabel
    Friend WithEvents dgvResults As DataGridView
    Friend WithEvents lblEmail As Controls.MaterialLabel
    Friend WithEvents txtEmail As Controls.MaterialTextBox
    Friend WithEvents mnuItmPreferences As ToolStripMenuItem
    Friend WithEvents mnuItmTheme As ToolStripMenuItem
    Friend WithEvents mnuItmDarkModeGreen As ToolStripMenuItem
    Friend WithEvents mnuItmLightModeBlue As ToolStripMenuItem
    Friend WithEvents mnuItmDarkModePurple As ToolStripMenuItem
    Friend WithEvents mnuItmLightModeGreen As ToolStripMenuItem
    Friend WithEvents ContactBindingSource As BindingSource
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colPhone As DataGridViewTextBoxColumn
    Friend WithEvents colEmail As DataGridViewTextBoxColumn
    Friend WithEvents cMnu As ContextMenuStrip
    Friend WithEvents cMnuExport As ToolStripMenuItem
    Friend WithEvents mnuItmData As ToolStripMenuItem
    Friend WithEvents mnuItmExportData As ToolStripMenuItem
    Friend WithEvents mnuItmImportData As ToolStripMenuItem
    Friend WithEvents mnuItmPurgeData As ToolStripMenuItem
    Friend WithEvents mnuItmContacts As ToolStripMenuItem
    Friend WithEvents mnuItmMassEmail As ToolStripMenuItem

End Class
