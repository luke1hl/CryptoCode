﻿Public Class Vernam
    Private Sub Vernam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshers()
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        vernamc.setplaceinstring(0)
        vernamc.setnumber(0)
        vernamc.setplaceincypher(0)
        vernamc.setnumbercypher(0)
        makeeverythingdisapear()
    End Sub
    Dim vernamc As New vernamcypher
    Dim repeater As String
    Private Sub leftarrow_Click(sender As Object, e As EventArgs) Handles leftarrow.Click
        If vernamc.returnplaceinstring > 0 Then
            vernamc.movealongleft()
            Letter.Text = Input.Text(vernamc.returnplaceinstring)
            Cypherletter.Text = repeter.Text(vernamc.returnplaceinstring)

        End If
        refreshers()
    End Sub

    Private Sub rightarrow_Click(sender As Object, e As EventArgs) Handles rightarrow.Click
        If vernamc.returnplaceinstring < Len(Input.Text) - 1 Then
            vernamc.movealongright()
            Letter.Text = Input.Text(vernamc.returnplaceinstring)
            Cypherletter.Text = repeter.Text(vernamc.returnplaceinstring)
        End If
        refreshers()
    End Sub

    Private Sub Input_TextChanged(sender As Object, e As EventArgs) Handles Input.TextChanged
        If Len(TextBox1.Text) > Len(Input.Text) Then 'NEED TO FIX FOR SOME REASON THE TEXT IF INPUT BECOMES LESS IT WONT CALL THIS IF
            MsgBox("")
            vernamc.limitstring(TextBox1.Text, sender, Len(Input.Text))
        End If
        vernamc.limitstring(Input.Text, sender, 10)

        If Len(TextBox1.Text) <> 0 Then
            createrepeater()
        End If

        If vernamc.returnplaceinstring() = vernamc.returnnumber() - 1 Then
            vernamc.setnumber(Len(Input.Text))
            vernamc.setplaceinstring(vernamc.returnnumber - 1)
        End If
        vernamc.setnumber(Len(Input.Text))
        refreshers()
    End Sub
    Private Sub createrepeater()
        repeater = ""
        Dim counter As Integer = 1
        Dim length As Integer = Len(TextBox1.Text)
        For i = 1 To Len(Input.Text)
            If counter > length Then
                counter = 1
            End If
            '  MsgBox(counter & length)
            repeater = repeater & TextBox1.Text(counter - 1)
            counter += 1
        Next
        repeter.Text = repeater
    End Sub

    Sub refreshers()
        vernamc.setplaceincypher(vernamc.returnplaceinstring)
        If Len(TextBox1.Text) > 0 And Len(TextBox1.Text) <= Len(Input.Text) Then
            Cypherletter.Text = repeter.Text(vernamc.returnplaceincypher)
        Else
            If Len(TextBox1.Text) <> 0 Then
                vernamc.limitstring(TextBox1.Text, TextBox1, Len(Input.Text))
            Else
                Cypherletter.Text = ""
            End If
        End If
        If Len(Input.Text) > 0 Then
            Letter.Text = Input.Text(vernamc.returnplaceinstring)
        Else
            Letter.Text = ""
        End If
        binaryequiv.Text = vernamc.convertcharactertobinary(Letter.Text)
        binarycypherequiv.Text = vernamc.convertcharactertobinary(Cypherletter.Text)
        If binaryequiv.Text <> 0 And binarycypherequiv.Text <> 0 Then
            XORBOX.Text = vernamc.DoanXOR(binaryequiv.Text, binarycypherequiv.Text)

        End If
        If XORBOX.Text <> "" Then
            Xordchar.Text = vernamc.binarytochar(XORBOX.Text, True)
            finalcypher.Text = createfinalvernam()
        End If

    End Sub
    Private Function createfinalvernam()
        Dim listofcharacters(Len(Input.Text) - 1) As String
        Dim listofcharcterscypher(Len(repeter.Text) - 1) As String
        Dim listofxored(Len(Input.Text) - 1) As String
        Dim finalstring As String = ""
        For i = 0 To Len(Input.Text) - 1
            listofcharacters(i) = vernamc.convertcharactertobinary(Input.Text(i))
        Next
        For i = 0 To Len(repeter.Text) - 1
            listofcharcterscypher(i) = vernamc.convertcharactertobinary(repeter.Text(i))
        Next
        For i = 0 To Len(repeter.Text) - 1
            listofxored(i) = vernamc.DoanXOR(listofcharacters(i), listofcharcterscypher(i))
        Next
        For i = 0 To Len(repeter.Text) - 1
            finalstring = finalstring & (vernamc.binarytochar(listofxored(i), True))

        Next
        Return finalstring
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        vernamc.limitstring(TextBox1.Text, sender, 10)
        If Len(TextBox1.Text) <> 0 Then
            createrepeater()

        End If
        If Len(TextBox1.Text) > Len(Input.Text) Then
            vernamc.limitstring(TextBox1.Text, sender, Len(Input.Text))
        End If
        If vernamc.returnplaceincypher() = vernamc.returnnumbercypher() - 1 Then
            vernamc.setnumbercypher(Len(TextBox1.Text))
            vernamc.setplaceincypher(vernamc.returnnumbercypher - 1)
        End If
        vernamc.setnumbercypher(Len(TextBox1.Text))
        refreshers()
    End Sub

    Private Sub Menubutton_Click(sender As Object, e As EventArgs) Handles Menubutton.Click
        vernamc.backtothemenu(Me)
    End Sub



    Private Sub curlyarrow1_Click(sender As Object, e As EventArgs) Handles curlyarrow1.Click

    End Sub
    Dim helpon As Boolean = False
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MsgBox("Disclaimer : This vernam represents outputs a cypher string but this visual representation does not work if you attempted to decipher it. If you wish to decipher vernam please use the read in file mode found in the menu")
        If helpon = False Then
            helpon = True
            curlyarrow1.Visible = True
            helplabel1.Visible = True
            curlyarrow2.Visible = True
            helplabel2.Visible = True
            Curlyarrow3.Visible = True
            helplabel3.Visible = True
            curlybracket.Visible = True
            Helplabel4.Visible = True
            curlyarrow5.Visible = True
            helplabel5.Visible = True

        Else
            makeeverythingdisapear()
        End If
    End Sub
    Sub makeeverythingdisapear()
        helpon = False
        curlyarrow1.Visible = False
        helplabel1.Visible = False
        curlyarrow2.Visible = False
        helplabel2.Visible = False
        helplabel3.Visible = False
        Curlyarrow3.Visible = False
        curlybracket.Visible = False
        Helplabel4.Visible = False
        curlyarrow5.Visible = False
        helplabel5.Visible = False
    End Sub
End Class