Imports MySql.Data.MySqlClient




Public Class BBDD
    Dim conexion As MySqlConnection

    Public Sub New()

    End Sub

    'Inicializar todos los datos de la base de datos
    Public Sub InicializarConexion()
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
    Public Sub Conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conectado al servidor de bbdd")
        Catch ex As MySqlException
            MessageBox.Show("Problemas al conectar al servidor de bbdd")
        End Try
    End Sub

    'Para desconectarte de la base de datos
    Public Sub Desconectar()
        Try
            conexion.Close()
            MessageBox.Show("Desconectado del servidor de bbdd")
        Catch ex As MySqlException
            MessageBox.Show("Problemas al desconectarse del servidor de bbdd")
        End Try

    End Sub








End Class
