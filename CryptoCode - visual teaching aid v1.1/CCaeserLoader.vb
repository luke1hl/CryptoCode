Public Class CCaeserLoader 'used to set encrypt or decrypt for the file loader
    Inherits cEncryption
    Protected dore As Boolean 'decrypt or encrypt

    Sub setdore(choice As Boolean)
        dore = choice
    End Sub
    Function returndore()
        Return dore

    End Function

End Class
