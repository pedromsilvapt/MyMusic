Imports System.IO
Imports Transitions

Public Class frm_main

    Public Structure DragFiles
        Public InvalidDrag As Boolean
        Public Music As String
        Public Image As String
    End Structure

    Public _MusicFile As MusicFile

    Public music_path As String = ""
    Public image_path As String = ""

    Public ImageFormats As List(Of String) = New List(Of String)

    Private Loading As Boolean = True

    Private t_moving As Boolean = False

    Private terror_showing As Boolean = False


    Private WithEvents kpnl_transition_loading_error As Transition = New Transition(New Transitions.TransitionType_Flash(1, 500))
    Private WithEvents kpnl_transition_loading_editing As Transition = New Transition(New TransitionType_EaseInEaseOut(200))
    Private WithEvents kpnl_transition_loading_color As Transition = New Transition(New TransitionType_EaseInEaseOut(500))


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
            If (Not NewThumb.Equals(Me._MusicFile.Thumbnail)) Then
                If (NewThumb Is Nothing) Then
                    Me._MusicFile.ClearThumbnail()
                Else
                    Me._MusicFile.Thumbnail = NewThumb
                End If
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

        Dim name As String = Me._MusicFile.MusicFileName.Substring(0, Me._MusicFile.MusicFileName.Length - My.Computer.FileSystem.GetFileInfo(Me._MusicFile.MusicFile).Extension.Length)
        name &= "_thumbnail.png"

        Me.sfd_export_thumbnail.FileName = name
        Me.sfd_export_thumbnail.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG)|*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG"
        Dim res As Windows.Forms.DialogResult = Me.sfd_export_thumbnail.ShowDialog()
        If res = Windows.Forms.DialogResult.OK Then
            Me._MusicFile.Thumbnail.Save(Me.sfd_export_thumbnail.FileName)
        End If
    End Sub

    Private Sub kbtn_editing_thumbnail_paste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kbtn_editing_thumbnail_paste.Click
        If (My.Computer.Clipboard.ContainsImage) Then
            Me.ChangeThumbnail(My.Computer.Clipboard.GetImage())
        ElseIf My.Computer.Clipboard.ContainsFileDropList Then
            Dim fileImage As Boolean = False

            For Each _File As String In My.Computer.Clipboard.GetFileDropList
                If (Me.ImageFormats.Contains(My.Computer.FileSystem.GetFileInfo(_File).Extension.ToLower())) Then
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
                If (Me.ImageFormats.Contains(My.Computer.FileSystem.GetFileInfo(_File).Extension.ToLower())) Then
                    Me.ChangeThumbnail(Image.FromFile(_File))
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
                If (Me.ImageFormats.Contains(My.Computer.FileSystem.GetFileInfo(_File).Extension.ToLower())) Then
                    Me.ChangeThumbnail(Image.FromFile(_File), False)
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


    Private Sub pcb_editing_thumbnail_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pcb_editing_thumbnail.MouseDown
        Me.t_moving = True
    End Sub

    Private Sub pcb_editing_thumbnail_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pcb_editing_thumbnail.MouseMove
        If (Me.t_moving) Then
            Dim name As String = Me._MusicFile.MusicFileName.Substring(0, Me._MusicFile.MusicFileName.Length - My.Computer.FileSystem.GetFileInfo(Me._MusicFile.MusicFile).Extension.Length)
            name &= "_thumbnail.png"

            Me.pcb_editing_thumbnail.Image.Save(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & name)

            Dim fileas As String() = New [String](0) {}
            fileas(0) = My.Computer.FileSystem.SpecialDirectories.Temp & "\" & name
            Dim dta = New DataObject(DataFormats.FileDrop, fileas)
            dta.SetData(DataFormats.StringFormat, fileas)
            dta.SetData(DataFormats.Bitmap, Me.pcb_editing_thumbnail.Image)
            kpnl_editing_thumbnail.DoDragDrop(dta, DragDropEffects.Copy)


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
            Me._MusicFile.Artists = Split(Me.tvktxt_artists.TextBoxValue1, ";")
        End If
    End Sub

    Private Sub tvktxt_comments_Text1Changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles tvktxt_comments.Text1Changed
        If Not Me.Loading Then
            Me._MusicFile.Legend = Me.tvktxt_comments.TextBoxValue1
        End If
    End Sub

    Private Sub tvktxt_genres_Text1Changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles tvktxt_genres.Text1Changed
        If Not Me.Loading Then
            Me._MusicFile.Genres = Split(Me.tvktxt_genres.TextBoxValue1, ";")
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
            Me.LoadMusicFileIntoGUI(paths.Music, paths.Image)
            Me.TransitionLoadingToEditingPanel()
        End If
    End Sub

#End Region

