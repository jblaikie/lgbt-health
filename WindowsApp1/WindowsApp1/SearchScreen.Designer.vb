<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchScreen
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.lblNumOfResults = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(89, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(351, 22)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.WordWrap = False
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(86, 64)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(169, 17)
        Me.lblResults.TabIndex = 1
        Me.lblResults.Text = "Number of Results found:"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(26, 31)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(57, 17)
        Me.lblSearch.TabIndex = 2
        Me.lblSearch.Text = "Search:"
        '
        'lblNumOfResults
        '
        Me.lblNumOfResults.AutoSize = True
        Me.lblNumOfResults.Location = New System.Drawing.Point(261, 64)
        Me.lblNumOfResults.Name = "lblNumOfResults"
        Me.lblNumOfResults.Size = New System.Drawing.Size(0, 17)
        Me.lblNumOfResults.TabIndex = 3
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(89, 113)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(943, 436)
        Me.ListBox1.TabIndex = 4
        '
        'SearchScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 682)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.lblNumOfResults)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "SearchScreen"
        Me.Text = "SearchScreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblResults As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents lblNumOfResults As Label
    Friend WithEvents ListBox1 As ListBox
End Class
