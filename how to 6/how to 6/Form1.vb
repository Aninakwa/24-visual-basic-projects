Public Class Form1
    Dim index As Integer
    Dim table As New DataTable("Table")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        table.Columns.Add("id", Type.GetType("System.Int32"))
        table.Columns.Add("First Name", Type.GetType("System.String"))
        table.Columns.Add("Last Name", Type.GetType("System.String"))
        table.Columns.Add("Age", Type.GetType("System.Int32"))

        table.Rows.Add(1, "XXXX", " YYYY", 21)
        table.Rows.Add(2, "kofi", "jjk", 33)
        table.Rows.Add(3, "Lemuel", "yuou", 53)
        table.Rows.Add(4, "Lem", "ou", 19)
        table.Rows.Add(5, "Muel", "you", 36)
        table.Rows.Add(6, "Mamuel", "henry", 63)

        DataGridView1.DataSource = table
    End Sub



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        index = e.RowIndex
        Dim SelectedRow As New DataGridViewRow
        SelectedRow = DataGridView1.Rows(index)

        Dim id As String
        id = SelectedRow.Cells(0).Value.ToString()

        Dim fn As String
        fn = SelectedRow.Cells(1).Value.ToString()

        Dim ln As String
        ln = SelectedRow.Cells(2).Value.ToString()

        Dim age As String
        age = SelectedRow.Cells(3).Value.ToString()

        InputBox("The Id", "Show Data", id)
        InputBox("The First Name", "Show Data", fn)
        InputBox("The Last Name", "Show Data", ln)
        InputBox("The Age", "Show Data", age)



    End Sub
End Class
