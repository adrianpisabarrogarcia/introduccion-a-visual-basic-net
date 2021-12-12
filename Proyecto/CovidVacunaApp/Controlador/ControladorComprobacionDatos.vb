Public Class ControladorComprobacionDatos

    Public Sub New()

    End Sub

    Public Function stringVacio(texto As String)
        If texto.Length = 0 Or texto = " " Then
            Return True
        End If
        Return False
    End Function

    Public Function iniciarSesionUsuarioValidacion(user As String, password As String)
        Dim errores As Boolean = False

        errores = stringVacio(user)
        errores = stringVacio(password)
        If errores Then
            MessageBox.Show("Inicio de sesión incorrecto, rellene todos los campos")
        End If

        Return errores
    End Function

    Public Function registroUsuarioValidacion(user As Usuario)
        Dim errores As Boolean = False

        errores = stringVacio(user.nombre)
        errores = stringVacio(user.password)
        errores = stringVacio(user.nombre)

        If errores Then
            MessageBox.Show("Registro incorrecto, rellene todos los campos")
        End If

        Return errores
    End Function



End Class
