<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnZoomin_b = New System.Windows.Forms.Button()
        Me.btnZoomout_b = New System.Windows.Forms.Button()
        Me.btnRight_b = New System.Windows.Forms.Button()
        Me.btnLeft_b = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(51, 47)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(38, 20)
        Me.NumericUpDown1.TabIndex = 35
        Me.NumericUpDown1.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Sienna
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(1, 1)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(20, 20)
        Me.Button4.TabIndex = 39
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btnZoomin_b
        '
        Me.btnZoomin_b.Image = Global.HIK_PTZ.My.Resources.Resources.zoom_in24
        Me.btnZoomin_b.Location = New System.Drawing.Point(6, 97)
        Me.btnZoomin_b.Margin = New System.Windows.Forms.Padding(2)
        Me.btnZoomin_b.Name = "btnZoomin_b"
        Me.btnZoomin_b.Size = New System.Drawing.Size(32, 32)
        Me.btnZoomin_b.TabIndex = 33
        Me.btnZoomin_b.UseVisualStyleBackColor = True
        '
        'btnZoomout_b
        '
        Me.btnZoomout_b.Image = Global.HIK_PTZ.My.Resources.Resources.zoom_out24
        Me.btnZoomout_b.Location = New System.Drawing.Point(97, 97)
        Me.btnZoomout_b.Margin = New System.Windows.Forms.Padding(2)
        Me.btnZoomout_b.Name = "btnZoomout_b"
        Me.btnZoomout_b.Size = New System.Drawing.Size(32, 32)
        Me.btnZoomout_b.TabIndex = 34
        Me.btnZoomout_b.UseVisualStyleBackColor = True
        '
        'btnRight_b
        '
        Me.btnRight_b.Image = Global.HIK_PTZ.My.Resources.Resources.right24
        Me.btnRight_b.Location = New System.Drawing.Point(99, 40)
        Me.btnRight_b.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRight_b.Name = "btnRight_b"
        Me.btnRight_b.Size = New System.Drawing.Size(32, 32)
        Me.btnRight_b.TabIndex = 32
        Me.btnRight_b.UseVisualStyleBackColor = True
        '
        'btnLeft_b
        '
        Me.btnLeft_b.Image = Global.HIK_PTZ.My.Resources.Resources.left24
        Me.btnLeft_b.Location = New System.Drawing.Point(8, 40)
        Me.btnLeft_b.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLeft_b.Name = "btnLeft_b"
        Me.btnLeft_b.Size = New System.Drawing.Size(32, 32)
        Me.btnLeft_b.TabIndex = 31
        Me.btnLeft_b.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Image = Global.HIK_PTZ.My.Resources.Resources.down24
        Me.btnDown.Location = New System.Drawing.Point(52, 76)
        Me.btnDown.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(32, 32)
        Me.btnDown.TabIndex = 30
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Image = Global.HIK_PTZ.My.Resources.Resources.up24
        Me.btnUp.Location = New System.Drawing.Point(53, 3)
        Me.btnUp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(32, 32)
        Me.btnUp.TabIndex = 29
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(138, 133)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.btnZoomin_b)
        Me.Controls.Add(Me.btnZoomout_b)
        Me.Controls.Add(Me.btnRight_b)
        Me.Controls.Add(Me.btnLeft_b)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents btnZoomin_b As Button
    Friend WithEvents btnZoomout_b As Button
    Friend WithEvents btnRight_b As Button
    Friend WithEvents btnLeft_b As Button
    Friend WithEvents btnDown As Button
    Friend WithEvents btnUp As Button
    Friend WithEvents Button4 As Button
End Class
