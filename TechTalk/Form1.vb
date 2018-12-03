Public Class Form1
    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub textBox1_TextChanged(sender As Object, e As EventArgs) Handles textBox1.TextChanged

    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        My.Forms.login.Text = Now.ToString
        My.Forms.login.Show()

    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        My.Forms.login.Text = Now.ToString
        My.Forms.login.Show()
    End Sub

    Private Sub btnAsk_Click(sender As Object, e As EventArgs) Handles btnAsk.Click
        Panel6.Show()
        Panel9.Hide()
        Panel7.Hide()
        Question1.BringToFront()


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel9.Hide()
        Panel7.Hide()

    End Sub

    Private Sub btnDis_Click(sender As Object, e As EventArgs) Handles btnDis.Click
        Panel6.Hide()
        Panel7.Hide()
        Panel9.Show()
        Discussion1.BringToFront()
    End Sub

    Private Sub btnUsr_Click(sender As Object, e As EventArgs) Handles btnUsr.Click
        Panel6.Hide()
        Panel7.Show()
        Panel9.Hide()
        Cummunity1.BringToFront()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Panel6.Show()
        Panel9.Hide()
        Panel7.Hide()
        Question1.BringToFront()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel6.Hide()
        Panel7.Hide()
        Panel9.Show()
        Discussion1.BringToFront()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel6.Hide()
        Panel7.Show()
        Panel9.Hide()
        Cummunity1.BringToFront()
    End Sub
End Class
