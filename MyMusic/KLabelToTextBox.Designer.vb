<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KLabelToTextBox
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
        Me.KLabel = New ComponentFactory.Krypton.Toolkit.KryptonWrapLabel()
        Me.SuspendLayout()
        '
        'KTextBox
        '
        Me.KTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KTextBox.Location = New System.Drawing.Point(0, 0)
        Me.KTextBox.Multiline = True
        Me.KTextBox.Name = "KTextBox"
        Me.KTextBox.Size = New System.Drawing.Size(190, 75)
        Me.KTextBox.TabIndex = 1
        Me.KTextBox.Visible = False
        '
        'KLabel
        '
        Me.KLabel.AutoSize = False
        Me.KLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.KLabel.ForeColor = System.Drawing.Color.White
        Me.KLabel.Location = New System.Drawing.Point(0, 0)
        Me.KLabel.Name = "KLabel"
        Me.KLabel.Size = New System.Drawing.Size(190, 75)
        Me.KLabel.StateCommon.TextColor = System.Drawing.Color.White
        Me.KLabel.Text = "KryptonLabel1"
        '
        'KLabelToTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KLabel)
        Me.Controls.Add(Me.KTextBox)
        Me.Name = "KLabelToTextBox"
        Me.Size = New System.Drawing.Size(190, 75)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KTextBox As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KLabel As ComponentFactory.Krypton.Toolkit.KryptonWrapLabel

End Class
