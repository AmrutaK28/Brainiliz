Public Class Menus
    Private Sub Menus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        word_shuff.Show()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        math.Show()
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        digit_shuff.Show()
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        mem.Show()
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        riddle.Show()
    End Sub


    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        MsgBox("settings")
    End Sub

End Class