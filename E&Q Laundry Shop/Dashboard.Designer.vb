<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.active = New System.Windows.Forms.Label()
        Me.completed = New System.Windows.Forms.Label()
        Me.topcustomer = New System.Windows.Forms.Label()
        Me.revenue = New System.Windows.Forms.Label()
        Me.Panel12.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Panel12.Controls.Add(Me.Label15)
        Me.Panel12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel12.Location = New System.Drawing.Point(1, 362)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(231, 50)
        Me.Panel12.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(28, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(140, 29)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Order History"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(231, 684)
        Me.Panel1.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkRed
        Me.Label10.Location = New System.Drawing.Point(61, 642)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 29)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Logout"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel6.Location = New System.Drawing.Point(0, 418)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(231, 50)
        Me.Panel6.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(35, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 29)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "About"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel5.Location = New System.Drawing.Point(0, 306)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(231, 50)
        Me.Panel5.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 29)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Customers"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel4.Location = New System.Drawing.Point(0, 250)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(231, 50)
        Me.Panel4.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(28, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Order Management"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(0, 194)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(231, 50)
        Me.Panel3.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(28, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dashboard"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(231, 111)
        Me.Panel2.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(60, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(113, 108)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'Chart1
        '
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(302, 374)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(420, 270)
        Me.Chart1.TabIndex = 7
        Me.Chart1.Text = "Chart1"
        '
        'Chart2
        '
        ChartArea4.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend4)
        Me.Chart2.Location = New System.Drawing.Point(773, 374)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.Chart2.Series.Add(Series4)
        Me.Chart2.Size = New System.Drawing.Size(420, 270)
        Me.Chart2.TabIndex = 8
        Me.Chart2.Text = "Chart2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(863, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Active Orders:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(769, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(242, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total Revenue this Day:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(858, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Top Customer:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(297, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 25)
        Me.Label7.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(819, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 25)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Completed Orders:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1094, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'active
        '
        Me.active.AutoSize = True
        Me.active.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.active.Location = New System.Drawing.Point(1017, 128)
        Me.active.Name = "active"
        Me.active.Size = New System.Drawing.Size(36, 25)
        Me.active.TabIndex = 16
        Me.active.Text = "01"
        '
        'completed
        '
        Me.completed.AutoSize = True
        Me.completed.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.completed.Location = New System.Drawing.Point(1017, 166)
        Me.completed.Name = "completed"
        Me.completed.Size = New System.Drawing.Size(36, 25)
        Me.completed.TabIndex = 17
        Me.completed.Text = "01"
        '
        'topcustomer
        '
        Me.topcustomer.AutoSize = True
        Me.topcustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.topcustomer.Location = New System.Drawing.Point(1017, 247)
        Me.topcustomer.Name = "topcustomer"
        Me.topcustomer.Size = New System.Drawing.Size(36, 25)
        Me.topcustomer.TabIndex = 18
        Me.topcustomer.Text = "01"
        '
        'revenue
        '
        Me.revenue.AutoSize = True
        Me.revenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.revenue.Location = New System.Drawing.Point(1017, 207)
        Me.revenue.Name = "revenue"
        Me.revenue.Size = New System.Drawing.Size(36, 25)
        Me.revenue.TabIndex = 19
        Me.revenue.Text = "01"
        '
        'Dashboard
        '
        Me.AccessibleName = " "
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.revenue)
        Me.Controls.Add(Me.topcustomer)
        Me.Controls.Add(Me.completed)
        Me.Controls.Add(Me.active)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Services"
        Me.Panel12.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents active As Label
    Friend WithEvents completed As Label
    Friend WithEvents topcustomer As Label
    Friend WithEvents revenue As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
