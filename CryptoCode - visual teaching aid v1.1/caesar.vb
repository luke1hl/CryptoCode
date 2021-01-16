Public Class caesar
    Inherits cEncryption
    Protected currenttyping As Boolean = True
    Protected cyphercode As Integer 'used for the roation code
    Protected cyphertext As String
    Sub setcyphercode(code As Integer)   'sets the cypher code when called
        cyphercode = code
    End Sub
    Function returncyphercode() 'returns what the cypher code is
        Return cyphercode
    End Function
    Sub setcurrentype(bol As Boolean) 'sets wether its an encrypt or decrypt
        currenttyping = bol
    End Sub
    Function returncurrent()
        Return currenttyping
    End Function

    Public Overrides Sub encrypt()

    End Sub
    Sub decryptceasercypher(cyphertext As String, textbox As TextBox, cypher As Integer) 'will decrypt the ceaser cypher
        setplaintext("")
        cyphercode = cypher
        Dim holder As Integer

        For i = 0 To Len(cyphertext) - 1
            holder = Asc(cyphertext(i))
            holder -= cyphercode
            setplaintext(returnplaintext() & " " & Chr(holder))
            ' MsgBox(returnplaintext())
        Next
        If textbox.ForeColor <> Color.Salmon Then 'removes the spaces that are used for alphabet from final string by detecting textbox text color
            textbox.Text = returnplaintext()
        Else
            textbox.Text = returnplaintext().Where(Function(x) Not Char.IsWhiteSpace(x)).ToArray()

        End If

    End Sub
    Function ceasercypheringame(plaintext As String, cypher As Integer) 'specific ceaser cypher code to make sure the formatting used in the game is not particuarly weird

        setcyphertext("")
        cyphercode = cypher
        Dim holder As Integer

        For i = 0 To Len(plaintext) - 1
            holder = Asc(plaintext(i))
            holder += cyphercode
            setcyphertext(returncyphertext() & " " & Chr(holder))
        Next
        Return returncyphertext() 'returns the cypher result
    End Function
    Sub ceasercypher(plaintext As String, textbox As TextBox, Cypher As Integer) 'cyphers the text
        setcyphertext("")
        cyphercode = Cypher
        Dim holder As Integer

        For i = 0 To Len(plaintext) - 1
            holder = Asc(plaintext(i))
            holder += cyphercode
            setcyphertext(returncyphertext() & " " & Chr(holder))
        Next
        If textbox.ForeColor <> Color.Salmon Then 'removes the spaces that are used for alphabet from final string by detecting textbox text color
            textbox.Text = returncyphertext()
        Else
            textbox.Text = returncyphertext().Where(Function(x) Not Char.IsWhiteSpace(x)).ToArray()

        End If
    End Sub


End Class
