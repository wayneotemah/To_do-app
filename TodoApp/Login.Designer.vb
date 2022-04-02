<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.LoginLBL = New System.Windows.Forms.Label()
        Me.UsernameTXT = New System.Windows.Forms.TextBox()
        Me.PasswordTXT = New System.Windows.Forms.TextBox()
        Me.NameLoginLB = New System.Windows.Forms.Label()
        Me.PassLogingLB = New System.Windows.Forms.Label()
        Me.LogBTN = New System.Windows.Forms.Button()
        Me.SignInLKLB = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'LoginLBL
        '
        Me.LoginLBL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LoginLBL.AutoSize = True
        Me.LoginLBL.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginLBL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LoginLBL.Location = New System.Drawing.Point(578, 202)
        Me.LoginLBL.Name = "LoginLBL"
        Me.LoginLBL.Size = New System.Drawing.Size(64, 30)
        Me.LoginLBL.TabIndex = 0
        Me.LoginLBL.Text = "Login"
        Me.LoginLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'UsernameTXT
        '
        Me.UsernameTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UsernameTXT.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UsernameTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UsernameTXT.ForeColor = System.Drawing.SystemColors.Window
        Me.UsernameTXT.Location = New System.Drawing.Point(583, 286)
        Me.UsernameTXT.Multiline = True
        Me.UsernameTXT.Name = "UsernameTXT"
        Me.UsernameTXT.Size = New System.Drawing.Size(149, 20)
        Me.UsernameTXT.TabIndex = 2
        '
        'PasswordTXT
        '
        Me.PasswordTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PasswordTXT.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PasswordTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PasswordTXT.ForeColor = System.Drawing.SystemColors.Window
        Me.PasswordTXT.Location = New System.Drawing.Point(583, 348)
        Me.PasswordTXT.Multiline = True
        Me.PasswordTXT.Name = "PasswordTXT"
        Me.PasswordTXT.Size = New System.Drawing.Size(149, 20)
        Me.PasswordTXT.TabIndex = 3
        '
        'NameLoginLB
        '
        Me.NameLoginLB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NameLoginLB.AutoSize = True
        Me.NameLoginLB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLoginLB.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NameLoginLB.Location = New System.Drawing.Point(466, 286)
        Me.NameLoginLB.Name = "NameLoginLB"
        Me.NameLoginLB.Size = New System.Drawing.Size(81, 21)
        Me.NameLoginLB.TabIndex = 4
        Me.NameLoginLB.Text = "Username"
        '
        'PassLogingLB
        '
        Me.PassLogingLB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PassLogingLB.AutoSize = True
        Me.PassLogingLB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassLogingLB.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PassLogingLB.Location = New System.Drawing.Point(466, 345)
        Me.PassLogingLB.Name = "PassLogingLB"
        Me.PassLogingLB.Size = New System.Drawing.Size(76, 21)
        Me.PassLogingLB.TabIndex = 5
        Me.PassLogingLB.Text = "Password"
        '
        'LogBTN
        '
        Me.LogBTN.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LogBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogBTN.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LogBTN.Location = New System.Drawing.Point(1089, 481)
        Me.LogBTN.Name = "LogBTN"
        Me.LogBTN.Size = New System.Drawing.Size(120, 39)
        Me.LogBTN.TabIndex = 6
        Me.LogBTN.Text = "Login"
        Me.LogBTN.UseVisualStyleBackColor = True
        '
        'SignInLKLB
        '
        Me.SignInLKLB.ActiveLinkColor = System.Drawing.Color.WhiteSmoke
        Me.SignInLKLB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SignInLKLB.AutoSize = True
        Me.SignInLKLB.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignInLKLB.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SignInLKLB.Location = New System.Drawing.Point(583, 409)
        Me.SignInLKLB.Name = "SignInLKLB"
        Me.SignInLKLB.Size = New System.Drawing.Size(105, 17)
        Me.SignInLKLB.TabIndex = 7
        Me.SignInLKLB.TabStop = True
        Me.SignInLKLB.Text = "Create Account..."
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(1245, 547)
        Me.Controls.Add(Me.SignInLKLB)
        Me.Controls.Add(Me.LogBTN)
        Me.Controls.Add(Me.PassLogingLB)
        Me.Controls.Add(Me.NameLoginLB)
        Me.Controls.Add(Me.PasswordTXT)
        Me.Controls.Add(Me.UsernameTXT)
        Me.Controls.Add(Me.LoginLBL)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginLBL As Label
    Friend WithEvents UsernameTXT As TextBox
    Friend WithEvents PasswordTXT As TextBox
    Friend WithEvents NameLoginLB As Label
    Friend WithEvents PassLogingLB As Label
    Friend WithEvents LogBTN As Button
    Friend WithEvents SignInLKLB As LinkLabel
End Class
