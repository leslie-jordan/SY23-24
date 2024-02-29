Public Class Form1
    Dim cs As New CoinSlot
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cs.total >= 1 Then
            ReelControl1.spin()
            ReelControl2.spin()
            ReelControl3.spin()
            cs.spin()
            Label4.Text = cs.total.ToString("c2")
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.insertdollar()
        Label4.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.insertquarter()
        Label4.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertdime()
        Label4.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.insertnickel()
        Label4.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = ReelControl1.itemValue
        Label2.Text = ReelControl2.itemValue
        Label3.Text = ReelControl3.itemValue
        Timer1.Enabled = False
        If ReelControl1.itemValue = ReelControl2.itemValue And
        ReelControl2.itemValue = ReelControl3.itemValue Then
            cs.insertten()
            Label4.Text = cs.total.ToString("c2")
        End If
    End Sub
End Class
