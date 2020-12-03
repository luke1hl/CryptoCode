Public Class cfileencryptermenu
    Dim currentlyselectedmethod As String = ""
    Dim encryptordecrypt As Boolean
    Dim choiceselected As Boolean = False
    Function returnchoiceselected()
        Return choiceselected
    End Function
    Sub setchoiceselected()
        choiceselected = True
    End Sub
    Function returncurrentlyselected()
        Return currentlyselectedmethod
    End Function
    Sub setmethod(method As String)
        currentlyselectedmethod = method
    End Sub
    Function returnecnryptordecrypt()
        Return encryptordecrypt
    End Function
    Sub setencryptordecrypt(choice As Boolean)
        encryptordecrypt = choice
    End Sub
End Class
