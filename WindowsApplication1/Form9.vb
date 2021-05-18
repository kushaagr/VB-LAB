Imports System.Data.SqlClient

Public Class Form9

    'Dim DtDr As SqlDataReader
    Dim oConnection As New SqlConnection(
        "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database_one;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        )

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (oConnection.State = ConnectionState.Closed) Then
            oConnection.Open()
        End If
        Dim oCommand As New SqlCommand
        oCommand.Connection = oConnection
        oCommand.CommandText = "INSERT INTO Student_table values ('" _
            & TextBox1.Text & "'," & TextBox2.Text & ")"
        If (oCommand.ExecuteNonQuery()) Then
            MessageBox.Show("Data saved successfully")
            FillDt()
        Else
            MessageBox.Show("Data save fail.")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim Dr As DataRow()
        Dim value = ComboBox1.SelectedValue
        If Not ComboBox1.SelectedIndex = 0 Then
            Dr = Dt.Select($"id={value}")
            'MsgBox(Dt.Rows(value)(2))
            TextBox1.Text = Dt.Rows(value)(1)
            TextBox2.Text = Dt.Rows(value)(2)
        Else
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If

    End Sub

    Private Sub FillDt()
        Dim oCommand As New SqlCommand
        If (oConnection.State = ConnectionState.Closed) Then
            oConnection.Open()
        End If
        Dim Da As New SqlDataAdapter("SELECT * FROM Student_table",
            oConnection)
        'Dt.Reset()
        Dt = New DataTable()
        Da.Fill(Dt)
        Dim dummyRow = Dt.NewRow()
        dummyRow(0) = 0
        dummyRow(1) = "SELECT id"
        Dt.Rows.InsertAt(dummyRow, 0)
        ComboBox1.DisplayMember = "id"
    End Sub

    Dim Dt As New DataTable
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim oCommand As New SqlCommand
        If (oConnection.State = ConnectionState.Closed) Then
            oConnection.Open()
        End If
        Dim Da As New SqlDataAdapter("SELECT * FROM Student_table",
            oConnection)
        Da.Fill(Dt)
        Dim dummyRow = Dt.NewRow()
        dummyRow(0) = 0
        dummyRow(1) = "SELECT id"
        Dt.Rows.InsertAt(dummyRow, 0)

        ComboBox1.Items.Insert(0, "SELECT id")
        ComboBox1.DataSource = Dt.DefaultView
        ComboBox1.DisplayMember = "id"
        ComboBox1.ValueMember = "id"

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        'MessageBox.Show(ComboBox1.Text.GetType().ToString())
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (oConnection.State = ConnectionState.Closed) Then
            oConnection.Open()
        End If
        Dim oCommand As New SqlCommand
        oCommand.Connection = oConnection
        oCommand.CommandText = "UPDATE Student_table SET Name='" _
            & TextBox1.Text & "', Age=" & TextBox2.Text &
            " WHERE id=" & ComboBox1.SelectedValue
        'MessageBox.Show(oCommand.CommandText)
        If (oCommand.ExecuteNonQuery()) Then
            MessageBox.Show("success")
            FillDt()
        Else
            MessageBox.Show("Data save fail.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (oConnection.State = ConnectionState.Closed) Then
            oConnection.Open()
        End If
        Dim oCommand As New SqlCommand
        oCommand.Connection = oConnection
        oCommand.CommandText = "DELETE Student_table WHERE Name='" _
            & TextBox1.Text & "', Age=" & TextBox2.Text &
            " WHERE id=" & ComboBox1.SelectedValue
        MessageBox.Show(oCommand.CommandText)
        If (oCommand.ExecuteNonQuery()) Then
            MessageBox.Show("Success")
            FillDt()
        Else
            MessageBox.Show("Fail.")
        End If
    End Sub
End Class