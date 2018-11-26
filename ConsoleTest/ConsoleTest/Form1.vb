Public Class Form1
    Private Shared processOutput As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Runs a sample JAR which saves the location where it's executing from to a text file
        Label1.Text = RunJar("TestJava.jar")
    End Sub
    Private Shared Function RunJar(command As String, Optional arguments As String = "") As String
        Dim p As Process = New Process()
        'javaw instead of java so that a console window does not pop up
        With p.StartInfo
            .FileName = "javaw.exe"
            .Arguments = " -jar " + command + " " + arguments
            .RedirectStandardOutput = True
            .RedirectStandardError = True
            .RedirectStandardInput = True
            .UseShellExecute = False
            .WindowStyle = ProcessWindowStyle.Normal
            .CreateNoWindow = False
        End With

        AddHandler p.OutputDataReceived, AddressOf OutputHandler

        p.Start()
        p.BeginOutputReadLine()
        p.WaitForExit()
        Return processOutput
    End Function
    Private Shared Sub OutputHandler(sendingProcess As Object, outLine As DataReceivedEventArgs)
        ' Collect the sort command output.
        If Not String.IsNullOrEmpty(outLine.Data) Then
            ' Add the text to the collected output.
            processOutput = processOutput + outLine.Data
        End If
    End Sub
End Class
