<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewProduct
    Inherits System.Windows.Forms.Form

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
        Me.descInput = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nameInput = New System.Windows.Forms.TextBox()
        Me.uploadBtn = New System.Windows.Forms.Button()
        Me.imgDisplay = New System.Windows.Forms.PictureBox()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.removeBtn = New System.Windows.Forms.Button()
        Me.priceInput = New System.Windows.Forms.TextBox()
        Me.amtInput = New System.Windows.Forms.TextBox()
        CType(Me.imgDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'descInput
        '
        Me.descInput.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descInput.Location = New System.Drawing.Point(126, 268)
        Me.descInput.Name = "descInput"
        Me.descInput.Size = New System.Drawing.Size(273, 144)
        Me.descInput.TabIndex = 4
        Me.descInput.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(39, 481)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Amount: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(39, 435)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Price (RM): "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(38, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Description: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(39, 228)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name: "
        '
        'nameInput
        '
        Me.nameInput.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameInput.Location = New System.Drawing.Point(126, 225)
        Me.nameInput.MaxLength = 255
        Me.nameInput.Name = "nameInput"
        Me.nameInput.Size = New System.Drawing.Size(273, 22)
        Me.nameInput.TabIndex = 3
        '
        'uploadBtn
        '
        Me.uploadBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.uploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.uploadBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uploadBtn.ForeColor = System.Drawing.Color.White
        Me.uploadBtn.Location = New System.Drawing.Point(231, 114)
        Me.uploadBtn.Name = "uploadBtn"
        Me.uploadBtn.Size = New System.Drawing.Size(137, 27)
        Me.uploadBtn.TabIndex = 1
        Me.uploadBtn.Text = "Upload Image"
        Me.uploadBtn.UseVisualStyleBackColor = False
        '
        'imgDisplay
        '
        Me.imgDisplay.BackColor = System.Drawing.Color.White
        Me.imgDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgDisplay.Location = New System.Drawing.Point(42, 19)
        Me.imgDisplay.Name = "imgDisplay"
        Me.imgDisplay.Size = New System.Drawing.Size(169, 156)
        Me.imgDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgDisplay.TabIndex = 6
        Me.imgDisplay.TabStop = False
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.Color.White
        Me.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.saveBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.Location = New System.Drawing.Point(88, 543)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(96, 27)
        Me.saveBtn.TabIndex = 7
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'cancelBtn
        '
        Me.cancelBtn.BackColor = System.Drawing.Color.White
        Me.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cancelBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBtn.Location = New System.Drawing.Point(231, 543)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(96, 27)
        Me.cancelBtn.TabIndex = 8
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = False
        '
        'removeBtn
        '
        Me.removeBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.removeBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removeBtn.ForeColor = System.Drawing.Color.White
        Me.removeBtn.Location = New System.Drawing.Point(231, 148)
        Me.removeBtn.Name = "removeBtn"
        Me.removeBtn.Size = New System.Drawing.Size(137, 27)
        Me.removeBtn.TabIndex = 2
        Me.removeBtn.Text = "Remove Image"
        Me.removeBtn.UseVisualStyleBackColor = False
        '
        'priceInput
        '
        Me.priceInput.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceInput.Location = New System.Drawing.Point(126, 434)
        Me.priceInput.MaxLength = 5
        Me.priceInput.Name = "priceInput"
        Me.priceInput.Size = New System.Drawing.Size(40, 22)
        Me.priceInput.TabIndex = 5
        '
        'amtInput
        '
        Me.amtInput.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amtInput.Location = New System.Drawing.Point(126, 478)
        Me.amtInput.MaxLength = 2
        Me.amtInput.Name = "amtInput"
        Me.amtInput.Size = New System.Drawing.Size(25, 22)
        Me.amtInput.TabIndex = 6
        '
        'NewProduct
        '
        Me.AcceptButton = Me.saveBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PharmachineAdmin.My.Resources.Resources.bg_new
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.cancelBtn
        Me.ClientSize = New System.Drawing.Size(433, 582)
        Me.Controls.Add(Me.descInput)
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
        Me.Controls.Add(Me.priceInput)
        Me.Controls.Add(Me.amtInput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "NewProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add new"
        CType(Me.imgDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents descInput As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nameInput As TextBox
    Friend WithEvents uploadBtn As Button
    Friend WithEvents imgDisplay As PictureBox
    Friend WithEvents saveBtn As Button
    Friend WithEvents cancelBtn As Button
    Friend WithEvents removeBtn As Button
    Friend WithEvents priceInput As TextBox
    Friend WithEvents amtInput As TextBox
End Class
