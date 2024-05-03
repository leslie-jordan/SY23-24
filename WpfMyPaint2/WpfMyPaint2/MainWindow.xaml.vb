Imports Microsoft.Win32
Imports System.IO
Imports System.Windows.Forms
Class MainWindow
    Dim c1 As Color
    Dim c2 As Color
    Private Sub drawingCanvas_MouseMove(sender As Object, e As MouseEventArgs) Handles drawingcanvas.MouseMove
        Dim el As New Ellipse
        el.Width = widthSlider.Value
        el.Height = heightSlider.Value
        el.Fill = color1.Fill

        Dim p As Point = Mouse.GetPosition(drawingcanvas)
        Canvas.SetLeft(el, p.X)
        Canvas.SetTop(el, p.Y)
        If e.LeftButton = MouseButtonState.Pressed Then
            drawingcanvas.Children.Add(el)
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        drawingcanvas.Children.RemoveRange(1, drawingcanvas.Children.Count - 1)
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        drawingcanvas.Children.RemoveAt(drawingcanvas.Children.Count - 1)
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        shapeLabel.Content = sender.content
    End Sub

    Private Sub angleSlider_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double)) Handles angleSlider.ValueChanged
        color1.Fill = New LinearGradientBrush(c1, c2, angleSlider.Value)
    End Sub

    Private Sub saveButton_Click(sender As Object, e As RoutedEventArgs) Handles saveButton.Click
        ExportToPng(drawingcanvas)
    End Sub

    Public Sub ExportToPng(ByVal surface As Canvas)

        Dim sfd As New SaveFileDialog

        sfd.ShowDialog()

        If sfd.FileName Is Nothing Then Return

        Dim transform As Transform = surface.LayoutTransform

        surface.LayoutTransform = Nothing

        Dim size As Size = New Size(surface.Width, surface.Height)

        surface.Measure(size)

        surface.Arrange(New Rect(size))

        Dim renderBitmap As RenderTargetBitmap = New RenderTargetBitmap(CInt(size.Width), CInt(size.Height), 96.0R, 96.0R, PixelFormats.Pbgra32)

        renderBitmap.Render(surface)



        Using outStream As FileStream = New FileStream(sfd.FileName & ".png", FileMode.Create)

            Dim encoder As PngBitmapEncoder = New PngBitmapEncoder()

            encoder.Frames.Add(BitmapFrame.Create(renderBitmap))

            encoder.Save(outStream)

        End Using


        surface.LayoutTransform = transform

        Canvas.SetLeft(drawingcanvas, 401)

        Canvas.SetTop(drawingcanvas, 401)

    End Sub

    Private Sub grad1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles grad1.MouseDown
        grad1.Fill = New SolidColorBrush(Color.FromRgb(r.Value, g.Value, b.Value))
        c1 = (Color.FromRgb(r.Value, g.Value, b.Value))
        c2 = (Color.FromRgb(r.Value, g.Value, b.Value))
    End Sub

    Private Sub grad2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles grad2.MouseDown
        grad2.Fill = New SolidColorBrush(Color.FromRgb(r.Value, g.Value, b.Value))
    End Sub
End Class
