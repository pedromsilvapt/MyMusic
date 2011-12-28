Module Utils

    Public Function SplitKeywords(ByRef Text As String, ByVal Split As String) As String()
        Dim arr As String()

        arr = Text.Split(Split)
        For i As Integer = 0 To arr.Length - 1 Step 1
            arr(i) = Trim(arr(i))
        Next
        Return arr
    End Function

    Public Function JoinKeywords(ByRef arr As String(), ByVal Split As String) As String
        For i As Integer = 0 To arr.Length - 1 Step 1
            arr(i) = Trim(arr(i))
        Next

        Dim text As String = Join(arr, Split)
        Return text
    End Function

End Module
