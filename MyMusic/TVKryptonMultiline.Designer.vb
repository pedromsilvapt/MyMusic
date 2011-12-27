<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TVKryptonMultiline
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
        Me.KTextBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KHeader = New ComponentFactory.Krypton.Toolkit.KryptonHeader()
        Me.KBSRevert = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.KBSClear = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.KBSCheck = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.SuspendLayout()
        '
        'KTextBox
        '
        Me.KTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KTextBox.Location = New System.Drawing.Point(3, 34)
        Me.KTextBox.Multiline = True
        Me.KTextBox.Name = "KTextBox"
        Me.KTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.KTextBox.Size = New System.Drawing.Size(225, 200)
        Me.KTextBox.TabIndex = 3
        '
        'KHeader
        '
        Me.KHeader.AllowButtonSpecToolTips = True
        Me.KHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KHeader.AutoSize = False
        Me.KHeader.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.KBSRevert, Me.KBSClear, Me.KBSCheck})
        Me.KHeader.Location = New System.Drawing.Point(3, 3)
        Me.KHeader.Name = "KHeader"
        Me.KHeader.Size = New System.Drawing.Size(225, 31)
        Me.KHeader.TabIndex = 6
        Me.KHeader.Values.Description = ""
        Me.KHeader.Values.Heading = "Krypton Header Text"
        Me.KHeader.Values.Image = Nothing
        '
        'KBSRevert
        '
        Me.KBSRevert.ToolTipBody = "Reverter"
        Me.KBSRevert.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowLeft
        Me.KBSRevert.UniqueName = "83BA0203CA874CE08DAA026EAF128B35"
        '
        'KBSClear
        '
        Me.KBSClear.ToolTipBody = "Limpar"
        Me.KBSClear.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.KBSClear.UniqueName = "417DB2DF465241B03E8357D350595D9B"
        '
        'KBSCheck
        '
        Me.KBSCheck.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Unchecked
        Me.KBSCheck.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.PinVertical
        Me.KBSCheck.UniqueName = "AC6BD61A892A46F24B9B5689F25CC1B9"
        Me.KBSCheck.Visible = False
        '
        'TVKryptonMultiline
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KHeader)
        Me.Controls.Add(Me.KTextBox)
        Me.Name = "TVKryptonMultiline"
        Me.Size = New System.Drawing.Size(231, 237)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KTextBox As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KHeader As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents KBSRevert As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KBSClear As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KBSCheck As ComponentFactory.Krypton.Toolkit.ButtonSpecAny

End Class
