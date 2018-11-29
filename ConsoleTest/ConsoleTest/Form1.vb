Imports System.Web.Script.Serialization

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim ser As String = JarRunner.RunJar("TestJava.jar", "-convert string VB-String")
        'Label1.Text = JarRunner.RunJar("TestJava.jar", "{\""class\"":\""vbInterface.Test\"",\""object\"":null} staticEcho ""{\""class\"":\""java.lang.String\"",\""object\"":\""" + ser + "\""}""")
        Dim js As New JavaScriptSerializer()
    End Sub
End Class
