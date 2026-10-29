<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        lblInstruction = New Label()
        lblAttempts = New Label()
        lblMatches = New Label()
        lblStatus = New Label()
        btnStart = New Button()
        btnRestart = New Button()
        hideTimer = New Timer(components)
        btnCard1 = New Button()
        btnCard2 = New Button()
        btnCard3 = New Button()
        btnCard4 = New Button()
        btnCard5 = New Button()
        btnCard6 = New Button()
        btnCard7 = New Button()
        btnCard8 = New Button()
        btnCard10 = New Button()
        btnCard9 = New Button()
        btnCard11 = New Button()
        btnCard12 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(181, 20)
        Label1.TabIndex = 0
        Label1.Text = "Memeory Matching Game"
        ' 
        ' lblInstruction
        ' 
        lblInstruction.AutoSize = True
        lblInstruction.Location = New Point(22, 69)
        lblInstruction.Name = "lblInstruction"
        lblInstruction.Size = New Size(78, 20)
        lblInstruction.TabIndex = 0
        lblInstruction.Text = "Instruction"
        ' 
        ' lblAttempts
        ' 
        lblAttempts.AutoSize = True
        lblAttempts.Location = New Point(22, 103)
        lblAttempts.Name = "lblAttempts"
        lblAttempts.Size = New Size(70, 20)
        lblAttempts.TabIndex = 0
        lblAttempts.Text = "Attempts"
        ' 
        ' lblMatches
        ' 
        lblMatches.AutoSize = True
        lblMatches.Location = New Point(22, 138)
        lblMatches.Name = "lblMatches"
        lblMatches.Size = New Size(64, 20)
        lblMatches.TabIndex = 0
        lblMatches.Text = "Matches"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(22, 170)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(49, 20)
        lblStatus.TabIndex = 0
        lblStatus.Text = "Status"
        ' 
        ' btnStart
        ' 
        btnStart.Location = New Point(35, 265)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(94, 29)
        btnStart.TabIndex = 1
        btnStart.Text = "Start"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' btnRestart
        ' 
        btnRestart.Location = New Point(35, 309)
        btnRestart.Name = "btnRestart"
        btnRestart.Size = New Size(94, 29)
        btnRestart.TabIndex = 1
        btnRestart.Text = "Restart"
        btnRestart.UseVisualStyleBackColor = True
        ' 
        ' btnCard1
        ' 
        btnCard1.BackColor = Color.Cyan
        btnCard1.Font = New Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCard1.Location = New Point(246, 82)
        btnCard1.Name = "btnCard1"
        btnCard1.Size = New Size(70, 70)
        btnCard1.TabIndex = 2
        btnCard1.Tag = "A"
        btnCard1.Text = "?"
        btnCard1.UseVisualStyleBackColor = False
        ' 
        ' btnCard2
        ' 
        btnCard2.BackColor = Color.Cyan
        btnCard2.Font = New Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCard2.Location = New Point(362, 82)
        btnCard2.Name = "btnCard2"
        btnCard2.Size = New Size(70, 70)
        btnCard2.TabIndex = 2
        btnCard2.Tag = "C"
        btnCard2.Text = "?"
        btnCard2.UseVisualStyleBackColor = False
        ' 
        ' btnCard3
        ' 
        btnCard3.BackColor = Color.Cyan
        btnCard3.Font = New Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCard3.Location = New Point(479, 82)
        btnCard3.Name = "btnCard3"
        btnCard3.Size = New Size(70, 70)
        btnCard3.TabIndex = 2
        btnCard3.Tag = "B"
        btnCard3.Text = "?"
        btnCard3.UseVisualStyleBackColor = False
        ' 
        ' btnCard4
        ' 
        btnCard4.BackColor = Color.Cyan
        btnCard4.Font = New Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCard4.Location = New Point(246, 170)
        btnCard4.Name = "btnCard4"
        btnCard4.Size = New Size(70, 70)
        btnCard4.TabIndex = 2
        btnCard4.Tag = "B"
        btnCard4.Text = "?"
        btnCard4.UseVisualStyleBackColor = False
        ' 
        ' btnCard5
        ' 
        btnCard5.BackColor = Color.Cyan
        btnCard5.Font = New Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCard5.Location = New Point(362, 170)
        btnCard5.Name = "btnCard5"
        btnCard5.Size = New Size(70, 70)
        btnCard5.TabIndex = 2
        btnCard5.Tag = "E"
        btnCard5.Text = "?"
        btnCard5.UseVisualStyleBackColor = False
        ' 
        ' btnCard6
        ' 
        btnCard6.BackColor = Color.Cyan
        btnCard6.Font = New Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCard6.Location = New Point(479, 170)
        btnCard6.Name = "btnCard6"
        btnCard6.Size = New Size(70, 70)
        btnCard6.TabIndex = 2
        btnCard6.Tag = "A"
        btnCard6.Text = "?"
        btnCard6.UseVisualStyleBackColor = False
        ' 
        ' btnCard7
        ' 
        btnCard7.BackColor = Color.Cyan
        btnCard7.Font = New Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCard7.Location = New Point(246, 255)
        btnCard7.Name = "btnCard7"
        btnCard7.Size = New Size(70, 70)
        btnCard7.TabIndex = 2
        btnCard7.Tag = "D"
        btnCard7.Text = "?"
        btnCard7.UseVisualStyleBackColor = False
        ' 
        ' btnCard8
        ' 
        btnCard8.BackColor = Color.Cyan
        btnCard8.Font = New Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCard8.Location = New Point(362, 255)
        btnCard8.Name = "btnCard8"
        btnCard8.Size = New Size(70, 70)
        btnCard8.TabIndex = 2
        btnCard8.Tag = "D"
        btnCard8.Text = "?"
        btnCard8.UseVisualStyleBackColor = False
        ' 
        ' btnCard10
        ' 
        btnCard10.BackColor = Color.Cyan
        btnCard10.Font = New Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCard10.Location = New Point(246, 343)
        btnCard10.Name = "btnCard10"
        btnCard10.Size = New Size(70, 70)
        btnCard10.TabIndex = 2
        btnCard10.Tag = "E"
        btnCard10.Text = "?"
        btnCard10.UseVisualStyleBackColor = False
        ' 
        ' btnCard9
        ' 
        btnCard9.BackColor = Color.Cyan
        btnCard9.Font = New Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCard9.Location = New Point(479, 255)
        btnCard9.Name = "btnCard9"
        btnCard9.Size = New Size(70, 70)
        btnCard9.TabIndex = 2
        btnCard9.Tag = "C"
        btnCard9.Text = "?"
        btnCard9.UseVisualStyleBackColor = False
        ' 
        ' btnCard11
        ' 
        btnCard11.BackColor = Color.Cyan
        btnCard11.Font = New Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCard11.Location = New Point(362, 343)
        btnCard11.Name = "btnCard11"
        btnCard11.Size = New Size(70, 70)
        btnCard11.TabIndex = 2
        btnCard11.Tag = "F"
        btnCard11.Text = "?"
        btnCard11.UseVisualStyleBackColor = False
        ' 
        ' btnCard12
        ' 
        btnCard12.BackColor = Color.Cyan
        btnCard12.Font = New Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCard12.Location = New Point(479, 343)
        btnCard12.Name = "btnCard12"
        btnCard12.Size = New Size(70, 70)
        btnCard12.TabIndex = 2
        btnCard12.Tag = "F"
        btnCard12.Text = "?"
        btnCard12.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCard12)
        Controls.Add(btnCard11)
        Controls.Add(btnCard6)
        Controls.Add(btnCard9)
        Controls.Add(btnCard5)
        Controls.Add(btnCard10)
        Controls.Add(btnCard3)
        Controls.Add(btnCard8)
        Controls.Add(btnCard4)
        Controls.Add(btnCard7)
        Controls.Add(btnCard2)
        Controls.Add(btnCard1)
        Controls.Add(btnRestart)
        Controls.Add(btnStart)
        Controls.Add(lblStatus)
        Controls.Add(lblMatches)
        Controls.Add(lblAttempts)
        Controls.Add(lblInstruction)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Memory Matching Game"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblInstruction As Label
    Friend WithEvents lblAttempts As Label
    Friend WithEvents lblMatches As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnRestart As Button
    Friend WithEvents hideTimer As Timer
    Friend WithEvents btnCard1 As Button
    Friend WithEvents btnCard2 As Button
    Friend WithEvents btnCard3 As Button
    Friend WithEvents btnCard4 As Button
    Friend WithEvents btnCard5 As Button
    Friend WithEvents btnCard6 As Button
    Friend WithEvents btnCard7 As Button
    Friend WithEvents btnCard8 As Button
    Friend WithEvents btnCard10 As Button
    Friend WithEvents btnCard9 As Button
    Friend WithEvents btnCard11 As Button
    Friend WithEvents btnCard12 As Button

End Class
