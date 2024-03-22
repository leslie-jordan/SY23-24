Public Class Form2
    Dim breed As Integer
    Dim color As Integer
    Dim pattern As Integer
    Dim weight As Integer
    Dim age As Integer
    Dim t As Integer
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles mainecoonCheckBox.CheckedChanged
        If mainecoonCheckBox.Checked = True Then
            TextBox1.Text = mainecoonCheckBox.Text
            persianCheckBox.Checked = False
            ragdollCheckBox.Checked = False
            himalayanCheckBox.Checked = False
            breed = 500
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles persianCheckBox.CheckedChanged
        If persianCheckBox.Checked = True Then
            TextBox1.Text = persianCheckBox.Text
            ragdollCheckBox.Checked = False
            mainecoonCheckBox.Checked = False
            himalayanCheckBox.Checked = False
            breed = 600
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles ragdollCheckBox.CheckedChanged
        If ragdollCheckBox.Checked = True Then
            TextBox1.Text = ragdollCheckBox.Text
            persianCheckBox.Checked = False
            mainecoonCheckBox.Checked = False
            himalayanCheckBox.Checked = False
            breed = 550
        End If
    End Sub
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles himalayanCheckBox.CheckedChanged
        If himalayanCheckBox.Checked = True Then
            TextBox1.Text = himalayanCheckBox.Text
            persianCheckBox.Checked = False
            mainecoonCheckBox.Checked = False
            ragdollCheckBox.Checked = False
            breed = 700
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles blackCheckBox.CheckedChanged
        If blackCheckBox.Checked = True Then
            TextBox2.Text = blackCheckBox.Text
            greyCheckBox.Checked = False
            whiteCheckBox.Checked = False
            brownCheckBox.Checked = False
            color = 100
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles greyCheckBox.CheckedChanged
        If greyCheckBox.Checked = True Then
            TextBox2.Text = greyCheckBox.Text
            blackCheckBox.Checked = False
            whiteCheckBox.Checked = False
            brownCheckBox.Checked = False
            color = 150
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles whiteCheckBox.CheckedChanged
        If whiteCheckBox.Checked = True Then
            TextBox2.Text = whiteCheckBox.Text
            greyCheckBox.Checked = False
            blackCheckBox.Checked = False
            brownCheckBox.Checked = False
            color = 300
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles brownCheckBox.CheckedChanged
        If brownCheckBox.Checked = True Then
            TextBox2.Text = brownCheckBox.Text
            greyCheckBox.Checked = False
            whiteCheckBox.Checked = False
            blackCheckBox.Checked = False
            color = 200
        End If
    End Sub
    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles solidCheckBox.CheckedChanged
        If solidCheckBox.Checked = True Then
            TextBox3.Text = solidCheckBox.Text
            stripedCheckBox.Checked = False
            bicolorCheckBox.Checked = False
            tricolorCheckBox.Checked = False
            pattern = 400
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles stripedCheckBox.CheckedChanged
        If stripedCheckBox.Checked = True Then
            TextBox3.Text = stripedCheckBox.Text
            solidCheckBox.Checked = False
            bicolorCheckBox.Checked = False
            tricolorCheckBox.Checked = False
            pattern = 100
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles bicolorCheckBox.CheckedChanged
        If bicolorCheckBox.Checked = True Then
            TextBox3.Text = bicolorCheckBox.Text
            stripedCheckBox.Checked = False
            solidCheckBox.Checked = False
            tricolorCheckBox.Checked = False
            pattern = 200
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles tricolorCheckBox.CheckedChanged
        If tricolorCheckBox.Checked = True Then
            TextBox3.Text = tricolorCheckBox.Text
            stripedCheckBox.Checked = False
            bicolorCheckBox.Checked = False
            solidCheckBox.Checked = False
            pattern = 300
        End If
    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1to5.CheckedChanged
        If CheckBox1to5.Checked = True Then
            TextBox4.Text = CheckBox1to5.Text
            CheckBox5to10.Checked = False
            CheckBox10to15.Checked = False
            CheckBox15to20.Checked = False
            weight = 400
        End If
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5to10.CheckedChanged
        If CheckBox5to10.Checked = True Then
            TextBox4.Text = CheckBox5to10.Text
            CheckBox1to5.Checked = False
            CheckBox10to15.Checked = False
            CheckBox15to20.Checked = False
            weight = 300
        End If
    End Sub

    Private Sub CheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10to15.CheckedChanged
        If CheckBox10to15.Checked = True Then
            TextBox4.Text = CheckBox10to15.Text
            CheckBox5to10.Checked = False
            CheckBox1to5.Checked = False
            CheckBox15to20.Checked = False
            weight = 200
        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox15to20.CheckedChanged
        If CheckBox15to20.Checked = True Then
            TextBox4.Text = CheckBox15to20.Text
            CheckBox5to10.Checked = False
            CheckBox10to15.Checked = False
            CheckBox1to5.Checked = False
            weight = 100
        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs) Handles kittenCheckBox.CheckedChanged
        If kittenCheckBox.Checked = True Then
            TextBox5.Text = kittenCheckBox.Text
            youngCheckBox.Checked = False
            adultCheckBox.Checked = False
            seniorCheckBox.Checked = False
            age = 400
        End If
    End Sub

    Private Sub CheckBox18_CheckedChanged(sender As Object, e As EventArgs) Handles youngCheckBox.CheckedChanged
        If youngCheckBox.Checked = True Then
            TextBox5.Text = youngCheckBox.Text
            kittenCheckBox.Checked = False
            adultCheckBox.Checked = False
            seniorCheckBox.Checked = False
            age = 300
        End If
    End Sub

    Private Sub CheckBox19_CheckedChanged(sender As Object, e As EventArgs) Handles adultCheckBox.CheckedChanged
        If adultCheckBox.Checked = True Then
            TextBox5.Text = adultCheckBox.Text
            youngCheckBox.Checked = False
            kittenCheckBox.Checked = False
            seniorCheckBox.Checked = False
            age = 200
        End If
    End Sub

    Private Sub CheckBox20_CheckedChanged(sender As Object, e As EventArgs) Handles seniorCheckBox.CheckedChanged
        If seniorCheckBox.Checked = True Then
            TextBox5.Text = seniorCheckBox.Text
            youngCheckBox.Checked = False
            adultCheckBox.Checked = False
            kittenCheckBox.Checked = False
            age = 100
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        t = breed + color + pattern + weight + age
        TextBox6.Text = t
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UserControl1.Visible = True
        If mainecoonCheckBox.Checked And blackCheckBox.Checked = True Then
            PictureBox1.Image = Image.FromFile("C:\2.jpg")
        End If
        If persianCheckBox.Checked And greyCheckBox.Checked = True Then
            PictureBox1.Image = Image.FromFile("C:\2.jpg")
        End If
        If ragdollCheckBox.Checked And whiteCheckBox.Checked = True Then
            PictureBox1.Image = Image.FromFile("C:\Users\lajor965\Downloads\ragdoll-before-you-buy.jpg")
        End If
        If himalayanCheckBox.Checked And brownCheckBox.Checked = True Then
            PictureBox1.Image = Image.FromFile("C:\2.jpg")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class