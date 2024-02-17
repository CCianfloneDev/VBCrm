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
        lblCompany = New Controls.MaterialLabel()
        txtCompany = New Controls.MaterialTextBox()
        lblJobTitle = New Controls.MaterialLabel()
        txtJobTitle = New Controls.MaterialTextBox()
        lblDateOfBirth = New Controls.MaterialLabel()
        txtDateOfBirth = New Controls.MaterialTextBox()
        lblNotes = New Controls.MaterialLabel()
        txtNotes = New Controls.MaterialMultiLineTextBox()
        lblAddress = New Controls.MaterialLabel()
        txtAddress = New Controls.MaterialTextBox()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Depth = 0
        lblName.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblName.Location = New Point(68, 93)
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
        lblPhoneNumber.Location = New Point(51, 145)
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
        txtName.Location = New Point(117, 91)
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
        txtPhoneNumber.Location = New Point(117, 143)
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
        lblEmail.Location = New Point(70, 194)
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
        txtEmail.Location = New Point(117, 194)
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
        btnCancel.Location = New Point(203, 557)
        btnCancel.Margin = New Padding(4, 6, 4, 6)
        btnCancel.MouseState = MouseState.HOVER
        btnCancel.Name = "btnCancel"
        btnCancel.NoAccentTextColor = Color.Empty
        btnCancel.Size = New Size(73, 36)
        btnCancel.TabIndex = 9
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
        btnSave.Location = New Point(104, 557)
        btnSave.Margin = New Padding(4, 6, 4, 6)
        btnSave.MouseState = MouseState.HOVER
        btnSave.Name = "btnSave"
        btnSave.NoAccentTextColor = Color.Empty
        btnSave.Size = New Size(73, 36)
        btnSave.TabIndex = 8
        btnSave.Text = "Save"
        btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnSave.UseAccentColor = False
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' lblCompany
        ' 
        lblCompany.AutoSize = True
        lblCompany.Depth = 0
        lblCompany.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblCompany.Location = New Point(42, 296)
        lblCompany.MouseState = MouseState.HOVER
        lblCompany.Name = "lblCompany"
        lblCompany.Size = New Size(69, 19)
        lblCompany.TabIndex = 23
        lblCompany.Text = "Company"
        ' 
        ' txtCompany
        ' 
        txtCompany.AnimateReadOnly = False
        txtCompany.BorderStyle = BorderStyle.None
        txtCompany.Depth = 0
        txtCompany.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtCompany.LeadingIcon = Nothing
        txtCompany.Location = New Point(117, 296)
        txtCompany.MaxLength = 50
        txtCompany.MouseState = MouseState.OUT
        txtCompany.Multiline = False
        txtCompany.Name = "txtCompany"
        txtCompany.Size = New Size(157, 36)
        txtCompany.TabIndex = 4
        txtCompany.Text = ""
        txtCompany.TrailingIcon = Nothing
        txtCompany.UseTallSize = False
        ' 
        ' lblJobTitle
        ' 
        lblJobTitle.AutoSize = True
        lblJobTitle.Depth = 0
        lblJobTitle.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblJobTitle.Location = New Point(48, 347)
        lblJobTitle.MouseState = MouseState.HOVER
        lblJobTitle.Name = "lblJobTitle"
        lblJobTitle.Size = New Size(63, 19)
        lblJobTitle.TabIndex = 25
        lblJobTitle.Text = "Job Title"
        ' 
        ' txtJobTitle
        ' 
        txtJobTitle.AnimateReadOnly = False
        txtJobTitle.BorderStyle = BorderStyle.None
        txtJobTitle.Depth = 0
        txtJobTitle.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtJobTitle.LeadingIcon = Nothing
        txtJobTitle.Location = New Point(117, 347)
        txtJobTitle.MaxLength = 50
        txtJobTitle.MouseState = MouseState.OUT
        txtJobTitle.Multiline = False
        txtJobTitle.Name = "txtJobTitle"
        txtJobTitle.Size = New Size(157, 36)
        txtJobTitle.TabIndex = 5
        txtJobTitle.Text = ""
        txtJobTitle.TrailingIcon = Nothing
        txtJobTitle.UseTallSize = False
        ' 
        ' lblDateOfBirth
        ' 
        lblDateOfBirth.AutoSize = True
        lblDateOfBirth.Depth = 0
        lblDateOfBirth.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblDateOfBirth.Location = New Point(19, 402)
        lblDateOfBirth.MouseState = MouseState.HOVER
        lblDateOfBirth.Name = "lblDateOfBirth"
        lblDateOfBirth.Size = New Size(92, 19)
        lblDateOfBirth.TabIndex = 27
        lblDateOfBirth.Text = "Date Of Birth"
        ' 
        ' txtDateOfBirth
        ' 
        txtDateOfBirth.AnimateReadOnly = False
        txtDateOfBirth.BorderStyle = BorderStyle.None
        txtDateOfBirth.Depth = 0
        txtDateOfBirth.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtDateOfBirth.LeadingIcon = Nothing
        txtDateOfBirth.Location = New Point(117, 399)
        txtDateOfBirth.MaxLength = 50
        txtDateOfBirth.MouseState = MouseState.OUT
        txtDateOfBirth.Multiline = False
        txtDateOfBirth.Name = "txtDateOfBirth"
        txtDateOfBirth.Size = New Size(157, 36)
        txtDateOfBirth.TabIndex = 6
        txtDateOfBirth.Text = ""
        txtDateOfBirth.TrailingIcon = Nothing
        txtDateOfBirth.UseTallSize = False
        ' 
        ' lblNotes
        ' 
        lblNotes.AutoSize = True
        lblNotes.Depth = 0
        lblNotes.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblNotes.Location = New Point(35, 452)
        lblNotes.MouseState = MouseState.HOVER
        lblNotes.Name = "lblNotes"
        lblNotes.Size = New Size(42, 19)
        lblNotes.TabIndex = 29
        lblNotes.Text = "Notes"
        ' 
        ' txtNotes
        ' 
        txtNotes.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        txtNotes.BorderStyle = BorderStyle.None
        txtNotes.Depth = 0
        txtNotes.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtNotes.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        txtNotes.Location = New Point(83, 452)
        txtNotes.MouseState = MouseState.HOVER
        txtNotes.Name = "txtNotes"
        txtNotes.Size = New Size(224, 96)
        txtNotes.TabIndex = 7
        txtNotes.Text = ""
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Depth = 0
        lblAddress.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblAddress.Location = New Point(53, 245)
        lblAddress.MouseState = MouseState.HOVER
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(58, 19)
        lblAddress.TabIndex = 32
        lblAddress.Text = "Address"
        ' 
        ' txtAddress
        ' 
        txtAddress.AnimateReadOnly = False
        txtAddress.BorderStyle = BorderStyle.None
        txtAddress.Depth = 0
        txtAddress.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtAddress.LeadingIcon = Nothing
        txtAddress.Location = New Point(117, 245)
        txtAddress.MaxLength = 50
        txtAddress.MouseState = MouseState.OUT
        txtAddress.Multiline = False
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(157, 36)
        txtAddress.TabIndex = 3
        txtAddress.Text = ""
        txtAddress.TrailingIcon = Nothing
        txtAddress.UseTallSize = False
        ' 
        ' FrmCreateEdit
        ' 
        AcceptButton = btnSave
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(390, 608)
        Controls.Add(lblAddress)
        Controls.Add(txtAddress)
        Controls.Add(txtNotes)
        Controls.Add(lblNotes)
        Controls.Add(lblDateOfBirth)
        Controls.Add(txtDateOfBirth)
        Controls.Add(lblJobTitle)
        Controls.Add(txtJobTitle)
        Controls.Add(lblCompany)
        Controls.Add(txtCompany)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(lblEmail)
        Controls.Add(txtEmail)
        Controls.Add(lblName)
        Controls.Add(lblPhoneNumber)
        Controls.Add(txtName)
        Controls.Add(txtPhoneNumber)
        Name = "FrmCreateEdit"
        StartPosition = FormStartPosition.CenterScreen
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
    Friend WithEvents lblCompany As Controls.MaterialLabel
    Friend WithEvents txtCompany As Controls.MaterialTextBox
    Friend WithEvents lblJobTitle As Controls.MaterialLabel
    Friend WithEvents txtJobTitle As Controls.MaterialTextBox
    Friend WithEvents lblDateOfBirth As Controls.MaterialLabel
    Friend WithEvents txtDateOfBirth As Controls.MaterialTextBox
    Friend WithEvents lblNotes As Controls.MaterialLabel
    Friend WithEvents txtNotes As Controls.MaterialMultiLineTextBox
    Friend WithEvents lblAddress As Controls.MaterialLabel
    Friend WithEvents txtAddress As Controls.MaterialTextBox
End Class
