Public Class riddle

    Dim ex As String
    Dim id As Integer = 0
    Dim que() As String = {"What get wetter but it dries", "A Government by people"}
    Dim ans() As String = {"Towel", "Democracy"}
    Public Sub expression()
        ex = que(id)
    End Sub
    Public Sub timer_st()
        Timer1.Stop()
        Timer2.Stop()
    End Sub
    Public Sub starts()
        Timer1.Start()
        Timer2.Start()
    End Sub
    Private Sub riddle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        expression()
        starts()
        Label2.Text = ex
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = ans(id) Then
            MsgBox("Correct answer")
        Else
            MsgBox("Wrong answer")
            MsgBox("Correct anser is :" + ans(id))
        End If

        Button2.Visible = True
        Button3.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        id = id + 1
        If id >= que.Length Then
            id = 0
        End If
        expression()
        Button1.Visible = False
        Button3.Visible = False
        Label3.Visible = True
        Label3.Text = 0
        Label4.Text = "0 0 : 0"
        starts()
        Label2.Text = ex
        TextBox1.ReadOnly = False
        TextBox1.Text = ""
        Button2.Visible = False
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Label3.Text + 1
        If Label3.Text > 9 Then
            Label3.Visible = False
            Label4.Text = "0 0 : 1 0"
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        MsgBox("Your time is up !!")
        Button1.Visible = True
        TextBox1.ReadOnly = True
        timer_st()
    End Sub
End Class