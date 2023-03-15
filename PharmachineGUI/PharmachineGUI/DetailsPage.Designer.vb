<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailsPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetailsPage))
        Me.imgDisplay = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.descBox = New System.Windows.Forms.RichTextBox()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.buyBtn = New System.Windows.Forms.Button()
        CType(Me.imgDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgDisplay
        '
        Me.imgDisplay.BackColor = System.Drawing.Color.Transparent
        Me.imgDisplay.Location = New System.Drawing.Point(47, 85)
        Me.imgDisplay.Name = "imgDisplay"
        Me.imgDisplay.Size = New System.Drawing.Size(150, 150)
        Me.imgDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgDisplay.TabIndex = 0
        Me.imgDisplay.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(227, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(227, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Price: "
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.BackColor = System.Drawing.Color.Transparent
        Me.nameLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.ForeColor = System.Drawing.Color.White
        Me.nameLabel.Location = New System.Drawing.Point(309, 127)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(73, 24)
        Me.nameLabel.TabIndex = 1
        Me.nameLabel.Text = "[name]"
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = True
        Me.priceLabel.BackColor = System.Drawing.Color.Transparent
        Me.priceLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceLabel.ForeColor = System.Drawing.Color.White
        Me.priceLabel.Location = New System.Drawing.Point(309, 166)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(90, 24)
        Me.priceLabel.TabIndex = 1
        Me.priceLabel.Text = "RM 0.00"
        '
        'descBox
        '
        Me.descBox.BackColor = System.Drawing.Color.White
        Me.descBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.descBox.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descBox.Location = New System.Drawing.Point(33, 266)
        Me.descBox.Name = "descBox"
        Me.descBox.ReadOnly = True
        Me.descBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.descBox.ShortcutsEnabled = False
        Me.descBox.Size = New System.Drawing.Size(452, 293)
        Me.descBox.TabIndex = 2
        Me.descBox.TabStop = False
        Me.descBox.Text = ""
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
        Me.backBtn.Location = New System.Drawing.Point(0, 583)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(106, 98)
        Me.backBtn.TabIndex = 3
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'buyBtn
        '
        Me.buyBtn.BackColor = System.Drawing.Color.Transparent
        Me.buyBtn.BackgroundImage = Global.PharmachineGUI.My.Resources.Resources.buyBtn
        Me.buyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.buyBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buyBtn.FlatAppearance.BorderSize = 0
        Me.buyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.buyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.buyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buyBtn.Location = New System.Drawing.Point(415, 583)
        Me.buyBtn.Name = "buyBtn"
        Me.buyBtn.Size = New System.Drawing.Size(106, 98)
        Me.buyBtn.TabIndex = 3
        Me.buyBtn.UseVisualStyleBackColor = False
        '
        'DetailsPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PharmachineGUI.My.Resources.Resources.details_page
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(519, 681)
        Me.Controls.Add(Me.buyBtn)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.descBox)
        Me.Controls.Add(Me.priceLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.imgDisplay)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "DetailsPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pharmachine"
        CType(Me.imgDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgDisplay As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents priceLabel As Label
    Friend WithEvents descBox As RichTextBox
    Friend WithEvents backBtn As Button
    Friend WithEvents buyBtn As Button
End Class
