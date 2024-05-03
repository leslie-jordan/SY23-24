Imports System.Security.Cryptography.X509Certificates

Class MainWindow
    Private Sub clearButton_Click(sender As Object, e As RoutedEventArgs) Handles clearButton.Click
        Textbox1.Text = ""
        Textbox2.Text = ""
        Textbox3.Text = ""
        Textbox4.Text = ""
        okButton.IsEnabled = False
    End Sub

    Private Sub Textbox1_TextChanged(sender As Object, e As TextChangedEventArgs) Handles Textbox1.TextChanged, Textbox2.TextChanged, Textbox3.TextChanged, Textbox4.TextChanged, Textbox5.TextChanged
        If Textbox1.Text Like "##########" And Textbox2.Text Like "* *" And Textbox3.Text Like "###-###-####" And Textbox4.Text Like "##/##/####" And Textbox5.Text Like "####" Then
            okButton.IsEnabled = True
        End If
    End Sub
End Class
