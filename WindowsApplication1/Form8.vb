Imports System.Data.SqlClient

Public Class Form8
    Dim oConnection As New SqlConnection(
        "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database_one;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        )

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (oConnection.State = ConnectionState.Closed) Then
            oConnection.Open()
            MessageBox.Show("Connection open now!")
        End If

    End Sub
End Class