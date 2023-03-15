<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditProduct
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
        Me.movPrevBtn = New System.Windows.Forms.Button()
        Me.movFirstBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nameInput = New System.Windows.Forms.TextBox()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.removeBtn = New System.Windows.Forms.Button()
        Me.uploadBtn = New System.Windows.Forms.Button()
        Me.imgDisplay = New System.Windows.Forms.PictureBox()
        Me.movLastBtn = New System.Windows.Forms.Button()
        Me.movNextBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.priceInput = New System.Windows.Forms.TextBox()
        Me.amtInput = New System.Windows.Forms.TextBox()
        Me.descInput = New System.Windows.Forms.RichTextBox()
        Me.idLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.editBtn = New System.Windows.Forms.Button()
        CType(Me.imgDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'movPrevBtn
        '
        Me.movPrevBtn.BackColor = System.Drawing.Color.White
        Me.movPrevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.movPrevBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.movPrevBtn.Location = New System.Drawing.Point(131, 12)
        Me.movPrevBtn.Name = "movPrevBtn"
        Me.movPrevBtn.Size = New System.Drawing.Size(35, 33)
        Me.movPrevBtn.TabIndex = 1
        Me.movPrevBtn.Text = "<"
        Me.movPrevBtn.UseVisualStyleBackColor = False
        '
        'movFirstBtn
        '
        Me.movFirstBtn.BackColor = System.Drawing.Color.White
        Me.movFirstBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.movFirstBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.movFirstBtn.Location = New System.Drawing.Point(89, 12)
        Me.movFirstBtn.Name = "movFirstBtn"
        Me.movFirstBtn.Size = New System.Drawing.Size(35, 33)
        Me.movFirstBtn.TabIndex = 0
        Me.movFirstBtn.Text = "<<"
        Me.movFirstBtn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(42, 549)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Amount: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(42, 503)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Price (RM): "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(41, 337)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Description: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(42, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Name: "
        '
        'nameInput
        '
        Me.nameInput.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameInput.Location = New System.Drawing.Point(129, 293)
        Me.nameInput.MaxLength = 255
        Me.nameInput.Name = "nameInput"
        Me.nameInput.Size = New System.Drawing.Size(273, 22)
        Me.nameInput.TabIndex = 7
        '
        'cancelBtn
        '
        Me.cancelBtn.BackColor = System.Drawing.Color.White
        Me.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cancelBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBtn.Location = New System.Drawing.Point(234, 606)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(96, 27)
        Me.cancelBtn.TabIndex = 12
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = False
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.Color.White
        Me.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.saveBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.Location = New System.Drawing.Point(91, 606)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(96, 27)
        Me.saveBtn.TabIndex = 11
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'removeBtn
        '
        Me.removeBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.removeBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removeBtn.ForeColor = System.Drawing.Color.White
        Me.removeBtn.Location = New System.Drawing.Point(234, 216)
        Me.removeBtn.Name = "removeBtn"
        Me.removeBtn.Size = New System.Drawing.Size(137, 27)
        Me.removeBtn.TabIndex = 6
        Me.removeBtn.Text = "Remove Image"
        Me.removeBtn.UseVisualStyleBackColor = False
        '
        'uploadBtn
        '
        Me.uploadBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.uploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.uploadBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uploadBtn.ForeColor = System.Drawing.Color.White
        Me.uploadBtn.Location = New System.Drawing.Point(234, 182)
        Me.uploadBtn.Name = "uploadBtn"
        Me.uploadBtn.Size = New System.Drawing.Size(137, 27)
        Me.uploadBtn.TabIndex = 5
        Me.uploadBtn.Text = "Upload Image"
        Me.uploadBtn.UseVisualStyleBackColor = False
        '
        'imgDisplay
        '
        Me.imgDisplay.BackColor = System.Drawing.Color.Transparent
        Me.imgDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgDisplay.Location = New System.Drawing.Point(45, 87)
        Me.imgDisplay.Name = "imgDisplay"
        Me.imgDisplay.Size = New System.Drawing.Size(169, 156)
        Me.imgDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgDisplay.TabIndex = 21
        Me.imgDisplay.TabStop = False
        '
        'movLastBtn
        '
        Me.movLastBtn.BackColor = System.Drawing.Color.White
        Me.movLastBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.movLastBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.movLastBtn.Location = New System.Drawing.Point(308, 12)
        Me.movLastBtn.Name = "movLastBtn"
        Me.movLastBtn.Size = New System.Drawing.Size(35, 33)
        Me.movLastBtn.TabIndex = 4
        Me.movLastBtn.Text = ">>"
        Me.movLastBtn.UseVisualStyleBackColor = False
        '
        'movNextBtn
        '
        Me.movNextBtn.BackColor = System.Drawing.Color.White
        Me.movNextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.movNextBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.movNextBtn.Location = New System.Drawing.Point(266, 12)
        Me.movNextBtn.Name = "movNextBtn"
        Me.movNextBtn.Size = New System.Drawing.Size(35, 33)
        Me.movNextBtn.TabIndex = 3
        Me.movNextBtn.Text = ">"
        Me.movNextBtn.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.priceInput)
        Me.GroupBox1.Controls.Add(Me.amtInput)
        Me.GroupBox1.Controls.Add(Me.descInput)
        Me.GroupBox1.Controls.Add(Me.idLabel)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 530)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit Details"
        '
        'priceInput
        '
        Me.priceInput.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceInput.Location = New System.Drawing.Point(102, 446)
        Me.priceInput.MaxLength = 5
        Me.priceInput.Name = "priceInput"
        Me.priceInput.Size = New System.Drawing.Size(40, 22)
        Me.priceInput.TabIndex = 29
        '
        'amtInput
        '
        Me.amtInput.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amtInput.Location = New System.Drawing.Point(102, 490)
        Me.amtInput.MaxLength = 2
        Me.amtInput.Name = "amtInput"
        Me.amtInput.Size = New System.Drawing.Size(25, 22)
        Me.amtInput.TabIndex = 30
        '
        'descInput
        '
        Me.descInput.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descInput.Location = New System.Drawing.Point(102, 278)
        Me.descInput.Name = "descInput"
        Me.descInput.Size = New System.Drawing.Size(273, 144)
        Me.descInput.TabIndex = 8
        Me.descInput.Text = ""
        '
        'idLabel
        '
        Me.idLabel.BackColor = System.Drawing.SystemColors.Menu
        Me.idLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.idLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idLabel.Location = New System.Drawing.Point(229, 53)
        Me.idLabel.Name = "idLabel"
        Me.idLabel.Size = New System.Drawing.Size(45, 20)
        Me.idLabel.TabIndex = 14
        Me.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(206, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "ID: "
        '
        'editBtn
        '
        Me.editBtn.BackColor = System.Drawing.Color.White
        Me.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editBtn.Location = New System.Drawing.Point(172, 12)
        Me.editBtn.Name = "editBtn"
        Me.editBtn.Size = New System.Drawing.Size(88, 33)
        Me.editBtn.TabIndex = 2
        Me.editBtn.Text = "Edit"
        Me.editBtn.UseVisualStyleBackColor = False
        '
        'EditProduct
        '
        Me.AcceptButton = Me.saveBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PharmachineAdmin.My.Resources.Resources.bg_edit
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.cancelBtn
        Me.ClientSize = New System.Drawing.Size(433, 652)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nameInput)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.removeBtn)
        Me.Controls.Add(Me.uploadBtn)
        Me.Controls.Add(Me.imgDisplay)
        Me.Controls.Add(Me.movNextBtn)
        Me.Controls.Add(Me.movFirstBtn)
        Me.Controls.Add(Me.movLastBtn)
        Me.Controls.Add(Me.editBtn)
        Me.Controls.Add(Me.movPrevBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "EditProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit"
        CType(Me.imgDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents movPrevBtn As Button
    Friend WithEvents movFirstBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nameInput As TextBox
    Friend WithEvents cancelBtn As Button
    Friend WithEvents saveBtn As Button
    Friend WithEvents removeBtn As Button
    Friend WithEvents uploadBtn As Button
    Friend WithEvents imgDisplay As PictureBox
    Friend WithEvents movLastBtn As Button
    Friend WithEvents movNextBtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents idLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents editBtn As Button
    Friend WithEvents descInput As RichTextBox
    Friend WithEvents priceInput As TextBox
    Friend WithEvents amtInput As TextBox
End Class
