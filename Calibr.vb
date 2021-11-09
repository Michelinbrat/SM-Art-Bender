Public Class Calibr
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.XMax = tbXMax.Text
        My.Settings.Save()
    End Sub

    Private Sub Calibr_Load(sender As Object, e As EventArgs) Handles Me.Load
        tbXMax.Text = My.Settings.XMax
    End Sub
End Class