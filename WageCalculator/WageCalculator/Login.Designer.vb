<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
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
        Me.usernameLabel = New System.Windows.Forms.Label()
        Me.passwordLabel = New System.Windows.Forms.Label()
        Me.txtBoxUsername = New System.Windows.Forms.TextBox()
        Me.txtBoxPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'usernameLabel
        '
        Me.usernameLabel.AutoSize = True
        Me.usernameLabel.Location = New System.Drawing.Point(13, 30)
        Me.usernameLabel.Name = "usernameLabel"
        Me.usernameLabel.Size = New System.Drawing.Size(55, 13)
        Me.usernameLabel.TabIndex = 0
        Me.usernameLabel.Text = "Username"
        '
        'passwordLabel
        '
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.Location = New System.Drawing.Point(13, 68)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(53, 13)
        Me.passwordLabel.TabIndex = 1
        Me.passwordLabel.Text = "Password"
        '
        'txtBoxUsername
        '
        Me.txtBoxUsername.Location = New System.Drawing.Point(74, 27)
        Me.txtBoxUsername.Name = "txtBoxUsername"
        Me.txtBoxUsername.Size = New System.Drawing.Size(243, 20)
        Me.txtBoxUsername.TabIndex = 2
        '
        'txtBoxPassword
        '
        Me.txtBoxPassword.Location = New System.Drawing.Point(72, 65)
        Me.txtBoxPassword.Name = "txtBoxPassword"
        Me.txtBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBoxPassword.Size = New System.Drawing.Size(243, 20)
        Me.txtBoxPassword.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(124, 99)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 134)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtBoxPassword)
        Me.Controls.Add(Me.txtBoxUsername)
        Me.Controls.Add(Me.passwordLabel)
        Me.Controls.Add(Me.usernameLabel)
        Me.Name = "loginForm"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents usernameLabel As System.Windows.Forms.Label
    Friend WithEvents passwordLabel As System.Windows.Forms.Label
    Friend WithEvents txtBoxUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button

End Class
