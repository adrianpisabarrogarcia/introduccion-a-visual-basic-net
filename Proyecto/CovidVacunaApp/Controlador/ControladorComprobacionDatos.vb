Public Class ControladorComprobacionDatos

    Public Sub New()

    End Sub

    Public Function stringVacio(texto As String)
        If texto.Length = 0 Or texto = " " Then
            MessageBox.Show("El texto introducido está vacío.")
            Return True
        End If
        Return False
    End Function

End Class
