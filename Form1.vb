Public Class Form1
    Private Sub btnprocesar_Click(sender As Object, e As EventArgs) Handles btnprocesar.Click
        Dim ntabla, i As Int64
        ntabla = txtntabla.Text
        i = 1

        IstTablas.Items.Clear()
        Do While i <= 10
            IstTablas.Items.Add(ntablas.ToString() + "X" + i.ToString() + "=" + (ntabla * 1).ToString)
            i = i + 1
        Loop
    End Sub
End Class
