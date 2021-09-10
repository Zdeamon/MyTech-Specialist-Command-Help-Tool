<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PCTroubleshootingMainWnd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RunDismRestoreHealth = New System.Windows.Forms.Button()
        Me.RunDismScanHealth = New System.Windows.Forms.Button()
        Me.RunDismCheckHealth = New System.Windows.Forms.Button()
        Me.RunSFCScannow = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.EnableSafeModeBooting = New System.Windows.Forms.Button()
        Me.EnableSafeModeBootingNetworking = New System.Windows.Forms.Button()
        Me.EnableSafeModeCMD = New System.Windows.Forms.Button()
        Me.DisableSafeMode = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(327, 282)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RunDismRestoreHealth)
        Me.GroupBox1.Controls.Add(Me.RunDismScanHealth)
        Me.GroupBox1.Controls.Add(Me.RunDismCheckHealth)
        Me.GroupBox1.Controls.Add(Me.RunSFCScannow)
        Me.GroupBox1.Location = New System.Drawing.Point(67, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(122, 184)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Repair Tools"
        '
        'RunDismRestoreHealth
        '
        Me.RunDismRestoreHealth.Location = New System.Drawing.Point(7, 137)
        Me.RunDismRestoreHealth.Name = "RunDismRestoreHealth"
        Me.RunDismRestoreHealth.Size = New System.Drawing.Size(107, 34)
        Me.RunDismRestoreHealth.TabIndex = 3
        Me.RunDismRestoreHealth.Text = "Run Dism Restore Health"
        Me.RunDismRestoreHealth.UseVisualStyleBackColor = True
        '
        'RunDismScanHealth
        '
        Me.RunDismScanHealth.Location = New System.Drawing.Point(7, 95)
        Me.RunDismScanHealth.Name = "RunDismScanHealth"
        Me.RunDismScanHealth.Size = New System.Drawing.Size(106, 35)
        Me.RunDismScanHealth.TabIndex = 2
        Me.RunDismScanHealth.Text = "Run Dism Scan Health"
        Me.RunDismScanHealth.UseVisualStyleBackColor = True
        '
        'RunDismCheckHealth
        '
        Me.RunDismCheckHealth.Location = New System.Drawing.Point(7, 49)
        Me.RunDismCheckHealth.Name = "RunDismCheckHealth"
        Me.RunDismCheckHealth.Size = New System.Drawing.Size(106, 39)
        Me.RunDismCheckHealth.TabIndex = 1
        Me.RunDismCheckHealth.Text = "Run Dism Health Check"
        Me.RunDismCheckHealth.UseVisualStyleBackColor = True
        '
        'RunSFCScannow
        '
        Me.RunSFCScannow.Location = New System.Drawing.Point(6, 19)
        Me.RunSFCScannow.Name = "RunSFCScannow"
        Me.RunSFCScannow.Size = New System.Drawing.Size(107, 23)
        Me.RunSFCScannow.TabIndex = 0
        Me.RunSFCScannow.Text = "Run SFC Scannow"
        Me.RunSFCScannow.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DisableSafeMode)
        Me.GroupBox2.Controls.Add(Me.EnableSafeModeCMD)
        Me.GroupBox2.Controls.Add(Me.EnableSafeModeBootingNetworking)
        Me.GroupBox2.Controls.Add(Me.EnableSafeModeBooting)
        Me.GroupBox2.Location = New System.Drawing.Point(208, 35)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Size = New System.Drawing.Size(122, 184)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SafeMode"
        '
        'EnableSafeModeBooting
        '
        Me.EnableSafeModeBooting.Location = New System.Drawing.Point(7, 20)
        Me.EnableSafeModeBooting.Name = "EnableSafeModeBooting"
        Me.EnableSafeModeBooting.Size = New System.Drawing.Size(108, 22)
        Me.EnableSafeModeBooting.TabIndex = 0
        Me.EnableSafeModeBooting.Text = "Enable Safe-Mode"
        Me.EnableSafeModeBooting.UseVisualStyleBackColor = True
        '
        'EnableSafeModeBootingNetworking
        '
        Me.EnableSafeModeBootingNetworking.Location = New System.Drawing.Point(9, 49)
        Me.EnableSafeModeBootingNetworking.Name = "EnableSafeModeBootingNetworking"
        Me.EnableSafeModeBootingNetworking.Size = New System.Drawing.Size(105, 36)
        Me.EnableSafeModeBootingNetworking.TabIndex = 1
        Me.EnableSafeModeBootingNetworking.Text = "Enable Safe-Mode With Networking"
        Me.EnableSafeModeBootingNetworking.UseVisualStyleBackColor = True
        '
        'EnableSafeModeCMD
        '
        Me.EnableSafeModeCMD.Location = New System.Drawing.Point(8, 96)
        Me.EnableSafeModeCMD.Name = "EnableSafeModeCMD"
        Me.EnableSafeModeCMD.Size = New System.Drawing.Size(105, 34)
        Me.EnableSafeModeCMD.TabIndex = 2
        Me.EnableSafeModeCMD.Text = "Enable Safe-Mode With CMD"
        Me.EnableSafeModeCMD.UseVisualStyleBackColor = True
        '
        'DisableSafeMode
        '
        Me.DisableSafeMode.Location = New System.Drawing.Point(8, 142)
        Me.DisableSafeMode.Name = "DisableSafeMode"
        Me.DisableSafeMode.Size = New System.Drawing.Size(105, 29)
        Me.DisableSafeMode.TabIndex = 3
        Me.DisableSafeMode.Text = "Disable Safe-Mode"
        Me.DisableSafeMode.UseVisualStyleBackColor = True
        '
        'PCTroubleshootingMainWnd
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 317)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PCTroubleshootingMainWnd"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Computer Troubleshooting"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RunDismRestoreHealth As System.Windows.Forms.Button
    Friend WithEvents RunDismScanHealth As System.Windows.Forms.Button
    Friend WithEvents RunDismCheckHealth As System.Windows.Forms.Button
    Friend WithEvents RunSFCScannow As System.Windows.Forms.Button
    Friend WithEvents DisableSafeMode As System.Windows.Forms.Button
    Friend WithEvents EnableSafeModeCMD As System.Windows.Forms.Button
    Friend WithEvents EnableSafeModeBootingNetworking As System.Windows.Forms.Button
    Friend WithEvents EnableSafeModeBooting As System.Windows.Forms.Button

End Class
