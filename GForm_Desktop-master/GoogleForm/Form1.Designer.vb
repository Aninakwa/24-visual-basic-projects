<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        BtnViewSubmissions = New Button()
        BtnCreateSubmission = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(202, 107)
        Label1.Name = "Label1"
        Label1.Size = New Size(357, 20)
        Label1.TabIndex = 0
        Label1.Text = "Jhon Doe, Slidely Task 2 - Slidely Form App"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' BtnViewSubmissions
        ' 
        BtnViewSubmissions.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        BtnViewSubmissions.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnViewSubmissions.Location = New Point(244, 140)
        BtnViewSubmissions.Margin = New Padding(3, 2, 3, 2)
        BtnViewSubmissions.Name = "BtnViewSubmissions"
        BtnViewSubmissions.Padding = New Padding(2)
        BtnViewSubmissions.Size = New Size(309, 52)
        BtnViewSubmissions.TabIndex = 1
        BtnViewSubmissions.Text = "VIEW SUBMISSIONS (CTRL + V)"
        BtnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' BtnCreateSubmission
        ' 
        BtnCreateSubmission.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        BtnCreateSubmission.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnCreateSubmission.Location = New Point(244, 233)
        BtnCreateSubmission.Margin = New Padding(3, 2, 3, 2)
        BtnCreateSubmission.Name = "BtnCreateSubmission"
        BtnCreateSubmission.Padding = New Padding(2)
        BtnCreateSubmission.Size = New Size(309, 56)
        BtnCreateSubmission.TabIndex = 2
        BtnCreateSubmission.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        BtnCreateSubmission.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(818, 467)
        Controls.Add(BtnCreateSubmission)
        Controls.Add(BtnViewSubmissions)
        Controls.Add(Label1)
        KeyPreview = True
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Padding = New Padding(4, 4, 4, 4)
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnViewSubmissions As Button
    Friend WithEvents BtnCreateSubmission As Button

End Class
