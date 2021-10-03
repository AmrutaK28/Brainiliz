<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mem
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mem))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(197, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 37)
        Me.Label1.TabIndex = 10
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(177, 330)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(210, 41)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Check"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(157, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 36)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Memory Game"
        '
        'Timer2
        '
        Me.Timer2.Interval = 10000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(143, 183)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 46)
        Me.Panel1.TabIndex = 12
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Silver
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox1.HideSelection = False
        Me.TextBox1.Location = New System.Drawing.Point(37, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(178, 28)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Enter number"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(92, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 26)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "0"
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 1000
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(15, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "0 0 : 0"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Controls.Add(Me.PictureBox6)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Location = New System.Drawing.Point(-6, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(536, 53)
        Me.Panel6.TabIndex = 15
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(500, 12)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox6.TabIndex = 6
        Me.PictureBox6.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(43, 418)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 37)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(421, 417)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 37)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "New"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'mem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(525, 466)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Name = "mem"
        Me.Text = "mem"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
