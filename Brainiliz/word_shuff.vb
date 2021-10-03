Public Class word_shuff
    Dim alph() As String = {"BRAIN", "ACHIEVE", "CLIMB", "ENGINE", "FREEZE", "GATHER", "PAL", "LAUGH", "MIRACLE", "TERROR", "UP", "YOUTH"}
    Dim len As Integer = 0
    Dim ind As Integer = 0
    Dim word As String
    Public Sub str()
        len = alph(ind).Length
        word = alph(ind)
    End Sub

    Public Sub timer_st()
        Timer1.Stop()
        Timer2.Stop()
    End Sub

    Public Sub starts()
        Timer1.Start()
        Timer2.Start()
    End Sub

    Public Sub Len_7()
        Panel1.Visible = True
        Label2.Visible = True
        Label2.Text = word.Chars(3)

        Panel2.Visible = True
        Label6.Visible = True
        Label6.Text = word.Chars(4)

        Panel3.Visible = True
        Label7.Visible = True
        Label7.Text = word.Chars(0)

        Panel4.Visible = True
        Label8.Visible = True
        Label8.Text = word.Chars(6)

        Panel5.Visible = True
        Label9.Visible = True
        Label9.Text = word.Chars(5)

        Panel6.Visible = True
        Label11.Visible = True
        Label11.Text = word.Chars(2)

        Panel7.Visible = True
        Label12.Visible = True
        Label12.Text = word.Chars(1)

    End Sub
    Public Sub Len_6()
        Panel1.Visible = True
        Label2.Visible = True
        Label2.Text = word.Chars(3)

        Panel2.Visible = True
        Label6.Visible = True
        Label6.Text = word.Chars(0)

        Panel3.Visible = True
        Label7.Visible = True
        Label7.Text = word.Chars(4)

        Panel4.Visible = True
        Label8.Visible = True
        Label8.Text = word.Chars(2)

        Panel5.Visible = True
        Label9.Visible = True
        Label9.Text = word.Chars(5)

        Panel6.Visible = True
        Label11.Visible = True
        Label11.Text = word.Chars(1)

        Panel7.Visible = False
        Label12.Visible = False


    End Sub

    Public Sub Len_5()
        Panel1.Visible = True
        Label2.Visible = True
        Label2.Text = word.Chars(1)

        Panel2.Visible = True
        Label6.Visible = True
        Label6.Text = word.Chars(0)

        Panel3.Visible = True
        Label7.Visible = True
        Label7.Text = word.Chars(4)

        Panel4.Visible = True
        Label8.Visible = True
        Label8.Text = word.Chars(2)

        Panel5.Visible = True
        Label9.Visible = True
        Label9.Text = word.Chars(3)

        Panel6.Visible = False
        Label11.Visible = False

        Panel7.Visible = False
        Label12.Visible = False


    End Sub

    Public Sub Len_4()
        Panel1.Visible = True
        Label2.Visible = True
        Label2.Text = word.Chars(1)

        Panel2.Visible = True
        Label6.Visible = True
        Label6.Text = word.Chars(3)

        Panel3.Visible = True
        Label7.Visible = True
        Label7.Text = word.Chars(2)

        Panel4.Visible = True
        Label8.Visible = True
        Label8.Text = word.Chars(0)

        Panel6.Visible = False
        Label11.Visible = False

        Panel5.Visible = False
        Label9.Visible = False

        Panel7.Visible = False
        Label12.Visible = False

    End Sub

    Public Sub Len_3()
        Label6.Visible = True
        Panel2.Visible = True
        Label6.Text = word.Chars(1)

        Label7.Visible = True
        Panel3.Visible = True
        Label7.Text = word.Chars(0)

        Label8.Visible = True
        Panel4.Visible = True
        Label8.Text = word.Chars(2)

        Panel6.Visible = False
        Label11.Visible = False

        Panel1.Visible = False
        Label2.Visible = False

        Panel5.Visible = False
        Label9.Visible = False

        Panel7.Visible = False
        Label12.Visible = False
    End Sub

    Public Sub Len_2()
        Label7.Visible = True
        Panel3.Visible = True
        Label7.Text = word.Chars(1)

        Label8.Visible = True
        Panel4.Visible = True
        Label8.Text = word.Chars(0)

        Panel6.Visible = False
        Label11.Visible = False

        Panel1.Visible = False
        Label2.Visible = False

        Panel2.Visible = False
        Label6.Visible = False

        Panel5.Visible = False
        Label9.Visible = False

        Panel7.Visible = False
        Label12.Visible = False
    End Sub

    Public Sub disable()
        Panel6.Visible = False
        Label11.Visible = False
        Panel1.Visible = False
        Label2.Visible = False
        Panel2.Visible = False
        Label6.Visible = False
        Panel3.Visible = False
        Label7.Visible = False
        Panel4.Visible = False
        Label8.Visible = False
        Panel5.Visible = False
        Label9.Visible = False
        Panel7.Visible = False
        Label12.Visible = False
    End Sub

    Private Sub word_shuff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Str()
        If len = 2 Then
            Len_2()
        ElseIf len = 3 Then
            Len_3()
        ElseIf len = 4 Then
            Len_4()
        ElseIf len = 5 Then
            Len_5()
        ElseIf len = 6 Then
            Len_6()
        Else
            Len_7()
        End If
        starts()
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Label13.Text = ""
    End Sub
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Label11.Visible = False
        Panel6.Visible = False
        Label13.Text &= ""
        Label13.Text &= Label11.Text
        Label13.Text &= ""
        Label13.Show()
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Label2.Visible = False
        Panel1.Visible = False
        Label13.Text &= ""
        Label13.Text &= Label2.Text
        Label13.Text &= ""
        Label13.Show()
    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Label6.Visible = False
        Panel2.Visible = False
        Label13.Text &= ""
        Label13.Text &= Label6.Text
        Label13.Text &= ""
        Label13.Show()
    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Label7.Visible = False
        Panel3.Visible = False
        Label13.Text &= ""
        Label13.Text &= Label7.Text
        Label13.Text &= ""
        Label13.Show()
    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Label8.Visible = False
        Panel4.Visible = False
        Label13.Text &= ""
        Label13.Text &= Label8.Text
        Label13.Text &= ""
        Label13.Show()
    End Sub
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Label9.Visible = False
        Panel5.Visible = False
        Label13.Text &= ""
        Label13.Text &= Label9.Text
        Label13.Text &= ""
        Label13.Show()
    End Sub
    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Label12.Visible = False
        Panel7.Visible = False
        Label13.Text &= ""
        Label13.Text &= Label12.Text
        Label13.Text &= ""
        Label13.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Label13.Text = word Then
            MessageBox.Show("Correct answer", "Result")
            Label15.Text = Label15.Text + 1
        Else
            MessageBox.Show("Wrong answer", "Result")
            MessageBox.Show("Correct anser is :" + alph(ind), "Answer")
        End If

        Button2.Visible = True
        Button3.Visible = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Label3.Text + 1
        If Label3.Text > 9 Then
            Label3.Visible = False
            Label4.Text = "0 0 : 1 0"
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        timer_st()
        MessageBox.Show("Your time is up !!", "Time")
        Button1.Visible = True

        disable()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DialogResult = MsgBox("Do you want to exit ? ", MsgBoxStyle.OkCancel, "Exit")
        If DialogResult = DialogResult.OK Then
            MessageBox.Show("Thanks for playing", "Thank You :)")
            Menus.Show()
        Else
            MessageBox.Show("continue", "Nice Going ")
            Button3.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ind = ind + 1
        If ind >= alph.Count Then
            ind = 0
        End If
        str()
        If len = 2 Then
            Len_2()
        ElseIf len = 3 Then
            Len_3()
        ElseIf len = 4 Then
            Len_4()
        ElseIf len = 5 Then
            Len_5()
        ElseIf len = 6 Then
            Len_6()
        Else
            Len_7()
        End If
        Timer2.Interval = 11000
        Button1.Visible = False
        Button3.Visible = False
        Label3.Visible = True
        Label3.Text = 0
        Label4.Text = "0 0 : 0"

        starts()
        Button2.Visible = False
        Label13.Text = ""
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class