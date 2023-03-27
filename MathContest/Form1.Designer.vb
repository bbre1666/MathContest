<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MathContest
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
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.SecondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.AnswerTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DivideCheckBox = New System.Windows.Forms.CheckBox()
        Me.MultiplyCheckBox = New System.Windows.Forms.CheckBox()
        Me.SubtractCheckBox = New System.Windows.Forms.CheckBox()
        Me.ADDCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SummeryButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.AgeNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.GradeNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.AgeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(15, 55)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(259, 27)
        Me.NameTextBox.TabIndex = 0
        '
        'FirstNumberTextBox
        '
        Me.FirstNumberTextBox.Location = New System.Drawing.Point(16, 62)
        Me.FirstNumberTextBox.Name = "FirstNumberTextBox"
        Me.FirstNumberTextBox.Size = New System.Drawing.Size(259, 27)
        Me.FirstNumberTextBox.TabIndex = 3
        '
        'SecondNumberTextBox
        '
        Me.SecondNumberTextBox.Location = New System.Drawing.Point(16, 131)
        Me.SecondNumberTextBox.Name = "SecondNumberTextBox"
        Me.SecondNumberTextBox.Size = New System.Drawing.Size(259, 27)
        Me.SecondNumberTextBox.TabIndex = 4
        '
        'AnswerTextBox
        '
        Me.AnswerTextBox.Location = New System.Drawing.Point(16, 194)
        Me.AnswerTextBox.Name = "AnswerTextBox"
        Me.AnswerTextBox.Size = New System.Drawing.Size(259, 27)
        Me.AnswerTextBox.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.AnswerTextBox)
        Me.GroupBox1.Controls.Add(Me.SecondNumberTextBox)
        Me.GroupBox1.Controls.Add(Me.FirstNumberTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 261)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Current Math Problem"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Student Answer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "2nd Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "1st Number"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GradeNumericUpDown)
        Me.GroupBox2.Controls.Add(Me.AgeNumericUpDown)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.NameTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(506, 129)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Student information"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(409, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Grade"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(312, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Age"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Name"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DivideCheckBox)
        Me.GroupBox3.Controls.Add(Me.MultiplyCheckBox)
        Me.GroupBox3.Controls.Add(Me.SubtractCheckBox)
        Me.GroupBox3.Controls.Add(Me.ADDCheckBox)
        Me.GroupBox3.Location = New System.Drawing.Point(344, 147)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(180, 259)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Math Problem Type"
        '
        'DivideCheckBox
        '
        Me.DivideCheckBox.AutoSize = True
        Me.DivideCheckBox.Location = New System.Drawing.Point(23, 218)
        Me.DivideCheckBox.Name = "DivideCheckBox"
        Me.DivideCheckBox.Size = New System.Drawing.Size(74, 24)
        Me.DivideCheckBox.TabIndex = 9
        Me.DivideCheckBox.Text = "Divide"
        Me.DivideCheckBox.UseVisualStyleBackColor = True
        '
        'MultiplyCheckBox
        '
        Me.MultiplyCheckBox.AutoSize = True
        Me.MultiplyCheckBox.Location = New System.Drawing.Point(23, 158)
        Me.MultiplyCheckBox.Name = "MultiplyCheckBox"
        Me.MultiplyCheckBox.Size = New System.Drawing.Size(85, 24)
        Me.MultiplyCheckBox.TabIndex = 8
        Me.MultiplyCheckBox.Text = "Multiply"
        Me.MultiplyCheckBox.UseVisualStyleBackColor = True
        '
        'SubtractCheckBox
        '
        Me.SubtractCheckBox.AutoSize = True
        Me.SubtractCheckBox.Location = New System.Drawing.Point(22, 104)
        Me.SubtractCheckBox.Name = "SubtractCheckBox"
        Me.SubtractCheckBox.Size = New System.Drawing.Size(86, 24)
        Me.SubtractCheckBox.TabIndex = 7
        Me.SubtractCheckBox.Text = "Subtract"
        Me.SubtractCheckBox.UseVisualStyleBackColor = True
        '
        'ADDCheckBox
        '
        Me.ADDCheckBox.AutoSize = True
        Me.ADDCheckBox.Location = New System.Drawing.Point(23, 39)
        Me.ADDCheckBox.Name = "ADDCheckBox"
        Me.ADDCheckBox.Size = New System.Drawing.Size(63, 24)
        Me.ADDCheckBox.TabIndex = 6
        Me.ADDCheckBox.Text = "ADD"
        Me.ADDCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ExitButton)
        Me.GroupBox4.Controls.Add(Me.SummeryButton)
        Me.GroupBox4.Controls.Add(Me.ClearButton)
        Me.GroupBox4.Controls.Add(Me.SubmitButton)
        Me.GroupBox4.Location = New System.Drawing.Point(530, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(257, 395)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(36, 281)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(193, 63)
        Me.ExitButton.TabIndex = 13
        Me.ExitButton.Text = "  Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SummeryButton
        '
        Me.SummeryButton.Location = New System.Drawing.Point(36, 204)
        Me.SummeryButton.Name = "SummeryButton"
        Me.SummeryButton.Size = New System.Drawing.Size(193, 63)
        Me.SummeryButton.TabIndex = 12
        Me.SummeryButton.Text = "Summery"
        Me.SummeryButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(36, 123)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(193, 63)
        Me.ClearButton.TabIndex = 11
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(36, 43)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(193, 63)
        Me.SubmitButton.TabIndex = 10
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'AgeNumericUpDown
        '
        Me.AgeNumericUpDown.Location = New System.Drawing.Point(312, 55)
        Me.AgeNumericUpDown.Name = "AgeNumericUpDown"
        Me.AgeNumericUpDown.Size = New System.Drawing.Size(53, 27)
        Me.AgeNumericUpDown.TabIndex = 9
        '
        'GradeNumericUpDown
        '
        Me.GradeNumericUpDown.Location = New System.Drawing.Point(409, 55)
        Me.GradeNumericUpDown.Name = "GradeNumericUpDown"
        Me.GradeNumericUpDown.Size = New System.Drawing.Size(53, 27)
        Me.GradeNumericUpDown.TabIndex = 10
        '
        'MathContest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MathContest"
        Me.Text = "Math Contest "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.AgeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents AnswerTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DivideCheckBox As CheckBox
    Friend WithEvents MultiplyCheckBox As CheckBox
    Friend WithEvents SubtractCheckBox As CheckBox
    Friend WithEvents ADDCheckBox As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents SummeryButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GradeNumericUpDown As NumericUpDown
    Friend WithEvents AgeNumericUpDown As NumericUpDown
End Class
