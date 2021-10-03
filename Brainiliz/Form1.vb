Imports System.Drawing.Text
Imports System.Data
Imports System.Data.DataTable
Imports System.Data.OleDb
Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        If TextBox2.Text = "username" Then
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        If TextBox3.Text = "password" Then
            TextBox3.Text = ""
        End If
        TextBox3.PasswordChar = "."

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim len As Integer
        len = TextBox3.Text.Length
        If len < 8 Then
            MsgBox("Please enter big password", MsgBoxStyle.RetryCancel)
            TextBox3.Text = ""
            TextBox3.PasswordChar = "."
        Else
            MsgBox("Logged in sucessfully", MsgBoxStyle.Information)
            Menus.Show()
        End If
        '    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\vb_pro\New folder\Dta.accdb")
        '    Dim cmd As New OleDbCommand("SELECT * from Data where username =@username and password=@password", conn)
        '    cmd.Parameters.Add("@username", OleDbType.VarChar).Value = TextBox2.Text
        '    cmd.Parameters.Add("@password", OleDbType.VarChar).Value = TextBox3.Text

        '    Dim adapter1 As New OleDbDataAdapter(cmd)
        '    Dim table As New DataTable
        '    adapter1.Fill(table)
        '    If table.Rows.Count <= 0 Then
        '        MsgBox("ERROR")
        '    Else
        '        MsgBox("Successful!!!!!")
        '        Menus.Show()
        '    End If
    End Sub


    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Dim len As Integer
        len = TextBox3.Text.Length
        If len < 8 Then
            MsgBox("Please enter big password", MsgBoxStyle.RetryCancel)
            TextBox3.Text = ""
            TextBox3.PasswordChar = "."
        Else
            MsgBox("Logged in sucessfully", MsgBoxStyle.Information)
            Menus.Show()
            'Form1.ActiveForm.Hide()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        log2.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        log2.Show()
    End Sub
End Class
