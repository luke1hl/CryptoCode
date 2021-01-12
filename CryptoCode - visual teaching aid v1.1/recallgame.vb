Public Class recallgame
    Protected railfenceclass As New railfenceclass
    Protected typesofencryption = New String() {"Ceaser", "Enigma", "Vernam", "Railfence"}
    Protected currentcorrect As Integer
    Protected cencryption As New cEncryption
    Protected engimaclasss As New enigmaclass
    Protected ceaser As New caesar
    Protected vernamcyphers As New vernamcypher
    Protected currentgenre As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'this exits back to the home menu
        Dim menu As New Form1
        menu.Show()
        Me.Close()
    End Sub

    Private Sub pickgenre()
        Randomize()
        Dim genrenumber As Integer = cencryption.returnrandomnumber(1, 4) ' 1. is what type of encryption does this look like  2. what is the most likely encryption 3. what is most likely decryption 4.practice an xor 5.what is the key
        currentgenre = genrenumber
        ' genrenumber = 4
        If genrenumber = 1 Then 'type of encryption
            createquestionone()
        ElseIf genrenumber = 2 Then ' what does given word look like when encrypted using 'x' with a key of 'y'
            createquestiontwo()
        ElseIf genrenumber = 3 Then 'what is the most likely decryption of a encrypted word using 'x' with a key of 'y'
            createquestionthree()
        ElseIf genrenumber = 4 Then 'practice XOR question
            createquestionfour()
        End If
    End Sub
    Private Function choosetypeofencryption(max) 'randomly picks a type of encryption
        Return cencryption.returnrandomnumber(1, max)

    End Function
    Function pickrandomword() 'this will grab a random word from the text file i have stored in the project

        ' Dim ioFile As New System.IO.StreamReader("D:\Visual basic code\CryptoCode\CryptoCode - visual teaching aid v1.1\Collins Scrabble Words (2019).txt")
        Dim filelocation As String = System.IO.Path.GetFullPath((Application.StartupPath & "\..\..\Resources\Collins Scrabble Words (2019).txt"))

        Dim ioFile As New System.IO.StreamReader(filelocation)
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
    Private Function generaterandombinarynumber() 'this will make a random binary number by randomly picking a number 1 to 1000 if even it adds a zero if odd it adds a one
        Dim binarystring As String = ""
        For i = 0 To 7
            Dim oneorzero As Integer = cencryption.returnrandomnumber(1, 1000)
            binarystring = binarystring & oneorzero Mod 2

        Next
        Return binarystring
    End Function
    Private rnd As New Random()

    Private Sub Shuffle(items As String()) 'this shuffles the order fo the answers
        Dim j As Int32
        Dim temp As String

        For n As Int32 = items.Length - 1 To 0 Step -1
            j = rnd.Next(0, n + 1)
            ' Swap them.
            temp = items(n)
            items(n) = items(j)
            items(j) = temp
        Next n
    End Sub
    Private Sub createquestionfour() 'generates the xor question
        Dim listofpossibleanswer(3) As String
        Dim binaryone As String = generaterandombinarynumber()
        Dim binarytwo As String = generaterandombinarynumber()
        Dim xoredstring As String = cencryption.DoanXOR(binaryone, binarytwo)
        listofpossibleanswer(1) = xoredstring
        listofpossibleanswer(0) = generaterandombinarynumber()
        listofpossibleanswer(2) = generaterandombinarynumber()
        listofpossibleanswer(3) = generaterandombinarynumber()
        For i = 0 To cencryption.returnrandomnumber(1, 200)
            Shuffle(listofpossibleanswer)

        Next
        For i = 0 To 3
            If listofpossibleanswer(i) = xoredstring Then
                currentcorrect = i + 1
                enablebuttons()
                Exit For
            End If
        Next
        questionbox.Text = "what would Xor of " & binaryone & " with " & binarytwo & " be?"
        Optionbox.Text = ("1. " & listofpossibleanswer(0) & "
2. " & listofpossibleanswer(1) & "
3. " & listofpossibleanswer(2) & "
4. " & listofpossibleanswer(3))
    End Sub
    Private Sub createquestionthree() 'generates the finding the decryption of either ceaser or railfence questions
        Dim wordtoencrypt As String = pickrandomword()
        Dim listofpossibleanswer(3) As String

        Dim typeofs As String = ""
        Dim encryptedword As String = ""
        Dim oneortheother As Integer = cencryption.returnrandomnumber(1, 2)
        Dim keya As Integer = cencryption.returnrandomnumber(-8, 10)
        Dim keyb As Integer = cencryption.returnrandomnumber(2, 6)
        If oneortheother = 1 Then
            encryptedword = ceaser.ceasercypheringame(wordtoencrypt, keya)
            typeofs = "ceaser cypher"
        Else
            encryptedword = railfenceclass.railfenceencrypt(wordtoencrypt, keyb)
            encryptedword = encryptedword.Replace("℗", "")
            typeofs = "Railfence Encryption"

        End If
        listofpossibleanswer(1) = pickrandomword()
        listofpossibleanswer(0) = pickrandomword()
        listofpossibleanswer(2) = pickrandomword()
        listofpossibleanswer(3) = wordtoencrypt
        For i = 0 To cencryption.returnrandomnumber(1, 200)
            Shuffle(listofpossibleanswer)

        Next
        For i = 0 To 3
            If listofpossibleanswer(i) = wordtoencrypt Then
                currentcorrect = i + 1
                enablebuttons()
                Exit For
            End If
        Next

        questionbox.Text = "what would the decryption of " & encryptedword & " be when using " & typeofs & "?"
        Optionbox.Text = ("1. " & listofpossibleanswer(0) & "
2. " & listofpossibleanswer(1) & "
3. " & listofpossibleanswer(2) & "
4. " & listofpossibleanswer(3))
    End Sub
    Private Sub createquestiontwo() 'asks a user to encrypt question
        Dim wordtoencrypt As String = pickrandomword()
        Dim listofpossibleanswer(3) As String

        Dim typeofs As String = ""
        Dim encryptedword As String = ""
        Dim oneortheother As Integer = cencryption.returnrandomnumber(1, 2)
        Dim keya As Integer = cencryption.returnrandomnumber(-8, 10)
        Dim keyb As Integer = cencryption.returnrandomnumber(2, 6)
        If oneortheother = 1 Then
            encryptedword = ceaser.ceasercypheringame(wordtoencrypt, keya)
            typeofs = "ceaser cypher"
        Else
            encryptedword = railfenceclass.railfenceencrypt(wordtoencrypt, keyb)
            encryptedword = encryptedword.Replace("℗", "")
            typeofs = "Railfence Encryption"

        End If
        listofpossibleanswer(1) = ceaser.ceasercypheringame(pickrandomword(), keya)
        listofpossibleanswer(0) = railfenceclass.railfencedecrypt(pickrandomword(), keyb)
        listofpossibleanswer(2) = cencryption.Scramble(encryptedword)
        listofpossibleanswer(3) = encryptedword
        For i = 0 To cencryption.returnrandomnumber(1, 200)
            Shuffle(listofpossibleanswer)

        Next
        For i = 0 To 3
            If listofpossibleanswer(i) = encryptedword Then
                currentcorrect = i + 1
                enablebuttons()
                Exit For
            End If
        Next

        questionbox.Text = "what would the encryption of " & wordtoencrypt & " be when using " & typeofs & "?"
        Optionbox.Text = ("1. " & listofpossibleanswer(0) & "
2. " & listofpossibleanswer(1) & "
3. " & listofpossibleanswer(2) & "
4. " & listofpossibleanswer(3))

    End Sub
    Private Sub createquestionone() 'what kind of encryption is this?
        Dim wordtoencrypt As String = pickrandomword()
        Dim key As Integer = cencryption.returnrandomnumber(3, 6)
        currentcorrect = cencryption.returnrandomnumber(1, 4)
        Dim typeofencryption As String = typesofencryption(currentcorrect - 1)
        Dim encryptedword As String = ""
        ' typeofencryption = "Railfence"
        ' currentcorrect = 4
        If typeofencryption = "Ceaser" Then
            encryptedword = ceaser.ceasercypheringame(wordtoencrypt, key)
            ' vbLf is the multiline charcter
            'encryptedword = 
            'cypherdislapy.Text = encryptedword

        ElseIf typeofencryption = "Enigma" Then
            engimaclasss.predefinealphabets()
            For i = 0 To Len(wordtoencrypt) - 1
                encryptedword = encryptedword & engimaclasss.enigmaencodeforgame(wordtoencrypt(i))

            Next
        ElseIf typeofencryption = "Vernam" Then
            Dim extra As String = pickrandomword()
            extra = extra & pickrandomword()
            extra = extra.Substring(0, extra.Length - (Len(extra) - Len(wordtoencrypt)))
            'MsgBox(extra)
            For i = 0 To Len(wordtoencrypt) - 1
                encryptedword = encryptedword & vernamcyphers.binarytochar(vernamcyphers.DoanXOR(vernamcyphers.convertcharactertobinary(wordtoencrypt(i)), vernamcyphers.convertcharactertobinary(extra(i))), True)

            Next
        ElseIf typeofencryption = "Railfence" Then
            ' MsgBox(wordtoencrypt)
            encryptedword = railfenceclass.railfenceencrypt(wordtoencrypt, key)
            encryptedword = encryptedword.Replace("℗", "")
        End If
        questionbox.Text = "what kind of encryption does this look like?

" & encryptedword
        Optionbox.Text = (" 1. Ceaser
2.Enigma
3.Vernam
4.Railfence")
        enablebuttons()
    End Sub
    Private Sub enablebuttons() 'turns the answer buttons on
        answerone.Enabled = True
        answertwo.Enabled = True
        Answerthree.Enabled = True
        answerfour.Enabled = True
    End Sub
    Private Sub disablebuttons() 'turns the answer buttons off
        answerone.Enabled = False
        answertwo.Enabled = False
        Answerthree.Enabled = False
        answerfour.Enabled = False
    End Sub
    Private Sub recallgame_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'this sets up the first question when you load the form
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        disablebuttons()
        ' MsgBox(pickrandomword())
        pickgenre()
    End Sub

    Private Sub newquestion_Click(sender As Object, e As EventArgs) Handles newquestion.Click 'will generate a new question when pushed
        pickgenre()
    End Sub

    Private Sub answerone_Click(sender As Object, e As EventArgs) Handles answerone.Click 'this will all check wether the answer the user selcts is correct
        If currentcorrect = 1 Then
            MsgBox("well done thats the right answer")
        Else
            MsgBox("unlucky the correct answer was " & currentcorrect)
        End If
        disablebuttons()
    End Sub

    Private Sub answertwo_Click(sender As Object, e As EventArgs) Handles answertwo.Click
        If currentcorrect = 2 Then
            MsgBox("well done thats the right answer")
        Else
            MsgBox("unlucky the correct answer was " & currentcorrect)
        End If
        disablebuttons()
    End Sub

    Private Sub Answerthree_Click(sender As Object, e As EventArgs) Handles Answerthree.Click
        If currentcorrect = 3 Then
            MsgBox("well done thats the right answer")
        Else
            MsgBox("unlucky the correct answer was " & currentcorrect)
        End If
        disablebuttons()
    End Sub

    Private Sub answerfour_Click(sender As Object, e As EventArgs) Handles answerfour.Click
        If currentcorrect = 4 Then
            MsgBox("well done thats the right answer")
        Else
            MsgBox("unlucky the correct answer was " & currentcorrect)
        End If
        disablebuttons()
    End Sub
End Class