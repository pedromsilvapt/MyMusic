Imports System.IO
Imports Transitions
Imports System.Reflection

Public Class frm_main

    Public Structure DragFiles
        Public InvalidDrag As Boolean
        Public Music As String
        Public Image As String
    End Structure

    Public _MusicFile As MusicFile

    Public music_path As String = ""
    Public image_path As String = ""

    Public Shared ImageFormats As List(Of String) = New List(Of String)
    Public Shared MusicFormats As List(Of String) = New List(Of String)

    Private Loading As Boolean = True

    Private t_moving As Boolean = False

    Private terror_showing As Boolean = False

    Private history As List(Of String) = New List(Of String)
    Private history_pos As Integer = -1

    Private WithEvents kpnl_transition_loading_error As Transition = New Transition(New TransitionType_Flash(1, 500))
    Private WithEvents kpnl_transition_loading_editing As Transition = New Transition(New TransitionType_EaseInEaseOut(200))
    Private WithEvents kpnl_transition_loading_color As Transition = New Transition(New TransitionType_EaseInEaseOut(500))
    Private WithEvents kpnl_transition_show_loading As Transition = New Transition(New TransitionType_EaseInEaseOut(200))
    Private WithEvents kpnl_transition_show_editing As Transition = New Transition(New TransitionType_EaseInEaseOut(200))


#Region "Transitions"

    Public Sub TransitionLoadingToEditingPanel()
        Me.kpnl_editing_music.Location = New Point(0, Me.kpnl_loading_music.Size.Height)
        Me.kpnl_editing_music.Visible = True

        kpnl_transition_loading_editing.add(Me.kpnl_loading_music, "Top", -Me.kpnl_loading_music.Size.Height)
        kpnl_transition_loading_editing.add(Me.kpnl_editing_music, "Top", 0)
        kpnl_transition_loading_editing.run()
    End Sub

    Private Sub kpnl_transition_loading_editing_TransitionCompletedEvent(ByVal sender As Object, ByVal e As Transitions.Transition.Args) Handles kpnl_transition_loading_editing.TransitionCompletedEvent
        Me.kpnl_loading_music.Visible = False
    End Sub

#End Region

