Imports System.Drawing.Drawing2D
Imports Microsoft.VisualBasic.FileIO
Module Draw
    Public GCodeLine() As SplineSeg = Nothing
    Structure SplineSeg
        Public Property SplineType As String
        Private Enum segtype
            Line
            Bezier
            BezierApprox
        End Enum

        Public Coord1, Coord2, Coord3, Coord4 As Point
        Public Angle As Double
        Public Length As Double
        Public tempstr As String
        Public PointsArr As Point()

        Public Sub GetAttrFromString(instr As String)
            Dim pos1, pos3 As Integer
            Dim Arrstr() As String
            If Left(instr, 3) = "$02" Then
                SplineType = "Curve"

                pos1 = instr.IndexOf("(") 'Ищем скобку (
                pos3 = instr.LastIndexOf(")")
                tempstr = instr.Substring(pos1 + 1, pos3 - pos1 - 1)

                Arrstr = tempstr.Split(";")

                Coord1.X = Arrstr(0)
                Coord1.Y = Arrstr(1)
                Coord2.X = Arrstr(2)
                Coord2.Y = Arrstr(3)
                Coord3.X = Arrstr(4)
                Coord3.Y = Arrstr(5)
                Coord4.X = Arrstr(6)
                Coord4.Y = Arrstr(7)

                tempstr = instr.Substring(0, instr.IndexOf("("))
                Arrstr = tempstr.Split(";")
                Length = Arrstr(1)
                ReDim PointsArr(4)
                PointsArr(0).X = Coord1.X
                PointsArr(0).Y = Coord1.Y
                PointsArr(1).X = Coord2.X
                PointsArr(1).Y = Coord2.Y
                PointsArr(2).X = Coord3.X
                PointsArr(2).Y = Coord3.Y
                PointsArr(3).X = Coord4.X
                PointsArr(3).Y = Coord4.Y
            End If

            If Left(instr, 3) = "$01" Then

                SplineType = "Line"
                pos1 = instr.IndexOf("(") 'Ищем скобку (
                pos3 = instr.LastIndexOf(")")
                tempstr = instr.Substring(pos1 + 1, pos3 - pos1 - 1)

                Arrstr = tempstr.Split(";")

                Coord1.X = Arrstr(0)
                Coord1.Y = Arrstr(1)
                Coord2.X = Arrstr(2)
                Coord2.Y = Arrstr(3)

                tempstr = instr.Substring(0, instr.IndexOf("("))
                Arrstr = tempstr.Split(";")
                Length = Arrstr(1)
                Angle = Arrstr(2)
                ReDim PointsArr(2)
                PointsArr(0).X = Coord1.X
                PointsArr(0).Y = Coord1.Y
                PointsArr(1).X = Coord2.X
                PointsArr(1).Y = Coord2.Y
            End If
        End Sub
    End Structure
    Public Sub LoadFile()

        Using fileReader As System.IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader("F:\binder.txt")

            Dim stringReader As String
            Dim lines As Long = 0


            Do

                stringReader = fileReader.ReadLine()
                If Left(stringReader, 2) = "$0" Then
                    GCodeLine(lines).GetAttrFromString(stringReader)
                    lines = lines + 1
                    ReDim GCodeLine(lines)
                Else
                    MsgBox("Ошибка чтения файла")
                    Exit Sub
                End If

            Loop Until fileReader.EndOfStream
            MsgBox(lines)
        End Using

    End Sub
    Public Sub Parser()
        Dim tempstr2 As String = "$02;63,303(558,942;618,93;587,095;607,116;347,298;352,514;347,298;363,024)"
        Dim tempstr As String = "$01;85,226;0(473,715;347,298;558,942;347,298)"
        Dim wa As New SplineSeg
        wa.GetAttrFromString(tempstr)
        Debug.Print(wa.Coord1.X)
        Debug.Print(wa.Coord1.Y)
        Debug.Print(wa.Coord2.X)
        Debug.Print(wa.Coord2.Y)
        Debug.Print(wa.Length)
        Debug.Print(wa.Angle)
    End Sub
    Public Sub DrawOnForm()
        Using redPen As New Pen(Color.Red),
            formGraphics As Graphics = MainForm.PictureBox1.CreateGraphics()
            formGraphics.DrawLine(redPen, 0, 0, 200, 200)
            For n = 0 To GCodeLine.Length
                If GCodeLine(n).SplineType = "line" Then

                End If
            Next
        End Using

    End Sub
End Module
