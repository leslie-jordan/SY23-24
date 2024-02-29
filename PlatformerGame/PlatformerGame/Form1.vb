﻿Public Class Form1
    Dim movespeed As Integer = 10
    Dim isjumping As Boolean
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
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
            End If
        Next
    End Sub

    Private Sub timerGravity_Tick(sender As Object, e As EventArgs) Handles timerGravity.Tick
        picPlayer.Top += movespeed
    End Sub
End Class
