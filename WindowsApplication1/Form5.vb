' Single quote is used to comment lines.

Public Class Form5

    'Copy/Add item from Listbox1 to ListBox2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Previous code (to copy one item at a time):
        '   ListBox2.Items.Add(ListBox1.SelectedItems)
        '   ListBox2.Items.AddRange(ListBox1.SelectedItems)

        'We use a loop to assign each element from
        ' list named "SelectedItems" (that belong to ListBox1)
        ' to a variable named 'item'
        '
        For Each item In ListBox1.SelectedItems
            ListBox2.Items.Add(item)
        Next

        'In other words the 'For each' loop is shorthand for writing:
        '  For (int i = 0; item < SelectedItems.count; i++) {
        '    item = SelectedItem[i]
        '
        '    ... code ...
        '  }

    End Sub

    'Copy/Add item from Listbox1 to ListBox1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each item In ListBox2.SelectedItems
            ListBox1.Items.Add(item)
        Next

    End Sub



    'Move item from Listbox1 to Listbox2
    'To move items,
    ' we first copy from listbox1 to listbox2 and
    ' then remove/delete from listbox1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Previous code (to move one item at a time):
        '   ListBox2.Items.Add(ListBox1.SelectedItem)
        '   ListBox1.Items.Remove(ListBox1.SelectedItem)

        'Code to move multiple items once
        'We declare a new list (array)
        Dim lst As New List(Of Object)

        'We cannot delete an element from the list "SelectedItems" while
        ' we are using it in a for-each-loop, thus
        ' we need to delete all the selected elements after 
        ' we have finished the loop.
        'So for this we save all the selected elements in a new list named "lst"
        For Each item In ListBox1.SelectedItems
            ListBox2.Items.Add(item)
            lst.Add(item)
        Next

        'Here we remove elements from listbox1 after adding 
        ' selected elements to listbox2 and coping them in list lst.
        For Each item In lst
            ListBox1.Items.Remove(item)
        Next
    End Sub

    'Move item from Listbox2 to Listbox1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Previous code (to move one item at a time):
        '   ListBox1.Items.Add(ListBox2.SelectedItem)
        '   ListBox2.Items.Remove(ListBox2.SelectedItem)

        'Code to move multiple items once
        Dim lst As New List(Of Object)
        For Each item In ListBox2.SelectedItems
            ListBox1.Items.Add(item)
            lst.Add(item)
        Next

        For Each item In lst
            ListBox2.Items.Remove(item)
        Next

    End Sub



    'Copy all items from Listbox to another Listbox
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ListBox2.Items.AddRange(ListBox1.Items)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ListBox1.Items.AddRange(ListBox2.Items)
    End Sub


    'Move all items from Listbox to another Listbox
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ListBox2.Items.AddRange(ListBox1.Items)
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.AddRange(ListBox2.Items)
        ListBox2.Items.Clear()
    End Sub



    'Add text from user to either or both listbox(es), using TextBox
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ' .trim is used to remove surrounding spaces from the text inputed in textbox1
        If (Not TextBox1.Text.Trim = String.Empty) Then
            If (ComboBox1.Text = "LIST ONE") Then
                ListBox1.Items.Add(TextBox1.Text.Trim)
            End If
            If (ComboBox1.Text = "LIST TWO") Then
                ListBox2.Items.Add(TextBox1.Text.Trim)
            End If
            If (ComboBox1.Text = "BOTH") Then
                ListBox1.Items.Add(TextBox1.Text.Trim)
                ListBox2.Items.Add(TextBox1.Text.Trim)
            End If
        End If
    End Sub



    'LinkLabel (Colored and underlined label) is used to remove item(s) from listbox, but
    ' before deleting an item, the program asks/prompts user to confirm a delete action.
    ' 
    'MessageBox.show() function returns a value, we store this value in "Result" variable,
    ' then check if the value is "Yes" or "No",
    ' only when the value is "Yes" we delete the item
    ' 
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim Result As DialogResult
        Result = MessageBox.Show("Confirm Delete?", "Any text can go here", MessageBoxButtons.YesNo)
        If (Result = DialogResult.Yes) Then
            'Remove one item - selected item from listbox1
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Dim Result As DialogResult
        Result = MessageBox.Show("Confirm delete?", "from listbox2", MessageBoxButtons.YesNo)
        If (Result = DialogResult.Yes) Then
            'Remove one item - selected item from listbox2
            ListBox2.Items.Remove(ListBox2.SelectedItem)
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim Result As DialogResult
        Result = MessageBox.Show("Confirm delete?", "from listbox2", MessageBoxButtons.YesNo)
        If (Result = DialogResult.Yes) Then
            'Remove all items from listbox1
            ListBox1.Items.Clear()
        End If

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim Result As DialogResult
        Result = MessageBox.Show("Confirm delete?", "from listbox2", MessageBoxButtons.YesNo)
        If (Result = DialogResult.Yes) Then
            'Remove all items from listbox1
            ListBox2.Items.Clear()
        End If

    End Sub


    'Clear selected items in ListBox1
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ListBox1.ClearSelected()
    End Sub

    'Clear selected items in ListBox2
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ListBox2.ClearSelected()
    End Sub
End Class