Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.Text = CheckBox1.Text
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TextBox1.Text = CheckBox2.Text
            CheckBox1.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            TextBox1.Text = CheckBox3.Text
            CheckBox2.Checked = False
            CheckBox1.Checked = False
            CheckBox4.Checked = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            TextBox1.Text = CheckBox4.Text
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            TextBox2.Text = CheckBox5.Text
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            TextBox2.Text = CheckBox6.Text
            CheckBox5.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            TextBox2.Text = CheckBox7.Text
            CheckBox6.Checked = False
            CheckBox5.Checked = False
            CheckBox8.Checked = False
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            TextBox2.Text = CheckBox8.Text
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox5.Checked = False
        End If
    End Sub
    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked = True Then
            TextBox3.Text = CheckBox9.Text
            CheckBox10.Checked = False
            CheckBox11.Checked = False
            CheckBox12.Checked = False
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked = True Then
            TextBox3.Text = CheckBox10.Text
            CheckBox9.Checked = False
            CheckBox11.Checked = False
            CheckBox12.Checked = False
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked = True Then
            TextBox3.Text = CheckBox11.Text
            CheckBox10.Checked = False
            CheckBox9.Checked = False
            CheckBox12.Checked = False
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.Checked = True Then
            TextBox3.Text = CheckBox12.Text
            CheckBox10.Checked = False
            CheckBox11.Checked = False
            CheckBox9.Checked = False
        End If
    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.Checked = True Then
            TextBox4.Text = CheckBox13.Text
            CheckBox14.Checked = False
            CheckBox15.Checked = False
            CheckBox16.Checked = False
        End If
    End Sub
End Class
