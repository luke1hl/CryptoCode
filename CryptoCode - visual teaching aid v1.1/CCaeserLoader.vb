Public Class CCaeserLoader
    Inherits cEncryption
    Dim dore As Boolean

    Sub setdore(choice As Boolean)
        dore = choice
    End Sub
    Function returndore()
        Return dore

    End Function

End Class
