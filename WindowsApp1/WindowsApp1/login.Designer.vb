<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPW = New System.Windows.Forms.Label()
        Me.txtPw = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(133, 127)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(122, 32)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username:"
        '
        'lblPW
        '
        Me.lblPW.AutoSize = True
        Me.lblPW.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPW.Location = New System.Drawing.Point(133, 203)
        Me.lblPW.Name = "lblPW"
        Me.lblPW.Size = New System.Drawing.Size(112, 32)
        Me.lblPW.TabIndex = 1
        Me.lblPW.Text = "Password:"
        '
        'txtPw
        '
        Me.txtPw.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPw.Location = New System.Drawing.Point(270, 203)
        Me.txtPw.Name = "txtPw"
        Me.txtPw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPw.Size = New System.Drawing.Size(406, 34)
        Me.txtPw.TabIndex = 2
        Me.txtPw.UseSystemPasswordChar = True
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(270, 127)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(406, 34)
        Me.txtUser.TabIndex = 3
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtPw)
        Me.Controls.Add(Me.lblPW)
        Me.Controls.Add(Me.lblUsername)
        Me.Name = "login"
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPW As Label
    Friend WithEvents txtPw As TextBox
    Friend WithEvents txtUser As TextBox
End Class
