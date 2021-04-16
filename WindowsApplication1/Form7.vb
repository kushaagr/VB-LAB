Imports System.IO

Public Class Form7

    Dim IsEdited As Boolean = False

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim File As StreamReader
        If (OpenFileDialog1.ShowDialog() =
            Windows.Forms.DialogResult.OK) Then
            'RichTextBox1.LoadFile(
            '    OpenFileDialog1.FileName
            '    )
            File = My.Computer.FileSystem.OpenTextFileReader(
                OpenFileDialog1.FileName)
            RichTextBox1.Text = File.ReadToEnd()

            IsEdited = False
            ModifyTitle()
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        If (IsEdited = True) Then
            MessageBox.Show(
                "Do you want to save this file?",
                "MyNotepad",
                MessageBoxButtons.OKCancel)
        End If
        RichTextBox1.Text = ""
        IsEdited = False
        ModifyTitle()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim File As StreamWriter
        If (SaveFileDialog1.ShowDialog =
            Windows.Forms.DialogResult.OK) Then
            'RichTextBox1.SaveFile(
            '    SaveFileDialog1.FileName)
            File = My.Computer.FileSystem.OpenTextFileWriter(
                SaveFileDialog1.FileName, False)
            File.Write(RichTextBox1.Text)
            File.Close()
            IsEdited = False
            ModifyTitle()
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        IsEdited = True
        ModifyTitle()
    End Sub


    'Prepends an asterisk to the Form name, if a 
    ' file has unsaved changes     
    Sub ModifyTitle()
        Static Dim formName = Me.Text
        If (IsEdited) Then
            Me.Text = $"*{formName}"
            'Me.Text = "*" + formName
        Else
            Me.Text = formName
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        'If (ColorDialog1.ShowDialog() =
        '    DialogResult.OK) Then
        '    RichTextBox1.ForeColor = ColorDialog1.Color
        'End If
        If (RichTextBox1.SelectedText = "") Then
            ChangeColor(RichTextBox1.ForeColor)
        Else
            ChangeColor(RichTextBox1.SelectionColor)
        End If

    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        If (FontDialog1.ShowDialog() =
           DialogResult.OK) Then
            If (RichTextBox1.SelectedText = "") Then
                RichTextBox1.Font = FontDialog1.Font
            Else
                RichTextBox1.SelectionFont = FontDialog1.Font
            End If
        End If
    End Sub

    Private Sub BackgroundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundToolStripMenuItem.Click
        'If (ColorDialog1.ShowDialog() =
        '    DialogResult.OK) Then
        '    RichTextBox1.BackColor = ColorDialog1.Color
        'End If
        If (RichTextBox1.SelectedText = "") Then
            ChangeColor(RichTextBox1.BackColor)
        Else
            ChangeColor(RichTextBox1.SelectionBackColor)
        End If

    End Sub

    Sub ChangeColor(ByRef propertyName)
        If (ColorDialog1.ShowDialog() =
            DialogResult.OK) Then
            propertyName = ColorDialog1.Color
        End If
    End Sub

    'Dim formname As String
    'Private Sub form7_load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    formname = Me.Text
    'End Sub
End Class