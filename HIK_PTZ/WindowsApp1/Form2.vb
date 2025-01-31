Imports System.Diagnostics.Eventing.Reader
Imports System.Security.Cryptography
Imports System.Text.RegularExpressions

Public Class Form2
    Private Sub chkReveal_CheckedChanged(sender As Object, e As EventArgs) Handles chkReveal.CheckedChanged
        If chkReveal.Checked Then
            txtPass.PasswordChar = ""
        Else
            txtPass.PasswordChar = "*"
        End If
    End Sub

    Private Sub txtIpAddress_TextChanged(sender As Object, e As EventArgs) Handles txtIPAddress.TextChanged
        If IsValidIPv4(txtIPAddress.Text) Then
            txtIPAddress.BackColor = Color.LightGreen ' Valid IP
        Else
            txtIPAddress.BackColor = Color.LightCoral ' Invalid IP
        End If
    End Sub

    Private Function IsValidIPv4(ip As String) As Boolean
        Dim regex As New Regex("^(25[0-5]|2[0-4][0-9]|1?[0-9]?[0-9])(\.(25[0-5]|2[0-4][0-9]|1?[0-9]?[0-9])){3}$")
        Return regex.IsMatch(ip)
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call SaveVariables()
    End Sub

    Private Sub SaveVariables()
        If IsValidIPv4(txtIPAddress.Text) Then
            ipAddress = txtIPAddress.Text
        Else
            Dim ans = MsgBox("IP address field doesn't seem to have a valid IP Address." & vbNewLine & "Continue with this value?", vbYesNo, "Invalid IP Address")
            If ans = vbNo Then

                Exit Sub
            Else
                ipAddress = txtIPAddress.Text

            End If


        End If


        username = txtUser.Text
        password = txtPass.Text

        Form1.lblTargetIP.Text = ipAddress


        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = Form1.Top + (Form1.Height - Me.Height) / 2
        Me.Left = Form1.Left + (Form1.Width - Me.Width) / 2

        txtIPAddress.Text = ipAddress

        txtUser.Text = username
        txtPass.Text = password
    End Sub
End Class