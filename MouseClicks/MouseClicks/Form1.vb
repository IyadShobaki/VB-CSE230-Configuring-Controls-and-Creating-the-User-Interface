Public Class Form1
    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                MessageBox.Show("Left button clicked")
            Case Windows.Forms.MouseButtons.Right
                MessageBox.Show("Right button clicked")
            Case Windows.Forms.MouseButtons.Middle
                MessageBox.Show("Middle button clicked")

        End Select
        MessageBox.Show("Mouse is at location " & e.X.ToString() & "," & e.Y.ToString())
    End Sub
End Class
