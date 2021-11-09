Module Macro

    Public CutProgram As List(Of String)
    Private SawMotorOn = "M3"
    Private SawMotorOff = "M5"
    Private WaitForEndOperation = "M400"
    Private Function AngleToPosition(angle As Double, dir As Direction) As Double
        Return AngleToPosition = XPositionZero + dir * (Math.PI * MachineRadius * (angle / 2 + ToolAngle / 2) / 180)
    End Function
    Public Sub Cut(CutAngle As Double, AngleFeed As Long, CutLength As Double, CutFeed As Long, CurrentE1 As Double,
                   retract As Double)

        Dim Pos1 = AngleToPosition(CutAngle, Direction.CCW)
        Dim Pos2 = AngleToPosition(CutAngle, Direction.CW)

        With CutProgram
            .Add(SawMotorOn) 'Включаем пилу
            .Add("M1 S1") ' Ждем 1 с
            .Add("G0 Y" & Pos1 & " F" & AngleFeed) ' Поворачиваем на нужный угол
            .Add(WaitForEndOperation) 'Ждем конца выполнения 
            .Add("GO X" & CutLength & " F" & CutFeed) 'Режем вверх
            .Add(WaitForEndOperation) ''Ждем конца выполнения
            .Add("G0 Y" & Pos2 & " F" & AngleFeed) ' Разворачиваем в другом направлении
            .Add("G0 E1" & CurrentE1 - retract) 'Смещаем заготовку на величину ретракта
            .Add(WaitForEndOperation) ''Ждем конца выполнения
            .Add("GO X0 F" & CutFeed) 'Режем вниз
            .Add(SawMotorOff) 'Выключаем пилу
        End With

    End Sub
End Module
