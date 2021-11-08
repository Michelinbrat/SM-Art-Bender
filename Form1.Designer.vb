<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SP = New System.IO.Ports.SerialPort(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.НастройкиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОПрограммеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.НастройкиСтанкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.НастройкиСтанкаToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.КалибровкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem, Me.НастройкиToolStripMenuItem, Me.ОПрограммеToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ФайлToolStripMenuItem
        '
        Me.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        Me.ФайлToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ФайлToolStripMenuItem.Text = "Файл"
        '
        'НастройкиToolStripMenuItem
        '
        Me.НастройкиToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.НастройкиСтанкаToolStripMenuItem, Me.НастройкиСтанкаToolStripMenuItem1})
        Me.НастройкиToolStripMenuItem.Name = "НастройкиToolStripMenuItem"
        Me.НастройкиToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.НастройкиToolStripMenuItem.Text = "Настройки"
        '
        'ОПрограммеToolStripMenuItem
        '
        Me.ОПрограммеToolStripMenuItem.Name = "ОПрограммеToolStripMenuItem"
        Me.ОПрограммеToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.ОПрограммеToolStripMenuItem.Text = "О программе"
        '
        'НастройкиСтанкаToolStripMenuItem
        '
        Me.НастройкиСтанкаToolStripMenuItem.Name = "НастройкиСтанкаToolStripMenuItem"
        Me.НастройкиСтанкаToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.НастройкиСтанкаToolStripMenuItem.Text = "Настройка соединения"
        '
        'НастройкиСтанкаToolStripMenuItem1
        '
        Me.НастройкиСтанкаToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.КалибровкаToolStripMenuItem})
        Me.НастройкиСтанкаToolStripMenuItem1.Name = "НастройкиСтанкаToolStripMenuItem1"
        Me.НастройкиСтанкаToolStripMenuItem1.Size = New System.Drawing.Size(201, 22)
        Me.НастройкиСтанкаToolStripMenuItem1.Text = "Настройки станка"
        '
        'КалибровкаToolStripMenuItem
        '
        Me.КалибровкаToolStripMenuItem.Name = "КалибровкаToolStripMenuItem"
        Me.КалибровкаToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.КалибровкаToolStripMenuItem.Text = "Калибровка"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "SM-Art Bender"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SP As IO.Ports.SerialPort
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ФайлToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents НастройкиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents НастройкиСтанкаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents НастройкиСтанкаToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents КалибровкаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОПрограммеToolStripMenuItem As ToolStripMenuItem
End Class
