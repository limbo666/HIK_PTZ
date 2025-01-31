Imports System.Net
Imports System.Security.Cryptography
Imports System.Text

Public Class Form1

    Dim ptzSpeed As Integer = 40


    Private Sub SendPTZCommandWithVelocity(ByVal direction As String, ByVal speed As Integer, ByVal isStop As Boolean)
        Dim url As String = $"http://{ipAddress}/ISAPI/PTZCtrl/channels/1/continuous"

        ' Determine pan, tilt, zoom, and focus velocity values
        Dim panVelocity As Integer = 0
        Dim tiltVelocity As Integer = 0
        Dim zoomVelocity As Integer = 0
        Dim focusVelocity As Integer = 0

        If Not isStop Then
            Select Case direction
                Case "left"
                    panVelocity = -speed
                Case "right"
                    panVelocity = speed
                Case "up"
                    tiltVelocity = speed
                Case "down"
                    tiltVelocity = -speed
                Case "zoomin"
                    zoomVelocity = speed
                Case "zoomout"
                    zoomVelocity = -speed
                Case "focus+"
                    focusVelocity = speed
                Case "focus-"
                    focusVelocity = -speed
            End Select
        End If

        ' Update status label before sending the request
        If isStop Then
            stlStatus.Text = "Movement stopped."
        Else
            stlStatus.Text = $"Sending {direction} command at speed {speed}..."
        End If

        ' Construct XML for PTZ movement
        Dim postData As String = $"<?xml version=""1.0"" encoding=""UTF-8""?>
<PTZData>
    <pan>{panVelocity}</pan>
    <tilt>{tiltVelocity}</tilt>
    <zoom>{zoomVelocity}</zoom>
    <focus>{focusVelocity}</focus>
