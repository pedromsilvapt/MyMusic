Public Class KLabelToTextBox

    Private Changed As Boolean = False

    Public Property Label As ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
        Get
            Return Me.KLabel
        End Get
        Set(ByVal value As ComponentFactory.Krypton.Toolkit.KryptonWrapLabel)
            Me.KLabel = value
        End Set
    End Property

    Public Property TextBox As ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Get
            Return Me.KTextBox
        End Get
        Set(ByVal value As ComponentFactory.Krypton.Toolkit.KryptonTextBox)
            Me.KTextBox = value
        End Set
    End Property

    Public Overrides Property Text As String
        Get
            Return Me.KTextBox.Text
        End Get
        Set(ByVal value As String)
            Me.KTextBox.Text = value
        End Set
    End Property


    Private Sub KLabel_MouseClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles KLabel.MouseClick
        Me.KTextBox.Visible = True
        Me.KLabel.Visible = False
        Me.KTextBox.Focus()
    End Sub

    Private Sub KTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles KTextBox.LostFocus
        Me.KLabel.Visible = True
        Me.KTextBox.Visible = False
    End Sub

    Private Sub KLabel_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles KLabel.TextChanged
        If (Changed = False) Then
            Me.Changed = True
            Me.KTextBox.Text = Me.KLabel.Text
        Else
            Me.Changed = False
        End If
    End Sub

    Private Sub KTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles KTextBox.TextChanged
        If (Changed = False) Then
            Me.Changed = True
            Me.KLabel.Text = Me.KTextBox.Text
        Else
            Me.Changed = False
        End If
    End Sub
End Class
