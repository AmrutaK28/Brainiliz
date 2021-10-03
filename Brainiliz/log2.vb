Public Class log2
    Private Sub log2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        If TextBox2.Text = "username" Then
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        If TextBox3.Text = "password" Then
            TextBox3.Text = ""
        End If
        TextBox3.PasswordChar = "."
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox6_Click(sender As Object, e As EventArgs) Handles TextBox6.Click
        If TextBox6.Text = "confirm password" Then
            TextBox6.Text = ""
        End If
        TextBox6.PasswordChar = "."
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If TextBox3.Text = TextBox6.Text Then
            MsgBox("Created account sucessfully", MsgBoxStyle.Information)
            'Form2.Show()
        Else
            MsgBox("Please Enter same password !!", MsgBoxStyle.Exclamation)
            TextBox3.Text = ""
            TextBox6.Text = ""
        End If

    End Sub

    Private Sub TextBox5_Click(sender As Object, e As EventArgs) Handles TextBox5.Click
        If TextBox3.Text = TextBox6.Text Then
            MsgBox("Created account sucessfully", MsgBoxStyle.Information)
            'Form2.Show()
        Else
            MsgBox("Please Enter same password !!", MsgBoxStyle.Exclamation)
            TextBox3.Text = ""
            TextBox6.Text = ""
        End If

    End Sub
End Class