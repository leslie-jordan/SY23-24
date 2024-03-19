Public Class Form1
    Dim movespeed As Integer = 10
    Dim isjumping As Boolean
    Dim t As Integer
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                timerRight.Start()
            Case Keys.Left
                timerLeft.Start()
            Case Keys.Up
                timerUp.Start()
                isjumping = True
        End Select
    End Sub

    Private Sub timerRight_Tick(sender As Object, e As EventArgs) Handles timerRight.Tick
        picPlayer.Left += 15
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                timerRight.Stop()
            Case Keys.Left
                timerLeft.Stop()
            Case Keys.Up
                timerUp.Stop()
                isjumping = False
        End Select
    End Sub

    Private Sub timerLeft_Tick(sender As Object, e As EventArgs) Handles timerLeft.Tick
        picPlayer.Left -= movespeed
        TextBox1.Select()
    End Sub

    Private Sub timerUp_Tick(sender As Object, e As EventArgs) Handles timerUp.Tick
        picPlayer.Top -= movespeed
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerGameLogic.Start()
    End Sub

    Private Sub timerGameLogic_Tick(sender As Object, e As EventArgs) Handles timerGameLogic.Tick
        If picPlayer.Bounds.IntersectsWith(picGround.Bounds) Then
            timerGravity.Stop()
        Else
            If isjumping = False Then
                timerGravity.Start()
            End If
        End If

        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        timerGravity.Stop()
                    End If
                End If
                If b.Tag = "coin1" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        t = 1
                        PictureBox5.Visible = False
                    End If
                End If
                If b.Tag = "coin2" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        t = 2
                        PictureBox1.Visible = False
                    End If
                End If
                If b.Tag = "win" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        mousePictureBox.Visible = False
                        Mover1.speed = 0
                        Mover2.speed = 0
                        Mover3.speed = 0
                        Mover4.speed = 0
                        Me.BackColor = Color.Green
                        t = 10
                    End If
                End If
                If b.Tag = "lose" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        picPlayer.Visible = False
                        Mover1.speed = 0
                        Mover2.speed = 0
                        Mover3.speed = 0
                        Mover4.speed = 0
                        Me.BackColor = Color.Red
                        t = 0
                    End If
                End If
            End If
        Next
        Label1.Text = t
    End Sub

    Private Sub timerGravity_Tick(sender As Object, e As EventArgs) Handles timerGravity.Tick
        picPlayer.Top += movespeed
    End Sub

End Class
