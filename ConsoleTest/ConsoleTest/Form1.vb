Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Runs a sample JAR which saves the location where it's executing from to a text file
        Label1.Text = JarRunner.RunJar("TestJava.jar", "null staticPrint")
    End Sub
End Class