#Region "Runtime Loading Panel"
    Private Sub kpnl_transition_loading_error_TransitionCompletedEvent(ByVal sender As Object, ByVal e As Transitions.Transition.Args) Handles kpnl_transition_loading_error.TransitionCompletedEvent
        Me.terror_showing = False
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
                Me.music_path = paths.Music
                Me.image_path = paths.Image
                Me.LoadMusicFileIntoGUI(paths.Music, paths.Image)
            ElseIf (result = Windows.Forms.DialogResult.OK) Then
                Me.music_path = paths.Music
                Me.image_path = paths.Image
                Me.LoadMusicFileIntoGUI(paths.Music, paths.Image)
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

    Public Function CheckFileDrags(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) As DragFiles
        Dim paths As DragFiles = New DragFiles
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
                If (My.Computer.FileSystem.GetFileInfo(filePaths(i)).Extension.ToLower() = ".mp3" And music = False) Then
                    paths.Music = filePaths(i)
                    music = True
                ElseIf (Me.ImageFormats.Contains(My.Computer.FileSystem.GetFileInfo(filePaths(i)).Extension.ToLower()) And image = False) Then
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

    Private Sub frm_main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ImageFormats.Add(".jpg")
        Me.ImageFormats.Add(".jpeg")
        Me.ImageFormats.Add(".png")
        Me.ImageFormats.Add(".bmp")

        Me.kpnl_editing_music.Visible = False
        Me.kpnl_loading_music.Visible = True

        Me.kpnl_rloading_music.StateCommon.Color1 = Me.kpnl_editing_music.StateCommon.GetBackColor1(ComponentFactory.Krypton.Toolkit.PaletteState.Normal)

        Me.sfd_export_thumbnail.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyMusic
    End Sub

    Public Sub LoadMusicFileIntoGUI(ByVal music As String, Optional ByVal image As String = "")
        Me.Loading = True
        Me._MusicFile = New MusicFile(music, image)
        Me.kltt_editing_filename.Text = My.Computer.FileSystem.GetFileInfo(music).Name

        Me.tvktxt_title.TextBoxValue1 = Me._MusicFile.Title
        Me.tvktxt_title.RevertText = Me._MusicFile.Title

        Me.tvktxt_comments.TextBoxValue1 = Me._MusicFile.Legend
        Me.tvktxt_comments.RevertText = Me._MusicFile.Legend

        Me.tvktxt_artists.TextBoxValue1 = String.Join("; ", Me._MusicFile.Artists)
        Me.tvktxt_artists.RevertText = String.Join("; ", Me._MusicFile.Artists)

        Me.tvktxt_interpret.TextBoxValue1 = Me._MusicFile.AlbumArtist
        Me.tvktxt_interpret.RevertText = Me._MusicFile.AlbumArtist

        Me.tvktxt_album.TextBoxValue1 = Me._MusicFile.Album
        Me.tvktxt_album.RevertText = Me._MusicFile.Album

        Me.tvktxt_year.TextBoxValue1 = Me._MusicFile.Year
        Me.tvktxt_year.RevertText = Me._MusicFile.Year

        Me.tvktxt_number.TextBoxValue1 = Me._MusicFile.Number
        Me.tvktxt_number.RevertText = Me._MusicFile.Number

        Me.tvktxt_genres.TextBoxValue1 = String.Join("; ", Me._MusicFile.Genres)
        Me.tvktxt_genres.RevertText = String.Join("; ", Me._MusicFile.Genres)

        Me.tvktxt_lyrics.TextBoxValue1 = Me._MusicFile.Lyrics
        Me.tvktxt_lyrics.RevertText = Me._MusicFile.Lyrics

        If (image <> "" And (Not image Is Nothing)) Then
            Me._MusicFile.Thumbnail = Drawing.Image.FromFile(image)
            Me.ChangeThumbnail(Me._MusicFile.Thumbnail, True)
        Else
            Dim imageThumb As Image = Me._MusicFile.Thumbnail
            Me.ChangeThumbnail(imageThumb, False)
        End If

        Me.Loading = False
    End Sub

    Public Sub HideLoadingItems()
        Me.klbl_loading_music.Visible = False
        Me.klbl_loading_thumbnail.Visible = False
        Me.kwlbl_loading_music_name.Visible = False
        Me.kwlbl_loading_thumbnail_name.Visible = False
        Me.pcb_loading_music.Visible = False
        Me.pcb_loading_thumbnail.Visible = False
    End Sub

    Public Sub ShowLoadingPanel(ByVal music_path As String, Optional ByVal image_path As String = "")
        Me.HideLoadingItems()

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

    End Sub

    Private Sub kbtn_editing_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kbtn_editing_save.Click
        Me.pcb_editing_saving.Visible = True
        If (Me.kltt_editing_filename.Text = Me._MusicFile.MusicFileName) Then
            Me._MusicFile.Save()
        Else
            Me._MusicFile.MusicFileName = Me.kltt_editing_filename.Text
        End If

        Me.tvktxt_title.RevertText = Me._MusicFile.Title

        Me.tvktxt_comments.RevertText = Me._MusicFile.Legend

        Me.tvktxt_artists.RevertText = String.Join("; ", Me._MusicFile.Artists)

        Me.tvktxt_interpret.RevertText = Me._MusicFile.AlbumArtist

        Me.tvktxt_album.RevertText = Me._MusicFile.Album

        Me.tvktxt_year.RevertText = Me._MusicFile.Year

        Me.tvktxt_number.RevertText = Me._MusicFile.Number

        Me.tvktxt_genres.RevertText = String.Join("; ", Me._MusicFile.Genres)

        Me.tvktxt_lyrics.RevertText = Me._MusicFile.Lyrics

        Me.pcb_editing_saving.Visible = False
    End Sub
End Class
