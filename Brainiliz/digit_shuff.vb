Public Class digit_shuff

    Dim r As New Random()
    Dim no As New ArrayList()
    Public Sub reset()
        Dim rand As Integer
        no.Add("1")
        no.Add("2")
        no.Add("3")
        no.Add("4")
        no.Add("5")
        no.Add("6")
        no.Add("7")
        no.Add("8")
        no.Add("9")
        no.Add("10")
        no.Add("11")
        no.Add("12")
        no.Add("13")
        no.Add("14")
        no.Add("15")

        rand = 0
        rand = r.Next(0, no.Count - 1)
        Button1.Text = no(rand)
        no.Remove(no(rand))

        rand = 0
        rand = r.Next(0, no.Count - 1)
        Button2.Text = no(rand)
        no.Remove(no(rand))

        rand = 0
        rand = r.Next(0, no.Count - 1)
        Button3.Text = no(rand)
        no.Remove(no(rand))

        rand = r.Next(0, no.Count - 1)
        Button4.Text = no(rand)
        no.Remove(no(rand))

        rand = r.Next(0, no.Count - 1)
        Button5.Text = no(rand)
        no.Remove(no(rand))

        rand = 0
        rand = r.Next(0, no.Count - 1)
        Button6.Text = no(rand)
        no.Remove(no(rand))

        rand = 0
        rand = r.Next(0, no.Count - 1)
        Button7.Text = no(rand)
        no.Remove(no(rand))

        rand = 0
        rand = r.Next(0, no.Count - 1)
        Button8.Text = no(rand)
        no.Remove(no(rand))

        rand = 0
        rand = r.Next(0, no.Count - 1)
        Button9.Text = no(rand)
        no.Remove(no(rand))

        rand = 0
        rand = r.Next(0, no.Count - 1)
        Button10.Text = no(rand)
        no.Remove(no(rand))

        rand = 0
        rand = r.Next(0, no.Count - 1)
        Button11.Text = no(rand)
        no.Remove(no(rand))

        rand = 0
        rand = r.Next(0, no.Count - 1)
        Button12.Text = no(rand)
        no.Remove(no(rand))

        rand = 0
        rand = r.Next(0, no.Count - 1)
        Button13.Text = no(rand)
        no.Remove(no(rand))

        rand = 0
        rand = r.Next(0, no.Count - 1)
        Button14.Text = no(rand)
        no.Remove(no(rand))

        rand = 0
        rand = r.Next(0, no.Count - 1)
        Button15.Text = no(rand)
        no.Remove(no(rand))


        Button16.Text = ""




    End Sub

    Private Sub digit_shuff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub

    Public Sub CheckShuffle(ByRef b1 As Button, ByRef b2 As Button)
        If b2.Text = "" Then
            b2.Text = b1.Text
            b1.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckShuffle(Button1, Button2)
        CheckShuffle(Button1, Button5)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckShuffle(Button2, Button1)
        CheckShuffle(Button2, Button6)
        CheckShuffle(Button2, Button3)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CheckShuffle(Button3, Button2)
        CheckShuffle(Button3, Button7)
        CheckShuffle(Button3, Button4)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CheckShuffle(Button4, Button3)
        CheckShuffle(Button4, Button8)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CheckShuffle(Button5, Button1)
        CheckShuffle(Button5, Button6)
        CheckShuffle(Button5, Button9)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CheckShuffle(Button6, Button2)
        CheckShuffle(Button6, Button5)
        CheckShuffle(Button6, Button10)
        CheckShuffle(Button6, Button7)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        CheckShuffle(Button7, Button3)
        CheckShuffle(Button7, Button6)
        CheckShuffle(Button7, Button11)
        CheckShuffle(Button7, Button8)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        CheckShuffle(Button8, Button4)
        CheckShuffle(Button8, Button7)
        CheckShuffle(Button8, Button12)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        CheckShuffle(Button9, Button5)
        CheckShuffle(Button9, Button10)
        CheckShuffle(Button9, Button13)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        CheckShuffle(Button10, Button9)
        CheckShuffle(Button10, Button6)
        CheckShuffle(Button10, Button14)
        CheckShuffle(Button10, Button11)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        CheckShuffle(Button11, Button7)
        CheckShuffle(Button11, Button10)
        CheckShuffle(Button11, Button15)
        CheckShuffle(Button11, Button12)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        CheckShuffle(Button12, Button8)
        CheckShuffle(Button12, Button11)
        CheckShuffle(Button12, Button16)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        CheckShuffle(Button13, Button9)
        CheckShuffle(Button13, Button14)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        CheckShuffle(Button14, Button13)
        CheckShuffle(Button14, Button10)
        CheckShuffle(Button14, Button15)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        CheckShuffle(Button15, Button14)
        CheckShuffle(Button15, Button11)
        CheckShuffle(Button15, Button16)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        CheckShuffle(Button16, Button15)
        CheckShuffle(Button16, Button12)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If Button1.Text = "1" And Button2.Text = "2" And Button3.Text = "3" And Button4.Text = "4" And Button5.Text = "5" And Button6.Text = "6" And Button7.Text = "7" And Button8.Text = "8" And Button9.Text = "9" And Button10.Text = "10" And Button11.Text = "11" And Button12.Text = "12" And Button13.Text = "13" And Button14.Text = "14" And Button15.Text = "15" And Button16.Text = "1 " Then
            MsgBox("You Win!!!!!!", MsgBoxStyle.Information)
        Else
            MsgBox("You Must try again!!!!!!", MsgBoxStyle.Exclamation)
            reset()
        End If

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        reset()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        DialogResult = MsgBox("Do you want to exit ? ", MsgBoxStyle.OkCancel, "Exit")
        If DialogResult = DialogResult.OK Then
            MessageBox.Show("Thanks for playing", "Thank You :)")
            Menus.Show()
        End If
    End Sub
End Class