<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimpleGuessingGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnNewGame = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnNewGame
        '
        Me.BtnNewGame.Location = New System.Drawing.Point(337, 308)
        Me.BtnNewGame.Name = "BtnNewGame"
        Me.BtnNewGame.Size = New System.Drawing.Size(138, 24)
        Me.BtnNewGame.TabIndex = 27
        Me.BtnNewGame.Text = "New Game"
        Me.BtnNewGame.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(296, 263)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 13)
        Me.lblResult.TabIndex = 26
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(276, 65)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(140, 13)
        Me.lblMessage.TabIndex = 25
        Me.lblMessage.Text = "Guess a number from 0 to 9!"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(271, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(119, 13)
        Me.lblTitle.TabIndex = 24
        Me.lblTitle.Text = "Guess the Number (0-9)"
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(390, 176)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(35, 25)
        Me.btn5.TabIndex = 23
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(440, 176)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(35, 25)
        Me.btn6.TabIndex = 22
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(440, 207)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(35, 25)
        Me.btn9.TabIndex = 21
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(337, 207)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(35, 25)
        Me.btn7.TabIndex = 20
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(390, 207)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(35, 25)
        Me.btn8.TabIndex = 19
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(337, 145)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(35, 25)
        Me.btn1.TabIndex = 18
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(390, 145)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(35, 25)
        Me.btn2.TabIndex = 17
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(440, 145)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(35, 25)
        Me.btn3.TabIndex = 16
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(337, 176)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(35, 25)
        Me.btn4.TabIndex = 15
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(390, 102)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(35, 25)
        Me.btn0.TabIndex = 14
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'SimpleGuessingGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnNewGame)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn0)
        Me.Name = "SimpleGuessingGame"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnNewGame As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn0 As Button
End Class
