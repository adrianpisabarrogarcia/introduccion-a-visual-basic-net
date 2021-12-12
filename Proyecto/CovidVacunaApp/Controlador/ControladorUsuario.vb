Public Class ControladorUsuario


    Public Sub registrarUsuario(user As Usuario)
        user.password = encriptarPassword(user.password)

        Dim bbdd = New BBDD
        bbdd.registrarUsuario(user)
    End Sub

    Public Function accederUsuario(usuario As String, password As String)

        password = encriptarPassword(password)
        Dim passwordUsuarioConcreto As String = obtenerPasswordUsuarioConcreto(usuario)

        If password = passwordUsuarioConcreto Then
            Return True
        End If
        Return False

    End Function

    Public Function obtenerPasswordUsuarioConcreto(user As String)
        Dim listaUsuarios = New List(Of Usuario)
        Dim baseDatos As New BBDD()
        listaUsuarios = baseDatos.listarUsuarios()

        Dim password As String = ""
        For Each usuario As Usuario In listaUsuarios
            If usuario.usuario = user Then
                Return usuario.password
            End If
        Next
        Return ""


    End Function


    Public Function encriptarPassword(ByVal strPwd As String) As String
        Dim i As Integer, C As Integer
        Dim strBuff As String = ""
        Dim strText As String = "12345Abcde"

        strPwd = UCase$(strPwd)

        'Encrypt string
        If Len(strPwd) > 0 Then
            For i = 1 To Len(strText)
                C = Asc(Mid$(strText, i, 1))
                C += Asc(Mid$(strPwd, (i Mod Len(strPwd)) + 1, 1))
                strBuff &= Chr(C And &HFF)
            Next i
        Else
            strBuff = strText
        End If
        Return strBuff
    End Function

    'Esta función no hace falta utilizarla, es solo a modo de información
    'para desencriptar una contraseña
    Public Function desencriptarPassword(ByVal strPwd As String) As String
        Dim i As Integer, C As Integer
        Dim strBuff As String = ""
        Dim strText As String = "12345Abcde"

        strPwd = UCase$(strPwd)

        'Decrypt string
        If Len(strPwd) > 0 Then
            For i = 1 To Len(strText)
                C = Asc(Mid$(strText, i, 1))
                C -= Asc(Mid$(strPwd, (i Mod Len(strPwd)) + 1, 1))
                strBuff &= Chr(C And &HFF)
            Next i
        Else
            strBuff = strText
        End If
        Return strBuff
    End Function



End Class
