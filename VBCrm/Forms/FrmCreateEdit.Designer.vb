<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCreateEdit
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
        lblName = New Controls.MaterialLabel()
        lblPhoneNumber = New Controls.MaterialLabel()
        txtName = New Controls.MaterialTextBox()
        txtPhoneNumber = New Controls.MaterialTextBox()
        lblEmail = New Controls.MaterialLabel()
        txtEmail = New Controls.MaterialTextBox()
        btnCancel = New Controls.MaterialButton()
        btnSave = New Controls.MaterialButton()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Depth = 0
        lblName.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblName.Location = New Point(34, 93)
        lblName.MouseState = MouseState.HOVER
        lblName.Name = "lblName"
        lblName.Size = New Size(43, 19)
        lblName.TabIndex = 19
        lblName.Text = "Name"
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Depth = 0
        lblPhoneNumber.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblPhoneNumber.Location = New Point(17, 143)
        lblPhoneNumber.MouseState = MouseState.HOVER
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(60, 19)
        lblPhoneNumber.TabIndex = 18
        lblPhoneNumber.Text = "Phone #"
        ' 
        ' txtName
        ' 
        txtName.AnimateReadOnly = False
        txtName.BorderStyle = BorderStyle.None
        txtName.Depth = 0
        txtName.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtName.LeadingIcon = Nothing
        txtName.Location = New Point(83, 91)
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
        txtPhoneNumber.Location = New Point(83, 143)
        txtPhoneNumber.MaxLength = 50
        txtPhoneNumber.MouseState = MouseState.OUT
        txtPhoneNumber.Multiline = False
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(157, 36)
        txtPhoneNumber.TabIndex = 1
        txtPhoneNumber.Text = ""
        txtPhoneNumber.TrailingIcon = Nothing
        txtPhoneNumber.UseTallSize = False
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Depth = 0
        lblEmail.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblEmail.Location = New Point(36, 194)
        lblEmail.MouseState = MouseState.HOVER
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(41, 19)
        lblEmail.TabIndex = 21
        lblEmail.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.AnimateReadOnly = False
        txtEmail.BorderStyle = BorderStyle.None
        txtEmail.Depth = 0
        txtEmail.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtEmail.LeadingIcon = Nothing
        txtEmail.Location = New Point(83, 194)
        txtEmail.MaxLength = 50
        txtEmail.MouseState = MouseState.OUT
        txtEmail.Multiline = False
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(157, 36)
        txtEmail.TabIndex = 2
        txtEmail.Text = ""
        txtEmail.TrailingIcon = Nothing
        txtEmail.UseTallSize = False
        ' 
        ' btnCancel
        ' 
        btnCancel.AutoSize = False
        btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnCancel.BackColor = SystemColors.Control
        btnCancel.Cursor = Cursors.Hand
        btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnCancel.Depth = 0
        btnCancel.ForeColor = SystemColors.ControlText
        btnCancel.HighEmphasis = True
        btnCancel.Icon = Nothing
        btnCancel.Location = New Point(175, 259)
        btnCancel.Margin = New Padding(4, 6, 4, 6)
        btnCancel.MouseState = MouseState.HOVER
        btnCancel.Name = "btnCancel"
        btnCancel.NoAccentTextColor = Color.Empty
        btnCancel.Size = New Size(73, 36)
        btnCancel.TabIndex = 4
        btnCancel.Text = "Cancel"
        btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnCancel.UseAccentColor = False
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.AutoSize = False
        btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSave.BackColor = SystemColors.Control
        btnSave.Cursor = Cursors.Hand
        btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnSave.Depth = 0
        btnSave.ForeColor = SystemColors.ControlText
        btnSave.HighEmphasis = True
        btnSave.Icon = Nothing
        btnSave.Location = New Point(76, 259)
        btnSave.Margin = New Padding(4, 6, 4, 6)
        btnSave.MouseState = MouseState.HOVER
        btnSave.Name = "btnSave"
        btnSave.NoAccentTextColor = Color.Empty
        btnSave.Size = New Size(73, 36)
        btnSave.TabIndex = 3
        btnSave.Text = "Save"
        btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnSave.UseAccentColor = False
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' FrmCreateEdit
        ' 
        AcceptButton = btnSave
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(324, 331)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(lblEmail)
        Controls.Add(txtEmail)
        Controls.Add(lblName)
        Controls.Add(lblPhoneNumber)
        Controls.Add(txtName)
        Controls.Add(txtPhoneNumber)
        Name = "FrmCreateEdit"
        StartPosition = FormStartPosition.CenterParent
        Text = "Create Edit - Contact"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Controls.MaterialLabel
    Friend WithEvents lblPhoneNumber As Controls.MaterialLabel
    Friend WithEvents txtName As Controls.MaterialTextBox
    Friend WithEvents txtPhoneNumber As Controls.MaterialTextBox
    Friend WithEvents lblEmail As Controls.MaterialLabel
    Friend WithEvents txtEmail As Controls.MaterialTextBox
    Friend WithEvents btnCancel As Controls.MaterialButton
    Friend WithEvents btnSave As Controls.MaterialButton
End Class
