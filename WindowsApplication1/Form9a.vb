Imports System.Data.SqlClient
Public Class Form9a
    Dim oConnection As New SqlConnection(
        "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database_one;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        )

    Private Sub Form91_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDg()
    End Sub

    Sub FillDg()
        Dim Dt As New DataTable
        Dim oCommand As New SqlCommand
        If (oConnection.State = ConnectionState.Closed) Then
            oConnection.Open()
        End If
        Dim Da As New SqlDataAdapter("SELECT * FROM Student_table",
oConnection)
        Da.Fill(Dt)
        DataGridView1.DataSource = Dt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Dim res As DialogResult
        res = MessageBox.Show("Do you want to delete this row?",
                              "<Caption>",
                              MessageBoxButtons.YesNo)

        If res = DialogResult.Yes Then
            MessageBox.Show("Deleted!")
            'DataGridView1.CurrentRow.Cells(0).Value

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
