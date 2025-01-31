Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Xml


Public Class Form3



    ' Function to get PTZ capabilities
    Private Sub GetPTZCapabilities()
        ' Construct the URL for getting capabilities
        Dim url As String = $"http://{ipAddress}/ISAPI/PTZCtrl/channels/1/capabilities"

        ' Create a WebRequest object
        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        request.Method = "GET"
        request.Credentials = New NetworkCredential(username, password)

        Try
            ' Send the request and get the response
            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Using responseStream As System.IO.Stream = response.GetResponseStream()
                    Using reader As New System.IO.StreamReader(responseStream)
                        Dim capabilities As String = reader.ReadToEnd()
                        rtbCapabilities.Text = capabilities
                        ' Save capabilities to examine supported speed parameters
                        Form1.stlStatus.Text = "Capabilities retrieved successfully"
                    End Using
                End Using
            End Using
        Catch ex As WebException
            Form1.stlStatus.Text = $"Error getting capabilities: {ex.Message}"
            If ex.Response IsNot Nothing Then
                Using responseStream As System.IO.Stream = ex.Response.GetResponseStream()
                    Using reader As New System.IO.StreamReader(responseStream)
                        Dim errorResponse As String = reader.ReadToEnd()
                        rtbCapabilities.Text = $"Error Response: {errorResponse}"
                    End Using
                End Using
            End If
        End Try
    End Sub

    Private Sub btnGetCapabilities_Click(sender As Object, e As EventArgs) Handles btnGetCapabilities.Click
        Call GetPTZCapabilities()
        '   Dim xmlData As String = "<root><item>Value</item></root>"
        DisplayFormattedXML(rtbCapabilities, rtbCapabilities.Text)
        ' DisplayFormattedXMLWithColors(rtbCapabilities, rtbCapabilities.Text)
    End Sub



    Public Sub DisplayFormattedXML(rtb As RichTextBox, xmlString As String)
        Try
            ' Load the XML string into an XmlDocument
            Dim xmlDoc As New XmlDocument()
            xmlDoc.LoadXml(xmlString)

            ' Create a StringWriter to hold formatted XML
            Dim stringWriter As New StringWriter()
            Dim xmlTextWriter As New XmlTextWriter(stringWriter) With {
                .Formatting = Formatting.Indented, ' Enable indentation
                .Indentation = 4 ' Set indentation level (spaces)
            }

            ' Write formatted XML to the StringWriter
            xmlDoc.WriteTo(xmlTextWriter)
            xmlTextWriter.Flush()

            ' Display formatted XML in the RichTextBox
            rtb.Text = stringWriter.ToString()
        Catch ex As Exception
            ' Display error message if XML is invalid
            rtb.Text = "Error formatting XML: " & ex.Message
        End Try
    End Sub



    Public Sub DisplayFormattedXMLWithColors(rtb As RichTextBox, xmlString As String)
        Try
            ' Load and format the XML properly
            Dim xmlDoc As New XmlDocument()
            xmlDoc.LoadXml(xmlString)

            Dim stringWriter As New StringWriter()
            Dim xmlTextWriter As New XmlTextWriter(stringWriter) With {
            .Formatting = Formatting.Indented,
            .Indentation = 4
        }
            xmlDoc.WriteTo(xmlTextWriter)
            xmlTextWriter.Flush()

            ' Prepare RichTextBox for fast rendering
            rtb.SuspendLayout()
            rtb.Clear()

            ' Store formatted XML text
            Dim formattedXml As String = stringWriter.ToString()
            rtb.Text = formattedXml ' First, set plain text

            ' Use regex to match XML structure
            Dim regex As New Regex("(<[^>]+>)|([^<>]+)", RegexOptions.Singleline)
            Dim startIndex As Integer = 0

            ' Apply syntax highlighting
            For Each match As Match In regex.Matches(formattedXml)
                rtb.SelectionStart = startIndex
                rtb.SelectionLength = match.Length

                If match.Value.StartsWith("<") AndAlso match.Value.EndsWith(">") Then
                    ' XML tags (blue color)
                    rtb.SelectionColor = Color.Blue
                ElseIf Not String.IsNullOrWhiteSpace(match.Value) Then
                    ' XML values (red color)
                    rtb.SelectionColor = Color.Red
                End If

                startIndex += match.Length
            Next

            ' Reset selection and enable layout
            rtb.SelectionStart = 0
            rtb.SelectionLength = 0
            rtb.SelectionColor = Color.Black
            rtb.ResumeLayout()

        Catch ex As Exception
            rtb.Text = "Error formatting XML: " & ex.Message
            rtb.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = Form1.Top + (Form1.Height - Me.Height) / 2
        Me.Left = Form1.Left + (Form1.Width - Me.Width) / 2
    End Sub
End Class