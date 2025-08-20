Public Class Form1

    Dim table As New DataTable("Table")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As Integer
        id = Integer.Parse(InputBox("Enter The Id", "Row Data", -1, -1).ToString())

        Dim fn As String
        fn = InputBox("Enter The first name", "Row Data", -1, -1)

        Dim ln As String
        ln = InputBox("Enter The last name")

        Dim age As Integer
        age = InputBox("Enter The age")

        table.Rows.Add(id, fn, ln, age)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        table.Columns.Add("Id", Type.GetType("System.Int32"))
        table.Columns.Add("First Name", Type.GetType("System.String"))
        table.Columns.Add("Last Name", Type.GetType("System.String"))
        table.Columns.Add("Age", Type.GetType("System.Int32"))

        DataGridView1.DataSource = table
    End Sub
End Class
