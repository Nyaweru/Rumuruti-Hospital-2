<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(145, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.Location = New System.Drawing.Point(346, 215)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 29)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "UserID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Role"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(104, 200)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(488, 247)
        Me.Panel1.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(145, 154)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(272, 27)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(145, 91)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(272, 27)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(148, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(269, 27)
        Me.TextBox1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(249, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(243, 161)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(188, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(367, 29)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = " RUMURUTI LEVEL 5 HOSPITAL"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(603, 94)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(185, 29)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "ADMIN"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(603, 165)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(185, 29)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "PHARMACIST"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Rumuruti_Hospital_2.My.Resources.Resources.Pharmac_logo2
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(-7, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(189, 146)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
