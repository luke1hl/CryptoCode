<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Engima
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
        Me.Alphabet = New System.Windows.Forms.TextBox()
        Me.Mixedalphabet1 = New System.Windows.Forms.TextBox()
        Me.Mixedalphabet2 = New System.Windows.Forms.TextBox()
        Me.Typedchar = New System.Windows.Forms.TextBox()
        Me.Cypherbox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.textdisplay = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Alphabet
        '
        Me.Alphabet.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alphabet.Location = New System.Drawing.Point(26, 12)
        Me.Alphabet.Name = "Alphabet"
        Me.Alphabet.ReadOnly = True
        Me.Alphabet.Size = New System.Drawing.Size(948, 34)
        Me.Alphabet.TabIndex = 0
        Me.Alphabet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Mixedalphabet1
        '
        Me.Mixedalphabet1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mixedalphabet1.Location = New System.Drawing.Point(26, 52)
        Me.Mixedalphabet1.Name = "Mixedalphabet1"
        Me.Mixedalphabet1.ReadOnly = True
        Me.Mixedalphabet1.Size = New System.Drawing.Size(948, 34)
        Me.Mixedalphabet1.TabIndex = 1
        Me.Mixedalphabet1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Mixedalphabet2
        '
        Me.Mixedalphabet2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mixedalphabet2.Location = New System.Drawing.Point(26, 92)
        Me.Mixedalphabet2.Name = "Mixedalphabet2"
        Me.Mixedalphabet2.ReadOnly = True
        Me.Mixedalphabet2.Size = New System.Drawing.Size(948, 34)
        Me.Mixedalphabet2.TabIndex = 2
        Me.Mixedalphabet2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Typedchar
        '
        Me.Typedchar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Typedchar.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Typedchar.ForeColor = System.Drawing.Color.Yellow
        Me.Typedchar.Location = New System.Drawing.Point(341, 147)
        Me.Typedchar.Name = "Typedchar"
        Me.Typedchar.Size = New System.Drawing.Size(100, 98)
        Me.Typedchar.TabIndex = 3
        Me.Typedchar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cypherbox
        '
        Me.Cypherbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Cypherbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cypherbox.ForeColor = System.Drawing.Color.Yellow
        Me.Cypherbox.Location = New System.Drawing.Point(601, 147)
        Me.Cypherbox.Name = "Cypherbox"
        Me.Cypherbox.Size = New System.Drawing.Size(100, 98)
        Me.Cypherbox.TabIndex = 4
        Me.Cypherbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CryptoCode___visual_teaching_aid_v1._1.My.Resources.Resources.yellow_arrow
        Me.PictureBox1.Location = New System.Drawing.Point(475, 157)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'textdisplay
        '
        Me.textdisplay.Location = New System.Drawing.Point(193, 253)
        Me.textdisplay.MaxLength = 500
        Me.textdisplay.Multiline = True
        Me.textdisplay.Name = "textdisplay"
        Me.textdisplay.ReadOnly = True
        Me.textdisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textdisplay.Size = New System.Drawing.Size(628, 244)
        Me.textdisplay.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(875, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 61)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "E/D"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(899, 447)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 50)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(26, 447)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 50)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "home"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Engima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(986, 509)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.textdisplay)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Cypherbox)
        Me.Controls.Add(Me.Typedchar)
        Me.Controls.Add(Me.Mixedalphabet2)
        Me.Controls.Add(Me.Mixedalphabet1)
        Me.Controls.Add(Me.Alphabet)
        Me.Name = "Engima"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Engima"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Alphabet As TextBox
    Friend WithEvents Mixedalphabet1 As TextBox
    Friend WithEvents Mixedalphabet2 As TextBox
    Friend WithEvents Typedchar As TextBox
    Friend WithEvents Cypherbox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents textdisplay As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
