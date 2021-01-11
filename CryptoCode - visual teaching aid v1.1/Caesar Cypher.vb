Public Class Caesar_Cypher
    Dim caesar As New caesar 'This is the caesar form thats used to store methods for caesar

    Private Sub Caesar_Cypher_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'loads caesar cypher

        Me.FormBorderStyle = FormBorderStyle.FixedSingle 'sets the form so the user can't expand the boarders
        For i = 0 To Len(caesar.getalphabet()) - 1 'sets the text boxes to contain the alphabets
            If i <> 0 Then
                plainbet.Text = plainbet.Text & " " & caesar.getalphabet(i)
            Else
                plainbet.Text = plainbet.Text & caesar.getalphabet(i)
            End If
        Next
        caesar.ceasercypher(caesar.getalphabet(), cypherbet, Cypher.Value) 'ceasercyphers the alphabet
        Button1.Text = "encrypt" 'sets the button text to encrypt as this is swappable later on to given the option to decrypt
        caesar.setcurrentype(True)
        Encryptedtextbox.ReadOnly = True 'sets all the colours for the different textboxes to demonstrate to user which are useable and which are not
        Encryptedtextbox.BackColor = Color.LightGray
    End Sub

    Private Sub refresh_Tick(sender As Object, e As EventArgs) Handles refresha.Tick 'this just makes sure the cypher code is up to date with the slider
        caesar.setcyphercode(Cypher.Value)

    End Sub


    Private Sub Plaintextbox_TextChanged(sender As Object, e As EventArgs) Handles Plaintextbox.TextChanged 'whenever you change the text that needs to be encrypted it will put it through the ceaser cypher encryption and return it tot the output box
        If caesar.returncurrent = True Then
            caesar.limitstring(Plaintextbox.Text, Plaintextbox, 10)
            caesar.setplaintext(Plaintextbox.Text)

            caesar.ceasercypher(caesar.returnplaintext, Encryptedtextbox, Cypher.Value)
        End If

    End Sub



    Private Sub Cypher_ValueChanged(sender As Object, e As EventArgs) Handles Cypher.ValueChanged 'when you change the slider it update the caesar and alphabets to match with the current code
        Slidernumber.Text = Cypher.Value
        If caesar.returncurrent() = True Then
            caesar.setplaintext(Plaintextbox.Text)
            caesar.ceasercypher(caesar.returnplaintext(), Encryptedtextbox, Cypher.Value)
            caesar.ceasercypher(caesar.getalphabet(), cypherbet, Cypher.Value)

        Else
            'MsgBox("")
            caesar.setcyphertext(Encryptedtextbox.Text)
            ' MsgBox(caesar.returncyphertext)
            caesar.decryptceasercypher(caesar.returncyphertext(), Plaintextbox, Cypher.Value)
            caesar.decryptceasercypher(caesar.getalphabet(), plainbet, Cypher.Value)
        End If
    End Sub

    Private Sub Encryptedtextbox_TextChanged(sender As Object, e As EventArgs) Handles Encryptedtextbox.TextChanged 'same as before but for decryption
        If caesar.returncurrent() = False Then
            caesar.limitstring(Encryptedtextbox.Text, Encryptedtextbox, 10)
            caesar.setcyphertext(Encryptedtextbox.Text)
            caesar.decryptceasercypher(caesar.returncyphertext(), Plaintextbox, Cypher.Value)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'this will change between encrypt and decrypt
        If caesar.returncurrent = True Then
            Encryptedtextbox.Text = ""
            Plaintextbox.Text = ""
            Button1.BackColor = Color.DarkGray
            Button1.ForeColor = Color.White
            Encryptedtextbox.BackColor = Color.White
            Plaintextbox.BackColor = Color.LightGray
            Button1.Text = "decrypt"
            Encryptedtextbox.ReadOnly = False
            Plaintextbox.ReadOnly = True
            caesar.setcurrentype(False)
            cypherbet.Text = ""
            For i = 0 To Len(caesar.getalphabet()) - 1
                If i <> 0 Then
                    cypherbet.Text = cypherbet.Text & " " & caesar.getalphabet(i)
                Else
                    cypherbet.Text = cypherbet.Text & caesar.getalphabet(i)
                End If
            Next
            caesar.decryptceasercypher(caesar.getalphabet(), plainbet, Cypher.Value)
        Else
            Encryptedtextbox.Text = ""
            Encryptedtextbox.BackColor = Color.LightGray
            Plaintextbox.BackColor = Color.White
            Plaintextbox.Text = ""
            Button1.BackColor = Color.Silver
            Button1.ForeColor = Color.Black
            Button1.Text = "encrypt"
            Plaintextbox.ReadOnly = False
            Encryptedtextbox.ReadOnly = True
            caesar.setcurrentype(True)
            For i = 0 To Len(caesar.getalphabet()) - 1
                If i <> 0 Then
                    plainbet.Text = plainbet.Text & " " & caesar.getalphabet(i)
                Else
                    plainbet.Text = plainbet.Text & caesar.getalphabet(i)
                End If
            Next
            caesar.ceasercypher(caesar.getalphabet(), cypherbet, Cypher.Value)
        End If
    End Sub

    Private Sub Menubutton_Click(sender As Object, e As EventArgs) Handles Menubutton.Click 'this will quit the form and go back to the starting menu
        caesar.backtothemenu(Me)
    End Sub
End Class