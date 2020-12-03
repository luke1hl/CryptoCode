Public Class FileEncrypterMenu
    Dim menusorter As New cfileencryptermenu
    Private Sub ceaser_Click(sender As Object, e As EventArgs) Handles ceaser.Click
        menusorter.setmethod("ceaser")
        ceaser.BackColor = Color.LightBlue
        ceaser.ForeColor = Color.Black
        vernam.BackColor = Color.MediumBlue
        vernam.ForeColor = Color.White
        Enigma.BackColor = Color.MediumBlue
        Enigma.ForeColor = Color.White
    End Sub

    Private Sub vernam_Click(sender As Object, e As EventArgs) Handles vernam.Click
        menusorter.setmethod("vernam")
        Enigma.BackColor = Color.MediumBlue
        ceaser.BackColor = Color.MediumBlue
        vernam.BackColor = Color.LightBlue
        Enigma.ForeColor = Color.White
        vernam.ForeColor = Color.Black
        ceaser.ForeColor = Color.White

    End Sub

    Private Sub FileEncrypterMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle

    End Sub

    Private Sub Encrypt_Click(sender As Object, e As EventArgs) Handles Encrypt.Click
        menusorter.setencryptordecrypt(True)
        Encrypt.BackColor = Color.LightBlue
        Decrypt.BackColor = Color.MediumBlue
        Encrypt.ForeColor = Color.Black
        Decrypt.ForeColor = Color.White
        menusorter.setchoiceselected()
    End Sub

    Private Sub Decrypt_Click(sender As Object, e As EventArgs) Handles Decrypt.Click
        menusorter.setencryptordecrypt(False)
        Encrypt.BackColor = Color.MediumBlue
        Decrypt.BackColor = Color.LightBlue
        Decrypt.ForeColor = Color.Black
        Encrypt.ForeColor = Color.White
        menusorter.setchoiceselected()
    End Sub

    Private Sub ok_Click(sender As Object, e As EventArgs) Handles ok.Click
        If menusorter.returncurrentlyselected() <> "" And menusorter.returnchoiceselected() = True Then
            Dim ceaserloaderf As New Ceaserloader

            If menusorter.returncurrentlyselected() = "vernam" Then
                ceaserloaderf.vernampanel.Show()
                ceaserloaderf.Ceaserpanel.Hide()
                ceaserloaderf.enigmade.Hide()
                Application.DoEvents()
                ' MsgBox("")
                If menusorter.returnecnryptordecrypt() = True Then 'using the background colour to store the value of if it should be encrypting or decrypting
                    ceaserloaderf.BackColor = Color.Black

                Else
                    ceaserloaderf.BackColor = Color.White

                End If
            ElseIf menusorter.returncurrentlyselected() = "ceaser" Then
                ceaserloaderf.vernampanel.Hide()
                ceaserloaderf.Ceaserpanel.Show()
                ceaserloaderf.enigmade.Hide()
                If menusorter.returnecnryptordecrypt() = True Then 'using the background colour to store the value of if it should be encrypting or decrypting
                    ceaserloaderf.BackColor = Color.Black

                Else
                    ceaserloaderf.BackColor = Color.White

                End If

            ElseIf menusorter.returncurrentlyselected = "Enigma" Then
                ceaserloaderf.vernampanel.Hide()
                ceaserloaderf.Ceaserpanel.Hide()
                ceaserloaderf.enigmade.Show()
                If menusorter.returnecnryptordecrypt() = True Then 'using the background colour to store the value of if it should be encrypting or decrypting
                    ceaserloaderf.BackColor = Color.Black

                Else
                    ceaserloaderf.BackColor = Color.White

                End If
            End If
            ceaserloaderf.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Enigma_Click(sender As Object, e As EventArgs) Handles Enigma.Click
        menusorter.setmethod("Enigma")
        ceaser.BackColor = Color.MediumBlue
        vernam.BackColor = Color.MediumBlue
        vernam.ForeColor = Color.White
        Enigma.BackColor = Color.LightBlue
        Enigma.ForeColor = Color.Black
        ceaser.ForeColor = Color.White
    End Sub
End Class