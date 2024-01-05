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
        mnuMenuStrip = New MenuStrip()
        mnuItmFile = New ToolStripMenuItem()
        mnuItmExit = New ToolStripMenuItem()
        mnuItmHelp = New ToolStripMenuItem()
        mnuItmAbout = New ToolStripMenuItem()
        staStatusStrip = New StatusStrip()
        pnlSearchCriteria = New Panel()
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
        ContactidDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        ContactnameDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        ContactphoneDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        ContactemailDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        ContactBindingSource = New BindingSource(components)
        lblSearchCriteria = New Controls.MaterialLabel()
        mnuMenuStrip.SuspendLayout()
        pnlSearchCriteria.SuspendLayout()
        pnlBottom.SuspendLayout()
        pnlBody.SuspendLayout()
        CType(dgvResults, ComponentModel.ISupportInitialize).BeginInit()
        CType(ContactBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' mnuMenuStrip
        ' 
        mnuMenuStrip.Items.AddRange(New ToolStripItem() {mnuItmFile, mnuItmHelp})
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
        txtName.TabIndex = 13
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
        txtPhoneNumber.TabIndex = 12
        txtPhoneNumber.Text = ""
        txtPhoneNumber.TrailingIcon = Nothing
        txtPhoneNumber.UseTallSize = False
        ' 
        ' btnClear
        ' 
        btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnClear.BackColor = SystemColors.Control
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
        btnClear.TabIndex = 11
        btnClear.Text = "Clear"
        btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnClear.UseAccentColor = False
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSearch.BackColor = SystemColors.Control
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
        btnSearch.TabIndex = 10
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
        btnEdit.TabIndex = 9
        btnEdit.Text = "Edit"
        btnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnEdit.UseAccentColor = False
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnNew
        ' 
        btnNew.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnNew.BackColor = SystemColors.Control
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
        btnNew.TabIndex = 8
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
        dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvResults.Columns.AddRange(New DataGridViewColumn() {ContactidDataGridViewTextBoxColumn, ContactnameDataGridViewTextBoxColumn, ContactphoneDataGridViewTextBoxColumn, ContactemailDataGridViewTextBoxColumn})
        dgvResults.DataSource = ContactBindingSource
        dgvResults.Dock = DockStyle.Fill
        dgvResults.Location = New Point(0, 0)
        dgvResults.Name = "dgvResults"
        dgvResults.ReadOnly = True
        dgvResults.Size = New Size(794, 213)
        dgvResults.TabIndex = 0
        ' 
        ' ContactidDataGridViewTextBoxColumn
        ' 
        ContactidDataGridViewTextBoxColumn.DataPropertyName = "Contact_id"
        ContactidDataGridViewTextBoxColumn.HeaderText = "Contact_id"
        ContactidDataGridViewTextBoxColumn.Name = "ContactidDataGridViewTextBoxColumn"
        ContactidDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' ContactnameDataGridViewTextBoxColumn
        ' 
        ContactnameDataGridViewTextBoxColumn.DataPropertyName = "Contact_name"
        ContactnameDataGridViewTextBoxColumn.HeaderText = "Contact_name"
        ContactnameDataGridViewTextBoxColumn.Name = "ContactnameDataGridViewTextBoxColumn"
        ContactnameDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' ContactphoneDataGridViewTextBoxColumn
        ' 
        ContactphoneDataGridViewTextBoxColumn.DataPropertyName = "Contact_phone"
        ContactphoneDataGridViewTextBoxColumn.HeaderText = "Contact_phone"
        ContactphoneDataGridViewTextBoxColumn.Name = "ContactphoneDataGridViewTextBoxColumn"
        ContactphoneDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' ContactemailDataGridViewTextBoxColumn
        ' 
        ContactemailDataGridViewTextBoxColumn.DataPropertyName = "Contact_email"
        ContactemailDataGridViewTextBoxColumn.HeaderText = "Contact_email"
        ContactemailDataGridViewTextBoxColumn.Name = "ContactemailDataGridViewTextBoxColumn"
        ContactemailDataGridViewTextBoxColumn.ReadOnly = True
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
    Friend WithEvents ContactBindingSource As BindingSource
    Friend WithEvents ContactidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactphoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactemailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn

End Class
