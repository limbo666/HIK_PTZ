Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = Form1.Top + (Form1.Height - Me.Height) / 2
        Me.Left = Form1.Left + (Form1.Width - Me.Width) / 2
    End Sub
End Class