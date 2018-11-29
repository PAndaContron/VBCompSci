Public Class JarRunner
    Private Shared processOutput As String
    Public Shared Function RunJar(jarFile As String, Optional arguments As String = "") As String
        processOutput = ""

        Dim p As Process = New Process()
        'javaw instead of java so that a console window does not pop up
        With p.StartInfo
            .FileName = "javaw.exe"
            .Arguments = " -jar " + jarFile + " " + arguments
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
