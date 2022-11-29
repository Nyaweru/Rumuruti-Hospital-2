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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(34, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "MANAGE USERS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(34, 106)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "VIEW STOCK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(34, 199)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "PLACE ORDER"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(55, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(232, 23)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(37, 125)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(186, 23)
        Me.TextBox2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ID"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(55, 255)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "CLEAR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(555, 38)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 10
        Me.MonthCalendar1.TitleBackColor = System.Drawing.Color.Red
        Me.MonthCalendar1.TrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(145, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(448, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "RUMURUTI LEVEL 5 HOSPITAL DRUG DISPENSING SYSTEM"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(298, 321)
        Me.Panel1.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Location = New System.Drawing.Point(307, 113)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 265)
        Me.Panel2.TabIndex = 13
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button5.Location = New System.Drawing.Point(613, 368)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 47)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "BACK"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Name = "Form2"
        Me.Text = "ADMIN PAGE"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button5 As Button
End Class
