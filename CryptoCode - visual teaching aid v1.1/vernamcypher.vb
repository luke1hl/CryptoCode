Public Class vernamcypher
    Inherits cEncryption
    Protected placeinstring As Integer
    Protected numberofcharactersinstring
    Protected numbercypher As String
    Sub setnumbercypher(number As String) 'whole class is meerly just used to return the places in string and to hold all the super important variables used in vernam as well as containing getters and setters for them
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
