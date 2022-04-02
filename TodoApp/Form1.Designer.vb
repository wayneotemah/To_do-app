<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.AppscreenTitle = New System.Windows.Forms.Label()
        Me.emptyTextInfo = New System.Windows.Forms.Label()
        Me.createTaskLabelLink = New System.Windows.Forms.LinkLabel()
        Me.SchoolActivityPanel = New System.Windows.Forms.Panel()
        Me.SchoolActTitle = New System.Windows.Forms.Label()
        Me.WorkActivityPanel = New System.Windows.Forms.Panel()
        Me.WorkActlTitle = New System.Windows.Forms.Label()
        Me.PersonalActivityPanel = New System.Windows.Forms.Panel()
        Me.PersonalActTitle = New System.Windows.Forms.Label()
        Me.SchoolActivityPanel.SuspendLayout()
        Me.WorkActivityPanel.SuspendLayout()
        Me.PersonalActivityPanel.SuspendLayout()
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
        'emptyTextInfo
        '
        Me.emptyTextInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.emptyTextInfo.AutoSize = True
        Me.emptyTextInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emptyTextInfo.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.emptyTextInfo.Location = New System.Drawing.Point(883, 266)
        Me.emptyTextInfo.Name = "emptyTextInfo"
        Me.emptyTextInfo.Size = New System.Drawing.Size(141, 20)
        Me.emptyTextInfo.TabIndex = 2
        Me.emptyTextInfo.Text = "No items to display"
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
        'SchoolActivityPanel
        '
        Me.SchoolActivityPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SchoolActivityPanel.Controls.Add(Me.SchoolActTitle)
        Me.SchoolActivityPanel.Location = New System.Drawing.Point(54, 156)
        Me.SchoolActivityPanel.Name = "SchoolActivityPanel"
        Me.SchoolActivityPanel.Size = New System.Drawing.Size(536, 119)
        Me.SchoolActivityPanel.TabIndex = 4
        '
        'SchoolActTitle
        '
        Me.SchoolActTitle.AutoSize = True
        Me.SchoolActTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchoolActTitle.ForeColor = System.Drawing.Color.Silver
        Me.SchoolActTitle.Location = New System.Drawing.Point(3, 12)
        Me.SchoolActTitle.Name = "SchoolActTitle"
        Me.SchoolActTitle.Size = New System.Drawing.Size(135, 25)
        Me.SchoolActTitle.TabIndex = 0
        Me.SchoolActTitle.Text = "School Activity"
        '
        'WorkActivityPanel
        '
        Me.WorkActivityPanel.BackColor = System.Drawing.Color.MediumVioletRed
        Me.WorkActivityPanel.Controls.Add(Me.WorkActlTitle)
        Me.WorkActivityPanel.Location = New System.Drawing.Point(55, 292)
        Me.WorkActivityPanel.Name = "WorkActivityPanel"
        Me.WorkActivityPanel.Size = New System.Drawing.Size(536, 119)
        Me.WorkActivityPanel.TabIndex = 5
        '
        'WorkActlTitle
        '
        Me.WorkActlTitle.AutoSize = True
        Me.WorkActlTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkActlTitle.ForeColor = System.Drawing.Color.Silver
        Me.WorkActlTitle.Location = New System.Drawing.Point(3, 10)
        Me.WorkActlTitle.Name = "WorkActlTitle"
        Me.WorkActlTitle.Size = New System.Drawing.Size(122, 25)
        Me.WorkActlTitle.TabIndex = 0
        Me.WorkActlTitle.Text = "Work Activity"
        '
        'PersonalActivityPanel
        '
        Me.PersonalActivityPanel.BackColor = System.Drawing.Color.SlateBlue
        Me.PersonalActivityPanel.Controls.Add(Me.PersonalActTitle)
        Me.PersonalActivityPanel.Location = New System.Drawing.Point(54, 432)
        Me.PersonalActivityPanel.Name = "PersonalActivityPanel"
        Me.PersonalActivityPanel.Size = New System.Drawing.Size(536, 119)
        Me.PersonalActivityPanel.TabIndex = 5
        '
        'PersonalActTitle
        '
        Me.PersonalActTitle.AutoSize = True
        Me.PersonalActTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonalActTitle.ForeColor = System.Drawing.Color.Silver
        Me.PersonalActTitle.Location = New System.Drawing.Point(3, 9)
        Me.PersonalActTitle.Name = "PersonalActTitle"
        Me.PersonalActTitle.Size = New System.Drawing.Size(150, 25)
        Me.PersonalActTitle.TabIndex = 0
        Me.PersonalActTitle.Text = "Personal Activity"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(1253, 538)
        Me.Controls.Add(Me.PersonalActivityPanel)
        Me.Controls.Add(Me.WorkActivityPanel)
        Me.Controls.Add(Me.SchoolActivityPanel)
        Me.Controls.Add(Me.createTaskLabelLink)
        Me.Controls.Add(Me.emptyTextInfo)
        Me.Controls.Add(Me.AppscreenTitle)
        Me.Controls.Add(Me.TitleLabel)
        Me.Name = "Form1"
        Me.Text = "Todo App"
        Me.SchoolActivityPanel.ResumeLayout(False)
        Me.SchoolActivityPanel.PerformLayout()
        Me.WorkActivityPanel.ResumeLayout(False)
        Me.WorkActivityPanel.PerformLayout()
        Me.PersonalActivityPanel.ResumeLayout(False)
        Me.PersonalActivityPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents AppscreenTitle As Label
    Friend WithEvents emptyTextInfo As Label
    Friend WithEvents createTaskLabelLink As LinkLabel
    Friend WithEvents SchoolActivityPanel As Panel
    Friend WithEvents SchoolActTitle As Label
    Friend WithEvents WorkActivityPanel As Panel
    Friend WithEvents WorkActlTitle As Label
    Friend WithEvents PersonalActivityPanel As Panel
    Friend WithEvents PersonalActTitle As Label
End Class
