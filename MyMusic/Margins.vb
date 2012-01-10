Public Class Margins

    Private _Left As Integer
    Private _Top As Integer
    Private _Right As Integer
    Private _Bottom As Integer

    Private _CanvasSize As Size


    Public Property CanvasSize As Size
        Get
            Return Me._CanvasSize
        End Get
        Set(ByVal value As Size)
            Me._CanvasSize = value
        End Set
    End Property

    Public Property Left As Integer
        Get
            Return Me._Left
        End Get
        Set(ByVal value As Integer)
            If value < 0 Then
                value = 0
            ElseIf Me._Right + value > Me.CanvasSize.Width - 1 Or value > Me.CanvasSize.Width - 1 Then
                value = Me.CanvasSize.Width - 1
            End If
            Me._Left = value
        End Set
    End Property

    Public Property Right As Integer
        Get
            Return Me._Right
        End Get
        Set(ByVal value As Integer)
            If value < 0 Then
                value = 0
            ElseIf Me._Left + value > Me.CanvasSize.Width - 1 Or value > Me.CanvasSize.Width - 1 Then
                value = Me.CanvasSize.Width - 1
            End If
            Me._Right = value
        End Set
    End Property

    Public Property Top As Integer
        Get
            Return Me._Top
        End Get
        Set(ByVal value As Integer)
            If value < 0 Then
                value = 0
            ElseIf Me._Bottom + value > Me.CanvasSize.Height - 1 Or value > Me.CanvasSize.Height - 1 Then
                value = Me.CanvasSize.Height - 1
            End If
            Me._Top = value
        End Set
    End Property

    Public Property Bottom As Integer
        Get
            Return Me._Bottom
        End Get
        Set(ByVal value As Integer)
            If value < 0 Then
                value = 0
            ElseIf Me._Top + value > Me.CanvasSize.Height - 1 Or value > Me.CanvasSize.Height - 1 Then
                value = Me.CanvasSize.Height - 1
            End If
            Me._Bottom = value
        End Set
    End Property

    Public Property Location As Point
        Get
            Return New Point(Me.Left, Me.Top)
        End Get
        Set(ByVal value As Point)
            Dim tempSize As Size = Me.Size

            If (value.X < 0) Then
                value = New Point(0, value.Y)
            ElseIf (value.X + tempSize.Width > Me.CanvasSize.Width) Then
                value = New Point(Me.CanvasSize.Width - tempSize.Width, value.Y)
            End If

            If (value.Y < 0) Then
                value = New Point(value.X, 0)
            ElseIf (value.Y + tempSize.Height > Me.CanvasSize.Height) Then
                value = New Point(value.X, Me.CanvasSize.Height - tempSize.Height)
            End If

            Me.Left = value.X
            Me.Top = value.Y
            Me.Right = Me.CanvasSize.Width - tempSize.Width - value.X
            Me.Bottom = Me.CanvasSize.Height - tempSize.Height - value.Y
        End Set
    End Property

    Public Property Size As Size
        Get
            Return New Size(Me.CanvasSize.Width - Me.Left - Me.Right, Me.CanvasSize.Height - Me.Top - Me.Bottom)
        End Get
        Set(ByVal value As Size)
            If (value.Width <= 0) Then
                value = New Point(1, value.Height)
            ElseIf (value.Width + Me.Left > Me.CanvasSize.Width) Then
                value = New Point(Me.CanvasSize.Width - Me.Left, value.Height)
            End If

            If (value.Height <= 0) Then
                value = New Point(value.Width, 1)
            ElseIf (value.Height + Me.Top > Me.CanvasSize.Height) Then
                value = New Point(value.Width, Me.CanvasSize.Height - Me.Top)
            End If

            Me.Right = Me.CanvasSize.Width - Me.Left - value.Width
            Me.Bottom = Me.CanvasSize.Height - Me.Top - value.Height
        End Set
    End Property

    Public Sub New(ByVal CanvasSize As Size)
        Me.New(CanvasSize, 0, 0, 0, 0)
    End Sub

    Public Sub New(ByVal CanvasSize As Size, ByVal Margins As Integer)
        Me.New(CanvasSize, Margins, Margins, Margins, Margins)
    End Sub

    Public Sub New(ByVal CanvasSize As Size, ByVal MarginLeft As Integer, ByVal MarginRight As Integer, ByVal MarginTop As Integer, ByVal MarginBottm As Integer)
        Me.CanvasSize = CanvasSize
        Me.Left = MarginLeft
        Me.Right = MarginRight
        Me.Top = MarginTop
        Me.Bottom = MarginBottm
    End Sub
End Class
