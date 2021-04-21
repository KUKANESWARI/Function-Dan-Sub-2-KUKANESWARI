Public Class Form1
    Private Sub S1()
        Label1.Text = "Hi KUKANESWARI"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        S1()
    End Sub
    Private Sub S2()

        Dim strText As String
        strText = TextBox1.Text
        Label2.Text = strText
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        S2()
    End Sub
    Private Function S3()
        Label3.Text = "18DDT19F1106"
        Return Label3
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        S3()
    End Sub
    Private Function S4()
        Dim strText2 As String
        strText2 = TextBox2.Text
        Label4.Text = strText2
        Return Label4
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        S4()
    End Sub
End Class
