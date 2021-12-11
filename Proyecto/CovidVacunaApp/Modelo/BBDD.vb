Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class BBDD
    Dim conexion As MySqlConnection

    Public Sub New()

    End Sub

    'Inicializar todos los datos de la base de datos
    Public Sub inicializarConexion()
        'Datos
        Dim servidor As String = "127.0.0.1"
        Dim usuario As String = "root"
        Dim pswd As String = ""
        Dim baseDeDatos As String = "covidvacunaapp"

        'Inicializar la Conexión
        conexion = New MySqlConnection()
        conexion.ConnectionString = "server=" & servidor & ";" & "database=" & baseDeDatos & ";" & "user id=" & usuario & ";" & "password=" & pswd & ";"

    End Sub

    'Para Conectarte a la base de datos
    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conectado al servidor de bbdd")
        Catch ex As MySqlException
            MessageBox.Show("Problemas al conectar al servidor de bbdd")
        End Try
    End Sub

    'Para desconectarte de la base de datos
    Public Sub desconectar()
        Try
            conexion.Close()
            MessageBox.Show("Desconectado del servidor de bbdd")
        Catch ex As MySqlException
            MessageBox.Show("Problemas al desconectarse del servidor de bbdd")
        End Try

    End Sub





    ''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' FUNCIONES DE BBDD
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Sub registrarUsuario(user As Usuario)
        Dim query As String = "INSERT INTO usuario (name, user, password)
                                VALUES ('" & user.nombre & "', '" & user.usuario & "', '" & user.password & "'); "
        conectar()

        Try
            Dim cmd = New MySqlCommand(query, conexion)
            cmd.ExecuteNonQuery()
            'para devolver datos:
            'MySqlDataReader rdr = cmd.ExecuteReader();


        Catch ex As Exception
            MessageBox.Show("Error registrando un usuario")
        End Try


        desconectar()

    End Sub








End Class
