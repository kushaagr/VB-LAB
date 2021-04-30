Imports System.Data.SqlClient
Public Class Form9
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

End Class