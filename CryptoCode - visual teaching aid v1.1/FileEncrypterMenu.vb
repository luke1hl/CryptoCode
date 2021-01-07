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
        Button1.ForeColor = Color.White
        Button1.BackColor = Color.MediumBlue
    End Sub

    Private Sub vernam_Click(sender As Object, e As EventArgs) Handles vernam.Click
        menusorter.setmethod("vernam")
        Enigma.BackColor = Color.MediumBlue
        ceaser.BackColor = Color.MediumBlue
        vernam.BackColor = Color.LightBlue
        Enigma.ForeColor = Color.White
        vernam.ForeColor = Color.Black
        ceaser.ForeColor = Color.White
        Button1.ForeColor = Color.White
        Button1.BackColor = Color.MediumBlue
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
                ceaserloaderf.railfencego.Hide()

                ceaserloaderf.Button2.Hide()
                ceaserloaderf.Button3.Hide()
                ceaserloaderf.Button4.Hide()

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
                ceaserloaderf.railfencego.Hide()
                ceaserloaderf.Button2.Hide()
                ceaserloaderf.Button3.Hide()
                ceaserloaderf.Button4.Hide()
                ceaserloaderf.enigmade.Hide()
                If menusorter.returnecnryptordecrypt() = True Then 'using the background colour to store the value of if it should be encrypting or decrypting
                    ceaserloaderf.BackColor = Color.Black

                Else
                    ceaserloaderf.BackColor = Color.White

                End If

            ElseIf menusorter.returncurrentlyselected = "Enigma" Then
                ceaserloaderf.vernampanel.Hide()
                ceaserloaderf.Ceaserpanel.Hide()
                ceaserloaderf.railfencego.Hide()
                ceaserloaderf.enigmade.Show()
                ceaserloaderf.Button2.Hide()
                ceaserloaderf.Button3.Hide()
                ceaserloaderf.Button4.Hide()
                If menusorter.returnecnryptordecrypt() = True Then 'using the background colour to store the value of if it should be encrypting or decrypting
                    ceaserloaderf.BackColor = Color.Black

                Else
                    ceaserloaderf.BackColor = Color.White

                End If

            ElseIf menusorter.returncurrentlyselected = "Railfence" Then
                ceaserloaderf.vernampanel.Hide()
                ceaserloaderf.Ceaserpanel.Hide()
                Ceaserloader.enigmade.Hide()
                Ceaserloader.railfencego.Show()
                ceaserloaderf.Button2.Show()
                ceaserloaderf.Button3.Show()
                ceaserloaderf.Button4.Show()
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
        Button1.ForeColor = Color.White
        Button1.BackColor = Color.MediumBlue
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        menusorter.setmethod("Railfence")
        ceaser.BackColor = Color.MediumBlue
        ceaser.ForeColor = Color.White
        vernam.BackColor = Color.MediumBlue
        vernam.ForeColor = Color.White
        Enigma.BackColor = Color.MediumBlue
        Enigma.ForeColor = Color.White
        Button1.ForeColor = Color.Black
        Button1.BackColor = Color.LightBlue
    End Sub
End Class