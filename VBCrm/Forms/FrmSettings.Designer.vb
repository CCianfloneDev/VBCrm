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
        pnlBody = New Panel()
        pnlSearchCriteria = New Panel()
        lblSearchCriteria = New Controls.MaterialLabel()
        pnlGridSettings = New Panel()
        lblGridSettings = New Controls.MaterialLabel()
        pnlBody.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlBody
        ' 
        pnlBody.AutoSize = True
        pnlBody.Controls.Add(pnlSearchCriteria)
        pnlBody.Controls.Add(lblSearchCriteria)
        pnlBody.Controls.Add(pnlGridSettings)
        pnlBody.Controls.Add(lblGridSettings)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(3, 64)
        pnlBody.Name = "pnlBody"
        pnlBody.Size = New Size(476, 326)
        pnlBody.TabIndex = 7
        ' 
        ' pnlSearchCriteria
        ' 
        pnlSearchCriteria.AutoSize = True
        pnlSearchCriteria.BorderStyle = BorderStyle.FixedSingle
        pnlSearchCriteria.Dock = DockStyle.Fill
        pnlSearchCriteria.Location = New Point(0, 60)
        pnlSearchCriteria.Name = "pnlSearchCriteria"
        pnlSearchCriteria.Size = New Size(476, 266)
        pnlSearchCriteria.TabIndex = 2
        ' 
        ' lblSearchCriteria
        ' 
        lblSearchCriteria.AutoSize = True
        lblSearchCriteria.Depth = 0
        lblSearchCriteria.Dock = DockStyle.Top
        lblSearchCriteria.Font = New Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblSearchCriteria.FontType = MaterialSkinManager.fontType.H5
        lblSearchCriteria.Location = New Point(0, 31)
        lblSearchCriteria.MouseState = MouseState.HOVER
        lblSearchCriteria.Name = "lblSearchCriteria"
        lblSearchCriteria.Size = New Size(159, 29)
        lblSearchCriteria.TabIndex = 3
        lblSearchCriteria.Text = "Search Criteria"
        ' 
        ' pnlGridSettings
        ' 
        pnlGridSettings.AutoSize = True
        pnlGridSettings.BorderStyle = BorderStyle.FixedSingle
        pnlGridSettings.Dock = DockStyle.Top
        pnlGridSettings.Location = New Point(0, 29)
        pnlGridSettings.Name = "pnlGridSettings"
        pnlGridSettings.Size = New Size(476, 2)
        pnlGridSettings.TabIndex = 1
        ' 
        ' lblGridSettings
        ' 
        lblGridSettings.AutoSize = True
        lblGridSettings.Depth = 0
        lblGridSettings.Dock = DockStyle.Top
        lblGridSettings.Font = New Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblGridSettings.FontType = MaterialSkinManager.fontType.H5
        lblGridSettings.Location = New Point(0, 0)
        lblGridSettings.MouseState = MouseState.HOVER
        lblGridSettings.Name = "lblGridSettings"
        lblGridSettings.Size = New Size(146, 29)
        lblGridSettings.TabIndex = 0
        lblGridSettings.Text = "Grid Columns"
        ' 
        ' FrmSettings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(482, 393)
        Controls.Add(pnlBody)
        Name = "FrmSettings"
        StartPosition = FormStartPosition.CenterParent
        Text = "Settings"
        pnlBody.ResumeLayout(False)
        pnlBody.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents pnlBody As Panel
    Friend WithEvents pnlGridSettings As Panel
    Friend WithEvents lblGridSettings As Controls.MaterialLabel
    Friend WithEvents pnlSearchCriteria As Panel
    Friend WithEvents lblSearchCriteria As Controls.MaterialLabel
End Class
