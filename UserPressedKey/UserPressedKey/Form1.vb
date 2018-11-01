Public Class Form1
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        lblInfo.Text = ""
        If e.Alt Then
            lblInfo.Text &= "Alt: Yes" & vbCrLf
        Else
            lblInfo.Text &= "Alt: No" & vbCrLf
        End If
        If e.Shift Then
            lblInfo.Text &= "Shift: Yes" & vbCrLf
        Else
            lblInfo.Text &= "Shift: No" & vbCrLf
        End If
        If e.Control Then
            lblInfo.Text &= "Ctrl: Yes" & vbCrLf
        Else
            lblInfo.Text &= "Ctrl: No" & vbCrLf
        End If
        lblInfo.Text &= "KeyCode: " & e.KeyCode.ToString & vbCrLf & "KeyData: " & e.KeyData.ToString & vbCrLf & "KeyValue: " & e.KeyValue

    End Sub

    ' You can do in separate labels if you like:(not demonstrated in class) // see lecture(pdf)1
End Class
