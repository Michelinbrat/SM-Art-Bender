Module Macro

    Public CutProgram As List(Of String)
    Private SawMotorOn = "M3"
    Private Function AngleToPosition(angle As Double, dir As Direction) As Double
        Return AngleToPosition = XPositionZero + dir * (Math.PI * MachineRadius * (angle / 2 - ToolAngle / 2) / 180)
    End Function
    Public Sub Cut(CutAngle As Double, AngleFeed As Long, CutLength As Double, CutFeed As Long, retract As Double)
        With CutProgram
            .Add(SawMotorOn)
            .Add("M1 S1") ' Пауза 1 с
            .Add("G0 Y" & CutAngle & " F" & AngleFeed) ' поворот на угол реза 1
            .Add("M400")
            .Add("GO X" & CutLength & " F" & CutFeed) 'Резка 1
            .Add("M400")
            .Add("G0 Y" & -CutAngle & " F" & AngleFeed) ' поворот на угол реза 2
        End With

    End Sub
End Module
