Public Class frmAcceso

    Function validar_Password()
        If (txtNombreUser.Text = "Supervisor" And txtPassword.Text = "456") Then
            MsgBox("Bienvenido",, "Medikalsistem23")
            Me.Hide()
            frmMenuPrincipal.Show()
            txtNombreUser.BackColor = Color.White
            txtPassword.BackColor = Color.White
        Else
            MsgBox("Usuario y contraseña incorrectos", "Medykalsystem23")
            txtNombreUser.Text = ""
            txtPassword.Text = ""
            txtNombreUser.BackColor = Color.Violet
            txtPassword.BackColor = Color.Violet

        End If
    End Function
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        validar_Password()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        End
    End Sub


    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            validar_Password()
        End If
    End Sub
End Class