Public Class Ceaserloader
    Private TheCCeaserloader As New CCaeserLoader
    Private filePath As String 'used to store the file path when reading it
    Private cyphernumba As Integer = 0 'used to define what type of cypher is occuring
    Private caesar As New caesar
    Private vernamc As New vernamcypher
    Private completefile As String = ""
    Private threader As Threading.Thread
    Private enigmac As New enigmaclass
    Private railfenceclasser As New railfenceclass 'calls all classes so I can use them for all the different encryption methods
    Protected binarychar As String
    Protected binarycypherchar As String
    Protected vcyphercounter As Integer
    Protected vernamcyphers As String
    Protected officialvernatext As String
    Protected visualveratext As String
    Protected percentagev As Integer = 0 'used to determine the loading time of threading when used for the vernam cypher
    Protected threadover As Boolean = False

    Private Sub Ceaserloader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enigmac.predefinealphabets()


        cyphernumber.Text = 0
        vcyphercounter = 0
        Me.FormBorderStyle = FormBorderStyle.FixedSingle

        Select Case OpenFileDialog1.ShowDialog()
            Case DialogResult.OK
                filePath = OpenFileDialog1.FileName
                textdisplay.Text = My.Computer.FileSystem.ReadAllText(filePath)
            Case Else
        End Select

        completefile = textdisplay.Text
        If TheCCeaserloader.returndore = True Then   ' all msgbox are used for testing so i'm just going to leave them in
            'MsgBox("got it")
            completefile = completefile.Where(Function(x) Not Char.IsWhiteSpace(x)).ToArray()
            textdisplay.Text = completefile
            'MsgBox(completefile)
            percentage.Maximum = Len(completefile)
        ElseIf TheCCeaserloader.returndore = False And vernampanel.Visible = True Then
            ' MsgBox("recived")
            completefile = My.Computer.FileSystem.ReadAllText(filePath)
            textdisplay.Text = completefile
            percentage.Maximum = Len(completefile)
        End If
        ' End If

        frequencyanalysis(textdisplay.Text)
    End Sub

    Private Sub Ceaserloader_BackColorChanged(sender As Object, e As EventArgs) Handles Me.BackColorChanged 'this is used to detect a colour change from the previous form to determine wether its encrypt or decrypt
        If Me.BackColor = Color.Black Then
            Me.BackColor = Color.LightGreen
            TheCCeaserloader.setdore(True)
        ElseIf Me.BackColor = Color.White Then
            Me.BackColor = Color.LightGreen
            TheCCeaserloader.setdore(False)
        End If
    End Sub

    Private Sub Minus_Click(sender As Object, e As EventArgs) Handles Minus.Click 'used to lower the encryption code for caesar
        If cyphernumba > -10 Then
            cyphernumba -= 1

            If TheCCeaserloader.returndore = True Then
                caesar.ceasercypher(My.Computer.FileSystem.ReadAllText(filePath), textdisplay, cyphernumba)

            Else
                caesar.decryptceasercypher(My.Computer.FileSystem.ReadAllText(filePath), textdisplay, cyphernumba)
            End If
            cyphernumber.Text = cyphernumba
            frequencyanalysis(textdisplay.Text)
        End If

    End Sub

    Private Sub plus_Click(sender As Object, e As EventArgs) Handles plus.Click 'used to raise the encryption code for caesar
        If cyphernumba <= 10 Then
            cyphernumba += 1

            If TheCCeaserloader.returndore = True Then
                caesar.ceasercypher(My.Computer.FileSystem.ReadAllText(filePath), textdisplay, cyphernumba)

            Else
                caesar.decryptceasercypher(My.Computer.FileSystem.ReadAllText(filePath), textdisplay, cyphernumba)
            End If
            cyphernumber.Text = cyphernumba
            frequencyanalysis(textdisplay.Text)
        End If

    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click 'use to save the file
        Select Case SaveFileDialog1.ShowDialog()
            Case DialogResult.OK
                If vernampanel.Visible = True Then
                    'MsgBox(textdisplay.Text)
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, textdisplay.Text, True)

                Else
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, textdisplay.Text, True)

                End If
                MsgBox("file saved")
                Dim menu As New Form1
                menu.Show()
                Me.Close()
            Case Else
                MsgBox("ERROR")
        End Select
    End Sub
    Private Sub frequencyanalysis(input As String) 'used for frequency analysis which will count the number of each character in any string
        frequency.Items.Clear()
        Dim chararray() As Char = input.ToCharArray
        Dim distinctarray() As Char = chararray.Distinct.ToArray

        Dim counter As Integer = 0
        For i As Integer = 0 To distinctarray.Count - 1
            counter = 0
            For j As Integer = i To chararray.Count - 1
                If distinctarray(i) = chararray(j) Then
                    counter += 1
                End If
            Next

            frequency.Items.Add(distinctarray(i) + "   =   " + counter.ToString)
        Next

    End Sub
    Private Sub removenastycharacters() 'takes away characters that come up in vernam if they are above a certain value to prevent error
        Dim holders As Integer
        Dim holderslist(10000) As Integer
        Dim holderslistcounter As Integer = 0
        For i = 0 To Len(visualveratext) - 1
            If Asc(visualveratext(i)) < 125 And visualveratext(i) <> " " Then
                holders = Asc(visualveratext(i))
                holderslist(holderslistcounter) = holders
                holderslistcounter += 1

            End If
        Next
        For q = 0 To holderslistcounter
            visualveratext = visualveratext.Replace(Chr(holderslist(q)), "")

        Next
    End Sub

    Private Sub vcchange() 'this is used for the vernam cypher and cals the different methods used to change characters to and from binary as well as using the XOR
        Dim holder As String
        ' MsgBox("")
        vcyphercounter = 0

        officialvernatext = ""
        visualveratext = ""

        If Len(VernamCypher.Text) <> 0 Then

            For i = 0 To Len(completefile) - 1

                If TheCCeaserloader.returndore = False Then
                    binarychar = vernamc.ToBinary(Asc(completefile(i)) - 130)

                Else
                    binarychar = vernamc.ToBinary(Asc(completefile(i)))

                End If

                If Len(VernamCypher.Text) = 1 Then
                    vcyphercounter = 0
                End If
                binarycypherchar = vernamc.convertcharactertobinary(VernamCypher.Text(vcyphercounter))
                'MsgBox(vcyphercounter)
                If vcyphercounter < Len(VernamCypher.Text) - 1 Then
                    vcyphercounter += 1
                Else
                    vcyphercounter = 0
                End If

                holder = vernamc.DoanXOR(binarychar, binarycypherchar)
                If TheCCeaserloader.returndore = True Then
                    visualveratext = visualveratext & vernamc.binarytochar(holder, True)

                Else

                    visualveratext = visualveratext & vernamc.binarytochar(holder, False)

                End If
                percentagev += 1
            Next
            threadover = True
            threader.Abort()
        Else
            percentagev = percentage.Maximum
            ' MsgBox("complete")
            visualveratext = completefile
            threadover = True
            threader.Abort()

        End If


    End Sub
    Private Sub dostandardisation() 'used to fix the formating of certain encryptions and make spacing normal
        Dim holders As Integer
        Dim holderslist(10000) As Integer
        Dim holderslistcounter As Integer = 0
        percentage.Value = 0
        MsgBox(visualveratext)
        For i = 0 To Len(visualveratext) - 1
            If Asc(visualveratext(i)) < 30 And visualveratext(i) <> " " Then
                holders = Asc(visualveratext(i))
                holderslist(holderslistcounter) = holders
                holderslistcounter += 1

            End If
        Next

        Try
            For q = 0 To holderslistcounter
                visualveratext = visualveratext.Replace(Chr(holderslist(q)), "")

            Next
        Catch
        End Try
        textdisplay.Text = visualveratext
        frequencyanalysis(textdisplay.Text)

        Timer1.Enabled = False

        percentage.Visible = False
        percentagev = 0
        VernamCypher.ReadOnly = False
    End Sub
    Private Sub VernamCypher_TextChanged(sender As Object, e As EventArgs) Handles VernamCypher.TextChanged 'detects the change in vernam cypher and is used to commence the threading so that the encryption can occur in the background and load faster
        VernamCypher.ReadOnly = True
        threader = New Threading.Thread((AddressOf vcchange))
        threader.Start()
        percentage.Visible = True
        Timer1.Enabled = True




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick 'used to update the load bar for vernam
        percentage.Value = percentagev
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick 'used for when the thread ends
        If threadover = True Then
            threadover = False
            dostandardisation()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'takes you back to home menu
        Dim menu As New Form1
        menu.Show()
        Me.Close()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If vernamc.returncloseform() = "die" Then
            threader.Abort()
            vernamc.resetcloseform() 'used to kill the form if the vernam turns up an error This dosen't occur often but 
            Dim menu As New Form1
            menu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub enigmade_Click(sender As Object, e As EventArgs) Handles enigmade.Click 'if you click the enigma encode button it will perform the enigma as it dosen't require any encryption codes persay
        Dim holder As Char
        textdisplay.Text = ""
        'MsgBox(completefile)
        For i = 0 To Len(completefile) - 1
            If Asc(UCase(completefile(i))) <= 90 And Asc(UCase(completefile(i))) >= 65 Then
                ' MsgBox(completefile(i))
                If TheCCeaserloader.returndore = True Then
                    holder = enigmac.enigmaencode(Typedchar, UCase(completefile(i)), Cypherbox)
                    'MsgBox(holder)
                Else
                    holder = enigmac.enigmadecode(Typedchar, UCase(completefile(i)), Cypherbox)
                End If

                textdisplay.Text = textdisplay.Text & holder

            End If
        Next
        frequencyanalysis(textdisplay.Text)

    End Sub



    Private Sub railfencego_Click(sender As Object, e As EventArgs) Handles railfencego.Click 'used to perform the railfence cypher
        If TheCCeaserloader.returndore = True Then
            textdisplay.Text = railfenceclasser.railfenceencrypt(completefile, Button4.Text)
        Else
            'MsgBox(Len(completefile))
            textdisplay.Text = railfenceclasser.railfencedecrypt(completefile, Button4.Text)
        End If
        frequencyanalysis(textdisplay.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'used to lower railfence encryption number
        If Button4.Text > 2 Then
            Button4.Text -= 1

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'used to raise railfence encryption number
        If Button4.Text < 7 Then
            Button4.Text += 1

        End If
    End Sub


End Class