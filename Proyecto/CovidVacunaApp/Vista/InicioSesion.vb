Public Class InicioSesion
    Private Sub bRegistrarse_Click(sender As Object, e As EventArgs) Handles bRegistrarse.Click

        MsgBox("Hola")


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexionBBDD = New BBDD
        conexionBBDD.InicializarConexion()
        conexionBBDD.Conectar()
        conexionBBDD.Desconectar()

    End Sub
End Class
