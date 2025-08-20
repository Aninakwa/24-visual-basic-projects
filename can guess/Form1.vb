Public Class SimpleGuessingGame
    Private secretNumber As Integer
    Private random As New Random()

    Private Sub SimpleGuessingGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartNewGame()
    End Sub

    Private Sub StartNewGame()
        secretNumber = random.Next(0, 10)
        lblMessage.Text = "Guess a number from 0 to 9!"
        lblResult.Text = ""
        For Each btn As Button In {btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9}
            btn.Enabled = True
            btn.BackColor = SystemColors.Control
        Next
    End Sub

    Private Sub NumberButton_Click(sender As Object, e As EventArgs) Handles _
        btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click,
        btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click

        Dim clickedButton As Button = DirectCast(sender, Button)
        Dim guess As Integer = Integer.Parse(clickedButton.Text)

        If guess = secretNumber Then
            lblResult.Text = "Correct! You guessed it!"
            clickedButton.BackColor = Color.Green
            For Each btn As Button In {btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9}
                btn.Enabled = False
            Next
        Else
            lblResult.Text = "Wrong! Try again!"
            clickedButton.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles BtnNewGame.Click
        StartNewGame()
    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub
End Class