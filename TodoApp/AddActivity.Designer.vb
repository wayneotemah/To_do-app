<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddActivity
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
        Me.AddActivityTitleLBL = New System.Windows.Forms.Label()
        Me.AccUserNameLBL = New System.Windows.Forms.Label()
        Me.TaskNameLBL = New System.Windows.Forms.Label()
        Me.ActivityNameTXT = New System.Windows.Forms.TextBox()
        Me.SaveBTN = New System.Windows.Forms.Button()
        Me.CancelBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddActivityTitleLBL
        '
        Me.AddActivityTitleLBL.AutoSize = True
        Me.AddActivityTitleLBL.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddActivityTitleLBL.Location = New System.Drawing.Point(77, 79)
        Me.AddActivityTitleLBL.Name = "AddActivityTitleLBL"
        Me.AddActivityTitleLBL.Size = New System.Drawing.Size(140, 21)
        Me.AddActivityTitleLBL.TabIndex = 0
        Me.AddActivityTitleLBL.Text = "Add a new activity "
        '
        'AccUserNameLBL
        '
        Me.AccUserNameLBL.AutoSize = True
        Me.AccUserNameLBL.Location = New System.Drawing.Point(1076, 79)
        Me.AccUserNameLBL.Name = "AccUserNameLBL"
        Me.AccUserNameLBL.Size = New System.Drawing.Size(74, 17)
        Me.AccUserNameLBL.TabIndex = 1
        Me.AccUserNameLBL.Text = "Usernname"
        '
        'TaskNameLBL
        '
        Me.TaskNameLBL.AutoSize = True
        Me.TaskNameLBL.Location = New System.Drawing.Point(77, 258)
        Me.TaskNameLBL.Name = "TaskNameLBL"
        Me.TaskNameLBL.Size = New System.Drawing.Size(72, 17)
        Me.TaskNameLBL.TabIndex = 2
        Me.TaskNameLBL.Text = "Task Name"
        '
        'ActivityNameTXT
        '
        Me.ActivityNameTXT.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ActivityNameTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ActivityNameTXT.ForeColor = System.Drawing.SystemColors.Window
        Me.ActivityNameTXT.Location = New System.Drawing.Point(233, 258)
        Me.ActivityNameTXT.Name = "ActivityNameTXT"
        Me.ActivityNameTXT.Size = New System.Drawing.Size(194, 18)
        Me.ActivityNameTXT.TabIndex = 3
        '
        'SaveBTN
        '
        Me.SaveBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveBTN.Location = New System.Drawing.Point(1079, 470)
        Me.SaveBTN.Name = "SaveBTN"
        Me.SaveBTN.Size = New System.Drawing.Size(148, 44)
        Me.SaveBTN.TabIndex = 4
        Me.SaveBTN.Text = "Save"
        Me.SaveBTN.UseVisualStyleBackColor = True
        '
        'CancelBTN
        '
        Me.CancelBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBTN.Location = New System.Drawing.Point(890, 470)
        Me.CancelBTN.Name = "CancelBTN"
        Me.CancelBTN.Size = New System.Drawing.Size(144, 44)
        Me.CancelBTN.TabIndex = 5
        Me.CancelBTN.Text = "Cancal"
        Me.CancelBTN.UseVisualStyleBackColor = True
        '
        'AddActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(1479, 724)
        Me.Controls.Add(Me.CancelBTN)
        Me.Controls.Add(Me.SaveBTN)
        Me.Controls.Add(Me.ActivityNameTXT)
        Me.Controls.Add(Me.TaskNameLBL)
        Me.Controls.Add(Me.AccUserNameLBL)
        Me.Controls.Add(Me.AddActivityTitleLBL)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AddActivity"
        Me.Text = "AddActivity"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddActivityTitleLBL As Label
    Friend WithEvents AccUserNameLBL As Label
    Friend WithEvents TaskNameLBL As Label
    Friend WithEvents ActivityNameTXT As TextBox
    Friend WithEvents SaveBTN As Button
    Friend WithEvents CancelBTN As Button
End Class
