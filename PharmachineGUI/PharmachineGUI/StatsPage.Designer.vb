<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatsPage
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StatsPage))
        Me.prevBtn = New System.Windows.Forms.Button()
        Me.nextBtn = New System.Windows.Forms.Button()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.statsChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.nameLbl = New System.Windows.Forms.Label()
        CType(Me.statsChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'prevBtn
        '
        Me.prevBtn.BackgroundImage = Global.PharmachineGUI.My.Resources.Resources.prevBtn
        Me.prevBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.prevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.prevBtn.Location = New System.Drawing.Point(283, 720)
        Me.prevBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.prevBtn.Name = "prevBtn"
        Me.prevBtn.Size = New System.Drawing.Size(51, 47)
        Me.prevBtn.TabIndex = 1
        Me.prevBtn.UseVisualStyleBackColor = True
        '
        'nextBtn
        '
        Me.nextBtn.BackgroundImage = Global.PharmachineGUI.My.Resources.Resources.nextBtn
        Me.nextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.nextBtn.Location = New System.Drawing.Point(363, 720)
        Me.nextBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.nextBtn.Name = "nextBtn"
        Me.nextBtn.Size = New System.Drawing.Size(51, 47)
        Me.nextBtn.TabIndex = 2
        Me.nextBtn.UseVisualStyleBackColor = True
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
        Me.backBtn.Location = New System.Drawing.Point(0, 720)
        Me.backBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(141, 121)
        Me.backBtn.TabIndex = 5
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'statsChart
        '
        Me.statsChart.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Area3DStyle.Inclination = 20
        ChartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea1.Area3DStyle.Rotation = 15
        ChartArea1.Area3DStyle.WallWidth = 8
        ChartArea1.AxisX.MajorGrid.Enabled = False
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX.Title = "Date bought"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal
        ChartArea1.AxisY.Title = "Amount bought"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea1.Name = "ChartArea1"
        ChartArea1.ShadowColor = System.Drawing.Color.DimGray
        ChartArea1.ShadowOffset = 5
        Me.statsChart.ChartAreas.Add(ChartArea1)
        Legend1.DockedToChartArea = "ChartArea1"
        Legend1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.statsChart.Legends.Add(Legend1)
        Me.statsChart.Location = New System.Drawing.Point(16, 85)
        Me.statsChart.Margin = New System.Windows.Forms.Padding(4)
        Me.statsChart.Name = "statsChart"
        Me.statsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Me.statsChart.RightToLeft = System.Windows.Forms.RightToLeft.No
        Series1.ChartArea = "ChartArea1"
        Series1.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsValueShownAsLabel = True
        Series1.IsVisibleInLegend = False
        Series1.Legend = "Legend1"
        Series1.Name = "Amount"
        Series1.YValuesPerPoint = 2
        Me.statsChart.Series.Add(Series1)
        Me.statsChart.Size = New System.Drawing.Size(660, 546)
        Me.statsChart.TabIndex = 6
        Me.statsChart.Text = "chart"
        '
        'nameLbl
        '
        Me.nameLbl.BackColor = System.Drawing.Color.Transparent
        Me.nameLbl.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLbl.ForeColor = System.Drawing.Color.White
        Me.nameLbl.Location = New System.Drawing.Point(0, 26)
        Me.nameLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nameLbl.Name = "nameLbl"
        Me.nameLbl.Size = New System.Drawing.Size(691, 30)
        Me.nameLbl.TabIndex = 7
        Me.nameLbl.Text = "[name]"
        Me.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatsPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(692, 838)
        Me.Controls.Add(Me.nameLbl)
        Me.Controls.Add(Me.statsChart)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.nextBtn)
        Me.Controls.Add(Me.prevBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "StatsPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pharmachine"
        CType(Me.statsChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents prevBtn As Button
    Friend WithEvents nextBtn As Button
    Friend WithEvents backBtn As Button
    Friend WithEvents statsChart As DataVisualization.Charting.Chart
    Friend WithEvents nameLbl As Label
End Class
