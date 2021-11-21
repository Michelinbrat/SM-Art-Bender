Imports System.Drawing.Drawing2D
Imports Microsoft.VisualBasic.FileIO
Module Draw
    Public GCodeLine() As SplineSeg
    Structure SplineSeg

        Public Property SegType As String
            Get
                Return
            End Get
            Set
                SegType = "ssdvc"
            End Set
        End Property
        Public SegPoints As Point()
        Public Angle As Double
        Public Length As Double

    End Structure
    Public Function GetPointArrFromString(instr As String) As Point()
        Dim pos1, pos3 As Integer
        Dim Arrstr() As String
        Dim tempstr As String
        Dim pointsarr(8) As Point
        Select Case Left(instr, 3)
            Case "$02"
                'SplineType = "Curve"
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


            Do
                ReDim GCodeLine(lines + 1)
                stringReader = fileReader.ReadLine()
                If Left(stringReader, 3) = "$02" Then
                    GCodeLine(lines).SegPoints = GetPointArrFromString(stringReader)
                    GCodeLine(lines).SegType.Curve
                    lines = lines + 1

                Else
                    'MsgBox("Ошибка чтения файла")
                    'Exit Sub
                End If

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
                If GCodeLine(n).SegType.Curve Then Debug.Print("New" & GCodeLine(n).SplineType) : formGraphics.DrawBeziers(redPen, GCodeLine(n).PointsArr)
                'If GCodeLine(n).SplineType = "Line" Then formGraphics.DrawLines(redPen, GCodeLine(n).PointsArr)
                'If GCodeLine(n).SplineType = "Line" Then formGraphics.DrawLine(redPen, 45, 60, 100, 100)
                Next
        End Using

    End Sub
End Module
