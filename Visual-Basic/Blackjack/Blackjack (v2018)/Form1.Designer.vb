<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txt_DealerShow = New System.Windows.Forms.TextBox()
        Me.txt_DealerHid = New System.Windows.Forms.TextBox()
        Me.lbl_Dealer = New System.Windows.Forms.Label()
        Me.lbl_YourHand1 = New System.Windows.Forms.Label()
        Me.lbl_YourHand2 = New System.Windows.Forms.Label()
        Me.lbl_Bet = New System.Windows.Forms.Label()
        Me.btn_Bet = New System.Windows.Forms.Button()
        Me.btn_Show = New System.Windows.Forms.Button()
        Me.btn_TakeBet = New System.Windows.Forms.Button()
        Me.btn_ResetHand = New System.Windows.Forms.Button()
        Me.lbl_score = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_DealerShow
        '
        Me.txt_DealerShow.Enabled = False
        Me.txt_DealerShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_DealerShow.Location = New System.Drawing.Point(82, 62)
        Me.txt_DealerShow.Name = "txt_DealerShow"
        Me.txt_DealerShow.Size = New System.Drawing.Size(212, 26)
        Me.txt_DealerShow.TabIndex = 0
        '
        'txt_DealerHid
        '
        Me.txt_DealerHid.Enabled = False
        Me.txt_DealerHid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_DealerHid.Location = New System.Drawing.Point(82, 107)
        Me.txt_DealerHid.Name = "txt_DealerHid"
        Me.txt_DealerHid.Size = New System.Drawing.Size(212, 26)
        Me.txt_DealerHid.TabIndex = 1
        '
        'lbl_Dealer
        '
        Me.lbl_Dealer.AutoSize = True
        Me.lbl_Dealer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lbl_Dealer.Location = New System.Drawing.Point(123, 9)
        Me.lbl_Dealer.Name = "lbl_Dealer"
        Me.lbl_Dealer.Size = New System.Drawing.Size(131, 25)
        Me.lbl_Dealer.TabIndex = 2
        Me.lbl_Dealer.Text = "Dealers Hand"
        '
        'lbl_YourHand1
        '
        Me.lbl_YourHand1.AutoSize = True
        Me.lbl_YourHand1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lbl_YourHand1.Location = New System.Drawing.Point(13, 222)
        Me.lbl_YourHand1.Name = "lbl_YourHand1"
        Me.lbl_YourHand1.Size = New System.Drawing.Size(105, 25)
        Me.lbl_YourHand1.TabIndex = 3
        Me.lbl_YourHand1.Text = "Your Hand"
        '
        'lbl_YourHand2
        '
        Me.lbl_YourHand2.AutoSize = True
        Me.lbl_YourHand2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lbl_YourHand2.Location = New System.Drawing.Point(202, 222)
        Me.lbl_YourHand2.Name = "lbl_YourHand2"
        Me.lbl_YourHand2.Size = New System.Drawing.Size(105, 25)
        Me.lbl_YourHand2.TabIndex = 4
        Me.lbl_YourHand2.Text = "Your Hand"
        '
        'lbl_Bet
        '
        Me.lbl_Bet.AutoSize = True
        Me.lbl_Bet.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lbl_Bet.Location = New System.Drawing.Point(164, 160)
        Me.lbl_Bet.Name = "lbl_Bet"
        Me.lbl_Bet.Size = New System.Drawing.Size(41, 25)
        Me.lbl_Bet.TabIndex = 5
        Me.lbl_Bet.Text = "Bet"
        '
        'btn_Bet
        '
        Me.btn_Bet.Location = New System.Drawing.Point(16, 272)
        Me.btn_Bet.Name = "btn_Bet"
        Me.btn_Bet.Size = New System.Drawing.Size(101, 42)
        Me.btn_Bet.TabIndex = 6
        Me.btn_Bet.Text = "Add Bet"
        Me.btn_Bet.UseVisualStyleBackColor = True
        '
        'btn_Show
        '
        Me.btn_Show.Location = New System.Drawing.Point(248, 272)
        Me.btn_Show.Name = "btn_Show"
        Me.btn_Show.Size = New System.Drawing.Size(101, 42)
        Me.btn_Show.TabIndex = 7
        Me.btn_Show.Text = "Show Cards"
        Me.btn_Show.UseVisualStyleBackColor = True
        '
        'btn_TakeBet
        '
        Me.btn_TakeBet.Location = New System.Drawing.Point(17, 320)
        Me.btn_TakeBet.Name = "btn_TakeBet"
        Me.btn_TakeBet.Size = New System.Drawing.Size(101, 42)
        Me.btn_TakeBet.TabIndex = 8
        Me.btn_TakeBet.Text = "Decrease Bet"
        Me.btn_TakeBet.UseVisualStyleBackColor = True
        '
        'btn_ResetHand
        '
        Me.btn_ResetHand.Location = New System.Drawing.Point(248, 320)
        Me.btn_ResetHand.Name = "btn_ResetHand"
        Me.btn_ResetHand.Size = New System.Drawing.Size(101, 42)
        Me.btn_ResetHand.TabIndex = 9
        Me.btn_ResetHand.Text = "Reset Hand"
        Me.btn_ResetHand.UseVisualStyleBackColor = True
        '
        'lbl_score
        '
        Me.lbl_score.AutoSize = True
        Me.lbl_score.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lbl_score.Location = New System.Drawing.Point(164, 326)
        Me.lbl_score.Name = "lbl_score"
        Me.lbl_score.Size = New System.Drawing.Size(60, 25)
        Me.lbl_score.TabIndex = 10
        Me.lbl_score.Text = "score"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 374)
        Me.Controls.Add(Me.lbl_score)
        Me.Controls.Add(Me.btn_ResetHand)
        Me.Controls.Add(Me.btn_TakeBet)
        Me.Controls.Add(Me.btn_Show)
        Me.Controls.Add(Me.btn_Bet)
        Me.Controls.Add(Me.lbl_Bet)
        Me.Controls.Add(Me.lbl_YourHand2)
        Me.Controls.Add(Me.lbl_YourHand1)
        Me.Controls.Add(Me.lbl_Dealer)
        Me.Controls.Add(Me.txt_DealerHid)
        Me.Controls.Add(Me.txt_DealerShow)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "BlackJack"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_DealerShow As System.Windows.Forms.TextBox
    Friend WithEvents txt_DealerHid As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Dealer As System.Windows.Forms.Label
    Friend WithEvents lbl_YourHand1 As System.Windows.Forms.Label
    Friend WithEvents lbl_YourHand2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Bet As System.Windows.Forms.Label
    Friend WithEvents btn_Bet As System.Windows.Forms.Button
    Friend WithEvents btn_Show As System.Windows.Forms.Button
    Friend WithEvents btn_TakeBet As System.Windows.Forms.Button
    Friend WithEvents btn_ResetHand As System.Windows.Forms.Button
    Friend WithEvents lbl_score As System.Windows.Forms.Label

End Class
