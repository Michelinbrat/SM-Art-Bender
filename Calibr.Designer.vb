<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calibr
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
        Me.tbXMax = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbXMax
        '
        Me.tbXMax.Location = New System.Drawing.Point(155, 12)
        Me.tbXMax.Name = "tbXMax"
        Me.tbXMax.Size = New System.Drawing.Size(71, 20)
        Me.tbXMax.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(358, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 43)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(528, 71)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 32)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Calibr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbXMax)
        Me.Name = "Calibr"
        Me.Text = "Calibr"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbXMax As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
