Public Class recallgame
    Dim cencrypt As cEncryption
    Dim typesofencryption = New String() {"ceaser", "Enigma", "vernam", "railfence"}
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
        Dim ioFile As New System.IO.StreamReader("D:\Visual basic code\CryptoCode\CryptoCode - visual teaching aid v1.1\Collins Scrabble Words (2019).txt")
        Dim lines As New List(Of String)
        Dim rnd As New Random()
        Dim line As Integer
        While ioFile.Peek <> -1
            lines.Add(ioFile.ReadLine())
        End While
        line = rnd.Next(lines.Count + 1)
        MsgBox(lines(line).Trim())
        ioFile.Close()
        ioFile.Dispose()
    End Function
    Private Sub createquestionone()
        '  Dim wordtoencrypt As String = My.Computer.FileSystem.ReadAllText()
        Dim correctanswer As Integer = cencrypt.returnrandomnumber(1, 4)
        Dim typeofencryption As String = typesofencryption(cencrypt.returnrandomnumber(1, 4))
        If typeofencryption = "ceaser" Then

        End If
    End Sub
    Private Sub recallgame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pickrandomword()
    End Sub

    Private Sub newquestion_Click(sender As Object, e As EventArgs) Handles newquestion.Click
        pickgenre()
    End Sub
End Class