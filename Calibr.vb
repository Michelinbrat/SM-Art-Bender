Public Class Calibr
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.XMax = tbXMax.Text
        My.Settings.Save()
    End Sub

    Private Sub Calibr_Load(sender As Object, e As EventArgs) Handles Me.Load
        tbXMax.Text = My.Settings.XMax
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cut(35, 200, 45, 200, 500, 10)
        For i = 0 To 10
            Debug.Print(CutProgram(i))
        Next i
    End Sub
End Class