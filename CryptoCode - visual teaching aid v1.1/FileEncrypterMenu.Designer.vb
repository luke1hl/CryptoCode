<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileEncrypterMenu
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
        Me.ceaser = New System.Windows.Forms.Button()
        Me.vernam = New System.Windows.Forms.Button()
        Me.Title2 = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.PictureBox()
        Me.Encrypt = New System.Windows.Forms.Button()
        Me.Decrypt = New System.Windows.Forms.Button()
        Me.ok = New System.Windows.Forms.Button()
        Me.Enigma = New System.Windows.Forms.Button()
        CType(Me.Title2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Title, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ceaser
        '
        Me.ceaser.BackColor = System.Drawing.Color.MediumBlue
        Me.ceaser.ForeColor = System.Drawing.Color.White
        Me.ceaser.Location = New System.Drawing.Point(48, 127)
        Me.ceaser.Name = "ceaser"
        Me.ceaser.Size = New System.Drawing.Size(108, 53)
        Me.ceaser.TabIndex = 1
        Me.ceaser.Text = "Ceasercypher"
        Me.ceaser.UseVisualStyleBackColor = False
        '
        'vernam
        '
        Me.vernam.BackColor = System.Drawing.Color.MediumBlue
        Me.vernam.ForeColor = System.Drawing.Color.White
        Me.vernam.Location = New System.Drawing.Point(188, 127)
        Me.vernam.Name = "vernam"
        Me.vernam.Size = New System.Drawing.Size(108, 53)
        Me.vernam.TabIndex = 2
        Me.vernam.Text = "Vernam"
        Me.vernam.UseVisualStyleBackColor = False
        '
        'Title2
        '
        Me.Title2.Image = Global.CryptoCode___visual_teaching_aid_v1._1.My.Resources.Resources.fileslector2
        Me.Title2.Location = New System.Drawing.Point(198, 186)
        Me.Title2.Name = "Title2"
        Me.Title2.Size = New System.Drawing.Size(389, 97)
        Me.Title2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Title2.TabIndex = 3
        Me.Title2.TabStop = False
        '
        'Title
        '
        Me.Title.Image = Global.CryptoCode___visual_teaching_aid_v1._1.My.Resources.Resources.fileslector1
        Me.Title.Location = New System.Drawing.Point(198, 12)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(389, 102)
        Me.Title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Title.TabIndex = 0
        Me.Title.TabStop = False
        '
        'Encrypt
        '
        Me.Encrypt.BackColor = System.Drawing.Color.MediumBlue
        Me.Encrypt.ForeColor = System.Drawing.Color.White
        Me.Encrypt.Location = New System.Drawing.Point(188, 301)
        Me.Encrypt.Name = "Encrypt"
        Me.Encrypt.Size = New System.Drawing.Size(108, 53)
        Me.Encrypt.TabIndex = 4
        Me.Encrypt.Text = "Encrypt"
        Me.Encrypt.UseVisualStyleBackColor = False
        '
        'Decrypt
        '
        Me.Decrypt.BackColor = System.Drawing.Color.MediumBlue
        Me.Decrypt.ForeColor = System.Drawing.Color.White
        Me.Decrypt.Location = New System.Drawing.Point(489, 301)
        Me.Decrypt.Name = "Decrypt"
        Me.Decrypt.Size = New System.Drawing.Size(108, 53)
        Me.Decrypt.TabIndex = 5
        Me.Decrypt.Text = "Decrypt"
        Me.Decrypt.UseVisualStyleBackColor = False
        '
        'ok
        '
        Me.ok.Location = New System.Drawing.Point(370, 388)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(50, 50)
        Me.ok.TabIndex = 6
        Me.ok.Text = "OK"
        Me.ok.UseVisualStyleBackColor = True
        '
        'Enigma
        '
        Me.Enigma.BackColor = System.Drawing.Color.MediumBlue
        Me.Enigma.ForeColor = System.Drawing.Color.White
        Me.Enigma.Location = New System.Drawing.Point(343, 127)
        Me.Enigma.Name = "Enigma"
        Me.Enigma.Size = New System.Drawing.Size(108, 53)
        Me.Enigma.TabIndex = 7
        Me.Enigma.Text = "Enigma"
        Me.Enigma.UseVisualStyleBackColor = False
        '
        'FileEncrypterMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Enigma)
        Me.Controls.Add(Me.ok)
        Me.Controls.Add(Me.Decrypt)
        Me.Controls.Add(Me.Encrypt)
        Me.Controls.Add(Me.Title2)
        Me.Controls.Add(Me.vernam)
        Me.Controls.Add(Me.ceaser)
        Me.Controls.Add(Me.Title)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FileEncrypterMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FileEncrypterMenu"
        CType(Me.Title2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Title, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Title As PictureBox
    Friend WithEvents ceaser As Button
    Friend WithEvents vernam As Button
    Friend WithEvents Title2 As PictureBox
    Friend WithEvents Encrypt As Button
    Friend WithEvents Decrypt As Button
    Friend WithEvents ok As Button
    Friend WithEvents Enigma As Button
End Class
