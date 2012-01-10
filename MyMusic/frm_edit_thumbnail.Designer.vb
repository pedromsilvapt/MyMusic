<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_edit_thumbnail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_edit_thumbnail))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.kpnl_crop = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.kpnl_crop_buttons = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.kbtn_set_crop_size = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.kbtn_crop_reset = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.kbtn_make_square = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.CropablePictureBox1 = New MyMusic.CropablePictureBox()
        Me.kpnl_preview_thumbnail = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.kcbtn_link = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.kcbx_smart_scale = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.klbl_preview_width = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.klbl_preview_height = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.knud_width = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.kbtn_alignement = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.knud_height = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.kcbx_scale_thumbnail = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.kbtn_apply = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.kbtn_cancel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.kcbx_background = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.kcbtn_background_color = New ComponentFactory.Krypton.Toolkit.KryptonColorButton()
        Me.kpnl_align = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.kbtn_align_rightdown = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.kbtn_align_centerdown = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.kbtn_align_leftdown = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.kbtn_align_rightmiddle = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.kbtn_align_centermiddle = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.kbtn_align_leftmiddle = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.kbtn_align_rightup = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.kbtn_align_centerup = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.kbtn_align_leftup = New ComponentFactory.Krypton.Toolkit.KryptonCheckButton()
        Me.pcb_preview = New System.Windows.Forms.PictureBox()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.kcks_align = New ComponentFactory.Krypton.Toolkit.KryptonCheckSet(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.kpnl_crop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kpnl_crop.SuspendLayout()
        CType(Me.kpnl_crop_buttons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kpnl_crop_buttons.SuspendLayout()
        CType(Me.kpnl_preview_thumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kpnl_preview_thumbnail.SuspendLayout()
        CType(Me.kpnl_align, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kpnl_align.SuspendLayout()
        CType(Me.pcb_preview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kcks_align, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.kpnl_crop)
        Me.KryptonPanel.Controls.Add(Me.kpnl_preview_thumbnail)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(618, 424)
        Me.KryptonPanel.TabIndex = 0
        '
        'kpnl_crop
        '
        Me.kpnl_crop.Controls.Add(Me.kpnl_crop_buttons)
        Me.kpnl_crop.Controls.Add(Me.CropablePictureBox1)
        Me.kpnl_crop.Location = New System.Drawing.Point(0, 0)
        Me.kpnl_crop.Name = "kpnl_crop"
        Me.kpnl_crop.Size = New System.Drawing.Size(384, 424)
        Me.kpnl_crop.TabIndex = 13
        '
        'kpnl_crop_buttons
        '
        Me.kpnl_crop_buttons.Controls.Add(Me.kbtn_set_crop_size)
        Me.kpnl_crop_buttons.Controls.Add(Me.kbtn_crop_reset)
        Me.kpnl_crop_buttons.Controls.Add(Me.kbtn_make_square)
        Me.kpnl_crop_buttons.Location = New System.Drawing.Point(3, 388)
        Me.kpnl_crop_buttons.Name = "kpnl_crop_buttons"
        Me.kpnl_crop_buttons.Size = New System.Drawing.Size(342, 24)
        Me.kpnl_crop_buttons.TabIndex = 13
        '
        'kbtn_set_crop_size
        '
        Me.kbtn_set_crop_size.Location = New System.Drawing.Point(238, 0)
        Me.kbtn_set_crop_size.Name = "kbtn_set_crop_size"
        Me.kbtn_set_crop_size.Size = New System.Drawing.Size(103, 25)
        Me.kbtn_set_crop_size.TabIndex = 13
        Me.kbtn_set_crop_size.Values.Image = CType(resources.GetObject("kbtn_set_crop_size.Values.Image"), System.Drawing.Image)
        Me.kbtn_set_crop_size.Values.Text = "Crop's Size"
        '
        'kbtn_crop_reset
        '
        Me.kbtn_crop_reset.Location = New System.Drawing.Point(0, 0)
        Me.kbtn_crop_reset.Name = "kbtn_crop_reset"
        Me.kbtn_crop_reset.Size = New System.Drawing.Size(99, 25)
        Me.kbtn_crop_reset.TabIndex = 2
        Me.kbtn_crop_reset.Values.Image = CType(resources.GetObject("kbtn_crop_reset.Values.Image"), System.Drawing.Image)
        Me.kbtn_crop_reset.Values.Text = "Reset Crop"
        '
        'kbtn_make_square
        '
        Me.kbtn_make_square.Location = New System.Drawing.Point(105, 0)
        Me.kbtn_make_square.Name = "kbtn_make_square"
        Me.kbtn_make_square.Size = New System.Drawing.Size(127, 25)
        Me.kbtn_make_square.TabIndex = 12
        Me.kbtn_make_square.Values.Image = CType(resources.GetObject("kbtn_make_square.Values.Image"), System.Drawing.Image)
        Me.kbtn_make_square.Values.Text = "Formar Quadrado"
        '
        'CropablePictureBox1
        '
        Me.CropablePictureBox1.AllowCrop = True
        Me.CropablePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.CropablePictureBox1.CropBottom = 0
        Me.CropablePictureBox1.CropLeft = 0
        Me.CropablePictureBox1.CropLocation = New System.Drawing.Point(0, 0)
        Me.CropablePictureBox1.CropRight = 0
        Me.CropablePictureBox1.CropSize = New System.Drawing.Size(100, 100)
        Me.CropablePictureBox1.CropTop = 0
        Me.CropablePictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.CropablePictureBox1.MaxSize = New System.Drawing.Size(382, 382)
        Me.CropablePictureBox1.Name = "CropablePictureBox1"
        Me.CropablePictureBox1.RealCropBottom = 0
        Me.CropablePictureBox1.RealCropLeft = 0
        Me.CropablePictureBox1.RealCropLocation = New System.Drawing.Point(0, 0)
        Me.CropablePictureBox1.RealCropRight = 0
        Me.CropablePictureBox1.RealCropSize = New System.Drawing.Size(0, 0)
        Me.CropablePictureBox1.RealCropTop = 0
        Me.CropablePictureBox1.Size = New System.Drawing.Size(382, 382)
        Me.CropablePictureBox1.TabIndex = 0
        '
        'kpnl_preview_thumbnail
        '
        Me.kpnl_preview_thumbnail.Controls.Add(Me.kcbtn_link)
        Me.kpnl_preview_thumbnail.Controls.Add(Me.kcbx_smart_scale)
        Me.kpnl_preview_thumbnail.Controls.Add(Me.klbl_preview_width)
        Me.kpnl_preview_thumbnail.Controls.Add(Me.klbl_preview_height)
        Me.kpnl_preview_thumbnail.Controls.Add(Me.knud_width)
        Me.kpnl_preview_thumbnail.Controls.Add(Me.kbtn_alignement)
        Me.kpnl_preview_thumbnail.Controls.Add(Me.knud_height)
        Me.kpnl_preview_thumbnail.Controls.Add(Me.kcbx_scale_thumbnail)
        Me.kpnl_preview_thumbnail.Controls.Add(Me.kbtn_apply)
        Me.kpnl_preview_thumbnail.Controls.Add(Me.kbtn_cancel)
        Me.kpnl_preview_thumbnail.Controls.Add(Me.kcbx_background)
        Me.kpnl_preview_thumbnail.Controls.Add(Me.kcbtn_background_color)
        Me.kpnl_preview_thumbnail.Controls.Add(Me.kpnl_align)
        Me.kpnl_preview_thumbnail.Controls.Add(Me.pcb_preview)
        Me.kpnl_preview_thumbnail.Location = New System.Drawing.Point(410, 12)
        Me.kpnl_preview_thumbnail.Name = "kpnl_preview_thumbnail"
        Me.kpnl_preview_thumbnail.Size = New System.Drawing.Size(203, 388)
        Me.kpnl_preview_thumbnail.TabIndex = 11
        '
        'kcbtn_link
        '
        Me.kcbtn_link.Location = New System.Drawing.Point(156, 185)
        Me.kcbtn_link.Name = "kcbtn_link"
        Me.kcbtn_link.Size = New System.Drawing.Size(22, 50)
        Me.kcbtn_link.TabIndex = 13
        Me.kcbtn_link.Values.Image = Global.MyMusic.My.Resources.Resources.link_break
        Me.kcbtn_link.Values.Text = ""
        '
        'kcbx_smart_scale
        '
        Me.kcbx_smart_scale.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.kcbx_smart_scale.Location = New System.Drawing.Point(28, 267)
        Me.kcbx_smart_scale.Name = "kcbx_smart_scale"
        Me.kcbx_smart_scale.Size = New System.Drawing.Size(166, 20)
        Me.kcbx_smart_scale.TabIndex = 14
        Me.kcbx_smart_scale.Text = "Redimensionar Inteligente"
        Me.kcbx_smart_scale.Values.Text = "Redimensionar Inteligente"
        '
        'klbl_preview_width
        '
        Me.klbl_preview_width.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klbl_preview_width.Location = New System.Drawing.Point(33, 215)
        Me.klbl_preview_width.Name = "klbl_preview_width"
        Me.klbl_preview_width.Size = New System.Drawing.Size(54, 20)
        Me.klbl_preview_width.TabIndex = 13
        Me.klbl_preview_width.Values.Text = "Largura:"
        '
        'klbl_preview_height
        '
        Me.klbl_preview_height.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klbl_preview_height.Location = New System.Drawing.Point(33, 187)
        Me.klbl_preview_height.Name = "klbl_preview_height"
        Me.klbl_preview_height.Size = New System.Drawing.Size(46, 20)
        Me.klbl_preview_height.TabIndex = 12
        Me.klbl_preview_height.Values.Text = "Altura:"
        '
        'knud_width
        '
        Me.knud_width.Location = New System.Drawing.Point(86, 213)
        Me.knud_width.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.knud_width.Name = "knud_width"
        Me.knud_width.Size = New System.Drawing.Size(64, 22)
        Me.knud_width.TabIndex = 11
        Me.knud_width.Value = New Decimal(New Integer() {145, 0, 0, 0})
        '
        'kbtn_alignement
        '
        Me.kbtn_alignement.Location = New System.Drawing.Point(33, 3)
        Me.kbtn_alignement.Name = "kbtn_alignement"
        Me.kbtn_alignement.Size = New System.Drawing.Size(145, 25)
        Me.kbtn_alignement.TabIndex = 7
        Me.kbtn_alignement.Values.Image = CType(resources.GetObject("kbtn_alignement.Values.Image"), System.Drawing.Image)
        Me.kbtn_alignement.Values.Text = "Alinhamento"
        '
        'knud_height
        '
        Me.knud_height.Location = New System.Drawing.Point(86, 185)
        Me.knud_height.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.knud_height.Name = "knud_height"
        Me.knud_height.Size = New System.Drawing.Size(64, 22)
        Me.knud_height.TabIndex = 10
        Me.knud_height.Value = New Decimal(New Integer() {145, 0, 0, 0})
        '
        'kcbx_scale_thumbnail
        '
        Me.kcbx_scale_thumbnail.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.kcbx_scale_thumbnail.Location = New System.Drawing.Point(28, 241)
        Me.kcbx_scale_thumbnail.Name = "kcbx_scale_thumbnail"
        Me.kcbx_scale_thumbnail.Size = New System.Drawing.Size(166, 20)
        Me.kcbx_scale_thumbnail.TabIndex = 9
        Me.kcbx_scale_thumbnail.Text = "Redimensionar Thumbnail"
        Me.kcbx_scale_thumbnail.Values.Text = "Redimensionar Thumbnail"
        '
        'kbtn_apply
        '
        Me.kbtn_apply.Location = New System.Drawing.Point(8, 351)
        Me.kbtn_apply.Name = "kbtn_apply"
        Me.kbtn_apply.Size = New System.Drawing.Size(90, 25)
        Me.kbtn_apply.TabIndex = 3
        Me.kbtn_apply.Values.Image = Global.MyMusic.My.Resources.Resources.accept
        Me.kbtn_apply.Values.Text = "Aplicar"
        '
        'kbtn_cancel
        '
        Me.kbtn_cancel.Location = New System.Drawing.Point(104, 351)
        Me.kbtn_cancel.Name = "kbtn_cancel"
        Me.kbtn_cancel.Size = New System.Drawing.Size(90, 25)
        Me.kbtn_cancel.TabIndex = 4
        Me.kbtn_cancel.Values.Image = Global.MyMusic.My.Resources.Resources.cross
        Me.kbtn_cancel.Values.Text = "Cancelar"
        '
        'kcbx_background
        '
        Me.kcbx_background.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.kcbx_background.Location = New System.Drawing.Point(45, 293)
        Me.kcbx_background.Name = "kcbx_background"
        Me.kcbx_background.Size = New System.Drawing.Size(130, 20)
        Me.kcbx_background.TabIndex = 5
        Me.kcbx_background.Text = "Aplicar background"
        Me.kcbx_background.Values.Text = "Aplicar background"
        '
        'kcbtn_background_color
        '
        Me.kcbtn_background_color.Location = New System.Drawing.Point(104, 319)
        Me.kcbtn_background_color.Name = "kcbtn_background_color"
        Me.kcbtn_background_color.SelectedColor = System.Drawing.Color.White
        Me.kcbtn_background_color.Size = New System.Drawing.Size(69, 25)
        Me.kcbtn_background_color.TabIndex = 6
        Me.kcbtn_background_color.Values.Text = "Cor"
        '
        'kpnl_align
        '
        Me.kpnl_align.Controls.Add(Me.kbtn_align_rightdown)
        Me.kpnl_align.Controls.Add(Me.kbtn_align_centerdown)
        Me.kpnl_align.Controls.Add(Me.kbtn_align_leftdown)
        Me.kpnl_align.Controls.Add(Me.kbtn_align_rightmiddle)
        Me.kpnl_align.Controls.Add(Me.kbtn_align_centermiddle)
        Me.kpnl_align.Controls.Add(Me.kbtn_align_leftmiddle)
        Me.kpnl_align.Controls.Add(Me.kbtn_align_rightup)
        Me.kpnl_align.Controls.Add(Me.kbtn_align_centerup)
        Me.kpnl_align.Controls.Add(Me.kbtn_align_leftup)
        Me.kpnl_align.Location = New System.Drawing.Point(33, 34)
        Me.kpnl_align.Name = "kpnl_align"
        Me.kpnl_align.Size = New System.Drawing.Size(145, 145)
        Me.kpnl_align.TabIndex = 8
        Me.kpnl_align.Visible = False
        '
        'kbtn_align_rightdown
        '
        Me.kbtn_align_rightdown.Location = New System.Drawing.Point(98, 98)
        Me.kbtn_align_rightdown.Name = "kbtn_align_rightdown"
        Me.kbtn_align_rightdown.Size = New System.Drawing.Size(47, 47)
        Me.kbtn_align_rightdown.TabIndex = 21
        Me.kbtn_align_rightdown.Tag = "rightdown"
        Me.kbtn_align_rightdown.Values.Image = CType(resources.GetObject("kbtn_align_rightdown.Values.Image"), System.Drawing.Image)
        Me.kbtn_align_rightdown.Values.Text = ""
        '
        'kbtn_align_centerdown
        '
        Me.kbtn_align_centerdown.Location = New System.Drawing.Point(49, 98)
        Me.kbtn_align_centerdown.Name = "kbtn_align_centerdown"
        Me.kbtn_align_centerdown.Size = New System.Drawing.Size(47, 47)
        Me.kbtn_align_centerdown.TabIndex = 20
        Me.kbtn_align_centerdown.Tag = "centerdown"
        Me.kbtn_align_centerdown.Values.Image = CType(resources.GetObject("kbtn_align_centerdown.Values.Image"), System.Drawing.Image)
        Me.kbtn_align_centerdown.Values.Text = ""
        '
        'kbtn_align_leftdown
        '
        Me.kbtn_align_leftdown.Location = New System.Drawing.Point(0, 98)
        Me.kbtn_align_leftdown.Name = "kbtn_align_leftdown"
        Me.kbtn_align_leftdown.Size = New System.Drawing.Size(47, 47)
        Me.kbtn_align_leftdown.TabIndex = 19
        Me.kbtn_align_leftdown.Tag = "leftdown"
        Me.kbtn_align_leftdown.Values.Image = CType(resources.GetObject("kbtn_align_leftdown.Values.Image"), System.Drawing.Image)
        Me.kbtn_align_leftdown.Values.Text = ""
        '
        'kbtn_align_rightmiddle
        '
        Me.kbtn_align_rightmiddle.Location = New System.Drawing.Point(98, 49)
        Me.kbtn_align_rightmiddle.Name = "kbtn_align_rightmiddle"
        Me.kbtn_align_rightmiddle.Size = New System.Drawing.Size(47, 47)
        Me.kbtn_align_rightmiddle.TabIndex = 18
        Me.kbtn_align_rightmiddle.Tag = "rightmiddle"
        Me.kbtn_align_rightmiddle.Values.Image = CType(resources.GetObject("kbtn_align_rightmiddle.Values.Image"), System.Drawing.Image)
        Me.kbtn_align_rightmiddle.Values.Text = ""
        '
        'kbtn_align_centermiddle
        '
        Me.kbtn_align_centermiddle.Location = New System.Drawing.Point(49, 49)
        Me.kbtn_align_centermiddle.Name = "kbtn_align_centermiddle"
        Me.kbtn_align_centermiddle.Size = New System.Drawing.Size(47, 47)
        Me.kbtn_align_centermiddle.TabIndex = 17
        Me.kbtn_align_centermiddle.Tag = "centermiddle"
        Me.kbtn_align_centermiddle.Values.Image = CType(resources.GetObject("kbtn_align_centermiddle.Values.Image"), System.Drawing.Image)
        Me.kbtn_align_centermiddle.Values.Text = ""
        '
        'kbtn_align_leftmiddle
        '
        Me.kbtn_align_leftmiddle.Location = New System.Drawing.Point(0, 49)
        Me.kbtn_align_leftmiddle.Name = "kbtn_align_leftmiddle"
        Me.kbtn_align_leftmiddle.Size = New System.Drawing.Size(47, 47)
        Me.kbtn_align_leftmiddle.TabIndex = 16
        Me.kbtn_align_leftmiddle.Tag = "leftmiddle"
        Me.kbtn_align_leftmiddle.Values.Image = CType(resources.GetObject("kbtn_align_leftmiddle.Values.Image"), System.Drawing.Image)
        Me.kbtn_align_leftmiddle.Values.Text = ""
        '
        'kbtn_align_rightup
        '
        Me.kbtn_align_rightup.Location = New System.Drawing.Point(98, 0)
        Me.kbtn_align_rightup.Name = "kbtn_align_rightup"
        Me.kbtn_align_rightup.Size = New System.Drawing.Size(47, 47)
        Me.kbtn_align_rightup.TabIndex = 15
        Me.kbtn_align_rightup.Tag = "rightup"
        Me.kbtn_align_rightup.Values.Image = CType(resources.GetObject("kbtn_align_rightup.Values.Image"), System.Drawing.Image)
        Me.kbtn_align_rightup.Values.Text = ""
        '
        'kbtn_align_centerup
        '
        Me.kbtn_align_centerup.Location = New System.Drawing.Point(49, 0)
        Me.kbtn_align_centerup.Name = "kbtn_align_centerup"
        Me.kbtn_align_centerup.Size = New System.Drawing.Size(47, 47)
        Me.kbtn_align_centerup.TabIndex = 14
        Me.kbtn_align_centerup.Tag = "centerup"
        Me.kbtn_align_centerup.Values.Image = CType(resources.GetObject("kbtn_align_centerup.Values.Image"), System.Drawing.Image)
        Me.kbtn_align_centerup.Values.Text = ""
        '
        'kbtn_align_leftup
        '
        Me.kbtn_align_leftup.Checked = True
        Me.kbtn_align_leftup.Location = New System.Drawing.Point(0, 0)
        Me.kbtn_align_leftup.Name = "kbtn_align_leftup"
        Me.kbtn_align_leftup.Size = New System.Drawing.Size(47, 47)
        Me.kbtn_align_leftup.TabIndex = 13
        Me.kbtn_align_leftup.Tag = "leftup"
        Me.kbtn_align_leftup.Values.Image = CType(resources.GetObject("kbtn_align_leftup.Values.Image"), System.Drawing.Image)
        Me.kbtn_align_leftup.Values.Text = ""
        '
        'pcb_preview
        '
        Me.pcb_preview.BackColor = System.Drawing.Color.Transparent
        Me.pcb_preview.Image = Global.MyMusic.My.Resources.Resources.PNG
        Me.pcb_preview.Location = New System.Drawing.Point(33, 34)
        Me.pcb_preview.Name = "pcb_preview"
        Me.pcb_preview.Size = New System.Drawing.Size(145, 145)
        Me.pcb_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcb_preview.TabIndex = 1
        Me.pcb_preview.TabStop = False
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Black
        '
        'kcks_align
        '
        Me.kcks_align.CheckButtons.Add(Me.kbtn_align_leftup)
        Me.kcks_align.CheckButtons.Add(Me.kbtn_align_centerup)
        Me.kcks_align.CheckButtons.Add(Me.kbtn_align_rightup)
        Me.kcks_align.CheckButtons.Add(Me.kbtn_align_leftmiddle)
        Me.kcks_align.CheckButtons.Add(Me.kbtn_align_centermiddle)
        Me.kcks_align.CheckButtons.Add(Me.kbtn_align_rightmiddle)
        Me.kcks_align.CheckButtons.Add(Me.kbtn_align_leftdown)
        Me.kcks_align.CheckButtons.Add(Me.kbtn_align_centerdown)
        Me.kcks_align.CheckButtons.Add(Me.kbtn_align_rightdown)
        Me.kcks_align.CheckedButton = Me.kbtn_align_leftup
        '
        'frm_edit_thumbnail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 424)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_edit_thumbnail"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Thumbnail"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.kpnl_crop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kpnl_crop.ResumeLayout(False)
        CType(Me.kpnl_crop_buttons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kpnl_crop_buttons.ResumeLayout(False)
        CType(Me.kpnl_preview_thumbnail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kpnl_preview_thumbnail.ResumeLayout(False)
        Me.kpnl_preview_thumbnail.PerformLayout()
        CType(Me.kpnl_align, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kpnl_align.ResumeLayout(False)
        CType(Me.pcb_preview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kcks_align, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents CropablePictureBox1 As MyMusic.CropablePictureBox
    Friend WithEvents pcb_preview As System.Windows.Forms.PictureBox
    Friend WithEvents kbtn_crop_reset As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents kbtn_cancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents kbtn_apply As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents kcbx_background As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kcbtn_background_color As ComponentFactory.Krypton.Toolkit.KryptonColorButton
    Friend WithEvents kbtn_alignement As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents kpnl_align As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents kcbx_scale_thumbnail As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents knud_height As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents kpnl_preview_thumbnail As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents knud_width As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents klbl_preview_width As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klbl_preview_height As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kcbx_smart_scale As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kbtn_make_square As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents kcbtn_link As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents kpnl_crop As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents kpnl_crop_buttons As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents kbtn_align_rightdown As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents kbtn_align_centerdown As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents kbtn_align_leftdown As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents kbtn_align_rightmiddle As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents kbtn_align_centermiddle As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents kbtn_align_leftmiddle As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents kbtn_align_rightup As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents kbtn_align_centerup As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents kbtn_align_leftup As ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents kcks_align As ComponentFactory.Krypton.Toolkit.KryptonCheckSet
    Friend WithEvents kbtn_set_crop_size As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
