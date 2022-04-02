<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signup
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
        Me.SignUpNametxt = New System.Windows.Forms.TextBox()
        Me.SignupLabe = New System.Windows.Forms.Label()
        Me.SignUpMsg = New System.Windows.Forms.Label()
        Me.SignUpNameLBL = New System.Windows.Forms.Label()
        Me.SingupEmailLBL = New System.Windows.Forms.Label()
        Me.SignUpEmailTXT = New System.Windows.Forms.TextBox()
        Me.SignUpBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SignUpNametxt
        '
        Me.SignUpNametxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SignUpNametxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SignUpNametxt.Location = New System.Drawing.Point(251, 245)
        Me.SignUpNametxt.Multiline = True
        Me.SignUpNametxt.Name = "SignUpNametxt"
        Me.SignUpNametxt.Size = New System.Drawing.Size(183, 20)
        Me.SignUpNametxt.TabIndex = 0
        '
        'SignupLabe
        '
        Me.SignupLabe.AutoSize = True
        Me.SignupLabe.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignupLabe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SignupLabe.Location = New System.Drawing.Point(97, 71)
        Me.SignupLabe.Name = "SignupLabe"
        Me.SignupLabe.Size = New System.Drawing.Size(113, 37)
        Me.SignupLabe.TabIndex = 1
        Me.SignupLabe.Text = "Sign Up"
        '
        'SignUpMsg
        '
        Me.SignUpMsg.AutoSize = True
        Me.SignUpMsg.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignUpMsg.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SignUpMsg.Location = New System.Drawing.Point(100, 130)
        Me.SignUpMsg.Name = "SignUpMsg"
        Me.SignUpMsg.Size = New System.Drawing.Size(342, 42)
        Me.SignUpMsg.TabIndex = 2
        Me.SignUpMsg.Text = "Sign up and start usign the *TO DO App* today. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Increase you productivity and ef" &
    "fectivness. "
        '
        'SignUpNameLBL
        '
        Me.SignUpNameLBL.AutoSize = True
        Me.SignUpNameLBL.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignUpNameLBL.ForeColor = System.Drawing.Color.White
        Me.SignUpNameLBL.Location = New System.Drawing.Point(99, 239)
        Me.SignUpNameLBL.Name = "SignUpNameLBL"
        Me.SignUpNameLBL.Size = New System.Drawing.Size(94, 25)
        Me.SignUpNameLBL.TabIndex = 3
        Me.SignUpNameLBL.Text = "Full name"
        '
        'SingupEmailLBL
        '
        Me.SingupEmailLBL.AutoSize = True
        Me.SingupEmailLBL.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SingupEmailLBL.ForeColor = System.Drawing.Color.White
        Me.SingupEmailLBL.Location = New System.Drawing.Point(99, 308)
        Me.SingupEmailLBL.Name = "SingupEmailLBL"
        Me.SingupEmailLBL.Size = New System.Drawing.Size(58, 25)
        Me.SingupEmailLBL.TabIndex = 5
        Me.SingupEmailLBL.Text = "Email"
        '
        'SignUpEmailTXT
        '
        Me.SignUpEmailTXT.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SignUpEmailTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SignUpEmailTXT.Location = New System.Drawing.Point(251, 314)
        Me.SignUpEmailTXT.Multiline = True
        Me.SignUpEmailTXT.Name = "SignUpEmailTXT"
        Me.SignUpEmailTXT.Size = New System.Drawing.Size(183, 20)
        Me.SignUpEmailTXT.TabIndex = 4
        '
        'SignUpBTN
        '
        Me.SignUpBTN.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SignUpBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignUpBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SignUpBTN.Location = New System.Drawing.Point(1077, 474)
        Me.SignUpBTN.Name = "SignUpBTN"
        Me.SignUpBTN.Size = New System.Drawing.Size(134, 37)
        Me.SignUpBTN.TabIndex = 6
        Me.SignUpBTN.Text = "Sign Up"
        Me.SignUpBTN.UseVisualStyleBackColor = True
        '
        'Signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(1253, 537)
        Me.Controls.Add(Me.SignUpBTN)
        Me.Controls.Add(Me.SingupEmailLBL)
        Me.Controls.Add(Me.SignUpEmailTXT)
        Me.Controls.Add(Me.SignUpNameLBL)
        Me.Controls.Add(Me.SignUpMsg)
        Me.Controls.Add(Me.SignupLabe)
        Me.Controls.Add(Me.SignUpNametxt)
        Me.Name = "Signup"
        Me.Text = "Signup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SignUpNametxt As TextBox
    Friend WithEvents SignupLabe As Label
    Friend WithEvents SignUpMsg As Label
    Friend WithEvents SignUpNameLBL As Label
    Friend WithEvents SingupEmailLBL As Label
    Friend WithEvents SignUpEmailTXT As TextBox
    Friend WithEvents SignUpBTN As Button
End Class
