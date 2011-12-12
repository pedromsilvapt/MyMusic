<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.kpnl_loading_music = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.klbl_loading_drag_files = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.kwlbl_loading_thumbnail_name = New ComponentFactory.Krypton.Toolkit.KryptonWrapLabel()
        Me.pcb_loading_thumbnail = New System.Windows.Forms.PictureBox()
        Me.kwlbl_loading_music_name = New ComponentFactory.Krypton.Toolkit.KryptonWrapLabel()
        Me.pcb_loading_music = New System.Windows.Forms.PictureBox()
        Me.klbl_loading_thumbnail = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.klbl_loading_music = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.kpnl_editing_music = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.pcb_editing_saving = New System.Windows.Forms.PictureBox()
        Me.kltt_editing_filename = New MyMusic.KLabelToTextBox()
        Me.kpnl_editing_thumbnail = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.pcb_editing_thumbnail = New System.Windows.Forms.PictureBox()
        Me.KryptonButton2 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.kbtn_editing_thumbnail_paste = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.kbtn_editing_thumbnail_export = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.kbtn_editing_thumbnail_clear = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.kbtn_editing_save = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.tvktxt_album = New MyMusic.TVKryptonTextBox()
        Me.tvktxt_genres = New MyMusic.TVKryptonTextBox()
        Me.tvktxt_number = New MyMusic.TVKryptonTextBox()
        Me.tvktxt_year = New MyMusic.TVKryptonTextBox()
        Me.tvktxt_interpret = New MyMusic.TVKryptonTextBox()
        Me.tvktxt_artists = New MyMusic.TVKryptonTextBox()
        Me.tvktxt_comments = New MyMusic.TVKryptonTextBox()
        Me.tvktxt_title = New MyMusic.TVKryptonTextBox()
        Me.klbl_classification = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.rc_classification = New Softclean.RatingControl()
        Me.sfd_export_thumbnail = New System.Windows.Forms.SaveFileDialog()
        CType(Me.kpnl_loading_music, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kpnl_loading_music.SuspendLayout()
        CType(Me.pcb_loading_thumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb_loading_music, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kpnl_editing_music, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kpnl_editing_music.SuspendLayout()
        CType(Me.pcb_editing_saving, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kpnl_editing_thumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kpnl_editing_thumbnail.SuspendLayout()
        CType(Me.pcb_editing_thumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'kpnl_loading_music
        '
        Me.kpnl_loading_music.AllowDrop = True
        Me.kpnl_loading_music.Controls.Add(Me.klbl_loading_drag_files)
        Me.kpnl_loading_music.Controls.Add(Me.kwlbl_loading_thumbnail_name)
        Me.kpnl_loading_music.Controls.Add(Me.pcb_loading_thumbnail)
        Me.kpnl_loading_music.Controls.Add(Me.kwlbl_loading_music_name)
        Me.kpnl_loading_music.Controls.Add(Me.pcb_loading_music)
        Me.kpnl_loading_music.Controls.Add(Me.klbl_loading_thumbnail)
        Me.kpnl_loading_music.Controls.Add(Me.klbl_loading_music)
        Me.kpnl_loading_music.Location = New System.Drawing.Point(-1, 0)
        Me.kpnl_loading_music.Name = "kpnl_loading_music"
        Me.kpnl_loading_music.Size = New System.Drawing.Size(763, 298)
        Me.kpnl_loading_music.TabIndex = 0
        '
        'klbl_loading_drag_files
        '
        Me.klbl_loading_drag_files.Location = New System.Drawing.Point(143, 122)
        Me.klbl_loading_drag_files.Name = "klbl_loading_drag_files"
        Me.klbl_loading_drag_files.Size = New System.Drawing.Size(488, 53)
        Me.klbl_loading_drag_files.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.klbl_loading_drag_files.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe WP", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.klbl_loading_drag_files.TabIndex = 7
        Me.klbl_loading_drag_files.Values.Text = "Arraste para aqui os ficheiros."
        '
        'kwlbl_loading_thumbnail_name
        '
        Me.kwlbl_loading_thumbnail_name.AutoSize = False
        Me.kwlbl_loading_thumbnail_name.Font = New System.Drawing.Font("Segoe WP", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kwlbl_loading_thumbnail_name.ForeColor = System.Drawing.Color.White
        Me.kwlbl_loading_thumbnail_name.Location = New System.Drawing.Point(416, 235)
        Me.kwlbl_loading_thumbnail_name.Name = "kwlbl_loading_thumbnail_name"
        Me.kwlbl_loading_thumbnail_name.Size = New System.Drawing.Size(155, 54)
        Me.kwlbl_loading_thumbnail_name.StateCommon.Font = New System.Drawing.Font("Segoe WP", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kwlbl_loading_thumbnail_name.StateCommon.TextColor = System.Drawing.Color.White
        Me.kwlbl_loading_thumbnail_name.Text = "Nome do Ficheiro.mp3"
        Me.kwlbl_loading_thumbnail_name.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.kwlbl_loading_thumbnail_name.Visible = False
        '
        'pcb_loading_thumbnail
        '
        Me.pcb_loading_thumbnail.BackColor = System.Drawing.Color.Transparent
        Me.pcb_loading_thumbnail.Image = Global.MyMusic.My.Resources.Resources.PNG
        Me.pcb_loading_thumbnail.Location = New System.Drawing.Point(416, 67)
        Me.pcb_loading_thumbnail.Name = "pcb_loading_thumbnail"
        Me.pcb_loading_thumbnail.Size = New System.Drawing.Size(149, 165)
        Me.pcb_loading_thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcb_loading_thumbnail.TabIndex = 5
        Me.pcb_loading_thumbnail.TabStop = False
        Me.pcb_loading_thumbnail.Visible = False
        '
        'kwlbl_loading_music_name
        '
        Me.kwlbl_loading_music_name.AutoSize = False
        Me.kwlbl_loading_music_name.Font = New System.Drawing.Font("Segoe WP", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kwlbl_loading_music_name.ForeColor = System.Drawing.Color.White
        Me.kwlbl_loading_music_name.Location = New System.Drawing.Point(209, 235)
        Me.kwlbl_loading_music_name.Name = "kwlbl_loading_music_name"
        Me.kwlbl_loading_music_name.Size = New System.Drawing.Size(155, 54)
        Me.kwlbl_loading_music_name.StateCommon.Font = New System.Drawing.Font("Segoe WP", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kwlbl_loading_music_name.StateCommon.TextColor = System.Drawing.Color.White
        Me.kwlbl_loading_music_name.Text = "Nome do Ficheiro.mp3"
        Me.kwlbl_loading_music_name.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.kwlbl_loading_music_name.Visible = False
        '
        'pcb_loading_music
        '
        Me.pcb_loading_music.BackColor = System.Drawing.Color.Transparent
        Me.pcb_loading_music.Image = Global.MyMusic.My.Resources.Resources.MP3
        Me.pcb_loading_music.Location = New System.Drawing.Point(209, 67)
        Me.pcb_loading_music.Name = "pcb_loading_music"
        Me.pcb_loading_music.Size = New System.Drawing.Size(149, 165)
        Me.pcb_loading_music.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcb_loading_music.TabIndex = 2
        Me.pcb_loading_music.TabStop = False
        Me.pcb_loading_music.Visible = False
        '
        'klbl_loading_thumbnail
        '
        Me.klbl_loading_thumbnail.Location = New System.Drawing.Point(395, 20)
        Me.klbl_loading_thumbnail.Name = "klbl_loading_thumbnail"
        Me.klbl_loading_thumbnail.Size = New System.Drawing.Size(186, 53)
        Me.klbl_loading_thumbnail.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.klbl_loading_thumbnail.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe WP", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.klbl_loading_thumbnail.TabIndex = 1
        Me.klbl_loading_thumbnail.Values.Text = "Thumbnail"
        Me.klbl_loading_thumbnail.Visible = False
        '
        'klbl_loading_music
        '
        Me.klbl_loading_music.Location = New System.Drawing.Point(219, 20)
        Me.klbl_loading_music.Name = "klbl_loading_music"
        Me.klbl_loading_music.Size = New System.Drawing.Size(130, 53)
        Me.klbl_loading_music.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.klbl_loading_music.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe WP", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.klbl_loading_music.TabIndex = 0
        Me.klbl_loading_music.Values.Text = "Música"
        Me.klbl_loading_music.Visible = False
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Black
        '
        'kpnl_editing_music
        '
        Me.kpnl_editing_music.Controls.Add(Me.pcb_editing_saving)
        Me.kpnl_editing_music.Controls.Add(Me.kltt_editing_filename)
        Me.kpnl_editing_music.Controls.Add(Me.kpnl_editing_thumbnail)
        Me.kpnl_editing_music.Controls.Add(Me.KryptonButton2)
        Me.kpnl_editing_music.Controls.Add(Me.kbtn_editing_thumbnail_paste)
        Me.kpnl_editing_music.Controls.Add(Me.kbtn_editing_thumbnail_export)
        Me.kpnl_editing_music.Controls.Add(Me.kbtn_editing_thumbnail_clear)
        Me.kpnl_editing_music.Controls.Add(Me.kbtn_editing_save)
        Me.kpnl_editing_music.Controls.Add(Me.tvktxt_album)
        Me.kpnl_editing_music.Controls.Add(Me.tvktxt_genres)
        Me.kpnl_editing_music.Controls.Add(Me.tvktxt_number)
        Me.kpnl_editing_music.Controls.Add(Me.tvktxt_year)
        Me.kpnl_editing_music.Controls.Add(Me.tvktxt_interpret)
        Me.kpnl_editing_music.Controls.Add(Me.tvktxt_artists)
        Me.kpnl_editing_music.Controls.Add(Me.tvktxt_comments)
        Me.kpnl_editing_music.Controls.Add(Me.tvktxt_title)
        Me.kpnl_editing_music.Controls.Add(Me.klbl_classification)
        Me.kpnl_editing_music.Controls.Add(Me.rc_classification)
        Me.kpnl_editing_music.Location = New System.Drawing.Point(0, 0)
        Me.kpnl_editing_music.Name = "kpnl_editing_music"
        Me.kpnl_editing_music.Size = New System.Drawing.Size(763, 298)
        Me.kpnl_editing_music.TabIndex = 7
        '
        'pcb_editing_saving
        '
        Me.pcb_editing_saving.BackColor = System.Drawing.Color.Transparent
        Me.pcb_editing_saving.Image = CType(resources.GetObject("pcb_editing_saving.Image"), System.Drawing.Image)
        Me.pcb_editing_saving.Location = New System.Drawing.Point(446, 268)
        Me.pcb_editing_saving.Name = "pcb_editing_saving"
        Me.pcb_editing_saving.Size = New System.Drawing.Size(16, 16)
        Me.pcb_editing_saving.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcb_editing_saving.TabIndex = 19
        Me.pcb_editing_saving.TabStop = False
        Me.pcb_editing_saving.Visible = False
        '
        'kltt_editing_filename
        '
        Me.kltt_editing_filename.BackColor = System.Drawing.Color.Transparent
        Me.kltt_editing_filename.Location = New System.Drawing.Point(44, 163)
        Me.kltt_editing_filename.Name = "kltt_editing_filename"
        Me.kltt_editing_filename.Size = New System.Drawing.Size(145, 33)
        Me.kltt_editing_filename.TabIndex = 18
        '
        'kpnl_editing_thumbnail
        '
        Me.kpnl_editing_thumbnail.AllowDrop = True
        Me.kpnl_editing_thumbnail.Controls.Add(Me.pcb_editing_thumbnail)
        Me.kpnl_editing_thumbnail.Location = New System.Drawing.Point(44, 12)
        Me.kpnl_editing_thumbnail.Name = "kpnl_editing_thumbnail"
        Me.kpnl_editing_thumbnail.Size = New System.Drawing.Size(145, 145)
        Me.kpnl_editing_thumbnail.TabIndex = 17
        '
        'pcb_editing_thumbnail
        '
        Me.pcb_editing_thumbnail.BackColor = System.Drawing.Color.Transparent
        Me.pcb_editing_thumbnail.Image = Global.MyMusic.My.Resources.Resources.MP3
        Me.pcb_editing_thumbnail.Location = New System.Drawing.Point(0, 0)
        Me.pcb_editing_thumbnail.Name = "pcb_editing_thumbnail"
        Me.pcb_editing_thumbnail.Size = New System.Drawing.Size(145, 145)
        Me.pcb_editing_thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcb_editing_thumbnail.TabIndex = 0
        Me.pcb_editing_thumbnail.TabStop = False
        '
        'KryptonButton2
        '
        Me.KryptonButton2.Location = New System.Drawing.Point(3, 122)
        Me.KryptonButton2.Name = "KryptonButton2"
        Me.KryptonButton2.Size = New System.Drawing.Size(35, 30)
        Me.KryptonButton2.TabIndex = 16
        Me.KryptonButton2.Values.Image = Global.MyMusic.My.Resources.Resources.magnifier
        Me.KryptonButton2.Values.Text = ""
        '
        'kbtn_editing_thumbnail_paste
        '
        Me.kbtn_editing_thumbnail_paste.Location = New System.Drawing.Point(3, 86)
        Me.kbtn_editing_thumbnail_paste.Name = "kbtn_editing_thumbnail_paste"
        Me.kbtn_editing_thumbnail_paste.Size = New System.Drawing.Size(35, 30)
        Me.kbtn_editing_thumbnail_paste.TabIndex = 15
        Me.kbtn_editing_thumbnail_paste.Values.Image = Global.MyMusic.My.Resources.Resources.paste_plain
        Me.kbtn_editing_thumbnail_paste.Values.Text = ""
        '
        'kbtn_editing_thumbnail_export
        '
        Me.kbtn_editing_thumbnail_export.Location = New System.Drawing.Point(2, 50)
        Me.kbtn_editing_thumbnail_export.Name = "kbtn_editing_thumbnail_export"
        Me.kbtn_editing_thumbnail_export.Size = New System.Drawing.Size(35, 30)
        Me.kbtn_editing_thumbnail_export.TabIndex = 14
        Me.kbtn_editing_thumbnail_export.Values.Image = Global.MyMusic.My.Resources.Resources.picture_go
        Me.kbtn_editing_thumbnail_export.Values.Text = ""
        '
        'kbtn_editing_thumbnail_clear
        '
        Me.kbtn_editing_thumbnail_clear.Location = New System.Drawing.Point(3, 14)
        Me.kbtn_editing_thumbnail_clear.Name = "kbtn_editing_thumbnail_clear"
        Me.kbtn_editing_thumbnail_clear.Size = New System.Drawing.Size(35, 30)
        Me.kbtn_editing_thumbnail_clear.TabIndex = 13
        Me.kbtn_editing_thumbnail_clear.Values.Image = Global.MyMusic.My.Resources.Resources.cross
        Me.kbtn_editing_thumbnail_clear.Values.Text = ""
        '
        'kbtn_editing_save
        '
        Me.kbtn_editing_save.Location = New System.Drawing.Point(369, 264)
        Me.kbtn_editing_save.Name = "kbtn_editing_save"
        Me.kbtn_editing_save.Size = New System.Drawing.Size(71, 25)
        Me.kbtn_editing_save.TabIndex = 12
        Me.kbtn_editing_save.Values.Image = Global.MyMusic.My.Resources.Resources.accept
        Me.kbtn_editing_save.Values.Text = "Aplicar"
        '
        'tvktxt_album
        '
        Me.tvktxt_album.AutoChangeToFirst = True
        Me.tvktxt_album.BackColor = System.Drawing.Color.Transparent
        Me.tvktxt_album.CheckBoxVisible = False
        Me.tvktxt_album.LabelColor = System.Drawing.Color.White
        Me.tvktxt_album.LabelText = "Álbum:"
        Me.tvktxt_album.Location = New System.Drawing.Point(203, 132)
        Me.tvktxt_album.Name = "tvktxt_album"
        Me.tvktxt_album.Size = New System.Drawing.Size(292, 22)
        Me.tvktxt_album.TabIndex = 11
        Me.tvktxt_album.TextBoxValue1 = ""
        Me.tvktxt_album.TextBoxValue2 = ""
        Me.tvktxt_album.TextBoxWidth = 150.0!
        Me.tvktxt_album.TextBoxX = 135.0!
        Me.tvktxt_album.ValueTwoEditable = False
        '
        'tvktxt_genres
        '
        Me.tvktxt_genres.AutoChangeToFirst = True
        Me.tvktxt_genres.BackColor = System.Drawing.Color.Transparent
        Me.tvktxt_genres.CheckBoxVisible = False
        Me.tvktxt_genres.LabelColor = System.Drawing.Color.White
        Me.tvktxt_genres.LabelText = "Géneros:"
        Me.tvktxt_genres.Location = New System.Drawing.Point(203, 216)
        Me.tvktxt_genres.Name = "tvktxt_genres"
        Me.tvktxt_genres.Size = New System.Drawing.Size(292, 22)
        Me.tvktxt_genres.TabIndex = 10
        Me.tvktxt_genres.TextBoxValue1 = ""
        Me.tvktxt_genres.TextBoxValue2 = ""
        Me.tvktxt_genres.TextBoxWidth = 150.0!
        Me.tvktxt_genres.TextBoxX = 135.0!
        Me.tvktxt_genres.ValueTwoEditable = False
        '
        'tvktxt_number
        '
        Me.tvktxt_number.AutoChangeToFirst = True
        Me.tvktxt_number.BackColor = System.Drawing.Color.Transparent
        Me.tvktxt_number.CheckBoxVisible = False
        Me.tvktxt_number.LabelColor = System.Drawing.Color.White
        Me.tvktxt_number.LabelText = "Número:"
        Me.tvktxt_number.Location = New System.Drawing.Point(203, 188)
        Me.tvktxt_number.Name = "tvktxt_number"
        Me.tvktxt_number.Size = New System.Drawing.Size(292, 22)
        Me.tvktxt_number.TabIndex = 9
        Me.tvktxt_number.TextBoxValue1 = ""
        Me.tvktxt_number.TextBoxValue2 = ""
        Me.tvktxt_number.TextBoxWidth = 150.0!
        Me.tvktxt_number.TextBoxX = 135.0!
        Me.tvktxt_number.ValueTwoEditable = False
        '
        'tvktxt_year
        '
        Me.tvktxt_year.AutoChangeToFirst = True
        Me.tvktxt_year.BackColor = System.Drawing.Color.Transparent
        Me.tvktxt_year.CheckBoxVisible = False
        Me.tvktxt_year.LabelColor = System.Drawing.Color.White
        Me.tvktxt_year.LabelText = "Ano:"
        Me.tvktxt_year.Location = New System.Drawing.Point(203, 160)
        Me.tvktxt_year.Name = "tvktxt_year"
        Me.tvktxt_year.Size = New System.Drawing.Size(292, 22)
        Me.tvktxt_year.TabIndex = 8
        Me.tvktxt_year.TextBoxValue1 = ""
        Me.tvktxt_year.TextBoxValue2 = ""
        Me.tvktxt_year.TextBoxWidth = 150.0!
        Me.tvktxt_year.TextBoxX = 135.0!
        Me.tvktxt_year.ValueTwoEditable = False
        '
        'tvktxt_interpret
        '
        Me.tvktxt_interpret.AutoChangeToFirst = True
        Me.tvktxt_interpret.BackColor = System.Drawing.Color.Transparent
        Me.tvktxt_interpret.CheckBoxVisible = False
        Me.tvktxt_interpret.LabelColor = System.Drawing.Color.White
        Me.tvktxt_interpret.LabelText = "Intérprete do Álbum:"
        Me.tvktxt_interpret.Location = New System.Drawing.Point(203, 104)
        Me.tvktxt_interpret.Name = "tvktxt_interpret"
        Me.tvktxt_interpret.Size = New System.Drawing.Size(292, 22)
        Me.tvktxt_interpret.TabIndex = 7
        Me.tvktxt_interpret.TextBoxValue1 = ""
        Me.tvktxt_interpret.TextBoxValue2 = ""
        Me.tvktxt_interpret.TextBoxWidth = 150.0!
        Me.tvktxt_interpret.TextBoxX = 135.0!
        Me.tvktxt_interpret.ValueTwoEditable = False
        '
        'tvktxt_artists
        '
        Me.tvktxt_artists.AutoChangeToFirst = True
        Me.tvktxt_artists.BackColor = System.Drawing.Color.Transparent
        Me.tvktxt_artists.CheckBoxVisible = False
        Me.tvktxt_artists.LabelColor = System.Drawing.Color.White
        Me.tvktxt_artists.LabelText = "Artistas: "
        Me.tvktxt_artists.Location = New System.Drawing.Point(203, 76)
        Me.tvktxt_artists.Name = "tvktxt_artists"
        Me.tvktxt_artists.Size = New System.Drawing.Size(292, 22)
        Me.tvktxt_artists.TabIndex = 6
        Me.tvktxt_artists.TextBoxValue1 = ""
        Me.tvktxt_artists.TextBoxValue2 = ""
        Me.tvktxt_artists.TextBoxWidth = 150.0!
        Me.tvktxt_artists.TextBoxX = 135.0!
        Me.tvktxt_artists.ValueTwoEditable = False
        '
        'tvktxt_comments
        '
        Me.tvktxt_comments.AutoChangeToFirst = True
        Me.tvktxt_comments.BackColor = System.Drawing.Color.Transparent
        Me.tvktxt_comments.CheckBoxVisible = False
        Me.tvktxt_comments.LabelColor = System.Drawing.Color.White
        Me.tvktxt_comments.LabelText = "Comentários:"
        Me.tvktxt_comments.Location = New System.Drawing.Point(203, 48)
        Me.tvktxt_comments.Name = "tvktxt_comments"
        Me.tvktxt_comments.Size = New System.Drawing.Size(292, 22)
        Me.tvktxt_comments.TabIndex = 5
        Me.tvktxt_comments.TextBoxValue1 = ""
        Me.tvktxt_comments.TextBoxValue2 = ""
        Me.tvktxt_comments.TextBoxWidth = 150.0!
        Me.tvktxt_comments.TextBoxX = 135.0!
        Me.tvktxt_comments.ValueTwoEditable = False
        '
        'tvktxt_title
        '
        Me.tvktxt_title.AutoChangeToFirst = True
        Me.tvktxt_title.BackColor = System.Drawing.Color.Transparent
        Me.tvktxt_title.CheckBoxVisible = False
        Me.tvktxt_title.LabelColor = System.Drawing.Color.White
        Me.tvktxt_title.LabelText = "Título:"
        Me.tvktxt_title.Location = New System.Drawing.Point(203, 20)
        Me.tvktxt_title.Name = "tvktxt_title"
        Me.tvktxt_title.Size = New System.Drawing.Size(292, 22)
        Me.tvktxt_title.TabIndex = 3
        Me.tvktxt_title.TextBoxValue1 = ""
        Me.tvktxt_title.TextBoxValue2 = ""
        Me.tvktxt_title.TextBoxWidth = 150.0!
        Me.tvktxt_title.TextBoxX = 135.0!
        Me.tvktxt_title.ValueTwoEditable = False
        '
        'klbl_classification
        '
        Me.klbl_classification.Location = New System.Drawing.Point(79, 202)
        Me.klbl_classification.Name = "klbl_classification"
        Me.klbl_classification.Size = New System.Drawing.Size(82, 20)
        Me.klbl_classification.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.klbl_classification.TabIndex = 2
        Me.klbl_classification.Values.Text = "Classificação:"
        '
        'rc_classification
        '
        Me.rc_classification.BackColor = System.Drawing.Color.Transparent
        Me.rc_classification.Location = New System.Drawing.Point(68, 227)
        Me.rc_classification.Name = "rc_classification"
        Me.rc_classification.Size = New System.Drawing.Size(111, 24)
        Me.rc_classification.TabIndex = 1
        '
        'sfd_export_thumbnail
        '
        Me.sfd_export_thumbnail.Title = "Exportar Thumbnail"
        '
        'frm_main
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 298)
        Me.Controls.Add(Me.kpnl_editing_music)
        Me.Controls.Add(Me.kpnl_loading_music)
        Me.MaximizeBox = False
        Me.Name = "frm_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyMusic"
        CType(Me.kpnl_loading_music, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kpnl_loading_music.ResumeLayout(False)
        Me.kpnl_loading_music.PerformLayout()
        CType(Me.pcb_loading_thumbnail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcb_loading_music, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kpnl_editing_music, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kpnl_editing_music.ResumeLayout(False)
        Me.kpnl_editing_music.PerformLayout()
        CType(Me.pcb_editing_saving, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kpnl_editing_thumbnail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kpnl_editing_thumbnail.ResumeLayout(False)
        CType(Me.pcb_editing_thumbnail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents kpnl_loading_music As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents pcb_loading_music As System.Windows.Forms.PictureBox
    Friend WithEvents klbl_loading_thumbnail As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klbl_loading_music As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kwlbl_loading_thumbnail_name As ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
    Friend WithEvents pcb_loading_thumbnail As System.Windows.Forms.PictureBox
    Friend WithEvents kwlbl_loading_music_name As ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
    Friend WithEvents kpnl_editing_music As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents klbl_classification As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents rc_classification As Softclean.RatingControl
    Friend WithEvents pcb_editing_thumbnail As System.Windows.Forms.PictureBox
    Friend WithEvents tvktxt_title As MyMusic.TVKryptonTextBox
    Friend WithEvents tvktxt_genres As MyMusic.TVKryptonTextBox
    Friend WithEvents tvktxt_number As MyMusic.TVKryptonTextBox
    Friend WithEvents tvktxt_year As MyMusic.TVKryptonTextBox
    Friend WithEvents tvktxt_interpret As MyMusic.TVKryptonTextBox
    Friend WithEvents tvktxt_artists As MyMusic.TVKryptonTextBox
    Friend WithEvents tvktxt_comments As MyMusic.TVKryptonTextBox
    Friend WithEvents tvktxt_album As MyMusic.TVKryptonTextBox
    Friend WithEvents kbtn_editing_save As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents kbtn_editing_thumbnail_clear As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents kbtn_editing_thumbnail_export As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents kbtn_editing_thumbnail_paste As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton2 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents sfd_export_thumbnail As System.Windows.Forms.SaveFileDialog
    Friend WithEvents kpnl_editing_thumbnail As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents kltt_editing_filename As MyMusic.KLabelToTextBox
    Friend WithEvents klbl_loading_drag_files As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents pcb_editing_saving As System.Windows.Forms.PictureBox
End Class
