<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.rtbCapabilities = New System.Windows.Forms.RichTextBox()
        Me.btnGetCapabilities = New System.Windows.Forms.Button()
        Me.btnTestSpeed = New System.Windows.Forms.Button()
        Me.btnFocusIn = New System.Windows.Forms.Button()
        Me.btnFocusOut = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnFocusminus_b = New System.Windows.Forms.Button()
        Me.btnFoxusplus_b = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetConnectionDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiagnosticToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.stStrip = New System.Windows.Forms.StatusStrip()
        Me.stlStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTargetIP = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.btnZoomin_b = New System.Windows.Forms.Button()
        Me.btnZoomout_b = New System.Windows.Forms.Button()
        Me.btnRight_b = New System.Windows.Forms.Button()
        Me.btnLeft_b = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnZoomIn = New System.Windows.Forms.Button()
        Me.btnZoomOut = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.stStrip.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(9, 184)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 26)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Preset 1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(80, 184)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 26)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Preset 2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'rtbCapabilities
        '
        Me.rtbCapabilities.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbCapabilities.Location = New System.Drawing.Point(12, 259)
        Me.rtbCapabilities.Name = "rtbCapabilities"
        Me.rtbCapabilities.Size = New System.Drawing.Size(445, 134)
        Me.rtbCapabilities.TabIndex = 8
        Me.rtbCapabilities.Text = ""
        '
        'btnGetCapabilities
        '
        Me.btnGetCapabilities.Location = New System.Drawing.Point(12, 218)
        Me.btnGetCapabilities.Name = "btnGetCapabilities"
        Me.btnGetCapabilities.Size = New System.Drawing.Size(153, 35)
        Me.btnGetCapabilities.TabIndex = 9
        Me.btnGetCapabilities.Text = "Get Capabilities"
        Me.ToolTip1.SetToolTip(Me.btnGetCapabilities, "Retrieves cameras capabilities ")
        Me.btnGetCapabilities.UseVisualStyleBackColor = True
        '
        'btnTestSpeed
        '
        Me.btnTestSpeed.Location = New System.Drawing.Point(332, 218)
        Me.btnTestSpeed.Name = "btnTestSpeed"
        Me.btnTestSpeed.Size = New System.Drawing.Size(115, 35)
        Me.btnTestSpeed.TabIndex = 10
        Me.btnTestSpeed.Text = "Button4"
        Me.btnTestSpeed.UseVisualStyleBackColor = True
        Me.btnTestSpeed.Visible = False
        '
        'btnFocusIn
        '
        Me.btnFocusIn.Location = New System.Drawing.Point(10, 10)
        Me.btnFocusIn.Name = "btnFocusIn"
        Me.btnFocusIn.Size = New System.Drawing.Size(40, 40)
        Me.btnFocusIn.TabIndex = 13
        Me.btnFocusIn.Text = "F+"
        Me.btnFocusIn.UseVisualStyleBackColor = True
        Me.btnFocusIn.Visible = False
        '
        'btnFocusOut
        '
        Me.btnFocusOut.Location = New System.Drawing.Point(391, 172)
        Me.btnFocusOut.Name = "btnFocusOut"
        Me.btnFocusOut.Size = New System.Drawing.Size(40, 40)
        Me.btnFocusOut.TabIndex = 14
        Me.btnFocusOut.Text = "F-"
        Me.btnFocusOut.UseVisualStyleBackColor = True
        Me.btnFocusOut.Visible = False
        '
        'btnFocusminus_b
        '
        Me.btnFocusminus_b.Location = New System.Drawing.Point(9, 141)
        Me.btnFocusminus_b.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFocusminus_b.Name = "btnFocusminus_b"
        Me.btnFocusminus_b.Size = New System.Drawing.Size(36, 39)
        Me.btnFocusminus_b.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.btnFocusminus_b, "Move Up")
        Me.btnFocusminus_b.UseVisualStyleBackColor = True
        Me.btnFocusminus_b.Visible = False
        '
        'btnFoxusplus_b
        '
        Me.btnFoxusplus_b.Location = New System.Drawing.Point(110, 141)
        Me.btnFoxusplus_b.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFoxusplus_b.Name = "btnFoxusplus_b"
        Me.btnFoxusplus_b.Size = New System.Drawing.Size(36, 39)
        Me.btnFoxusplus_b.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.btnFoxusplus_b, "Move Up")
        Me.btnFoxusplus_b.UseVisualStyleBackColor = True
        Me.btnFoxusplus_b.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(226, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetConnectionDetailsToolStripMenuItem, Me.DiagnosticToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'SetConnectionDetailsToolStripMenuItem
        '
        Me.SetConnectionDetailsToolStripMenuItem.Name = "SetConnectionDetailsToolStripMenuItem"
        Me.SetConnectionDetailsToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.SetConnectionDetailsToolStripMenuItem.Text = "Set connection details..."
        '
        'DiagnosticToolStripMenuItem
        '
        Me.DiagnosticToolStripMenuItem.Name = "DiagnosticToolStripMenuItem"
        Me.DiagnosticToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.DiagnosticToolStripMenuItem.Text = "Diagnostics..."
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.AboutToolStripMenuItem.Text = "About..."
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'stStrip
        '
        Me.stStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.stStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stlStatus})
        Me.stStrip.Location = New System.Drawing.Point(0, 236)
        Me.stStrip.Name = "stStrip"
        Me.stStrip.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.stStrip.Size = New System.Drawing.Size(226, 22)
        Me.stStrip.TabIndex = 17
        Me.stStrip.Text = "StatusStrip1"
        '
        'stlStatus
        '
        Me.stlStatus.Name = "stlStatus"
        Me.stlStatus.Size = New System.Drawing.Size(10, 17)
        Me.stlStatus.Text = "."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 218)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Target device:"
        '
        'lblTargetIP
        '
        Me.lblTargetIP.AutoSize = True
        Me.lblTargetIP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTargetIP.Location = New System.Drawing.Point(86, 218)
        Me.lblTargetIP.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTargetIP.Name = "lblTargetIP"
        Me.lblTargetIP.Size = New System.Drawing.Size(2, 15)
        Me.lblTargetIP.TabIndex = 20
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(150, 184)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(66, 26)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Preset 2"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(55, 91)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(49, 20)
        Me.NumericUpDown1.TabIndex = 28
        Me.NumericUpDown1.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'btnZoomin_b
        '
        Me.btnZoomin_b.Image = Global.HIK_PTZ.My.Resources.Resources.zoom_in
        Me.btnZoomin_b.Location = New System.Drawing.Point(165, 42)
        Me.btnZoomin_b.Margin = New System.Windows.Forms.Padding(2)
        Me.btnZoomin_b.Name = "btnZoomin_b"
        Me.btnZoomin_b.Size = New System.Drawing.Size(52, 52)
        Me.btnZoomin_b.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.btnZoomin_b, "Move Up")
        Me.btnZoomin_b.UseVisualStyleBackColor = True
        '
        'btnZoomout_b
        '
        Me.btnZoomout_b.Image = Global.HIK_PTZ.My.Resources.Resources.zoom_out
        Me.btnZoomout_b.Location = New System.Drawing.Point(165, 108)
        Me.btnZoomout_b.Margin = New System.Windows.Forms.Padding(2)
        Me.btnZoomout_b.Name = "btnZoomout_b"
        Me.btnZoomout_b.Size = New System.Drawing.Size(52, 52)
        Me.btnZoomout_b.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.btnZoomout_b, "Move Up")
        Me.btnZoomout_b.UseVisualStyleBackColor = True
        '
        'btnRight_b
        '
        Me.btnRight_b.Image = Global.HIK_PTZ.My.Resources.Resources.right1
        Me.btnRight_b.Location = New System.Drawing.Point(107, 74)
        Me.btnRight_b.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRight_b.Name = "btnRight_b"
        Me.btnRight_b.Size = New System.Drawing.Size(52, 52)
        Me.btnRight_b.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.btnRight_b, "Move Up")
        Me.btnRight_b.UseVisualStyleBackColor = True
        '
        'btnLeft_b
        '
        Me.btnLeft_b.Image = Global.HIK_PTZ.My.Resources.Resources.left1
        Me.btnLeft_b.Location = New System.Drawing.Point(0, 74)
        Me.btnLeft_b.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLeft_b.Name = "btnLeft_b"
        Me.btnLeft_b.Size = New System.Drawing.Size(52, 52)
        Me.btnLeft_b.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.btnLeft_b, "Move Up")
        Me.btnLeft_b.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Image = Global.HIK_PTZ.My.Resources.Resources.down5
        Me.btnDown.Location = New System.Drawing.Point(53, 113)
        Me.btnDown.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(52, 52)
        Me.btnDown.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnDown, "Move Down")
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Image = Global.HIK_PTZ.My.Resources.Resources.up2
        Me.btnUp.Location = New System.Drawing.Point(53, 37)
        Me.btnUp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(52, 52)
        Me.btnUp.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnUp, "Move Up")
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnLeft
        '
        Me.btnLeft.Image = Global.HIK_PTZ.My.Resources.Resources.left
        Me.btnLeft.Location = New System.Drawing.Point(216, 69)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(48, 48)
        Me.btnLeft.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.btnLeft, "Move Left")
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Image = Global.HIK_PTZ.My.Resources.Resources.right
        Me.btnRight.Location = New System.Drawing.Point(324, 69)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(48, 48)
        Me.btnRight.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.btnRight, "Move Right")
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnZoomIn
        '
        Me.btnZoomIn.Image = Global.HIK_PTZ.My.Resources.Resources.zoomin
        Me.btnZoomIn.Location = New System.Drawing.Point(389, 49)
        Me.btnZoomIn.Name = "btnZoomIn"
        Me.btnZoomIn.Size = New System.Drawing.Size(40, 40)
        Me.btnZoomIn.TabIndex = 11
        Me.btnZoomIn.Text = "Zoom In"
        Me.btnZoomIn.UseVisualStyleBackColor = True
        '
        'btnZoomOut
        '
        Me.btnZoomOut.Image = Global.HIK_PTZ.My.Resources.Resources.zoomout
        Me.btnZoomOut.Location = New System.Drawing.Point(389, 95)
        Me.btnZoomOut.Name = "btnZoomOut"
        Me.btnZoomOut.Size = New System.Drawing.Size(40, 40)
        Me.btnZoomOut.TabIndex = 12
        Me.btnZoomOut.Text = "Zoom Out"
        Me.btnZoomOut.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Teal
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button4.Location = New System.Drawing.Point(172, 235)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(48, 22)
        Me.Button4.TabIndex = 29
        Me.Button4.Text = "tiny"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 258)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.btnZoomin_b)
        Me.Controls.Add(Me.btnZoomout_b)
        Me.Controls.Add(Me.btnFocusminus_b)
        Me.Controls.Add(Me.btnFoxusplus_b)
        Me.Controls.Add(Me.btnRight_b)
        Me.Controls.Add(Me.btnLeft_b)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lblTargetIP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.stStrip)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "HIK PTZ "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.stStrip.ResumeLayout(False)
        Me.stStrip.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents rtbCapabilities As RichTextBox
    Friend WithEvents btnGetCapabilities As Button
    Friend WithEvents btnTestSpeed As Button
    Friend WithEvents btnFocusIn As Button
    Friend WithEvents btnFocusOut As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnUp As Button
    Friend WithEvents btnDown As Button
    Friend WithEvents btnLeft As Button
    Friend WithEvents btnRight As Button
    Friend WithEvents btnZoomIn As Button
    Friend WithEvents btnZoomOut As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiagnosticToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetConnectionDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents stStrip As StatusStrip
    Friend WithEvents stlStatus As ToolStripStatusLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTargetIP As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents btnLeft_b As Button
    Friend WithEvents btnRight_b As Button
    Friend WithEvents btnZoomin_b As Button
    Friend WithEvents btnZoomout_b As Button
    Friend WithEvents btnFocusminus_b As Button
    Friend WithEvents btnFoxusplus_b As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Button4 As Button
End Class
