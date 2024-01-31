Public Class FormConverter

    Const KM2MI = 1.609344
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Try
            txtMiles.Text = txtKilometres.Text / KM2MI
        Catch ex As Exception
            'MsgBox("Tekkis viga!", MsgBoxStyle.Critical, "Kõik on katki")
            txtMiles.Text = "Tekkis viga"
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtKilometres.TextChanged

    End Sub

    Private Sub FormConverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
