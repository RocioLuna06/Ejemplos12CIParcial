Public Class frmTiempo

    Private Sub tmrHora_Tick(sender As Object, e As EventArgs) Handles tmrHora.Tick
        lbHora.Text = TimeOfDay
    End Sub

    Private Sub BtnMostrarHora_Click(sender As Object, e As EventArgs) Handles BtnMostrarHora.Click
        tmrHora.Enabled = True
    End Sub

    Private Sub BtnDetenerTiempo_Click(sender As Object, e As EventArgs) Handles BtnDetenerTiempo.Click
        tmrHora.Enabled = False
    End Sub
End Class