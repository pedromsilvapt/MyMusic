Public Class TVKryptonMultiline
    Private TextValue1 As String = ""
    Private TextValue2 As String = ""
    Private Value2Editable As Boolean = False
    Private AutoChangeTo1 As Boolean = True
    Private _RevertText As String

    Private _ShowClear As Boolean = True

    Private _ShowRevert As Boolean = True

    Public Property RevertText As String
        Get
            Return Me._RevertText
        End Get
        Set(ByVal value As String)
            Me._RevertText = value

            Me.KBSRevert.Visible = ((Me.TextBoxValue <> Me.RevertText) And (Me._ShowRevert = True))
        End Set
    End Property

    Public Property ShowClear As Boolean
        Get
            Return Me._ShowClear
        End Get
        Set(ByVal value As Boolean)
            Me._ShowClear = value

            Me.KBSClear.Visible = ((Me.TextBoxValue <> "") And (Me._ShowClear))
        End Set
    End Property

    Public Property ShowRevert As Boolean
        Get
            Return Me._ShowRevert
        End Get
        Set(ByVal value As Boolean)
            Me._ShowRevert = value

            Me.KBSRevert.Visible = ((Me.KTextBox.Text <> Me.RevertText) And (Me._ShowRevert))
        End Set
    End Property

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
            If (Me.KChecked) Then
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
            If (Me.KChecked) Then
                Me.KTextBox.Text = value
            Else
                Me.TextValue2 = value
            End If
        End Set
    End Property

    Public Property TextBoxValue As String
        Get
            Return Me.KTextBox.Text
        End Get
        Set(ByVal value As String)
            Me.KTextBox.Text = value
        End Set
    End Property

    Public Property LabelText As String
        Get
            Return Me.KHeader.Text
        End Get
        Set(ByVal value As String)
            Me.KHeader.Text = value
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
            Return Me.KBSCheck.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.KBSCheck.Visible = value
        End Set
    End Property

    Public Property KChecked As Boolean
        Get
            If Me.KBSCheck.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Checked Then
                Return True
            Else
                Return False
            End If
        End Get
        Set(ByVal value As Boolean)
            If value = True Then
                Me.KBSCheck.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Checked
            Else
                Me.KBSCheck.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Unchecked
            End If
        End Set
    End Property

    Public Property LabelColor As Color
        Get
            Return Me.KHeader.StateCommon.Content.ShortText.Color1
        End Get
        Set(ByVal value As Color)
            Me.KHeader.StateCommon.Content.ShortText.Color1 = value
        End Set
    End Property

    Public Event AnyTextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event Text1Changed(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event Text2Changed(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Sub KTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles KTextBox.TextChanged
        Me.KBSClear.Visible = ((Me.TextBoxValue <> "") And (Me._ShowClear))

        If (Me.KChecked = True) Then
            If (Me.Value2Editable = True) Then
                Me.TextValue2 = Me.KTextBox.Text
                RaiseEvent Text2Changed(sender, e)
            Else
                Me.TextValue1 = Me.KTextBox.Text
                Me.KBSCheck.Checked = False

                Me.KBSRevert.Visible = ((Me.TextBoxValue <> Me.RevertText) And (Me.ShowRevert = True))

                RaiseEvent Text1Changed(sender, e)
            End If
        Else
            Me.TextValue1 = Me.KTextBox.Text

            Me.KBSRevert.Visible = ((Me.TextBoxValue <> Me.RevertText) And (Me.ShowRevert = True))

            RaiseEvent Text1Changed(sender, e)
        End If
        RaiseEvent AnyTextChanged(sender, e)
    End Sub

    Private Sub KCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles KBSCheck.Click
        If (Me.KChecked = True) Then
            Me.KTextBox.Text = Me.TextValue2
        Else
            Me.KTextBox.Text = Me.TextValue1
        End If
    End Sub

    Private Sub KCheckBox_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles KBSCheck.ButtonSpecPropertyChanged
        If (Me.AutoChangeTo1 = True And Me.KBSCheck.Visible = False) Then
            Me.KChecked = False
        End If
    End Sub

    Private Sub btnsc_revert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KBSRevert.Click
        Me.TextBoxValue = Me.RevertText
    End Sub

    Private Sub KBSClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles KBSClear.Click
        Me.TextBoxValue = ""
    End Sub
End Class
