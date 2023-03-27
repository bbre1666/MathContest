'Baden Brenner  
'RCET 0265
'Spring 23
'Math Contest
'
Option Strict On
Option Explicit On

Public Class MathContest

    Dim CorrectAnser As Integer = 0
    Dim WrongAnser As Integer = 0

    Sub Boot() Handles Me.Activated
        'sets max and min for numeric up downs
        AgeNumericUpDown.Minimum = 4
        GradeNumericUpDown.Minimum = 1
        AgeNumericUpDown.Maximum = 11
        GradeNumericUpDown.Maximum = 7
        'add radio button will always be checked on startup
        ADDCheckBox.Checked = True
        'restricts the user from acsessing these text boxes
        FirstNumberTextBox.Enabled = False
        SecondNumberTextBox.Enabled = False

    End Sub
    Function Validation() As Boolean
        Dim Status As Boolean = False
        'This looks to see if there is any empty fields and promts the user
        If NameTextBox.Text = "" Then
            Status = False
        Else
            Status = True
        End If
        Return Status
    End Function

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim FirstNumber As Integer
        Dim SecondNumber As Integer
        Dim StudentAnswer As Integer
        FirstNumber = CInt(FirstNumberTextBox.Text)
        SecondNumber = CInt(SecondNumberTextBox.Text)
        StudentAnswer = CInt(AnswerTextBox.Text)

        'all below check if the answer submitted is actually the correct answer
        'based on the selected operation
        If ADDCheckBox.Checked = True Then
            If StudentAnswer = (FirstNumber + SecondNumber) Then
                MsgBox($"Correct! the answer was {FirstNumber + SecondNumber}")
                CorrectAnser = (CorrectAnser + 1)
                SubmitButton.Enabled = True
            ElseIf StudentAnswer <> (FirstNumber + SecondNumber) Then
                MsgBox($"Sorry, But the answer was {FirstNumber + SecondNumber}")
                WrongAnser = (WrongAnser + 1)
                SubmitButton.Enabled = True
            Else
                MsgBox("I think you broke the program")
            End If

        End If
        If SubtractCheckBox.Checked = True Then
            If StudentAnswer = (FirstNumber - SecondNumber) Then
                MsgBox($"Correct! the answer was {FirstNumber - SecondNumber}")
                CorrectAnser = (CorrectAnser + 1)
                SubmitButton.Enabled = True
            ElseIf StudentAnswer <> (FirstNumber - SecondNumber) Then
                MsgBox($"Sorry, But the answer was {FirstNumber - SecondNumber}")
                WrongAnser = (WrongAnser + 1)
                SubmitButton.Enabled = True
            Else
                MsgBox("I think you broke the program")
            End If
        End If
        If MultiplyCheckBox.Checked = True Then
            If StudentAnswer = (FirstNumber * SecondNumber) Then
                MsgBox($"Correct! the answer was {FirstNumber * SecondNumber}")
                CorrectAnser = (CorrectAnser + 1)
                SubmitButton.Enabled = True
            ElseIf StudentAnswer <> (FirstNumber * SecondNumber) Then
                MsgBox($"Sorry, But the answer was {FirstNumber * SecondNumber}")
                WrongAnser = (WrongAnser + 1)
                SubmitButton.Enabled = True
            Else
                MsgBox("I think you broke the program")
            End If
        End If
        If DivideCheckBox.Checked = True Then
            If StudentAnswer = (FirstNumber / SecondNumber) Then
                MsgBox($"Correct! the answer was {FirstNumber / SecondNumber}")
                CorrectAnser = (CorrectAnser + 1)
                SubmitButton.Enabled = True
            ElseIf StudentAnswer <> (FirstNumber / SecondNumber) Then
                MsgBox($"Sorry, But the answer was {FirstNumber / SecondNumber}")
                WrongAnser = (WrongAnser + 1)
                SubmitButton.Enabled = True
            Else
                MsgBox("I think you broke the program")
            End If
        End If
    End Sub
    Private Sub PageClear()
        NameTextBox.Clear()
        FirstNumberTextBox.Clear()
        SecondNumberTextBox.Clear()
        AnswerTextBox.Clear()
        AgeNumericUpDown.Value = 4
        GradeNumericUpDown.Value = 1

    End Sub
    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummeryButton.Click
        'displays to the user the number of questions answered correct or incorrect
        MsgBox($"You got {CorrectAnser} correct and {WrongAnser} Wrong.")
    End Sub
    Private Sub MathContest_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Validation() = False Then
            SubmitButton.Enabled = False
        Else
            SubmitButton.Enabled = True
        End If
    End Sub

    Private Sub NameTextBox_Leave(sender As Object, e As EventArgs) Handles NameTextBox.Leave
        If Validation() = False Then
            SubmitButton.Enabled = False
        Else
            SubmitButton.Enabled = True
        End If
    End Sub
    Private Sub AnswerTextBox_Leave(sender As Object, e As EventArgs)
        If Validation() = False Then
            SubmitButton.Enabled = False
        Else
            SubmitButton.Enabled = True
        End If
    End Sub
    Private Sub AddRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles ADDCheckBox.CheckedChanged
        FirstNumberTextBox.Text = CStr(CInt(Int((20 * Rnd() * +1))))
        SecondNumberTextBox.Text = CStr(CInt(Int((20 * Rnd() * +1))))
    End Sub
    Private Sub SubtractRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SubtractCheckBox.CheckedChanged
        FirstNumberTextBox.Text = CStr(CInt(Int((20 * Rnd() * +1))))
        SecondNumberTextBox.Text = CStr(CInt(Int((12 * Rnd() * +1))))
    End Sub
    Private Sub MultiplyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MultiplyCheckBox.CheckedChanged
        FirstNumberTextBox.Text = CStr(CInt(Int((20 * Rnd() * +1))))
        SecondNumberTextBox.Text = CStr(CInt(Int((20 * Rnd() * +1))))
    End Sub
    Private Sub DivideRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DivideCheckBox.CheckedChanged
        FirstNumberTextBox.Text = CStr(CInt(Int((20 * Rnd() * +1))))
        SecondNumberTextBox.Text = CStr(CInt(Int((12 * Rnd() * +1))))
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        PageClear()
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
