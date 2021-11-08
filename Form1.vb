Public Class MainForm
    Private Sub ОПрограммеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОПрограммеToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub EEPROMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EEPROMToolStripMenuItem.Click
        EEPROM.ShowDialog()
    End Sub
End Class
