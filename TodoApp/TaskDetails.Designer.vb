<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskDetails
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
        Me.TaskDetailTitleLBL = New System.Windows.Forms.Label()
        Me.TaskDetailsAccUsername = New System.Windows.Forms.Label()
        Me.TaskDetailsInfo = New System.Windows.Forms.Label()
        Me.TaskDetailsDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TaskDetailsStatus = New System.Windows.Forms.Label()
        Me.TaskDetailsBack = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TaskDetailTitleLBL
        '
        Me.TaskDetailTitleLBL.AutoSize = True
        Me.TaskDetailTitleLBL.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskDetailTitleLBL.Location = New System.Drawing.Point(82, 79)
        Me.TaskDetailTitleLBL.Name = "TaskDetailTitleLBL"
        Me.TaskDetailTitleLBL.Size = New System.Drawing.Size(81, 45)
        Me.TaskDetailTitleLBL.TabIndex = 0
        Me.TaskDetailTitleLBL.Text = "Title"
        '
        'TaskDetailsAccUsername
        '
        Me.TaskDetailsAccUsername.AutoSize = True
        Me.TaskDetailsAccUsername.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskDetailsAccUsername.Location = New System.Drawing.Point(1113, 79)
        Me.TaskDetailsAccUsername.Name = "TaskDetailsAccUsername"
        Me.TaskDetailsAccUsername.Size = New System.Drawing.Size(122, 32)
        Me.TaskDetailsAccUsername.TabIndex = 1
        Me.TaskDetailsAccUsername.Text = "Username"
        '
        'TaskDetailsInfo
        '
        Me.TaskDetailsInfo.AutoSize = True
        Me.TaskDetailsInfo.Location = New System.Drawing.Point(86, 168)
        Me.TaskDetailsInfo.Name = "TaskDetailsInfo"
        Me.TaskDetailsInfo.Size = New System.Drawing.Size(56, 21)
        Me.TaskDetailsInfo.TabIndex = 2
        Me.TaskDetailsInfo.Text = "Label3"
        '
        'TaskDetailsDate
        '
        Me.TaskDetailsDate.AutoSize = True
        Me.TaskDetailsDate.Location = New System.Drawing.Point(86, 390)
        Me.TaskDetailsDate.Name = "TaskDetailsDate"
        Me.TaskDetailsDate.Size = New System.Drawing.Size(42, 21)
        Me.TaskDetailsDate.TabIndex = 3
        Me.TaskDetailsDate.Text = "Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 436)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Status :"
        '
        'TaskDetailsStatus
        '
        Me.TaskDetailsStatus.AutoSize = True
        Me.TaskDetailsStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskDetailsStatus.Location = New System.Drawing.Point(168, 436)
        Me.TaskDetailsStatus.Name = "TaskDetailsStatus"
        Me.TaskDetailsStatus.Size = New System.Drawing.Size(57, 21)
        Me.TaskDetailsStatus.TabIndex = 5
        Me.TaskDetailsStatus.Text = "Status"
        '
        'TaskDetailsBack
        '
        Me.TaskDetailsBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TaskDetailsBack.AutoSize = True
        Me.TaskDetailsBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TaskDetailsBack.Location = New System.Drawing.Point(1077, 502)
        Me.TaskDetailsBack.Name = "TaskDetailsBack"
        Me.TaskDetailsBack.Size = New System.Drawing.Size(158, 21)
        Me.TaskDetailsBack.TabIndex = 6
        Me.TaskDetailsBack.Text = "Back To Home Screen"
        '
        'TaskDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.TaskDetailsBack)
        Me.Controls.Add(Me.TaskDetailsStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TaskDetailsDate)
        Me.Controls.Add(Me.TaskDetailsInfo)
        Me.Controls.Add(Me.TaskDetailsAccUsername)
        Me.Controls.Add(Me.TaskDetailTitleLBL)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "TaskDetails"
        Me.Text = "TaskDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TaskDetailTitleLBL As Label
    Friend WithEvents TaskDetailsAccUsername As Label
    Friend WithEvents TaskDetailsInfo As Label
    Friend WithEvents TaskDetailsDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TaskDetailsStatus As Label
    Friend WithEvents TaskDetailsBack As Label
End Class
