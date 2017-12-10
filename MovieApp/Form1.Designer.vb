<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblInterested = New System.Windows.Forms.Label()
        Me.lblWatched = New System.Windows.Forms.Label()
        Me.intText = New System.Windows.Forms.TextBox()
        Me.intAdd = New System.Windows.Forms.Button()
        Me.intRemove = New System.Windows.Forms.Button()
        Me.wtchAdd = New System.Windows.Forms.Button()
        Me.wtchRemove = New System.Windows.Forms.Button()
        Me.wtchText = New System.Windows.Forms.TextBox()
        Me.intWatched = New System.Windows.Forms.Button()
        Me.intList = New System.Windows.Forms.Label()
        Me.wtchList = New System.Windows.Forms.Label()
        Me.intLabel = New System.Windows.Forms.Label()
        Me.wtchLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInterested
        '
        Me.lblInterested.AutoSize = True
        Me.lblInterested.Location = New System.Drawing.Point(200, 66)
        Me.lblInterested.Name = "lblInterested"
        Me.lblInterested.Size = New System.Drawing.Size(71, 17)
        Me.lblInterested.TabIndex = 0
        Me.lblInterested.Text = "Interested"
        '
        'lblWatched
        '
        Me.lblWatched.AutoSize = True
        Me.lblWatched.Location = New System.Drawing.Point(690, 66)
        Me.lblWatched.Name = "lblWatched"
        Me.lblWatched.Size = New System.Drawing.Size(64, 17)
        Me.lblWatched.TabIndex = 1
        Me.lblWatched.Text = "Watched"
        '
        'intText
        '
        Me.intText.Location = New System.Drawing.Point(187, 406)
        Me.intText.Name = "intText"
        Me.intText.Size = New System.Drawing.Size(100, 22)
        Me.intText.TabIndex = 2
        '
        'intAdd
        '
        Me.intAdd.Location = New System.Drawing.Point(293, 402)
        Me.intAdd.Name = "intAdd"
        Me.intAdd.Size = New System.Drawing.Size(75, 30)
        Me.intAdd.TabIndex = 3
        Me.intAdd.Text = "Add"
        Me.intAdd.UseVisualStyleBackColor = True
        '
        'intRemove
        '
        Me.intRemove.Location = New System.Drawing.Point(374, 402)
        Me.intRemove.Name = "intRemove"
        Me.intRemove.Size = New System.Drawing.Size(75, 30)
        Me.intRemove.TabIndex = 4
        Me.intRemove.Text = "Remove"
        Me.intRemove.UseVisualStyleBackColor = True
        '
        'wtchAdd
        '
        Me.wtchAdd.Location = New System.Drawing.Point(785, 401)
        Me.wtchAdd.Name = "wtchAdd"
        Me.wtchAdd.Size = New System.Drawing.Size(75, 31)
        Me.wtchAdd.TabIndex = 5
        Me.wtchAdd.Text = "Add"
        Me.wtchAdd.UseVisualStyleBackColor = True
        '
        'wtchRemove
        '
        Me.wtchRemove.Location = New System.Drawing.Point(866, 401)
        Me.wtchRemove.Name = "wtchRemove"
        Me.wtchRemove.Size = New System.Drawing.Size(75, 31)
        Me.wtchRemove.TabIndex = 6
        Me.wtchRemove.Text = "Remove"
        Me.wtchRemove.UseVisualStyleBackColor = True
        '
        'wtchText
        '
        Me.wtchText.Location = New System.Drawing.Point(679, 405)
        Me.wtchText.Name = "wtchText"
        Me.wtchText.Size = New System.Drawing.Size(100, 22)
        Me.wtchText.TabIndex = 7
        '
        'intWatched
        '
        Me.intWatched.Location = New System.Drawing.Point(293, 435)
        Me.intWatched.Name = "intWatched"
        Me.intWatched.Size = New System.Drawing.Size(156, 23)
        Me.intWatched.TabIndex = 8
        Me.intWatched.Text = "Move To Watched"
        Me.intWatched.UseVisualStyleBackColor = True
        '
        'intList
        '
        Me.intList.Location = New System.Drawing.Point(131, 107)
        Me.intList.Name = "intList"
        Me.intList.Size = New System.Drawing.Size(293, 282)
        Me.intList.TabIndex = 9
        '
        'wtchList
        '
        Me.wtchList.Location = New System.Drawing.Point(648, 107)
        Me.wtchList.Name = "wtchList"
        Me.wtchList.Size = New System.Drawing.Size(293, 282)
        Me.wtchList.TabIndex = 10
        '
        'intLabel
        '
        Me.intLabel.AutoSize = True
        Me.intLabel.Location = New System.Drawing.Point(184, 464)
        Me.intLabel.Name = "intLabel"
        Me.intLabel.Size = New System.Drawing.Size(0, 17)
        Me.intLabel.TabIndex = 11
        '
        'wtchLabel
        '
        Me.wtchLabel.AutoSize = True
        Me.wtchLabel.Location = New System.Drawing.Point(703, 438)
        Me.wtchLabel.Name = "wtchLabel"
        Me.wtchLabel.Size = New System.Drawing.Size(0, 17)
        Me.wtchLabel.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 515)
        Me.Controls.Add(Me.wtchLabel)
        Me.Controls.Add(Me.intLabel)
        Me.Controls.Add(Me.wtchList)
        Me.Controls.Add(Me.intList)
        Me.Controls.Add(Me.intWatched)
        Me.Controls.Add(Me.wtchText)
        Me.Controls.Add(Me.wtchRemove)
        Me.Controls.Add(Me.wtchAdd)
        Me.Controls.Add(Me.intRemove)
        Me.Controls.Add(Me.intAdd)
        Me.Controls.Add(Me.intText)
        Me.Controls.Add(Me.lblWatched)
        Me.Controls.Add(Me.lblInterested)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInterested As Label
    Friend WithEvents lblWatched As Label
    Friend WithEvents intText As TextBox
    Friend WithEvents intAdd As Button
    Friend WithEvents intRemove As Button
    Friend WithEvents wtchAdd As Button
    Friend WithEvents wtchRemove As Button
    Friend WithEvents wtchText As TextBox
    Friend WithEvents intWatched As Button
    Friend WithEvents intList As Label
    Friend WithEvents wtchList As Label
    Friend WithEvents intLabel As Label
    Friend WithEvents wtchLabel As Label
End Class
