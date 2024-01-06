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
        lnkLbl = New LinkLabel()
        btnClose = New Controls.MaterialButton()
        SuspendLayout()
        ' 
        ' lblMessage
        ' 
        lblMessage.Depth = 0
        lblMessage.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblMessage.Location = New Point(47, 111)
        lblMessage.MouseState = MouseState.HOVER
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(331, 220)
        lblMessage.TabIndex = 0
        lblMessage.Text = "message goes here"
        ' 
        ' lnkLbl
        ' 
        lnkLbl.AutoSize = True
        lnkLbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lnkLbl.LinkColor = Color.Green
        lnkLbl.Location = New Point(164, 343)
        lnkLbl.Name = "lnkLbl"
        lnkLbl.Size = New Size(97, 21)
        lnkLbl.TabIndex = 1
        lnkLbl.TabStop = True
        lnkLbl.Text = "Github Repo"
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = False
        btnClose.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnClose.BackColor = SystemColors.Control
        btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnClose.Depth = 0
        btnClose.ForeColor = SystemColors.ControlText
        btnClose.HighEmphasis = True
        btnClose.Icon = Nothing
        btnClose.Location = New Point(176, 373)
        btnClose.Margin = New Padding(4, 6, 4, 6)
        btnClose.MouseState = MouseState.HOVER
        btnClose.Name = "btnClose"
        btnClose.NoAccentTextColor = Color.Empty
        btnClose.Size = New Size(73, 36)
        btnClose.TabIndex = 2
        btnClose.Text = "Cancel"
        btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnClose.UseAccentColor = False
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' FrmAbout
        ' 
        AcceptButton = btnClose
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(456, 541)
        Controls.Add(btnClose)
        Controls.Add(lnkLbl)
        Controls.Add(lblMessage)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmAbout"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "FrmAbout"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents lblMessage As Controls.MaterialLabel
    Friend WithEvents lnkLbl As LinkLabel
    Friend WithEvents btnClose As Controls.MaterialButton

End Class
