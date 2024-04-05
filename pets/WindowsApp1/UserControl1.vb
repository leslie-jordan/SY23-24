Public Class UserControl1
    Public Event purchase()
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Length = 10 Then
            Button1.Enabled = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = "Purchase Complete"
        RaiseEvent purchase()
    End Sub
End Class
