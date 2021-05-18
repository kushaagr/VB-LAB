Public Class Form10
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "MDI VB showcase"
    End Sub

    Private Sub PrototypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrototypeToolStripMenuItem.Click
        Dim Cp As New Form1
        Cp.MdiParent = Me
        Cp.Show()
    End Sub

    Private Sub SimpleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpleToolStripMenuItem.Click
        Dim F As New Form2
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ButtonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ButtonToolStripMenuItem.Click
        Dim F As New Form3
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub CalculatorprototypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatorprototypeToolStripMenuItem.Click

    End Sub
End Class