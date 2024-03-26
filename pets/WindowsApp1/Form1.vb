Public Class Form1
    Dim breed As Integer
    Dim color As Integer
    Dim pattern As Integer
    Dim weight As Integer
    Dim age As Integer
    Dim t As Integer
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chihuahuaCheckBox.CheckedChanged
        If chihuahuaCheckBox.Checked = True Then
            TextBox1.Text = chihuahuaCheckBox.Text
            germanshepardCheckBox.Checked = False
            frenchbulldogCheckBox.Checked = False
            goldenretrieverCheckBox.Checked = False
            breed = 500
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles germanshepardCheckBox.CheckedChanged
        If germanshepardCheckBox.Checked = True Then
            TextBox1.Text = germanshepardCheckBox.Text
            frenchbulldogCheckBox.Checked = False
            chihuahuaCheckBox.Checked = False
            goldenretrieverCheckBox.Checked = False
            breed = 600
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles frenchbulldogCheckBox.CheckedChanged
        If frenchbulldogCheckBox.Checked = True Then
            TextBox1.Text = frenchbulldogCheckBox.Text
            germanshepardCheckBox.Checked = False
            chihuahuaCheckBox.Checked = False
            goldenretrieverCheckBox.Checked = False
            breed = 550
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles goldenretrieverCheckBox.CheckedChanged
        If goldenretrieverCheckBox.Checked = True Then
            TextBox1.Text = goldenretrieverCheckBox.Text
            germanshepardCheckBox.Checked = False
            chihuahuaCheckBox.Checked = False
            frenchbulldogCheckBox.Checked = False
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
            spottedCheckBox.Checked = False
            bicolorCheckBox.Checked = False
            tricolorCheckBox.Checked = False
            pattern = 400
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles spottedCheckBox.CheckedChanged
        If spottedCheckBox.Checked = True Then
            TextBox3.Text = spottedCheckBox.Text
            solidCheckBox.Checked = False
            bicolorCheckBox.Checked = False
            tricolorCheckBox.Checked = False
            pattern = 100
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles bicolorCheckBox.CheckedChanged
        If bicolorCheckBox.Checked = True Then
            TextBox3.Text = bicolorCheckBox.Text
            spottedCheckBox.Checked = False
            solidCheckBox.Checked = False
            tricolorCheckBox.Checked = False
            pattern = 200
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles tricolorCheckBox.CheckedChanged
        If tricolorCheckBox.Checked = True Then
            TextBox3.Text = tricolorCheckBox.Text
            spottedCheckBox.Checked = False
            bicolorCheckBox.Checked = False
            solidCheckBox.Checked = False
            pattern = 300
        End If
    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1to10.CheckedChanged
        If CheckBox1to10.Checked = True Then
            TextBox4.Text = CheckBox1to10.Text
            CheckBox10to40.Checked = False
            CheckBox40to70.Checked = False
            CheckBox70plus.Checked = False
            weight = 400
        End If
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10to40.CheckedChanged
        If CheckBox10to40.Checked = True Then
            TextBox4.Text = CheckBox10to40.Text
            CheckBox1to10.Checked = False
            CheckBox40to70.Checked = False
            CheckBox70plus.Checked = False
            weight = 300
        End If
    End Sub

    Private Sub CheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox40to70.CheckedChanged
        If CheckBox40to70.Checked = True Then
            TextBox4.Text = CheckBox40to70.Text
            CheckBox10to40.Checked = False
            CheckBox1to10.Checked = False
            CheckBox70plus.Checked = False
            weight = 200
        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox70plus.CheckedChanged
        If CheckBox70plus.Checked = True Then
            TextBox4.Text = CheckBox70plus.Text
            CheckBox10to40.Checked = False
            CheckBox40to70.Checked = False
            CheckBox1to10.Checked = False
            weight = 100
        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs) Handles puppyCheckBox.CheckedChanged
        If puppyCheckBox.Checked = True Then
            TextBox5.Text = puppyCheckBox.Text
            youngCheckBox.Checked = False
            adultCheckBox.Checked = False
            seniorCheckBox.Checked = False
            age = 400
        End If
    End Sub

    Private Sub CheckBox18_CheckedChanged(sender As Object, e As EventArgs) Handles youngCheckBox.CheckedChanged
        If youngCheckBox.Checked = True Then
            TextBox5.Text = youngCheckBox.Text
            puppyCheckBox.Checked = False
            adultCheckBox.Checked = False
            seniorCheckBox.Checked = False
            age = 300
        End If
    End Sub

    Private Sub CheckBox19_CheckedChanged(sender As Object, e As EventArgs) Handles adultCheckBox.CheckedChanged
        If adultCheckBox.Checked = True Then
            TextBox5.Text = adultCheckBox.Text
            youngCheckBox.Checked = False
            puppyCheckBox.Checked = False
            seniorCheckBox.Checked = False
            age = 200
        End If
    End Sub

    Private Sub CheckBox20_CheckedChanged(sender As Object, e As EventArgs) Handles seniorCheckBox.CheckedChanged
        If seniorCheckBox.Checked = True Then
            TextBox5.Text = seniorCheckBox.Text
            youngCheckBox.Checked = False
            adultCheckBox.Checked = False
            puppyCheckBox.Checked = False
            age = 100
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        t = breed + color + pattern + weight + age
        TextBox6.Text = t
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label12.Visible = True
        If chihuahuaCheckBox.Checked And blackCheckBox.Checked And solidCheckBox.Checked And CheckBox1to10.Checked And puppyCheckBox.Checked = True Then
            'PictureBox1.Image = Image.FromFile("C:\")
            UserControl1.Visible = True
            Label12.Visible = False
        End If
        If chihuahuaCheckBox.Checked And brownCheckBox.Checked And solidCheckBox.Checked And CheckBox1to10.Checked And youngCheckBox.Checked = True Then
            'PictureBox1.Image = Image.FromFile("C:\")
            UserControl1.Visible = True
            Label12.Visible = False
        End If
        If germanshepardCheckBox.Checked And brownCheckBox.Checked And bicolorCheckBox.Checked And CheckBox70plus.Checked And adultCheckBox.Checked = True Then
            'PictureBox1.Image = Image.FromFile("C:\")
            UserControl1.Visible = True
            Label12.Visible = False
        End If
        If frenchbulldogCheckBox.Checked And whiteCheckBox.Checked And spottedCheckBox.Checked And CheckBox10to40.Checked And youngCheckBox.Checked = True Then
            'PictureBox1.Image = Image.FromFile("C:\")
            UserControl1.Visible = True
            Label12.Visible = False
        End If
        If goldenretrieverCheckBox.Checked And whiteCheckBox.Checked And solidCheckBox.Checked And CheckBox40to70.Checked And puppyCheckBox.Checked = True Then
            'PictureBox1.Image = Image.FromFile("C:\")
            UserControl1.Visible = True
            Label12.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
