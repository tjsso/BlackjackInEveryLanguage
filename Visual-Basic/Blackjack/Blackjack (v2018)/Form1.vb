Public Class Form1

    Dim rnd As New Random
    Dim CardNum As String
    Dim CardSt As String
    Dim CardSuits(4) As String
    Dim CardNumbers(13) As String
    Dim i As Integer
    Dim n As Integer
    Dim PlayerResult1 As Integer
    Dim playerResult2 As Integer
    Dim DealerResult As Integer
    Dim DealerResult2 As Integer
    Dim dealerTotal As Integer
    Dim playerTotal As Integer
    Dim Bet As Integer

    Private Sub btn_Bet_Click(sender As Object, e As EventArgs) Handles btn_Bet.Click

        Bet = lbl_Bet.Text
        Bet = Bet + 1
        If Bet > 10 Then
            Bet = 10
            MsgBox("Bet Cannot Go Above 10 Pesos")

        End If
        lbl_Bet.Text = Bet



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btn_ResetHand.Enabled = False

        lbl_score.Text = "0"
        txt_DealerHid.Text = "Hidden"
        txt_DealerShow.Text = ""
        lbl_Bet.Text = "0"
        lbl_YourHand1.Text = ""
        lbl_YourHand2.Text = ""

        CardNumbers(1) = "Ace"
        CardNumbers(2) = "Two"
        CardNumbers(3) = "Three"
        CardNumbers(4) = "Four"
        CardNumbers(5) = "Five"
        CardNumbers(6) = "Six"
        CardNumbers(7) = "Seven"
        CardNumbers(8) = "Eight"
        CardNumbers(9) = "Nine"
        CardNumbers(10) = "Ten"
        CardNumbers(11) = "Jack"
        CardNumbers(12) = "Queen"
        CardNumbers(13) = "King"

        CardSuits(1) = "Spades"
        CardSuits(2) = "Clubs"
        CardSuits(3) = "Diamonds"
        CardSuits(4) = "Hearts"

        n = rnd.Next(1, 13)
        CardNum = CardNumbers(n)
        'MsgBox(n)
        i = rnd.Next(1, 4)
        CardSt = CardSuits(i)

        If n > 10 Then
            n = 10
        End If
        If n < 2 Then
            n = 11
        End If
        DealerResult = n
        txt_DealerShow.Text = CardNum & " of " & CardSt

        n = rnd.Next(1, 13)
        i = rnd.Next(1, 4)
        If i = i Then rnd.Next(1, 4)
        CardNum = CardNumbers(n)
        CardSt = CardSuits(i)
        lbl_YourHand1.Text = CardNum & " of " & CardSt
        If n > 10 Then
            n = 10
        End If
        If n < 2 Then
            n = 11
        End If
        PlayerResult1 = n

        n = rnd.Next(1, 13)
        i = rnd.Next(1, 4)
        If i = i Then rnd.Next(1, 4)
        CardNum = CardNumbers(n)
        CardSt = CardSuits(i)
        lbl_YourHand2.Text = CardNum & " of " & CardSt
        If n > 10 Then
            n = 10
        End If
        If n < 2 Then
            n = 11
        End If
        playerResult2 = n

 

    End Sub

  
    Private Sub btn_Show_Click(sender As Object, e As EventArgs) Handles btn_Show.Click

        n = rnd.Next(1, 13)
        i = rnd.Next(1, 4)
        If i = i Then rnd.Next(1, 4)
        CardNum = CardNumbers(n)
        CardSt = CardSuits(i)
        txt_DealerHid.Text = CardNum & " of " & CardSt

        If n > 10 Then
            n = 10
        End If
        If n < 2 Then
            n = 11
        End If


        playerTotal = PlayerResult1 + playerResult2
        dealerTotal = DealerResult + n

        If dealerTotal >= 22 And DealerResult = 11 Or n = 11 Then
            If DealerResult = 11 And n = 11 Then
                n = 1
            End If

            If n = 11 Then
                n = 1
            End If
            dealerTotal = DealerResult + n
        End If

        If playerTotal >= 22 And PlayerResult1 = 11 Or playerResult2 = 11 Then
            If PlayerResult1 = 11 And playerResult2 = 11 Then
                playerResult2 = 1
            End If

            If playerResult2 = 11 Then
                playerResult2 = 1
            End If
            playerTotal = PlayerResult1 + playerResult2
        End If




        MsgBox(PlayerResult1 & "+" & playerResult2 & " = " & playerTotal)
        MsgBox(DealerResult & " + " & n & " = " & dealerTotal)

        If playerTotal >= dealerTotal Then
            MsgBox("You win " & Bet & " Pesos")
            lbl_score.Text = lbl_score.Text + Bet
        Else : MsgBox("House Wins")
            lbl_score.Text = lbl_score.Text - Bet
        End If

        btn_ResetHand.Enabled = True

    End Sub


    Private Sub btn_ResetHand_Click(sender As Object, e As EventArgs) Handles btn_ResetHand.Click


        n = rnd.Next(1, 13)
        i = rnd.Next(1, 4)
        If i = i Then rnd.Next(1, 4)
        CardNum = CardNumbers(n)
        CardSt = CardSuits(i)
        lbl_YourHand1.Text = CardNum & " of " & CardSt
        If n > 10 Then
            n = 10
        End If
        If n < 2 Then
            n = 11
        End If
        PlayerResult1 = n

        n = rnd.Next(1, 13)
        i = rnd.Next(1, 4)
        If i = i Then rnd.Next(1, 4)
        CardNum = CardNumbers(n)
        CardSt = CardSuits(i)
        lbl_YourHand2.Text = CardNum & " of " & CardSt
        If n > 10 Then
            n = 10
        End If
        If n < 2 Then
            n = 11
        End If
        playerResult2 = n

        n = rnd.Next(1, 13)
        i = rnd.Next(1, 4)
        If i = i Then rnd.Next(1, 4)
        CardNum = CardNumbers(n)
        CardSt = CardSuits(i)
        txt_DealerShow.Text = CardNum & " of " & CardSt
        If n > 10 Then
            n = 10
        End If
        If n < 2 Then
            n = 11
        End If
        DealerResult = n

        btn_ResetHand.Enabled = False
        txt_DealerHid.Text = "Hidden"

    End Sub

    Private Sub btn_TakeBet_Click(sender As Object, e As EventArgs) Handles btn_TakeBet.Click

        Bet = lbl_Bet.Text
        Bet = Bet - 1
        If Bet < 0 Then
            Bet = 0


        End If
        lbl_Bet.Text = Bet

    End Sub
End Class
