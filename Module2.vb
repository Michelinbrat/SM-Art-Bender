Imports CorelDRAW

Module Module2



    ' *********************************************Действующий экспортер**********************************************
    Public Sub BinderExport(sr As ShapeRange)
        Dim Gcodefilename As String
        Dim BegX As Double
        Dim BegY As Double
        Dim EndX As Double
        Dim EndY As Double
        Dim seg As Segment

        Dim k As Long
        Dim Xend, Yend As Double
        Gcodefilename = "F:\binder.txt"
        'If fileexist Then Kill Gcodefilename
        FileOpen(1, Gcodefilename, OpenMode.Append, OpenAccess.Write)



        FileSystem.Print(1, ";************************** Vector task processing***********************")


        On Error Resume Next
        For k = 1 To sr.Count

            For Each seg In sr(k).DisplayCurve.Segments
                BegX = seg.StartNode.PositionX
                BegY = seg.StartNode.PositionY
                EndX = seg.EndNode.PositionX
                EndY = seg.EndNode.PositionY
                If seg.Index = 1 Then
                    Print(1, "Start Position: X" & DigToStr(BegX) & " Y" & DigToStr(BegY))

                End If

                Select Case seg.Type
                    Case VGCore.cdrSegmentType.cdrLineSegment


                        Print(1, "Line: X:" & DigToStr(EndX) & " Y:" & DigToStr(EndY))
                        Print(1, "Angle: :" & seg.GetTangentAt)
                    Case VGCore.cdrSegmentType.cdrCurveSegment
                        Print(1, "Curve: " &
                    " bx:" & DigToStr(BegX) &
                    " ex:" & DigToStr(EndX) &
                    " by:" & DigToStr(BegY) &
                    " ey:" & DigToStr(EndY) &
                    " scpx" & DigToStr(seg.StartingControlPointX) &
                    " ecpx" & DigToStr(seg.EndingControlPointX) &
                    " scpy" & DigToStr(seg.StartingControlPointY) &
                    " ecpy" & DigToStr(seg.EndingControlPointY))

                End Select
            Next seg

        Next k
        Print(1, ";************* End Vector task****************************")
        FileSystem.FileClose(1)
    End Sub

    Private Function DigToStr(ByVal Number As Double) As String
        Dim number2 As String
        number2 = CStr(Math.Round(Number, 3))
        DigToStr = Replace(number2, ",", ".", , , vbTextCompare)
    End Function
    Private Sub UserForm_Click()

    End Sub

    Private Sub UserForm_Initialize()
        ActiveDocument.Unit = cdrMillimeter
    End Sub

End Module
