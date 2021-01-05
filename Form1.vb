Public Class Form1

    'Ball Variables'
    Dim ballxVel As Integer = 5
    Dim ballyVel As Integer = 5
    Dim velInc As Integer = 1
    Dim pdlInc As Integer = 5
    Dim rnd As New Random
    'Paddle Variables'
    Dim padyVel As Integer = 10
    Dim padLUp As Boolean = False
    Dim padLDown As Boolean = False
    Dim padRUp As Boolean = False
    Dim padRDown As Boolean = False

    Dim scoreR As Integer = 0
    Dim scoreL As Integer = 0


    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        'Ball movement'
        pbBall.Left += ballxVel
        pbBall.Top += ballyVel

        'Bounce'

        'Bottom'
        If pbBall.Bottom >= pbCanvas.Bottom Then
            ballyVel *= -1
        End If

        'Top'
        If pbBall.Top <= pbCanvas.Top Then
            ballyVel *= -1
        End If

        'Right'
        If pbBall.Right >= pbCanvas.Right Then
            pbBall.Location = New Point(pbCanvas.Width / 2, pbCanvas.Height / 2)
            scoreL += 1
            lblScoreL.Text = scoreL
            ballxVel = 5
            pbPadL.Height = 150
            pbPadR.Height = 150
        End If

        'Left'
        If pbBall.Left <= pbCanvas.Left Then
            pbBall.Location = New Point(pbCanvas.Width / 2, pbCanvas.Height / 2)
            scoreR += 1
            lblScoreR.Text = scoreR
            ballxVel = 5
            ballyVel = rnd.Next(-10, 10)
            pbPadL.Height = 150
            pbPadR.Height = 150
        End If



        '========================================================================================'
        'Paddle code'

        If padLUp = True And pbPadL.Top > pbCanvas.Top Then
            pbPadL.Top -= padyVel
        End If

        If padLDown = True And pbPadL.Bottom < pbCanvas.Bottom Then
            pbPadL.Top += padyVel
        End If

        'Right Paddle'
        If padRUp = True And pbPadR.Top > pbCanvas.Top Then
            pbPadR.Top -= padyVel
        End If

        If padRDown = True And pbPadR.Bottom < pbCanvas.Bottom Then
            pbPadR.Top += padyVel
        End If

        'Ball / Paddle collision'
        If pbBall.Bounds.IntersectsWith(pbPadL.Bounds) Then
            ballxVel *= -1
            ballxVel += velInc
            pbPadL.Height -= pdlInc
        End If

        If pbBall.Bounds.IntersectsWith(pbPadR.Bounds) Then
            ballxVel *= -1
            ballxVel -= velInc
            pbPadR.Height -= pdlInc
        End If


    End Sub

    Private Sub Form1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        'Up W // Left Table'
        If e.KeyData = Keys.W Then
            padLUp = True
            padLDown = False
        End If

        'Down S// Left Table'
        If e.KeyData = Keys.S Then
            padLDown = True
            padLUp = False
        End If

        'Up Arrow // Right Table'
        If e.KeyData = Keys.Up Then
            padRUp = True
            padRDown = False
        End If

        'Down Arrow // Right Table'
        If e.KeyData = Keys.Down Then
            padRDown = True
            padRUp = False
        End If

    End Sub

    Private Sub Form1_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp

        'Up W // Left Table'
        If e.KeyData = Keys.W Then
            padLUp = False
        End If

        'Down S // Left Table'
        If e.KeyData = Keys.S Then
            padLDown = False
        End If

        'Up Arrow // Right Table'
        If e.KeyData = Keys.Up Then
            padRUp = False
        End If

        'Down Arrow // Right Table'
        If e.KeyData = Keys.Down Then
            padRDown = False
        End If

    End Sub

    Private Sub CentreBall()

    End Sub

End Class
