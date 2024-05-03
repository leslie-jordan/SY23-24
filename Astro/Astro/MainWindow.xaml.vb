Class MainWindow
    Private Sub Button1_Click(sender As Object, e As RoutedEventArgs) Handles Button1.Click
        Dim m As Integer
        Dim d As Integer
        m = Calendar1.SelectedDate.Value.Month
        d = Calendar1.SelectedDate.Value.Day
        Label1.Content = Calendar1.SelectedDate

        If m = 2 And d > 18 Or m = 3 And d < 21 Then
            monthLabel.Content = "Pisces"
            PictureBox1.Opacity = "1.0"
        End If
        If m = 3 And d > 20 Or m = 4 And d < 20 Then
            monthLabel.Content = "Aries"
            PictureBox2.Opacity = "1.0"
        End If
        If m = 4 And d > 19 Or m = 5 And d < 21 Then
            monthLabel.Content = "Taurus"
            PictureBox3.Opacity = "1.0"
        End If
        If m = 5 And d > 20 Or m = 6 And d < 22 Then
            monthLabel.Content = "Gemini"
            PictureBox4.Opacity = "1.0"
        End If
        If m = 6 And d > 21 Or m = 7 And d < 23 Then
            monthLabel.Content = "Cancer"
            PictureBox5.Opacity = "1.0"
        End If
        If m = 7 And d > 22 Or m = 8 And d < 23 Then
            monthLabel.Content = "Leo"
            PictureBox6.Opacity = "1.0"
        End If
        If m = 8 And d > 22 Or m = 9 And d < 23 Then
            monthLabel.Content = "Virgo"
            PictureBox7.Opacity = "1.0"
        End If
        If m = 9 And d > 22 Or m = 10 And d < 23 Then
            monthLabel.Content = "Libra"
            PictureBox8.Opacity = "1.0"
        End If
        If m = 10 And d > 22 Or m = 11 And d < 22 Then
            monthLabel.Content = "Scorpio"
            PictureBox9.Opacity = "1.0"
        End If
        If m = 11 And d > 21 Or m = 12 And d < 22 Then
            monthLabel.Content = "Sagittarius"
            PictureBox10.Opacity = "1.0"
        End If
        If m = 12 And d > 21 Or m = 1 And d < 20 Then
            monthLabel.Content = "Capricorn"
            PictureBox11.Opacity = "1.0"
        End If
        If m = 1 And d > 18 Or m = 2 And d < 18 Then
            monthLabel.Content = "Aquarius"
            PictureBox12.Opacity = "1.0"
        End If
    End Sub
End Class