</PTZData>"

        ' Create HTTP request
        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        request.Method = "PUT"
        request.Credentials = New NetworkCredential(UserName, Password)
        request.ContentType = "application/xml"

        ' Convert the XML string to bytes and send request
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        request.ContentLength = byteArray.Length

        Using dataStream As System.IO.Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
        End Using

        ' Handle response
        Try
            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                If response.StatusCode = HttpStatusCode.OK Then
                    ' Only update on success
                    If Not isStop Then
                        stlStatus.Text = $"{direction} command sent successfully at speed {speed}."
                    End If
                Else
                    stlStatus.Text = $"Failed to send command. Status code: {response.StatusCode}"
                End If
            End Using
        Catch ex As WebException
            stlStatus.Text = $"Error: {ex.Message}"
        End Try
    End Sub

    Sub callPreset(presetNumberToCall As Integer)

        ' PTZ preset number
        Dim presetNumber As Integer = presetNumberToCall
        ' Construct the URL for the PTZ preset call
        Dim url As String = $"http://{ipAddress}/ISAPI/PTZCtrl/channels/1/presets/{presetNumber}/goto"

        ' Create a WebRequest object
        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        request.Method = "PUT"
        request.Credentials = New NetworkCredential(UserName, Password)

        Try
            ' Send the request and get the response
            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                If response.StatusCode = HttpStatusCode.OK Then
                    stlStatus.Text = $"PTZ preset {presetNumber} called successfully."
                Else
                    stlStatus.Text = $"Failed to call PTZ preset. Status code: {response.StatusCode}"
                End If
            End Using
        Catch ex As WebException
            ' Handle errors
            stlStatus.Text = $"Error: {ex.Message}"
        End Try
    End Sub


    ' MouseDown and MouseUp Event Handlers
    Sub btnLeft_MouseDown(sender As Object, e As MouseEventArgs) Handles btnLeft_b.MouseDown
        SendPTZCommandWithVelocity("left", ptzSpeed, False)
    End Sub
    Sub btnLeft_MouseUp(sender As Object, e As MouseEventArgs) Handles btnLeft_b.MouseUp
        SendPTZCommandWithVelocity("left", 0, True)
    End Sub

    Sub btnRight_MouseDown(sender As Object, e As MouseEventArgs) Handles btnRight_b.MouseDown
        SendPTZCommandWithVelocity("right", ptzSpeed, False)
    End Sub
    Sub btnRight_MouseUp(sender As Object, e As MouseEventArgs) Handles btnRight_b.MouseUp
        SendPTZCommandWithVelocity("right", 0, True)
    End Sub

    Sub btnUp_MouseDown(sender As Object, e As MouseEventArgs) Handles btnUp.MouseDown
        SendPTZCommandWithVelocity("up", ptzSpeed, False)
    End Sub
    Sub btnUp_MouseUp(sender As Object, e As MouseEventArgs) Handles btnUp.MouseUp
        SendPTZCommandWithVelocity("up", 0, True)
    End Sub

    Sub btnDown_MouseDown(sender As Object, e As MouseEventArgs) Handles btnDown.MouseDown
        SendPTZCommandWithVelocity("down", ptzSpeed, False)
    End Sub
    Sub btnDown_MouseUp(sender As Object, e As MouseEventArgs) Handles btnDown.MouseUp
        SendPTZCommandWithVelocity("down", 0, True)
    End Sub

    Sub btnZoomIn_MouseDown(sender As Object, e As MouseEventArgs) Handles btnZoomin_b.MouseDown
        SendPTZCommandWithVelocity("zoomin", ptzSpeed, False)
    End Sub
    Sub btnZoomIn_MouseUp(sender As Object, e As MouseEventArgs) Handles btnZoomin_b.MouseUp
        SendPTZCommandWithVelocity("zoomin", 0, True)
    End Sub

    Sub btnZoomOut_MouseDown(sender As Object, e As MouseEventArgs) Handles btnZoomout_b.MouseDown
        SendPTZCommandWithVelocity("zoomout", ptzSpeed, False)
    End Sub
    Sub btnZoomOut_MouseUp(sender As Object, e As MouseEventArgs) Handles btnZoomout_b.MouseUp
        SendPTZCommandWithVelocity("zoomout", 0, True)
    End Sub

    Sub btnFocusIn_MouseDown(sender As Object, e As MouseEventArgs) Handles btnFoxusplus_b.MouseDown
        SendPTZCommandWithVelocity("focus+", ptzSpeed, False)
    End Sub
    Sub btnFocusIn_MouseUp(sender As Object, e As MouseEventArgs) Handles btnFoxusplus_b.MouseUp
        SendPTZCommandWithVelocity("focus+", 0, True)
    End Sub

    Sub btnFocusOut_MouseDown(sender As Object, e As MouseEventArgs) Handles btnFocusminus_b.MouseDown
        SendPTZCommandWithVelocity("focus-", ptzSpeed, False)
    End Sub
    Sub btnFocusOut_MouseUp(sender As Object, e As MouseEventArgs) Handles btnFocusminus_b.MouseUp
        SendPTZCommandWithVelocity("focus-", 0, True)
    End Sub


    Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call callPreset(1)
    End Sub

    Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call callPreset(2)
    End Sub


    Sub Button3_Click(sender As Object, e As EventArgs)
        Call callPreset(10)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub



    Private Sub SetConnectionDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetConnectionDetailsToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub

    Private Sub DiagnosticToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiagnosticToolStripMenuItem.Click
        Form3.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Form4.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = RegGetSetting("Settings", "Top", 200)
        Me.Left = RegGetSetting("Settings", "Left", 200)

        ipAddress = RegGetSetting("Settings", "IPAddress", "192.168.1.64")
        username = RegGetSetting("Settings", "User", "admin")
        password = RegGetSetting("Settings", "Pass", "aaa12345")
        NumericUpDown1.Value = RegGetSetting("Settings", "Speed/10", 4)
        ptzSpeed = NumericUpDown1.Value * 10
        lblTargetIP.Text = ipAddress

    End Sub


    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        RegSaveSetting("Settings", "Top", Me.Top)
        RegSaveSetting("Settings", "Left", Me.Left)
        RegSaveSetting("Settings", "IPAddress", ipAddress)
        RegSaveSetting("Settings", "User", username)
        RegSaveSetting("Settings", "Pass", password)
        RegSaveSetting("Settings", "Speed/10", NumericUpDown1.Value)
    End Sub


    Private Sub lblTargetIP_Click(sender As Object, e As EventArgs) Handles lblTargetIP.Click
        Process.Start("http://" & ipAddress & ":" * Port)
    End Sub



    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        ptzSpeed = NumericUpDown1.Value * 10
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form5.Show()

    End Sub
End Class
