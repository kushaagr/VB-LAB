Public Class Form3
    Dim a, b, c As Double
    Dim op As Char = " "

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) _
    Handles one.Click
        display.Text &= "1"
    End Sub

    Private Sub display_Click(sender As System.Object, e As System.EventArgs) _
    Handles display.Click
        display.Text = ""
        a = 0
        b = 0
        c = 0
        op = " "
        update_label()
    End Sub

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) _
    Handles MyBase.Load
        update_label()
        Form4.Show()

    End Sub

    Private Sub two_Click(sender As System.Object, e As System.EventArgs) _
    Handles two.Click
        display.Text &= "2"
    End Sub

    Private Sub three_Click(sender As System.Object, e As System.EventArgs) _
    Handles three.Click
        display.Text &= "3"
    End Sub

    Private Sub four_Click(sender As System.Object, e As System.EventArgs) _
    Handles four.Click
        display.Text &= "4"
    End Sub

    Private Sub five_Click(sender As System.Object, e As System.EventArgs) _
    Handles five.Click
        display.Text &= "5"
    End Sub

    Private Sub six_Click(sender As System.Object, e As System.EventArgs) _
    Handles six.Click
        display.Text &= "6"
    End Sub

    Private Sub seven_Click(sender As System.Object, e As System.EventArgs) _
    Handles seven.Click
        display.Text &= "7"
    End Sub

    Private Sub eight_Click(sender As System.Object, e As System.EventArgs) _
    Handles eight.Click
        display.Text &= "8"
    End Sub

    Private Sub nine_Click(sender As System.Object, e As System.EventArgs) _
    Handles nine.Click
        display.Text &= "9"
    End Sub

    Private Sub zero_Click(sender As System.Object, e As System.EventArgs) _
    Handles zero.Click
        display.Text &= "0"
    End Sub

    Private Sub minus_Click(sender As Object, e As EventArgs) _
    Handles minus.Click
        If (Not display.Text = String.Empty) Then
            a = display.Text
            display.Text = ""
            op = "-"
            update_label()
        End If

    End Sub

    Private Sub multi_Click(sender As Object, e As EventArgs) _
    Handles multi.Click
        If (Not display.Text = String.Empty) Then
            a = display.Text
            display.Text = ""
            op = "*"
            update_label()
        End If

    End Sub

    Private Sub divi_Click(sender As Object, e As EventArgs) _
    Handles divi.Click
        If (Not display.Text = String.Empty) Then
            a = display.Text
            display.Text = ""
            op = "/"
            update_label()
        End If

    End Sub

    Private Sub plus_Click(sender As System.Object, e As System.EventArgs) _
    Handles plus.Click
        If (Not display.Text = String.Empty) Then
            a += display.Text
            display.Text = String.Empty
            op = "+"
            update_label()
        End If

    End Sub



    Private Sub answer_Click(sender As System.Object, e As System.EventArgs) _
    Handles answer.Click
        If (Not display.Text = String.Empty) Then
            b = display.Text
            If (op = "+") Then
                c = a + b
            ElseIf (op = "-") Then
                c = a - b
            ElseIf (op = "*") Then
                c = a * b
            ElseIf (op = "/") Then
                c = a / b
            End If
        End If

        display.Text = c
        update_label()
    End Sub

    Private Sub update_label()
        Label3.Text = a
        Label5.Text = b
        Label7.Text = c
        'If (Not op = "") Then
        Label6.Text = $"c (a {op} b)"
        'End If

    End Sub
End Class