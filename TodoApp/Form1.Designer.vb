<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.AppscreenTitle = New System.Windows.Forms.Label()
        Me.TaskemptyTextInfo = New System.Windows.Forms.Label()
        Me.createTaskLabelLink = New System.Windows.Forms.LinkLabel()
        Me.AccUsernameTxt = New System.Windows.Forms.Label()
        Me.accountLKLB = New System.Windows.Forms.LinkLabel()
        Me.NewActivityBTN = New System.Windows.Forms.Button()
        Me.NewTaskBTN = New System.Windows.Forms.Button()
        Me.AcivityemptyinfoTXT = New System.Windows.Forms.Label()
        Me.ActivityTitleLBL = New System.Windows.Forms.Label()
        Me.ActivityListBX = New System.Windows.Forms.ListBox()
        Me.SelectTaskLIstView = New System.Windows.Forms.ListBox()
        Me.LogoutBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.SystemColors.Window
        Me.TitleLabel.Location = New System.Drawing.Point(44, 40)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(233, 37)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "To-Do Application"
        '
        'AppscreenTitle
        '
        Me.AppscreenTitle.AutoSize = True
        Me.AppscreenTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppscreenTitle.ForeColor = System.Drawing.SystemColors.Window
        Me.AppscreenTitle.Location = New System.Drawing.Point(51, 94)
        Me.AppscreenTitle.Name = "AppscreenTitle"
        Me.AppscreenTitle.Size = New System.Drawing.Size(91, 17)
        Me.AppscreenTitle.TabIndex = 1
        Me.AppscreenTitle.Text = "Your to-do list"
        '
        'TaskemptyTextInfo
        '
        Me.TaskemptyTextInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TaskemptyTextInfo.AutoSize = True
        Me.TaskemptyTextInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskemptyTextInfo.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.TaskemptyTextInfo.Location = New System.Drawing.Point(883, 266)
        Me.TaskemptyTextInfo.Name = "TaskemptyTextInfo"
        Me.TaskemptyTextInfo.Size = New System.Drawing.Size(175, 20)
        Me.TaskemptyTextInfo.TabIndex = 2
        Me.TaskemptyTextInfo.Text = "No task items to display"
        '
        'createTaskLabelLink
        '
        Me.createTaskLabelLink.ActiveLinkColor = System.Drawing.Color.GhostWhite
        Me.createTaskLabelLink.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.createTaskLabelLink.AutoSize = True
        Me.createTaskLabelLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createTaskLabelLink.Location = New System.Drawing.Point(884, 292)
        Me.createTaskLabelLink.Name = "createTaskLabelLink"
        Me.createTaskLabelLink.Size = New System.Drawing.Size(128, 16)
        Me.createTaskLabelLink.TabIndex = 3
        Me.createTaskLabelLink.TabStop = True
        Me.createTaskLabelLink.Text = "Create your first task"
        '
        'AccUsernameTxt
        '
        Me.AccUsernameTxt.AutoSize = True
        Me.AccUsernameTxt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccUsernameTxt.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.AccUsernameTxt.Location = New System.Drawing.Point(1118, 52)
        Me.AccUsernameTxt.Name = "AccUsernameTxt"
        Me.AccUsernameTxt.Size = New System.Drawing.Size(108, 25)
        Me.AccUsernameTxt.TabIndex = 4
        Me.AccUsernameTxt.Text = "Usernname"
        '
        'accountLKLB
        '
        Me.accountLKLB.ActiveLinkColor = System.Drawing.Color.White
        Me.accountLKLB.AutoSize = True
        Me.accountLKLB.Location = New System.Drawing.Point(1120, 94)
        Me.accountLKLB.Name = "accountLKLB"
        Me.accountLKLB.Size = New System.Drawing.Size(0, 13)
        Me.accountLKLB.TabIndex = 5
        '
        'NewActivityBTN
        '
        Me.NewActivityBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NewActivityBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewActivityBTN.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewActivityBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NewActivityBTN.Location = New System.Drawing.Point(131, 499)
        Me.NewActivityBTN.Name = "NewActivityBTN"
        Me.NewActivityBTN.Size = New System.Drawing.Size(146, 34)
        Me.NewActivityBTN.TabIndex = 6
        Me.NewActivityBTN.Text = "Create new Activity"
        Me.NewActivityBTN.UseVisualStyleBackColor = True
        '
        'NewTaskBTN
        '
        Me.NewTaskBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewTaskBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewTaskBTN.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewTaskBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NewTaskBTN.Location = New System.Drawing.Point(912, 499)
        Me.NewTaskBTN.Name = "NewTaskBTN"
        Me.NewTaskBTN.Size = New System.Drawing.Size(146, 34)
        Me.NewTaskBTN.TabIndex = 7
        Me.NewTaskBTN.Text = "Create new Task"
        Me.NewTaskBTN.UseVisualStyleBackColor = True
        '
        'AcivityemptyinfoTXT
        '
        Me.AcivityemptyinfoTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AcivityemptyinfoTXT.AutoSize = True
        Me.AcivityemptyinfoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcivityemptyinfoTXT.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.AcivityemptyinfoTXT.Location = New System.Drawing.Point(70, 266)
        Me.AcivityemptyinfoTXT.Name = "AcivityemptyinfoTXT"
        Me.AcivityemptyinfoTXT.Size = New System.Drawing.Size(192, 20)
        Me.AcivityemptyinfoTXT.TabIndex = 8
        Me.AcivityemptyinfoTXT.Text = "No activity items to display"
        '
        'ActivityTitleLBL
        '
        Me.ActivityTitleLBL.AutoSize = True
        Me.ActivityTitleLBL.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActivityTitleLBL.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ActivityTitleLBL.Location = New System.Drawing.Point(793, 126)
        Me.ActivityTitleLBL.Name = "ActivityTitleLBL"
        Me.ActivityTitleLBL.Size = New System.Drawing.Size(0, 25)
        Me.ActivityTitleLBL.TabIndex = 9
        '
        'ActivityListBX
        '
        Me.ActivityListBX.BackColor = System.Drawing.Color.DarkMagenta
        Me.ActivityListBX.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ActivityListBX.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActivityListBX.ForeColor = System.Drawing.SystemColors.Window
        Me.ActivityListBX.FormattingEnabled = True
        Me.ActivityListBX.ItemHeight = 30
        Me.ActivityListBX.Location = New System.Drawing.Point(54, 163)
        Me.ActivityListBX.Name = "ActivityListBX"
        Me.ActivityListBX.Size = New System.Drawing.Size(223, 330)
        Me.ActivityListBX.TabIndex = 10
        '
        'SelectTaskLIstView
        '
        Me.SelectTaskLIstView.BackColor = System.Drawing.Color.DarkMagenta
        Me.SelectTaskLIstView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SelectTaskLIstView.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectTaskLIstView.ForeColor = System.Drawing.SystemColors.Window
        Me.SelectTaskLIstView.FormattingEnabled = True
        Me.SelectTaskLIstView.ItemHeight = 30
        Me.SelectTaskLIstView.Location = New System.Drawing.Point(436, 154)
        Me.SelectTaskLIstView.Name = "SelectTaskLIstView"
        Me.SelectTaskLIstView.Size = New System.Drawing.Size(790, 330)
        Me.SelectTaskLIstView.TabIndex = 11
        '
        'LogoutBTN
        '
        Me.LogoutBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogoutBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutBTN.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutBTN.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.LogoutBTN.Location = New System.Drawing.Point(1080, 499)
        Me.LogoutBTN.Name = "LogoutBTN"
        Me.LogoutBTN.Size = New System.Drawing.Size(146, 34)
        Me.LogoutBTN.TabIndex = 12
        Me.LogoutBTN.Text = "Log Out"
        Me.LogoutBTN.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(1253, 538)
        Me.Controls.Add(Me.LogoutBTN)
        Me.Controls.Add(Me.SelectTaskLIstView)
        Me.Controls.Add(Me.ActivityListBX)
        Me.Controls.Add(Me.ActivityTitleLBL)
        Me.Controls.Add(Me.AcivityemptyinfoTXT)
        Me.Controls.Add(Me.NewTaskBTN)
        Me.Controls.Add(Me.NewActivityBTN)
        Me.Controls.Add(Me.accountLKLB)
        Me.Controls.Add(Me.AccUsernameTxt)
        Me.Controls.Add(Me.createTaskLabelLink)
        Me.Controls.Add(Me.TaskemptyTextInfo)
        Me.Controls.Add(Me.AppscreenTitle)
        Me.Controls.Add(Me.TitleLabel)
        Me.Name = "Form1"
        Me.Text = "Todo App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents AppscreenTitle As Label
    Friend WithEvents TaskemptyTextInfo As Label
    Friend WithEvents createTaskLabelLink As LinkLabel
    Friend WithEvents AccUsernameTxt As Label
    Friend WithEvents accountLKLB As LinkLabel
    Friend WithEvents NewActivityBTN As Button
    Friend WithEvents NewTaskBTN As Button
    Friend WithEvents AcivityemptyinfoTXT As Label
    Friend WithEvents ActivityTitleLBL As Label
    Friend WithEvents ActivityListBX As ListBox
    Friend WithEvents SelectTaskLIstView As ListBox
    Friend WithEvents LogoutBTN As Button
End Class
