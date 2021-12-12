Public Class Usuario

    Property id As Integer
    Property nombre As String
    Property usuario As String
    Property password As String

    Public Sub New(nombre As String, usuario As String, password As String)
        Me.nombre = nombre
        Me.usuario = usuario
        Me.password = password
    End Sub

    Public Sub New(id As Integer, nombre As String, usuario As String, password As String)
        Me.id = id
        Me.nombre = nombre
        Me.usuario = usuario
        Me.password = password
    End Sub

    Public Sub registrar(user As Usuario)
        user.password = encriptarPassword(user.password)

        Dim bbdd = New BBDD
        bbdd.registrarUsuario(user)
    End Sub

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
