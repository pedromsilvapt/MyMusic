﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TVKryptonTextBox
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
        Me.KCheckBox = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.KLabel = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KTextBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.SuspendLayout()
        '
        'KCheckBox
        '
        Me.KCheckBox.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.KCheckBox.Location = New System.Drawing.Point(3, 4)
        Me.KCheckBox.Name = "KCheckBox"
        Me.KCheckBox.Size = New System.Drawing.Size(19, 13)
        Me.KCheckBox.TabIndex = 0
        Me.KCheckBox.Values.Text = ""
        '
        'KLabel
        '
        Me.KLabel.Location = New System.Drawing.Point(16, 1)
        Me.KLabel.Name = "KLabel"
        Me.KLabel.Size = New System.Drawing.Size(39, 20)
        Me.KLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.KLabel.TabIndex = 1
        '
        'KTextBox
        '
        Me.KTextBox.Location = New System.Drawing.Point(59, 1)
        Me.KTextBox.Name = "KTextBox"
        Me.KTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KTextBox.TabIndex = 2
        '
        'TVKryptonTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KTextBox)
        Me.Controls.Add(Me.KLabel)
        Me.Controls.Add(Me.KCheckBox)
        Me.Name = "TVKryptonTextBox"
        Me.Size = New System.Drawing.Size(173, 22)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KCheckBox As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KLabel As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KTextBox As ComponentFactory.Krypton.Toolkit.KryptonTextBox

End Class
