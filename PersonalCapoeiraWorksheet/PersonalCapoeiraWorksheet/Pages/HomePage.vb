Imports SwdevIUI

Public Class HomePage
    Inherits PageTemplate
    Dim startTime As Date
    Dim elapsedTime As TimeSpan
    Private Sub linkStartStop_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkStartStop.LinkClicked
        If linkStartStop.Text = "Start" Then
            startTime = Now
            Timer1.Enabled = True
            linkStartStop.Text = "Stop"
        Else
            Timer1.Enabled = False
            linkStartStop.Text = "Start"
        End If
        
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'borrowed from http://vb-tips.blogspot.com/2007/09/track-elapsed-time-in-vbnet.html
        elapsedTime = Now().Subtract(startTime)
        lblClock.Text = String.Format("{0:00}:{1:00}:{2:00}", _
        CInt(elapsedTime.TotalHours), _
        CInt(elapsedTime.TotalMinutes) Mod 60, _
        CInt(elapsedTime.TotalSeconds) Mod 60)
    End Sub

    Private Sub linkPause_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPause.LinkClicked
        If linkPause.Text = "Pause" Then
            Timer1.Enabled = False
            linkPause.Text = "Continue"
            startTime = Now
        Else
            Timer1.Enabled = True
            linkPause.Text = "Pause"
        End If
        
    End Sub

    Private Sub linkReset_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        startTime = Now
        Timer1_Tick(Nothing, Nothing)
    End Sub

    Private Sub linkAbout_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkAbout.LinkClicked
        MainWindow.enterView(Pages.Item("about"))
    End Sub
End Class
