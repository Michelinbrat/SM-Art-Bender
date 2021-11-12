Imports System.ComponentModel
Imports System.Windows.Forms

Public Class Parameters

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Parameters_Load(sender As Object, e As EventArgs) Handles Me.Load
        With My.Settings
            TextBox1.Text = .XRotaryAxisMax
            TextBox2.Text = .XRotaryAxisZero
            TextBox3.Text = .XRotaryAxisFeed
            TextBox9.Text = .ToolAngle
        End With
    End Sub

    Private Sub Parameters_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        With My.Settings
            .XRotaryAxisMax = TextBox1.Text
            .XRotaryAxisZero = TextBox2.Text
            .XRotaryAxisFeed = TextBox3.Text
            .ToolAngle = TextBox9.Text
        End With
    End Sub
End Class
