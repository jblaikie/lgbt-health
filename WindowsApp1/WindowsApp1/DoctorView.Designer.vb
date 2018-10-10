<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctorView
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
        Me.ptntpic1 = New System.Windows.Forms.PictureBox()
        Me.ptntpic2 = New System.Windows.Forms.PictureBox()
        Me.ptntpic3 = New System.Windows.Forms.PictureBox()
        Me.Labelptnt = New System.Windows.Forms.Label()
        Me.ptntname1 = New System.Windows.Forms.Label()
        Me.ptntname2 = New System.Windows.Forms.Label()
        Me.ptntname3 = New System.Windows.Forms.Label()
        Me.welcome = New System.Windows.Forms.Label()
        CType(Me.ptntpic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptntpic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptntpic3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ptntpic1
        '
        Me.ptntpic1.Location = New System.Drawing.Point(59, 159)
        Me.ptntpic1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ptntpic1.Name = "ptntpic1"
        Me.ptntpic1.Size = New System.Drawing.Size(84, 77)
        Me.ptntpic1.TabIndex = 0
        Me.ptntpic1.TabStop = False
        '
        'ptntpic2
        '
        Me.ptntpic2.Location = New System.Drawing.Point(193, 159)
        Me.ptntpic2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ptntpic2.Name = "ptntpic2"
        Me.ptntpic2.Size = New System.Drawing.Size(92, 76)
        Me.ptntpic2.TabIndex = 1
        Me.ptntpic2.TabStop = False
        '
        'ptntpic3
        '
        Me.ptntpic3.Location = New System.Drawing.Point(331, 159)
        Me.ptntpic3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ptntpic3.Name = "ptntpic3"
        Me.ptntpic3.Size = New System.Drawing.Size(82, 76)
        Me.ptntpic3.TabIndex = 2
        Me.ptntpic3.TabStop = False
        '
        'Labelptnt
        '
        Me.Labelptnt.AutoSize = True
        Me.Labelptnt.Location = New System.Drawing.Point(25, 111)
        Me.Labelptnt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Labelptnt.Name = "Labelptnt"
        Me.Labelptnt.Size = New System.Drawing.Size(59, 13)
        Me.Labelptnt.TabIndex = 3
        Me.Labelptnt.Text = "Patient List"
        '
        'ptntname1
        '
        Me.ptntname1.AutoSize = True
        Me.ptntname1.Location = New System.Drawing.Point(64, 251)
        Me.ptntname1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ptntname1.Name = "ptntname1"
        Me.ptntname1.Size = New System.Drawing.Size(31, 13)
        Me.ptntname1.TabIndex = 4
        Me.ptntname1.Text = "ptnt1"
        '
        'ptntname2
        '
        Me.ptntname2.AutoSize = True
        Me.ptntname2.Location = New System.Drawing.Point(200, 255)
        Me.ptntname2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ptntname2.Name = "ptntname2"
        Me.ptntname2.Size = New System.Drawing.Size(39, 13)
        Me.ptntname2.TabIndex = 5
        Me.ptntname2.Text = "Label1"
        '
        'ptntname3
        '
        Me.ptntname3.AutoSize = True
        Me.ptntname3.Location = New System.Drawing.Point(337, 259)
        Me.ptntname3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ptntname3.Name = "ptntname3"
        Me.ptntname3.Size = New System.Drawing.Size(39, 13)
        Me.ptntname3.TabIndex = 6
        Me.ptntname3.Text = "Label1"
        '
        'welcome
        '
        Me.welcome.AutoSize = True
        Me.welcome.Location = New System.Drawing.Point(39, 33)
        Me.welcome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.welcome.Name = "welcome"
        Me.welcome.Size = New System.Drawing.Size(67, 13)
        Me.welcome.TabIndex = 7
        Me.welcome.Text = "Hello, doctor"
        '
        'DoctorView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.welcome)
        Me.Controls.Add(Me.ptntname3)
        Me.Controls.Add(Me.ptntname2)
        Me.Controls.Add(Me.ptntname1)
        Me.Controls.Add(Me.Labelptnt)
        Me.Controls.Add(Me.ptntpic3)
        Me.Controls.Add(Me.ptntpic2)
        Me.Controls.Add(Me.ptntpic1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "DoctorView"
        Me.Text = "DoctorView"
        CType(Me.ptntpic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptntpic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptntpic3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ptntpic1 As PictureBox
    Friend WithEvents ptntpic2 As PictureBox
    Friend WithEvents ptntpic3 As PictureBox
    Friend WithEvents Labelptnt As Label
    Friend WithEvents ptntname1 As Label
    Friend WithEvents ptntname2 As Label
    Friend WithEvents ptntname3 As Label
    Friend WithEvents welcome As Label
End Class
