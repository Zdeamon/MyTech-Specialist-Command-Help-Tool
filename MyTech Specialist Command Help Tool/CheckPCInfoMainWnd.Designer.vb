<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckPCInfoMainWnd
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
        Me.CheckRunningProcesses = New System.Windows.Forms.Button()
        Me.CheckDriverDates = New System.Windows.Forms.Button()
        Me.CheckSysyInfo = New System.Windows.Forms.Button()
        Me.X86X64Info = New System.Windows.Forms.Button()
        Me.CheckRamDetails = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(233, 259)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(61, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckRamDetails)
        Me.GroupBox1.Controls.Add(Me.X86X64Info)
        Me.GroupBox1.Controls.Add(Me.CheckSysyInfo)
        Me.GroupBox1.Controls.Add(Me.CheckDriverDates)
        Me.GroupBox1.Controls.Add(Me.CheckRunningProcesses)
        Me.GroupBox1.Location = New System.Drawing.Point(76, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(126, 254)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Computer Information"
        '
        'CheckRunningProcesses
        '
        Me.CheckRunningProcesses.Location = New System.Drawing.Point(25, 19)
        Me.CheckRunningProcesses.Name = "CheckRunningProcesses"
        Me.CheckRunningProcesses.Size = New System.Drawing.Size(75, 52)
        Me.CheckRunningProcesses.TabIndex = 0
        Me.CheckRunningProcesses.Text = "Check Running Processes"
        Me.CheckRunningProcesses.UseVisualStyleBackColor = True
        '
        'CheckDriverDates
        '
        Me.CheckDriverDates.Location = New System.Drawing.Point(25, 112)
        Me.CheckDriverDates.Name = "CheckDriverDates"
        Me.CheckDriverDates.Size = New System.Drawing.Size(75, 40)
        Me.CheckDriverDates.TabIndex = 1
        Me.CheckDriverDates.Text = "Check Driver Dates"
        Me.CheckDriverDates.UseVisualStyleBackColor = True
        '
        'CheckSysyInfo
        '
        Me.CheckSysyInfo.Location = New System.Drawing.Point(25, 77)
        Me.CheckSysyInfo.Name = "CheckSysyInfo"
        Me.CheckSysyInfo.Size = New System.Drawing.Size(75, 29)
        Me.CheckSysyInfo.TabIndex = 2
        Me.CheckSysyInfo.Text = "System Info"
        Me.CheckSysyInfo.UseVisualStyleBackColor = True
        '
        'X86X64Info
        '
        Me.X86X64Info.Location = New System.Drawing.Point(25, 158)
        Me.X86X64Info.Name = "X86X64Info"
        Me.X86X64Info.Size = New System.Drawing.Size(75, 36)
        Me.X86X64Info.TabIndex = 3
        Me.X86X64Info.Text = "x86/x64 Bit Info"
        Me.X86X64Info.UseVisualStyleBackColor = True
        '
        'CheckRamDetails
        '
        Me.CheckRamDetails.Location = New System.Drawing.Point(25, 201)
        Me.CheckRamDetails.Name = "CheckRamDetails"
        Me.CheckRamDetails.Size = New System.Drawing.Size(75, 36)
        Me.CheckRamDetails.TabIndex = 4
        Me.CheckRamDetails.Text = "Check Ram Details"
        Me.CheckRamDetails.UseVisualStyleBackColor = True
        '
        'CheckPCInfoMainWnd
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 318)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CheckPCInfoMainWnd"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Check PC Info"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckRunningProcesses As System.Windows.Forms.Button
    Friend WithEvents CheckDriverDates As System.Windows.Forms.Button
    Friend WithEvents CheckSysyInfo As System.Windows.Forms.Button
    Friend WithEvents X86X64Info As System.Windows.Forms.Button
    Friend WithEvents CheckRamDetails As System.Windows.Forms.Button

End Class
