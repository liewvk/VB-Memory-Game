Public Class Form1
    Dim firstCard As Button = Nothing
    Dim secondCard As Button = Nothing

    Dim matchesFound As Integer = 0
    Dim attempts As Integer = 0

    Dim gameStarted As Boolean = False
    Dim gameBusy As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblInstruction.Text = "Find all the matching pairs."
        lblAttempts.Text = "Attempts: 0"
        lblMatches.Text = "Matches: 0"
        lblStatus.Text = "Click Start to begin."

        hideTimer.Interval = 800
        PrepareCardsHidden()
    End Sub

    Private Sub PrepareCardsHidden()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso ctrl.Tag IsNot Nothing AndAlso ctrl.Name.StartsWith("btnCard") Then
                ctrl.Text = "?"
                ctrl.Enabled = True
            End If
        Next
    End Sub

    Private Sub ShuffleAndAssignCards()
        Dim rnd As New Random()
        Dim values As New List(Of String) From {"A", "A", "B", "B", "C", "C", "D", "D", "E", "E", "F", "F"}

        Dim cardButtons As New List(Of Button)

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso ctrl.Name.StartsWith("btnCard") Then
                cardButtons.Add(DirectCast(ctrl, Button))
            End If
        Next

        For Each btn As Button In cardButtons
            Dim index As Integer = rnd.Next(values.Count)
            btn.Tag = values(index)
            values.RemoveAt(index)
            btn.Text = "?"
            btn.Enabled = True
        Next
    End Sub

    Private Sub StartGame()
        firstCard = Nothing
        secondCard = Nothing

        matchesFound = 0
        attempts = 0

        gameStarted = True
        gameBusy = False

        lblAttempts.Text = "Attempts: 0"
        lblMatches.Text = "Matches: 0"
        lblStatus.Text = "Find all the pairs."

        ShuffleAndAssignCards()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        StartGame()
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        StartGame()
    End Sub

    Private Sub Card_Click(sender As Object, e As EventArgs) _
    Handles btnCard1.Click, btnCard2.Click, btnCard3.Click, btnCard4.Click,
            btnCard5.Click, btnCard6.Click, btnCard7.Click, btnCard8.Click,
            btnCard9.Click, btnCard10.Click, btnCard11.Click, btnCard12.Click

        If Not gameStarted OrElse gameBusy Then Exit Sub

        Dim clickedCard As Button = DirectCast(sender, Button)

        If clickedCard Is firstCard Then Exit Sub
        If clickedCard.Enabled = False Then Exit Sub
        If clickedCard.Text <> "?" Then Exit Sub

        clickedCard.Text = clickedCard.Tag.ToString()

        If firstCard Is Nothing Then
            firstCard = clickedCard
        Else
            secondCard = clickedCard
            attempts += 1
            lblAttempts.Text = "Attempts: " & attempts.ToString()
            CheckMatch()
        End If
    End Sub

    Private Sub CheckMatch()
        If firstCard.Tag.ToString() = secondCard.Tag.ToString() Then
            firstCard.Enabled = False
            secondCard.Enabled = False

            matchesFound += 1
            lblMatches.Text = "Matches: " & matchesFound.ToString()
            lblStatus.Text = "Match found!"

            firstCard = Nothing
            secondCard = Nothing

            If matchesFound = 6 Then
                gameStarted = False
                lblStatus.Text = "You found all the pairs!"
                MessageBox.Show("Congratulations! You completed the board in " & attempts.ToString() & " attempts.")
            End If
        Else
            lblStatus.Text = "Not a match."
            gameBusy = True
            hideTimer.Start()
        End If
    End Sub

    Private Sub hideTimer_Tick(sender As Object, e As EventArgs) Handles hideTimer.Tick
        hideTimer.Stop()

        If firstCard IsNot Nothing Then firstCard.Text = "?"
        If secondCard IsNot Nothing Then secondCard.Text = "?"

        firstCard = Nothing
        secondCard = Nothing

        gameBusy = False
        lblStatus.Text = "Try again."
    End Sub

End Class
