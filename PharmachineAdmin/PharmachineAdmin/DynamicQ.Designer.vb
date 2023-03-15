<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DynamicQ
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
        Me.listbox = New System.Windows.Forms.ListBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.searchBar = New System.Windows.Forms.TextBox()
        Me.cbBox = New System.Windows.Forms.ComboBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listbox
        '
        Me.listbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listbox.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listbox.FormattingEnabled = True
        Me.listbox.ItemHeight = 17
        Me.listbox.Location = New System.Drawing.Point(12, 15)
        Me.listbox.Name = "listbox"
        Me.listbox.Size = New System.Drawing.Size(216, 361)
        Me.listbox.TabIndex = 0
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(234, 141)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.RowTemplate.ReadOnly = True
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(491, 235)
        Me.dgv.TabIndex = 1
        '
        'searchBar
        '
        Me.searchBar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBar.Location = New System.Drawing.Point(234, 58)
        Me.searchBar.Name = "searchBar"
        Me.searchBar.Size = New System.Drawing.Size(260, 25)
        Me.searchBar.TabIndex = 1
        '
        'cbBox
        '
        Me.cbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBox.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBox.FormattingEnabled = True
        Me.cbBox.Location = New System.Drawing.Point(234, 15)
        Me.cbBox.Name = "cbBox"
        Me.cbBox.Size = New System.Drawing.Size(260, 25)
        Me.cbBox.TabIndex = 0
        '
        'DynamicQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.PharmachineAdmin.My.Resources.Resources.bg_about_dynamic
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(737, 380)
        Me.Controls.Add(Me.cbBox)
        Me.Controls.Add(Me.searchBar)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.listbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "DynamicQ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dynamic Queries"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listbox As ListBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents searchBar As TextBox
    Friend WithEvents cbBox As ComboBox
End Class
