<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartPage))
        Me.startBtn = New System.Windows.Forms.Button()
        Me.aboutBtn = New System.Windows.Forms.Button()
        Me.statsBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'startBtn
        '
        Me.startBtn.BackgroundImage = CType(resources.GetObject("startBtn.BackgroundImage"), System.Drawing.Image)
        Me.startBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.startBtn.Location = New System.Drawing.Point(113, 60)
        Me.startBtn.Name = "startBtn"
        Me.startBtn.Size = New System.Drawing.Size(296, 110)
        Me.startBtn.TabIndex = 0
        Me.startBtn.UseVisualStyleBackColor = True
        '
        'aboutBtn
        '
        Me.aboutBtn.BackColor = System.Drawing.Color.Transparent
        Me.aboutBtn.BackgroundImage = Global.PharmachineGUI.My.Resources.Resources.aboutBtn
        Me.aboutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.aboutBtn.Location = New System.Drawing.Point(405, 628)
        Me.aboutBtn.Name = "aboutBtn"
        Me.aboutBtn.Size = New System.Drawing.Size(87, 32)
        Me.aboutBtn.TabIndex = 0
        Me.aboutBtn.UseVisualStyleBackColor = False
        '
        'statsBtn
        '
        Me.statsBtn.BackColor = System.Drawing.Color.Transparent
        Me.statsBtn.BackgroundImage = Global.PharmachineGUI.My.Resources.Resources.statsBtn
        Me.statsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.statsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.statsBtn.Location = New System.Drawing.Point(27, 628)
        Me.statsBtn.Name = "statsBtn"
        Me.statsBtn.Size = New System.Drawing.Size(87, 32)
        Me.statsBtn.TabIndex = 0
        Me.statsBtn.UseVisualStyleBackColor = False
        '
        'StartPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PharmachineGUI.My.Resources.Resources.startBg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(519, 681)
        Me.Controls.Add(Me.statsBtn)
        Me.Controls.Add(Me.aboutBtn)
        Me.Controls.Add(Me.startBtn)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "StartPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pharmachine"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents startBtn As Button
    Friend WithEvents aboutBtn As Button
    Friend WithEvents statsBtn As Button
End Class
