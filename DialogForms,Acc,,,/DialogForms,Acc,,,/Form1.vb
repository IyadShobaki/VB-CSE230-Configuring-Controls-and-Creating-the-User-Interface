Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New Form2
        Dim result As DialogResult
        result = frm.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            MessageBox.Show("OK Selected")
        Else
            MessageBox.Show("Cancel Selected")
        End If
    End Sub



    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LinkLabel1.LinkVisited = True
        System.Diagnostics.Process.Start("www.Google.com")
        System.Diagnostics.Process.Start("Notepad.exe")
    End Sub
End Class
