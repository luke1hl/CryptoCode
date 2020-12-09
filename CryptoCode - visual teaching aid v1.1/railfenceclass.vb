Public Class railfenceclass
    Function railfenceencrypt(input As String, numberofrows As Integer)
        Dim final As String = ""

        For i = 0 To numberofrows - 1
            For r = i To Len(input) Step numberofrows
                If r < Len(input) Then
                    final = final & input(r)
                Else
                    final = final & "℗"
                End If
            Next
        Next
        Return final
    End Function
    Function railfencedecrypt(input As String, numberofrows As Integer)
        Dim final As String = ""
        ' MsgBox(Len(input))
        Dim nocols As Integer = Math.Ceiling(Len(input) / numberofrows)
        '  MsgBox(nocols)
        For i = 0 To nocols - 1
            For r = i To Len(input) Step nocols
                ' MsgBox(r & " " & input(r))
                If r < Len(input) Then
                    If input(r) <> "℗" Then
                        final = final & input(r)

                    End If
                End If
            Next
        Next
        Return final
    End Function
End Class
