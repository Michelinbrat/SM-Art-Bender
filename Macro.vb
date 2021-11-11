Module Macro
    Public CutProgram As String()
    Private Const SawMotorOn As String = "M3"
    Private Const SawMotorOff = "M5"
    Private Const WaitForEndOperation = "M400"
    Private Function AngleToPosition(angle As Double, dir As Direction) As Double
        Return AngleToPosition = XPositionZero + dir * (Math.PI * MachineRadius * (angle / 2 + ToolAngle / 2) / 180)
    End Function
    Public Sub Cut(CutAngle As Double, AngleFeed As Long, CutLength As Double, CutFeed As Long, CurrentE1 As Double,
                   retract As Double)

        Dim Pos1 = AngleToPosition(CutAngle, Direction.CCW)
        Dim Pos2 = AngleToPosition(CutAngle, Direction.CW)



        CutProgram(0) = ("uu") 'Включаем пилу
        CutProgram(1) = ("M1 S1") ' Ждем 1 с
        CutProgram(2) = ("G0 Y" & Pos1 & " F" & AngleFeed) ' Поворачиваем на нужный угол
        CutProgram(3) = (WaitForEndOperation) 'Ждем конца выполнения 
        CutProgram(4) = ("GO X" & CutLength & " F" & CutFeed) 'Режем вверх
        CutProgram(5) = (WaitForEndOperation) ''Ждем конца выполнения
        CutProgram(6) = ("G0 Y" & Pos2 & " F" & AngleFeed) ' Разворачиваем в другом направлении
        CutProgram(7) = ("G0 E1" & CurrentE1 - retract) 'Смещаем заготовку на величину ретракта
        CutProgram(8) = (WaitForEndOperation) ''Ждем конца выполнения
        CutProgram(9) = ("GO X0 F" & CutFeed) 'Режем вниз
        CutProgram(10) = (SawMotorOff) 'Выключаем пилу


    End Sub
End Module
