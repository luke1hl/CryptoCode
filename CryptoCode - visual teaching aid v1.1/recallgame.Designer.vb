<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class recallgame
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
        Me.answerone = New System.Windows.Forms.Button()
        Me.answerfour = New System.Windows.Forms.Button()
        Me.Answerthree = New System.Windows.Forms.Button()
        Me.answertwo = New System.Windows.Forms.Button()
        Me.Optionbox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.questionbox = New System.Windows.Forms.TextBox()
        Me.newquestion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'answerone
        '
        Me.answerone.Location = New System.Drawing.Point(162, 294)
        Me.answerone.Name = "answerone"
        Me.answerone.Size = New System.Drawing.Size(75, 43)
        Me.answerone.TabIndex = 0
        Me.answerone.Text = "1"
        Me.answerone.UseVisualStyleBackColor = True
        '
        'answerfour
        '
        Me.answerfour.Location = New System.Drawing.Point(504, 294)
        Me.answerfour.Name = "answerfour"
        Me.answerfour.Size = New System.Drawing.Size(75, 43)
        Me.answerfour.TabIndex = 1
        Me.answerfour.Text = "4"
        Me.answerfour.UseVisualStyleBackColor = True
        '
        'Answerthree
        '
        Me.Answerthree.Location = New System.Drawing.Point(391, 294)
        Me.Answerthree.Name = "Answerthree"
        Me.Answerthree.Size = New System.Drawing.Size(75, 43)
        Me.Answerthree.TabIndex = 2
        Me.Answerthree.Text = "3"
        Me.Answerthree.UseVisualStyleBackColor = True
        '
        'answertwo
        '
        Me.answertwo.Location = New System.Drawing.Point(275, 294)
        Me.answertwo.Name = "answertwo"
        Me.answertwo.Size = New System.Drawing.Size(75, 43)
        Me.answertwo.TabIndex = 3
        Me.answertwo.Text = "2"
        Me.answertwo.UseVisualStyleBackColor = True
        '
        'Optionbox
        '
        Me.Optionbox.Location = New System.Drawing.Point(147, 151)
        Me.Optionbox.Multiline = True
        Me.Optionbox.Name = "Optionbox"
        Me.Optionbox.ReadOnly = True
        Me.Optionbox.Size = New System.Drawing.Size(448, 124)
        Me.Optionbox.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(713, 377)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 61)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'questionbox
        '
        Me.questionbox.Location = New System.Drawing.Point(147, 87)
        Me.questionbox.Multiline = True
        Me.questionbox.Name = "questionbox"
        Me.questionbox.ReadOnly = True
        Me.questionbox.Size = New System.Drawing.Size(448, 58)
        Me.questionbox.TabIndex = 12
        '
        'newquestion
        '
        Me.newquestion.Location = New System.Drawing.Point(305, 394)
        Me.newquestion.Name = "newquestion"
        Me.newquestion.Size = New System.Drawing.Size(133, 44)
        Me.newquestion.TabIndex = 13
        Me.newquestion.Text = "newquestion"
        Me.newquestion.UseVisualStyleBackColor = True
        '
        'recallgame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.newquestion)
        Me.Controls.Add(Me.questionbox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Optionbox)
        Me.Controls.Add(Me.answertwo)
        Me.Controls.Add(Me.Answerthree)
        Me.Controls.Add(Me.answerfour)
        Me.Controls.Add(Me.answerone)
        Me.Name = "recallgame"
        Me.Text = "recallgame"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents answerone As Button
    Friend WithEvents answerfour As Button
    Friend WithEvents Answerthree As Button
    Friend WithEvents answertwo As Button
    Friend WithEvents Optionbox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents questionbox As TextBox
    Friend WithEvents newquestion As Button
End Class
