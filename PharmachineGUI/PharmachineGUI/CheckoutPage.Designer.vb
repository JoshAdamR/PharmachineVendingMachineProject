<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckoutPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckoutPage))
        Me.minusBtn = New System.Windows.Forms.Button()
        Me.plusBtn = New System.Windows.Forms.Button()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.payBtn = New System.Windows.Forms.Button()
        Me.imgDisplay = New System.Windows.Forms.PictureBox()
        Me.cashOption = New System.Windows.Forms.RadioButton()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.qtyLabel = New System.Windows.Forms.Label()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.amountLabel = New System.Windows.Forms.Label()
        Me.errMsg = New System.Windows.Forms.Label()
        CType(Me.imgDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'minusBtn
        '
        Me.minusBtn.BackColor = System.Drawing.Color.Transparent
        Me.minusBtn.BackgroundImage = Global.PharmachineGUI.My.Resources.Resources.minus
        Me.minusBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.minusBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.minusBtn.Location = New System.Drawing.Point(259, 234)
        Me.minusBtn.Name = "minusBtn"
        Me.minusBtn.Size = New System.Drawing.Size(37, 37)
        Me.minusBtn.TabIndex = 0
        Me.minusBtn.UseVisualStyleBackColor = False
        '
        'plusBtn
        '
        Me.plusBtn.BackColor = System.Drawing.Color.Transparent
        Me.plusBtn.BackgroundImage = Global.PharmachineGUI.My.Resources.Resources.plus
        Me.plusBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.plusBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.plusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.plusBtn.Location = New System.Drawing.Point(362, 234)
        Me.plusBtn.Name = "plusBtn"
        Me.plusBtn.Size = New System.Drawing.Size(37, 37)
        Me.plusBtn.TabIndex = 0
        Me.plusBtn.UseVisualStyleBackColor = False
        '
        'backBtn
        '
        Me.backBtn.BackColor = System.Drawing.Color.Transparent
        Me.backBtn.BackgroundImage = Global.PharmachineGUI.My.Resources.Resources.backBtn
        Me.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.backBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backBtn.FlatAppearance.BorderSize = 0
        Me.backBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backBtn.Location = New System.Drawing.Point(-1, 586)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(104, 97)
        Me.backBtn.TabIndex = 0
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'payBtn
        '
        Me.payBtn.BackColor = System.Drawing.Color.Transparent
        Me.payBtn.BackgroundImage = Global.PharmachineGUI.My.Resources.Resources.payBtn
        Me.payBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.payBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.payBtn.FlatAppearance.BorderSize = 0
        Me.payBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.payBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.payBtn.Location = New System.Drawing.Point(415, 586)
        Me.payBtn.Name = "payBtn"
        Me.payBtn.Size = New System.Drawing.Size(104, 97)
        Me.payBtn.TabIndex = 0
        Me.payBtn.UseVisualStyleBackColor = False
        '
        'imgDisplay
        '
        Me.imgDisplay.BackColor = System.Drawing.Color.Transparent
        Me.imgDisplay.Location = New System.Drawing.Point(38, 107)
        Me.imgDisplay.Name = "imgDisplay"
        Me.imgDisplay.Size = New System.Drawing.Size(183, 171)
        Me.imgDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgDisplay.TabIndex = 1
        Me.imgDisplay.TabStop = False
        '
        'cashOption
        '
        Me.cashOption.AutoSize = True
        Me.cashOption.BackColor = System.Drawing.Color.Transparent
        Me.cashOption.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cashOption.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cashOption.Location = New System.Drawing.Point(200, 418)
        Me.cashOption.Name = "cashOption"
        Me.cashOption.Size = New System.Drawing.Size(97, 36)
        Me.cashOption.TabIndex = 2
        Me.cashOption.TabStop = True
        Me.cashOption.Text = "Cash"
        Me.cashOption.UseVisualStyleBackColor = False
        '
        'totalLabel
        '
        Me.totalLabel.BackColor = System.Drawing.Color.Transparent
        Me.totalLabel.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalLabel.Location = New System.Drawing.Point(309, 514)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(178, 32)
        Me.totalLabel.TabIndex = 3
        Me.totalLabel.Text = "RM 0.00"
        Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'qtyLabel
        '
        Me.qtyLabel.BackColor = System.Drawing.Color.Transparent
        Me.qtyLabel.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qtyLabel.Location = New System.Drawing.Point(299, 238)
        Me.qtyLabel.Name = "qtyLabel"
        Me.qtyLabel.Size = New System.Drawing.Size(60, 32)
        Me.qtyLabel.TabIndex = 4
        Me.qtyLabel.Text = "1"
        Me.qtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = True
        Me.priceLabel.BackColor = System.Drawing.Color.Transparent
        Me.priceLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceLabel.ForeColor = System.Drawing.Color.White
        Me.priceLabel.Location = New System.Drawing.Point(321, 143)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(102, 24)
        Me.priceLabel.TabIndex = 5
        Me.priceLabel.Text = "[RM 0.00]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(239, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Price: "
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.BackColor = System.Drawing.Color.Transparent
        Me.nameLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.ForeColor = System.Drawing.Color.White
        Me.nameLabel.Location = New System.Drawing.Point(321, 104)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(73, 24)
        Me.nameLabel.TabIndex = 7
        Me.nameLabel.Text = "[name]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(239, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Name: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(239, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Amount left:"
        '
        'amountLabel
        '
        Me.amountLabel.AutoSize = True
        Me.amountLabel.BackColor = System.Drawing.Color.Transparent
        Me.amountLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountLabel.ForeColor = System.Drawing.Color.White
        Me.amountLabel.Location = New System.Drawing.Point(364, 183)
        Me.amountLabel.Name = "amountLabel"
        Me.amountLabel.Size = New System.Drawing.Size(46, 24)
        Me.amountLabel.TabIndex = 5
        Me.amountLabel.Text = "[00]"
        '
        'errMsg
        '
        Me.errMsg.AutoSize = True
        Me.errMsg.BackColor = System.Drawing.Color.Transparent
        Me.errMsg.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errMsg.ForeColor = System.Drawing.Color.Red
        Me.errMsg.Location = New System.Drawing.Point(124, 463)
        Me.errMsg.Name = "errMsg"
        Me.errMsg.Size = New System.Drawing.Size(0, 22)
        Me.errMsg.TabIndex = 9
        Me.errMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckoutPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PharmachineGUI.My.Resources.Resources.checkoutBg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(519, 681)
        Me.Controls.Add(Me.errMsg)
        Me.Controls.Add(Me.amountLabel)
        Me.Controls.Add(Me.priceLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.qtyLabel)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.cashOption)
        Me.Controls.Add(Me.imgDisplay)
        Me.Controls.Add(Me.plusBtn)
        Me.Controls.Add(Me.payBtn)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.minusBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CheckoutPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pharmachine"
        CType(Me.imgDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents minusBtn As Button
    Friend WithEvents plusBtn As Button
    Friend WithEvents backBtn As Button
    Friend WithEvents payBtn As Button
    Friend WithEvents imgDisplay As PictureBox
    Friend WithEvents cashOption As RadioButton
    Friend WithEvents totalLabel As Label
    Friend WithEvents qtyLabel As Label
    Friend WithEvents priceLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents amountLabel As Label
    Friend WithEvents errMsg As Label
End Class
