Public Class Form3
    Dim a, b, c As Double
    Dim op = " "
    Dim f4 As Form4
    ' Dim Form4 As Form4
    Dim flabel = Form4.Label1
    Public log As String = ""
    Dim AnsOnDisplay As Boolean = False
    Dim DotInserted As Boolean = False

    Private Sub Clear_Values()
        display.Text = ""
        a = 0
        b = 0
        c = 0
        op = " "
        DotInserted = False
        AnsOnDisplay = False
    End Sub

    Private Sub Update_label()
        Label3.Text = a
        Label5.Text = b
        Label7.Text = Process_Calculation(a, b)
        'If (Not op = "") Then
        Label6.Text = $"c (a {op} b)"
        'End If
    End Sub

    Function Process_Calculation(a, b)
        Dim answer As Double
        If (op = "+") Then
            answer = a + b
        ElseIf (op = "-") Then
            answer = a - b
        ElseIf (op = "*") Then
            answer = a * b
        ElseIf (op = "/") Then
            answer = a / b
        Else
            answer = a + b
            'In case op = " "
        End If
        Process_Calculation = answer
    End Function

    Private Sub Display_Click(sender As System.Object, e As System.EventArgs) _
    Handles display.Click
        Clear_Values()
        Update_label()
        log &= $"Clear{vbCrLf}"
        AnsOnDisplay = False
        'If (Form4.Visible) Then
        '    flabel.text = log
        'End If
        f4.Label1.Text = log


    End Sub

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) _
    Handles MyBase.Load
        Me.Text = "Calculator"
        Clear_Values()
        Update_label()
        'Form4.Show()
        f4 = New Form4()
        f4.Show()
        'Form1.Show()
        'Form2.Show()
    End Sub

    Private Sub Button_click(sender As System.Object, e As System.EventArgs) _
    Handles one.Click, two.Click, three.Click, four.Click, five.Click,
    six.Click, seven.Click, eight.Click, nine.Click, zero.Click
        If ((Not sender.Text = ".")) Then
            display.Text += sender.Text
        ElseIf (sender.Text = "." AndAlso Not DotInserted) Then
            display.Text += sender.Text
            DotInserted = True
        End If
        'Form4.Label1.Text &= $"Pressed {sender.text + vbCrLf}"
        log &= $"Pressed {sender.text + vbCrLf}"
        'If (Form4.Visible) Then
        '    flabel.text = log
        If (f4.Visible) Then
            f4.Label1.Text = log
        Else
            f4 = New Form4
        f4.Label1.Text = log
        End If
    End Sub

    'Private Sub op_Click(sender As Object, e As EventArgs) _
    'Handles plus.Click, minus.Click, multiply.Click, divide.Click
    '    If ((Not display.Text = String.Empty) AndAlso
    '    IsNumeric(display.Text)) Then
    '        a = display.Text
    '        display.Text = ""
    '        op = sender.text
    '        update_label()
    '        log &= $"{sender.name} operation{vbCrLf}"
    '        If (Form4.Visible) Then
    '            flabel.text = log
    '        End If
    '    End If
    'End Sub

    Private Sub Op_Click(sender As Object, e As EventArgs) _
    Handles plus.Click, minus.Click, multiply.Click, divide.Click
        If ((Not display.Text = String.Empty) AndAlso
        IsNumeric(display.Text)) Then
            If (Not AnsOnDisplay) Then
                b = display.Text
                a = Process_Calculation(a, b)
                b = 0
            Else
                a = display.Text
            End If

            display.Text = ""
            AnsOnDisplay = False
        End If

        op = sender.Text
        Update_label()
        log &= $"{sender.name} operation{vbCrLf}"
        'If (Form4.Visible) Then
        '    flabel.text = log
        'End If
        f4.Label1.Text = log
    End Sub

    Private Sub Answer_Click(sender As System.Object, e As System.EventArgs) _
    Handles answer.Click
        If ((Not display.Text = String.Empty) AndAlso
            IsNumeric(display.Text)) Then
            If (Not AnsOnDisplay) Then
                b = display.Text
                'log &= $"AnsNotOnDisplay{vbCrLf}"
            End If

            log &= $"Equals (Processing {a} {op} {b}){vbCrLf}"
            a = Process_Calculation(a, b)
        End If
        display.Text = a
        AnsOnDisplay = True
        log &= $"AnsOnDisplay{vbTab + vbFormFeed}{vbNewLine}"
        'b = 0
        'op = " "
        Update_label()
        'If (Form4.Visible) Then
        '    flabel.text = log
        'End If
        f4.Label1.Text = log
    End Sub

    'Private Sub answer_Click(sender As System.Object, e As System.EventArgs) _
    'Handles answer.Click
    '    If (Not display.Text = String.Empty) Then
    '        b = display.Text
    '        If (op = "+") Then
    '            c = a + b
    '        ElseIf (op = "-") Then
    '            c = a - b
    '        ElseIf (op = "*") Then
    '            c = a * b
    '        ElseIf (op = "/") Then
    '            c = a / b
    '        End If
    '    End If

    '    display.Text = c
    '    update_label()
    '    log &= $"Equals (Processing {a} {op} {b}){vbCrLf}"
    '    If (Form4.Visible) Then
    '        flabel.text = log
    '    End If
    'End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) _
        Handles Label2.Click
        Form1.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) _
        Handles Label4.Click
        Form2.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) _
        Handles Label6.Click
        f4.Show()
        f4.Label1.Text = log
        'f = New Form4
        'f.Show()
        'flabel = f.Label1
        'Console.WriteLine(log)
    End Sub

    'Private Sub minus_Click(sender As Object, e As EventArgs) _
    'Handles minus.Click
    '    If (Not display.Text = String.Empty) Then
    '        a = display.Text
    '        display.Text = ""
    '        op = "-"
    '        update_label()
    '    End If

    'End Sub

    'Private Sub multi_Click(sender As Object, e As EventArgs) _
    'Handles multiply.Click
    '    If (Not display.Text = String.Empty) Then
    '        a = display.Text
    '        display.Text = ""
    '        op = "*"
    '        update_label()
    '    End If

    'End Sub

    'Private Sub divi_Click(sender As Object, e As EventArgs) _
    'Handles divide.Click
    '    If (Not display.Text = String.Empty) Then
    '        a = display.Text
    '        display.Text = ""
    '        op = "/"
    '        update_label()
    '    End If

    'End Sub

    'Private Sub plus_Click(sender As System.Object, e As System.EventArgs) _
    'Handles plus.Click
    '    If (Not display.Text = String.Empty) Then
    '        a += display.Text
    '        display.Text = String.Empty
    '        op = "+"
    '        update_label()
    '    End If

    'End Sub

End Class