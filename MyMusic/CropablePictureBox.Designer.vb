<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CropablePictureBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pcb_main = New System.Windows.Forms.PictureBox()
        Me.KWidth = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KHeight = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.pcb_main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pcb_main
        '
        Me.pcb_main.Location = New System.Drawing.Point(0, 0)
        Me.pcb_main.Name = "pcb_main"
        Me.pcb_main.Size = New System.Drawing.Size(355, 355)
        Me.pcb_main.TabIndex = 0
        Me.pcb_main.TabStop = False
        '
        'KWidth
        '
        Me.KWidth.Location = New System.Drawing.Point(141, 358)
        Me.KWidth.Name = "KWidth"
        Me.KWidth.Size = New System.Drawing.Size(51, 20)
        Me.KWidth.TabIndex = 1
        Me.KWidth.Values.Text = "KWidth"
        '
        'KHeight
        '
        Me.KHeight.Location = New System.Drawing.Point(361, 143)
        Me.KHeight.Name = "KHeight"
        Me.KHeight.Orientation = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left
        Me.KHeight.Size = New System.Drawing.Size(20, 54)
        Me.KHeight.TabIndex = 2
        Me.KHeight.Values.Text = "KHeight"
        '
        'CropablePictureBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KHeight)
        Me.Controls.Add(Me.KWidth)
        Me.Controls.Add(Me.pcb_main)
        Me.Name = "CropablePictureBox"
        Me.Size = New System.Drawing.Size(382, 382)
        CType(Me.pcb_main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pcb_main As System.Windows.Forms.PictureBox
    Friend WithEvents KWidth As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KHeight As ComponentFactory.Krypton.Toolkit.KryptonLabel

End Class
