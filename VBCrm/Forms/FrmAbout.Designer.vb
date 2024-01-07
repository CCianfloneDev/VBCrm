<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAbout
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
        lblMessage = New Controls.MaterialLabel()
        btnClose = New Controls.MaterialButton()
        lnkLbl = New LinkLabel()
        SuspendLayout()
        ' 
        ' lblMessage
        ' 
        lblMessage.Depth = 0
        lblMessage.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblMessage.Location = New Point(17, 93)
        lblMessage.MouseState = MouseState.HOVER
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(331, 220)
        lblMessage.TabIndex = 1
        lblMessage.Text = "message goes here"
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
        btnClose.Location = New Point(146, 358)
        btnClose.Margin = New Padding(4, 6, 4, 6)
        btnClose.MouseState = MouseState.HOVER
        btnClose.Name = "btnClose"
        btnClose.NoAccentTextColor = Color.Empty
        btnClose.Size = New Size(73, 36)
        btnClose.TabIndex = 4
        btnClose.Text = "Cancel"
        btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnClose.UseAccentColor = False
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' lnkLbl
        ' 
        lnkLbl.AutoSize = True
        lnkLbl.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lnkLbl.LinkColor = Color.Green
        lnkLbl.Location = New Point(109, 320)
        lnkLbl.Name = "lnkLbl"
        lnkLbl.Size = New Size(128, 30)
        lnkLbl.TabIndex = 3
        lnkLbl.TabStop = True
        lnkLbl.Text = "Github Repo"
        ' 
        ' FrmAbout
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(364, 407)
        Controls.Add(btnClose)
        Controls.Add(lnkLbl)
        Controls.Add(lblMessage)
        Name = "FrmAbout"
        StartPosition = FormStartPosition.CenterParent
        Text = "About - VBCrm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblMessage As Controls.MaterialLabel
    Friend WithEvents btnClose As Controls.MaterialButton
    Friend WithEvents lnkLbl As LinkLabel
End Class
