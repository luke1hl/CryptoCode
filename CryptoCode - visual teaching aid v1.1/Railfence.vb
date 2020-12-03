Public Class Railfence
    Dim completestring As String = ""
    Private Sub Railfence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.KeyPreview = True

    End Sub
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
    End Sub
    Private Sub movestuff()
        Dim xfive As Integer = letterfive.Location.X
        Dim xthree As Integer = letterthree.Location.X
        Dim xfour As Integer = letterfour.Location.X
        For i = 0 To 70
            lettertwo.Top += 1
        Next
        For i = 0 To 70
            letterfour.Top += 1
        Next
        Threading.Thread.Sleep(1000)
        Dim x As Integer
        x = lettertwo.Location.X
        While letterthree.Location.X <> x
            letterthree.Left -= 1
        End While

        While letterfive.Location.X <> xthree
            letterfive.Left -= 1
        End While
        Threading.Thread.Sleep(1000)
        While lettertwo.Location.X <> xfour
            lettertwo.Left += 1
        End While
        While letterfour.Location.X <> xfive
            letterfour.Left += 1
        End While
        'Threading.Thread.Sleep(1000)
        For i = 0 To 70
            lettertwo.Top -= 1
        Next
        For i = 0 To 70
            letterfour.Top -= 1
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If letterone.Text <> "" And lettertwo.Text <> "" And letterthree.Text <> "" And letterfour.Text <> "" And letterfive.Text <> "" Then
            Button1.Visible = False

            movestuff()
        Else
            MsgBox("please make sure you input a five letter string")
        End If

    End Sub
End Class