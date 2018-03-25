Imports System.Windows.Forms
Imports System.Drawing

Public Class Bar
    Inherits System.Windows.Forms.Form
    Public WithEvents Timer As New Timer With {.Enabled = True, .Interval = 1}
    Public WithEvents ControledForm As Form
    Public Distance As Double = 0
    Public BarHeight As Double = 0
    Private WithEvents Mover As ControlMover
    Friend WithEvents Cross As MBGlassButton
    Friend WithEvents Mini As MBGlassButton
    Dim istoclose As Boolean = False
    Dim prvs As New FormWindowState
    Shadows Sub Close()
        istoclose = True
        MyBase.Close()
    End Sub
    Sub New(Form As Form, Optional Distance As Double = 50, Optional Height As Double = 50)
        Me.BarHeight = Height
        Me.Distance = Distance
        If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Runtime Then
            ControledForm = Form
            Me.TopMost = True
        Else
            Dim tmpForm As New Form
            tmpForm.Hide()
            ControledForm = tmpForm
        End If
        ControledForm.TopMost = True
        Me.InitializeComponent()
        Mover = New ControlMover(Me.Button, Me)
        Me.ShowInTaskbar = False
    End Sub
    Private Sub InitializeComponent()
        Me.Mini = New MBGlassButton()
        Me.Cross = New MBGlassButton()
        Me.Button = New MBGlassButton()
        Me.SuspendLayout()
        '
        'Mini
        '
        Me.Mini.BackColor = System.Drawing.Color.LightGray
        Me.Mini.BaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Mini.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Mini.FlatAppearance.BorderSize = 0
        Me.Mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Mini.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mini.ImageSize = New System.Drawing.Size(24, 24)
        Me.Mini.Location = New System.Drawing.Point(149, 19)
        Me.Mini.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.Mini.Name = "Mini"
        Me.Mini.OnColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Mini.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Mini.PressColor = System.Drawing.Color.Blue
        Me.Mini.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Mini.Radius = 10
        Me.Mini.Size = New System.Drawing.Size(27, 27)
        Me.Mini.TabIndex = 2
        Me.Mini.Text = "-"
        Me.Mini.UseVisualStyleBackColor = False
        '
        'Cross
        '
        Me.Cross.BackColor = System.Drawing.Color.LightGray
        Me.Cross.BaseColor = System.Drawing.Color.Red
        Me.Cross.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cross.FlatAppearance.BorderSize = 0
        Me.Cross.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cross.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cross.ImageSize = New System.Drawing.Size(24, 24)
        Me.Cross.Location = New System.Drawing.Point(182, 19)
        Me.Cross.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.Cross.Name = "Cross"
        Me.Cross.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Cross.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cross.PressColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cross.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cross.Radius = 10
        Me.Cross.Size = New System.Drawing.Size(27, 27)
        Me.Cross.TabIndex = 1
        Me.Cross.Text = "X"
        Me.Cross.UseVisualStyleBackColor = False
        '
        'Button
        '
        Me.Button.BackColor = System.Drawing.Color.Transparent
        Me.Button.BaseColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Button.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button.FlatAppearance.BorderSize = 0
        Me.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button.Font = New System.Drawing.Font("Buxton Sketch", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button.ImageSize = New System.Drawing.Size(24, 24)
        Me.Button.Location = New System.Drawing.Point(-1, -2)
        Me.Button.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.Button.Name = "Button"
        Me.Button.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Button.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Button.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button.Radius = 25
        Me.Button.Size = New System.Drawing.Size(220, 65)
        Me.Button.TabIndex = 0
        Me.Button.Text = "ZDS.Bar"
        Me.Button.UseVisualStyleBackColor = False
        '
        'Bar
        '
        Me.ClientSize = New System.Drawing.Size(220, 62)
        Me.Controls.Add(Me.Mini)
        Me.Controls.Add(Me.Cross)
        Me.Controls.Add(Me.Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Bar"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button As MBGlassButton
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Button.Height = Me.Height
        Button.Width = Me.Width
        Button.Left = 0
        Button.Top = 0
        Me.Width = ControledForm.Width
        Me.Height = BarHeight
        ControledForm.Left = Me.Left
        ControledForm.Top = Me.Top + Me.Height + Distance
        Cross.Left = Button.Width - Cross.Width - 25
        Cross.Top = (Me.Height / 2) - (Cross.Height / 2)
        Mini.Left = Button.Width - Mini.Width - 55
        Mini.Top = (Me.Height / 2) - (Cross.Height / 2)
        If prvs = FormWindowState.Normal And ControledForm.WindowState = FormWindowState.Minimized Then
            Me.Hide()
        ElseIf prvs = FormWindowState.Minimized And ControledForm.WindowState = FormWindowState.Normal Then
            Me.Show()
        End If
        prvs = ControledForm.WindowState
    End Sub
    Private Sub Bar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If istoclose = False Then
            e.Cancel = True
        End If
    End Sub
    Private Sub ControledForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles ControledForm.FormClosing
        Me.Close()
    End Sub
    Private Sub Cross_Click(sender As Object, e As EventArgs) Handles Cross.Click
        ControledForm.Close()
    End Sub
    Private Sub Mini_Click(sender As Object, e As EventArgs) Handles Mini.Click
        ControledForm.WindowState = FormWindowState.Minimized
    End Sub
End Class
Public Class ControlMover
    Dim pressed As Boolean = False
    Dim OldPoint As New Point
    Dim NewPoint As New Point
    Dim SubPoint As New Point
    Dim WithEvents Me_ As Control
    Dim Moved As Control
    Public Sub MouseDown(MousePos As Point)
        If pressed = False Then
            pressed = True
            OldPoint = New Point(MousePos.X, MousePos.Y)
        End If
    End Sub
    Public Sub MouseUp()
        If pressed = True Then
            pressed = False
        End If
    End Sub
    Public Sub MouseMove(MousePos As Point)
        If pressed = True Then
            NewPoint = New Point(MousePos.X, MousePos.Y)
            SubPoint = New Point(-OldPoint.X + NewPoint.X, -OldPoint.Y + NewPoint.Y)
            Moved.Left = Moved.Left + SubPoint.X
            Moved.Top = Moved.Top + SubPoint.Y
        End If
    End Sub
    Public Sub New(Object_ As Control, Optional Moved As Control = Nothing)
        Me_ = Object_
        If Moved Is Nothing Then
            Me.Moved = Object_
        Else
            Me.Moved = Moved
        End If
    End Sub
    Private Sub MDown(sender As Object, e As MouseEventArgs) Handles Me_.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MouseDown(New Point(e.X, e.Y))
        End If
    End Sub
    Public Sub MMove(sender As Object, e As MouseEventArgs) Handles Me_.MouseMove
        MouseMove(New Point(e.X, e.Y))
    End Sub
    Public Sub MUp(sender As Object, e As MouseEventArgs) Handles Me_.MouseUp
        MouseUp()
    End Sub
End Class