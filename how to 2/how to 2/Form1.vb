Imports System.Data.DataTable
Public Class Form1
    Dim table As New DataTable("Table")
    Dim index As Integer
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

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
    '   table.Rows.Add(txtboxID.Text, txtFirstName.Text, txtLastName.Text, txtAge.Text)
    '  DataGridView1.DataSource = table
    ' End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        txtboxID.Text = selectedRow.Cells(0).Value.ToString
        txtFirstName.Text = selectedRow.Cells(1).Value.ToString
        txtLastName.Text = selectedRow.Cells(2).Value.ToString
        txtAge.Text = selectedRow.Cells(3).Value.ToString

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim newDataRow As DataGridViewRow
        newDataRow = DataGridView1.Rows(index)
        newDataRow.Cells(0).Value = txtboxID.Text
        newDataRow.Cells(1).Value = txtFirstName.Text
        newDataRow.Cells(2).Value = txtLastName.Text
        newDataRow.Cells(3).Value = txtAge.Text
    End Sub
End Class
