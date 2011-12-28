Imports System.IO
Imports TagLib

Public Class MusicFile
    Public MusicPath As String
    Public NewMusicPath As String

    Public _Thumbnail As Image
    Public MusicTags As TagLib.File
    Private _Edited As Boolean = False

    Private tag As TagLib.Tag

    Private PopM As TagLib.Id3v2.PopularimeterFrame

    Private _rates As Dictionary(Of Integer, Integer) = New Dictionary(Of Integer, Integer)

    Public ReadOnly Property RateByte(ByVal Rate As Integer) As Integer
        Get
            If (Rate < 0) Then
                Rate = 0
            ElseIf (Rate > 5) Then
                Rate = 5
            End If
            Return Me._rates(Rate)
        End Get
    End Property

    Public ReadOnly Property RateStars(ByVal _Byte As Integer) As Integer
        Get
            If (_Byte <= 0) Then
                Return 0
            ElseIf (_Byte >= 1 And _Byte <= 63) Then
                Return 1
            ElseIf (_Byte >= 64 And _Byte <= 127) Then
                Return 2
            ElseIf (_Byte >= 128 And _Byte <= 191) Then
                Return 3
            ElseIf (_Byte >= 192 And _Byte <= 254) Then
                Return 4
            Else
                Return 5
            End If
        End Get
    End Property

    Public ReadOnly Property Edited As Boolean
        Get
            Return Me._Edited
        End Get
    End Property

    Public Property MusicFile As String
        Get
            Return Me.NewMusicPath
        End Get
        Set(ByVal value As String)
            If (value <> Me.NewMusicPath) Then
                If (My.Computer.FileSystem.FileExists(value)) Then
                    Throw New Exception(String.Format("O ficheiro com o nome {0} já existe.", value))
                Else
                    Me.NewMusicPath = value
                End If
            End If
        End Set
    End Property

    Public Property MusicFileName As String
        Get
            Return My.Computer.FileSystem.GetFileInfo(Me.NewMusicPath).Name
        End Get
        Set(ByVal value As String)
            If (value <> My.Computer.FileSystem.GetFileInfo(Me.NewMusicPath).Name) Then
                If (My.Computer.FileSystem.FileExists(My.Computer.FileSystem.GetFileInfo(Me.MusicPath).DirectoryName & "\" & value)) Then
                    Throw New Exception(String.Format("O ficheiro com o nome {0} já existe.", My.Computer.FileSystem.GetFileInfo(Me.MusicPath).DirectoryName & "\" & value))
                Else
                    Me.NewMusicPath = My.Computer.FileSystem.GetFileInfo(Me.MusicPath).DirectoryName & "\" & value
                End If
            End If
        End Set
    End Property

    Public Property Album As String
        Get
            Return Me.MusicTags.Tag.Album
        End Get
        Set(ByVal value As String)
            If (value <> Me.MusicTags.Tag.Album) Then
                Me._Edited = True
            End If
            Me.MusicTags.Tag.Album = value
        End Set
    End Property

    Public Property Title As String
        Get
            Return Me.MusicTags.Tag.Title
        End Get
        Set(ByVal value As String)
            If (value <> Me.MusicTags.Tag.Title) Then
                Me._Edited = True
            End If

            Me.MusicTags.Tag.Title = value
        End Set
    End Property

    Public Property Legend As String
        Get
            Return Me.MusicTags.Tag.Comment
        End Get
        Set(ByVal value As String)
            If (value <> Me.MusicTags.Tag.Comment) Then
                Me._Edited = True
            End If
            Me.MusicTags.Tag.Comment = value
        End Set
    End Property

    Public Property Lyrics As String
        Get
            Return Me.MusicTags.Tag.Lyrics
        End Get
        Set(ByVal value As String)
            If (value <> Me.MusicTags.Tag.Lyrics) Then
                Me._Edited = True
            End If
            Me.MusicTags.Tag.Lyrics = value
        End Set
    End Property

    Public Property Artists As Array
        Get
            Return Me.MusicTags.Tag.Performers
        End Get
        Set(ByVal value As Array)
            If (value IsNot Me.MusicTags.Tag.Performers) Then
                Me._Edited = True
            End If
            Me.MusicTags.Tag.Performers = value
        End Set
    End Property

    Public Property ArtistsString As String
        Get
            Return JoinKeywords(Me.Artists, "; ")
        End Get
        Set(ByVal value As String)
            Me.Artists = SplitKeywords(value, ";")
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

            If (temp IsNot Me.MusicTags.Tag.AlbumArtists) Then
                Me._Edited = True
            End If

            Me.MusicTags.Tag.AlbumArtists = temp
        End Set
    End Property

    Public Property Year As Integer
        Get
            Return Me.MusicTags.Tag.Year
        End Get
        Set(ByVal value As Integer)
            If (value <> Me.MusicTags.Tag.Year) Then
                Me._Edited = True
            End If
            Me.MusicTags.Tag.Year = value
        End Set
    End Property

    Public Property Number As Integer
        Get
            Return Me.MusicTags.Tag.Track
        End Get
        Set(ByVal value As Integer)
            If (value <> Me.MusicTags.Tag.Track) Then
                Me._Edited = True
            End If
            Me.MusicTags.Tag.Track = value
        End Set
    End Property

    Public Property Genres As Array
        Get
            Return Me.MusicTags.Tag.Genres
        End Get
        Set(ByVal value As Array)
            If (value IsNot Me.MusicTags.Tag.Genres) Then
                Me._Edited = True
            End If
            Me.MusicTags.Tag.Genres = value
        End Set
    End Property

    Public Property GenresString As String
        Get
            Return JoinKeywords(Me.Genres, "; ")
        End Get
        Set(ByVal value As String)
            Me.Genres = SplitKeywords(value, ";")
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

                If (Me.MusicTags.Tag.Pictures IsNot pictures) Then
                    Me._Edited = True
                End If

                Me.MusicTags.Tag.Pictures = pictures
                Me._Thumbnail = value
            Else
                If (Me.MusicTags.Tag.Pictures IsNot Nothing) Then
                    Me._Edited = True
                End If
                Me._Thumbnail = Nothing
                Me.MusicTags.Tag.Pictures = Nothing
            End If
        End Set
    End Property

    Public Property Rate As Integer
        Get
            Return Me.RateStars(Me.PopM.Rating)
        End Get
        Set(ByVal value As Integer)
            If (value < Me.RateStars(Me.PopM.Rating)) Then
                Me._Edited = True
            End If
            Me.PopM.Rating = Me.RateByte(value)
        End Set
    End Property

    Public Sub ClearThumbnail()
        Me._Edited = True
        Me._Thumbnail = Nothing
        Me.MusicTags.Tag.Pictures = Nothing
    End Sub

    Public Sub Save()
        Me.MusicTags.Save()
        If (NewMusicPath <> MusicPath) Then
            My.Computer.FileSystem.MoveFile(Me.MusicPath, NewMusicPath)
            Me.MusicTags = TagLib.File.Create(NewMusicPath)
            Me.MusicPath = NewMusicPath
        End If
        Me._Edited = False
    End Sub

    Public Sub New(ByVal music As String, Optional ByVal image As String = "")
        If (Not My.Computer.FileSystem.FileExists(music)) Then
            Throw New Exception("O ficheiro de música especificado não existe.")
        End If
        If (Not My.Computer.FileSystem.FileExists(image) And image <> "") Then
            Throw New Exception("O thumbnail especificado não existe.")
        End If

        Me.MusicPath = music
        Me.NewMusicPath = music

        Me.MusicTags = TagLib.File.Create(music)

        TagLib.Id3v2.Tag.DefaultVersion = 3
        TagLib.Id3v2.Tag.ForceDefaultVersion = True

        If (image <> "") Then
            Me.Thumbnail = Bitmap.FromFile(image)
        End If

        Me.tag = MusicTags.GetTag(TagLib.TagTypes.Id3v2)
        Me.PopM = TagLib.Id3v2.PopularimeterFrame.Get(tag, My.User.Name, True)

        Me._rates.Add(0, 0)
        Me._rates.Add(1, 62)
        Me._rates.Add(2, 65)
        Me._rates.Add(3, 129)
        Me._rates.Add(4, 193)
        Me._rates.Add(5, 255)
    End Sub
End Class
