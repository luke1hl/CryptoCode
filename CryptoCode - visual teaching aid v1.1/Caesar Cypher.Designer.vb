<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Caesar_Cypher
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
        Me.Cypher = New System.Windows.Forms.TrackBar()
        Me.refresha = New System.Windows.Forms.Timer(Me.components)
        Me.Slidernumber = New System.Windows.Forms.Label()
        Me.Plaintextbox = New System.Windows.Forms.TextBox()
        Me.Encryptedtextbox = New System.Windows.Forms.TextBox()
        Me.plainbet = New System.Windows.Forms.TextBox()
        Me.cypherbet = New System.Windows.Forms.TextBox()
        Me.Title = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Menubutton = New System.Windows.Forms.Button()
        CType(Me.Cypher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Title, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cypher
        '
        Me.Cypher.BackColor = System.Drawing.Color.White
        Me.Cypher.Location = New System.Drawing.Point(140, 193)
        Me.Cypher.Maximum = 20
        Me.Cypher.Minimum = -20
        Me.Cypher.Name = "Cypher"
        Me.Cypher.Size = New System.Drawing.Size(539, 56)
        Me.Cypher.TabIndex = 0
        '
        'refresh
        '
        Me.refresha.Enabled = True
        Me.refresha.Interval = 10
        '
        'Slidernumber
        '
        Me.Slidernumber.AutoSize = True
        Me.Slidernumber.BackColor = System.Drawing.Color.Transparent
        Me.Slidernumber.Location = New System.Drawing.Point(398, 223)
        Me.Slidernumber.Name = "Slidernumber"
        Me.Slidernumber.Size = New System.Drawing.Size(0, 17)
        Me.Slidernumber.TabIndex = 1
        Me.Slidernumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Plaintextbox
        '
        Me.Plaintextbox.BackColor = System.Drawing.Color.White
        Me.Plaintextbox.Font = New System.Drawing.Font("Tahoma", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Plaintextbox.ForeColor = System.Drawing.Color.Salmon
        Me.Plaintextbox.Location = New System.Drawing.Point(267, 113)
        Me.Plaintextbox.Name = "Plaintextbox"
        Me.Plaintextbox.Size = New System.Drawing.Size(304, 59)
        Me.Plaintextbox.TabIndex = 3
        Me.Plaintextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Encryptedtextbox
        '
        Me.Encryptedtextbox.BackColor = System.Drawing.Color.White
        Me.Encryptedtextbox.Font = New System.Drawing.Font("Tahoma", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Encryptedtextbox.ForeColor = System.Drawing.Color.Salmon
        Me.Encryptedtextbox.Location = New System.Drawing.Point(267, 379)
        Me.Encryptedtextbox.Name = "Encryptedtextbox"
        Me.Encryptedtextbox.Size = New System.Drawing.Size(304, 59)
        Me.Encryptedtextbox.TabIndex = 4
        Me.Encryptedtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'plainbet
        '
        Me.plainbet.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.plainbet.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plainbet.ForeColor = System.Drawing.Color.Transparent
        Me.plainbet.Location = New System.Drawing.Point(0, 265)
        Me.plainbet.Name = "plainbet"
        Me.plainbet.Size = New System.Drawing.Size(799, 44)
        Me.plainbet.TabIndex = 6
        Me.plainbet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cypherbet
        '
        Me.cypherbet.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cypherbet.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cypherbet.ForeColor = System.Drawing.Color.Black
        Me.cypherbet.Location = New System.Drawing.Point(0, 315)
        Me.cypherbet.Name = "cypherbet"
        Me.cypherbet.Size = New System.Drawing.Size(799, 44)
        Me.cypherbet.TabIndex = 7
        Me.cypherbet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Title
        '
        Me.Title.BackgroundImage = Global.CryptoCode___visual_teaching_aid_v1._1.My.Resources.Resources.cc
        Me.Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Title.Location = New System.Drawing.Point(163, 3)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(465, 104)
        Me.Title.TabIndex = 8
        Me.Title.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(642, 92)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 68)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Menubutton
        '
        Me.Menubutton.Location = New System.Drawing.Point(12, 3)
        Me.Menubutton.Name = "Menubutton"
        Me.Menubutton.Size = New System.Drawing.Size(75, 73)
        Me.Menubutton.TabIndex = 10
        Me.Menubutton.Text = "MENU"
        Me.Menubutton.UseVisualStyleBackColor = True
        '
        'Caesar_Cypher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Menubutton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.cypherbet)
        Me.Controls.Add(Me.plainbet)
        Me.Controls.Add(Me.Encryptedtextbox)
        Me.Controls.Add(Me.Plaintextbox)
        Me.Controls.Add(Me.Slidernumber)
        Me.Controls.Add(Me.Cypher)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Caesar_Cypher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caesar_Cypher"
        CType(Me.Cypher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Title, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cypher As TrackBar
    Friend WithEvents refresha As Timer
    Friend WithEvents Slidernumber As Label
    Friend WithEvents Plaintextbox As TextBox
    Friend WithEvents Encryptedtextbox As TextBox
    Friend WithEvents plainbet As TextBox
    Friend WithEvents cypherbet As TextBox
    Friend WithEvents Title As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Menubutton As Button
End Class
