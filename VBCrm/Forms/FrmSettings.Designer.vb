<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettings
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblGridSettings = New Controls.MaterialLabel()
        pnlGridSettings = New Panel()
        lblSearchCriteria = New Controls.MaterialLabel()
        pnlSearchCriteria = New Panel()
        btnGridSettingsCollapse = New Controls.MaterialButton()
        btnSearchFieldsCollapse = New Controls.MaterialButton()
        tbplBody = New TableLayoutPanel()
        tbplBody.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblGridSettings
        ' 
        lblGridSettings.AutoSize = True
        lblGridSettings.Depth = 0
        lblGridSettings.Dock = DockStyle.Right
        lblGridSettings.Font = New Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblGridSettings.FontType = MaterialSkinManager.fontType.H5
        lblGridSettings.Location = New Point(16, 0)
        lblGridSettings.MouseState = MouseState.HOVER
        lblGridSettings.Name = "lblGridSettings"
        lblGridSettings.Size = New Size(146, 29)
        lblGridSettings.TabIndex = 0
        lblGridSettings.Text = "Grid Columns"
        ' 
        ' pnlGridSettings
        ' 
        pnlGridSettings.AutoSize = True
        pnlGridSettings.BorderStyle = BorderStyle.FixedSingle
        tbplBody.SetColumnSpan(pnlGridSettings, 2)
        pnlGridSettings.Dock = DockStyle.Fill
        pnlGridSettings.Location = New Point(3, 32)
        pnlGridSettings.Name = "pnlGridSettings"
        pnlGridSettings.Size = New Size(496, 2)
        pnlGridSettings.TabIndex = 1
        ' 
        ' lblSearchCriteria
        ' 
        lblSearchCriteria.AutoSize = True
        lblSearchCriteria.Depth = 0
        lblSearchCriteria.Dock = DockStyle.Right
        lblSearchCriteria.Font = New Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblSearchCriteria.FontType = MaterialSkinManager.fontType.H5
        lblSearchCriteria.Location = New Point(3, 37)
        lblSearchCriteria.MouseState = MouseState.HOVER
        lblSearchCriteria.Name = "lblSearchCriteria"
        lblSearchCriteria.Size = New Size(159, 29)
        lblSearchCriteria.TabIndex = 3
        lblSearchCriteria.Text = "Search Criteria"
        ' 
        ' pnlSearchCriteria
        ' 
        pnlSearchCriteria.AutoSize = True
        pnlSearchCriteria.BorderStyle = BorderStyle.FixedSingle
        tbplBody.SetColumnSpan(pnlSearchCriteria, 2)
        pnlSearchCriteria.Dock = DockStyle.Fill
        pnlSearchCriteria.Location = New Point(3, 69)
        pnlSearchCriteria.Name = "pnlSearchCriteria"
        pnlSearchCriteria.Size = New Size(496, 327)
        pnlSearchCriteria.TabIndex = 2
        ' 
        ' btnGridSettingsCollapse
        ' 
        btnGridSettingsCollapse.AutoSize = False
        btnGridSettingsCollapse.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnGridSettingsCollapse.Cursor = Cursors.Hand
        btnGridSettingsCollapse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnGridSettingsCollapse.Depth = 0
        btnGridSettingsCollapse.Dock = DockStyle.Left
        btnGridSettingsCollapse.HighEmphasis = True
        btnGridSettingsCollapse.Icon = Nothing
        btnGridSettingsCollapse.Location = New Point(169, 6)
        btnGridSettingsCollapse.Margin = New Padding(4, 6, 4, 6)
        btnGridSettingsCollapse.MouseState = MouseState.HOVER
        btnGridSettingsCollapse.Name = "btnGridSettingsCollapse"
        btnGridSettingsCollapse.NoAccentTextColor = Color.Empty
        btnGridSettingsCollapse.Size = New Size(73, 17)
        btnGridSettingsCollapse.TabIndex = 5
        btnGridSettingsCollapse.Text = "Collapse"
        btnGridSettingsCollapse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        btnGridSettingsCollapse.UseAccentColor = False
        btnGridSettingsCollapse.UseVisualStyleBackColor = True
        ' 
        ' btnSearchFieldsCollapse
        ' 
        btnSearchFieldsCollapse.AutoSize = False
        btnSearchFieldsCollapse.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSearchFieldsCollapse.Cursor = Cursors.Hand
        btnSearchFieldsCollapse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnSearchFieldsCollapse.Depth = 0
        btnSearchFieldsCollapse.Dock = DockStyle.Left
        btnSearchFieldsCollapse.HighEmphasis = True
        btnSearchFieldsCollapse.Icon = Nothing
        btnSearchFieldsCollapse.Location = New Point(169, 43)
        btnSearchFieldsCollapse.Margin = New Padding(4, 6, 4, 6)
        btnSearchFieldsCollapse.MouseState = MouseState.HOVER
        btnSearchFieldsCollapse.Name = "btnSearchFieldsCollapse"
        btnSearchFieldsCollapse.NoAccentTextColor = Color.Empty
        btnSearchFieldsCollapse.Size = New Size(73, 17)
        btnSearchFieldsCollapse.TabIndex = 4
        btnSearchFieldsCollapse.Text = "Collapse"
        btnSearchFieldsCollapse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        btnSearchFieldsCollapse.UseAccentColor = False
        btnSearchFieldsCollapse.UseVisualStyleBackColor = True
        ' 
        ' tbplBody
        ' 
        tbplBody.AutoSize = True
        tbplBody.ColumnCount = 2
        tbplBody.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.00971F))
        tbplBody.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 66.99029F))
        tbplBody.Controls.Add(btnGridSettingsCollapse, 1, 0)
        tbplBody.Controls.Add(pnlSearchCriteria, 0, 3)
        tbplBody.Controls.Add(pnlGridSettings, 0, 1)
        tbplBody.Controls.Add(btnSearchFieldsCollapse, 1, 2)
        tbplBody.Controls.Add(lblSearchCriteria, 0, 2)
        tbplBody.Controls.Add(lblGridSettings, 0, 0)
        tbplBody.Dock = DockStyle.Fill
        tbplBody.Location = New Point(3, 64)
        tbplBody.Name = "tbplBody"
        tbplBody.RowCount = 4
        tbplBody.RowStyles.Add(New RowStyle())
        tbplBody.RowStyles.Add(New RowStyle())
        tbplBody.RowStyles.Add(New RowStyle())
        tbplBody.RowStyles.Add(New RowStyle())
        tbplBody.Size = New Size(502, 399)
        tbplBody.TabIndex = 6
        ' 
        ' FrmSettings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(508, 466)
        Controls.Add(tbplBody)
        MinimumSize = New Size(508, 143)
        Name = "FrmSettings"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Settings"
        tbplBody.ResumeLayout(False)
        tbplBody.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents pnlBody As Panel
    Friend WithEvents pnlGridSettings As Panel
    Friend WithEvents lblGridSettings As Controls.MaterialLabel
    Friend WithEvents pnlSearchCriteria As Panel
    Friend WithEvents lblSearchCriteria As Controls.MaterialLabel
    Friend WithEvents btnGridSettingsCollapse As Controls.MaterialButton
    Friend WithEvents btnSearchFieldsCollapse As Controls.MaterialButton
    Friend WithEvents tbplBody As TableLayoutPanel
End Class
