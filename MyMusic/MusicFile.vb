Imports System.IO
Imports TagLib

Public Class MusicFile
    Public MusicPath As String
    Public _Thumbnail As Image
    Public MusicTags As TagLib.File

    Public Property MusicFile As String
        Get
            Return Me.MusicPath
        End Get
        Set(ByVal value As String)
            If (value <> Me.MusicPath) Then
                Me.MusicTags.Save()
                My.Computer.FileSystem.MoveFile(Me.MusicPath, value)
                Me.MusicTags = TagLib.File.Create(value)
                Me.MusicPath = value
            End If
        End Set
    End Property

    Public Property MusicFileName As String
        Get
            Return My.Computer.FileSystem.GetFileInfo(Me.MusicPath).Name
        End Get
        Set(ByVal value As String)
            If (value <> My.Computer.FileSystem.GetFileInfo(Me.MusicPath).Name) Then
                Me.MusicTags.Save()
                My.Computer.FileSystem.RenameFile(Me.MusicPath, value)
                Me.MusicTags = TagLib.File.Create(My.Computer.FileSystem.GetFileInfo(Me.MusicPath).Directory.FullName & "\" & value)
                Me.MusicPath = My.Computer.FileSystem.GetFileInfo(Me.MusicPath).Directory.FullName & "\" & value
            End If
        End Set
    End Property

    Public Property Album As String
        Get
            Return Me.MusicTags.Tag.Album
        End Get
        Set(ByVal value As String)
            Me.MusicTags.Tag.Album = value
        End Set
    End Property

    Public Property Title As String
        Get
            Return Me.MusicTags.Tag.Title
        End Get
        Set(ByVal value As String)
            Me.MusicTags.Tag.Title = value
        End Set
    End Property

    Public Property Legend As String
        Get
            Return Me.MusicTags.Tag.Comment
        End Get
        Set(ByVal value As String)
            Me.MusicTags.Tag.Comment = value
        End Set
    End Property

    Public Property Artists As Array
        Get
            Return Me.MusicTags.Tag.Performers
        End Get
        Set(ByVal value As Array)
            Me.MusicTags.Tag.Performers = value
        End Set
    End Property

    Public Property AlbumArtist As String
        Get
            If (Me.MusicTags.Tag.AlbumArtists.Length > 0) Then
                Return Me.MusicTags.Tag.AlbumArtists(0)
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As String)
            Dim temp(0) As String
            temp(0) = value
            Me.MusicTags.Tag.AlbumArtists = temp
        End Set
    End Property

    Public Property Year As Integer
        Get
            Return Me.MusicTags.Tag.Year
        End Get
        Set(ByVal value As Integer)
            Me.MusicTags.Tag.Year = value
        End Set
    End Property

    Public Property Number As Integer
        Get
            Return Me.MusicTags.Tag.Track
        End Get
        Set(ByVal value As Integer)
            Me.MusicTags.Tag.Track = value
        End Set
    End Property

    Public Property Genres As Array
        Get
            Return Me.MusicTags.Tag.Genres
        End Get
        Set(ByVal value As Array)
            Me.MusicTags.Tag.Genres = value
        End Set
    End Property

    Public Property Thumbnail As Image
        Get
            If (Me.MusicTags.Tag.Pictures.Length > 0) Then
                Dim bin = DirectCast(MusicTags.Tag.Pictures(0).Data.Data, Byte())
                Me._Thumbnail = Bitmap.FromStream(New MemoryStream(bin))
                Return Me._Thumbnail
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As Image)
            If (value IsNot Nothing) Then
                value.Save(My.Computer.FileSystem.SpecialDirectories.Temp & "\tempthumb_mymusic.png")

                Dim pictures(0) As Picture
                pictures(0) = New Picture(My.Computer.FileSystem.SpecialDirectories.Temp & "\tempthumb_mymusic.png")

                My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\tempthumb_mymusic.png")

                Me.MusicTags.Tag.Pictures = pictures
                Me._Thumbnail = value
            Else
                Me._Thumbnail = Nothing
                Me.MusicTags.Tag.Pictures = Nothing
            End If
        End Set
    End Property

    Public Property Rate As Integer
        Get
            'Me.MusicTags.Tag.
        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public Sub ClearThumbnail()
        Me._Thumbnail = Nothing
        Me.MusicTags.Tag.Pictures = Nothing
    End Sub

    Public Sub Save()
        Me.MusicTags.Save()
    End Sub

    Public Sub New(ByVal music As String, Optional ByVal image As String = "")
        If (Not My.Computer.FileSystem.FileExists(music)) Then
            Throw New Exception("O ficheiro de música especificado não existe.")
        End If
        If (Not My.Computer.FileSystem.FileExists(image) And image <> "") Then
            Throw New Exception("O thumbnail especificado não existe.")
        End If

        Me.MusicPath = music

        Me.MusicTags = TagLib.File.Create(music)

        If (image <> "") Then
            Me.Thumbnail = Bitmap.FromFile(image)
        End If
    End Sub
End Class
