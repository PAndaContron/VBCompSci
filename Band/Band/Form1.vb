Public Class Form1
    Private Sub radBigTimeRush_Click(sender As Object, e As EventArgs) Handles radBigTimeRush.Click
        Me.lblInfo.Text = "Kendall Schmidt - vocals
James Maslow - vocals
Carlos Pena Jr. - vocals
Logan Henderson - vocals"
    End Sub

    Private Sub radBeatles_Click(sender As Object, e As EventArgs) Handles radBeatles.Click
        Me.lblInfo.Text = "John Lennon – vocals, rhythm and lead guitar, keyboards, harmonica, bass guitar
Paul McCartney – vocals, bass guitar, rhythm and lead guitar, keyboards, drums
George Harrison – lead and rhythm guitar, vocals, sitar, keyboards, bass guitar
Ringo Starr – drums, percussion, vocals"
    End Sub

    Private Sub radSmashMouth_Click(sender As Object, e As EventArgs) Handles radSmashMouth.Click
        Me.lblInfo.Text = "Paul De Lisle – bass, backing vocals
Steve Harwell – lead vocals
Michael Klooster – keyboards, programming, backing vocals
Randy Cooke – drums, percussion
Sam Eigen – guitar, backing vocals"
    End Sub

    Private Sub radRollingStones_Click(sender As Object, e As EventArgs) Handles radRollingStones.Click
        Me.lblInfo.Text = "Mick Jagger – vocals, harmonica, rhythm guitar, percussion, keyboards
Keith Richards – rhythm and lead guitar, bass guitar, vocals
Michael Klooster – keyboards, programming, backing vocals
Randy Cooke – drums, percussion"
    End Sub
End Class
