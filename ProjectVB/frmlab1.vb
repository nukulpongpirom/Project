Public Class frmlab1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label2.Text = TextBox1.Text * 12
        
        Label3.Text = Val(Label2.Text) * 5 / 100
        Label7.Text = Label2.Text - Label3.Text
       
    End Sub
End Class