Imports System.Data.DataTable
Public Class Form1
    Dim table As New DataTable("Table")
    Dim index As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        table.Columns.Add("Id", Type.GetType("System.Int32"))
        table.Columns.Add("First Name", Type.GetType("System.String"))
        table.Columns.Add("Last Name", Type.GetType("System.String"))
        table.Columns.Add("Age", Type.GetType("System.Int32"))

        table.Rows.Add("1", "Kofi", "Nimo", 23)
        table.Rows.Add("1", "Kofi", "Nimo", 23)
        table.Rows.Add("1", "Kofi", "Nimo", 23)
        table.Rows.Add("1", "Kofi", "Nimo", 23)
        table.Rows.Add("1", "Kofi", "Nimo", 23)
        table.Rows.Add("1", "Kofi", "Nimo", 23)
        table.Rows.Add("1", "Kofi", "Nimo", 23)
        table.Rows.Add("1", "Kofi", "Nimo", 23)
        table.Rows.Add("1", "Kofi", "Nimo", 23)
        table.Rows.Add("1", "Kofi", "Nimo", 23)

        DataGridView1.DataSource = table

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        TextBoxID.Text = selectedRow.Cells(0).Value.ToString
        TextBoxFN.Text = selectedRow.Cells(1).Value.ToString
        TextBoxLN.Text = selectedRow.Cells(2).Value.ToString
        TextBoxAGE.Text = selectedRow.Cells(3).Value.ToString

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        table.Rows.Add(TextBoxID.Text, TextBoxFN.Text, TextBoxLN.Text, TextBoxAGE.Text)
        DataGridView1.DataSource = table
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim newDataRow As DataGridViewRow
        newDataRow = DataGridView1.Rows(index)
        newDataRow.Cells(0).Value = TextBoxID.Text
        newDataRow.Cells(1).Value = TextBoxFN.Text
        newDataRow.Cells(2).Value = TextBoxLN.Text
        newDataRow.Cells(3).Value = TextBoxAGE.Text

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        index = DataGridView1.CurrentCell.RowIndex
        DataGridView1.Rows.RemoveAt(index)
    End Sub
End Class
