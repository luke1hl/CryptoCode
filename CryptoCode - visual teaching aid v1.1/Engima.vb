Public Class Engima
    Private eord As Boolean = True
    Private keynolongerdown As Boolean = True
    Private enigmac As New enigmaclass


    Private Sub Engima_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enigmac.predefinealphabets() 'sets the alphabets in the three rows
        Me.KeyPreview = True 'makes it so that keypresses can be recorded

        enigmac.updatedisplay(Alphabet, Mixedalphabet1, Mixedalphabet2) 'this will update the display and put the alphabets into all the boxes


    End Sub



    Private Sub Engima_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp 'detects when any key is pushed
        If e.KeyValue <= 90 And e.KeyValue >= 65 Then 'checks to see wether the key pushed was a member of the alphabet
            If eord = True Then 'this checks wether its meant to be encrypting or decrypting
                enigmac.enigmaencode(Typedchar, Chr(e.KeyValue), Cypherbox) 'performs the enigmacode on the keypressed

            Else
                enigmac.enigmadecode(Typedchar, Chr(e.KeyValue), Cypherbox)
            End If
            enigmac.updatedisplay(Alphabet, Mixedalphabet1, Mixedalphabet2) 'updates the alphabets by rotating them

            textdisplay.Text = textdisplay.Text & Cypherbox.Text 'updates the text display
            Threading.Thread.Sleep(500) 'creates a pause so the user can't spam letters faster than it can update

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'this is the button that swaps between encrypt or decrypt
        If eord = True Then
            eord = False
            Button1.BackColor = Color.Red
        Else
            eord = True
            Button1.BackColor = Color.Green

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'resets the enigma form
        Dim engimaform As New Engima
        engimaform.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'returns you to menu
        Dim menuform As New Form1
        menuform.Show()
        Me.Close()
    End Sub
End Class