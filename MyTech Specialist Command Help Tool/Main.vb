Public Class Main

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub NetworkingBtnMainWnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NetworkingBtnMainWnd.Click
        NetworkingMainWnd.ShowDialog()
    End Sub

    Private Sub PCInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCInfo.Click
        CheckPCInfoMainWnd.ShowDialog()
    End Sub

    Private Sub PCTroubleShooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCTroubleShooting.Click
        PCTroubleshootingMainWnd.ShowDialog()
    End Sub
End Class
