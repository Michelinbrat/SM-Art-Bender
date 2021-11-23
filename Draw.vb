Imports System.Drawing.Drawing2D
Imports Microsoft.VisualBasic.FileIO
Module Draw
    Public GCodeLine() As SplineSeg
    Structure SplineSeg
        Dim SegmentType As String
        Public Property SegType As String
            Get
                Return SegmentType
            End Get
            Set(ByVal val As String)
                SegmentType = val
            End Set
        End Property
        Public SegPoints As Point()
        Public Angle As Double
        Public Length As Double

    End Structure
    Public Function GetPointArrFromString(instr As String) As Point()
        Dim pos1, pos3 As Integer
        Dim Arrstr(8) As String
        Dim tempstr As String
        Dim pointsarr() As Point

        Select Case Left(instr, 3)
            Case "$02"
                'ReDim GetPointArrFromString(4) 'SplineType = "Curve"
                ReDim pointsarr(4)
                pos1 = instr.IndexOf("(") 'Ищем скобку (
                pos3 = instr.LastIndexOf(")")
                tempstr = instr.Substring(pos1 + 1, pos3 - pos1 - 1)

                Arrstr = tempstr.Split(";")

                pointsarr(0).X = Arrstr(0)
                pointsarr(0).Y = Arrstr(1)
                pointsarr(1).X = Arrstr(2)
                pointsarr(1).Y = Arrstr(3)
                pointsarr(2).X = Arrstr(4)
                pointsarr(2).Y = Arrstr(5)
                pointsarr(3).X = Arrstr(6)
                pointsarr(3).Y = Arrstr(7)

                tempstr = instr.Substring(0, instr.IndexOf("("))
                Arrstr = tempstr.Split(";")
                'Length = Arrstr(1)

                Return pointsarr

            Case "$01"
                'ReDim GetPointArrFromString(2)
                ReDim pointsarr(2)
                'SplineType = "Line"
                pos1 = instr.IndexOf("(") 'Ищем скобку (
                pos3 = instr.LastIndexOf(")")
                tempstr = instr.Substring(pos1 + 1, pos3 - pos1 - 1)

                Arrstr = tempstr.Split(";")

                pointsarr(0).X = Arrstr(0)
                pointsarr(0).Y = Arrstr(1)
                pointsarr(1).X = Arrstr(2)
                pointsarr(1).Y = Arrstr(3)

                tempstr = instr.Substring(0, instr.IndexOf("("))
                Arrstr = tempstr.Split(";")
                'Length = Arrstr(1)
                'Angle = Arrstr(2)
                Return pointsarr

        End Select
    End Function
    Public Sub LoadFile()

        Using fileReader As System.IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader("F:\binder.txt")

            Dim stringReader As String
            Dim lines As Long = 0
            Dim stringtype As String

            Do

                stringReader = fileReader.ReadLine()
                stringtype = Left(stringReader, 3)
                Select Case stringtype

                    Case "$02"
                        GCodeLine(lines).SegPoints = GetPointArrFromString(stringReader)
                        GCodeLine(lines).SegmentType = "Curve"

                    Case "$01"

                        GCodeLine(lines).SegPoints = GetPointArrFromString(stringReader)
                        GCodeLine(lines).SegmentType = "Line"
                    Case Else
                End Select
                lines = lines + 1
                ReDim Preserve GCodeLine(lines)
            Loop Until fileReader.EndOfStream
            MsgBox(lines)
        End Using
        DrawOnForm()
    End Sub

    Public Sub DrawOnForm()
        Dim n As Long
        Using redPen As New Pen(Color.Red),
            formGraphics As Graphics = MainForm.PictureBox1.CreateGraphics()
            formGraphics.DrawLine(redPen, 0, 0, 200, 200)
            Debug.Print("start")
            For n = 0 To GCodeLine.GetUpperBound(0)
                'Debug.Print(GCodeLine(n).Coord1.X)
                If GCodeLine(n).SegType = "Curve" Then formGraphics.DrawBeziers(redPen, GCodeLine(n).SegPoints)
                'If GCodeLine(n).SplineType = "Line" Then formGraphics.DrawLines(redPen, GCodeLine(n).PointsArr)
                'If GCodeLine(n).SplineType = "Line" Then formGraphics.DrawLine(redPen, 45, 60, 100, 100)
            Next
        End Using

    End Sub
End Module
