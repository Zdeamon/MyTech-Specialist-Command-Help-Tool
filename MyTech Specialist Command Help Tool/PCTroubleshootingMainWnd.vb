Imports System.Windows.Forms

Public Class PCTroubleshootingMainWnd

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub RunSFCScannow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunSFCScannow.Click
        Process.Start("cmd", "/k sfc /scannow")
    End Sub

    Private Sub RunDismCheckHealth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunDismCheckHealth.Click
        Process.Start("cmd", "/k DISM /Online /Cleanup-Image /CheckHealth")
    End Sub

    Private Sub RunDismScanHealth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunDismScanHealth.Click
        Process.Start("cmd", "/k DISM /Online /Cleanup-Image /ScanHealth")
    End Sub

    Private Sub RunDismRestoreHealth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunDismRestoreHealth.Click
        Process.Start("cmd", "/k DISM /Online /Cleanup-Image /RestoreHealth")
    End Sub

    Private Sub EnableSafeModeBooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableSafeModeBooting.Click
        Process.Start("cmd", "/c bcdedit /set {default} safeboot minimal")
    End Sub

    Private Sub EnableSafeModeBootingNetworking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableSafeModeBootingNetworking.Click
        Process.Start("cmd", "/c bcdedit /set {default} safeboot network")
    End Sub

    Private Sub EnableSafeModeCMD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableSafeModeCMD.Click
        Process.Start("cmd", "/c bcdedit /set {default} safeboot minimal")
        Process.Start("cmd", "/c bcdedit /set {default} safebootalternateshell")
    End Sub

    Private Sub DisableSafeMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisableSafeMode.Click
        Process.Start("cmd", "/k bcdedit /deletevalue {default} safeboot")
    End Sub
End Class
