Public Class vernamcypher
    Inherits cEncryption
    Dim placeinstring As Integer
    Dim numberofcharactersinstring
    Dim numbercypher As String
    Sub setnumbercypher(number As String)
        numbercypher = number
    End Sub
    Function returnnumbercypher()
        Return numbercypher
    End Function
    Sub setnumber(number As String)
        numberofcharactersinstring = number
    End Sub
    Function returnnumber()
        Return numberofcharactersinstring
    End Function
End Class
