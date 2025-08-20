Public Class Form1

    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles BtnCheck.Click
        Dim num As Integer

        If Integer.TryParse(txtNumber.Text, num) Then
            Dim result As String

            ' Check even or odd
            If num Mod 2 = 0 Then
                result = "Even"
            Else
                result = "Odd"
            End If

            ' Check if prime
            If num > 1 AndAlso IsPrime(num) Then
                result &= " and Prime"
            End If

            MsgBox("The number " & num & " is " & result & ".")

        Else
            MsgBox("Please enter a valid integer.")
        End If
    End Sub

    Private Function IsPrime(n As Integer) As Boolean
        If n < 2 Then Return False
        For i As Integer = 2 To Math.Sqrt(n)
            If n Mod i = 0 Then Return False
        Next
        Return True
    End Function

End Class
