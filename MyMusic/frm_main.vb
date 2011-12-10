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

    Private WithEvents kpnl_transition_loading_editing As Transition = New Transition(New TransitionType_EaseInEaseOut(200))

    Private Sub kpnl_loading_music_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles kpnl_loading_music.DragDrop
        Dim paths As DragFiles = Me.CheckFileDrags(sender, e)

        If (paths.InvalidDrag = False) Then
            Me.music_path = paths.Music
            Me.image_path = paths.Image
            Me.LoadMusicFileIntoGUI(paths.Music, paths.Image)
            Me.TransitionLoadingToEditingPanel()
        End If
    End Sub

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

    Public Function CheckFileDrags(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
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
                If (My.Computer.FileSystem.GetFileInfo(filePaths(i)).Extension = ".mp3" And music = False) Then
                    paths.Music = filePaths(i)
                    music = True
                ElseIf (Me.ImageFormats.Contains(My.Computer.FileSystem.GetFileInfo(filePaths(i)).Extension) And image = False) Then
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

    Private Sub kpnl_loading_music_DragLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles kpnl_loading_music.DragLeave
        HideLoadingItems()
    End Sub

    Private Sub frm_main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ImageFormats.Add(".jpg")
        Me.ImageFormats.Add(".jpeg")
        Me.ImageFormats.Add(".png")
        Me.ImageFormats.Add(".bmp")

        Me.kpnl_editing_music.Visible = False
        Me.kpnl_loading_music.Visible = True
    End Sub

    Private Sub kpnl_loading_music_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles kpnl_loading_music.DragEnter
        Dim paths As DragFiles = Me.CheckFileDrags(sender, e)
        If (paths.InvalidDrag = False) Then
            Me.ShowLoadingPanel(paths.Music, paths.Image)
        End If
    End Sub

    Public Sub LoadMusicFileIntoGUI(ByVal music As String, Optional ByVal image As String = "")
        Me._MusicFile = New MusicFile(music, image)
        Me.tvktxt_title.TextBoxValue1 = Me._MusicFile.Title
        Me.tvktxt_comments.TextBoxValue1 = Me._MusicFile.Legend
        Me.tvktxt_artists.TextBoxValue1 = String.Join("; ", Me._MusicFile.Artists)
        Me.tvktxt_interpret.TextBoxValue1 = Me._MusicFile.AlbumArtist
        Me.tvktxt_album.TextBoxValue1 = Me._MusicFile.Album
        Me.tvktxt_year.TextBoxValue1 = Me._MusicFile.Year
        Me.tvktxt_number.TextBoxValue1 = Me._MusicFile.Number
        Me.tvktxt_genres.TextBoxValue1 = String.Join("; ", Me._MusicFile.Genres)
        If (Not Me._MusicFile.Thumbnail Is Nothing) Then
            Me.pcb_editing_thumbnail.Image = Me._MusicFile.Thumbnail
        Else
            Me.pcb_editing_thumbnail.Image = My.Resources.MP3
        End If
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
    End Sub

    Private Sub TvKryptonTextBox2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
