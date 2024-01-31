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
        TimerClock.Interval = 1000
        TimerClock.Enabled = True

    End Sub

    Private Sub SulgeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SulgeToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub lblClock_Click(sender As Object, e As EventArgs) Handles lblClock.Click
        TimerClock.Enabled = Not TimerClock.Enabled
        lblClock.Text = "Meow"
    End Sub

    Private Sub TimerClock_Tick(sender As Object, e As EventArgs) Handles TimerClock.Tick
        lblClock.Text = DateTime.Now
    End Sub
End Class
