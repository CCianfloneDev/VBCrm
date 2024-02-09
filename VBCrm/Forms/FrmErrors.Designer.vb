<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmErrors
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
        lblErrorLogs = New Controls.MaterialLabel()
        txtErrors = New Controls.MaterialMultiLineTextBox()
        btnClose = New Controls.MaterialButton()
        btnDelete = New Controls.MaterialButton()
        lnkLbl = New LinkLabel()
        SuspendLayout()
        ' 
        ' lblErrorLogs
        ' 
        lblErrorLogs.AutoSize = True
        lblErrorLogs.Depth = 0
        lblErrorLogs.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblErrorLogs.Location = New Point(52, 81)
        lblErrorLogs.MouseState = MouseState.HOVER
        lblErrorLogs.Name = "lblErrorLogs"
        lblErrorLogs.Size = New Size(326, 19)
        lblErrorLogs.TabIndex = 2
        lblErrorLogs.Text = "Error logs, please share this with the developer"
        ' 
        ' txtErrors
        ' 
        txtErrors.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        txtErrors.BorderStyle = BorderStyle.None
        txtErrors.Depth = 0
        txtErrors.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtErrors.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        txtErrors.Location = New Point(37, 138)
        txtErrors.MouseState = MouseState.HOVER
        txtErrors.Name = "txtErrors"
        txtErrors.Size = New Size(356, 281)
        txtErrors.TabIndex = 3
        txtErrors.Text = ""
        ' 
        ' btnClose
        ' 
        btnClose.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnClose.BackColor = SystemColors.Control
        btnClose.Cursor = Cursors.Hand
        btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnClose.Depth = 0
        btnClose.ForeColor = SystemColors.ControlText
        btnClose.HighEmphasis = True
        btnClose.Icon = Nothing
        btnClose.Location = New Point(286, 438)
        btnClose.Margin = New Padding(4, 6, 4, 6)
        btnClose.MouseState = MouseState.HOVER
        btnClose.Name = "btnClose"
        btnClose.NoAccentTextColor = Color.Empty
        btnClose.Size = New Size(66, 36)
        btnClose.TabIndex = 6
        btnClose.Text = "Close"
        btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnClose.UseAccentColor = False
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnDelete.BackColor = SystemColors.Control
        btnDelete.Cursor = Cursors.Hand
        btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnDelete.Depth = 0
        btnDelete.ForeColor = SystemColors.ControlText
        btnDelete.HighEmphasis = True
        btnDelete.Icon = Nothing
        btnDelete.Location = New Point(79, 438)
        btnDelete.Margin = New Padding(4, 6, 4, 6)
        btnDelete.MouseState = MouseState.HOVER
        btnDelete.Name = "btnDelete"
        btnDelete.NoAccentTextColor = Color.Empty
        btnDelete.Size = New Size(143, 36)
        btnDelete.TabIndex = 5
        btnDelete.Text = "Delete All Logs"
        btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnDelete.UseAccentColor = False
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' lnkLbl
        ' 
        lnkLbl.AutoSize = True
        lnkLbl.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lnkLbl.LinkColor = Color.Green
        lnkLbl.Location = New Point(151, 105)
        lnkLbl.Name = "lnkLbl"
        lnkLbl.Size = New Size(128, 30)
        lnkLbl.TabIndex = 7
        lnkLbl.TabStop = True
        lnkLbl.Text = "Github Repo"
        ' 
        ' FrmErrors
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(431, 498)
        Controls.Add(lnkLbl)
        Controls.Add(btnClose)
        Controls.Add(btnDelete)
        Controls.Add(txtErrors)
        Controls.Add(lblErrorLogs)
        Name = "FrmErrors"
        Text = "FrmErrors"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblErrorLogs As Controls.MaterialLabel
    Friend WithEvents txtErrors As Controls.MaterialMultiLineTextBox
    Friend WithEvents btnClose As Controls.MaterialButton
    Friend WithEvents btnDelete As Controls.MaterialButton
    Friend WithEvents lnkLbl As LinkLabel
End Class
