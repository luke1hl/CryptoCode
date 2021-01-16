Public Class cfileencryptermenu
    Protected currentlyselectedmethod As String = ""
    Protected encryptordecrypt As Boolean
    Protected choiceselected As Boolean = False
    Function returnchoiceselected() 'this is basically all to return to the file encrypter what type of encryption im using and wether im encrypting or decrypting
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
