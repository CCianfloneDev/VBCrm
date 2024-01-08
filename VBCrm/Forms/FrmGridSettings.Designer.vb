<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGridSettings
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
        btnClose = New Controls.MaterialButton()
        lblSettings = New Controls.MaterialLabel()
        pnlBody = New Panel()
        pnlBottom = New Panel()
        pnlBottom.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = False
        btnClose.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnClose.BackColor = SystemColors.Control
        btnClose.Cursor = Cursors.Hand
        btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnClose.Depth = 0
        btnClose.ForeColor = SystemColors.ControlText
        btnClose.HighEmphasis = True
        btnClose.Icon = Nothing
        btnClose.Location = New Point(140, 13)
        btnClose.Margin = New Padding(4, 6, 4, 6)
        btnClose.MouseState = MouseState.HOVER
        btnClose.Name = "btnClose"
        btnClose.NoAccentTextColor = Color.Empty
        btnClose.Size = New Size(73, 36)
        btnClose.TabIndex = 5
        btnClose.Text = "Close"
        btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnClose.UseAccentColor = False
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' lblSettings
        ' 
        lblSettings.AutoSize = True
        lblSettings.Depth = 0
        lblSettings.Dock = DockStyle.Top
        lblSettings.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblSettings.FontType = MaterialSkinManager.fontType.H6
        lblSettings.Location = New Point(3, 64)
        lblSettings.MouseState = MouseState.HOVER
        lblSettings.Name = "lblSettings"
        lblSettings.Size = New Size(284, 24)
        lblSettings.TabIndex = 6
        lblSettings.Text = "Change the visibility of columns"
        ' 
        ' pnlBody
        ' 
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(3, 88)
        pnlBody.Name = "pnlBody"
        pnlBody.Size = New Size(352, 359)
        pnlBody.TabIndex = 7
        ' 
        ' pnlBottom
        ' 
        pnlBottom.Controls.Add(btnClose)
        pnlBottom.Dock = DockStyle.Bottom
        pnlBottom.Location = New Point(3, 385)
        pnlBottom.Name = "pnlBottom"
        pnlBottom.Size = New Size(352, 62)
        pnlBottom.TabIndex = 8
        ' 
        ' FrmGridSettings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(358, 450)
        Controls.Add(pnlBottom)
        Controls.Add(pnlBody)
        Controls.Add(lblSettings)
        Name = "FrmGridSettings"
        StartPosition = FormStartPosition.CenterParent
        Text = "Grid settings"
        pnlBottom.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClose As Controls.MaterialButton
    Friend WithEvents lblSettings As Controls.MaterialLabel
    Friend WithEvents pnlBody As Panel
    Friend WithEvents pnlBottom As Panel
End Class
