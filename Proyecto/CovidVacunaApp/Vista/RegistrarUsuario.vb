Public Class RegistrarUsuario
    Private Sub bAtras_Click(sender As Object, e As EventArgs) Handles bAtras.Click
        Me.Hide()
        InicioSesion.Show()
    End Sub

    Private Sub bRegistrarUsuario_Click(sender As Object, e As EventArgs) Handles bRegistrarUsuario.Click
        Dim usuario As New Usuario(tbNombre.Text, tbUsuario.Text, tbPassword.Text)
        Dim errores As Boolean = False
        Dim erroresDatos As New ControladorComprobacionDatos
        errores = erroresDatos.registroUsuarioValidacion(usuario)

        If Not errores Then
            Dim controladorUsuario As New ControladorUsuario
            controladorUsuario.registrarUsuario(usuario)
        End If

        tbNombre.Text = ""
        tbUsuario.Text = ""
        tbPassword.Text = ""

    End Sub
End Class