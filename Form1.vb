Public Class MainForm
    Private Sub ОПрограммеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОПрограммеToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub EEPROMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EEPROMToolStripMenuItem.Click
        EEPROM.ShowDialog()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MainForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rtbDisplay.Width = SplitContainer1.Panel2.Width - 10
    End Sub

    Private Sub SplitContainer1_Resize(sender As Object, e As EventArgs) Handles SplitContainer1.Resize
        rtbDisplay.Width = SplitContainer1.Panel2.Width - 10
    End Sub

    Private Sub ВыходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыходToolStripMenuItem.Click
        MainForm.ActiveForm.Close()
    End Sub
End Class
