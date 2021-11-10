Imports System.ComponentModel

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

    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.Save()
    End Sub

    Private Sub КалибровкаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles КалибровкаToolStripMenuItem.Click
        Calibr.ShowDialog()

    End Sub
    Private Sub Painter()

    End Sub

    Private Sub ОткрытьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОткрытьToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub
End Class
