﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewOrders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewOrders))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.delete = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(159, 152)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(794, 386)
        Me.DataGridView1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.Color.LightCoral
        Me.delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.Location = New System.Drawing.Point(252, 579)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(144, 38)
        Me.delete.TabIndex = 12
        Me.delete.Text = "Delete Order"
        Me.delete.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.PaleGreen
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1006, 325)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 38)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Order Completed"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(166, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 44)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Ongoing Orders"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(752, 579)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 38)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Notify Customer"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ViewOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ViewOrders"
        Me.Text = "ViewOrders"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents delete As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
End Class
