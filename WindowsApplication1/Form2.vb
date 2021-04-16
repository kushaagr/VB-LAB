Public Class Form2
    Dim a, b, c As Integer
    Sub AddFunc()

        c = a + b
    End Sub

    Sub SubFunc()

        c = a - b
    End Sub

    Sub MulFunc()

        c = a * b
    End Sub

    Sub DivFunc()

        c = a / b
    End Sub


    Private Sub Button5_Click_1(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If (CheckInput(TextBox1) = True AndAlso
            CheckInput(TextBox2) = True) Then
            a = TextBox1.Text
            b = TextBox2.Text
            If (ComboBox1.Text = "ADD") Then
                AddFunc()
            ElseIf (ComboBox1.Text = "SUBTRACT") Then
                SubFunc()
            ElseIf (ComboBox1.Text = "MULTIPLY") Then
                MulFunc()
            ElseIf (ComboBox1.Text = "DIVIDE") Then
                DivFunc()
            End If
        Else
            MessageBox.Show("Please provide input in numbers.")
        End If

        Label1.Text = c
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Function CheckInput(T As TextBox) As Boolean
        If (T.Text = "") Then
            ErrorProvider1.SetError(T, $"Please enter input for {T.Name}")
            Return False
        Else
            ErrorProvider1.SetError(T, "")
            Return True
        End If

    End Function

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        'If (TextBox1.Text = "") Then
        '    ErrorProvider1.SetError(TextBox1, "Please enter value for A")
        'Else
        '    ErrorProvider1.SetError(TextBox1, String.Empty)
        'End If
        CheckInput(TextBox1)
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        'If (TextBox2.Text = "") Then
        '    ErrorProvider1.SetError(TextBox2, "Please enter value for B")
        'Else
        '    ErrorProvider1.SetError(TextBox2, String.Empty)
        'End If
        CheckInput(TextBox2)
    End Sub
End Class