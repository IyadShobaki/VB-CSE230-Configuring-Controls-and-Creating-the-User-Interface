Public Class Form1
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        lblMouse.Text = "x= " + e.X.ToString() + ", y= " + e.Y.ToString()
    End Sub
End Class
