<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminForm
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm))
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.dgvCtxMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.deleteCtxItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.msItemFileOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.msItemNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.msItemDynamicQ = New System.Windows.Forms.ToolStripMenuItem()
        Me.msItemExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.msItemDeleteOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.msItemDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.msItemDeleteAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.msItemEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.msItemAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.searchBar = New System.Windows.Forms.TextBox()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.imgDisplay = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.idLabel = New System.Windows.Forms.Label()
        Me.cbBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.descTextbox = New System.Windows.Forms.RichTextBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dgvCtxMenu.SuspendLayout()
        Me.menuStrip.SuspendLayout()
        CType(Me.imgDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.dgv.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgv.Location = New System.Drawing.Point(12, 277)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersWidth = 51
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowTemplate.ReadOnly = True
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(643, 254)
        Me.dgv.TabIndex = 0
        Me.dgv.TabStop = False
        '
        'dgvCtxMenu
        '
        Me.dgvCtxMenu.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCtxMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.dgvCtxMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.deleteCtxItem})
        Me.dgvCtxMenu.Name = "dgvCtxMenu"
        Me.dgvCtxMenu.Size = New System.Drawing.Size(111, 26)
        '
        'deleteCtxItem
        '
        Me.deleteCtxItem.Name = "deleteCtxItem"
        Me.deleteCtxItem.Size = New System.Drawing.Size(110, 22)
        Me.deleteCtxItem.Text = "Delete"
        '
        'menuStrip
        '
        Me.menuStrip.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.menuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msItemFileOptions, Me.msItemDeleteOptions, Me.msItemEdit, Me.msItemAbout})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.menuStrip.Size = New System.Drawing.Size(667, 24)
        Me.menuStrip.TabIndex = 0
        Me.menuStrip.Text = "MenuStrip1"
        '
        'msItemFileOptions
        '
        Me.msItemFileOptions.BackColor = System.Drawing.SystemColors.Control
        Me.msItemFileOptions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msItemNew, Me.msItemDynamicQ, Me.msItemExit})
        Me.msItemFileOptions.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msItemFileOptions.ForeColor = System.Drawing.SystemColors.ControlText
        Me.msItemFileOptions.Name = "msItemFileOptions"
        Me.msItemFileOptions.Size = New System.Drawing.Size(39, 20)
        Me.msItemFileOptions.Text = "&File"
        Me.msItemFileOptions.ToolTipText = "Add new item to DB"
        '
        'msItemNew
        '
        Me.msItemNew.Name = "msItemNew"
        Me.msItemNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.msItemNew.Size = New System.Drawing.Size(169, 22)
        Me.msItemNew.Text = "New Item"
        Me.msItemNew.ToolTipText = "Add new item to database"
        '
        'msItemDynamicQ
        '
        Me.msItemDynamicQ.Name = "msItemDynamicQ"
        Me.msItemDynamicQ.Size = New System.Drawing.Size(169, 22)
        Me.msItemDynamicQ.Text = "Dynamic Queries"
        '
        'msItemExit
        '
        Me.msItemExit.Name = "msItemExit"
        Me.msItemExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.msItemExit.Size = New System.Drawing.Size(169, 22)
        Me.msItemExit.Text = "Exit"
        Me.msItemExit.ToolTipText = "Close application"
        '
        'msItemDeleteOptions
        '
        Me.msItemDeleteOptions.BackColor = System.Drawing.SystemColors.Control
        Me.msItemDeleteOptions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msItemDelete, Me.msItemDeleteAll})
        Me.msItemDeleteOptions.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msItemDeleteOptions.ForeColor = System.Drawing.SystemColors.ControlText
        Me.msItemDeleteOptions.Name = "msItemDeleteOptions"
        Me.msItemDeleteOptions.Size = New System.Drawing.Size(55, 20)
        Me.msItemDeleteOptions.Text = "&Delete"
        Me.msItemDeleteOptions.ToolTipText = "Delete item from DB"
        '
        'msItemDelete
        '
        Me.msItemDelete.Name = "msItemDelete"
        Me.msItemDelete.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.msItemDelete.Size = New System.Drawing.Size(198, 22)
        Me.msItemDelete.Text = "Delete Item"
        Me.msItemDelete.ToolTipText = "Delete selected item"
        '
        'msItemDeleteAll
        '
        Me.msItemDeleteAll.Name = "msItemDeleteAll"
        Me.msItemDeleteAll.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.msItemDeleteAll.Size = New System.Drawing.Size(198, 22)
        Me.msItemDeleteAll.Text = "Delete All"
        '
        'msItemEdit
        '
        Me.msItemEdit.BackColor = System.Drawing.SystemColors.Control
        Me.msItemEdit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msItemEdit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.msItemEdit.Name = "msItemEdit"
        Me.msItemEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.msItemEdit.Size = New System.Drawing.Size(67, 20)
        Me.msItemEdit.Text = "&Edit Item"
        Me.msItemEdit.ToolTipText = "Edit Items"
        '
        'msItemAbout
        '
        Me.msItemAbout.Name = "msItemAbout"
        Me.msItemAbout.Size = New System.Drawing.Size(52, 20)
        Me.msItemAbout.Text = "About"
        '
        'searchBar
        '
        Me.searchBar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBar.Location = New System.Drawing.Point(12, 239)
        Me.searchBar.Name = "searchBar"
        Me.searchBar.Size = New System.Drawing.Size(221, 22)
        Me.searchBar.TabIndex = 2
        '
        'searchBtn
        '
        Me.searchBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBtn.Location = New System.Drawing.Point(239, 238)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(99, 23)
        Me.searchBtn.TabIndex = 3
        Me.searchBtn.Text = "Search"
        Me.searchBtn.UseVisualStyleBackColor = True
        '
        'imgDisplay
        '
        Me.imgDisplay.BackColor = System.Drawing.Color.Transparent
        Me.imgDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgDisplay.Location = New System.Drawing.Point(12, 38)
        Me.imgDisplay.Name = "imgDisplay"
        Me.imgDisplay.Size = New System.Drawing.Size(221, 156)
        Me.imgDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgDisplay.TabIndex = 3
        Me.imgDisplay.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(317, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(289, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name: "
        '
        'nameLabel
        '
        Me.nameLabel.BackColor = System.Drawing.SystemColors.Menu
        Me.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nameLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(355, 66)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(243, 19)
        Me.nameLabel.TabIndex = 4
        '
        'idLabel
        '
        Me.idLabel.BackColor = System.Drawing.SystemColors.Menu
        Me.idLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.idLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idLabel.Location = New System.Drawing.Point(355, 38)
        Me.idLabel.Name = "idLabel"
        Me.idLabel.Size = New System.Drawing.Size(59, 18)
        Me.idLabel.TabIndex = 4
        '
        'cbBox
        '
        Me.cbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBox.FormattingEnabled = True
        Me.cbBox.Location = New System.Drawing.Point(12, 204)
        Me.cbBox.Name = "cbBox"
        Me.cbBox.Size = New System.Drawing.Size(221, 24)
        Me.cbBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(245, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Description: "
        '
        'descTextbox
        '
        Me.descTextbox.BackColor = System.Drawing.SystemColors.Menu
        Me.descTextbox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descTextbox.Location = New System.Drawing.Point(355, 102)
        Me.descTextbox.Name = "descTextbox"
        Me.descTextbox.ReadOnly = True
        Me.descTextbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.descTextbox.Size = New System.Drawing.Size(305, 159)
        Me.descTextbox.TabIndex = 100
        Me.descTextbox.TabStop = False
        Me.descTextbox.Text = ""
        '
        'AdminForm
        '
        Me.AcceptButton = Me.searchBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.PharmachineAdmin.My.Resources.Resources.bg_login_main
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(667, 543)
        Me.Controls.Add(Me.descTextbox)
        Me.Controls.Add(Me.cbBox)
        Me.Controls.Add(Me.idLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.imgDisplay)
        Me.Controls.Add(Me.searchBtn)
        Me.Controls.Add(Me.searchBar)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.menuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuStrip
        Me.MaximizeBox = False
        Me.Name = "AdminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pharmachine Admin"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dgvCtxMenu.ResumeLayout(False)
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        CType(Me.imgDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents msItemFileOptions As ToolStripMenuItem
    Friend WithEvents searchBar As TextBox
    Friend WithEvents searchBtn As Button
    Friend WithEvents imgDisplay As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents idLabel As Label
    Friend WithEvents cbBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents descTextbox As RichTextBox
    Friend WithEvents msItemDeleteOptions As ToolStripMenuItem
    Friend WithEvents dgvCtxMenu As ContextMenuStrip
    Friend WithEvents deleteCtxItem As ToolStripMenuItem
    Friend WithEvents msItemEdit As ToolStripMenuItem
    Friend WithEvents msItemDelete As ToolStripMenuItem
    Friend WithEvents msItemDeleteAll As ToolStripMenuItem
    Friend WithEvents msItemNew As ToolStripMenuItem
    Friend WithEvents msItemExit As ToolStripMenuItem
    Friend WithEvents msItemAbout As ToolStripMenuItem
    Friend WithEvents msItemDynamicQ As ToolStripMenuItem
End Class
