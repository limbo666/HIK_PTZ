<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.btnGetCapabilities = New System.Windows.Forms.Button()
        Me.rtbCapabilities = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'btnGetCapabilities
        '
        Me.btnGetCapabilities.Location = New System.Drawing.Point(12, 12)
        Me.btnGetCapabilities.Name = "btnGetCapabilities"
        Me.btnGetCapabilities.Size = New System.Drawing.Size(163, 32)
        Me.btnGetCapabilities.TabIndex = 0
        Me.btnGetCapabilities.Text = "Get capabilities"
        Me.btnGetCapabilities.UseVisualStyleBackColor = True
        '
        'rtbCapabilities
        '
        Me.rtbCapabilities.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbCapabilities.Location = New System.Drawing.Point(12, 50)
        Me.rtbCapabilities.Name = "rtbCapabilities"
        Me.rtbCapabilities.Size = New System.Drawing.Size(852, 469)
        Me.rtbCapabilities.TabIndex = 1
        Me.rtbCapabilities.Text = ""
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 541)
        Me.Controls.Add(Me.rtbCapabilities)
        Me.Controls.Add(Me.btnGetCapabilities)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Text = "Diagnostics"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGetCapabilities As Button
    Friend WithEvents rtbCapabilities As RichTextBox
End Class
