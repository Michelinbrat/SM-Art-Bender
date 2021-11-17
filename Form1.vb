Imports System.ComponentModel

Public Class MainForm
    Public ConnectionStatus As Boolean = False
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

    Private Sub НастройкиСтанкаToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles НастройкиСтанкаToolStripMenuItem1.Click

    End Sub



    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        MsgBox("cccff")
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        If ConnectionStatus = True Then
            ConnectionStatus = False
            btnConnect.ImageIndex = 0
        Else
            ConnectionStatus = True
            btnConnect.ImageIndex = 1
        End If

    End Sub

    Private Sub ПараметрыToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПараметрыToolStripMenuItem.Click
        Parameters.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoadFile()
    End Sub
End Class
