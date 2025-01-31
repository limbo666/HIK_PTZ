' Hikvision PTZ Preset Call Script
' This script calls PTZ preset 2 on a Hikvision camera

' Camera details
Dim ipAddress, username, password
ipAddress = "192.168.1.63"
username = "admin"
password = "aaa12345"

' PTZ preset number
Dim presetNumber
presetNumber = 1

' Construct the URL for the PTZ preset call
Dim url
url = "http://" & ipAddress & "/ISAPI/PTZCtrl/channels/1/presets/" & presetNumber & "/goto"

' Create XMLHTTP object to send the HTTP request
Dim http
Set http = CreateObject("MSXML2.XMLHTTP")

' Send the HTTP GET request
http.Open "PUT", url, False, username, password
http.Send

' Check the response status
If http.Status = 200 Then
    WScript.Echo "PTZ preset " & presetNumber & " called successfully."
Else
    WScript.Echo "Failed to call PTZ preset. Status code: " & http.Status
End If

' Clean up
Set http = Nothing