Public Class TVKryptonTextBox

    Private TextValue1 As String = ""
    Private TextValue2 As String = ""
    Private Value2Editable As Boolean = False
    Private AutoChangeTo1 As Boolean = True

    Public Property TextBoxX As Single
        Get
            Return Me.KTextBox.Location.X
        End Get
        Set(ByVal value As Single)
            Me.KTextBox.Location = New Point(value, Me.KTextBox.Location.Y)
        End Set
    End Property

    Public Property TextBoxWidth As Single
        Get
            Return Me.KTextBox.Size.Width
        End Get
        Set(ByVal value As Single)
            Me.KTextBox.Size = New Size(value, Me.KTextBox.Size.Height)
        End Set
    End Property

    Public Property TextBoxValue1 As String
        Get
            Return Me.TextValue1
        End Get
        Set(ByVal value As String)
            If (Me.KCheckBox.Checked) Then
                Me.TextValue1 = value
            Else
                Me.KTextBox.Text = value
            End If
        End Set
    End Property

    Public Property TextBoxValue2 As String
        Get
            Return Me.TextValue2
        End Get
        Set(ByVal value As String)
            If (Me.KCheckBox.Checked) Then
                Me.KTextBox.Text = value
            Else
                Me.TextValue2 = value
            End If
        End Set
    End Property

    Public Property LabelText As String
        Get
            Return Me.KLabel.Text
        End Get
        Set(ByVal value As String)
            Me.KLabel.Text = value
        End Set
    End Property

    Public Property ValueTwoEditable As Boolean
        Get
            Return Me.Value2Editable
        End Get
        Set(ByVal value As Boolean)
            Me.Value2Editable = value
        End Set
    End Property

    Public Property AutoChangeToFirst As Boolean
        Get
            Return Me.AutoChangeTo1
        End Get
        Set(ByVal value As Boolean)
            Me.AutoChangeTo1 = value
        End Set
    End Property

    Public Property CheckBoxVisible As Boolean
        Get
            Return Me.KCheckBox.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.KCheckBox.Visible = value
        End Set
    End Property

    Public Property LabelColor As Color
        Get
            Return Me.KLabel.StateCommon.ShortText.Color1
        End Get
        Set(ByVal value As Color)
            Me.KLabel.StateCommon.ShortText.Color1 = value
        End Set
    End Property

    Public Event AnyTextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event Text1Changed(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event Text2Changed(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Sub KTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles KTextBox.TextChanged
        If (Me.KCheckBox.Checked = True) Then
            If (Me.Value2Editable = True) Then
                Me.TextValue2 = Me.KTextBox.Text
                RaiseEvent Text2Changed(sender, e)
            Else
                Me.TextValue1 = Me.KTextBox.Text
                Me.KCheckBox.Checked = False
                RaiseEvent Text1Changed(sender, e)
            End If
        Else
            Me.TextValue1 = Me.KTextBox.Text
            RaiseEvent Text1Changed(sender, e)
        End If
        RaiseEvent AnyTextChanged(sender, e)
    End Sub

    Private Sub KCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles KCheckBox.CheckedChanged
        If (Me.KCheckBox.Checked = True) Then
            Me.KTextBox.Text = Me.TextValue2
        Else
            Me.KTextBox.Text = Me.TextValue1
        End If
    End Sub

    Private Sub KCheckBox_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles KCheckBox.VisibleChanged
        If (Me.AutoChangeTo1 = True And Me.KCheckBox.Visible = False) Then
            Me.KCheckBox.Checked = False
        End If
    End Sub
End Class
