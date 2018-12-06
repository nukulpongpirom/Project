Public Class frm1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'ค่าจ้าง = ชั่วโมงการทำงาน * อันตราค่าจ้างต่อชั่วโมง
        'ชั่วโมงการทำงาน => txthours.text
        'อัตราค่าจ้างต่อชั่วโมง => txtPayrate.text
        'ค่าจ้าง => lbltotal.text
        Label6.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
        Label7.Text = Val(Label6.Text) * 3 / 100
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()


    End Sub



End Class
