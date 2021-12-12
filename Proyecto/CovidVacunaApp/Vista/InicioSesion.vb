Public Class InicioSesion
    Private Sub bRegistrarse_Click(sender As Object, e As EventArgs) Handles bRegistrarse.Click
        RegistrarUsuario.Show()
        Me.Hide()

    End Sub

    Private Sub bAcceder_Click(sender As Object, e As EventArgs) Handles bAcceder.Click
        Dim errores As Boolean = False

        Dim comprobarStrings = New ControladorComprobacionDatos
        errores = comprobarStrings.iniciarSesionUsuarioValidacion(tbUser.Text, tbPassword.Text)

        If Not errores Then
            Dim controladorUsuario As New ControladorUsuario
            If controladorUsuario.accederUsuario(tbUser.Text, tbPassword.Text) Then
                Me.Hide()
                DatosCovid.Show()
            Else
                MessageBox.Show("Datos introducidos erróneos")
            End If
        End If



    End Sub





End Class
