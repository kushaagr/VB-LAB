Imports System.Data.SqlClient

Public Class Form9
    'Dim a As Int16
    Dim Dr As SqlDataReader
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
        Else
            MessageBox.Show("Data save fail.")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim DRow As DataRow()
        If ComboBox1.Items.Count >= 0 Then
            DRow = Dt.Select($"id={ComboBox1.SelectedValue}")

            TextBox1.Text = DRow(0).Item("Name")
            TextBox2.Text = DRow(0).Item("Age")
        End If
        'TextBox2.Text = ComboBox1.SelectedValue(1)
        REM MsgBox(ComboBox1.SelectedValue.ToString())

        'While Dr.Read()
        'If (Dr.Item("Id").ToString() = ComboBox1.Text) Then
        '        TextBox1.Text = Dr.Item("Name")
        '        TextBox2.Text = Dr.Item("Age")
        '        MsgBox("Found!")
        '    End If
        'End While

    End Sub

    'Dim List As List(Of Object)
    Dim Dt As New DataTable
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim oCommand As New SqlCommand
        If (oConnection.State = ConnectionState.Closed) Then
            oConnection.Open()
        End If
        Dim Da As New SqlDataAdapter("SELECT * FROM Student_table",
            oConnection)
        Da.Fill(Dt)
        ComboBox1.DataSource = Dt.DefaultView
        ComboBox1.DisplayMember = "name"
        ComboBox1.ValueMember = "id"


        'oCommand.Connection = oConnection
        'oCommand.CommandText = "SELECT * FROM Student_table"
        'Dr = oCommand.ExecuteReader()
        'If Dr.HasRows Then
        '    While Dr.Read()
        '        ComboBox1.Items.Add(Dr.Item(0))

        '        'List.Add(Dr.Item(0))
        '        'Dr.GetValues()
        '    End While
        'End If
        'a = 56
        'ComboBox1.ValueMember = "id"

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show(ComboBox1.Text.GetType().ToString())
    End Sub
End Class