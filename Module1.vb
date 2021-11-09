Module Module1
#Region "GCode prepare"
    Public Function SetOutString(ByVal N As Long, ByVal GcodeS As String) As String
        Dim i As Long = 1
        Dim str As String = Nothing
        For i = 0 To Len(GcodeS) - 1
            If GcodeS(i) = ";" Or GcodeS(i) = vbCrLf Then Exit For Else str = str & GcodeS(i)
        Next i
        SetOutString = "N" & N & " " & str & "*" & CheckSum("N" & N & " " & str)
        Return SetOutString
    End Function
    ''' <summary>
    ''' Расчет контрольной суммы пакета
    ''' </summary>
    ''' <param name="indata"></param>
    ''' <returns></returns>
    Private Function CheckSum(ByVal indata As String) As Byte
        Dim i As Long
        CheckSum = 0
        For i = 1 To Len(indata)
            CheckSum = CheckSum Xor Asc(indata(i - 1))
        Next
        Return CheckSum
    End Function
    Public Function SendGCodeWA(Num As Long, Command As String, port As String) As String

        MainForm.SP.WriteLine(SetOutString(Num, Command))
        Return "ok"
    End Function
#End Region

#Region "File reader"

#End Region
End Module
