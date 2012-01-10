Public Class frm_edit_thumbnail

  

    Public Enum AlignType As Integer
        LeftUp = 0
        CenterUp = 1
        RightUp = 2
        LeftMiddle = 3
        CenterMiddle = 4
        RightMidde = 5
        LeftDown = 6
        CenterDown = 7
        RightDown = 8
    End Enum


    Public Property Thumbnail As Image
        Get
            Return Me.CropablePictureBox1.CurrentImage
        End Get
        Set(ByVal value As Image)
            Me.CropablePictureBox1.SetImage(value)
            Me.knud_width.Value = value.Size.Width
            Me.knud_height.Value = value.Size.Height
        End Set
    End Property

    Public Property ThumbnailAlign As frm_edit_thumbnail.AlignType

    Private Shared Function GenerateThumbnail(ByVal FullImg As Image, ByVal CropMargins As Margins, ByVal ThumbSize As Size, ByVal Align As AlignType, ByVal Scale As Boolean, ByVal SmartScale As Boolean, ByVal BackColor As Color)
        Dim newIMG As Image = New Bitmap(ThumbSize.Width, ThumbSize.Height)
        Dim g As Graphics = Graphics.FromImage(newIMG)
        g.Clear(BackColor)

        Dim size As Size
        If (Scale) Then
            size = ThumbSize
        Else
            size = CropMargins.Size
        End If
        Dim cropped As Image = CropablePictureBox.CreateThumbnail(FullImg, CropMargins.Left, CropMargins.Top, CropMargins.Right, CropMargins.Bottom, size, (SmartScale And Scale))
        Dim location As Point
        If (Align = AlignType.LeftUp) Then
            location = New Point(0, 0)
        ElseIf (Align = AlignType.CenterUp) Then
            location = New Point(ThumbSize.Width / 2 - cropped.Width / 2, 0)
        ElseIf (Align = AlignType.RightUp) Then
            location = New Point(ThumbSize.Width - cropped.Width, 0)
        ElseIf (Align = AlignType.LeftMiddle) Then
            location = New Point(0, ThumbSize.Height / 2 - cropped.Height / 2)
        ElseIf (Align = AlignType.CenterMiddle) Then
            location = New Point(ThumbSize.Width / 2 - cropped.Width / 2, ThumbSize.Height / 2 - cropped.Height / 2)
        ElseIf (Align = AlignType.RightMidde) Then
            location = New Point(ThumbSize.Width - cropped.Width, ThumbSize.Height / 2 - cropped.Height / 2)
        ElseIf (Align = AlignType.LeftDown) Then
            location = New Point(0, ThumbSize.Height - cropped.Height)
        ElseIf (Align = AlignType.CenterDown) Then
            location = New Point(ThumbSize.Width / 2 - cropped.Width / 2, ThumbSize.Height - cropped.Height)
        ElseIf (Align = AlignType.RightDown) Then
            location = New Point(ThumbSize.Width - cropped.Width, ThumbSize.Height - cropped.Height)
        End If

        g.DrawImage(cropped, New Rectangle(location, cropped.Size))

        Return newIMG
    End Function

    Private Sub CropablePictureBox1_CropChanged() Handles CropablePictureBox1.CropChanged
        Me.RefreshPreview()
    End Sub

    Public Sub RefreshPreview()
        If (Me.CropablePictureBox1.CurrentImage IsNot Nothing) Then
            Dim bgColor As Color = Me.kcbtn_background_color.SelectedColor

            If (Not Me.kcbx_background.Checked) Then
                bgColor = Color.Transparent
            End If

            Me.pcb_preview.Image = frm_edit_thumbnail.GenerateThumbnail(Me.CropablePictureBox1.CurrentImage,
                                                                        New Margins(Me.CropablePictureBox1.CurrentImage.Size,
                                                                                    Me.CropablePictureBox1.RealCropLeft,
                                                                                    Me.CropablePictureBox1.RealCropRight,
                                                                                    Me.CropablePictureBox1.RealCropTop,
                                                                                    Me.CropablePictureBox1.RealCropBottom),
                                                                        New Size(Me.knud_width.Value, Me.knud_height.Value),
                                                                        Me.ThumbnailAlign,
                                                                        Me.kcbx_scale_thumbnail.Checked,
                                                                        Me.kcbx_smart_scale.Checked,
                                                                        bgColor)
        End If
    End Sub

    Private Sub CropablePictureBox1_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CropablePictureBox1.SizeChanged
        'Debug.WriteLine(String.Format("sX: {0} ; Y: {1}", Me.CropablePictureBox1.PictureBox.Location.X, Me.CropablePictureBox1.PictureBox.Location.Y))
        Me.ReOrganizeLayout()
    End Sub

    Public Sub ReOrganizeLayout()
        'Me.kpnl_preview_thumbnail.Location = New Point(Me.kpnl_preview_thumbnail.Location.X,
        '                                       Me.Size.Height / 2 - Me.kpnl_preview_thumbnail.Size.Height / 2)
        Me.kpnl_crop.Size = New Size(Me.kpnl_crop.Size.Width,
                                     Me.CropablePictureBox1.Size.Height + 8 + 25)
        Me.kpnl_crop.Location = New Point(Me.kpnl_crop.Location.X,
                                          Me.KryptonPanel.Size.Height / 2 - Me.kpnl_crop.Size.Height / 2)
        Me.CropablePictureBox1.Location = New Point(Me.kpnl_crop.Size.Width / 2 - Me.CropablePictureBox1.Size.Width / 2,
                                                    0)
        Me.kpnl_crop_buttons.Location = New Point(Me.CropablePictureBox1.Location.X + Me.CropablePictureBox1.PictureBox.Size.Width / 2 - Me.kpnl_crop_buttons.Size.Width / 2,
                                                  Me.CropablePictureBox1.Location.Y + Me.CropablePictureBox1.Size.Height + 8)
        'Me.kbtn_crop_reset.Location = New Point(Me.kbtn_crop_reset.Location.X,
        '                                        Me.CropablePictureBox1.Location.Y + Me.CropablePictureBox1.Size.Height + 8)
        'Me.kbtn_make_square.Location = New Point(Me.kbtn_make_square.Location.X,
        '                                         Me.CropablePictureBox1.Location.Y + Me.CropablePictureBox1.Size.Height + 8)
    End Sub

    Private Sub kcbx_background_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kcbx_background.CheckedChanged
        Me.kcbtn_background_color.Enabled = Me.kcbx_background.Checked
        Me.RefreshPreview()
    End Sub

    Private Sub kbtn_alignement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kbtn_alignement.Click
        Me.kpnl_align.Visible = Me.pcb_preview.Visible
        Me.pcb_preview.Visible = Not Me.kpnl_align.Visible
    End Sub

    Private Sub kcbx_scale_thumbnail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kcbx_scale_thumbnail.CheckedChanged
        Me.kcbx_smart_scale.Enabled = Me.kcbx_scale_thumbnail.Checked
        Me.RefreshPreview()
    End Sub

    Private Sub kbtn_crop_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kbtn_crop_reset.Click
        Me.CropablePictureBox1.CropLeft = 0
        Me.CropablePictureBox1.CropRight = 0
        Me.CropablePictureBox1.CropTop = 0
        Me.CropablePictureBox1.CropBottom = 0
        Me.CropablePictureBox1.RefreshOutput()
    End Sub

    Private Sub kcks_align_CheckedButtonChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kcks_align.CheckedButtonChanged
        If (Me.kcks_align.CheckedButton.Tag = "leftup") Then
            Me.ThumbnailAlign = AlignType.LeftUp
        ElseIf Me.kcks_align.CheckedButton.Tag = "centerup" Then
            Me.ThumbnailAlign = AlignType.CenterUp
        ElseIf Me.kcks_align.CheckedButton.Tag = "rightup" Then
            Me.ThumbnailAlign = AlignType.RightUp
        ElseIf Me.kcks_align.CheckedButton.Tag = "leftmiddle" Then
            Me.ThumbnailAlign = AlignType.LeftMiddle
        ElseIf Me.kcks_align.CheckedButton.Tag = "centermiddle" Then
            Me.ThumbnailAlign = AlignType.CenterMiddle
        ElseIf Me.kcks_align.CheckedButton.Tag = "rightmiddle" Then
            Me.ThumbnailAlign = AlignType.RightMidde
        ElseIf Me.kcks_align.CheckedButton.Tag = "leftdown" Then
            Me.ThumbnailAlign = AlignType.LeftDown
        ElseIf Me.kcks_align.CheckedButton.Tag = "centerdown" Then
            Me.ThumbnailAlign = AlignType.CenterDown
        ElseIf Me.kcks_align.CheckedButton.Tag = "rightdown" Then
            Me.ThumbnailAlign = AlignType.RightDown
        End If
        Me.kbtn_alignement.PerformClick()
        Me.RefreshPreview()
    End Sub

    Private Sub kbtn_make_square_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kbtn_make_square.Click
        Me.CropablePictureBox1.RealCropSize = New Size(Me.knud_width.Value, Me.knud_height.Value)
        Me.CropablePictureBox1.RefreshOutput()
    End Sub

    Private Sub kcbx_smart_scale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kcbx_smart_scale.CheckedChanged
        Me.RefreshPreview()
    End Sub

    Private Sub kcbtn_background_color_SelectedColorChanged(ByVal sender As System.Object, ByVal e As ComponentFactory.Krypton.Toolkit.ColorEventArgs) Handles kcbtn_background_color.SelectedColorChanged
        Me.RefreshPreview()
    End Sub

    Private Sub kbtn_set_crop_size_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kbtn_set_crop_size.Click
        Me.knud_width.Value = Me.CropablePictureBox1.RealCropSize.Width
        Me.knud_height.Value = Me.CropablePictureBox1.RealCropSize.Height
        Me.RefreshPreview()
    End Sub

    Private Sub kcbtn_link_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles kcbtn_link.CheckedChanged
        Me.kcbtn_link.Tag = Me.knud_width.Value / Me.knud_height.Value
        If (Me.kcbtn_link.Checked) Then
            Me.kcbtn_link.Values.Image = My.Resources.link
        Else
            Me.kcbtn_link.Values.Image = My.Resources.link_break
        End If
    End Sub

    Private Sub knud_height_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles knud_height.LostFocus
        If (kcbtn_link.Checked) Then
            Me.knud_width.Value = Me.knud_height.Value * Me.kcbtn_link.Tag
        End If
        Me.RefreshPreview()
    End Sub

    Private Sub knud_width_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles knud_width.LostFocus
        If (Me.kcbtn_link.Checked) Then
            Me.knud_height.Value = Me.knud_width.Value / Me.kcbtn_link.Tag
        End If
        Me.RefreshPreview()
    End Sub

    Private Sub frm_edit_thumbnail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.kcbx_scale_thumbnail.Checked = False
        Me.kcbx_background.Checked = False
        Me.kcbtn_link.Checked = False

        Me.kcbx_smart_scale.Enabled = Me.kcbx_scale_thumbnail.Checked
        Me.kcbtn_background_color.Enabled = Me.kcbx_background.Checked
    End Sub

    Private Sub kbtn_apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kbtn_apply.Click
        frm_main.ChangeThumbnail(Me.pcb_preview.Image, True)
        Me.Close()
    End Sub

    Private Sub kbtn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kbtn_cancel.Click
        Me.Close()
    End Sub
End Class
