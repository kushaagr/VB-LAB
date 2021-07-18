Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Button1.Text = "Start") Then
            Timer1.Start()
            Button1.Text = "Pause"
        ElseIf (Button1.Text = "Pause") Then
            Timer1.Stop()
            Button1.Text = "Start"
            Button2.Visible = True
            Button2.Enabled = True
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.PerformStep()
        If (ProgressBar1.Value = ProgressBar1.Maximum) Then
            Timer1.Stop()
            MessageBox.Show("Process completed")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ProgressBar1.Value = ProgressBar1.Minimum
        Timer1.Start()
        REM Button2.Visible = False
        Button2.Enabled = False
        Button1.Text = "Pause"
    End Sub
End Class