<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Move_to = New System.Windows.Forms.Button()
        Me.Move_x = New System.Windows.Forms.Button()
        Me.Move_y = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Count = New System.Windows.Forms.Button()
        Me.Edit_Start = New System.Windows.Forms.Button()
        Me.Nest_ = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Test = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Move_to
        '
        Me.Move_to.Location = New System.Drawing.Point(12, 12)
        Me.Move_to.Name = "Move_to"
        Me.Move_to.Size = New System.Drawing.Size(75, 23)
        Me.Move_to.TabIndex = 0
        Me.Move_to.Text = "Move to"
        Me.Move_to.UseVisualStyleBackColor = True
        '
        'Move_x
        '
        Me.Move_x.Location = New System.Drawing.Point(93, 12)
        Me.Move_x.Name = "Move_x"
        Me.Move_x.Size = New System.Drawing.Size(75, 23)
        Me.Move_x.TabIndex = 1
        Me.Move_x.Text = "Move x"
        Me.Move_x.UseVisualStyleBackColor = True
        '
        'Move_y
        '
        Me.Move_y.Location = New System.Drawing.Point(174, 12)
        Me.Move_y.Name = "Move_y"
        Me.Move_y.Size = New System.Drawing.Size(75, 23)
        Me.Move_y.TabIndex = 2
        Me.Move_y.Text = "Move y"
        Me.Move_y.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.SystemColors.Control
        Me.NumericUpDown1.DecimalPlaces = 4
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {625, 0, 0, 262144})
        Me.NumericUpDown1.Location = New System.Drawing.Point(255, 15)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 3
        '
        'Count
        '
        Me.Count.Location = New System.Drawing.Point(12, 54)
        Me.Count.Name = "Count"
        Me.Count.Size = New System.Drawing.Size(75, 23)
        Me.Count.TabIndex = 4
        Me.Count.Text = "Count"
        Me.Count.UseVisualStyleBackColor = True
        '
        'Edit_Start
        '
        Me.Edit_Start.Location = New System.Drawing.Point(12, 98)
        Me.Edit_Start.Name = "Edit_Start"
        Me.Edit_Start.Size = New System.Drawing.Size(75, 23)
        Me.Edit_Start.TabIndex = 5
        Me.Edit_Start.Text = "Edit Start"
        Me.Edit_Start.UseVisualStyleBackColor = True
        '
        'Nest_
        '
        Me.Nest_.Location = New System.Drawing.Point(12, 144)
        Me.Nest_.Name = "Nest_"
        Me.Nest_.Size = New System.Drawing.Size(75, 23)
        Me.Nest_.TabIndex = 6
        Me.Nest_.Text = "Nest"
        Me.Nest_.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 532)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "www.plastecprofiles.com/enroute"
        '
        'Test
        '
        Me.Test.Location = New System.Drawing.Point(12, 404)
        Me.Test.Name = "Test"
        Me.Test.Size = New System.Drawing.Size(78, 32)
        Me.Test.TabIndex = 10
        Me.Test.Text = "test"
        Me.Test.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(597, 522)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 554)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Test)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Nest_)
        Me.Controls.Add(Me.Edit_Start)
        Me.Controls.Add(Me.Count)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Move_y)
        Me.Controls.Add(Me.Move_x)
        Me.Controls.Add(Me.Move_to)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "PlastecAddins"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Move_to As Button
    Friend WithEvents Move_x As Button
    Friend WithEvents Move_y As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Count As Button
    Friend WithEvents Edit_Start As Button
    Friend WithEvents Nest_ As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Test As Button
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
