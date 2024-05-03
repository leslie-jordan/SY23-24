Class MainWindow
    Private Sub drawingCanvas_MouseMove(sender As Object, e As MouseEventArgs) Handles drawingcanvas.MouseMove
        Dim el As New Ellipse
        el.Width = widthSlider.Value
        el.Height = heightSlider.Value
        el.Fill = color1Rectangle.Fill

        Dim p As Point = Mouse.GetPosition(drawingcanvas)
        Canvas.SetLeft(el, p.X)
        Canvas.SetTop(el, p.Y)
        drawingcanvas.Children.Add(el)
    End Sub
End Class
