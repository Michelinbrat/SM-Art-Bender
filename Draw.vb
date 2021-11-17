Imports System.Drawing.Drawing2D
Imports Microsoft.VisualBasic.FileIO
Module Draw
    Public GCodeLine() As SplineSeg = Nothing
    Structure SplineSeg
        Private Property SplineType As String
        Public Coord1, Coord2, Coord3, Coord4 As Point
        Public Angle As Double
        Public Length As Double
        Public tempstr As String

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
            formGraphics.DrawBeziers()
        End Using

    End Sub
End Module
