Public Class Selector
    Inherits cEncryption
    Private options(5) As Panel

    Private random As Integer
    Private currentselect As Integer
    Sub initialiseselect(caesarselect As Panel, select2 As Panel, select3 As Panel, select4 As Panel, select5 As Panel, select6 As Panel)
        currentselect = 0

        options(0) = caesarselect
        options(1) = select2
        options(2) = select3
        options(3) = select4
        options(4) = select5
        options(5) = select6
        options(0).BackColor = Color.Green
    End Sub
    Function returnselect()
        Return currentselect
    End Function
    Sub rotateoption()
        options(currentselect).BackColor = Color.Silver
        If currentselect = 5 Then
            currentselect = 0
        Else
            currentselect += 1

        End If
        options(currentselect).BackColor = Color.Green

    End Sub
    Sub spin(PictureBox1)
        random = returnrandomnumber(1, 2)
        If random = 1 Then
            For i = 1 To returnrandomnumber(1, 5)
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
                PictureBox1.Refresh()
                Threading.Thread.Sleep(200)
            Next

        Else
            For i = 1 To returnrandomnumber(1, 5)
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
                PictureBox1.Refresh()
                Threading.Thread.Sleep(200)
            Next
        End If
        rotateoption()
    End Sub


End Class
