Imports System.Windows.Forms
Imports System.Drawing
Imports System.Threading

Public Class StyleBarForm
    Inherits Form
    Public TitleBar As Bar
    Public Shadows Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(value As String)
            TitleBar.Button.Text = value
            MyBase.Text = value
        End Set
    End Property
    Public Property BarDistance As Double
        Get
            Return TitleBar.Distance
        End Get
        Set(value As Double)
            TitleBar.Distance = value
        End Set
    End Property
    Public Property BarOpacity As Double
        Get
            Return TitleBar.Opacity
        End Get
        Set(value As Double)
            TitleBar.Opacity = value
        End Set
    End Property
    Public Property RefreshInterval As Integer
        Get
            Return TitleBar.Timer.Interval
        End Get
        Set(value As Integer)
            TitleBar.Timer.Interval = value
        End Set
    End Property
    Public Property BarThickness As Integer
        Get
            Return TitleBar.BarHeight
        End Get
        Set(value As Integer)
            TitleBar.BarHeight = value
        End Set
    End Property
    Public Property BarTitleFont As Font
        Get
            Return TitleBar.Button.Font
        End Get
        Set(value As Font)
            TitleBar.Button.Font = value
        End Set
    End Property

    Sub New()
        TitleBar = New Bar(Me, 15, 50)
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Runtime Then
            TitleBar.Show()
        ElseIf System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime Then
            TitleBar.Hide()
        End If
        Me.InitializeComponent()
    End Sub
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'StyleBarForm
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StyleBarForm"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ZDS.Bar"
        Me.ResumeLayout(False)
    End Sub
End Class
