<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.NetworkingBtnMainWnd = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelWelcome = New System.Windows.Forms.Label()
        Me.LabelWarningMain = New System.Windows.Forms.Label()
        Me.PCInfo = New System.Windows.Forms.Button()
        Me.PCTroubleShooting = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NetworkingBtnMainWnd
        '
        Me.NetworkingBtnMainWnd.Location = New System.Drawing.Point(29, 111)
        Me.NetworkingBtnMainWnd.Name = "NetworkingBtnMainWnd"
        Me.NetworkingBtnMainWnd.Size = New System.Drawing.Size(75, 23)
        Me.NetworkingBtnMainWnd.TabIndex = 0
        Me.NetworkingBtnMainWnd.Text = "Networking"
        Me.NetworkingBtnMainWnd.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(768, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'LabelWelcome
        '
        Me.LabelWelcome.AutoSize = True
        Me.LabelWelcome.Location = New System.Drawing.Point(115, 24)
        Me.LabelWelcome.Name = "LabelWelcome"
        Me.LabelWelcome.Size = New System.Drawing.Size(395, 13)
        Me.LabelWelcome.TabIndex = 2
        Me.LabelWelcome.Text = "Welcome to the MyTech Specialist Ver 2.0 Beta Application (Light Theme Version)"
        '
        'LabelWarningMain
        '
        Me.LabelWarningMain.AutoSize = True
        Me.LabelWarningMain.Location = New System.Drawing.Point(132, 54)
        Me.LabelWarningMain.Name = "LabelWarningMain"
        Me.LabelWarningMain.Size = New System.Drawing.Size(378, 26)
        Me.LabelWarningMain.TabIndex = 3
        Me.LabelWarningMain.Text = "Warning! - DO Not Use Any Avaliable Options Unless Instructed To Do So By" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A MyTe" & _
            "ch Specialist Staff Member, Failure To Do So May Result In Data Loss."
        '
        'PCInfo
        '
        Me.PCInfo.Location = New System.Drawing.Point(29, 141)
        Me.PCInfo.Name = "PCInfo"
        Me.PCInfo.Size = New System.Drawing.Size(75, 37)
        Me.PCInfo.TabIndex = 4
        Me.PCInfo.Text = "Check PC Info"
        Me.PCInfo.UseVisualStyleBackColor = True
        '
        'PCTroubleShooting
        '
        Me.PCTroubleShooting.Location = New System.Drawing.Point(12, 184)
        Me.PCTroubleShooting.Name = "PCTroubleShooting"
        Me.PCTroubleShooting.Size = New System.Drawing.Size(108, 25)
        Me.PCTroubleShooting.TabIndex = 5
        Me.PCTroubleShooting.Text = "PC Troubleshooting"
        Me.PCTroubleShooting.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 688)
        Me.Controls.Add(Me.PCTroubleShooting)
        Me.Controls.Add(Me.PCInfo)
        Me.Controls.Add(Me.LabelWarningMain)
        Me.Controls.Add(Me.LabelWelcome)
        Me.Controls.Add(Me.NetworkingBtnMainWnd)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "MyTech Specialist Command Help Tool"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NetworkingBtnMainWnd As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelWelcome As System.Windows.Forms.Label
    Friend WithEvents LabelWarningMain As System.Windows.Forms.Label
    Friend WithEvents PCInfo As System.Windows.Forms.Button
    Friend WithEvents PCTroubleShooting As System.Windows.Forms.Button

End Class
