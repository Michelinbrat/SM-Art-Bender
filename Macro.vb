Module Macro
    Public CutProgram As List(Of String)
    Private SawMotorOn = "M3"
    Public Sub Cut(CutAngle As Double, CutLength As Double)
        CutProgram.Add(SawMotorOn)
    End Sub
End Module
