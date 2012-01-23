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
        Me.kbtn_loading_info = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.klbl_loading_drag_files = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.kwlbl_loading_thumbnail_name = New ComponentFactory.Krypton.Toolkit.KryptonWrapLabel()
        Me.pcb_loading_thumbnail = New System.Windows.Forms.PictureBox()
        Me.kwlbl_loading_music_name = New ComponentFactory.Krypton.Toolkit.KryptonWrapLabel()
        Me.pcb_loading_music = New System.Windows.Forms.PictureBox()
        Me.klbl_loading_thumbnail = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.klbl_loading_music = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.kpnl_editing_music = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.kbtn_close_music = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.kbtn_info = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.kpnl_rloading_music = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.kwlbl_rloading_thumbnail_name = New ComponentFactory.Krypton.Toolkit.KryptonWrapLabel()
        Me.pcb_rloading_thumbnail = New System.Windows.Forms.PictureBox()
        Me.kwlbl_rloading_music_name = New ComponentFactory.Krypton.Toolkit.KryptonWrapLabel()
        Me.pcb_rloading_music = New System.Windows.Forms.PictureBox()
        Me.klbl_rloading_thumbnail = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.klbl_rloading_music = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.kbtn_clear_rating = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.pcb_editing_saving = New System.Windows.Forms.PictureBox()
        Me.kpnl_editing_thumbnail = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.pcb_editing_thumbnail = New System.Windows.Forms.PictureBox()
        Me.kbtn_thumbnail_open = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.kbtn_editing_thumbnail_paste = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.kbtn_editing_thumbnail_export = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.kbtn_editing_thumbnail_clear = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.kbtn_editing_save = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.klbl_classification = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.rc_classification = New Softclean.RatingControl()
        Me.sfd_export_thumbnail = New System.Windows.Forms.SaveFileDialog()
        Me.ktdlg_open_music = New ComponentFactory.Krypton.Toolkit.KryptonTaskDialog()
        Me.ktdlgc_save_open = New ComponentFactory.Krypton.Toolkit.KryptonTaskDialogCommand()
        Me.ktdlgc_close_open = New ComponentFactory.Krypton.Toolkit.KryptonTaskDialogCommand()
        Me.ktdlgc_cancel = New ComponentFactory.Krypton.Toolkit.KryptonTaskDialogCommand()
        Me.ktdlg_close_window = New ComponentFactory.Krypton.Toolkit.KryptonTaskDialog()
        Me.ktdlgc_save_close = New ComponentFactory.Krypton.Toolkit.KryptonTaskDialogCommand()
        Me.ktdlgc_close = New ComponentFactory.Krypton.Toolkit.KryptonTaskDialogCommand()
        Me.ktdlgc_close_cancel = New ComponentFactory.Krypton.Toolkit.KryptonTaskDialogCommand()
        Me.kcmd_thumbnail = New ComponentFactory.Krypton.Toolkit.KryptonContextMenu()
        Me.KryptonContextMenuItems1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems()
        Me.KryptonContextMenuItem1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem()
        Me.KryptonContextMenuItem2 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem()
        Me.ofd_thumbnail = New System.Windows.Forms.OpenFileDialog()
        Me.tt_thumbnail_clear = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_history_backward = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.btn_history_forwards = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.tvktxt_lyrics = New MyMusic.TVKryptonMultiline()
        Me.kltt_editing_filename = New MyMusic.KLabelToTextBox()
        Me.tvktxt_album = New MyMusic.TVKryptonTextBox()
        Me.tvktxt_genres = New MyMusic.TVKryptonTextBox()
        Me.tvktxt_number = New MyMusic.TVKryptonTextBox()
        Me.tvktxt_year = New MyMusic.TVKryptonTextBox()
        Me.tvktxt_interpret = New MyMusic.TVKryptonTextBox()
        Me.tvktxt_artists = New MyMusic.TVKryptonTextBox()
        Me.tvktxt_comments = New MyMusic.TVKryptonTextBox()
        Me.tvktxt_title = New MyMusic.TVKryptonTextBox()
        CType(Me.kpnl_loading_music, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kpnl_loading_music.SuspendLayout()
        CType(Me.pcb_loading_thumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb_loading_music, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kpnl_editing_music, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kpnl_editing_music.SuspendLayout()
        CType(Me.kpnl_rloading_music, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kpnl_rloading_music.SuspendLayout()
        CType(Me.pcb_rloading_thumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb_rloading_music, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb_editing_saving, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kpnl_editing_thumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kpnl_editing_thumbnail.SuspendLayout()
        CType(Me.pcb_editing_thumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'kpnl_loading_music
        '
        Me.kpnl_loading_music.AllowDrop = True
        Me.kpnl_loading_music.Controls.Add(Me.kbtn_loading_info)
        Me.kpnl_loading_music.Controls.Add(Me.klbl_loading_drag_files)
        Me.kpnl_loading_music.Controls.Add(Me.kwlbl_loading_thumbnail_name)
        Me.kpnl_loading_music.Controls.Add(Me.pcb_loading_thumbnail)
        Me.kpnl_loading_music.Controls.Add(Me.kwlbl_loading_music_name)
        Me.kpnl_loading_music.Controls.Add(Me.pcb_loading_music)
        Me.kpnl_loading_music.Controls.Add(Me.klbl_loading_thumbnail)
        Me.kpnl_loading_music.Controls.Add(Me.klbl_loading_music)
        Me.kpnl_loading_music.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kpnl_loading_music.Location = New System.Drawing.Point(0, 0)
        Me.kpnl_loading_music.Name = "kpnl_loading_music"
        Me.kpnl_loading_music.Size = New System.Drawing.Size(821, 298)
        Me.kpnl_loading_music.TabIndex = 0
        '
        'kbtn_loading_info
        '
        Me.kbtn_loading_info.Location = New System.Drawing.Point(774, 259)
        Me.kbtn_loading_info.Name = "kbtn_loading_info"
        Me.kbtn_loading_info.Size = New System.Drawing.Size(35, 30)
        Me.kbtn_loading_info.TabIndex = 24
        Me.kbtn_loading_info.Values.Image = Global.MyMusic.My.Resources.Resources.information
        Me.kbtn_loading_info.Values.Text = ""
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
        Me.kpnl_editing_music.Controls.Add(Me.kbtn_close_music)
        Me.kpnl_editing_music.Controls.Add(Me.kbtn_info)
        Me.kpnl_editing_music.Controls.Add(Me.kpnl_rloading_music)
        Me.kpnl_editing_music.Controls.Add(Me.kbtn_clear_rating)
        Me.kpnl_editing_music.Controls.Add(Me.tvktxt_lyrics)
        Me.kpnl_editing_music.Controls.Add(Me.pcb_editing_saving)
        Me.kpnl_editing_music.Controls.Add(Me.kltt_editing_filename)
        Me.kpnl_editing_music.Controls.Add(Me.kpnl_editing_thumbnail)
        Me.kpnl_editing_music.Controls.Add(Me.kbtn_thumbnail_open)
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
        Me.kpnl_editing_music.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kpnl_editing_music.Location = New System.Drawing.Point(0, 0)
        Me.kpnl_editing_music.Name = "kpnl_editing_music"
        Me.kpnl_editing_music.Size = New System.Drawing.Size(821, 298)
        Me.kpnl_editing_music.TabIndex = 7
        '
        'kbtn_close_music
        '
        Me.kbtn_close_music.Location = New System.Drawing.Point(783, 3)
        Me.kbtn_close_music.Name = "kbtn_close_music"
        Me.kbtn_close_music.Size = New System.Drawing.Size(35, 30)
        Me.kbtn_close_music.TabIndex = 22
        Me.tt_thumbnail_clear.SetToolTip(Me.kbtn_close_music, "Fechar Música")
        Me.kbtn_close_music.Values.Image = Global.MyMusic.My.Resources.Resources.cross
        Me.kbtn_close_music.Values.Text = ""
        '
        'kbtn_info
        '
        Me.kbtn_info.Location = New System.Drawing.Point(774, 259)
        Me.kbtn_info.Name = "kbtn_info"
        Me.kbtn_info.Size = New System.Drawing.Size(35, 30)
        Me.kbtn_info.TabIndex = 17
        Me.kbtn_info.Values.Image = Global.MyMusic.My.Resources.Resources.information
        Me.kbtn_info.Values.Text = ""
        '
        'kpnl_rloading_music
        '
        Me.kpnl_rloading_music.AllowDrop = True
        Me.kpnl_rloading_music.Controls.Add(Me.kwlbl_rloading_thumbnail_name)
        Me.kpnl_rloading_music.Controls.Add(Me.pcb_rloading_thumbnail)
        Me.kpnl_rloading_music.Controls.Add(Me.kwlbl_rloading_music_name)
        Me.kpnl_rloading_music.Controls.Add(Me.pcb_rloading_music)
        Me.kpnl_rloading_music.Controls.Add(Me.klbl_rloading_thumbnail)
        Me.kpnl_rloading_music.Controls.Add(Me.klbl_rloading_music)
        Me.kpnl_rloading_music.Cursor = System.Windows.Forms.Cursors.Hand
        Me.kpnl_rloading_music.Location = New System.Drawing.Point(727, 48)
        Me.kpnl_rloading_music.Name = "kpnl_rloading_music"
        Me.kpnl_rloading_music.Size = New System.Drawing.Size(94, 174)
        Me.kpnl_rloading_music.StateCommon.Image = Global.MyMusic.My.Resources.Resources.application_get
        Me.kpnl_rloading_music.StateCommon.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control
        Me.kpnl_rloading_music.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.kpnl_rloading_music.TabIndex = 21
        '
        'kwlbl_rloading_thumbnail_name
        '
        Me.kwlbl_rloading_thumbnail_name.AutoSize = False
        Me.kwlbl_rloading_thumbnail_name.Font = New System.Drawing.Font("Segoe WP", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kwlbl_rloading_thumbnail_name.ForeColor = System.Drawing.Color.White
        Me.kwlbl_rloading_thumbnail_name.Location = New System.Drawing.Point(425, 198)
        Me.kwlbl_rloading_thumbnail_name.Name = "kwlbl_rloading_thumbnail_name"
        Me.kwlbl_rloading_thumbnail_name.Size = New System.Drawing.Size(155, 54)
        Me.kwlbl_rloading_thumbnail_name.StateCommon.Font = New System.Drawing.Font("Segoe WP", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kwlbl_rloading_thumbnail_name.StateCommon.TextColor = System.Drawing.Color.White
        Me.kwlbl_rloading_thumbnail_name.Text = "Nome do Ficheiro.mp3"
        Me.kwlbl_rloading_thumbnail_name.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.kwlbl_rloading_thumbnail_name.Visible = False
        '
        'pcb_rloading_thumbnail
        '
        Me.pcb_rloading_thumbnail.BackColor = System.Drawing.Color.Transparent
        Me.pcb_rloading_thumbnail.Image = Global.MyMusic.My.Resources.Resources.PNG
        Me.pcb_rloading_thumbnail.Location = New System.Drawing.Point(425, 30)
        Me.pcb_rloading_thumbnail.Name = "pcb_rloading_thumbnail"
        Me.pcb_rloading_thumbnail.Size = New System.Drawing.Size(149, 165)
        Me.pcb_rloading_thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcb_rloading_thumbnail.TabIndex = 11
        Me.pcb_rloading_thumbnail.TabStop = False
        Me.pcb_rloading_thumbnail.Visible = False
        '
        'kwlbl_rloading_music_name
        '
        Me.kwlbl_rloading_music_name.AutoSize = False
        Me.kwlbl_rloading_music_name.Font = New System.Drawing.Font("Segoe WP", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kwlbl_rloading_music_name.ForeColor = System.Drawing.Color.White
        Me.kwlbl_rloading_music_name.Location = New System.Drawing.Point(218, 198)
        Me.kwlbl_rloading_music_name.Name = "kwlbl_rloading_music_name"
        Me.kwlbl_rloading_music_name.Size = New System.Drawing.Size(155, 54)
        Me.kwlbl_rloading_music_name.StateCommon.Font = New System.Drawing.Font("Segoe WP", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kwlbl_rloading_music_name.StateCommon.TextColor = System.Drawing.Color.White
        Me.kwlbl_rloading_music_name.Text = "Nome do Ficheiro.mp3"
        Me.kwlbl_rloading_music_name.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.kwlbl_rloading_music_name.Visible = False
        '
        'pcb_rloading_music
        '
        Me.pcb_rloading_music.BackColor = System.Drawing.Color.Transparent
        Me.pcb_rloading_music.Image = Global.MyMusic.My.Resources.Resources.MP3
        Me.pcb_rloading_music.Location = New System.Drawing.Point(218, 30)
        Me.pcb_rloading_music.Name = "pcb_rloading_music"
        Me.pcb_rloading_music.Size = New System.Drawing.Size(149, 165)
        Me.pcb_rloading_music.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcb_rloading_music.TabIndex = 10
        Me.pcb_rloading_music.TabStop = False
        Me.pcb_rloading_music.Visible = False
        '
        'klbl_rloading_thumbnail
        '
        Me.klbl_rloading_thumbnail.Location = New System.Drawing.Point(404, -17)
        Me.klbl_rloading_thumbnail.Name = "klbl_rloading_thumbnail"
        Me.klbl_rloading_thumbnail.Size = New System.Drawing.Size(186, 53)
        Me.klbl_rloading_thumbnail.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.klbl_rloading_thumbnail.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe WP", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.klbl_rloading_thumbnail.TabIndex = 9
        Me.klbl_rloading_thumbnail.Values.Text = "Thumbnail"
        Me.klbl_rloading_thumbnail.Visible = False
        '
        'klbl_rloading_music
        '
        Me.klbl_rloading_music.Location = New System.Drawing.Point(228, -17)
        Me.klbl_rloading_music.Name = "klbl_rloading_music"
        Me.klbl_rloading_music.Size = New System.Drawing.Size(130, 53)
        Me.klbl_rloading_music.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.klbl_rloading_music.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe WP", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.klbl_rloading_music.TabIndex = 7
        Me.klbl_rloading_music.Values.Text = "Música"
        Me.klbl_rloading_music.Visible = False
        '
        'kbtn_clear_rating
        '
        Me.kbtn_clear_rating.Location = New System.Drawing.Point(47, 227)
        Me.kbtn_clear_rating.Name = "kbtn_clear_rating"
        Me.kbtn_clear_rating.Size = New System.Drawing.Size(22, 22)
        Me.kbtn_clear_rating.TabIndex = 10
        Me.tt_thumbnail_clear.SetToolTip(Me.kbtn_clear_rating, "Apagar Classificação")
        Me.kbtn_clear_rating.Values.Image = Global.MyMusic.My.Resources.Resources.cross
        Me.kbtn_clear_rating.Values.Text = ""
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
        'kbtn_thumbnail_open
        '
        Me.kbtn_thumbnail_open.Location = New System.Drawing.Point(3, 122)
        Me.kbtn_thumbnail_open.Name = "kbtn_thumbnail_open"
        Me.kbtn_thumbnail_open.Size = New System.Drawing.Size(35, 30)
        Me.kbtn_thumbnail_open.TabIndex = 15
        Me.tt_thumbnail_clear.SetToolTip(Me.kbtn_thumbnail_open, "Procurar Thumbnail")
        Me.kbtn_thumbnail_open.Values.Image = Global.MyMusic.My.Resources.Resources.magnifier
        Me.kbtn_thumbnail_open.Values.Text = ""
        '
        'kbtn_editing_thumbnail_paste
        '
        Me.kbtn_editing_thumbnail_paste.Location = New System.Drawing.Point(3, 86)
        Me.kbtn_editing_thumbnail_paste.Name = "kbtn_editing_thumbnail_paste"
        Me.kbtn_editing_thumbnail_paste.Size = New System.Drawing.Size(35, 30)
        Me.kbtn_editing_thumbnail_paste.TabIndex = 14
        Me.tt_thumbnail_clear.SetToolTip(Me.kbtn_editing_thumbnail_paste, "Colar Thumbnail")
        Me.kbtn_editing_thumbnail_paste.Values.Image = Global.MyMusic.My.Resources.Resources.paste_plain
        Me.kbtn_editing_thumbnail_paste.Values.Text = ""
        '
        'kbtn_editing_thumbnail_export
        '
        Me.kbtn_editing_thumbnail_export.Location = New System.Drawing.Point(2, 50)
        Me.kbtn_editing_thumbnail_export.Name = "kbtn_editing_thumbnail_export"
        Me.kbtn_editing_thumbnail_export.Size = New System.Drawing.Size(35, 30)
        Me.kbtn_editing_thumbnail_export.TabIndex = 13
        Me.tt_thumbnail_clear.SetToolTip(Me.kbtn_editing_thumbnail_export, "Exportar Thumbnail")
        Me.kbtn_editing_thumbnail_export.Values.Image = Global.MyMusic.My.Resources.Resources.picture_go
        Me.kbtn_editing_thumbnail_export.Values.Text = ""
        '
        'kbtn_editing_thumbnail_clear
        '
        Me.kbtn_editing_thumbnail_clear.Location = New System.Drawing.Point(3, 14)
        Me.kbtn_editing_thumbnail_clear.Name = "kbtn_editing_thumbnail_clear"
        Me.kbtn_editing_thumbnail_clear.Size = New System.Drawing.Size(35, 30)
        Me.kbtn_editing_thumbnail_clear.TabIndex = 12
        Me.tt_thumbnail_clear.SetToolTip(Me.kbtn_editing_thumbnail_clear, "Apagar Thumbnail")
        Me.kbtn_editing_thumbnail_clear.Values.Image = Global.MyMusic.My.Resources.Resources.cross
        Me.kbtn_editing_thumbnail_clear.Values.Text = ""
        '
        'kbtn_editing_save
        '
        Me.kbtn_editing_save.Location = New System.Drawing.Point(361, 264)
        Me.kbtn_editing_save.Name = "kbtn_editing_save"
        Me.kbtn_editing_save.Size = New System.Drawing.Size(79, 25)
        Me.kbtn_editing_save.TabIndex = 16
        Me.kbtn_editing_save.Values.Image = Global.MyMusic.My.Resources.Resources.accept
        Me.kbtn_editing_save.Values.Text = "Aplicar"
        '
        'klbl_classification
        '
        Me.klbl_classification.Location = New System.Drawing.Point(73, 202)
        Me.klbl_classification.Name = "klbl_classification"
        Me.klbl_classification.Size = New System.Drawing.Size(82, 20)
        Me.klbl_classification.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.klbl_classification.TabIndex = 2
        Me.klbl_classification.Values.Text = "Classificação:"
        '
        'rc_classification
        '
        Me.rc_classification.BackColor = System.Drawing.Color.Transparent
        Me.rc_classification.Location = New System.Drawing.Point(71, 227)
        Me.rc_classification.Name = "rc_classification"
        Me.rc_classification.Size = New System.Drawing.Size(111, 24)
        Me.rc_classification.TabIndex = 11
        '
        'sfd_export_thumbnail
        '
        Me.sfd_export_thumbnail.Title = "Exportar Thumbnail"
        '
        'ktdlg_open_music
        '
        Me.ktdlg_open_music.CheckboxText = Nothing
        Me.ktdlg_open_music.CommandButtons.AddRange(New ComponentFactory.Krypton.Toolkit.KryptonTaskDialogCommand() {Me.ktdlgc_save_open, Me.ktdlgc_close_open, Me.ktdlgc_cancel})
        Me.ktdlg_open_music.CommonButtons = ComponentFactory.Krypton.Toolkit.TaskDialogButtons.None
        Me.ktdlg_open_music.Content = Nothing
        Me.ktdlg_open_music.DefaultRadioButton = Nothing
        Me.ktdlg_open_music.FooterHyperlink = Nothing
        Me.ktdlg_open_music.FooterText = Nothing
        Me.ktdlg_open_music.Icon = System.Windows.Forms.MessageBoxIcon.Question
        Me.ktdlg_open_music.MainInstruction = "Está prestes a abrir uma nova música, mas não guardou a anterior. Que pretende fa" & _
            "zer?"
        Me.ktdlg_open_music.Tag = Nothing
        Me.ktdlg_open_music.WindowTitle = "Abrir Música"
        '
        'ktdlgc_save_open
        '
        Me.ktdlgc_save_open.DialogResult = System.Windows.Forms.DialogResult.Retry
        Me.ktdlgc_save_open.ExtraText = "Guarda as alterações à música actual e abre a nova."
        Me.ktdlgc_save_open.Image = Nothing
        Me.ktdlgc_save_open.Text = "Guardar E Abrir"
        '
        'ktdlgc_close_open
        '
        Me.ktdlgc_close_open.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ktdlgc_close_open.ExtraText = "Fecha a música actual sem guardar as alteralções e abre a nova."
        Me.ktdlgc_close_open.Image = Nothing
        Me.ktdlgc_close_open.Text = "Fechar E Abrir"
        '
        'ktdlgc_cancel
        '
        Me.ktdlgc_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ktdlgc_cancel.ExtraText = ""
        Me.ktdlgc_cancel.Image = Nothing
        Me.ktdlgc_cancel.Text = "Cancelar"
        '
        'ktdlg_close_window
        '
        Me.ktdlg_close_window.CheckboxText = Nothing
        Me.ktdlg_close_window.CommandButtons.AddRange(New ComponentFactory.Krypton.Toolkit.KryptonTaskDialogCommand() {Me.ktdlgc_save_close, Me.ktdlgc_close, Me.ktdlgc_close_cancel})
        Me.ktdlg_close_window.CommonButtons = ComponentFactory.Krypton.Toolkit.TaskDialogButtons.None
        Me.ktdlg_close_window.Content = Nothing
        Me.ktdlg_close_window.DefaultRadioButton = Nothing
        Me.ktdlg_close_window.FooterHyperlink = Nothing
        Me.ktdlg_close_window.FooterText = Nothing
        Me.ktdlg_close_window.Icon = System.Windows.Forms.MessageBoxIcon.Question
        Me.ktdlg_close_window.MainInstruction = "Existem alterações não guardadas ao ficheiro. Que pretende fazer?"
        Me.ktdlg_close_window.Tag = Nothing
        Me.ktdlg_close_window.WindowTitle = "Ficheiro Não Gravado"
        '
        'ktdlgc_save_close
        '
        Me.ktdlgc_save_close.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ktdlgc_save_close.ExtraText = "Guarda o ficheiro actual e fecha o MyMusic"
        Me.ktdlgc_save_close.Image = Nothing
        Me.ktdlgc_save_close.Text = "Guardar E Feachar"
        '
        'ktdlgc_close
        '
        Me.ktdlgc_close.DialogResult = System.Windows.Forms.DialogResult.Abort
        Me.ktdlgc_close.ExtraText = "Não guarda as alterações e fecha o MyMusic."
        Me.ktdlgc_close.Image = Nothing
        Me.ktdlgc_close.Text = "Não Gravar E Fechar"
        '
        'ktdlgc_close_cancel
        '
        Me.ktdlgc_close_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ktdlgc_close_cancel.ExtraText = "Cancela o encerramento do programa"
        Me.ktdlgc_close_cancel.Image = Nothing
        Me.ktdlgc_close_cancel.Text = "Cancelar"
        '
        'kcmd_thumbnail
        '
        Me.kcmd_thumbnail.Items.AddRange(New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase() {Me.KryptonContextMenuItems1})
        '
        'KryptonContextMenuItems1
        '
        Me.KryptonContextMenuItems1.Items.AddRange(New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase() {Me.KryptonContextMenuItem1, Me.KryptonContextMenuItem2})
        '
        'KryptonContextMenuItem1
        '
        Me.KryptonContextMenuItem1.Image = Global.MyMusic.My.Resources.Resources.page_white_copy
        Me.KryptonContextMenuItem1.Text = "Copiar"
        '
        'KryptonContextMenuItem2
        '
        Me.KryptonContextMenuItem2.Image = Global.MyMusic.My.Resources.Resources.image_edit
        Me.KryptonContextMenuItem2.Text = "Editar Imagem"
        '
        'ofd_thumbnail
        '
        Me.ofd_thumbnail.Title = "Abrir Thumbnail"
        '
        'btn_history_backward
        '
        Me.btn_history_backward.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.[False]
        Me.btn_history_backward.Image = Global.MyMusic.My.Resources.Resources.arrow_180
        Me.btn_history_backward.ToolTipTitle = "Retroceder"
        Me.btn_history_backward.UniqueName = "8BA34058D1904F0F878448F52A1A7468"
        '
        'btn_history_forwards
        '
        Me.btn_history_forwards.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.[False]
        Me.btn_history_forwards.Image = Global.MyMusic.My.Resources.Resources.arrow
        Me.btn_history_forwards.ToolTipBody = "Avançar"
        Me.btn_history_forwards.UniqueName = "6B06F22689E14EB4C48998CC73FF1BF3"
        '
        'tvktxt_lyrics
        '
        Me.tvktxt_lyrics.AutoChangeToFirst = True
        Me.tvktxt_lyrics.BackColor = System.Drawing.Color.Transparent
        Me.tvktxt_lyrics.CheckBoxVisible = False
        Me.tvktxt_lyrics.KChecked = False
        Me.tvktxt_lyrics.LabelColor = System.Drawing.Color.Empty
        Me.tvktxt_lyrics.LabelText = "Lyrics"
        Me.tvktxt_lyrics.Location = New System.Drawing.Point(501, 12)
        Me.tvktxt_lyrics.Name = "tvktxt_lyrics"
        Me.tvktxt_lyrics.RevertText = Nothing
        Me.tvktxt_lyrics.ShowClear = True
        Me.tvktxt_lyrics.ShowRevert = True
        Me.tvktxt_lyrics.Size = New System.Drawing.Size(220, 237)
        Me.tvktxt_lyrics.TabIndex = 9
        Me.tvktxt_lyrics.TextBoxValue = ""
        Me.tvktxt_lyrics.TextBoxValue1 = ""
        Me.tvktxt_lyrics.TextBoxValue2 = ""
        Me.tvktxt_lyrics.TextBoxWidth = 214.0!
        Me.tvktxt_lyrics.TextBoxX = 3.0!
        Me.tvktxt_lyrics.ValueTwoEditable = False
        '
        'kltt_editing_filename
        '
        Me.kltt_editing_filename.BackColor = System.Drawing.Color.Transparent
        Me.kltt_editing_filename.Location = New System.Drawing.Point(44, 163)
        Me.kltt_editing_filename.Name = "kltt_editing_filename"
        Me.kltt_editing_filename.Size = New System.Drawing.Size(145, 33)
        Me.kltt_editing_filename.TabIndex = 18
        '
        'tvktxt_album
        '
        Me.tvktxt_album.AllowDrop = True
        Me.tvktxt_album.AutoChangeToFirst = True
        Me.tvktxt_album.BackColor = System.Drawing.Color.Transparent
        Me.tvktxt_album.CheckBoxVisible = False
        Me.tvktxt_album.LabelColor = System.Drawing.Color.White
        Me.tvktxt_album.LabelText = "Álbum:"
        Me.tvktxt_album.Location = New System.Drawing.Point(203, 132)
        Me.tvktxt_album.Name = "tvktxt_album"
        Me.tvktxt_album.OnlyNumerics = False
        Me.tvktxt_album.PropertyName = "Album"
        Me.tvktxt_album.RevertText = Nothing
        Me.tvktxt_album.ShowClear = True
        Me.tvktxt_album.ShowRevert = True
        Me.tvktxt_album.Size = New System.Drawing.Size(292, 22)
        Me.tvktxt_album.TabIndex = 5
        Me.tvktxt_album.TextBoxValue = ""
        Me.tvktxt_album.TextBoxValue1 = ""
        Me.tvktxt_album.TextBoxValue2 = ""
        Me.tvktxt_album.TextBoxWidth = 150.0!
        Me.tvktxt_album.TextBoxX = 135.0!
        Me.tvktxt_album.ValueTwoEditable = False
        '
        'tvktxt_genres
        '
        Me.tvktxt_genres.AllowDrop = True
        Me.tvktxt_genres.AutoChangeToFirst = True
        Me.tvktxt_genres.BackColor = System.Drawing.Color.Transparent
        Me.tvktxt_genres.CheckBoxVisible = False
        Me.tvktxt_genres.LabelColor = System.Drawing.Color.White
        Me.tvktxt_genres.LabelText = "Géneros:"
        Me.tvktxt_genres.Location = New System.Drawing.Point(203, 216)
        Me.tvktxt_genres.Name = "tvktxt_genres"
        Me.tvktxt_genres.OnlyNumerics = False
        Me.tvktxt_genres.PropertyName = "GenresString"
        Me.tvktxt_genres.RevertText = Nothing
        Me.tvktxt_genres.ShowClear = True
        Me.tvktxt_genres.ShowRevert = True
        Me.tvktxt_genres.Size = New System.Drawing.Size(292, 22)
        Me.tvktxt_genres.TabIndex = 8
        Me.tvktxt_genres.TextBoxValue = ""
        Me.tvktxt_genres.TextBoxValue1 = ""
        Me.tvktxt_genres.TextBoxValue2 = ""
        Me.tvktxt_genres.TextBoxWidth = 150.0!
        Me.tvktxt_genres.TextBoxX = 135.0!
        Me.tvktxt_genres.ValueTwoEditable = False
        '
        'tvktxt_number
        '
        Me.tvktxt_number.AllowDrop = True
        Me.tvktxt_number.AutoChangeToFirst = True
        Me.tvktxt_number.BackColor = System.Drawing.Color.Transparent
        Me.tvktxt_number.CheckBoxVisible = False
        Me.tvktxt_number.LabelColor = System.Drawing.Color.White
        Me.tvktxt_number.LabelText = "Número:"
        Me.tvktxt_number.Location = New System.Drawing.Point(203, 188)
        Me.tvktxt_number.Name = "tvktxt_number"
        Me.tvktxt_number.OnlyNumerics = True
        Me.tvktxt_number.PropertyName = "Number"
        Me.tvktxt_number.RevertText = "0"
        Me.tvktxt_number.ShowClear = True
        Me.tvktxt_number.ShowRevert = True
        Me.tvktxt_number.Size = New System.Drawing.Size(292, 22)
        Me.tvktxt_number.TabIndex = 7
        Me.tvktxt_number.TextBoxValue = "0"
        Me.tvktxt_number.TextBoxValue1 = "0"
        Me.tvktxt_number.TextBoxValue2 = "0"
        Me.tvktxt_number.TextBoxWidth = 150.0!
        Me.tvktxt_number.TextBoxX = 135.0!
        Me.tvktxt_number.ValueTwoEditable = False
        '
        'tvktxt_year
        '
        Me.tvktxt_year.AllowDrop = True
        Me.tvktxt_year.AutoChangeToFirst = True
        Me.tvktxt_year.BackColor = System.Drawing.Color.Transparent
        Me.tvktxt_year.CheckBoxVisible = False
        Me.tvktxt_year.LabelColor = System.Drawing.Color.White
        Me.tvktxt_year.LabelText = "Ano:"
        Me.tvktxt_year.Location = New System.Drawing.Point(203, 160)
        Me.tvktxt_year.Name = "tvktxt_year"
        Me.tvktxt_year.OnlyNumerics = True
        Me.tvktxt_year.PropertyName = "Year"
        Me.tvktxt_year.RevertText = "0"
        Me.tvktxt_year.ShowClear = True
        Me.tvktxt_year.ShowRevert = True
        Me.tvktxt_year.Size = New System.Drawing.Size(292, 22)
        Me.tvktxt_year.TabIndex = 6
        Me.tvktxt_year.TextBoxValue = "0"
        Me.tvktxt_year.TextBoxValue1 = "0"
        Me.tvktxt_year.TextBoxValue2 = "0"
        Me.tvktxt_year.TextBoxWidth = 150.0!
        Me.tvktxt_year.TextBoxX = 135.0!
        Me.tvktxt_year.ValueTwoEditable = False
        '
        'tvktxt_interpret
        '
        Me.tvktxt_interpret.AllowDrop = True
        Me.tvktxt_interpret.AutoChangeToFirst = True
        Me.tvktxt_interpret.BackColor = System.Drawing.Color.Transparent
        Me.tvktxt_interpret.CheckBoxVisible = False
        Me.tvktxt_interpret.LabelColor = System.Drawing.Color.White
        Me.tvktxt_interpret.LabelText = "Intérprete do Álbum:"
        Me.tvktxt_interpret.Location = New System.Drawing.Point(203, 104)
        Me.tvktxt_interpret.Name = "tvktxt_interpret"
        Me.tvktxt_interpret.OnlyNumerics = False
        Me.tvktxt_interpret.PropertyName = "AlbumArtist"
        Me.tvktxt_interpret.RevertText = Nothing
        Me.tvktxt_interpret.ShowClear = True
        Me.tvktxt_interpret.ShowRevert = True
        Me.tvktxt_interpret.Size = New System.Drawing.Size(292, 22)
        Me.tvktxt_interpret.TabIndex = 4
        Me.tvktxt_interpret.TextBoxValue = ""
        Me.tvktxt_interpret.TextBoxValue1 = ""
        Me.tvktxt_interpret.TextBoxValue2 = ""
        Me.tvktxt_interpret.TextBoxWidth = 150.0!
        Me.tvktxt_interpret.TextBoxX = 135.0!
        Me.tvktxt_interpret.ValueTwoEditable = False
        '
        'tvktxt_artists
        '
        Me.tvktxt_artists.AllowDrop = True
        Me.tvktxt_artists.AutoChangeToFirst = True
        Me.tvktxt_artists.BackColor = System.Drawing.Color.Transparent
        Me.tvktxt_artists.CheckBoxVisible = False
        Me.tvktxt_artists.LabelColor = System.Drawing.Color.White
        Me.tvktxt_artists.LabelText = "Artistas: "
        Me.tvktxt_artists.Location = New System.Drawing.Point(203, 76)
        Me.tvktxt_artists.Name = "tvktxt_artists"
        Me.tvktxt_artists.OnlyNumerics = False
        Me.tvktxt_artists.PropertyName = "ArtistsString"
        Me.tvktxt_artists.RevertText = Nothing
        Me.tvktxt_artists.ShowClear = True
        Me.tvktxt_artists.ShowRevert = True
        Me.tvktxt_artists.Size = New System.Drawing.Size(292, 22)
        Me.tvktxt_artists.TabIndex = 3
        Me.tvktxt_artists.TextBoxValue = ""
        Me.tvktxt_artists.TextBoxValue1 = ""
        Me.tvktxt_artists.TextBoxValue2 = ""
        Me.tvktxt_artists.TextBoxWidth = 150.0!
        Me.tvktxt_artists.TextBoxX = 135.0!
        Me.tvktxt_artists.ValueTwoEditable = False
        '
        'tvktxt_comments
        '
        Me.tvktxt_comments.AllowDrop = True
        Me.tvktxt_comments.AutoChangeToFirst = True
        Me.tvktxt_comments.BackColor = System.Drawing.Color.Transparent
        Me.tvktxt_comments.CheckBoxVisible = False
        Me.tvktxt_comments.LabelColor = System.Drawing.Color.White
        Me.tvktxt_comments.LabelText = "Comentários:"
        Me.tvktxt_comments.Location = New System.Drawing.Point(203, 48)
        Me.tvktxt_comments.Name = "tvktxt_comments"
        Me.tvktxt_comments.OnlyNumerics = False
        Me.tvktxt_comments.PropertyName = "Legend"
        Me.tvktxt_comments.RevertText = Nothing
        Me.tvktxt_comments.ShowClear = True
        Me.tvktxt_comments.ShowRevert = True
        Me.tvktxt_comments.Size = New System.Drawing.Size(292, 22)
        Me.tvktxt_comments.TabIndex = 2
        Me.tvktxt_comments.TextBoxValue = ""
        Me.tvktxt_comments.TextBoxValue1 = ""
        Me.tvktxt_comments.TextBoxValue2 = ""
        Me.tvktxt_comments.TextBoxWidth = 150.0!
        Me.tvktxt_comments.TextBoxX = 135.0!
        Me.tvktxt_comments.ValueTwoEditable = False
        '
        'tvktxt_title
        '
        Me.tvktxt_title.AllowDrop = True
        Me.tvktxt_title.AutoChangeToFirst = True
        Me.tvktxt_title.BackColor = System.Drawing.Color.Transparent
        Me.tvktxt_title.CheckBoxVisible = False
        Me.tvktxt_title.LabelColor = System.Drawing.Color.White
        Me.tvktxt_title.LabelText = "Título:"
        Me.tvktxt_title.Location = New System.Drawing.Point(203, 20)
        Me.tvktxt_title.Name = "tvktxt_title"
        Me.tvktxt_title.OnlyNumerics = False
        Me.tvktxt_title.PropertyName = "title"
        Me.tvktxt_title.RevertText = Nothing
        Me.tvktxt_title.ShowClear = True
        Me.tvktxt_title.ShowRevert = True
        Me.tvktxt_title.Size = New System.Drawing.Size(292, 22)
        Me.tvktxt_title.TabIndex = 1
        Me.tvktxt_title.TextBoxValue = ""
        Me.tvktxt_title.TextBoxValue1 = ""
        Me.tvktxt_title.TextBoxValue2 = ""
        Me.tvktxt_title.TextBoxWidth = 150.0!
        Me.tvktxt_title.TextBoxX = 135.0!
        Me.tvktxt_title.ValueTwoEditable = False
        '
        'frm_main
        '
        Me.AllowButtonSpecToolTips = True
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btn_history_backward, Me.btn_history_forwards})
        Me.ClientSize = New System.Drawing.Size(821, 298)
        Me.Controls.Add(Me.kpnl_editing_music)
        Me.Controls.Add(Me.kpnl_loading_music)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
        CType(Me.kpnl_rloading_music, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kpnl_rloading_music.ResumeLayout(False)
        Me.kpnl_rloading_music.PerformLayout()
        CType(Me.pcb_rloading_thumbnail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcb_rloading_music, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents kbtn_thumbnail_open As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents sfd_export_thumbnail As System.Windows.Forms.SaveFileDialog
    Friend WithEvents kpnl_editing_thumbnail As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents kltt_editing_filename As MyMusic.KLabelToTextBox
    Friend WithEvents klbl_loading_drag_files As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents pcb_editing_saving As System.Windows.Forms.PictureBox
    Friend WithEvents tvktxt_lyrics As MyMusic.TVKryptonMultiline
    Friend WithEvents kpnl_rloading_music As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents kwlbl_rloading_thumbnail_name As ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
    Friend WithEvents pcb_rloading_thumbnail As System.Windows.Forms.PictureBox
    Friend WithEvents kwlbl_rloading_music_name As ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
    Friend WithEvents pcb_rloading_music As System.Windows.Forms.PictureBox
    Friend WithEvents klbl_rloading_thumbnail As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klbl_rloading_music As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ktdlg_open_music As ComponentFactory.Krypton.Toolkit.KryptonTaskDialog
    Friend WithEvents ktdlgc_save_open As ComponentFactory.Krypton.Toolkit.KryptonTaskDialogCommand
    Friend WithEvents ktdlgc_close_open As ComponentFactory.Krypton.Toolkit.KryptonTaskDialogCommand
    Friend WithEvents ktdlgc_cancel As ComponentFactory.Krypton.Toolkit.KryptonTaskDialogCommand
    Friend WithEvents ktdlg_close_window As ComponentFactory.Krypton.Toolkit.KryptonTaskDialog
    Friend WithEvents ktdlgc_save_close As ComponentFactory.Krypton.Toolkit.KryptonTaskDialogCommand
    Friend WithEvents ktdlgc_close As ComponentFactory.Krypton.Toolkit.KryptonTaskDialogCommand
    Friend WithEvents ktdlgc_close_cancel As ComponentFactory.Krypton.Toolkit.KryptonTaskDialogCommand
    Friend WithEvents kbtn_clear_rating As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents kcmd_thumbnail As ComponentFactory.Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents KryptonContextMenuItems1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents KryptonContextMenuItem1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kbtn_info As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents ofd_thumbnail As System.Windows.Forms.OpenFileDialog
    Friend WithEvents kbtn_loading_info As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonContextMenuItem2 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kbtn_close_music As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents tt_thumbnail_clear As System.Windows.Forms.ToolTip
    Friend WithEvents btn_history_backward As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents btn_history_forwards As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
End Class
