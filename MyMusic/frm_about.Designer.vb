<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_about
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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.kgpb_libraries = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.kllbl_fam_fam_fam_icons = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.kllbl_rating_control = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.kllbl_taglib = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.kllbl_transitions = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.kllbl_krypton = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.klbl_date = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.klbl_version = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.klbl_mymusic = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.pcb_icon = New System.Windows.Forms.PictureBox()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.kgpb_libraries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kgpb_libraries.Panel.SuspendLayout()
        Me.kgpb_libraries.SuspendLayout()
        CType(Me.pcb_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.pcb_icon)
        Me.KryptonPanel.Controls.Add(Me.kgpb_libraries)
        Me.KryptonPanel.Controls.Add(Me.klbl_date)
        Me.KryptonPanel.Controls.Add(Me.klbl_version)
        Me.KryptonPanel.Controls.Add(Me.klbl_mymusic)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(292, 357)
        Me.KryptonPanel.TabIndex = 0
        '
        'kgpb_libraries
        '
        Me.kgpb_libraries.Location = New System.Drawing.Point(12, 181)
        Me.kgpb_libraries.Name = "kgpb_libraries"
        '
        'kgpb_libraries.Panel
        '
        Me.kgpb_libraries.Panel.Controls.Add(Me.kllbl_fam_fam_fam_icons)
        Me.kgpb_libraries.Panel.Controls.Add(Me.kllbl_rating_control)
        Me.kgpb_libraries.Panel.Controls.Add(Me.kllbl_taglib)
        Me.kgpb_libraries.Panel.Controls.Add(Me.kllbl_transitions)
        Me.kgpb_libraries.Panel.Controls.Add(Me.kllbl_krypton)
        Me.kgpb_libraries.Size = New System.Drawing.Size(268, 164)
        Me.kgpb_libraries.TabIndex = 3
        Me.kgpb_libraries.Text = "Bibliotecas Usadas"
        Me.kgpb_libraries.Values.Heading = "Bibliotecas Usadas"
        '
        'kllbl_fam_fam_fam_icons
        '
        Me.kllbl_fam_fam_fam_icons.Location = New System.Drawing.Point(4, 108)
        Me.kllbl_fam_fam_fam_icons.Name = "kllbl_fam_fam_fam_icons"
        Me.kllbl_fam_fam_fam_icons.Size = New System.Drawing.Size(118, 20)
        Me.kllbl_fam_fam_fam_icons.TabIndex = 4
        Me.kllbl_fam_fam_fam_icons.Values.Text = "Fam Fam Fam Icons"
        '
        'kllbl_rating_control
        '
        Me.kllbl_rating_control.Location = New System.Drawing.Point(4, 82)
        Me.kllbl_rating_control.Name = "kllbl_rating_control"
        Me.kllbl_rating_control.Size = New System.Drawing.Size(90, 20)
        Me.kllbl_rating_control.TabIndex = 3
        Me.kllbl_rating_control.Values.Text = "Rating Control"
        '
        'kllbl_taglib
        '
        Me.kllbl_taglib.Location = New System.Drawing.Point(4, 56)
        Me.kllbl_taglib.Name = "kllbl_taglib"
        Me.kllbl_taglib.Size = New System.Drawing.Size(54, 20)
        Me.kllbl_taglib.TabIndex = 2
        Me.kllbl_taglib.Values.Text = "TagLib#"
        '
        'kllbl_transitions
        '
        Me.kllbl_transitions.Location = New System.Drawing.Point(4, 30)
        Me.kllbl_transitions.Name = "kllbl_transitions"
        Me.kllbl_transitions.Size = New System.Drawing.Size(113, 20)
        Me.kllbl_transitions.TabIndex = 1
        Me.kllbl_transitions.Values.Text = "DotNet Transitions"
        '
        'kllbl_krypton
        '
        Me.kllbl_krypton.Location = New System.Drawing.Point(4, 4)
        Me.kllbl_krypton.Name = "kllbl_krypton"
        Me.kllbl_krypton.Size = New System.Drawing.Size(94, 20)
        Me.kllbl_krypton.TabIndex = 0
        Me.kllbl_krypton.Values.Text = "Krypton Toolkit"
        '
        'klbl_date
        '
        Me.klbl_date.AutoSize = False
        Me.klbl_date.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klbl_date.Location = New System.Drawing.Point(12, 155)
        Me.klbl_date.Name = "klbl_date"
        Me.klbl_date.Size = New System.Drawing.Size(268, 25)
        Me.klbl_date.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.klbl_date.TabIndex = 2
        Me.klbl_date.Values.Text = "27/12/2011"
        '
        'klbl_version
        '
        Me.klbl_version.AutoSize = False
        Me.klbl_version.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klbl_version.Location = New System.Drawing.Point(12, 129)
        Me.klbl_version.Name = "klbl_version"
        Me.klbl_version.Size = New System.Drawing.Size(268, 25)
        Me.klbl_version.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.klbl_version.TabIndex = 1
        Me.klbl_version.Values.Text = "Versão {0}"
        '
        'klbl_mymusic
        '
        Me.klbl_mymusic.AutoSize = False
        Me.klbl_mymusic.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.klbl_mymusic.Location = New System.Drawing.Point(12, 103)
        Me.klbl_mymusic.Name = "klbl_mymusic"
        Me.klbl_mymusic.Size = New System.Drawing.Size(268, 25)
        Me.klbl_mymusic.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.klbl_mymusic.TabIndex = 0
        Me.klbl_mymusic.Values.Text = "MyMusic"
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Black
        '
        'pcb_icon
        '
        Me.pcb_icon.BackColor = System.Drawing.Color.Transparent
        Me.pcb_icon.Image = Global.MyMusic.My.Resources.Resources.mymusic
        Me.pcb_icon.Location = New System.Drawing.Point(12, 12)
        Me.pcb_icon.Name = "pcb_icon"
        Me.pcb_icon.Size = New System.Drawing.Size(268, 85)
        Me.pcb_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcb_icon.TabIndex = 4
        Me.pcb_icon.TabStop = False
        '
        'frm_about
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 357)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_about"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sobre MyMusic"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.kgpb_libraries.Panel.ResumeLayout(False)
        Me.kgpb_libraries.Panel.PerformLayout()
        CType(Me.kgpb_libraries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kgpb_libraries.ResumeLayout(False)
        CType(Me.pcb_icon, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents klbl_date As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klbl_version As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents klbl_mymusic As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kgpb_libraries As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents kllbl_krypton As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents kllbl_transitions As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents kllbl_taglib As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents kllbl_rating_control As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents kllbl_fam_fam_fam_icons As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents pcb_icon As System.Windows.Forms.PictureBox
End Class
