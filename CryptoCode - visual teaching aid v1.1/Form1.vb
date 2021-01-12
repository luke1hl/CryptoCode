Public Class Form1
    Protected rotation As Integer = 60
    Protected bitmap1 As Bitmap 'this was origionally when i was trying to get the bitmap to roate by select amounts but I couldn't figure out how so ima make it one of my improvments
    Protected selector As New Selector
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.FormBorderStyle = FormBorderStyle.FixedSingle 'prevents window expanison by user
        ' caesar.Show()
        '  Me.Close()
        bitmap1 = CType(My.Resources.dial11, Bitmap)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize 'this is used for the rotater thing in the middle
        PictureBox1.Image = bitmap1
        selector.initialiseselect(Caesarselect, Select2, Select3, Select4, Select5, Select6)


    End Sub
    Dim rotate As Integer = 4
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click 'use 270 to go other way (make it randomised)
        selector.spin(sender) 'this just calls spin from the selector class which just rotates the selector by a random amount in a random direction
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'this is used for the menu selection to call the correct form
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
