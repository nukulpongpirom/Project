Public Class frmlab2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim vistra, computer, sum As Long
        vistra = Val(TextBox1.Text) * 5 / 100
        computer = Val(TextBox2.Text) * 10 / 100
        sum = Val(TextBox1.Text) + Val(TextBox2.Text)
        Label5.Text = sum
        Label6.Text = vistra + computer

    End Sub
End Class