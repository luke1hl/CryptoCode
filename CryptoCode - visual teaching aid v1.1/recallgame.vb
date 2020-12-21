Public Class recallgame
    Dim cencrypt As cEncryption
    Dim railfenceclass As railfenceclass
    Dim typesofencryption = New String() {"Ceaser", "Enigma", "Vernam", "Railfence"}
    Dim currentcorrect As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim menu As New Form1
        menu.Show()
        Me.Close()
    End Sub

    Private Sub pickgenre()
        Dim genrenumber As Integer = cencrypt.returnrandomnumber(1, 5) ' 1. is what type of encryption does this look like  2. what is the most likely encryption 3. what is most likely decryption 4.practice an xor 5.what is the key
        If genrenumber = 1 Then 'type of encryption

        ElseIf genrenumber = 2 Then ' what does given word look like when encrypted using 'x' with a key of 'y'

        ElseIf genrenumber = 3 Then 'what is the most likely decryption of a encrypted word using 'x' with a key of 'y'

        ElseIf genrenumber = 4 Then 'practice XOR question

        ElseIf genrenumber = 5 Then 'what is the key for either railfence or ceaser
        End If
    End Sub
    Private Function choosetypeofencryption(max)
        Return cencrypt.returnrandomnumber(1, max)

    End Function
    Function pickrandomword()
        Dim ioFile As New System.IO.StreamReader("Z:\visual basic coding\CryptoCode\CryptoCode\CryptoCode - visual teaching aid v1.1\Resources\Collins Scrabble Words (2019).txt")
        Dim lines As New List(Of String)
        Dim rnd As New Random()
        Dim line As Integer
        While ioFile.Peek <> -1
            lines.Add(ioFile.ReadLine())
        End While
        line = rnd.Next(lines.Count + 1)
        ioFile.Close()
        ioFile.Dispose()
        Return lines(line).Trim()

    End Function
    Private Sub createquestionone()
        Dim wordtoencrypt As String = pickrandomword()
        Dim key As Integer = cencrypt.returnrandomnumber(1, 4)
        currentcorrect = cencrypt.returnrandomnumber(1, 4)
        Dim typeofencryption As String = typesofencryption(currentcorrect)
        Dim encryptedword As String = ""
        If typeofencryption = "Ceaser" Then
            ' vbLf is the multiline charcter
            'encryptedword = 
        ElseIf typeofencryption = "Enigma" Then

        ElseIf typeofencryption = "Vernam" Then

        ElseIf typeofencryption = "Railfence" Then
            encryptedword = railfenceclass.railfenceencrypt(wordtoencrypt, key)

        End If
        questionbox.Text = "what kind of encryption does this look like?

" & encryptedword
        Optionbox.Text = (" 1. Ceaser
2.Enigma
3.Vernam
4.Railfence")
    End Sub
    Private Sub recallgame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        MsgBox(pickrandomword())
        'createquestionone()
    End Sub

    Private Sub newquestion_Click(sender As Object, e As EventArgs) Handles newquestion.Click
        pickgenre()
    End Sub
End Class