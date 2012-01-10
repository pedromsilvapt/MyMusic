Public Class CropablePictureBox

    Public CurrentImage As Image
    Public BaseImage As Image
    Public VisibleImage As Image

    Private _CropMargins As Margins

    Private Dragging As DraggingType = DraggingType.None

    Private DragMargins As Integer = 5

    Private p_drag As Point

    Public Enum DraggingType As Integer
        None = 0
        Left = 1
        Top = 2
        Right = 3
        Bottom = 4
        Move = 5
    End Enum


    Public Event CropChanged()

    Public Property AllowCrop As Boolean = True

    Public Property MaxSize As Size = New Size(382, 382)

    Public Property PictureBox As Windows.Forms.PictureBox
        Get
            Return Me.pcb_main
        End Get
        Set(ByVal value As Windows.Forms.PictureBox)
            Me.pcb_main = value
        End Set
    End Property

    Public Property KLabelWidth As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Get
            Return Me.KWidth
        End Get
        Set(ByVal value As ComponentFactory.Krypton.Toolkit.KryptonLabel)
            Me.KWidth = value
        End Set
    End Property

    Public Property KLabelHeight As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Get
            Return Me.KHeight
        End Get
        Set(ByVal value As ComponentFactory.Krypton.Toolkit.KryptonLabel)
            Me.KHeight = value
        End Set
    End Property

    Public Property CropLeft As Integer
        Get
            If Me._CropMargins IsNot Nothing Then
                Return Me._CropMargins.Left
            Else
                Return 0
            End If
        End Get
        Set(ByVal value As Integer)
            If Me._CropMargins IsNot Nothing Then
                Me._CropMargins.Left = value
            End If
        End Set
    End Property

    Public Property CropRight As Integer
        Get
            If Me._CropMargins IsNot Nothing Then
                Return Me._CropMargins.Right
            Else
                Return 0
            End If
        End Get
        Set(ByVal value As Integer)
            If Me._CropMargins IsNot Nothing Then
                Me._CropMargins.Right = value
            End If
        End Set
    End Property

    Public Property CropTop As Integer
        Get
            If Me._CropMargins IsNot Nothing Then
                Return Me._CropMargins.Top
            Else
                Return 0
            End If
        End Get
        Set(ByVal value As Integer)
            If Me._CropMargins IsNot Nothing Then
                Me._CropMargins.Top = value
            End If
        End Set
    End Property

    Public Property CropBottom As Integer
        Get
            If Me._CropMargins IsNot Nothing Then
                Return Me._CropMargins.Bottom
            Else
                Return 0
            End If
        End Get
        Set(ByVal value As Integer)
            If Me._CropMargins IsNot Nothing Then
                Me._CropMargins.Bottom = value
            End If
        End Set
    End Property

    Public Property CropLocation As Point
        Get
            If Me._CropMargins IsNot Nothing Then
                Return Me._CropMargins.Location
            Else
                Return New Point(0, 0)
            End If
        End Get
        Set(ByVal value As Point)
            If Me._CropMargins IsNot Nothing Then
                Me._CropMargins.Location = value
            End If
        End Set
    End Property

    Public Property CropSize As Size
        Get
            If Me._CropMargins IsNot Nothing Then
                Return Me._CropMargins.Size
            Else
                Return New Size(0, 0)
            End If
        End Get
        Set(ByVal value As Size)
            If Me._CropMargins IsNot Nothing Then
                Me._CropMargins.Size = value
            End If
        End Set
    End Property

    Public Property RealCropLeft As Integer
        Get
            If (Me.CurrentImage IsNot Nothing And Me._CropMargins IsNot Nothing) Then
                Return (Me.CurrentImage.Size.Width / Me._CropMargins.CanvasSize.Width) * Me.CropLeft
            Else
                Return 0
            End If
        End Get
        Set(ByVal value As Integer)
            If (Me.CurrentImage IsNot Nothing And Me._CropMargins IsNot Nothing) Then
                Me.CropLeft = value / (Me.CurrentImage.Size.Width / Me._CropMargins.CanvasSize.Width)
            End If
        End Set
    End Property

    Public Property RealCropTop As Integer
        Get
            If (Me.CurrentImage IsNot Nothing And Me._CropMargins IsNot Nothing) Then
                Return (Me.CurrentImage.Size.Width / Me._CropMargins.CanvasSize.Width) * Me.CropTop
            Else
                Return 0
            End If
        End Get
        Set(ByVal value As Integer)
            If (Me.CurrentImage IsNot Nothing And Me._CropMargins IsNot Nothing) Then
                Me.CropTop = value / (Me.CurrentImage.Size.Width / Me._CropMargins.CanvasSize.Width)
            End If
        End Set
    End Property

    Public Property RealCropRight As Integer
        Get
            If (Me.CurrentImage IsNot Nothing And Me._CropMargins IsNot Nothing) Then
                Return (Me.CurrentImage.Size.Width / Me._CropMargins.CanvasSize.Width) * Me.CropRight
            Else
                Return 0
            End If
        End Get
        Set(ByVal value As Integer)
            If (Me.CurrentImage IsNot Nothing And Me._CropMargins IsNot Nothing) Then
                Me.CropRight = value / (Me.CurrentImage.Size.Width / Me._CropMargins.CanvasSize.Width)
            End If
        End Set
    End Property

    Public Property RealCropBottom As Integer
        Get
            If (Me.CurrentImage IsNot Nothing And Me._CropMargins IsNot Nothing) Then
                Return (Me.CurrentImage.Size.Width / Me._CropMargins.CanvasSize.Width) * Me.CropBottom
            Else
                Return 0
            End If
        End Get
        Set(ByVal value As Integer)
            If (Me.CurrentImage IsNot Nothing And Me._CropMargins IsNot Nothing) Then
                Me.CropBottom = value / (Me.CurrentImage.Size.Width / Me._CropMargins.CanvasSize.Width)
            End If
        End Set
    End Property

    Public Property RealCropLocation As Point
        Get
            If (Me.CurrentImage IsNot Nothing And Me._CropMargins IsNot Nothing) Then
                Return New Point((Me.CurrentImage.Size.Width / Me._CropMargins.CanvasSize.Width) * Me.CropLocation.X,
                                 (Me.CurrentImage.Size.Width / Me._CropMargins.CanvasSize.Width) * Me.CropLocation.Y)
            Else
                Return New Point(0, 0)
            End If
        End Get
        Set(ByVal value As Point)
            If (Me.CurrentImage IsNot Nothing And Me._CropMargins IsNot Nothing) Then
                Me.CropLocation = New Point(value.X / (Me.CurrentImage.Size.Width / Me._CropMargins.CanvasSize.Width),
                                            value.Y / (Me.CurrentImage.Size.Width / Me._CropMargins.CanvasSize.Width))
            End If
        End Set
    End Property

    Public Property RealCropSize As Size
        Get
            If (Me.CurrentImage IsNot Nothing And Me._CropMargins IsNot Nothing) Then
                Return New Size((Me.CurrentImage.Size.Width / Me._CropMargins.CanvasSize.Width) * Me.CropSize.Width,
                                 (Me.CurrentImage.Size.Width / Me._CropMargins.CanvasSize.Width) * Me.CropSize.Height)
            Else
                Return New Size(0, 0)
            End If
        End Get
        Set(ByVal value As Size)
            If (Me.CurrentImage IsNot Nothing And Me._CropMargins IsNot Nothing) Then
                Me.CropSize = New Point(value.Width / (Me.CurrentImage.Size.Width / Me._CropMargins.CanvasSize.Width),
                                        value.Height / (Me.CurrentImage.Size.Width / Me._CropMargins.CanvasSize.Width))
            End If
        End Set
    End Property


    Public Shared Function ZoomSize(ByVal sz As Size, ByVal maxSZ As Size) As Size
        Dim Ratio As Double = 1

        If (sz.Width > sz.Height) Then
            Ratio = maxSZ.Width / sz.Width
        Else
            Ratio = maxSZ.Height / sz.Height
        End If
        Return New Size(sz.Width * Ratio, sz.Height * Ratio)
    End Function

    Public Shared Function cropImage(ByVal img As Image, ByVal CropLeft As Integer, ByVal CropTop As Integer, ByVal CropRight As Integer, ByVal CropBottom As Integer)
        Return CropablePictureBox.cropImage(img, New Rectangle(New Point(CropLeft, CropTop), New Size(img.Width - CropLeft - CropRight, img.Height - CropTop - CropBottom)))
    End Function

    Public Shared Function cropImage(ByVal img As Image, ByVal cropArea As Rectangle) As Image
        Dim bmpImage As New Bitmap(img)
        Dim bmpCrop As Bitmap = bmpImage.Clone(cropArea, bmpImage.PixelFormat)
        Return DirectCast(bmpCrop, Image)
    End Function

    Public Shared Function resizeImage(ByVal imgToResize As Image, ByVal size As Size) As Image
        Dim sourceWidth As Integer = imgToResize.Width
        Dim sourceHeight As Integer = imgToResize.Height

        Dim nPercent As Single = 0
        Dim nPercentW As Single = 0
        Dim nPercentH As Single = 0

        nPercentW = (CSng(size.Width) / CSng(sourceWidth))
        nPercentH = (CSng(size.Height) / CSng(sourceHeight))

        If nPercentH < nPercentW Then
            nPercent = nPercentH
        Else
            nPercent = nPercentW
        End If

        Dim destWidth As Integer = CInt(Math.Truncate(sourceWidth * nPercent))
        Dim destHeight As Integer = CInt(Math.Truncate(sourceHeight * nPercent))

        Dim b As New Bitmap(destWidth, destHeight)
        Dim g As Graphics = Graphics.FromImage(DirectCast(b, Image))
        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic

        g.DrawImage(imgToResize, 0, 0, destWidth, destHeight)
        g.Dispose()

        Return DirectCast(b, Image)
    End Function

    Public Shared Function CreateThumbnail(ByVal Img As Image, ByVal sz As Size, Optional ByVal Zoom As Boolean = False) As Image
        Return CropablePictureBox.CreateThumbnail(Img, 0, 0, 0, 0, sz, Zoom)
    End Function

    Public Shared Function CreateThumbnail(ByVal Img As Image, ByVal Width As Integer, ByVal Height As Integer, Optional ByVal Zoom As Boolean = False) As Image
        Return CropablePictureBox.CreateThumbnail(Img, 0, 0, 0, 0, New Size(Width, Height), Zoom)
    End Function

    Public Shared Function CreateThumbnail(ByVal Img As Image, ByVal CropLeft As Integer, ByVal CropTop As Integer, ByVal CropRight As Integer, ByVal CropBottom As Integer) As Image
        Return CropablePictureBox.CreateThumbnail(Img, CropLeft, CropTop, CropRight, CropBottom, Img.Size, False)
    End Function

    Public Shared Function CreateThumbnail(ByVal Img As Image, ByVal CropLeft As Integer, ByVal CropTop As Integer, ByVal CropRight As Integer, ByVal CropBottom As Integer, ByVal Width As Integer, ByVal Height As Integer, Optional ByVal Zoom As Boolean = False) As Image
        Return CropablePictureBox.CreateThumbnail(Img, CropLeft, CropTop, CropRight, CropBottom, New Size(Width, Height), Zoom)
    End Function

    Public Shared Function CreateThumbnail(ByVal Img As Image, ByVal CropLeft As Integer, ByVal CropTop As Integer, ByVal CropRight As Integer, ByVal CropBottom As Integer, ByVal sz As Size, Optional ByVal Zoom As Boolean = False) As Image
        Img = cropImage(Img, CropLeft, CropTop, CropRight, CropBottom)

        If (Zoom) Then
            sz = CropablePictureBox.ZoomSize(Img.Size, sz)
        End If

        Img = resizeImage(Img, sz)

        Return Img
    End Function

    Public Sub SetImage(ByRef NewImage As Image)
        If (NewImage Is Nothing) Then
            Throw New Exception("A imagem está nula.")
        End If

        Me.CurrentImage = NewImage

        Me.KWidth.Text = String.Format("{0} px", NewImage.Width)
        Me.KHeight.Text = String.Format("{0} px", NewImage.Height)

        Me._CropMargins = New Margins(NewImage.Size, 0, 0, 0, 0)

        Me.ResizePictureBox()
    End Sub

    Public Sub ResizePictureBox()
        If (Me.CurrentImage.Width <= Me.MaxSize.Width - 27 And Me.CurrentImage.Height <= Me.MaxSize.Height - 27) Then
            Me.pcb_main.Location = New Point(0, 0)
            Me.pcb_main.Size = Me.CurrentImage.Size
            Me.BaseImage = Me.CurrentImage.Clone()
        Else
            Me.pcb_main.Location = New Point(0, 0)
            Me.pcb_main.Size = CropablePictureBox.ZoomSize(Me.CurrentImage.Size, New Size(Me.MaxSize.Width - 27, Me.MaxSize.Height - 27))
            Me.BaseImage = CropablePictureBox.CreateThumbnail(Me.CurrentImage, Me.MaxSize.Width - 27, Me.MaxSize.Height - 27, True)
        End If

        Me.pcb_main.Image = Me.GenerateImage()

        Me._CropMargins.CanvasSize = Me.pcb_main.Size

        Me.KWidth.Location = New Point(Me.pcb_main.Location.X + (Me.pcb_main.Size.Width / 2) - (Me.KWidth.Size.Width / 2),
                                       Me.pcb_main.Location.Y + Me.pcb_main.Size.Height + 3)
        Me.KHeight.Location = New Point(Me.pcb_main.Location.X + Me.pcb_main.Size.Width + 3,
                                        Me.pcb_main.Location.Y + (Me.pcb_main.Size.Height / 2) - (Me.KHeight.Size.Height / 2))

        Me.Size = New Size(Me.KHeight.Location.X + Me.KHeight.Size.Width, Me.KWidth.Location.Y + Me.KWidth.Size.Height)
    End Sub

    Public Function GenerateImage() As Image
        Me.VisibleImage = Me.BaseImage.Clone()
        Dim g As Graphics
        g = Graphics.FromImage(Me.VisibleImage)

        g.FillRectangle(New SolidBrush(Color.FromArgb(150, Color.Gray)), New Rectangle(Me._CropMargins.Location, Me._CropMargins.Size))
        g.DrawRectangle(New Pen(New SolidBrush(Color.FromArgb(200, Color.DarkGray)), 1), New Rectangle(Me._CropMargins.Location, Me._CropMargins.Size - New Size(1, 1)))
        RaiseEvent CropChanged()
        Return Me.VisibleImage
    End Function

    Public Sub RefreshOutput()
        Me.pcb_main.Image = Me.GenerateImage()
    End Sub

    Private Sub pcb_main_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pcb_main.MouseDown
        Dim mouseX As Integer = pcb_main.PointToClient(Cursor.Position).X
        Dim mouseY As Integer = pcb_main.PointToClient(Cursor.Position).Y + 2

        If mouseX > Me.CropLeft - 2 And mouseX < Me.CropLeft + Me.DragMargins Then
            Me.Dragging = DraggingType.Left
        ElseIf mouseX > Me.pcb_main.Width - Me.CropRight - Me.DragMargins And mouseX < Me.pcb_main.Width - Me.CropRight + Me.DragMargins Then
            Me.Dragging = DraggingType.Right
        ElseIf mouseY < Me.CropTop + Me.DragMargins And mouseY > Me.CropTop - Me.DragMargins Then
            Me.Dragging = DraggingType.Top
        ElseIf mouseY > Me.pcb_main.Height - Me.CropBottom - Me.DragMargins And mouseY < Me.pcb_main.Height - Me.CropBottom + Me.DragMargins Then
            Me.Dragging = DraggingType.Bottom
        ElseIf mouseX > Me.CropLeft And mouseX < Me.pcb_main.Size.Width - Me.CropRight And mouseY > Me.CropTop And mouseY < Me.pcb_main.Size.Height - Me.CropBottom Then
            Me.p_drag = New Point(mouseX - Me.CropLeft, mouseY - Me.CropTop)
            Me.Dragging = DraggingType.Move
        Else
            Me.Dragging = DraggingType.None
        End If
    End Sub

    Private Sub pcb_main_MouseMove(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcb_main.MouseMove
        Dim mouseX As Integer = pcb_main.PointToClient(Cursor.Position).X
        Dim mouseY As Integer = pcb_main.PointToClient(Cursor.Position).Y + 2

        If Me.Dragging = DraggingType.None Then
            If mouseX > Me.CropLeft - Me.DragMargins And mouseX < Me.CropLeft + Me.DragMargins Then
                Me.pcb_main.Cursor = Cursors.SizeWE
            ElseIf mouseX > Me.pcb_main.Width - Me.CropRight - Me.DragMargins And mouseX < Me.pcb_main.Width - Me.CropRight + Me.DragMargins Then
                Me.pcb_main.Cursor = Cursors.SizeWE
            ElseIf mouseY < Me.CropTop + Me.DragMargins And mouseY > Me.CropTop - Me.DragMargins Then
                Me.pcb_main.Cursor = Cursors.SizeNS
            ElseIf mouseY > Me.pcb_main.Height - Me.CropBottom - Me.DragMargins And mouseY < Me.pcb_main.Height - Me.CropBottom + Me.DragMargins Then
                Me.pcb_main.Cursor = Cursors.SizeNS
            ElseIf mouseX > Me.CropLeft And mouseX < Me.pcb_main.Size.Width - Me.CropRight And mouseY > Me.CropTop And mouseY < Me.pcb_main.Size.Height - Me.CropBottom Then
                Me.pcb_main.Cursor = Cursors.SizeAll
            Else
                Me.pcb_main.Cursor = Cursors.Default
            End If
        Else
            If Me.Dragging = DraggingType.Left Then
                Me.CropLeft = mouseX
            ElseIf Me.Dragging = DraggingType.Right Then
                Me.CropRight = Me.pcb_main.Size.Width - mouseX + 3
            ElseIf Me.Dragging = DraggingType.Top Then
                Me.CropTop = mouseY
            ElseIf Me.Dragging = DraggingType.Bottom Then
                Me.CropBottom = Me.pcb_main.Size.Height - mouseY
            ElseIf Me.Dragging = DraggingType.Move Then
                Me.CropLocation = New Point(mouseX - Me.p_drag.X, mouseY - Me.p_drag.Y)
            End If
            Me.pcb_main.Image = GenerateImage()
        End If
    End Sub

    Private Sub pcb_main_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pcb_main.MouseUp
        Me.Dragging = DraggingType.None
    End Sub


    Public Sub New()
        Me._CropMargins = New Margins(New Size(100, 100))
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class
