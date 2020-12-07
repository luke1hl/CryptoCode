Public Class Railfence
    Dim completestring As String = ""

    Private Sub Railfence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Label1.Text = TrackBar1.Value
        xone = letterone.Location.X
        xtwo = lettertwo.Location.X
        xthree = letterthree.Location.X
        xfour = letterfour.Location.X
        xfive = letterfive.Location.X
        xsix = lettersix.Location.X
        xseven = letterseven.Location.X
        xeight = lettereight.Location.X

        letterone.Enabled = False
        lettertwo.Enabled = False
        letterthree.Enabled = False
        letterfour.Enabled = False
        letterfive.Enabled = False
        lettersix.Enabled = False
        letterseven.Enabled = False
        lettereight.Enabled = False
    End Sub
    Dim xone As Integer
    Dim xtwo As Integer
    Dim xthree As Integer
    Dim xfour As Integer
    Dim xfive As Integer
    Dim xsix As Integer
    Dim xseven As Integer
    Dim xeight As Integer
    Private Sub Engima_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyValue <= 90 And e.KeyValue >= 65 Or Chr(e.KeyValue) = " " Then
            If Len(completestring) < 8 Then
                completestring = completestring & Chr(e.KeyValue)

            End If
        ElseIf e.KeyValue = 8 Then
            Dim holder As String = ""
            For i = 0 To Len(completestring) - 2
                holder = holder & completestring(i)

            Next
            completestring = holder
        End If
        updatedisplay()
    End Sub
    Private Sub updatedisplay()
        letterone.Text = ""
        lettertwo.Text = ""
        letterthree.Text = ""
        letterfour.Text = ""
        letterfive.Text = ""
        lettersix.Text = ""
        letterseven.Text = ""
        lettereight.Text = ""

        For i = 0 To Len(completestring) - 1
            If i = 0 Then
                letterone.Text = completestring(i)
            ElseIf i = 1 Then
                lettertwo.Text = completestring(i)
            ElseIf i = 2 Then
                letterthree.Text = completestring(i)
            ElseIf i = 3 Then
                letterfour.Text = completestring(i)
            ElseIf i = 4 Then
                letterfive.Text = completestring(i)
            ElseIf i = 5 Then
                lettersix.Text = completestring(i)
            ElseIf i = 6 Then
                letterseven.Text = completestring(i)
            ElseIf i = 7 Then
                lettereight.Text = completestring(i)
            End If
        Next
        TextBox1.Text = ""
    End Sub

    Private Sub movestufftwo()

        For i = 0 To 70
            lettertwo.Top += 1
            Refresh()

        Next
        For i = 0 To 70
            letterfour.Top += 1
            Refresh()

        Next
        For i = 0 To 70
            lettersix.Top += 1
            Refresh()

        Next
        For i = 0 To 70
            lettereight.Top += 1
            Refresh()

        Next
        Threading.Thread.Sleep(1000)

        While letterthree.Location.X <> xtwo
            letterthree.Left -= 1
            Refresh()

        End While
        ' MsgBox("")

        While letterfive.Location.X <> xthree
            letterfive.Left -= 1
            Refresh()

        End While
        While letterseven.Location.X <> xfour
            letterseven.Left -= 1
            Refresh()

        End While
        Threading.Thread.Sleep(1000)


        While lettertwo.Location.X <> xfive
            lettertwo.Left += 1
            Refresh()

        End While
        While letterfour.Location.X <> xsix
            letterfour.Left += 1
            Refresh()

        End While
        While lettersix.Location.X <> xseven
            lettersix.Left += 1
            Refresh()

        End While
        ' Threading.Thread.Sleep(1000)
        For i = 0 To 70
            lettertwo.Top -= 1
            Refresh()

        Next
        For i = 0 To 70
            letterfour.Top -= 1
            Refresh()

        Next
        For i = 0 To 70
            lettersix.Top -= 1
            Refresh()

        Next
        For i = 0 To 70
            lettereight.Top -= 1
            Refresh()

        Next
    End Sub
    Private Sub movestuffthree()
        For i = 0 To 70
            lettertwo.Top += 1
            Refresh()
        Next
        For i = 0 To 140
            letterthree.Top += 1
            Refresh()

        Next
        For i = 0 To 70
            letterfive.Top += 1
            Refresh()

        Next
        For i = 0 To 140
            lettersix.Top += 1
            Refresh()

        Next
        For i = 0 To 70
            lettereight.Top += 1
            Refresh()

        Next
        Threading.Thread.Sleep(1000)
        While letterfour.Location.X <> xtwo
            letterfour.Left -= 1
            Refresh()
        End While
        While letterseven.Location.X <> xthree
            letterseven.Left -= 1
            Refresh()
        End While
        While lettereight.Location.X <> xsix
            lettereight.Left -= 1
            Refresh()
        End While

        Threading.Thread.Sleep(1000)
        While lettertwo.Location.X <> xfour
            lettertwo.Left += 1
            Refresh()
        End While
        While letterfive.Location.X <> xfive
            lettersix.Left -= 1
            Refresh()
        End While
        Threading.Thread.Sleep(1000)
        While letterthree.Location.X <> xseven
            letterthree.Left += 1
            Refresh()
        End While
        While lettersix.Location.X <> xeight
            lettersix.Left += 1
            Refresh()

        End While
        Threading.Thread.Sleep(1000)
        For i = 0 To 70
            lettertwo.Top -= 1
            Refresh()

        Next
        For i = 0 To 140
            letterthree.Top -= 1
            Refresh()

        Next
        For i = 0 To 70
            letterfive.Top -= 1
            Refresh()

        Next
        For i = 0 To 140
            lettersix.Top -= 1
            Refresh()

        Next
        For i = 0 To 70
            lettereight.Top -= 1
            Refresh()

        Next
    End Sub
    Private Sub movestufffour()
        For i = 0 To 70
            lettertwo.Top += 1
            Refresh()

        Next
        For i = 0 To 140
            letterthree.Top += 1
            Refresh()

        Next
        For i = 0 To 210
            letterfour.Top += 1
            Refresh()

        Next
        For i = 0 To 70
            lettersix.Top += 1
            Refresh()

        Next
        For i = 0 To 140
            letterseven.Top += 1
            Refresh()

        Next
        For i = 0 To 210
            lettereight.Top += 1
            Refresh()

        Next
        Threading.Thread.Sleep(1000)

        While letterfive.Location.X <> xtwo
            letterfive.Left -= 1
            Refresh()

        End While
        Threading.Thread.Sleep(1000)
        'two to three and six to four
        While lettertwo.Location.X <> xthree
            lettertwo.Left += 1
            Refresh()

        End While
        While lettersix.Location.X <> xfour
            lettersix.Left -= 1
            Refresh()

        End While
        'three to five and seven to six
        While letterthree.Location.X <> xfive
            letterthree.Left += 1
            Refresh()

        End While
        While letterseven.Location.X <> xsix
            letterseven.Left -= 1
            Refresh()

        End While
        While letterfour.Location.X <> xseven
            letterfour.Left += 1
            Refresh()

        End While
        Threading.Thread.Sleep(1000)
        For i = 0 To 70
            lettertwo.Top -= 1
            Refresh()

        Next
        For i = 0 To 140
            letterthree.Top -= 1
            Refresh()

        Next
        For i = 0 To 210
            letterfour.Top -= 1
            Refresh()

        Next
        For i = 0 To 70
            lettersix.Top -= 1
            Refresh()

        Next
        For i = 0 To 140
            letterseven.Top -= 1
            Refresh()

        Next
        For i = 0 To 210
            lettereight.Top -= 1
            Refresh()

        Next

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If letterone.Text <> "" And lettertwo.Text <> "" And letterthree.Text <> "" And letterfour.Text <> "" And letterfive.Text <> "" And lettersix.Text <> "" And letterseven.Text <> "" And lettereight.Text <> "" Then
            Button1.Visible = False
            TrackBar1.Visible = False
            Label1.Visible = False
            If TrackBar1.Value = 2 Then
                movestufftwo()
            ElseIf TrackBar1.Value = 3 Then
                movestuffthree()
            ElseIf TrackBar1.Value = 4 Then
                movestufffour()
            End If
        Else
            MsgBox("please make sure you input a 8 character string")
        End If

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Label1.Text = TrackBar1.Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim menuitem As New Form1
        menuitem.Show()
        Me.Close()
    End Sub
End Class