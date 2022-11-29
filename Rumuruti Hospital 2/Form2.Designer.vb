<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(102, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(230, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "MANAGE USERS"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(292, 132)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(407, 306)
        Me.Panel1.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Yellow
        Me.Button4.Location = New System.Drawing.Point(164, 190)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 29)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "ORDER"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(126, 262)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(172, 29)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "EXIT"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.Location = New System.Drawing.Point(164, 117)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 29)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "STOCK"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(107, 174)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(179, 27)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ADMIN ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(260, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(361, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "RUMURUTI LEVEL 5 HOSPITAL"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Rumuruti_Hospital_2.My.Resources.Resources.Pharmac_logo1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 131)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form2"
        Me.Text = "ADMIN"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
