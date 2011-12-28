Public Class TVKryptonTextBox

    Private TextValue1 As String = ""
    Private TextValue2 As String = ""
    Private Value2Editable As Boolean = False
    Private AutoChangeTo1 As Boolean = True
    Private _RevertText As String

    Private _ShowClear As Boolean = True

    Private _ShowRevert As Boolean = True

    Private t_moving As Boolean = False

    Public Property OnlyNumerics As Boolean = False

    Public Property RevertText As String
        Get
            Return Me._RevertText
        End Get
        Set(ByVal value As String)
            If (Me.OnlyNumerics = True And value = "") Then
                Me._RevertText = "0"
            Else
                Me._RevertText = value
            End If

            Me.btnsc_revert.Visible = ((Me.TextBoxValue <> Me.RevertText) And (Me._ShowRevert = True))
        End Set
    End Property

    Public Property ShowClear As Boolean
        Get
            Return Me._ShowClear
        End Get
        Set(ByVal value As Boolean)
            Me._ShowClear = value

            Me.btnsc_clear.Visible = ((Me.TextBoxValue <> "") And (Me._ShowClear))
        End Set
    End Property

    Public Property ShowRevert As Boolean
        Get
            Return Me._ShowRevert
        End Get
        Set(ByVal value As Boolean)
            Me._ShowRevert = value

            Me.btnsc_revert.Visible = ((Me.TextBoxValue <> Me.RevertText) And (Me._ShowRevert = True))
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
            If Me.OnlyNumerics And Me.KTextBox.Text = "" Then
                Return 0
            Else
                Return Me.TextValue1
            End If
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
            If Me.OnlyNumerics And Me.KTextBox.Text = "" Then
                Return 0
            Else
                Return Me.TextValue2
            End If
        End Get
        Set(ByVal value As String)
            If (Me.KCheckBox.Checked) Then
                Me.KTextBox.Text = value
            Else
                Me.TextValue2 = value
            End If
        End Set
    End Property

    Public Property TextBoxValue As String
        Get
            If Me.OnlyNumerics And Me.KTextBox.Text = "" Then
                Return 0
            Else
                Return Me.KTextBox.Text
            End If
        End Get
        Set(ByVal value As String)
            Me.KTextBox.Text = value
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

    Public Property PropertyName As String

    Public Event AnyTextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event Text1Changed(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event Text2Changed(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Sub KTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles KTextBox.KeyPress
        If (Me.OnlyNumerics) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
                e.Handled = True
            End If
            If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub KTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles KTextBox.TextChanged
        Me.btnsc_clear.Visible = ((Me.TextBoxValue <> "") And (Me._ShowClear))

        If (Me.KCheckBox.Checked = True) Then
            If (Me.Value2Editable = True) Then
                Me.TextValue2 = Me.KTextBox.Text
                RaiseEvent Text2Changed(sender, e)
            Else
                Me.TextValue1 = Me.KTextBox.Text
                Me.KCheckBox.Checked = False

                Me.btnsc_revert.Visible = ((Me.TextBoxValue <> Me.RevertText) And (Me.ShowRevert = True))

                RaiseEvent Text1Changed(sender, e)
            End If
        Else
            Me.TextValue1 = Me.KTextBox.Text

            Me.btnsc_revert.Visible = ((Me.TextBoxValue <> Me.RevertText) And (Me.ShowRevert = True))

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

    Private Sub ButtonSpecAny1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsc_clear.Click
        If (Me.OnlyNumerics) Then
            Me.TextBoxValue = "0"
        Else
            Me.TextBoxValue = ""
        End If
    End Sub

    Private Sub btnsc_revert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsc_revert.Click
        Me.TextBoxValue = Me.RevertText
    End Sub



    Private Sub KLabel_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles KLabel.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.t_moving = True
        End If
    End Sub

    Private Sub KTextBox_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles KTextBox.DragDrop
        If e.Data.GetDataPresent(DataFormats.Text) Then
            Me.TextBoxValue = e.Data.GetData(DataFormats.Text)
        ElseIf (e.Data.GetDataPresent(DataFormats.FileDrop)) Then

            Dim music As Boolean = False
            Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            For Each _File As String In filePaths

                If (frm_main.MusicFormats.Contains(My.Computer.FileSystem.GetFileInfo(_File).Extension)) Then

                    Dim tempMeta As MusicFile = New MusicFile(_File)
                    Me.TextBoxValue = CallByName(tempMeta, Me.PropertyName, CallType.Get)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub KTextBox_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles KTextBox.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            If (Me.OnlyNumerics) Then
                Dim text As String = e.Data.GetData(DataFormats.Text)

                If (Not Integer.TryParse(e.Data.GetData(DataFormats.Text), Nothing)) Then
                    e.Effect = DragDropEffects.None
                Else
                    e.Effect = DragDropEffects.Copy
                End If
            Else
                e.Effect = DragDropEffects.Copy
            End If
        ElseIf (e.Data.GetDataPresent(DataFormats.FileDrop) And Me.PropertyName <> "") Then
            Dim music As Boolean = False
            Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            For Each _File As String In filePaths
                If (frm_main.MusicFormats.Contains(My.Computer.FileSystem.GetFileInfo(_File).Extension)) Then
                    e.Effect = DragDropEffects.Copy
                    music = True
                    Exit For
                End If
            Next
            If (music = False) Then
                e.Effect = DragDropEffects.None
            End If
        Else
                e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub KLabel_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles KLabel.MouseMove
        If (Me.t_moving) Then
            Dim dta = New DataObject()
            dta.SetData(DataFormats.Text, Me.TextBoxValue)
            DoDragDrop(dta, DragDropEffects.Copy)
            Me.t_moving = False
        End If
    End Sub
End Class
