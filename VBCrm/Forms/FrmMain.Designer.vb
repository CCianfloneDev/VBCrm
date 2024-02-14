<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        mnuItmMenu = New ToolStripMenuItem()
        mnuItmContacts = New ToolStripMenuItem()
        mnuItmMassEmail = New ToolStripMenuItem()
        mnuItmCreateContact = New ToolStripMenuItem()
        mnuItmEditContact = New ToolStripMenuItem()
        mnuItmDeleteContact = New ToolStripMenuItem()
        mnuItmData = New ToolStripMenuItem()
        mnuItmImportData = New ToolStripMenuItem()
        mnuItmExportData = New ToolStripMenuItem()
        mnuItmPurgeData = New ToolStripMenuItem()
        mnuItmSettings = New ToolStripMenuItem()
        mnuItmTheme = New ToolStripMenuItem()
        mnuItmDarkModePurple = New ToolStripMenuItem()
        mnuItmDarkModeGreen = New ToolStripMenuItem()
        mnuItmLightModeBlue = New ToolStripMenuItem()
        mnuItmLightModeGreen = New ToolStripMenuItem()
        mnuItmEditGrid = New ToolStripMenuItem()
        mnuItmHelp = New ToolStripMenuItem()
        mnuItmAbout = New ToolStripMenuItem()
        mnuItmViewErrorLogs = New ToolStripMenuItem()
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
        mnuMenuStrip.SuspendLayout()
        pnlSearchCriteria.SuspendLayout()
        pnlBottom.SuspendLayout()
        pnlBody.SuspendLayout()
        CType(dgvResults, ComponentModel.ISupportInitialize).BeginInit()
        cMnu.SuspendLayout()
        CType(ContactBindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ContactBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' mnuMenuStrip
        ' 
        mnuMenuStrip.AllowItemReorder = True
        mnuMenuStrip.AutoSize = False
        mnuMenuStrip.Dock = DockStyle.Left
        mnuMenuStrip.Items.AddRange(New ToolStripItem() {mnuItmMenu, mnuItmContacts, mnuItmData, mnuItmSettings, mnuItmHelp})
        mnuMenuStrip.LayoutStyle = ToolStripLayoutStyle.Table
        mnuMenuStrip.Location = New Point(3, 64)
        mnuMenuStrip.Name = "mnuMenuStrip"
        mnuMenuStrip.Size = New Size(87, 616)
        mnuMenuStrip.TabIndex = 0
        ' 
        ' mnuItmMenu
        ' 
        mnuItmMenu.AutoSize = False
        mnuItmMenu.BackColor = SystemColors.Control
        mnuItmMenu.DisplayStyle = ToolStripItemDisplayStyle.Image
        mnuItmMenu.Image = CType(resources.GetObject("mnuItmMenu.Image"), Image)
        mnuItmMenu.ImageScaling = ToolStripItemImageScaling.None
        mnuItmMenu.Name = "mnuItmMenu"
        mnuItmMenu.ShowShortcutKeys = False
        mnuItmMenu.Size = New Size(80, 80)
        ' 
        ' mnuItmContacts
        ' 
        mnuItmContacts.AutoSize = False
        mnuItmContacts.BackColor = SystemColors.Control
        mnuItmContacts.BackgroundImageLayout = ImageLayout.None
        mnuItmContacts.DisplayStyle = ToolStripItemDisplayStyle.Image
        mnuItmContacts.DropDownItems.AddRange(New ToolStripItem() {mnuItmMassEmail, mnuItmCreateContact, mnuItmEditContact, mnuItmDeleteContact})
        mnuItmContacts.Image = CType(resources.GetObject("mnuItmContacts.Image"), Image)
        mnuItmContacts.ImageAlign = ContentAlignment.MiddleLeft
        mnuItmContacts.ImageScaling = ToolStripItemImageScaling.None
        mnuItmContacts.Name = "mnuItmContacts"
        mnuItmContacts.Size = New Size(60, 100)
        mnuItmContacts.Visible = False
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
        mnuItmData.DropDownItems.AddRange(New ToolStripItem() {mnuItmImportData, mnuItmExportData, mnuItmPurgeData})
        mnuItmData.Image = CType(resources.GetObject("mnuItmData.Image"), Image)
        mnuItmData.ImageAlign = ContentAlignment.MiddleRight
        mnuItmData.ImageScaling = ToolStripItemImageScaling.None
        mnuItmData.Name = "mnuItmData"
        mnuItmData.Size = New Size(62, 100)
        mnuItmData.Text = "&Data"
        mnuItmData.Visible = False
        ' 
        ' mnuItmImportData
        ' 
        mnuItmImportData.Name = "mnuItmImportData"
        mnuItmImportData.Size = New Size(180, 22)
        mnuItmImportData.Text = "Import data"
        ' 
        ' mnuItmExportData
        ' 
        mnuItmExportData.Name = "mnuItmExportData"
        mnuItmExportData.Size = New Size(180, 22)
        mnuItmExportData.Text = "Export data"
        ' 
        ' mnuItmPurgeData
        ' 
        mnuItmPurgeData.Name = "mnuItmPurgeData"
        mnuItmPurgeData.Size = New Size(180, 22)
        mnuItmPurgeData.Text = "Purge all data"
        ' 
        ' mnuItmSettings
        ' 
        mnuItmSettings.AutoSize = False
        mnuItmSettings.DisplayStyle = ToolStripItemDisplayStyle.Image
        mnuItmSettings.DropDownItems.AddRange(New ToolStripItem() {mnuItmTheme, mnuItmEditGrid})
        mnuItmSettings.Image = CType(resources.GetObject("mnuItmSettings.Image"), Image)
        mnuItmSettings.ImageAlign = ContentAlignment.MiddleRight
        mnuItmSettings.ImageScaling = ToolStripItemImageScaling.None
        mnuItmSettings.Name = "mnuItmSettings"
        mnuItmSettings.Size = New Size(60, 100)
        mnuItmSettings.Text = "&Settings"
        mnuItmSettings.Visible = False
        ' 
        ' mnuItmTheme
        ' 
        mnuItmTheme.DropDownItems.AddRange(New ToolStripItem() {mnuItmDarkModePurple, mnuItmDarkModeGreen, mnuItmLightModeBlue, mnuItmLightModeGreen})
        mnuItmTheme.Name = "mnuItmTheme"
        mnuItmTheme.Size = New Size(180, 22)
        mnuItmTheme.Text = "Theme"
        ' 
        ' mnuItmDarkModePurple
        ' 
        mnuItmDarkModePurple.Name = "mnuItmDarkModePurple"
        mnuItmDarkModePurple.Size = New Size(180, 22)
        mnuItmDarkModePurple.Text = "Dark mode - Purple"
        ' 
        ' mnuItmDarkModeGreen
        ' 
        mnuItmDarkModeGreen.Name = "mnuItmDarkModeGreen"
        mnuItmDarkModeGreen.Size = New Size(180, 22)
        mnuItmDarkModeGreen.Text = "Dark mode - Green"
        ' 
        ' mnuItmLightModeBlue
        ' 
        mnuItmLightModeBlue.Name = "mnuItmLightModeBlue"
        mnuItmLightModeBlue.Size = New Size(180, 22)
        mnuItmLightModeBlue.Text = "Light mode - Blue"
        ' 
        ' mnuItmLightModeGreen
        ' 
        mnuItmLightModeGreen.Name = "mnuItmLightModeGreen"
        mnuItmLightModeGreen.Size = New Size(180, 22)
        mnuItmLightModeGreen.Text = "Light mode - Green"
        ' 
        ' mnuItmEditGrid
        ' 
        mnuItmEditGrid.Name = "mnuItmEditGrid"
        mnuItmEditGrid.Size = New Size(180, 22)
        mnuItmEditGrid.Text = "Edit grid..."
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
        mnuItmHelp.Visible = False
        ' 
        ' mnuItmAbout
        ' 
        mnuItmAbout.Name = "mnuItmAbout"
        mnuItmAbout.ShortcutKeys = Keys.Alt Or Keys.A
        mnuItmAbout.Size = New Size(201, 22)
        mnuItmAbout.Text = "About..."
        ' 
        ' mnuItmViewErrorLogs
        ' 
        mnuItmViewErrorLogs.Name = "mnuItmViewErrorLogs"
        mnuItmViewErrorLogs.ShortcutKeys = Keys.Alt Or Keys.V
        mnuItmViewErrorLogs.Size = New Size(201, 22)
        mnuItmViewErrorLogs.Text = "View Error Logs..."
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
        pnlSearchCriteria.Location = New Point(90, 64)
        pnlSearchCriteria.Name = "pnlSearchCriteria"
        pnlSearchCriteria.Size = New Size(1054, 105)
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
        lblName.Location = New Point(24, 11)
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
        txtName.Location = New Point(90, 9)
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
        pnlBottom.Controls.Add(btnDelete)
        pnlBottom.Controls.Add(btnEdit)
        pnlBottom.Controls.Add(btnNew)
        pnlBottom.Dock = DockStyle.Bottom
        pnlBottom.Location = New Point(90, 615)
        pnlBottom.Name = "pnlBottom"
        pnlBottom.Size = New Size(1054, 65)
        pnlBottom.TabIndex = 4
        ' 
        ' btnDelete
        ' 
        btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnDelete.Cursor = Cursors.Hand
        btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnDelete.Depth = 0
        btnDelete.HighEmphasis = True
        btnDelete.Icon = Nothing
        btnDelete.Location = New Point(655, 14)
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
        btnEdit.Location = New Point(488, 14)
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
        btnNew.Location = New Point(321, 14)
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
        pnlBody.Controls.Add(dgvResults)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(90, 169)
        pnlBody.Name = "pnlBody"
        pnlBody.Size = New Size(1054, 446)
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
        dgvResults.BorderStyle = BorderStyle.None
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
        dgvResults.Size = New Size(1054, 446)
        dgvResults.TabIndex = 0
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
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1147, 683)
        Controls.Add(pnlBody)
        Controls.Add(pnlBottom)
        Controls.Add(pnlSearchCriteria)
        Controls.Add(mnuMenuStrip)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
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
        CType(ContactBindingSource1, ComponentModel.ISupportInitialize).EndInit()
        CType(ContactBindingSource, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents mnuMenuStrip As MenuStrip
    Friend WithEvents mnuItmMenu As ToolStripMenuItem
    Friend WithEvents mnuItmHelp As ToolStripMenuItem
    Friend WithEvents mnuItmAbout As ToolStripMenuItem
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
    Friend WithEvents mnuItmPurgeData As ToolStripMenuItem
    Friend WithEvents mnuItmContacts As ToolStripMenuItem
    Friend WithEvents mnuItmMassEmail As ToolStripMenuItem
    Friend WithEvents btnDelete As Controls.MaterialButton
    Friend WithEvents mnuItmCreateContact As ToolStripMenuItem
    Friend WithEvents mnuItmEditContact As ToolStripMenuItem
    Friend WithEvents mnuItmDeleteContact As ToolStripMenuItem
    Friend WithEvents mnuItmEditGrid As ToolStripMenuItem
    Friend WithEvents ContactBindingSource As BindingSource
    Friend WithEvents ContactBindingSource1 As BindingSource
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colPhone As DataGridViewTextBoxColumn
    Friend WithEvents colEmail As DataGridViewTextBoxColumn
    Friend WithEvents colAddress As DataGridViewTextBoxColumn
    Friend WithEvents colCompany As DataGridViewTextBoxColumn
    Friend WithEvents colJobTitle As DataGridViewTextBoxColumn
    Friend WithEvents colDateOfBirth As DataGridViewTextBoxColumn
    Friend WithEvents colNotes As DataGridViewTextBoxColumn
    Friend WithEvents mnuItmViewErrorLogs As ToolStripMenuItem

End Class
