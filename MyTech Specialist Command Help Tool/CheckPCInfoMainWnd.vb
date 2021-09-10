Imports System.Windows.Forms

Public Class CheckPCInfoMainWnd

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckRunningProcesses.Click
        Process.Start("cmd", "/k tasklist")
    End Sub

    Private Sub CheckDriverDates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckDriverDates.Click
        Process.Start("cmd", "/k driverquery")
    End Sub

    Private Sub CheckSysyInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckSysyInfo.Click
        Process.Start("cmd", "/k systeminfo")
    End Sub

    Private Sub X86X64Info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles X86X64Info.Click
        Process.Start("cmd", "/k wmic computersystem get systemtype")
    End Sub

    Private Sub CheckRamDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckRamDetails.Click
        Process.Start("cmd", "/k wmic memorychip get devicelocator, speed, manufacturer")
    End Sub
End Class
