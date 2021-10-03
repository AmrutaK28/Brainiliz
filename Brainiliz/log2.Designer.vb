<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class log2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(log2))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel1.Location = New System.Drawing.Point(159, 410)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(201, 39)
        Me.Panel1.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(-1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Create Account"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.Highlight
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox5.Location = New System.Drawing.Point(123, 395)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(278, 54)
        Me.TextBox5.TabIndex = 21
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox3.Location = New System.Drawing.Point(13, 11)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(254, 33)
        Me.TextBox3.TabIndex = 13
        Me.TextBox3.Text = "password"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 40.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(148, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 64)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Brainiliz"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(13, 11)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(254, 33)
        Me.TextBox2.TabIndex = 11
        Me.TextBox2.Text = "username"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox6.Location = New System.Drawing.Point(13, 11)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(254, 33)
        Me.TextBox6.TabIndex = 17
        Me.TextBox6.Text = "confirm password"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.Controls.Add(Me.TextBox6)
        Me.Panel4.Location = New System.Drawing.Point(123, 285)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(278, 54)
        Me.Panel4.TabIndex = 24
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.TextBox3)
        Me.Panel3.Location = New System.Drawing.Point(123, 202)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(278, 54)
        Me.Panel3.TabIndex = 25
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Location = New System.Drawing.Point(123, 116)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(278, 54)
        Me.Panel2.TabIndex = 23
        '
        'log2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(525, 466)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "log2"
        Me.Text = "log2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
End Class
