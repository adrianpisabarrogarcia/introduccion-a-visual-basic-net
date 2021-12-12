Imports MySql
Imports MySql.Data.MySqlClient

Public Class BBDD
    Dim conexion As MySqlConnection

    Public Sub New()

    End Sub

    'Inicializar todos los datos de la base de datos
    Public Sub inicializarConexion()
        Try
            'Datos
            Dim servidor As String = "127.0.0.1"
            Dim usuario As String = "root"
            Dim pswd As String = ""
            Dim baseDeDatos As String = "covidvacunaapp"

            'Inicializar la Conexión
            conexion = New MySqlConnection()
            conexion.ConnectionString = "server=" & servidor & ";" & "database=" & baseDeDatos & ";" & "user id=" & usuario & ";" & "password=" & pswd & ";"
        Catch ex As Exception
            MessageBox.Show("Error inicilizando conexión")
        End Try


    End Sub

    'Para Conectarte a la base de datos
    Public Sub conectar()
        Try
            inicializarConexion()
            conexion.Open()
            'MessageBox.Show("Conectado al servidor de bbdd")
        Catch ex As MySqlException
            MessageBox.Show("Problemas al conectar al servidor de bbdd")
        End Try
    End Sub

    'Para desconectarte de la base de datos
    Public Sub desconectar()
        Try
            conexion.Close()
            'MessageBox.Show("Desconectado del servidor de bbdd")
        Catch ex As MySqlException
            MessageBox.Show("Problemas al desconectarse del servidor de bbdd")
        End Try

    End Sub





    ''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' FUNCIONES DE BBDD
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''

    '''''''''''''''''''''''''''''''''''''
    ' USUARIOS - BBDD
    '''''''''''''''''''''''''''''''''''''

    Public Sub registrarUsuario(user As Usuario)
        Dim query As String = "INSERT INTO usuario (name, user, password)
                                VALUES ('" & user.nombre & "', '" & user.usuario & "', '" & user.password & "'); "
        conectar()

        Try
            Dim cmd = New MySqlCommand(query, conexion)
            cmd.ExecuteNonQuery()
            'para devolver datos:
            'MySqlDataReader rdr = cmd.ExecuteReader();
            MessageBox.Show("Usuario registrado")
        Catch ex As Exception
            MessageBox.Show("Error registrando un usuario")
        End Try

        desconectar()
    End Sub

    Public Function listarUsuarios()
        Dim query As String = "SELECT * FROM usuario;"
        conectar()


        Try
            Dim cmd = New MySqlCommand(query, conexion)
            Dim dr As MySqlDataReader
            Dim dt As New DataTable
            dr = cmd.ExecuteReader()
            dt.Load(dr)

            Dim ListOfUsers = New List(Of Usuario)

            For Each row As DataRow In dt.Rows

                Dim id As Integer = Integer.Parse(row("id"))
                Dim nombre As String = CStr(row("name"))
                Dim usuario As String = CStr(row("user"))
                Dim pass As String = CStr(row("password"))

                Dim user As New Usuario(id, nombre, usuario, pass)

                ListOfUsers.Add(user)
            Next
            desconectar()


            Return ListOfUsers

        Catch ex As MySqlException
            MessageBox.Show("Error sacando el listado de los usuarios")
        End Try

        Return 0

    End Function

    Public Function getUsuarioConcreto(usuarioEnBBDD As String)
        Dim query As String = "SELECT * FROM usuario WHERE user = '" & usuarioEnBBDD & "';"
        conectar()


        Try
            Dim cmd = New MySqlCommand(query, conexion)
            Dim dr As MySqlDataReader
            Dim dt As New DataTable
            dr = cmd.ExecuteReader()
            dt.Load(dr)


            For Each row As DataRow In dt.Rows

                Dim id As Integer = Integer.Parse(row("id"))
                Dim nombre As String = CStr(row("name"))
                Dim usuario As String = CStr(row("user"))
                Dim pass As String = CStr(row("password"))

                Dim user = New Usuario(id, nombre, usuario, pass)
                desconectar()

                Return user
            Next

            desconectar()
            Return Nothing

        Catch ex As MySqlException
            MessageBox.Show("Error sacando el un usuario")
        End Try

        Return 0

    End Function



    '''''''''''''''''''''''''''''''''''''
    ' COMUNIDADES - BBDD
    '''''''''''''''''''''''''''''''''''''





    '''''''''''''''''''''''''''''''''''''
    ' DATOS - BBDD
    '''''''''''''''''''''''''''''''''''''






End Class
