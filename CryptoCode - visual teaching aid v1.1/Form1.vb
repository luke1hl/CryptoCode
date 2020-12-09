Public Class Form1
    Dim rotation As Integer = 60
    Dim bitmap1 As Bitmap
    Dim selector As New Selector
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        ' caesar.Show()
        '  Me.Close()
        bitmap1 = CType(My.Resources.dial11, Bitmap)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.Image = bitmap1
        selector.initialiseselect(Caesarselect, Select2, Select3, Select4, Select5, Select6)


    End Sub
    Dim rotate As Integer = 4
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click 'use 270 to go other way (make it randomised)
        selector.spin(sender)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If selector.returnselect() = 0 Then
            Dim caesar As New Caesar_Cypher
            caesar.Show()
            Me.Close()
        ElseIf selector.returnselect() = 1 Then
            Dim vernam As New Vernam
            vernam.Show()
            Me.Close()
        ElseIf selector.returnselect() = 2 Then
            Dim enigma As New Engima 'i can't spell but ive started spelling it like this so its staying as engima
            enigma.Show()
            Me.Close()
        ElseIf selector.returnselect() = 3 Then
            Dim railfencer As New Railfence
            railfencer.Show()
            Me.Close()
        ElseIf selector.returnselect() = 4 Then
            Dim fileencrypter As New FileEncrypterMenu
            fileencrypter.Show()
            Me.Close()
        ElseIf selector.returnselect() = 5 Then
            Dim game As New recallgame
            game.Show()
            Me.Close()
        End If
    End Sub


End Class
