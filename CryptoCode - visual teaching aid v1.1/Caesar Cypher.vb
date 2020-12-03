Public Class Caesar_Cypher
    Dim caesar As New caesar

    Private Sub Caesar_Cypher_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        For i = 0 To Len(caesar.getalphabet()) - 1
            If i <> 0 Then
                plainbet.Text = plainbet.Text & " " & caesar.getalphabet(i)
            Else
                plainbet.Text = plainbet.Text & caesar.getalphabet(i)
            End If
        Next
        caesar.ceasercypher(caesar.getalphabet(), cypherbet, Cypher.Value)
        Button1.Text = "encrypt"
        caesar.setcurrentype(True)
        Encryptedtextbox.ReadOnly = True
        Encryptedtextbox.BackColor = Color.LightGray
    End Sub

    Private Sub refresh_Tick(sender As Object, e As EventArgs) Handles refresha.Tick
        caesar.setcyphercode(Cypher.Value)

    End Sub


    Private Sub Plaintextbox_TextChanged(sender As Object, e As EventArgs) Handles Plaintextbox.TextChanged
        If caesar.returncurrent = True Then
            caesar.limitstring(Plaintextbox.Text, Plaintextbox, 10)
            caesar.setplaintext(Plaintextbox.Text)

            caesar.ceasercypher(caesar.returnplaintext, Encryptedtextbox, Cypher.Value)
        End If

    End Sub



    Private Sub Cypher_ValueChanged(sender As Object, e As EventArgs) Handles Cypher.ValueChanged
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

    Private Sub Encryptedtextbox_TextChanged(sender As Object, e As EventArgs) Handles Encryptedtextbox.TextChanged
        If caesar.returncurrent() = False Then
            caesar.limitstring(Encryptedtextbox.Text, Encryptedtextbox, 10)
            caesar.setcyphertext(Encryptedtextbox.Text)
            caesar.decryptceasercypher(caesar.returncyphertext(), Plaintextbox, Cypher.Value)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

    Private Sub Menubutton_Click(sender As Object, e As EventArgs) Handles Menubutton.Click
        caesar.backtothemenu(Me)
    End Sub
End Class