Module Macro

    Public CutProgram As List(Of String)
    Private SawMotorOn = "M3"
    Public Sub Cut(CutAngle As Double, CutLength As Double)
        With CutProgram
            .Add(SawMotorOn)
            .Add("M1 S1") ' Пауза 1 с
        End With

    End Sub
End Module
