Public Class Question
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Show()
        Label8.Text = RichTextBox2.Text

    End Sub

    Private Sub Question_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("Class Project. No browser Support availabe. SoRRy!!!!!!!", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Class Project. No browser Support availabe. SoRRy!!!!!!!", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Class Project. No browser Support availabe. SoRRy!!!!!!!", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
