Public Class Form1

    Private Sub MULTIPLY_Click(sender As Object, e As EventArgs) Handles MULTIPLY.Click
        Dim a As Integer
        Dim b As Integer
        a = txtFirstNum.Text
        b = txtSecNum.Text
        lblResult.Text = a * b
    End Sub
End Class
