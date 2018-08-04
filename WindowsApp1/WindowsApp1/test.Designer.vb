<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientInfo
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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FirstName = New System.Windows.Forms.Label()
        Me.LastName = New System.Windows.Forms.Label()
        Me.PreferredName = New System.Windows.Forms.Label()
        Me.LegalName = New System.Windows.Forms.Label()
        Me.HeightLabel = New System.Windows.Forms.Label()
        Me.WeightLabel = New System.Windows.Forms.Label()
        Me.Height = New System.Windows.Forms.Label()
        Me.Weight = New System.Windows.Forms.Label()
        Me.Photo = New System.Windows.Forms.PictureBox()
        CType(Me.Photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'FirstName
        '
        Me.FirstName.AutoSize = True
        Me.FirstName.Location = New System.Drawing.Point(139, 252)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(76, 17)
        Me.FirstName.TabIndex = 1
        Me.FirstName.Text = "First Name"
        '
        'LastName
        '
        Me.LastName.AutoSize = True
        Me.LastName.Location = New System.Drawing.Point(221, 252)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(76, 17)
        Me.LastName.TabIndex = 2
        Me.LastName.Text = "Last Name"
        '
        'PreferredName
        '
        Me.PreferredName.AutoSize = True
        Me.PreferredName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreferredName.Location = New System.Drawing.Point(53, 193)
        Me.PreferredName.Name = "PreferredName"
        Me.PreferredName.Size = New System.Drawing.Size(144, 25)
        Me.PreferredName.TabIndex = 3
        Me.PreferredName.Text = "PreferredName"
        '
        'LegalName
        '
        Me.LegalName.AutoSize = True
        Me.LegalName.Location = New System.Drawing.Point(45, 252)
        Me.LegalName.Name = "LegalName"
        Me.LegalName.Size = New System.Drawing.Size(88, 17)
        Me.LegalName.TabIndex = 4
        Me.LegalName.Text = "Legal Name:"
        '
        'HeightLabel
        '
        Me.HeightLabel.AutoSize = True
        Me.HeightLabel.Location = New System.Drawing.Point(467, 201)
        Me.HeightLabel.Name = "HeightLabel"
        Me.HeightLabel.Size = New System.Drawing.Size(53, 17)
        Me.HeightLabel.TabIndex = 5
        Me.HeightLabel.Text = "Height:"
        '
        'WeightLabel
        '
        Me.WeightLabel.AutoSize = True
        Me.WeightLabel.Location = New System.Drawing.Point(464, 252)
        Me.WeightLabel.Name = "WeightLabel"
        Me.WeightLabel.Size = New System.Drawing.Size(56, 17)
        Me.WeightLabel.TabIndex = 6
        Me.WeightLabel.Text = "Weight:"
        '
        'Height
        '
        Me.Height.AutoSize = True
        Me.Height.Location = New System.Drawing.Point(567, 201)
        Me.Height.Name = "Height"
        Me.Height.Size = New System.Drawing.Size(47, 17)
        Me.Height.TabIndex = 7
        Me.Height.Text = "height"
        '
        'Weight
        '
        Me.Weight.AutoSize = True
        Me.Weight.Location = New System.Drawing.Point(567, 252)
        Me.Weight.Name = "Weight"
        Me.Weight.Size = New System.Drawing.Size(48, 17)
        Me.Weight.TabIndex = 8
        Me.Weight.Text = "weight"
        '
        'Photo
        '
        Me.Photo.Location = New System.Drawing.Point(76, 68)
        Me.Photo.Name = "Photo"
        Me.Photo.Size = New System.Drawing.Size(199, 114)
        Me.Photo.TabIndex = 9
        Me.Photo.TabStop = False
        '
        'PatientInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 505)
        Me.Controls.Add(Me.Photo)
        Me.Controls.Add(Me.Weight)
        Me.Controls.Add(Me.Height)
        Me.Controls.Add(Me.WeightLabel)
        Me.Controls.Add(Me.HeightLabel)
        Me.Controls.Add(Me.LegalName)
        Me.Controls.Add(Me.PreferredName)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.FirstName)
        Me.Name = "PatientInfo"
        Me.Text = "'\''\"
        CType(Me.Photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents FirstName As Label
    Friend WithEvents LastName As Label
    Friend WithEvents PreferredName As Label
    Friend WithEvents LegalName As Label
    Friend WithEvents HeightLabel As Label
    Friend WithEvents WeightLabel As Label
    Friend WithEvents Height As Label
    Friend WithEvents Weight As Label
    Friend WithEvents Photo As PictureBox
End Class
