Public Class enigmaclass
    Protected alphabetqueue As Queue = New Queue()
    Protected alphabettwoqueue As Queue = New Queue()
    Protected alphabetthreequeue As Queue = New Queue()
    Protected alpha As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Protected alphatwo As String = "UDPICOJSXQEWBNGHFARMVTYZKL" 'used as the three enigma alphabets
    Protected alphathree As String = "KOWTAECRHMDXZJQIUFGSPBYVNL"
    Function returnalphabet(number As Integer) 'this will return one of the three predefined alphabets
        If number = 1 Then
            Return alphabetqueue
        ElseIf number = 2 Then
            Return alphabettwoqueue

        ElseIf number = 3 Then
            Return alphabetthreequeue

        End If
    End Function
    Sub updatedisplay(Alphabet As TextBox, Mixedalphabet1 As TextBox, Mixedalphabet2 As TextBox) 'this will update the display on the enigma form
        Alphabet.Text = ""
        Mixedalphabet1.Text = ""
        Mixedalphabet2.Text = ""
        For i = 0 To alphabetqueue.Count - 1
            Alphabet.Text = Alphabet.Text & " " & alphabetqueue(i)

        Next
        For i = 0 To alphabettwoqueue.Count - 1
            Mixedalphabet1.Text = Mixedalphabet1.Text & " " & alphabettwoqueue(i)

        Next
        For i = 0 To alphabetthreequeue.Count - 1
            Mixedalphabet2.Text = Mixedalphabet2.Text & " " & alphabetthreequeue(i)

        Next
    End Sub
    Sub predefinealphabets() 'this is used to turn the alphabets into queues
        For i = 0 To Len(alpha) - 1
            alphabetqueue.Enqueue(alpha(i))
            '  MsgBox(alpha(i))
        Next
        For i = 0 To Len(alphatwo) - 1
            alphabettwoqueue.Enqueue(alphatwo(i))
            ' MsgBox(alphatwo(i))
        Next
        For i = 0 To Len(alphathree) - 1
            alphabetthreequeue.Enqueue(alphathree(i))
            '  MsgBox(alphathree(i))
        Next
    End Sub
    Function enigmaencodeforgame(e As Char) 'this is just a slight alteration on the enigma encode so it works when encrypting the words in the game
        Dim characterholder As Char = ""
        For i = 0 To alphabetqueue.Count - 1
            If alphabetqueue(i) = e Then
                characterholder = alphabettwoqueue(i)
                Exit For

            End If
        Next
        For i = 0 To alphabetqueue.Count - 1
            If alphabetqueue(i) = characterholder Then
                characterholder = alphabetthreequeue(i)

                Exit For

            End If
        Next
        enigmashuffle()
        Return characterholder
    End Function
    Function enigmaencode(typedchar As TextBox, e As Char, Cypherbox As TextBox) 'this is used to encode whatever letter is pushed
        Dim charholder As Char = ""

        typedchar.Text = e
        For i = 0 To alphabetqueue.Count - 1
            If alphabetqueue(i) = e Then
                charholder = alphabettwoqueue(i)
                Exit For

            End If
        Next
        For i = 0 To alphabetqueue.Count - 1
            If alphabetqueue(i) = charholder Then
                charholder = alphabetthreequeue(i)
                Cypherbox.Text = charholder
                Exit For

            End If
        Next
        enigmashuffle()
        Return charholder
    End Function
    Function enigmadecode(typedchar As TextBox, e As Char, Cypherbox As TextBox) 'this is used to decode whatever letter is pushed
        Dim charholder As Char = ""

        typedchar.Text = e
        For i = 0 To alphabetthreequeue.Count - 1
            If alphabetthreequeue(i) = e Then
                charholder = alphabetqueue(i)
                Exit For

            End If
        Next
        ' MsgBox(charholder)
        For i = 0 To alphabetthreequeue.Count - 1
            If alphabettwoqueue(i) = charholder Then
                charholder = alphabetqueue(i)
                Cypherbox.Text = charholder
                Exit For

            End If
        Next
        enigmashuffle()
        Return charholder
    End Function
    Sub enigmashuffle() 'this shuffles the alphabets by one
        ' MsgBox("shuffle")
        Dim holder As String = "" 'used to check if something has completed a total shuffle
        alphabetqueue.Enqueue(alphabetqueue.Dequeue)
        For i = 0 To alphabetqueue.Count - 1
            holder = holder & alphabetqueue(i)
        Next
        If holder = alpha Then
            alphabettwoqueue.Enqueue(alphabettwoqueue.Dequeue)
            holder = ""
            For i = 0 To alphabettwoqueue.Count - 1
                holder = holder & alphabettwoqueue(i)

            Next
            If holder = alphatwo Then
                alphabetthreequeue.Enqueue(alphabetthreequeue.Dequeue)

            End If
        End If
    End Sub
End Class
