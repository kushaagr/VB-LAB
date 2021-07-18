Public Class Form01
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "MDI VB showcase"
    End Sub

    Private Sub PrototypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrototypeToolStripMenuItem.Click
        'Dim Cp As New Form1
        'Cp.MdiParent = Me
        'Cp.Show()
        AddChild(Form1)
    End Sub

    Private Sub SimpleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpleToolStripMenuItem.Click
        'Dim F As New Form2
        'F.MdiParent = Me
        'F.Show()
        AddChild(Form2)
    End Sub

    Private Sub ButtonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ButtonToolStripMenuItem.Click
        'Dim F As New Form3
        'F.MdiParent = Me
        'F.Show()
        AddChild(Form3)
    End Sub

    Private Sub CalculatorprototypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatorprototypeToolStripMenuItem.Click

    End Sub

    Private Sub DataGridViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataGridViewToolStripMenuItem.Click
        AddChild(Form9a)
    End Sub

    Private Sub AddChild(form As Form)
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotepadToolStripMenuItem.Click
        AddChild(Form7)
    End Sub

    Private Sub Form1ToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles Form5ToolStripMenuItem.Click
        AddChild(Form5)
    End Sub

    Private Sub Form6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form6ToolStripMenuItem.Click
        AddChild(Form6)
    End Sub

    Private Sub Form8ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form8ToolStripMenuItem.Click
        AddChild(Form8)
    End Sub

    Private Sub Form9ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form9ToolStripMenuItem.Click
        AddChild(Form9)
    End Sub
End Class