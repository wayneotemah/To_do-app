<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Task
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
        Me.TaskLBL = New System.Windows.Forms.Label()
        Me.TaskLBL2 = New System.Windows.Forms.Label()
        Me.TitleLBL = New System.Windows.Forms.Label()
        Me.DetailsLBL = New System.Windows.Forms.Label()
        Me.TimeLBL = New System.Windows.Forms.Label()
        Me.TaskTXT = New System.Windows.Forms.TextBox()
        Me.DetailsTXT = New System.Windows.Forms.TextBox()
        Me.SaveTaskBTN = New System.Windows.Forms.Button()
        Me.CancelTaskBTN = New System.Windows.Forms.Button()
        Me.TaskTitileLBL = New System.Windows.Forms.Label()
        Me.Task_DateTime = New System.Windows.Forms.DateTimePicker()
        Me.AccUsernameLBL = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TaskLBL
        '
        Me.TaskLBL.AutoSize = True
        Me.TaskLBL.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskLBL.Location = New System.Drawing.Point(92, 96)
        Me.TaskLBL.Name = "TaskLBL"
        Me.TaskLBL.Size = New System.Drawing.Size(52, 30)
        Me.TaskLBL.TabIndex = 0
        Me.TaskLBL.Text = "Task"
        '
        'TaskLBL2
        '
        Me.TaskLBL2.AutoSize = True
        Me.TaskLBL2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskLBL2.Location = New System.Drawing.Point(92, 143)
        Me.TaskLBL2.Name = "TaskLBL2"
        Me.TaskLBL2.Size = New System.Drawing.Size(285, 17)
        Me.TaskLBL2.TabIndex = 1
        Me.TaskLBL2.Text = "Create a task by filling out the fields in the form"
        '
        'TitleLBL
        '
        Me.TitleLBL.AutoSize = True
        Me.TitleLBL.ForeColor = System.Drawing.Color.DarkGray
        Me.TitleLBL.Location = New System.Drawing.Point(93, 244)
        Me.TitleLBL.Name = "TitleLBL"
        Me.TitleLBL.Size = New System.Drawing.Size(69, 20)
        Me.TitleLBL.TabIndex = 2
        Me.TitleLBL.Text = "Task Title"
        '
        'DetailsLBL
        '
        Me.DetailsLBL.AutoSize = True
        Me.DetailsLBL.ForeColor = System.Drawing.Color.DarkGray
        Me.DetailsLBL.Location = New System.Drawing.Point(93, 300)
        Me.DetailsLBL.Name = "DetailsLBL"
        Me.DetailsLBL.Size = New System.Drawing.Size(59, 20)
        Me.DetailsLBL.TabIndex = 3
        Me.DetailsLBL.Text = "Details "
        '
        'TimeLBL
        '
        Me.TimeLBL.AutoSize = True
        Me.TimeLBL.ForeColor = System.Drawing.Color.DarkGray
        Me.TimeLBL.Location = New System.Drawing.Point(93, 434)
        Me.TimeLBL.Name = "TimeLBL"
        Me.TimeLBL.Size = New System.Drawing.Size(42, 20)
        Me.TimeLBL.TabIndex = 4
        Me.TimeLBL.Text = "Time"
        '
        'TaskTXT
        '
        Me.TaskTXT.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TaskTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TaskTXT.ForeColor = System.Drawing.SystemColors.Window
        Me.TaskTXT.Location = New System.Drawing.Point(228, 244)
        Me.TaskTXT.Name = "TaskTXT"
        Me.TaskTXT.Size = New System.Drawing.Size(149, 20)
        Me.TaskTXT.TabIndex = 6
        '
        'DetailsTXT
        '
        Me.DetailsTXT.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DetailsTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetailsTXT.ForeColor = System.Drawing.SystemColors.Window
        Me.DetailsTXT.Location = New System.Drawing.Point(228, 300)
        Me.DetailsTXT.Multiline = True
        Me.DetailsTXT.Name = "DetailsTXT"
        Me.DetailsTXT.Size = New System.Drawing.Size(334, 104)
        Me.DetailsTXT.TabIndex = 7
        '
        'SaveTaskBTN
        '
        Me.SaveTaskBTN.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SaveTaskBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveTaskBTN.Location = New System.Drawing.Point(1111, 477)
        Me.SaveTaskBTN.Name = "SaveTaskBTN"
        Me.SaveTaskBTN.Size = New System.Drawing.Size(111, 35)
        Me.SaveTaskBTN.TabIndex = 11
        Me.SaveTaskBTN.Text = "Save Task"
        Me.SaveTaskBTN.UseVisualStyleBackColor = True
        '
        'CancelTaskBTN
        '
        Me.CancelTaskBTN.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CancelTaskBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelTaskBTN.Location = New System.Drawing.Point(973, 477)
        Me.CancelTaskBTN.Name = "CancelTaskBTN"
        Me.CancelTaskBTN.Size = New System.Drawing.Size(111, 35)
        Me.CancelTaskBTN.TabIndex = 12
        Me.CancelTaskBTN.Text = "Cancel"
        Me.CancelTaskBTN.UseVisualStyleBackColor = True
        '
        'TaskTitileLBL
        '
        Me.TaskTitileLBL.AutoSize = True
        Me.TaskTitileLBL.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskTitileLBL.Location = New System.Drawing.Point(89, 40)
        Me.TaskTitileLBL.Name = "TaskTitileLBL"
        Me.TaskTitileLBL.Size = New System.Drawing.Size(111, 32)
        Me.TaskTitileLBL.TabIndex = 13
        Me.TaskTitileLBL.Text = "TaskTitile"
        '
        'Task_DateTime
        '
        Me.Task_DateTime.CalendarForeColor = System.Drawing.SystemColors.ControlLight
        Me.Task_DateTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Task_DateTime.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Task_DateTime.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Task_DateTime.Location = New System.Drawing.Point(228, 429)
        Me.Task_DateTime.Name = "Task_DateTime"
        Me.Task_DateTime.Size = New System.Drawing.Size(200, 27)
        Me.Task_DateTime.TabIndex = 14
        '
        'AccUsernameLBL
        '
        Me.AccUsernameLBL.AutoSize = True
        Me.AccUsernameLBL.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccUsernameLBL.Location = New System.Drawing.Point(968, 42)
        Me.AccUsernameLBL.Name = "AccUsernameLBL"
        Me.AccUsernameLBL.Size = New System.Drawing.Size(110, 30)
        Me.AccUsernameLBL.TabIndex = 15
        Me.AccUsernameLBL.Text = "UserName"
        '
        'Task
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(1253, 542)
        Me.Controls.Add(Me.AccUsernameLBL)
        Me.Controls.Add(Me.Task_DateTime)
        Me.Controls.Add(Me.TaskTitileLBL)
        Me.Controls.Add(Me.CancelTaskBTN)
        Me.Controls.Add(Me.SaveTaskBTN)
        Me.Controls.Add(Me.DetailsTXT)
        Me.Controls.Add(Me.TaskTXT)
        Me.Controls.Add(Me.TimeLBL)
        Me.Controls.Add(Me.DetailsLBL)
        Me.Controls.Add(Me.TitleLBL)
        Me.Controls.Add(Me.TaskLBL2)
        Me.Controls.Add(Me.TaskLBL)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Task"
        Me.Text = "Task"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TaskLBL As Label
    Friend WithEvents TaskLBL2 As Label
    Friend WithEvents TitleLBL As Label
    Friend WithEvents DetailsLBL As Label
    Friend WithEvents TimeLBL As Label
    Friend WithEvents TaskTXT As TextBox
    Friend WithEvents DetailsTXT As TextBox
    Friend WithEvents SaveTaskBTN As Button
    Friend WithEvents CancelTaskBTN As Button
    Friend WithEvents TaskTitileLBL As Label
    Friend WithEvents Task_DateTime As DateTimePicker
    Friend WithEvents AccUsernameLBL As Label
End Class
