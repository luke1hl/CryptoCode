<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ceaserloader
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
        Me.textdisplay = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.cyphernumber = New System.Windows.Forms.Label()
        Me.Minus = New System.Windows.Forms.Label()
        Me.plus = New System.Windows.Forms.Label()
        Me.save = New System.Windows.Forms.Button()
        Me.Ceaserpanel = New System.Windows.Forms.Panel()
        Me.vernampanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VernamCypher = New System.Windows.Forms.TextBox()
        Me.frequency = New System.Windows.Forms.ListBox()
        Me.percentage = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.enigmade = New System.Windows.Forms.Button()
        Me.Typedchar = New System.Windows.Forms.TextBox()
        Me.Cypherbox = New System.Windows.Forms.TextBox()
        Me.Ceaserpanel.SuspendLayout()
        Me.vernampanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'textdisplay
        '
        Me.textdisplay.Location = New System.Drawing.Point(36, 32)
        Me.textdisplay.MaxLength = 500
        Me.textdisplay.Multiline = True
        Me.textdisplay.Name = "textdisplay"
        Me.textdisplay.ReadOnly = True
        Me.textdisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textdisplay.Size = New System.Drawing.Size(596, 367)
        Me.textdisplay.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "txt files (*.txt)|*.txt"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "txt files (*.txt)|*.txt"
        '
        'cyphernumber
        '
        Me.cyphernumber.AutoSize = True
        Me.cyphernumber.BackColor = System.Drawing.Color.White
        Me.cyphernumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cyphernumber.Location = New System.Drawing.Point(47, 0)
        Me.cyphernumber.Name = "cyphernumber"
        Me.cyphernumber.Size = New System.Drawing.Size(33, 36)
        Me.cyphernumber.TabIndex = 1
        Me.cyphernumber.Text = "0"
        '
        'Minus
        '
        Me.Minus.AutoSize = True
        Me.Minus.BackColor = System.Drawing.Color.White
        Me.Minus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minus.Location = New System.Drawing.Point(16, 53)
        Me.Minus.Name = "Minus"
        Me.Minus.Size = New System.Drawing.Size(22, 29)
        Me.Minus.TabIndex = 2
        Me.Minus.Text = "-"
        '
        'plus
        '
        Me.plus.AutoSize = True
        Me.plus.BackColor = System.Drawing.Color.White
        Me.plus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plus.Location = New System.Drawing.Point(104, 53)
        Me.plus.Name = "plus"
        Me.plus.Size = New System.Drawing.Size(28, 29)
        Me.plus.TabIndex = 3
        Me.plus.Text = "+"
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(653, 345)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(200, 54)
        Me.save.TabIndex = 4
        Me.save.Text = "Save File"
        Me.save.UseVisualStyleBackColor = True
        '
        'Ceaserpanel
        '
        Me.Ceaserpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Ceaserpanel.Controls.Add(Me.cyphernumber)
        Me.Ceaserpanel.Controls.Add(Me.Minus)
        Me.Ceaserpanel.Controls.Add(Me.plus)
        Me.Ceaserpanel.Location = New System.Drawing.Point(653, 32)
        Me.Ceaserpanel.Name = "Ceaserpanel"
        Me.Ceaserpanel.Size = New System.Drawing.Size(135, 99)
        Me.Ceaserpanel.TabIndex = 5
        '
        'vernampanel
        '
        Me.vernampanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.vernampanel.Controls.Add(Me.Label1)
        Me.vernampanel.Controls.Add(Me.VernamCypher)
        Me.vernampanel.Location = New System.Drawing.Point(794, 31)
        Me.vernampanel.Name = "vernampanel"
        Me.vernampanel.Size = New System.Drawing.Size(200, 100)
        Me.vernampanel.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Input cypher"
        '
        'VernamCypher
        '
        Me.VernamCypher.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VernamCypher.Location = New System.Drawing.Point(3, 36)
        Me.VernamCypher.Name = "VernamCypher"
        Me.VernamCypher.Size = New System.Drawing.Size(194, 38)
        Me.VernamCypher.TabIndex = 0
        '
        'frequency
        '
        Me.frequency.FormattingEnabled = True
        Me.frequency.ItemHeight = 16
        Me.frequency.Location = New System.Drawing.Point(653, 137)
        Me.frequency.Name = "frequency"
        Me.frequency.Size = New System.Drawing.Size(177, 196)
        Me.frequency.TabIndex = 8
        '
        'percentage
        '
        Me.percentage.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.percentage.ForeColor = System.Drawing.Color.Fuchsia
        Me.percentage.Location = New System.Drawing.Point(36, 415)
        Me.percentage.Maximum = 1000
        Me.percentage.Name = "percentage"
        Me.percentage.Size = New System.Drawing.Size(596, 23)
        Me.percentage.Step = 1
        Me.percentage.TabIndex = 9
        Me.percentage.Visible = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(916, 377)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 61)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        '
        'enigmade
        '
        Me.enigmade.Location = New System.Drawing.Point(847, 161)
        Me.enigmade.Name = "enigmade"
        Me.enigmade.Size = New System.Drawing.Size(116, 73)
        Me.enigmade.TabIndex = 11
        Me.enigmade.Text = "Push to encrypt/decrypt"
        Me.enigmade.UseVisualStyleBackColor = True
        '
        'Typedchar
        '
        Me.Typedchar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Typedchar.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Typedchar.ForeColor = System.Drawing.Color.Yellow
        Me.Typedchar.Location = New System.Drawing.Point(1029, 240)
        Me.Typedchar.Name = "Typedchar"
        Me.Typedchar.Size = New System.Drawing.Size(32, 98)
        Me.Typedchar.TabIndex = 12
        Me.Typedchar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cypherbox
        '
        Me.Cypherbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Cypherbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cypherbox.ForeColor = System.Drawing.Color.Yellow
        Me.Cypherbox.Location = New System.Drawing.Point(1019, 161)
        Me.Cypherbox.Name = "Cypherbox"
        Me.Cypherbox.Size = New System.Drawing.Size(10, 98)
        Me.Cypherbox.TabIndex = 13
        Me.Cypherbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Ceaserloader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1017, 450)
        Me.Controls.Add(Me.Cypherbox)
        Me.Controls.Add(Me.Typedchar)
        Me.Controls.Add(Me.enigmade)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.percentage)
        Me.Controls.Add(Me.frequency)
        Me.Controls.Add(Me.vernampanel)
        Me.Controls.Add(Me.Ceaserpanel)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.textdisplay)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ceaserloader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ceaserloader"
        Me.Ceaserpanel.ResumeLayout(False)
        Me.Ceaserpanel.PerformLayout()
        Me.vernampanel.ResumeLayout(False)
        Me.vernampanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textdisplay As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents cyphernumber As Label
    Friend WithEvents Minus As Label
    Friend WithEvents plus As Label
    Friend WithEvents save As Button
    Friend WithEvents Ceaserpanel As Panel
    Friend WithEvents vernampanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents VernamCypher As TextBox
    Friend WithEvents frequency As ListBox
    Friend WithEvents percentage As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer3 As Timer
    Friend WithEvents enigmade As Button
    Friend WithEvents Typedchar As TextBox
    Friend WithEvents Cypherbox As TextBox
End Class
