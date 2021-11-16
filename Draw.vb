Module Draw
    Class SplineSeg
        Public Property SplineType As String
        Public Coord1, Coord2, Coord3, Coord4 As System.Drawing.Point
        Public Angle As Double
        Public Length As Double

        Public Sub GetAttrFromString(instr As String)
            Dim pos1, pos2 As Long
            If Left(instr, 3) = "$01" Then SplineType = "Curve"
            firstpos = instr.IndexOf("(")

            If Left(instr, 3) = "$02" Then SplineType = "Line"

            'Coord1.X = Left()
        End Sub
    End Class
    Public Sub DrawLineSegment()

    End Sub
    Public Sub Parser()
        Dim tempstr As String = "$02(558.942,618.93;587.095,607.116;347.298,352.514;347.298,363.024)"
        Dim wa As New SplineSeg
        wa.GetAttrFromString(tempstr)
        Debug.Print(wa.SplineType)
    End Sub
End Module
