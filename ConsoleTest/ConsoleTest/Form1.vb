Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Runs a sample JAR which saves the location where it's executing from to a text file
        RunJar("TestJava.jar")
    End Sub
    Shared Sub RunJar(command As String, Optional arguments As String = "")
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        pi.Arguments = " -jar " + command + " " + arguments
        'javaw instead of java so that a console window does not pop up
        pi.FileName = "javaw.exe"
        p.StartInfo = pi
        p.Start()
    End Sub
End Class