#Region "Thumbnail"

    Public Sub ChangeThumbnail(ByRef NewThumb As Image, Optional ByVal updateFile As Boolean = True)
        If (updateFile = True) Then
            If (NewThumb Is Nothing) Then
                Me.kbtn_editing_thumbnail_export.Enabled = False
                Me._MusicFile.ClearThumbnail()
            Else
                Me.kbtn_editing_thumbnail_export.Enabled = True
                Me._MusicFile.Thumbnail = NewThumb
            End If
        End If

        If (NewThumb Is Nothing) Then
            Me.pcb_editing_thumbnail.Image = My.Resources.MP3
        Else
            Me.pcb_editing_thumbnail.Image = NewThumb
        End If
    End Sub

    Private Sub kbtn_editing_thumbnail_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kbtn_editing_thumbnail_clear.Click
        Dim res As DialogResult = ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Tem a certeza que pretende apagar o thumbnail da música?", "Apagar Thumbnail", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (res = DialogResult.Yes) Then
            Me.ChangeThumbnail(Nothing)
        End If
    End Sub

    Private Sub kbtn_editing_thumbnail_export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kbtn_editing_thumbnail_export.Click
        If (Me._MusicFile.Thumbnail IsNot Nothing) Then
            Dim name As String = Me._MusicFile.MusicFileName.Substring(0, Me._MusicFile.MusicFileName.Length - My.Computer.FileSystem.GetFileInfo(Me._MusicFile.MusicFile).Extension.Length)
            name &= "_thumbnail.png"

            Me.sfd_export_thumbnail.FileName = name
            Me.sfd_export_thumbnail.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG)|*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG"
            Dim res As Windows.Forms.DialogResult = Me.sfd_export_thumbnail.ShowDialog()
            If res = Windows.Forms.DialogResult.OK Then
                Using img As Image = Me._MusicFile.Thumbnail.Clone()
                    img.Save(Me.sfd_export_thumbnail.FileName, Imaging.ImageFormat.Png)
                End Using
            End If
        End If
    End Sub

    Private Sub kbtn_editing_thumbnail_paste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kbtn_editing_thumbnail_paste.Click
        If (My.Computer.Clipboard.ContainsImage) Then
            Me.ChangeThumbnail(My.Computer.Clipboard.GetImage())
        ElseIf My.Computer.Clipboard.ContainsFileDropList Then
            Dim fileImage As Boolean = False

            For Each _File As String In My.Computer.Clipboard.GetFileDropList
                If (frm_main.ImageFormats.Contains(My.Computer.FileSystem.GetFileInfo(_File).Extension.ToLower())) Then
                    Me.ChangeThumbnail(Image.FromFile(_File))
                    fileImage = True
                    Exit For
                End If
            Next
            If (fileImage = False) Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Não colou nenhuma imagem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("O tipo de dados colado não é suportado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub kbtn_thumbnail_open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kbtn_thumbnail_open.Click
        Me.ofd_thumbnail.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG)|*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG"
        Dim res As Windows.Forms.DialogResult = Me.ofd_thumbnail.ShowDialog()
        If res = Windows.Forms.DialogResult.OK Then
            Me.ChangeThumbnail(Image.FromFile(Me.ofd_thumbnail.FileName))
        End If
    End Sub

    Private Sub kpnl_editing_thumbnail_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles kpnl_editing_thumbnail.DragDrop
        Dim paths As DragFiles = New DragFiles
        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            Dim fileImage As Boolean = False
            For Each _File As String In filePaths
                If (frm_main.ImageFormats.Contains(My.Computer.FileSystem.GetFileInfo(_File).Extension.ToLower())) Then
                    Me.ChangeThumbnail(Image.FromFile(_File), True)
                    fileImage = True
                    Exit For
                ElseIf (frm_main.MusicFormats.Contains(My.Computer.FileSystem.GetFileInfo(_File).Extension.ToLower())) Then
                    Dim tempMeta As MusicFile = New MusicFile(_File)
                    Me.ChangeThumbnail(tempMeta.Thumbnail, True)
                    fileImage = True
                    Exit For
                End If
            Next
            If (fileImage = False) Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Não arrastou nenhuma imagem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf (e.Data.GetDataPresent(DataFormats.Bitmap)) Then
            Me.ChangeThumbnail(e.Data.GetData(DataFormats.Bitmap))
        Else
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("O tipo de dados arrastado não é suportado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub kpnl_editing_thumbnail_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles kpnl_editing_thumbnail.DragEnter
        Dim paths As DragFiles = New DragFiles
        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            For Each _File As String In filePaths
                If (frm_main.ImageFormats.Contains(My.Computer.FileSystem.GetFileInfo(_File).Extension.ToLower())) Then
                    Me.ChangeThumbnail(Image.FromFile(_File), False)
                    Exit For
                ElseIf (frm_main.MusicFormats.Contains(My.Computer.FileSystem.GetFileInfo(_File).Extension.ToLower())) Then
                    Dim tempMeta As MusicFile = New MusicFile(_File)
                    Me.ChangeThumbnail(tempMeta.Thumbnail, False)
                    Exit For
                End If
            Next
        ElseIf (e.Data.GetDataPresent(DataFormats.Bitmap)) Then
            Me.ChangeThumbnail(e.Data.GetData(DataFormats.Bitmap), False)
        End If
    End Sub

    Private Sub kpnl_editing_thumbnail_DragLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles kpnl_editing_thumbnail.DragLeave
        If (Not Me._MusicFile.Thumbnail Is Nothing) Then
            Me.pcb_editing_thumbnail.Image = Me._MusicFile.Thumbnail
        Else
            Me.pcb_editing_thumbnail.Image = My.Resources.MP3
        End If
    End Sub

    Private Sub pcb_editing_thumbnail_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pcb_editing_thumbnail.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If (Me._MusicFile.Thumbnail Is Nothing) Then
                Me.KryptonContextMenuItem1.Enabled = False
                Me.KryptonContextMenuItem2.Enabled = False
            Else
                Me.KryptonContextMenuItem1.Enabled = True
                Me.KryptonContextMenuItem2.Enabled = True
            End If
            Me.kcmd_thumbnail.Show(Me.pcb_editing_thumbnail, New Point(frm_main.MousePosition.X, frm_main.MousePosition.Y))
        End If
    End Sub

    'Copy thumbnail to clipboard
    Private Sub KryptonContextMenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles KryptonContextMenuItem1.Click
        My.Computer.Clipboard.SetImage(Me.pcb_editing_thumbnail.Image)

        Dim name As String = Me._MusicFile.MusicFileName.Substring(0, Me._MusicFile.MusicFileName.Length - My.Computer.FileSystem.GetFileInfo(Me._MusicFile.MusicFile).Extension.Length)
        name &= "_thumbnail.png"

        Using img As Image = Me.pcb_editing_thumbnail.Image.Clone()
            img.Save(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & name, Imaging.ImageFormat.Png)
        End Using

        Dim fileas As Collections.Specialized.StringCollection = New Collections.Specialized.StringCollection()
        fileas.Add(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & name)

        My.Computer.Clipboard.SetFileDropList(fileas)
    End Sub

    Private Sub pcb_editing_thumbnail_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pcb_editing_thumbnail.MouseEnter
        Me.t_moving = False
    End Sub

    Private Sub pcb_editing_thumbnail_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pcb_editing_thumbnail.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.t_moving = True
        End If
    End Sub

    Private Sub pcb_editing_thumbnail_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pcb_editing_thumbnail.MouseMove
        If (Me.t_moving) Then
            Try
                Dim name As String = Me._MusicFile.MusicFileName.Substring(0, Me._MusicFile.MusicFileName.Length - My.Computer.FileSystem.GetFileInfo(Me._MusicFile.MusicFile).Extension.Length)
                name &= "_thumbnail.png"

                Using img As Image = Me.pcb_editing_thumbnail.Image.Clone()
                    img.Save(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & name, Imaging.ImageFormat.Png)
                End Using

                Dim fileas As String() = New [String](0) {}
                fileas(0) = My.Computer.FileSystem.SpecialDirectories.Temp & "\" & name
                Dim dta = New DataObject(DataFormats.FileDrop, fileas)
                dta.SetData(DataFormats.StringFormat, fileas)
                dta.SetData(DataFormats.Bitmap, Me.pcb_editing_thumbnail.Image)
                kpnl_editing_thumbnail.DoDragDrop(dta, DragDropEffects.Copy)
            Catch ex As Exception
                Me.t_moving = False
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show(ex.Message, "Erro de GDI+", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            'kpnl_editing_thumbnail.DoDragDrop(My.Computer.FileSystem.SpecialDirectories.Temp & "\tempthumb_mymusic.png", DragDropEffects.Copy)
        End If
        Me.t_moving = False
    End Sub

#End Region

#Region "Tags"
    Private Sub tvktxt_album_Text1Changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles tvktxt_album.Text1Changed
        If Not Me.Loading Then
            Me._MusicFile.Album = Me.tvktxt_album.TextBoxValue1
        End If
    End Sub

    Private Sub tvktxt_artists_Text1Changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles tvktxt_artists.Text1Changed
        If Not Me.Loading Then
            Me._MusicFile.ArtistsString = Me.tvktxt_artists.TextBoxValue
        End If
    End Sub

    Private Sub tvktxt_comments_Text1Changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles tvktxt_comments.Text1Changed
        If Not Me.Loading Then
            Me._MusicFile.Legend = Me.tvktxt_comments.TextBoxValue1
        End If
    End Sub

    Private Sub tvktxt_genres_Text1Changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles tvktxt_genres.Text1Changed
        If Not Me.Loading Then
            Me._MusicFile.GenresString = Me.tvktxt_genres.TextBoxValue
        End If
    End Sub

    Private Sub tvktxt_interpret_Text1Changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles tvktxt_interpret.Text1Changed
        If Not Me.Loading Then
            Me._MusicFile.AlbumArtist = Me.tvktxt_interpret.TextBoxValue1
        End If
    End Sub

    Private Sub tvktxt_number_Text1Changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles tvktxt_number.Text1Changed
        If Not Me.Loading Then
            Me._MusicFile.Number = Me.tvktxt_number.TextBoxValue1
        End If
    End Sub

    Private Sub tvktxt_title_Text1Changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles tvktxt_title.Text1Changed
        If Not Me.Loading Then
            Me._MusicFile.Title = Me.tvktxt_title.TextBoxValue1
        End If
    End Sub

    Private Sub tvktxt_year_Text1Changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles tvktxt_year.Text1Changed
        If Not Me.Loading Then
            Me._MusicFile.Year = Convert.ToInt32(Me.tvktxt_year.TextBoxValue1)
        End If
    End Sub

    Private Sub tvktxt_lyrics_Text1Changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles tvktxt_lyrics.Text1Changed
        If Not Me.Loading Then
            Me._MusicFile.Lyrics = Me.tvktxt_lyrics.TextBoxValue1
        End If
    End Sub

    Private Sub rc_classification_RatingUpdated(ByVal curRating As Integer) Handles rc_classification.RatingUpdated
        If Not Me.Loading Then
            Me._MusicFile.Rate = Me.rc_classification.Value
        End If
    End Sub

    Private Sub kbtn_clear_rating_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kbtn_clear_rating.Click
        Me.rc_classification.cleanRating()
    End Sub

    Private Sub kltt_editing_filename_TextBoxLostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles kltt_editing_filename.TextBoxLostFocus
        Try
            Me._MusicFile.MusicFileName = Me.kltt_editing_filename.Text
        Catch ex As Exception
            Dim res As DialogResult = ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show(ex.Message, "Erro ao mudar o nome", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            If res = Windows.Forms.DialogResult.Retry Then
                kltt_editing_filename_TextBoxLostFocus(Nothing, Nothing)
            Else
                Me.kltt_editing_filename.Text = Me._MusicFile.MusicFileName
            End If
        End Try
    End Sub
#End Region

#Region "Startup Loading Panel"

    Private Sub kpnl_loading_music_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles kpnl_loading_music.DragEnter
        Dim paths As DragFiles = Me.CheckFileDrags(sender, e)
        If (paths.InvalidDrag = False) Then
            Me.klbl_loading_drag_files.Visible = False
            Me.ShowLoadingPanel(paths.Music, paths.Image)
        End If
    End Sub

    Private Sub kpnl_loading_music_DragLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles kpnl_loading_music.DragLeave
        HideLoadingItems()
        Me.klbl_loading_drag_files.Visible = True
    End Sub

    Private Sub kpnl_loading_music_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles kpnl_loading_music.DragDrop
        Dim paths As DragFiles = Me.CheckFileDrags(sender, e)

        If (paths.InvalidDrag = False) Then
            Me.music_path = paths.Music
            Me.image_path = paths.Image
            Me.OpenFile(paths.Music, paths.Image)
        End If
    End Sub

#End Region

#Region "Runtime Loading Panel"

    Private Sub kpnl_transition_loading_error_TransitionCompletedEvent(ByVal sender As Object, ByVal e As Transitions.Transition.Args) Handles kpnl_transition_loading_error.TransitionCompletedEvent
        Me.terror_showing = False
    End Sub

    Private Sub kpnl_rloading_music_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles kpnl_rloading_music.MouseClick
        If (My.Computer.Clipboard.ContainsFileDropList) Then
            Dim files As Collections.Specialized.StringCollection = My.Computer.Clipboard.GetFileDropList()

            Dim filesDrop As DragFiles = Me.CheckFileOpens(files)

            If (filesDrop.InvalidDrag) Then
                Dim res As DialogResult = ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Os ficheiros que copiou são inválidos.", "Erro ao abrir", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                If (res = DialogResult.Retry) Then
                    Me.kpnl_rloading_music_MouseClick(sender, e)
                End If
            Else
                Me.OpenFile(filesDrop.Music, filesDrop.Image)
            End If
        End If
    End Sub

    Private Sub kpnl_rloading_music_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles kpnl_rloading_music.DragDrop
        Dim paths As DragFiles = Me.CheckFileDrags(sender, e)

        If paths.InvalidDrag = False Then
            Me.ktdlg_open_music.Content = paths.Music

            Dim result = DialogResult.OK

            If Me._MusicFile.Edited Then
                result = Me.ktdlg_open_music.ShowDialog()
            End If

            If (result = Windows.Forms.DialogResult.Retry) Then
                Me.kbtn_editing_save_Click(Nothing, Nothing)
                Me.OpenFile(paths.Music, paths.Image)
            ElseIf (result = Windows.Forms.DialogResult.OK) Then
                Me.OpenFile(paths.Music, paths.Image)
            End If
        End If

        Me.RHideLoadingItems()

        Me.kpnl_rloading_music.StateCommon.Image = My.Resources.application_get

        Me.kpnl_transition_loading_color = New Transition(New TransitionType_EaseInEaseOut(200))
        Me.kpnl_transition_loading_color.add(Me.kpnl_rloading_music, "Top", 14)
        Me.kpnl_transition_loading_color.add(Me.kpnl_rloading_music, "Left", 727)
        Me.kpnl_transition_loading_color.add(Me.kpnl_rloading_music, "Height", 235)
        Me.kpnl_transition_loading_color.add(Me.kpnl_rloading_music, "Width", 94)
        Me.kpnl_transition_loading_color.run()
    End Sub

    Private Sub kpnl_rloading_music_DragLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles kpnl_rloading_music.DragLeave
        Me.RHideLoadingItems()

        Me.kpnl_rloading_music.StateCommon.Image = My.Resources.application_get

        Me.kpnl_transition_loading_color = New Transition(New TransitionType_EaseInEaseOut(200))
        Me.kpnl_transition_loading_color.add(Me.kpnl_rloading_music, "Top", 14)
        Me.kpnl_transition_loading_color.add(Me.kpnl_rloading_music, "Left", 727)
        Me.kpnl_transition_loading_color.add(Me.kpnl_rloading_music, "Height", 235)
        Me.kpnl_transition_loading_color.add(Me.kpnl_rloading_music, "Width", 94)
        Me.kpnl_transition_loading_color.run()
    End Sub

    Private Sub kpnl_runtime_loading_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles kpnl_rloading_music.DragEnter
        Dim paths As DragFiles = Me.CheckFileDrags(sender, e)

        If (paths.InvalidDrag) Then
            If (Me.terror_showing = False) Then
                Me.terror_showing = True
                Me.kpnl_transition_loading_error = New Transitions.Transition(New Transitions.TransitionType_Flash(1, 500))
                Me.kpnl_transition_loading_error.add(Me.kpnl_rloading_music.StateCommon, "Color1", Color.FromArgb(255, 255, 160, 160))
                Me.kpnl_transition_loading_error.run()
            End If
        Else
            Me.kpnl_rloading_music.StateCommon.Image = Nothing

            Me.kpnl_rloading_music.Top = 0
            Me.kpnl_rloading_music.Left = 0
            Me.kpnl_rloading_music.Height = Me.kpnl_editing_music.Height
            Me.kpnl_rloading_music.Width = Me.kpnl_editing_music.Width
            Me.RShowLoadingPanel(paths.Music, paths.Image)
        End If
    End Sub

    Private Sub kpnl_runtime_loading_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles kpnl_rloading_music.MouseHover
        Me.kpnl_transition_loading_color = New Transition(New TransitionType_EaseInEaseOut(500))

        Me.kpnl_transition_loading_color.add(Me.kpnl_rloading_music.StateCommon, "Color1", Color.DarkGray)
        Me.kpnl_transition_loading_color.run()
    End Sub

    Private Sub kpnl_runtime_loading_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles kpnl_rloading_music.MouseLeave
        Me.kpnl_transition_loading_color = New Transition(New TransitionType_EaseInEaseOut(500))

        Me.kpnl_transition_loading_color.add(Me.kpnl_rloading_music.StateCommon, "Color1", Me.kpnl_editing_music.StateCommon.GetBackColor1(ComponentFactory.Krypton.Toolkit.PaletteState.Normal))
        Me.kpnl_transition_loading_color.run()
    End Sub

    Public Sub RHideLoadingItems()
        Me.klbl_rloading_music.Visible = False
        Me.klbl_rloading_thumbnail.Visible = False
        Me.kwlbl_rloading_music_name.Visible = False
        Me.kwlbl_rloading_thumbnail_name.Visible = False
        Me.pcb_rloading_music.Visible = False
        Me.pcb_rloading_thumbnail.Visible = False
    End Sub

    Public Sub RShowLoadingPanel(ByVal music_path As String, Optional ByVal image_path As String = "")
        Me.RHideLoadingItems()

        Dim TempMusicFile As MusicFile = New MusicFile(music_path)

        If (image_path <> "") Then
            Me.klbl_rloading_music.Location = New Point(Me.kpnl_rloading_music.Size.Width / 2 - Me.klbl_rloading_music.Size.Width - 50, 20)
            Me.klbl_rloading_thumbnail.Location = New Point(Me.kpnl_rloading_music.Size.Width / 2 + 50, 20)

            Me.pcb_rloading_music.Location = New Point((Me.klbl_rloading_music.Location.X + Me.klbl_rloading_music.Size.Width / 2) - Me.pcb_rloading_music.Size.Width / 2, 67)
            Me.pcb_rloading_thumbnail.Location = New Point((Me.klbl_rloading_thumbnail.Location.X + Me.klbl_rloading_thumbnail.Size.Width / 2) - Me.pcb_rloading_thumbnail.Size.Width / 2, 67)

            Me.kwlbl_rloading_music_name.Location = New Point((Me.klbl_rloading_music.Location.X + Me.klbl_rloading_music.Size.Width / 2) - Me.kwlbl_rloading_music_name.Size.Width / 2, 235)
            Me.kwlbl_rloading_thumbnail_name.Location = New Point((Me.klbl_rloading_thumbnail.Location.X + Me.klbl_rloading_thumbnail.Size.Width / 2) - Me.kwlbl_rloading_thumbnail_name.Size.Width / 2, 235)

            Me.klbl_rloading_music.Visible = True
            Me.klbl_rloading_thumbnail.Visible = True

            Me.pcb_rloading_music.Visible = True
            Me.pcb_rloading_thumbnail.Visible = True

            Me.kwlbl_rloading_music_name.Visible = True
            Me.kwlbl_rloading_thumbnail_name.Visible = True

            Me.pcb_rloading_music.BackColor = Me.kpnl_rloading_music.StateCommon.GetBackColor1(ComponentFactory.Krypton.Toolkit.PaletteState.Normal)
            Me.pcb_rloading_thumbnail.BackColor = Me.kpnl_rloading_music.StateCommon.GetBackColor1(ComponentFactory.Krypton.Toolkit.PaletteState.Normal)
            Me.pcb_rloading_thumbnail.Image = Image.FromFile(image_path)

            Me.kwlbl_rloading_music_name.Text = My.Computer.FileSystem.GetFileInfo(music_path).Name
            Me.kwlbl_rloading_thumbnail_name.Text = My.Computer.FileSystem.GetFileInfo(image_path).Name
        Else
            Me.klbl_rloading_music.Location = New Point(Me.kpnl_rloading_music.Size.Width / 2 - Me.klbl_rloading_music.Size.Width / 2, 20)

            Me.pcb_rloading_music.Location = New Point((Me.klbl_rloading_music.Location.X + Me.klbl_rloading_music.Size.Width / 2) - Me.pcb_rloading_music.Size.Width / 2, 67)

            Me.kwlbl_rloading_music_name.Location = New Point((Me.klbl_rloading_music.Location.X + Me.klbl_rloading_music.Size.Width / 2) - Me.kwlbl_rloading_music_name.Size.Width / 2, 235)

            Me.klbl_rloading_music.Visible = True

            Me.pcb_rloading_music.Visible = True

            Me.kwlbl_rloading_music_name.Visible = True

            Me.pcb_rloading_music.BackColor = Me.kpnl_rloading_music.StateCommon.GetBackColor1(ComponentFactory.Krypton.Toolkit.PaletteState.Normal)

            Me.kwlbl_rloading_music_name.Text = My.Computer.FileSystem.GetFileInfo(music_path).Name
        End If

        If (Not TempMusicFile.Thumbnail Is Nothing) Then
            Me.pcb_rloading_music.Image = TempMusicFile.Thumbnail
        Else
            Me.pcb_rloading_music.Image = My.Resources.MP3
        End If

    End Sub

    Private Sub kpnl_rloading_music_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles kpnl_rloading_music.SizeChanged
        If (Me.pcb_rloading_music.Visible = True And Me.pcb_rloading_thumbnail.Visible = True) Then
            Me.klbl_rloading_music.Location = New Point(Me.kpnl_rloading_music.Size.Width / 2 - Me.klbl_rloading_music.Size.Width - 50, 20)
            Me.klbl_rloading_thumbnail.Location = New Point(Me.kpnl_rloading_music.Size.Width / 2 + 50, 20)

            Me.pcb_rloading_music.Location = New Point((Me.klbl_rloading_music.Location.X + Me.klbl_rloading_music.Size.Width / 2) - Me.pcb_rloading_music.Size.Width / 2, 67)
            Me.pcb_rloading_thumbnail.Location = New Point((Me.klbl_rloading_thumbnail.Location.X + Me.klbl_rloading_thumbnail.Size.Width / 2) - Me.pcb_rloading_thumbnail.Size.Width / 2, 67)

            Me.kwlbl_rloading_music_name.Location = New Point((Me.klbl_rloading_music.Location.X + Me.klbl_rloading_music.Size.Width / 2) - Me.kwlbl_rloading_music_name.Size.Width / 2, 235)
            Me.kwlbl_rloading_thumbnail_name.Location = New Point((Me.klbl_rloading_thumbnail.Location.X + Me.klbl_rloading_thumbnail.Size.Width / 2) - Me.kwlbl_rloading_thumbnail_name.Size.Width / 2, 235)
        ElseIf (Me.pcb_rloading_music.Visible = True) Then
            Me.klbl_rloading_music.Location = New Point(Me.kpnl_rloading_music.Size.Width / 2 - Me.klbl_rloading_music.Size.Width / 2, 20)

            Me.pcb_rloading_music.Location = New Point((Me.klbl_rloading_music.Location.X + Me.klbl_rloading_music.Size.Width / 2) - Me.pcb_rloading_music.Size.Width / 2, 67)

            Me.kwlbl_rloading_music_name.Location = New Point((Me.klbl_rloading_music.Location.X + Me.klbl_rloading_music.Size.Width / 2) - Me.kwlbl_rloading_music_name.Size.Width / 2, 235)
        End If
    End Sub

#End Region

#Region "File"

    Private Sub kpnl_transition_show_loading_TransitionCompletedEvent(ByVal sender As Object, ByVal e As Transitions.Transition.Args) Handles kpnl_transition_show_loading.TransitionCompletedEvent
        Me.kpnl_editing_music.Visible = False
    End Sub

    Private Sub kpnl_transition_show_editing_TransitionCompletedEvent(ByVal sender As Object, ByVal e As Transitions.Transition.Args) Handles kpnl_transition_show_editing.TransitionCompletedEvent
        Me.kpnl_loading_music.Visible = False
    End Sub

    Public Sub ShowLoading()
        If (Not Me.kpnl_loading_music.Visible And Me.kpnl_editing_music.Visible) Then
            Me.kpnl_loading_music.Location = New Point(0, Me.kpnl_editing_music.Size.Height)
            Me.kpnl_loading_music.Visible = True
            Me.HideLoadingItems()
            Me.kpnl_loading_music.SendToBack()

            Me.kpnl_editing_music.Location = New Point(0, 0)

            Me.kpnl_transition_show_loading = New Transition(New TransitionType_EaseInEaseOut(200))
            Me.kpnl_transition_show_loading.add(Me.kpnl_editing_music, "Top", Me.kpnl_editing_music.Size.Height * -1)
            Me.kpnl_transition_show_loading.add(Me.kpnl_loading_music, "Top", 0)
            Me.kpnl_transition_show_loading.run()
        End If
    End Sub

    Public Sub ShowEditing()
        If (Me.kpnl_loading_music.Visible And Not Me.kpnl_editing_music.Visible) Then
            Me.kpnl_editing_music.Location = New Point(0, Me.kpnl_loading_music.Size.Height)
            Me.kpnl_editing_music.Visible = True
            Me.kpnl_editing_music.SendToBack()

            Me.kpnl_loading_music.Location = New Point(0, 0)

            Me.kpnl_transition_show_editing = New Transition(New TransitionType_EaseInEaseOut(200))
            Me.kpnl_transition_show_editing.add(Me.kpnl_loading_music, "Top", Me.kpnl_editing_music.Size.Height * -1)
            Me.kpnl_transition_show_editing.add(Me.kpnl_editing_music, "Top", 0)
            Me.kpnl_transition_show_editing.run()
        End If
    End Sub

    Public Sub AddToHistory(ByVal file As String)
        If (Me.history.Count - 1 > Me.history_pos + 1) Then
            Dim l As Integer = Me.history.Count
            For i As Integer = Me.history_pos To l Step 1
                Me.history.RemoveAt(i)
            Next
        End If
        Me.history.Add(file)
        Me.history_pos += 1
    End Sub

    Public Sub CloseFile(Optional ByVal ShowLoadingPanel As Boolean = True)
        Me.Loading = True
        Me.ClearEditingGUI()

        If (ShowLoadingPanel) Then
            Me.ShowLoading()
        End If

        Me.music_path = ""
        Me.image_path = ""
        Me._MusicFile = Nothing
    End Sub

    Public Sub OpenFile(ByVal MusicPath As String, Optional ByVal ImagePath As String = "", Optional ByVal UpdateHistory As Boolean = True)
        Me.CloseFile(False)

        Me.music_path = MusicPath
        Me.image_path = ImagePath

        Me.LoadMusicFileIntoGUI(MusicPath, ImagePath)
        Me.ActivateEditingGUI()
        Me.Loading = False

        If (UpdateHistory) Then
            Me.AddToHistory(MusicPath)
        End If

        Me.ShowEditing()
    End Sub

    Public Sub ClearEditingGUI()
        Me.pcb_editing_thumbnail.Image = My.Resources.MP3
        Me.kbtn_editing_thumbnail_clear.Enabled = False
        Me.kbtn_editing_thumbnail_export.Enabled = False
        Me.kbtn_editing_thumbnail_paste.Enabled = False
        Me.kbtn_thumbnail_open.Enabled = False
        Me.kbtn_clear_rating.Enabled = False
        Me.kbtn_editing_save.Enabled = False

        Me.tvktxt_album.TextBoxValue = ""
        Me.tvktxt_artists.TextBoxValue = ""
        Me.tvktxt_comments.TextBoxValue = ""
        Me.tvktxt_genres.TextBoxValue = ""
        Me.tvktxt_interpret.TextBoxValue = ""
        Me.tvktxt_lyrics.TextBoxValue = ""
        Me.tvktxt_number.TextBoxValue = ""
        Me.tvktxt_title.TextBoxValue = ""
        Me.tvktxt_year.TextBoxValue = ""
    End Sub

    Public Sub ActivateEditingGUI()
        If (Me._MusicFile IsNot Nothing) Then
            Me.kbtn_editing_thumbnail_clear.Enabled = True

            If (Me._MusicFile.Thumbnail IsNot Nothing) Then
                Me.kbtn_editing_thumbnail_export.Enabled = True
            End If

            Me.kbtn_editing_thumbnail_paste.Enabled = True
            Me.kbtn_thumbnail_open.Enabled = True
            Me.kbtn_clear_rating.Enabled = True
            Me.kbtn_editing_save.Enabled = True
        End If
    End Sub

    Public Sub LoadMusicFileIntoGUI(ByVal music As String, Optional ByVal image As String = "")
        Me.Loading = True
        Try
            Me._MusicFile = New MusicFile(music, image)

            Me.kltt_editing_filename.Text = My.Computer.FileSystem.GetFileInfo(music).Name

            Me.tvktxt_title.TextBoxValue1 = Me._MusicFile.Title
            Me.tvktxt_title.RevertText = Me._MusicFile.Title

            Me.tvktxt_comments.TextBoxValue1 = Me._MusicFile.Legend
            Me.tvktxt_comments.RevertText = Me._MusicFile.Legend

            Me.tvktxt_artists.TextBoxValue1 = Me._MusicFile.ArtistsString
            Me.tvktxt_artists.RevertText = Me._MusicFile.ArtistsString

            Me.tvktxt_interpret.TextBoxValue1 = Me._MusicFile.AlbumArtist
            Me.tvktxt_interpret.RevertText = Me._MusicFile.AlbumArtist

            Me.tvktxt_album.TextBoxValue1 = Me._MusicFile.Album
            Me.tvktxt_album.RevertText = Me._MusicFile.Album

            Me.tvktxt_year.TextBoxValue1 = Me._MusicFile.Year
            Me.tvktxt_year.RevertText = Me._MusicFile.Year

            Me.tvktxt_number.TextBoxValue1 = Me._MusicFile.Number
            Me.tvktxt_number.RevertText = Me._MusicFile.Number

            Me.tvktxt_genres.TextBoxValue1 = Me._MusicFile.GenresString
            Me.tvktxt_genres.RevertText = Me._MusicFile.GenresString

            Me.tvktxt_lyrics.TextBoxValue1 = Me._MusicFile.Lyrics
            Me.tvktxt_lyrics.RevertText = Me._MusicFile.Lyrics

            Me.rc_classification.Value = Me._MusicFile.Rate

            If (image <> "" And (Not image Is Nothing)) Then
                Me._MusicFile.Thumbnail = Drawing.Image.FromFile(image)
                Me.ChangeThumbnail(Me._MusicFile.Thumbnail, True)
            Else
                Dim imageThumb As Image = Me._MusicFile.Thumbnail
                Me.ChangeThumbnail(imageThumb, False)
            End If

        Catch ex As Exception
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show(ex.Message, "Erro ao abrir", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Loading = False
    End Sub

    Public Sub ShowLoadingPanel(ByVal music_path As String, Optional ByVal image_path As String = "")
        Me.HideLoadingItems()
        Try
            Dim TempMusicFile As MusicFile = New MusicFile(music_path)

            If (image_path <> "") Then
                Me.klbl_loading_music.Location = New Point(Me.kpnl_loading_music.Size.Width / 2 - Me.klbl_loading_music.Size.Width - 50, 20)
                Me.klbl_loading_thumbnail.Location = New Point(Me.kpnl_loading_music.Size.Width / 2 + 50, 20)

                Me.pcb_loading_music.Location = New Point((Me.klbl_loading_music.Location.X + Me.klbl_loading_music.Size.Width / 2) - Me.pcb_loading_music.Size.Width / 2, 67)
                Me.pcb_loading_thumbnail.Location = New Point((Me.klbl_loading_thumbnail.Location.X + Me.klbl_loading_thumbnail.Size.Width / 2) - Me.pcb_loading_thumbnail.Size.Width / 2, 67)

                Me.kwlbl_loading_music_name.Location = New Point((Me.klbl_loading_music.Location.X + Me.klbl_loading_music.Size.Width / 2) - Me.kwlbl_loading_music_name.Size.Width / 2, 235)
                Me.kwlbl_loading_thumbnail_name.Location = New Point((Me.klbl_loading_thumbnail.Location.X + Me.klbl_loading_thumbnail.Size.Width / 2) - Me.kwlbl_loading_thumbnail_name.Size.Width / 2, 235)

                Me.klbl_loading_music.Visible = True
                Me.klbl_loading_thumbnail.Visible = True

                Me.pcb_loading_music.Visible = True
                Me.pcb_loading_thumbnail.Visible = True

                Me.kwlbl_loading_music_name.Visible = True
                Me.kwlbl_loading_thumbnail_name.Visible = True

                Me.pcb_loading_music.BackColor = Me.kpnl_loading_music.StateCommon.GetBackColor1(ComponentFactory.Krypton.Toolkit.PaletteState.Normal)
                Me.pcb_loading_thumbnail.BackColor = Me.kpnl_loading_music.StateCommon.GetBackColor1(ComponentFactory.Krypton.Toolkit.PaletteState.Normal)
                Me.pcb_loading_thumbnail.Image = Image.FromFile(image_path)

                Me.kwlbl_loading_music_name.Text = My.Computer.FileSystem.GetFileInfo(music_path).Name
                Me.kwlbl_loading_thumbnail_name.Text = My.Computer.FileSystem.GetFileInfo(image_path).Name
            Else
                Me.klbl_loading_music.Location = New Point(Me.kpnl_loading_music.Size.Width / 2 - Me.klbl_loading_music.Size.Width / 2, 20)

                Me.pcb_loading_music.Location = New Point((Me.klbl_loading_music.Location.X + Me.klbl_loading_music.Size.Width / 2) - Me.pcb_loading_music.Size.Width / 2, 67)

                Me.kwlbl_loading_music_name.Location = New Point((Me.klbl_loading_music.Location.X + Me.klbl_loading_music.Size.Width / 2) - Me.kwlbl_loading_music_name.Size.Width / 2, 235)

                Me.klbl_loading_music.Visible = True

                Me.pcb_loading_music.Visible = True

                Me.kwlbl_loading_music_name.Visible = True

                Me.pcb_loading_music.BackColor = Me.kpnl_loading_music.StateCommon.GetBackColor1(ComponentFactory.Krypton.Toolkit.PaletteState.Normal)

                Me.kwlbl_loading_music_name.Text = My.Computer.FileSystem.GetFileInfo(music_path).Name
            End If

            If (Not TempMusicFile.Thumbnail Is Nothing) Then
                Me.pcb_loading_music.Image = TempMusicFile.Thumbnail
            Else
                Me.pcb_loading_music.Image = My.Resources.MP3
            End If
        Catch ex As Exception
            Me.HideLoadingItems()
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show(ex.Message, "Erro ao abrir", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

    Public Function CheckFileOpens(ByVal files As Collections.Specialized.StringCollection) As DragFiles
        Dim paths As DragFiles = New DragFiles

        Dim i As Integer = 0
        Dim music As Boolean = False
        Dim image As Boolean = False

        While ((music = False Or image = False) And i < files.Count)

            'Checks if the dropped file exists
            If (Not File.Exists(files(i))) Then
                Continue While
            End If

            'Then checks the file type, and if it any we are looking for
            If (frm_main.MusicFormats.Contains(My.Computer.FileSystem.GetFileInfo(files(i)).Extension.ToLower()) And music = False) Then
                paths.Music = files(i)
                music = True
            ElseIf (frm_main.ImageFormats.Contains(My.Computer.FileSystem.GetFileInfo(files(i)).Extension.ToLower()) And image = False) Then
                paths.Image = files(i)
                image = True
            End If

            'Checks if there is any music, otherwise it will be an invalid drag
            If (music = True) Then
                paths.InvalidDrag = False
            Else
                paths.InvalidDrag = True
            End If
            i += 1
        End While

        Return (paths)
    End Function

    Public Function CheckFileDrags(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) As DragFiles
        Dim paths As DragFiles = New DragFiles
        paths.InvalidDrag = True
        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())

            Dim i As Integer = 0
            Dim music As Boolean = False
            Dim image As Boolean = False

            While ((music = False Or image = False) And i < filePaths.Length)

                'Checks if the dropped file exists
                If (Not File.Exists(filePaths(i))) Then
                    Continue While
                End If

                'Then checks the file type, and if it any we are looking for
                If (frm_main.MusicFormats.Contains(My.Computer.FileSystem.GetFileInfo(filePaths(i)).Extension.ToLower()) And music = False) Then
                    paths.Music = filePaths(i)
                    music = True
                ElseIf (frm_main.ImageFormats.Contains(My.Computer.FileSystem.GetFileInfo(filePaths(i)).Extension.ToLower()) And image = False) Then
                    paths.Image = filePaths(i)
                    image = True
                End If

                'Checks if there is any music, otherwise it will be an invalid drag
                If (music = True) Then
                    paths.InvalidDrag = False
                Else
                    paths.InvalidDrag = True
                End If
                i += 1
            End While

            Return (paths)
        End If

        paths.InvalidDrag = True
        Return paths
    End Function

    Private Sub frm_main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me._MusicFile IsNot Nothing Then
            If (Me._MusicFile.Edited) Then
                Me.ktdlg_close_window.Content = Me.music_path
                Dim result As DialogResult = Me.ktdlg_close_window.ShowDialog()

                If (result = Windows.Forms.DialogResult.Cancel) Then
                    e.Cancel = True
                ElseIf (result = Windows.Forms.DialogResult.OK) Then
                    Me.kbtn_editing_save_Click(Nothing, Nothing)
                End If
            End If
        End If
    End Sub

    Private Sub frm_main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        frm_main.ImageFormats.Add(".jpg")
        frm_main.ImageFormats.Add(".jpeg")
        frm_main.ImageFormats.Add(".png")
        frm_main.ImageFormats.Add(".bmp")

        frm_main.MusicFormats.Add(".mp3")
        frm_main.MusicFormats.Add(".wav")

        Me.kpnl_editing_music.Visible = False
        Me.kpnl_loading_music.Visible = True

        Me.kpnl_rloading_music.StateCommon.Color1 = Me.kpnl_editing_music.StateCommon.GetBackColor1(ComponentFactory.Krypton.Toolkit.PaletteState.Normal)

        Me.sfd_export_thumbnail.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyMusic
    End Sub


    Public Sub HideLoadingItems()
        Me.klbl_loading_music.Visible = False
        Me.klbl_loading_thumbnail.Visible = False
        Me.kwlbl_loading_music_name.Visible = False
        Me.kwlbl_loading_thumbnail_name.Visible = False
        Me.pcb_loading_music.Visible = False
        Me.pcb_loading_thumbnail.Visible = False

        Me.klbl_loading_drag_files.Visible = True
    End Sub

    Private Sub kbtn_editing_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kbtn_editing_save.Click
        Me.pcb_editing_saving.Visible = True
        'If (Me.kltt_editing_filename.Text = Me._MusicFile.MusicFileName) Then
        '    Me._MusicFile.Save()
        'Else
        '    Me._MusicFile.MusicFileName = Me.kltt_editing_filename.Text
        'End If
        Try
            Me._MusicFile.Save()

            Me.tvktxt_title.TextBoxValue1 = Me._MusicFile.Title
            Me.tvktxt_title.RevertText = Me._MusicFile.Title

            Me.tvktxt_comments.TextBoxValue1 = Me._MusicFile.Legend
            Me.tvktxt_comments.RevertText = Me._MusicFile.Legend

            Me.tvktxt_artists.TextBoxValue1 = Me._MusicFile.ArtistsString
            Me.tvktxt_artists.RevertText = Me._MusicFile.ArtistsString

            Me.tvktxt_interpret.TextBoxValue1 = Me._MusicFile.AlbumArtist
            Me.tvktxt_interpret.RevertText = Me._MusicFile.AlbumArtist

            Me.tvktxt_album.TextBoxValue1 = Me._MusicFile.Album
            Me.tvktxt_album.RevertText = Me._MusicFile.Album

            Me.tvktxt_year.TextBoxValue1 = Me._MusicFile.Year
            Me.tvktxt_year.RevertText = Me._MusicFile.Year

            Me.tvktxt_number.TextBoxValue1 = Me._MusicFile.Number
            Me.tvktxt_number.RevertText = Me._MusicFile.Number

            Me.tvktxt_genres.TextBoxValue1 = Me._MusicFile.GenresString
            Me.tvktxt_genres.RevertText = Me._MusicFile.GenresString

            Me.tvktxt_lyrics.TextBoxValue1 = Me._MusicFile.Lyrics
            Me.tvktxt_lyrics.RevertText = Me._MusicFile.Lyrics

        Catch ex As Exception
            Dim res As DialogResult = ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show(ex.Message, "Erro ao guardar", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            If (res = DialogResult.Retry) Then
                Me.kbtn_editing_save.PerformClick()
            End If
        End Try

        Me.pcb_editing_saving.Visible = False
    End Sub

    Private Sub kbtn_info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kbtn_info.Click
        frm_about.ShowDialog()
    End Sub

    Private Sub kbtn_loading_info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kbtn_loading_info.Click
        frm_about.ShowDialog()
    End Sub

    Private Sub KryptonContextMenuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles KryptonContextMenuItem2.Click
        frm_edit_thumbnail.Thumbnail = Me._MusicFile.Thumbnail
        frm_edit_thumbnail.ShowDialog()
    End Sub

    Private Sub kbtn_close_music_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kbtn_close_music.Click
        Me.CloseFile(True)
    End Sub

    Private Sub kbtn_history_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kbtn_history_back.Click
        If (Me.history_pos > 0) Then
            Me.history_pos -= 1
            Me.OpenFile(Me.history(Me.history_pos), "", False)
        End If
    End Sub

    Private Sub kbtn_history_forward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kbtn_history_forward.Click
        If (Me.history_pos < Me.history.Count - 1) Then
            Me.history_pos += 1
            Me.OpenFile(Me.history(Me.history_pos), "", False)
        End If
    End Sub
End Class
