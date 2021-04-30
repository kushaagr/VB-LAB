Imports System.IO

Public Class Form7

    Dim IsEdited As Boolean = False
    Dim Wrap As Boolean = False

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

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        Dim Find As New Form7_1vb
        Find.Show()
    End Sub

    Private Sub WordWrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.Click
        'RichTextBox1.RightMargin = Me.Width - 20
        WrapText(RichTextBox1.Text, 30)

        'Dim oldMargin = RichTextBox1.Margin.Right
        'Wrap = Not Wrap
        'If (Wrap) Then
        '    RichTextBox1.RightMargin = Me.Width - 40
        '    RichTextBox1.SelectionStart = 0
        '    WordWrapToolStripMenuItem.Checked = True
        'Else
        '    RichTextBox1.RightMargin = oldMargin
        '    WordWrapToolStripMenuItem.Checked = False
        'End If

        'RichTextBox1.WordWrap = Not RichTextBox1.WordWrap
        'RichTextBox1.WordWrap = True
        'WordWrapToolStripMenuItem.Checked = Not WordWrapToolStripMenuItem.Checked
        'RichTextBox1.Text = RichTextBox1.WordWrap.GetType.ToString

    End Sub

    Private Sub Form7_ResizeEnd(sender As Object, e As EventArgs) Handles Me.Resize
        'Dim oldMargin = RichTextBox1.Margin.Right
        'If (Wrap) Then
        '    RichTextBox1.RightMargin = Me.Width - 40
        'Else
        '    RichTextBox1.RightMargin = oldMargin
        'End If

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles Me.Load
        'For Each line In RichTextBox1.Lines
        '    Dim Len = line.Length
        '    If (MaxLen < Len) Then
        '        MaxLen = Len
        '    End If
        'Next
        'RichTextBox1.RightMargin = MaxLen
        Dim a = WrapText(RichTextBox1.Text, 60)
        RichTextBox1.Text = ""
        For Each word As String In a
            RichTextBox1.Text &= word + Environment.NewLine
        Next

    End Sub

    Dim MaxLen As Integer = 0
    Private Sub Form7_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
        'If (Wrap = False) Then
        '    For Each line In RichTextBox1.Lines
        '        Dim Len = line.Length
        '        If (MaxLen < Len) Then
        '            MaxLen = Len
        '        End If
        '    Next
        '    RichTextBox1.RightMargin = MaxLen
        'End If
        'MessageBox.Show(MaxLen)

    End Sub

    'Source:
    'https://www.sourcecodester.com/visual-basic-net/9499/word-wrap-function-vbnet.html
    Public Function WrapText(ByVal Text As String, ByVal LineLength As Integer) As List(Of String)

        Dim ReturnValue As New List(Of String)
        ' Remove leading and trailing spaces
        Text = Trim(Text)


        Dim Words As String() = Text.Split(" ")

        If Words.Length = 1 And Words(0).Length > LineLength Then

            ' Text is just one big word that is longer than one line
            ' Split it mercilessly
            Dim lines As Integer = (Int(Text.Length / LineLength) + 1)
            Text = Text.PadRight(lines * LineLength)
            For i = 0 To lines - 1
                Dim SliceStart As Integer = i * LineLength
                ReturnValue.Add(Text.Substring(SliceStart,
                LineLength))
            Next
        Else
            Dim CurrentLine As New System.Text.StringBuilder
            For Each Word As String In Words
                ' will this word fit on the current line?
                If CurrentLine.Length + Word.Length <
                LineLength Then
                    CurrentLine.Append(Word & " ")
                Else
                    ' is the word too long for one line
                    If Word.Length > LineLength Then
                        ' hack off the first piece, fill out the current line and start a new line
                        Dim Slice As String =
                        Word.Substring(0, LineLength - CurrentLine.Length)
                        CurrentLine.Append(Slice)
                        ReturnValue.Add(CurrentLine.ToString)

                        CurrentLine = New System.Text.StringBuilder()

                        ' Remove the first slice from the word
                        Word = Word.Substring(Slice.Length,
                        Word.Length - Slice.Length)

                        ' How many more lines do we need for this word?
                        Dim RemainingSlices As Integer =
                        Int(Word.Length / LineLength) + 1
                        For LineNumber = 1 To RemainingSlices

                            If LineNumber = RemainingSlices Then

                                'this is the last slice
                                CurrentLine.Append(Word & " ")
                            Else
                                ' this is not the last slice
                                ' hack off a slice that is one line long, add that slice
                                ' to the output as a line and start a new line
                                Slice = Word.Substring(0,
                                LineLength)
                                CurrentLine.Append(Slice)

                                ReturnValue.Add(CurrentLine.ToString)
                                CurrentLine = New System.Text.StringBuilder()

                                ' Remove the slice from the 

                                Word = Word.Substring(Slice.Length, Word.Length - Slice.Length)
                            End If
                        Next
                    Else
                        ' finish the current line and start a new one with the wrapped word
                        ReturnValue.Add(CurrentLine.ToString)
                        CurrentLine = New System.Text.StringBuilder(Word & " ")
                    End If
                End If
            Next

            ' Write the last line to the output
            If CurrentLine.Length > 0 Then
                ReturnValue.Add(CurrentLine.ToString)
            End If
        End If
        Return ReturnValue
    End Function
    'Dim formname As String
    'Private Sub form7_load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    formname = Me.Text
    'End Sub
End Class