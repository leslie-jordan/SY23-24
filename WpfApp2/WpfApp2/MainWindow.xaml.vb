Class MainWindow
    Private Sub convertButton_Click(sender As Object, e As RoutedEventArgs) Handles convertButton.Click
        Dim dollars As Decimal
        Dim euros As Decimal
        Dim pesos As Decimal
        Dim canadiandollars As Decimal
        Dim pounds As Decimal
        Dim yen As Decimal
        Dim won As Decimal

        Decimal.TryParse(dollarsTextbox.Text, dollars)
        euros = dollars * 0.93
        pesos = dollars * 16.98
        canadiandollars = dollars * 1.37
        pounds = dollars * 0.8
        yen = dollars * 154.78
        won = won * 1373.76

        Textbox1.Text = euros.ToString("C2")
        Textbox2.Text = pesos.ToString("C2")
        Textbox3.Text = canadiandollars.ToString("C2")
        Textbox4.Text = pounds.ToString("C2")
        Textbox5.Text = yen.ToString("C2")
        Textbox6.Text = won.ToString("C2")
    End Sub
End Class
