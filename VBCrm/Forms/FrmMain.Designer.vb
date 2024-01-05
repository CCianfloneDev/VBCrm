<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

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
        mnuMenuStrip = New MenuStrip()
        mnuItmFile = New ToolStripMenuItem()
        mnuItmExit = New ToolStripMenuItem()
        mnuItmHelp = New ToolStripMenuItem()
        mnuItmAbout = New ToolStripMenuItem()
        staStatusStrip = New StatusStrip()
        lblSearchCriteria = New Label()
        pnlSearchCriteria = New Panel()
        btnClear = New Button()
        btnSearch = New Button()
        txtPhoneNumber = New TextBox()
        lblPhoneNumber = New Label()
        txtName = New TextBox()
        lblName = New Label()
        pnlBottom = New Panel()
        btnEdit = New Button()
        btnNew = New Button()
        pnlBody = New Panel()
        dgvResults = New DataGridView()
        mnuMenuStrip.SuspendLayout()
        pnlSearchCriteria.SuspendLayout()
        pnlBottom.SuspendLayout()
        pnlBody.SuspendLayout()
        CType(dgvResults, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' mnuMenuStrip
        ' 
        mnuMenuStrip.Items.AddRange(New ToolStripItem() {mnuItmFile, mnuItmHelp})
        mnuMenuStrip.Location = New Point(0, 0)
        mnuMenuStrip.Name = "mnuMenuStrip"
        mnuMenuStrip.Size = New Size(800, 24)
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
        staStatusStrip.Location = New Point(0, 428)
        staStatusStrip.Name = "staStatusStrip"
        staStatusStrip.Size = New Size(800, 22)
        staStatusStrip.TabIndex = 1
        staStatusStrip.Text = "StatusStrip1"
        ' 
        ' lblSearchCriteria
        ' 
        lblSearchCriteria.AutoSize = True
        lblSearchCriteria.Dock = DockStyle.Top
        lblSearchCriteria.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSearchCriteria.Location = New Point(0, 24)
        lblSearchCriteria.Name = "lblSearchCriteria"
        lblSearchCriteria.Size = New Size(121, 21)
        lblSearchCriteria.TabIndex = 2
        lblSearchCriteria.Text = "Search Criteria"
        ' 
        ' pnlSearchCriteria
        ' 
        pnlSearchCriteria.Controls.Add(btnClear)
        pnlSearchCriteria.Controls.Add(btnSearch)
        pnlSearchCriteria.Controls.Add(txtPhoneNumber)
        pnlSearchCriteria.Controls.Add(lblPhoneNumber)
        pnlSearchCriteria.Controls.Add(txtName)
        pnlSearchCriteria.Controls.Add(lblName)
        pnlSearchCriteria.Dock = DockStyle.Top
        pnlSearchCriteria.Location = New Point(0, 45)
        pnlSearchCriteria.Name = "pnlSearchCriteria"
        pnlSearchCriteria.Size = New Size(800, 84)
        pnlSearchCriteria.TabIndex = 3
        ' 
        ' btnClear
        ' 
        btnClear.Cursor = Cursors.Hand
        btnClear.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(713, 35)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 5
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Cursor = Cursors.Hand
        btnSearch.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(632, 35)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(75, 23)
        btnSearch.TabIndex = 4
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(69, 51)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(159, 23)
        txtPhoneNumber.TabIndex = 3
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Location = New Point(12, 54)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(51, 15)
        lblPhoneNumber.TabIndex = 2
        lblPhoneNumber.Text = "Phone #"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(69, 17)
        txtName.Name = "txtName"
        txtName.Size = New Size(159, 23)
        txtName.TabIndex = 1
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(24, 20)
        lblName.Name = "lblName"
        lblName.Size = New Size(39, 15)
        lblName.TabIndex = 0
        lblName.Text = "Name"
        ' 
        ' pnlBottom
        ' 
        pnlBottom.Controls.Add(btnEdit)
        pnlBottom.Controls.Add(btnNew)
        pnlBottom.Dock = DockStyle.Bottom
        pnlBottom.Location = New Point(0, 363)
        pnlBottom.Name = "pnlBottom"
        pnlBottom.Size = New Size(800, 65)
        pnlBottom.TabIndex = 4
        ' 
        ' btnEdit
        ' 
        btnEdit.Cursor = Cursors.Hand
        btnEdit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEdit.Location = New Point(403, 21)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 23)
        btnEdit.TabIndex = 7
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnNew
        ' 
        btnNew.Cursor = Cursors.Hand
        btnNew.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNew.Location = New Point(322, 21)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(75, 23)
        btnNew.TabIndex = 6
        btnNew.Text = "New"
        btnNew.UseVisualStyleBackColor = True
        ' 
        ' pnlBody
        ' 
        pnlBody.Controls.Add(dgvResults)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(0, 129)
        pnlBody.Name = "pnlBody"
        pnlBody.Size = New Size(800, 234)
        pnlBody.TabIndex = 5
        ' 
        ' dgvResults
        ' 
        dgvResults.AllowUserToAddRows = False
        dgvResults.AllowUserToDeleteRows = False
        dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvResults.Dock = DockStyle.Fill
        dgvResults.Location = New Point(0, 0)
        dgvResults.Name = "dgvResults"
        dgvResults.ReadOnly = True
        dgvResults.Size = New Size(800, 234)
        dgvResults.TabIndex = 0
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(pnlBody)
        Controls.Add(pnlBottom)
        Controls.Add(pnlSearchCriteria)
        Controls.Add(lblSearchCriteria)
        Controls.Add(staStatusStrip)
        Controls.Add(mnuMenuStrip)
        MainMenuStrip = mnuMenuStrip
        Name = "FrmMain"
        Text = "VBCrm - Main Form"
        mnuMenuStrip.ResumeLayout(False)
        mnuMenuStrip.PerformLayout()
        pnlSearchCriteria.ResumeLayout(False)
        pnlSearchCriteria.PerformLayout()
        pnlBottom.ResumeLayout(False)
        pnlBody.ResumeLayout(False)
        CType(dgvResults, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents mnuMenuStrip As MenuStrip
    Friend WithEvents mnuItmFile As ToolStripMenuItem
    Friend WithEvents mnuItmExit As ToolStripMenuItem
    Friend WithEvents mnuItmHelp As ToolStripMenuItem
    Friend WithEvents mnuItmAbout As ToolStripMenuItem
    Friend WithEvents staStatusStrip As StatusStrip
    Friend WithEvents lblSearchCriteria As Label
    Friend WithEvents pnlSearchCriteria As Panel
    Friend WithEvents pnlBottom As Panel
    Friend WithEvents pnlBody As Panel
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvResults As DataGridView
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnNew As Button

End Class
