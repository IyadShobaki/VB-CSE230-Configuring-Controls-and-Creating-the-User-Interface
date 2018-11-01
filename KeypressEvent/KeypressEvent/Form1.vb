Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57) Then
            MessageBox.Show(("Form.KeyPress: '" + e.KeyChar.ToString() + "' pressed."))
            Select Case e.KeyChar
                Case ChrW(49), ChrW(52), ChrW(55)
                    MessageBox.Show(("Form.KeyPress: '" + e.KeyChar.ToString() + "' consumed."))
                    e.Handled = True
            End Select
        End If
    End Sub
End Class
