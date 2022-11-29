<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(199, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(448, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RUMURUTI LEVEL 5 HOSPITAL DRUG DISPENSING SYSTEM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "EMAIL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PHARMACID"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(306, 71)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(330, 150)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.TextBox2.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(24, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 42)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "REQUEST"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Blue
        Me.Button3.Location = New System.Drawing.Point(24, 285)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 37)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "INVOICE"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(202, 217)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "CLEAR"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(609, 403)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "BACK"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(152, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(544, 270)
        Me.Panel1.TabIndex = 14
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "PHARMACIST PAGE"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ImageList1 As ImageList
End Class
