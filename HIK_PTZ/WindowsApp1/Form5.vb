Imports System.Runtime.InteropServices

Public Class Form5
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Close()

    End Sub



    Private Sub btnUp_MouseDown(sender As Object, e As MouseEventArgs) Handles btnUp.MouseDown
        Form1.btnUp_MouseDown(Nothing, Nothing)
    End Sub

    Private Sub btnDown_MouseDown(sender As Object, e As MouseEventArgs) Handles btnDown.MouseDown
        Form1.btnDown_MouseDown(Nothing, Nothing)
    End Sub

    Private Sub btnRight_b_MouseDown(sender As Object, e As MouseEventArgs) Handles btnRight_b.MouseDown
        Form1.btnRight_MouseDown(Nothing, Nothing)
    End Sub

    Private Sub btnLeft_b_MouseDown(sender As Object, e As MouseEventArgs) Handles btnLeft_b.MouseDown
        Form1.btnLeft_MouseDown(Nothing, Nothing)
    End Sub

    Private Sub btnUp_MouseUp(sender As Object, e As MouseEventArgs) Handles btnUp.MouseUp
        Form1.btnUp_MouseUp(Nothing, Nothing)
    End Sub

    Private Sub btnDown_MouseUp(sender As Object, e As MouseEventArgs) Handles btnDown.MouseUp
        Form1.btnDown_MouseUp(Nothing, Nothing)
    End Sub

    Private Sub btnRight_b_MouseUp(sender As Object, e As MouseEventArgs) Handles btnRight_b.MouseUp
        Form1.btnRight_MouseUp(Nothing, Nothing)
    End Sub

    Private Sub btnLeft_b_MouseUp(sender As Object, e As MouseEventArgs) Handles btnLeft_b.MouseUp
        Form1.btnLeft_MouseUp(Nothing, Nothing)
    End Sub



    Private Sub btnZoomin_b_MouseDown(sender As Object, e As MouseEventArgs) Handles btnZoomin_b.MouseDown
        Form1.btnZoomIn_MouseDown(Nothing, Nothing)
    End Sub

    Private Sub btnZoomin_b_MouseUp(sender As Object, e As MouseEventArgs) Handles btnZoomin_b.MouseUp
        Form1.btnZoomIn_MouseUp(Nothing, Nothing)
    End Sub

    Private Sub btnZoomout_b_MouseDown(sender As Object, e As MouseEventArgs) Handles btnZoomout_b.MouseDown
        Form1.btnZoomOut_MouseDown(Nothing, Nothing)
    End Sub

    Private Sub btnZoomout_b_MouseUp(sender As Object, e As MouseEventArgs) Handles btnZoomout_b.MouseUp
        Form1.btnZoomOut_MouseUp(Nothing, Nothing)
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True

        Me.Top = RegGetSetting("Settings", "TinyTop", 100)
        Me.Left = RegGetSetting("Settings", "TinyLeft", 100)
    End Sub

    ' Import user32.dll functions to enable dragging
    <DllImport("user32.dll")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.dll")>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    ' Constants for sending messages
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = &H2

    ' Enable dragging when mouse is pressed on the form
    Private Sub Form5_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
        End If
    End Sub

    Private Sub Form5_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        RegSaveSetting("Settings", "TinyTop", Me.Top)
        RegSaveSetting("Settings", "TinyLeft", Me.Left)
    End Sub
End Class