Public Class Form1
    Dim accumulator As Double = 0F
    Private Sub Process_click(sender As System.Object, e As EventArgs) _
        Handles add.Click, subtract.Click, multiply.Click, divide.Click
        If (Not input.Text = "" And IsNumeric(input.Text)) Then
            Form4.Label1.Text &= $"{accumulator} {sender.name} {input.Text + vbCrLf}"
            If (sender.name = "add") Then
                accumulator += input.Text
            ElseIf (sender.name = "subtract") Then
                accumulator -= input.Text
            ElseIf (sender.name = "multiply") Then
                accumulator *= input.Text
            ElseIf (sender.name = "divide") Then
                accumulator /= input.Text
            End If
            output.Text = accumulator

        End If
    End Sub

    Private Sub output_Click(sender As Object, e As EventArgs) Handles output.Click
        accumulator = 0
        output.Text = accumulator
    End Sub
End Class
