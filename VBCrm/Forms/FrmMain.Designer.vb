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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        mnuMenuStrip = New MenuStrip()
        mnuItmContacts = New ToolStripMenuItem()
        mnuItmMassEmail = New ToolStripMenuItem()
        mnuItmCreateContact = New ToolStripMenuItem()
        mnuItmEditContact = New ToolStripMenuItem()
        mnuItmDeleteContact = New ToolStripMenuItem()
        mnuItmData = New ToolStripMenuItem()
        mnuItmImportData = New ToolStripMenuItem()
        mnuItmExportData = New ToolStripMenuItem()
        mnuItmPurge = New ToolStripMenuItem()
        mnuItmPurgeContacts = New ToolStripMenuItem()
        mnuItmPurgePreferences = New ToolStripMenuItem()
        mnuItmPurgeAll = New ToolStripMenuItem()
        mnuItmSettings = New ToolStripMenuItem()
        mnuItmTheme = New ToolStripMenuItem()
        mnuItmDarkModePurple = New ToolStripMenuItem()
        mnuItmDarkModeGreen = New ToolStripMenuItem()
        mnuItmLightModeBlue = New ToolStripMenuItem()
        mnuItmLightModeGreen = New ToolStripMenuItem()
        mnuItmConfigureFields = New ToolStripMenuItem()
        mnuItmHelp = New ToolStripMenuItem()
        mnuItmAbout = New ToolStripMenuItem()
        mnuItmViewErrorLogs = New ToolStripMenuItem()
        lblNotes = New Controls.MaterialLabel()
        txtNotes = New Controls.MaterialTextBox()
        lblDateOfBirth = New Controls.MaterialLabel()
        txtDateOfBirth = New Controls.MaterialTextBox()
        lblJobTitle = New Controls.MaterialLabel()
        txtJobTitle = New Controls.MaterialTextBox()
        lblCompany = New Controls.MaterialLabel()
        txtCompany = New Controls.MaterialTextBox()
        lblAddress = New Controls.MaterialLabel()
        txtAddress = New Controls.MaterialTextBox()
        lblId = New Controls.MaterialLabel()
        txtId = New Controls.MaterialTextBox()
        lblEmail = New Controls.MaterialLabel()
        txtEmail = New Controls.MaterialTextBox()
        lblName = New Controls.MaterialLabel()
        lblPhoneNumber = New Controls.MaterialLabel()
        txtName = New Controls.MaterialTextBox()
        txtPhoneNumber = New Controls.MaterialTextBox()
        btnClear = New Controls.MaterialButton()
        btnSearch = New Controls.MaterialButton()
        pnlBottom = New Panel()
        btnDelete = New Controls.MaterialButton()
        btnEdit = New Controls.MaterialButton()
        btnNew = New Controls.MaterialButton()
        pnlBody = New Panel()
        dgvResults = New DataGridView()
        colId = New DataGridViewTextBoxColumn()
        colName = New DataGridViewTextBoxColumn()
        colPhone = New DataGridViewTextBoxColumn()
        colEmail = New DataGridViewTextBoxColumn()
        colAddress = New DataGridViewTextBoxColumn()
        colCompany = New DataGridViewTextBoxColumn()
        colJobTitle = New DataGridViewTextBoxColumn()
        colDateOfBirth = New DataGridViewTextBoxColumn()
        colNotes = New DataGridViewTextBoxColumn()
        cMnu = New ContextMenuStrip(components)
        cMnuExport = New ToolStripMenuItem()
        ContactBindingSource1 = New BindingSource(components)
        ContactBindingSource = New BindingSource(components)
        tbplSearchCriteria = New TableLayoutPanel()
        pnlButtons = New Panel()
        pnlDateOfBirth = New Panel()
        pnlCompany = New Panel()
        pnlAddress = New Panel()
        pnlId = New Panel()
        pnlNotes = New Panel()
        pnlJobTitle = New Panel()
        pnlName = New Panel()
        pnlEmail = New Panel()
        pnlPhoneNumber = New Panel()
        btnMenuControl = New Button()
        mnuMenuStrip.SuspendLayout()
        pnlBottom.SuspendLayout()
        pnlBody.SuspendLayout()
        CType(dgvResults, ComponentModel.ISupportInitialize).BeginInit()
        cMnu.SuspendLayout()
        CType(ContactBindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ContactBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        tbplSearchCriteria.SuspendLayout()
        pnlButtons.SuspendLayout()
        pnlDateOfBirth.SuspendLayout()
        pnlCompany.SuspendLayout()
        pnlAddress.SuspendLayout()
        pnlId.SuspendLayout()
        pnlNotes.SuspendLayout()
        pnlJobTitle.SuspendLayout()
        pnlName.SuspendLayout()
        pnlEmail.SuspendLayout()
        pnlPhoneNumber.SuspendLayout()
        SuspendLayout()
        ' 
        ' mnuMenuStrip
        ' 
        mnuMenuStrip.AllowItemReorder = True
        mnuMenuStrip.AutoSize = False
        mnuMenuStrip.Dock = DockStyle.Left
        mnuMenuStrip.Items.AddRange(New ToolStripItem() {mnuItmContacts, mnuItmData, mnuItmSettings, mnuItmHelp})
        mnuMenuStrip.LayoutStyle = ToolStripLayoutStyle.Table
        mnuMenuStrip.Location = New Point(3, 162)
        mnuMenuStrip.Name = "mnuMenuStrip"
        mnuMenuStrip.Size = New Size(87, 453)
        mnuMenuStrip.TabIndex = 3
        mnuMenuStrip.Visible = False
        ' 
        ' mnuItmContacts
        ' 
        mnuItmContacts.AutoSize = False
        mnuItmContacts.BackgroundImageLayout = ImageLayout.None
        mnuItmContacts.DisplayStyle = ToolStripItemDisplayStyle.Image
        mnuItmContacts.DropDownItems.AddRange(New ToolStripItem() {mnuItmMassEmail, mnuItmCreateContact, mnuItmEditContact, mnuItmDeleteContact})
        mnuItmContacts.Image = CType(resources.GetObject("mnuItmContacts.Image"), Image)
        mnuItmContacts.ImageAlign = ContentAlignment.MiddleLeft
        mnuItmContacts.ImageScaling = ToolStripItemImageScaling.None
        mnuItmContacts.Name = "mnuItmContacts"
        mnuItmContacts.Size = New Size(62, 100)
        ' 
        ' mnuItmMassEmail
        ' 
        mnuItmMassEmail.Name = "mnuItmMassEmail"
        mnuItmMassEmail.Size = New Size(198, 22)
        mnuItmMassEmail.Text = "Create mass email"
        ' 
        ' mnuItmCreateContact
        ' 
        mnuItmCreateContact.Name = "mnuItmCreateContact"
        mnuItmCreateContact.Size = New Size(198, 22)
        mnuItmCreateContact.Text = "Create Contact..."
        ' 
        ' mnuItmEditContact
        ' 
        mnuItmEditContact.Name = "mnuItmEditContact"
        mnuItmEditContact.Size = New Size(198, 22)
        mnuItmEditContact.Text = "Edit selected Contact..."
        ' 
        ' mnuItmDeleteContact
        ' 
        mnuItmDeleteContact.Name = "mnuItmDeleteContact"
        mnuItmDeleteContact.Size = New Size(198, 22)
        mnuItmDeleteContact.Text = "Delete selected Contact"
        ' 
        ' mnuItmData
        ' 
        mnuItmData.AutoSize = False
        mnuItmData.DisplayStyle = ToolStripItemDisplayStyle.Image
        mnuItmData.DropDownItems.AddRange(New ToolStripItem() {mnuItmImportData, mnuItmExportData, mnuItmPurge})
        mnuItmData.Image = CType(resources.GetObject("mnuItmData.Image"), Image)
        mnuItmData.ImageAlign = ContentAlignment.MiddleRight
        mnuItmData.ImageScaling = ToolStripItemImageScaling.None
        mnuItmData.Name = "mnuItmData"
        mnuItmData.Size = New Size(62, 100)
        mnuItmData.Text = "&Data"
        ' 
        ' mnuItmImportData
        ' 
        mnuItmImportData.Name = "mnuItmImportData"
        mnuItmImportData.Size = New Size(160, 22)
        mnuItmImportData.Text = "Import CSV data"
        ' 
        ' mnuItmExportData
        ' 
        mnuItmExportData.Name = "mnuItmExportData"
        mnuItmExportData.Size = New Size(160, 22)
        mnuItmExportData.Text = "Export CSV data"
        ' 
        ' mnuItmPurge
        ' 
        mnuItmPurge.DropDownItems.AddRange(New ToolStripItem() {mnuItmPurgeContacts, mnuItmPurgePreferences, mnuItmPurgeAll})
        mnuItmPurge.Name = "mnuItmPurge"
        mnuItmPurge.Size = New Size(160, 22)
        mnuItmPurge.Text = "Purge"
        ' 
        ' mnuItmPurgeContacts
        ' 
        mnuItmPurgeContacts.Name = "mnuItmPurgeContacts"
        mnuItmPurgeContacts.Size = New Size(169, 22)
        mnuItmPurgeContacts.Text = "Purge Contacts"
        ' 
        ' mnuItmPurgePreferences
        ' 
        mnuItmPurgePreferences.Name = "mnuItmPurgePreferences"
        mnuItmPurgePreferences.Size = New Size(169, 22)
        mnuItmPurgePreferences.Text = "Purge Preferences"
        ' 
        ' mnuItmPurgeAll
        ' 
        mnuItmPurgeAll.Name = "mnuItmPurgeAll"
        mnuItmPurgeAll.Size = New Size(169, 22)
        mnuItmPurgeAll.Text = "Purge All"
        ' 
        ' mnuItmSettings
        ' 
        mnuItmSettings.AutoSize = False
        mnuItmSettings.DisplayStyle = ToolStripItemDisplayStyle.Image
        mnuItmSettings.DropDownItems.AddRange(New ToolStripItem() {mnuItmTheme, mnuItmConfigureFields})
        mnuItmSettings.Image = CType(resources.GetObject("mnuItmSettings.Image"), Image)
        mnuItmSettings.ImageAlign = ContentAlignment.MiddleRight
        mnuItmSettings.ImageScaling = ToolStripItemImageScaling.None
        mnuItmSettings.Name = "mnuItmSettings"
        mnuItmSettings.Size = New Size(62, 100)
        mnuItmSettings.Text = "&Settings"
        ' 
        ' mnuItmTheme
        ' 
        mnuItmTheme.DropDownItems.AddRange(New ToolStripItem() {mnuItmDarkModePurple, mnuItmDarkModeGreen, mnuItmLightModeBlue, mnuItmLightModeGreen})
        mnuItmTheme.Name = "mnuItmTheme"
        mnuItmTheme.Size = New Size(167, 22)
        mnuItmTheme.Text = "Theme"
        ' 
        ' mnuItmDarkModePurple
        ' 
        mnuItmDarkModePurple.Name = "mnuItmDarkModePurple"
        mnuItmDarkModePurple.Size = New Size(177, 22)
        mnuItmDarkModePurple.Text = "Dark mode - Purple"
        ' 
        ' mnuItmDarkModeGreen
        ' 
        mnuItmDarkModeGreen.Name = "mnuItmDarkModeGreen"
        mnuItmDarkModeGreen.Size = New Size(177, 22)
        mnuItmDarkModeGreen.Text = "Dark mode - Green"
        ' 
        ' mnuItmLightModeBlue
        ' 
        mnuItmLightModeBlue.Name = "mnuItmLightModeBlue"
        mnuItmLightModeBlue.Size = New Size(177, 22)
        mnuItmLightModeBlue.Text = "Light mode - Blue"
        ' 
        ' mnuItmLightModeGreen
        ' 
        mnuItmLightModeGreen.Name = "mnuItmLightModeGreen"
        mnuItmLightModeGreen.Size = New Size(177, 22)
        mnuItmLightModeGreen.Text = "Light mode - Green"
        ' 
        ' mnuItmConfigureFields
        ' 
        mnuItmConfigureFields.Name = "mnuItmConfigureFields"
        mnuItmConfigureFields.Size = New Size(167, 22)
        mnuItmConfigureFields.Text = "Configure fields..."
        ' 
        ' mnuItmHelp
        ' 
        mnuItmHelp.AutoSize = False
        mnuItmHelp.DisplayStyle = ToolStripItemDisplayStyle.Image
        mnuItmHelp.DropDownItems.AddRange(New ToolStripItem() {mnuItmAbout, mnuItmViewErrorLogs})
        mnuItmHelp.Image = CType(resources.GetObject("mnuItmHelp.Image"), Image)
        mnuItmHelp.ImageAlign = ContentAlignment.MiddleRight
        mnuItmHelp.ImageScaling = ToolStripItemImageScaling.None
        mnuItmHelp.Name = "mnuItmHelp"
        mnuItmHelp.ShortcutKeys = Keys.Alt Or Keys.H
        mnuItmHelp.Size = New Size(60, 100)
        ' 
        ' mnuItmAbout
        ' 
        mnuItmAbout.Name = "mnuItmAbout"
        mnuItmAbout.Size = New Size(164, 22)
        mnuItmAbout.Text = "About..."
        ' 
        ' mnuItmViewErrorLogs
        ' 
        mnuItmViewErrorLogs.Name = "mnuItmViewErrorLogs"
        mnuItmViewErrorLogs.Size = New Size(164, 22)
        mnuItmViewErrorLogs.Text = "View Error Logs..."
        ' 
        ' lblNotes
        ' 
        lblNotes.AutoSize = True
        lblNotes.Depth = 0
        lblNotes.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblNotes.Location = New Point(3, 12)
        lblNotes.MouseState = MouseState.HOVER
        lblNotes.Name = "lblNotes"
        lblNotes.Size = New Size(42, 19)
        lblNotes.TabIndex = 29
        lblNotes.Tag = "Notes"
        lblNotes.Text = "Notes"
        ' 
        ' txtNotes
        ' 
        txtNotes.AnimateReadOnly = False
        txtNotes.BorderStyle = BorderStyle.None
        txtNotes.Depth = 0
        txtNotes.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtNotes.LeadingIcon = Nothing
        txtNotes.Location = New Point(51, 3)
        txtNotes.MaxLength = 50
        txtNotes.MouseState = MouseState.OUT
        txtNotes.Multiline = False
        txtNotes.Name = "txtNotes"
        txtNotes.Size = New Size(285, 36)
        txtNotes.TabIndex = 0
        txtNotes.Tag = "Notes"
        txtNotes.Text = ""
        txtNotes.TrailingIcon = Nothing
        txtNotes.UseTallSize = False
        ' 
        ' lblDateOfBirth
        ' 
        lblDateOfBirth.AutoSize = True
        lblDateOfBirth.Depth = 0
        lblDateOfBirth.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblDateOfBirth.Location = New Point(3, 13)
        lblDateOfBirth.MouseState = MouseState.HOVER
        lblDateOfBirth.Name = "lblDateOfBirth"
        lblDateOfBirth.Size = New Size(89, 19)
        lblDateOfBirth.TabIndex = 27
        lblDateOfBirth.Tag = "Date of birth"
        lblDateOfBirth.Text = "Date of birth"
        ' 
        ' txtDateOfBirth
        ' 
        txtDateOfBirth.AnimateReadOnly = False
        txtDateOfBirth.BorderStyle = BorderStyle.None
        txtDateOfBirth.Depth = 0
        txtDateOfBirth.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtDateOfBirth.LeadingIcon = Nothing
        txtDateOfBirth.Location = New Point(98, 3)
        txtDateOfBirth.MaxLength = 50
        txtDateOfBirth.MouseState = MouseState.OUT
        txtDateOfBirth.Multiline = False
        txtDateOfBirth.Name = "txtDateOfBirth"
        txtDateOfBirth.Size = New Size(138, 36)
        txtDateOfBirth.TabIndex = 0
        txtDateOfBirth.Tag = "Date of birth"
        txtDateOfBirth.Text = ""
        txtDateOfBirth.TrailingIcon = Nothing
        txtDateOfBirth.UseTallSize = False
        ' 
        ' lblJobTitle
        ' 
        lblJobTitle.AutoSize = True
        lblJobTitle.Depth = 0
        lblJobTitle.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblJobTitle.Location = New Point(3, 12)
        lblJobTitle.MouseState = MouseState.HOVER
        lblJobTitle.Name = "lblJobTitle"
        lblJobTitle.Size = New Size(58, 19)
        lblJobTitle.TabIndex = 25
        lblJobTitle.Tag = "Job title"
        lblJobTitle.Text = "Job title"
        ' 
        ' txtJobTitle
        ' 
        txtJobTitle.AnimateReadOnly = False
        txtJobTitle.BorderStyle = BorderStyle.None
        txtJobTitle.Depth = 0
        txtJobTitle.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtJobTitle.LeadingIcon = Nothing
        txtJobTitle.Location = New Point(67, 3)
        txtJobTitle.MaxLength = 50
        txtJobTitle.MouseState = MouseState.OUT
        txtJobTitle.Multiline = False
        txtJobTitle.Name = "txtJobTitle"
        txtJobTitle.Size = New Size(169, 36)
        txtJobTitle.TabIndex = 0
        txtJobTitle.Tag = "Job title"
        txtJobTitle.Text = ""
        txtJobTitle.TrailingIcon = Nothing
        txtJobTitle.UseTallSize = False
        ' 
        ' lblCompany
        ' 
        lblCompany.AutoSize = True
        lblCompany.Depth = 0
        lblCompany.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblCompany.Location = New Point(3, 13)
        lblCompany.MouseState = MouseState.HOVER
        lblCompany.Name = "lblCompany"
        lblCompany.Size = New Size(69, 19)
        lblCompany.TabIndex = 23
        lblCompany.Tag = "Company"
        lblCompany.Text = "Company"
        ' 
        ' txtCompany
        ' 
        txtCompany.AnimateReadOnly = False
        txtCompany.BorderStyle = BorderStyle.None
        txtCompany.Depth = 0
        txtCompany.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtCompany.LeadingIcon = Nothing
        txtCompany.Location = New Point(78, 3)
        txtCompany.MaxLength = 50
        txtCompany.MouseState = MouseState.OUT
        txtCompany.Multiline = False
        txtCompany.Name = "txtCompany"
        txtCompany.Size = New Size(153, 36)
        txtCompany.TabIndex = 0
        txtCompany.Tag = "Company"
        txtCompany.Text = ""
        txtCompany.TrailingIcon = Nothing
        txtCompany.UseTallSize = False
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Depth = 0
        lblAddress.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblAddress.Location = New Point(3, 13)
        lblAddress.MouseState = MouseState.HOVER
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(58, 19)
        lblAddress.TabIndex = 21
        lblAddress.Tag = "Address"
        lblAddress.Text = "Address"
        ' 
        ' txtAddress
        ' 
        txtAddress.AnimateReadOnly = False
        txtAddress.BorderStyle = BorderStyle.None
        txtAddress.Depth = 0
        txtAddress.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtAddress.LeadingIcon = Nothing
        txtAddress.Location = New Point(67, 3)
        txtAddress.MaxLength = 50
        txtAddress.MouseState = MouseState.OUT
        txtAddress.Multiline = False
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(164, 36)
        txtAddress.TabIndex = 0
        txtAddress.Tag = "Address"
        txtAddress.Text = ""
        txtAddress.TrailingIcon = Nothing
        txtAddress.UseTallSize = False
        ' 
        ' lblId
        ' 
        lblId.AutoSize = True
        lblId.Depth = 0
        lblId.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblId.Location = New Point(3, 13)
        lblId.MouseState = MouseState.HOVER
        lblId.Name = "lblId"
        lblId.Size = New Size(16, 19)
        lblId.TabIndex = 19
        lblId.Tag = "ID"
        lblId.Text = "ID"
        ' 
        ' txtId
        ' 
        txtId.AnimateReadOnly = False
        txtId.BorderStyle = BorderStyle.None
        txtId.Depth = 0
        txtId.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtId.LeadingIcon = Nothing
        txtId.Location = New Point(25, 3)
        txtId.MaxLength = 50
        txtId.MouseState = MouseState.OUT
        txtId.Multiline = False
        txtId.Name = "txtId"
        txtId.Size = New Size(184, 36)
        txtId.TabIndex = 0
        txtId.Tag = "ID"
        txtId.Text = ""
        txtId.TrailingIcon = Nothing
        txtId.UseTallSize = False
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Depth = 0
        lblEmail.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblEmail.Location = New Point(3, 12)
        lblEmail.MouseState = MouseState.HOVER
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(41, 19)
        lblEmail.TabIndex = 17
        lblEmail.Tag = "Email"
        lblEmail.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.AnimateReadOnly = False
        txtEmail.BorderStyle = BorderStyle.None
        txtEmail.Depth = 0
        txtEmail.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtEmail.LeadingIcon = Nothing
        txtEmail.Location = New Point(50, 3)
        txtEmail.MaxLength = 50
        txtEmail.MouseState = MouseState.OUT
        txtEmail.Multiline = False
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(181, 36)
        txtEmail.TabIndex = 0
        txtEmail.Tag = "Email"
        txtEmail.Text = ""
        txtEmail.TrailingIcon = Nothing
        txtEmail.UseTallSize = False
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Depth = 0
        lblName.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblName.Location = New Point(3, 12)
        lblName.MouseState = MouseState.HOVER
        lblName.Name = "lblName"
        lblName.Size = New Size(43, 19)
        lblName.TabIndex = 15
        lblName.Tag = "Name"
        lblName.Text = "Name"
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Depth = 0
        lblPhoneNumber.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblPhoneNumber.Location = New Point(3, 12)
        lblPhoneNumber.MouseState = MouseState.HOVER
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(60, 19)
        lblPhoneNumber.TabIndex = 14
        lblPhoneNumber.Tag = "Phone #"
        lblPhoneNumber.Text = "Phone #"
        ' 
        ' txtName
        ' 
        txtName.AnimateReadOnly = False
        txtName.BorderStyle = BorderStyle.None
        txtName.Depth = 0
        txtName.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtName.LeadingIcon = Nothing
        txtName.Location = New Point(52, 3)
        txtName.MaxLength = 50
        txtName.MouseState = MouseState.OUT
        txtName.Multiline = False
        txtName.Name = "txtName"
        txtName.Size = New Size(157, 36)
        txtName.TabIndex = 0
        txtName.Tag = "Name"
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
        txtPhoneNumber.Location = New Point(69, 3)
        txtPhoneNumber.MaxLength = 50
        txtPhoneNumber.MouseState = MouseState.OUT
        txtPhoneNumber.Multiline = False
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(157, 36)
        txtPhoneNumber.TabIndex = 0
        txtPhoneNumber.Tag = "Phone #"
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
        btnClear.Location = New Point(90, 2)
        btnClear.Margin = New Padding(4, 6, 4, 6)
        btnClear.MouseState = MouseState.HOVER
        btnClear.Name = "btnClear"
        btnClear.NoAccentTextColor = Color.Empty
        btnClear.Size = New Size(66, 36)
        btnClear.TabIndex = 1
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
        btnSearch.Location = New Point(4, 2)
        btnSearch.Margin = New Padding(4, 6, 4, 6)
        btnSearch.MouseState = MouseState.HOVER
        btnSearch.Name = "btnSearch"
        btnSearch.NoAccentTextColor = Color.Empty
        btnSearch.Size = New Size(78, 36)
        btnSearch.TabIndex = 0
        btnSearch.Text = "Search"
        btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnSearch.UseAccentColor = False
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' pnlBottom
        ' 
        pnlBottom.Controls.Add(btnDelete)
        pnlBottom.Controls.Add(btnEdit)
        pnlBottom.Controls.Add(btnNew)
        pnlBottom.Dock = DockStyle.Bottom
        pnlBottom.Location = New Point(3, 615)
        pnlBottom.Name = "pnlBottom"
        pnlBottom.Size = New Size(1372, 65)
        pnlBottom.TabIndex = 1
        ' 
        ' btnDelete
        ' 
        btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnDelete.Cursor = Cursors.Hand
        btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnDelete.Depth = 0
        btnDelete.HighEmphasis = True
        btnDelete.Icon = Nothing
        btnDelete.Location = New Point(773, 14)
        btnDelete.Margin = New Padding(4, 6, 4, 6)
        btnDelete.MouseState = MouseState.HOVER
        btnDelete.Name = "btnDelete"
        btnDelete.NoAccentTextColor = Color.Empty
        btnDelete.Size = New Size(73, 36)
        btnDelete.TabIndex = 2
        btnDelete.Text = "Delete"
        btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnDelete.UseAccentColor = False
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.AutoSize = False
        btnEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnEdit.BackColor = SystemColors.Control
        btnEdit.Cursor = Cursors.Hand
        btnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnEdit.Depth = 0
        btnEdit.ForeColor = SystemColors.ControlText
        btnEdit.HighEmphasis = True
        btnEdit.Icon = Nothing
        btnEdit.Location = New Point(606, 14)
        btnEdit.Margin = New Padding(4, 6, 4, 6)
        btnEdit.MouseState = MouseState.HOVER
        btnEdit.Name = "btnEdit"
        btnEdit.NoAccentTextColor = Color.Empty
        btnEdit.Size = New Size(73, 36)
        btnEdit.TabIndex = 1
        btnEdit.Text = "Edit"
        btnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnEdit.UseAccentColor = False
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnNew
        ' 
        btnNew.AutoSize = False
        btnNew.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnNew.BackColor = SystemColors.Control
        btnNew.Cursor = Cursors.Hand
        btnNew.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnNew.Depth = 0
        btnNew.ForeColor = SystemColors.ControlText
        btnNew.HighEmphasis = True
        btnNew.Icon = Nothing
        btnNew.Location = New Point(439, 14)
        btnNew.Margin = New Padding(4, 6, 4, 6)
        btnNew.MouseState = MouseState.HOVER
        btnNew.Name = "btnNew"
        btnNew.NoAccentTextColor = Color.Empty
        btnNew.Size = New Size(73, 36)
        btnNew.TabIndex = 0
        btnNew.Text = "New"
        btnNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnNew.UseAccentColor = False
        btnNew.UseVisualStyleBackColor = False
        ' 
        ' pnlBody
        ' 
        pnlBody.AutoSize = True
        pnlBody.Controls.Add(dgvResults)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(3, 162)
        pnlBody.Name = "pnlBody"
        pnlBody.Size = New Size(1372, 453)
        pnlBody.TabIndex = 5
        ' 
        ' dgvResults
        ' 
        dgvResults.AllowUserToAddRows = False
        dgvResults.AllowUserToDeleteRows = False
        dgvResults.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgvResults.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvResults.AutoGenerateColumns = False
        dgvResults.BorderStyle = BorderStyle.Fixed3D
        dgvResults.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvResults.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvResults.ColumnHeadersHeight = 40
        dgvResults.Columns.AddRange(New DataGridViewColumn() {colId, colName, colPhone, colEmail, colAddress, colCompany, colJobTitle, colDateOfBirth, colNotes})
        dgvResults.ContextMenuStrip = cMnu
        dgvResults.DataSource = ContactBindingSource1
        dgvResults.Dock = DockStyle.Fill
        dgvResults.Location = New Point(0, 0)
        dgvResults.MultiSelect = False
        dgvResults.Name = "dgvResults"
        dgvResults.ReadOnly = True
        dgvResults.RowHeadersVisible = False
        dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvResults.Size = New Size(1372, 453)
        dgvResults.TabIndex = 0
        dgvResults.TabStop = False
        ' 
        ' colId
        ' 
        colId.DataPropertyName = "ContactId"
        colId.HeaderText = "ID"
        colId.Name = "colId"
        colId.ReadOnly = True
        colId.Visible = False
        colId.Width = 50
        ' 
        ' colName
        ' 
        colName.DataPropertyName = "ContactName"
        colName.HeaderText = "Name"
        colName.Name = "colName"
        colName.ReadOnly = True
        colName.Width = 200
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
        colEmail.DataPropertyName = "ContactEmail"
        colEmail.HeaderText = "Email"
        colEmail.Name = "colEmail"
        colEmail.ReadOnly = True
        ' 
        ' colAddress
        ' 
        colAddress.DataPropertyName = "ContactAddress"
        colAddress.HeaderText = "Address"
        colAddress.Name = "colAddress"
        colAddress.ReadOnly = True
        colAddress.Width = 120
        ' 
        ' colCompany
        ' 
        colCompany.DataPropertyName = "ContactCompany"
        colCompany.HeaderText = "Company"
        colCompany.Name = "colCompany"
        colCompany.ReadOnly = True
        ' 
        ' colJobTitle
        ' 
        colJobTitle.DataPropertyName = "ContactJobTitle"
        colJobTitle.HeaderText = "Job Title"
        colJobTitle.Name = "colJobTitle"
        colJobTitle.ReadOnly = True
        ' 
        ' colDateOfBirth
        ' 
        colDateOfBirth.DataPropertyName = "ContactDateOfBirth"
        colDateOfBirth.HeaderText = "Date of birth"
        colDateOfBirth.Name = "colDateOfBirth"
        colDateOfBirth.ReadOnly = True
        colDateOfBirth.Width = 90
        ' 
        ' colNotes
        ' 
        colNotes.DataPropertyName = "ContactNotes"
        colNotes.HeaderText = "Notes"
        colNotes.Name = "colNotes"
        colNotes.ReadOnly = True
        colNotes.Width = 200
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
        ' ContactBindingSource1
        ' 
        ContactBindingSource1.DataSource = GetType(Contact)
        ' 
        ' tbplSearchCriteria
        ' 
        tbplSearchCriteria.AutoSize = True
        tbplSearchCriteria.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tbplSearchCriteria.ColumnCount = 6
        tbplSearchCriteria.ColumnStyles.Add(New ColumnStyle())
        tbplSearchCriteria.ColumnStyles.Add(New ColumnStyle())
        tbplSearchCriteria.ColumnStyles.Add(New ColumnStyle())
        tbplSearchCriteria.ColumnStyles.Add(New ColumnStyle())
        tbplSearchCriteria.ColumnStyles.Add(New ColumnStyle())
        tbplSearchCriteria.ColumnStyles.Add(New ColumnStyle())
        tbplSearchCriteria.Controls.Add(pnlButtons, 5, 1)
        tbplSearchCriteria.Controls.Add(pnlDateOfBirth, 4, 1)
        tbplSearchCriteria.Controls.Add(pnlCompany, 3, 1)
        tbplSearchCriteria.Controls.Add(pnlAddress, 2, 1)
        tbplSearchCriteria.Controls.Add(pnlId, 1, 1)
        tbplSearchCriteria.Controls.Add(pnlNotes, 5, 0)
        tbplSearchCriteria.Controls.Add(pnlJobTitle, 4, 0)
        tbplSearchCriteria.Controls.Add(pnlName, 1, 0)
        tbplSearchCriteria.Controls.Add(pnlEmail, 2, 0)
        tbplSearchCriteria.Controls.Add(pnlPhoneNumber, 3, 0)
        tbplSearchCriteria.Dock = DockStyle.Top
        tbplSearchCriteria.Location = New Point(3, 64)
        tbplSearchCriteria.Name = "tbplSearchCriteria"
        tbplSearchCriteria.Padding = New Padding(90, 0, 0, 0)
        tbplSearchCriteria.RowCount = 1
        tbplSearchCriteria.RowStyles.Add(New RowStyle())
        tbplSearchCriteria.RowStyles.Add(New RowStyle())
        tbplSearchCriteria.Size = New Size(1372, 98)
        tbplSearchCriteria.TabIndex = 0
        ' 
        ' pnlButtons
        ' 
        pnlButtons.AutoSize = True
        pnlButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnlButtons.Controls.Add(btnSearch)
        pnlButtons.Controls.Add(btnClear)
        pnlButtons.Dock = DockStyle.Fill
        pnlButtons.Location = New Point(1036, 51)
        pnlButtons.Name = "pnlButtons"
        pnlButtons.Size = New Size(339, 44)
        pnlButtons.TabIndex = 9
        ' 
        ' pnlDateOfBirth
        ' 
        pnlDateOfBirth.AutoSize = True
        pnlDateOfBirth.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnlDateOfBirth.Controls.Add(lblDateOfBirth)
        pnlDateOfBirth.Controls.Add(txtDateOfBirth)
        pnlDateOfBirth.Dock = DockStyle.Fill
        pnlDateOfBirth.Location = New Point(791, 51)
        pnlDateOfBirth.Name = "pnlDateOfBirth"
        pnlDateOfBirth.Size = New Size(239, 44)
        pnlDateOfBirth.TabIndex = 8
        ' 
        ' pnlCompany
        ' 
        pnlCompany.AutoSize = True
        pnlCompany.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnlCompany.Controls.Add(lblCompany)
        pnlCompany.Controls.Add(txtCompany)
        pnlCompany.Dock = DockStyle.Fill
        pnlCompany.Location = New Point(551, 51)
        pnlCompany.Name = "pnlCompany"
        pnlCompany.Size = New Size(234, 44)
        pnlCompany.TabIndex = 7
        ' 
        ' pnlAddress
        ' 
        pnlAddress.AutoSize = True
        pnlAddress.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnlAddress.Controls.Add(lblAddress)
        pnlAddress.Controls.Add(txtAddress)
        pnlAddress.Dock = DockStyle.Fill
        pnlAddress.Location = New Point(311, 51)
        pnlAddress.Name = "pnlAddress"
        pnlAddress.Size = New Size(234, 44)
        pnlAddress.TabIndex = 6
        ' 
        ' pnlId
        ' 
        pnlId.AutoSize = True
        pnlId.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnlId.Controls.Add(lblId)
        pnlId.Controls.Add(txtId)
        pnlId.Dock = DockStyle.Fill
        pnlId.Location = New Point(93, 51)
        pnlId.Name = "pnlId"
        pnlId.Size = New Size(212, 44)
        pnlId.TabIndex = 5
        ' 
        ' pnlNotes
        ' 
        pnlNotes.AutoSize = True
        pnlNotes.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnlNotes.Controls.Add(lblNotes)
        pnlNotes.Controls.Add(txtNotes)
        pnlNotes.Dock = DockStyle.Fill
        pnlNotes.Location = New Point(1036, 3)
        pnlNotes.Name = "pnlNotes"
        pnlNotes.Size = New Size(339, 42)
        pnlNotes.TabIndex = 4
        ' 
        ' pnlJobTitle
        ' 
        pnlJobTitle.AutoSize = True
        pnlJobTitle.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnlJobTitle.Controls.Add(lblJobTitle)
        pnlJobTitle.Controls.Add(txtJobTitle)
        pnlJobTitle.Dock = DockStyle.Fill
        pnlJobTitle.Location = New Point(791, 3)
        pnlJobTitle.Name = "pnlJobTitle"
        pnlJobTitle.Size = New Size(239, 42)
        pnlJobTitle.TabIndex = 3
        ' 
        ' pnlName
        ' 
        pnlName.AutoSize = True
        pnlName.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnlName.Controls.Add(txtName)
        pnlName.Controls.Add(lblName)
        pnlName.Dock = DockStyle.Fill
        pnlName.Location = New Point(93, 3)
        pnlName.Name = "pnlName"
        pnlName.Size = New Size(212, 42)
        pnlName.TabIndex = 0
        ' 
        ' pnlEmail
        ' 
        pnlEmail.AutoSize = True
        pnlEmail.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnlEmail.Controls.Add(lblEmail)
        pnlEmail.Controls.Add(txtEmail)
        pnlEmail.Dock = DockStyle.Fill
        pnlEmail.Location = New Point(311, 3)
        pnlEmail.Name = "pnlEmail"
        pnlEmail.Size = New Size(234, 42)
        pnlEmail.TabIndex = 1
        ' 
        ' pnlPhoneNumber
        ' 
        pnlPhoneNumber.AutoSize = True
        pnlPhoneNumber.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnlPhoneNumber.Controls.Add(lblPhoneNumber)
        pnlPhoneNumber.Controls.Add(txtPhoneNumber)
        pnlPhoneNumber.Dock = DockStyle.Fill
        pnlPhoneNumber.Location = New Point(551, 3)
        pnlPhoneNumber.Name = "pnlPhoneNumber"
        pnlPhoneNumber.Size = New Size(234, 42)
        pnlPhoneNumber.TabIndex = 2
        ' 
        ' btnMenuControl
        ' 
        btnMenuControl.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnMenuControl.BackColor = Color.Transparent
        btnMenuControl.Cursor = Cursors.Hand
        btnMenuControl.FlatAppearance.BorderSize = 0
        btnMenuControl.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnMenuControl.FlatStyle = FlatStyle.Flat
        btnMenuControl.Image = CType(resources.GetObject("btnMenuControl.Image"), Image)
        btnMenuControl.Location = New Point(3, 64)
        btnMenuControl.Name = "btnMenuControl"
        btnMenuControl.Size = New Size(90, 48)
        btnMenuControl.TabIndex = 2
        btnMenuControl.UseVisualStyleBackColor = False
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1378, 683)
        Controls.Add(btnMenuControl)
        Controls.Add(pnlBody)
        Controls.Add(mnuMenuStrip)
        Controls.Add(tbplSearchCriteria)
        Controls.Add(pnlBottom)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = mnuMenuStrip
        Name = "FrmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Your personal CRM"
        mnuMenuStrip.ResumeLayout(False)
        mnuMenuStrip.PerformLayout()
        pnlBottom.ResumeLayout(False)
        pnlBottom.PerformLayout()
        pnlBody.ResumeLayout(False)
        CType(dgvResults, ComponentModel.ISupportInitialize).EndInit()
        cMnu.ResumeLayout(False)
        CType(ContactBindingSource1, ComponentModel.ISupportInitialize).EndInit()
        CType(ContactBindingSource, ComponentModel.ISupportInitialize).EndInit()
        tbplSearchCriteria.ResumeLayout(False)
        tbplSearchCriteria.PerformLayout()
        pnlButtons.ResumeLayout(False)
        pnlButtons.PerformLayout()
        pnlDateOfBirth.ResumeLayout(False)
        pnlDateOfBirth.PerformLayout()
        pnlCompany.ResumeLayout(False)
        pnlCompany.PerformLayout()
        pnlAddress.ResumeLayout(False)
        pnlAddress.PerformLayout()
        pnlId.ResumeLayout(False)
        pnlId.PerformLayout()
        pnlNotes.ResumeLayout(False)
        pnlNotes.PerformLayout()
        pnlJobTitle.ResumeLayout(False)
        pnlJobTitle.PerformLayout()
        pnlName.ResumeLayout(False)
        pnlName.PerformLayout()
        pnlEmail.ResumeLayout(False)
        pnlEmail.PerformLayout()
        pnlPhoneNumber.ResumeLayout(False)
        pnlPhoneNumber.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents mnuMenuStrip As MenuStrip
    Friend WithEvents mnuItmHelp As ToolStripMenuItem
    Friend WithEvents mnuItmAbout As ToolStripMenuItem
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
    Friend WithEvents dgvResults As DataGridView
    Friend WithEvents lblEmail As Controls.MaterialLabel
    Friend WithEvents txtEmail As Controls.MaterialTextBox
    Friend WithEvents mnuItmSettings As ToolStripMenuItem
    Friend WithEvents mnuItmTheme As ToolStripMenuItem
    Friend WithEvents mnuItmDarkModeGreen As ToolStripMenuItem
    Friend WithEvents mnuItmLightModeBlue As ToolStripMenuItem
    Friend WithEvents mnuItmDarkModePurple As ToolStripMenuItem
    Friend WithEvents mnuItmLightModeGreen As ToolStripMenuItem
    Friend WithEvents cMnu As ContextMenuStrip
    Friend WithEvents cMnuExport As ToolStripMenuItem
    Friend WithEvents mnuItmData As ToolStripMenuItem
    Friend WithEvents mnuItmExportData As ToolStripMenuItem
    Friend WithEvents mnuItmImportData As ToolStripMenuItem
    Friend WithEvents mnuItmPurge As ToolStripMenuItem
    Friend WithEvents mnuItmContacts As ToolStripMenuItem
    Friend WithEvents mnuItmMassEmail As ToolStripMenuItem
    Friend WithEvents btnDelete As Controls.MaterialButton
    Friend WithEvents mnuItmCreateContact As ToolStripMenuItem
    Friend WithEvents mnuItmEditContact As ToolStripMenuItem
    Friend WithEvents mnuItmDeleteContact As ToolStripMenuItem
    Friend WithEvents mnuItmConfigureFields As ToolStripMenuItem
    Friend WithEvents ContactBindingSource As BindingSource
    Friend WithEvents ContactBindingSource1 As BindingSource
    Friend WithEvents mnuItmViewErrorLogs As ToolStripMenuItem
    Friend WithEvents lblCompany As Controls.MaterialLabel
    Friend WithEvents txtCompany As Controls.MaterialTextBox
    Friend WithEvents lblAddress As Controls.MaterialLabel
    Friend WithEvents txtAddress As Controls.MaterialTextBox
    Friend WithEvents lblId As Controls.MaterialLabel
    Friend WithEvents txtId As Controls.MaterialTextBox
    Friend WithEvents lblNotes As Controls.MaterialLabel
    Friend WithEvents txtNotes As Controls.MaterialTextBox
    Friend WithEvents lblDateOfBirth As Controls.MaterialLabel
    Friend WithEvents txtDateOfBirth As Controls.MaterialTextBox
    Friend WithEvents lblJobTitle As Controls.MaterialLabel
    Friend WithEvents txtJobTitle As Controls.MaterialTextBox
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colPhone As DataGridViewTextBoxColumn
    Friend WithEvents colEmail As DataGridViewTextBoxColumn
    Friend WithEvents colAddress As DataGridViewTextBoxColumn
    Friend WithEvents colCompany As DataGridViewTextBoxColumn
    Friend WithEvents colJobTitle As DataGridViewTextBoxColumn
    Friend WithEvents colDateOfBirth As DataGridViewTextBoxColumn
    Friend WithEvents colNotes As DataGridViewTextBoxColumn
    Friend WithEvents tbplSearchCriteria As TableLayoutPanel
    Friend WithEvents pnlId As Panel
    Friend WithEvents pnlNotes As Panel
    Friend WithEvents pnlJobTitle As Panel
    Friend WithEvents pnlName As Panel
    Friend WithEvents pnlEmail As Panel
    Friend WithEvents pnlPhoneNumber As Panel
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents pnlDateOfBirth As Panel
    Friend WithEvents pnlCompany As Panel
    Friend WithEvents pnlAddress As Panel
    Friend WithEvents btnMenuControl As Button
    Friend WithEvents mnuItmPurgeContacts As ToolStripMenuItem
    Friend WithEvents mnuItmPurgePreferences As ToolStripMenuItem
    Friend WithEvents mnuItmPurgeAll As ToolStripMenuItem

End Class
