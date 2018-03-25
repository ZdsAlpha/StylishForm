#Const Creator = "ZDS Alpha"
Public Class MetorStyleForm
    Inherits StyleBarForm
    Private components As System.ComponentModel.IContainer
    Sub New()
        Me.InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'TitleBar
        '
        Me.TitleBar.ClientSize = New System.Drawing.Size(300, 50)
        Me.TitleBar.Location = New System.Drawing.Point(530, 461)
        '
        'MetorStyleForm
        '
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BarDistance = 10.0R
        Me.ClientSize = New System.Drawing.Size(400, 300)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "MetorStyleForm"
        Me.Opacity = 0.9R
        Me.ResumeLayout(False)

    End Sub

End Class
