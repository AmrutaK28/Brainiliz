Public Class mem
    Dim r As New Random
    Dim i As Integer
    Public str As String = ""
    Sub assign()
        str = r.Next(100000000, 999999999)
    End Sub
    Public Sub tstop()
        Timer2.Stop()
        Timer3.Stop()
    End Sub

    Private Sub mem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Panel1.Visible = False
        TextBox1.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        assign()
        Label1.Text = str
    End Sub
    Public Sub fstop()
        Timer1.Stop()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Visible = False
        Panel1.Visible = True
        TextBox1.Visible = True
        'TextBox1.Text = ""
        fstop()
        Label3.Text = 0
        Timer2.Start()
        'Button1.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If str = TextBox1.Text Then
            MessageBox.Show("correct", "Result")
            TextBox1.Text = "Correct"
        Else
            MessageBox.Show("Incorrect", "Result")
            TextBox1.Text = "Incorrect"
        End If
        Button2.Visible = True
        Button3.Visible = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Button1.Visible = True
        TextBox1.HideSelection = False
        tstop()
        MessageBox.Show("Time Out!! ", "Time")
        'TextBox1.ReadOnly = True
        ' Button1.Visible = True
        'Button2.Visible = True
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Label3.Text = Label3.Text + 1
        If Label3.Text > 9 Then
            Label3.Visible = False
            Label4.Text = "0 0 : 1 0"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Start()
        TextBox1.Text = "Enter number"
        Label3.Visible = True
        Label3.Text = 0
        Label4.Text = "0 0 : 0"
        Timer1.Interval = 6000
        Timer3.Start()
        TextBox1.Visible = False
        Panel1.Visible = False
        Label1.Visible = True
        Button1.Visible = False
        assign()
        Label1.Text = str
        Button2.Visible = False
        Button3.Visible = False
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

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Text = ""
        TextBox1.HideSelection = False
    End Sub
End Class