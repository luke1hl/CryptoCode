Public Class Engima
    Dim eord As Boolean = True
    Dim keynolongerdown As Boolean = True
    Dim enigmac As New enigmaclass


    Private Sub Engima_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enigmac.predefinealphabets()
        Me.KeyPreview = True
        'For i = 0 To enigmac.returnalphabet(1).Count - 1
        '    Alphabet.Text = Alphabet.Text & " " & enigmac.returnalphabet(1)(i)

        'Next
        'For i = 0 To enigmac.returnalphabet(2).Count - 1
        '    Mixedalphabet1.Text = Mixedalphabet1.Text & " " & enigmac.returnalphabet(2)(i)

        'Next
        'For i = 0 To enigmac.returnalphabet(3).Count - 1
        '    Mixedalphabet2.Text = Mixedalphabet2.Text & " " & enigmac.returnalphabet(3)(i)

        'Next
        enigmac.updatedisplay(Alphabet, Mixedalphabet1, Mixedalphabet2)


    End Sub



    Private Sub Engima_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyValue <= 90 And e.KeyValue >= 65 Then
            'MsgBox(Chr(e.KeyValue))
            If eord = True Then
                enigmac.enigmaencode(Typedchar, Chr(e.KeyValue), Cypherbox)

            Else
                enigmac.enigmadecode(Typedchar, Chr(e.KeyValue), Cypherbox)
            End If
            enigmac.updatedisplay(Alphabet, Mixedalphabet1, Mixedalphabet2)

            textdisplay.Text = textdisplay.Text & Cypherbox.Text
            Threading.Thread.Sleep(500)

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If eord = True Then
            eord = False
            Button1.BackColor = Color.Red
        Else
            eord = True
            Button1.BackColor = Color.Green

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim engimaform As New Engima
        engimaform.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim menuform As New Form1
        menuform.Show()
        Me.Close()
    End Sub
End Class