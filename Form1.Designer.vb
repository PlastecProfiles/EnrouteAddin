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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Test = New System.Windows.Forms.Button()
        Me.Circle = New System.Windows.Forms.Button()
        Me.Circle_move_to = New System.Windows.Forms.Button()
        Me.Circle_move = New System.Windows.Forms.Button()
        Me.Gapat = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Gapsize = New System.Windows.Forms.NumericUpDown()
        Me.selection = New System.Windows.Forms.Button()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gapsize, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.NumericUpDown1.BackColor = System.Drawing.SystemColors.Window
        Me.NumericUpDown1.DecimalPlaces = 4
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {625, 0, 0, 262144})
        Me.NumericUpDown1.Location = New System.Drawing.Point(325, 15)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 3
        '
        'Count
        '
        Me.Count.Location = New System.Drawing.Point(12, 159)
        Me.Count.Name = "Count"
        Me.Count.Size = New System.Drawing.Size(75, 23)
        Me.Count.TabIndex = 4
        Me.Count.Text = "Count"
        Me.Count.UseVisualStyleBackColor = True
        '
        'Edit_Start
        '
        Me.Edit_Start.Location = New System.Drawing.Point(12, 188)
        Me.Edit_Start.Name = "Edit_Start"
        Me.Edit_Start.Size = New System.Drawing.Size(75, 23)
        Me.Edit_Start.TabIndex = 5
        Me.Edit_Start.Text = "Edit Start"
        Me.Edit_Start.UseVisualStyleBackColor = True
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
        Me.Test.Location = New System.Drawing.Point(12, 485)
        Me.Test.Name = "Test"
        Me.Test.Size = New System.Drawing.Size(78, 32)
        Me.Test.TabIndex = 10
        Me.Test.Text = "test"
        Me.Test.UseVisualStyleBackColor = True
        '
        'Circle
        '
        Me.Circle.Location = New System.Drawing.Point(12, 217)
        Me.Circle.Name = "Circle"
        Me.Circle.Size = New System.Drawing.Size(75, 23)
        Me.Circle.TabIndex = 11
        Me.Circle.Text = "Circle"
        Me.Circle.UseVisualStyleBackColor = True
        '
        'Circle_move_to
        '
        Me.Circle_move_to.Location = New System.Drawing.Point(12, 41)
        Me.Circle_move_to.Name = "Circle_move_to"
        Me.Circle_move_to.Size = New System.Drawing.Size(102, 23)
        Me.Circle_move_to.TabIndex = 12
        Me.Circle_move_to.Text = "Circle move to"
        Me.Circle_move_to.UseVisualStyleBackColor = True
        '
        'Circle_move
        '
        Me.Circle_move.Location = New System.Drawing.Point(120, 41)
        Me.Circle_move.Name = "Circle_move"
        Me.Circle_move.Size = New System.Drawing.Size(75, 23)
        Me.Circle_move.TabIndex = 13
        Me.Circle_move.Text = "Circle move"
        Me.Circle_move.UseVisualStyleBackColor = True
        '
        'Gapat
        '
        Me.Gapat.Location = New System.Drawing.Point(451, 26)
        Me.Gapat.Name = "Gapat"
        Me.Gapat.Size = New System.Drawing.Size(75, 23)
        Me.Gapat.TabIndex = 14
        Me.Gapat.Text = "Gap at"
        Me.Gapat.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(280, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "bit size"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(271, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Gap size"
        '
        'Gapsize
        '
        Me.Gapsize.DecimalPlaces = 4
        Me.Gapsize.Increment = New Decimal(New Integer() {1, 0, 0, 262144})
        Me.Gapsize.Location = New System.Drawing.Point(325, 44)
        Me.Gapsize.Name = "Gapsize"
        Me.Gapsize.Size = New System.Drawing.Size(120, 20)
        Me.Gapsize.TabIndex = 17
        '
        'selection
        '
        Me.selection.Location = New System.Drawing.Point(12, 246)
        Me.selection.Name = "selection"
        Me.selection.Size = New System.Drawing.Size(75, 23)
        Me.selection.TabIndex = 18
        Me.selection.Text = "Select"
        Me.selection.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 554)
        Me.Controls.Add(Me.selection)
        Me.Controls.Add(Me.Gapsize)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Gapat)
        Me.Controls.Add(Me.Circle_move)
        Me.Controls.Add(Me.Circle_move_to)
        Me.Controls.Add(Me.Circle)
        Me.Controls.Add(Me.Test)
        Me.Controls.Add(Me.Label1)
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
        CType(Me.Gapsize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Move_to As Button
    Friend WithEvents Move_x As Button
    Friend WithEvents Move_y As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Count As Button
    Friend WithEvents Edit_Start As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Test As Button
    Friend WithEvents Circle As Button
    Friend WithEvents Circle_move_to As Button
    Friend WithEvents Circle_move As Button
    Friend WithEvents Gapat As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Gapsize As NumericUpDown
    Friend WithEvents selection As Button
End Class
