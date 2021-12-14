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

    Public Function listarComunidades()
        Dim query As String = "SELECT * FROM comunidad;"
        conectar()


        Try
            Dim cmd = New MySqlCommand(query, conexion)
            Dim dr As MySqlDataReader
            Dim dt As New DataTable
            dr = cmd.ExecuteReader()
            dt.Load(dr)

            Dim ListOfComunidades = New List(Of Comunidad)

            For Each row As DataRow In dt.Rows

                Dim id As Integer = Integer.Parse(row("id"))
                Dim nombre As String = CStr(row("nombre"))

                Dim comunidad As New Comunidad(id, nombre)

                ListOfComunidades.Add(comunidad)
            Next
            desconectar()


            Return ListOfComunidades

        Catch ex As MySqlException
            MessageBox.Show("Error sacando el listado de comunidades")
        End Try

        Return 0

    End Function







    '''''''''''''''''''''''''''''''''''''
    ' DATOS - BBDD
    '''''''''''''''''''''''''''''''''''''

    Public Sub insertarDatos(dato As Datos)
        Dim query As String = ""
        'MessageBox.Show(Format(dato.fecha, "yyyy-MM-dd").ToString())
        Try
            query = "INSERT INTO datos (comunidad_id, dosisAdministradas, dosisEntregadas, dosisEntregadasModerna, dosisEntregadasPfizer, dosisEntregadasAstrazeneca, dosisPautaCompletada, porcentajeEntregadas, porcentajePoblacionAdministradas, porcentajePoblacionCompletas, fecha)
                                    VALUES ('" & dato.comunidad.id & "', '" & dato.dosisAdministradas & "', '" & dato.dosisEntregadas & "', '" & dato.dosisEntregadasModerna & "', '" & dato.dosisEntregadasPfizer & "', '" & dato.dosisEntregadasAstrazeneca & "', '" & dato.dosisPautaCompletada & "', '" & dato.porcentajeEntregadas * 100 & "', '" & dato.porcentajePoblacionAdministradas * 100 & "', '" & dato.porcentajePoblacionCompletas * 100 & "', '" & Format(dato.fecha, "yyyy-MM-dd").ToString() & "'); "

        Catch ex As Exception
            dato.imprimir()
        End Try


        conectar()

        Try
            Dim cmd = New MySqlCommand(query, conexion)
            cmd.ExecuteNonQuery()
            'para devolver datos:
            'MySqlDataReader rdr = cmd.ExecuteReader();
            'MessageBox.Show("Usuario registrado")
        Catch ex As Exception
            MessageBox.Show("Error insertando un dato")
        End Try


        desconectar()
    End Sub


    Public Sub eliminarDato(id As Integer)
        Dim query As String = " DELETE FROM datos WHERE id = " & id & ";"

        conectar()

        Try
            Dim cmd = New MySqlCommand(query, conexion)
            cmd.ExecuteNonQuery()
            'para devolver datos:
            'MySqlDataReader rdr = cmd.ExecuteReader();
            'MessageBox.Show("Usuario registrado")
        Catch ex As Exception
            MessageBox.Show("Error eliminarndo un dato")
        End Try

        desconectar()
    End Sub

    Public Sub modificarDato(dato As Datos)


        Dim query As String = "UPDATE datos
                                SET fecha = '" & Format(dato.fecha, "yyyy-MM-dd") & "', 
                                dosisAdministradas = '" & dato.dosisAdministradas & "', 
                                dosisEntregadas = '" & dato.dosisEntregadas & "', 
                                dosisEntregadasModerna = '" & dato.dosisEntregadasModerna & "', 
                                dosisEntregadasPfizer = '" & dato.dosisEntregadasPfizer & "', 
                                dosisEntregadasAstrazeneca = '" & dato.dosisEntregadasAstrazeneca & "', 
                                dosisPautaCompletada = '" & dato.dosisPautaCompletada & "', 
                                porcentajeEntregadas = '" & dato.porcentajeEntregadas & "', 
                                porcentajePoblacionAdministradas = '" & dato.porcentajePoblacionAdministradas & "', 
                                porcentajePoblacionCompletas = '" & dato.porcentajePoblacionCompletas & "' 
                                WHERE id = " & dato.id & "; "

        conectar()

        Try
            Dim cmd = New MySqlCommand(query, conexion)
            cmd.ExecuteNonQuery()
            'para devolver datos:
            'MySqlDataReader rdr = cmd.ExecuteReader();
            'MessageBox.Show("Usuario registrado")
        Catch ex As Exception
            MessageBox.Show("Error modificando un dato")
        End Try

        desconectar()
    End Sub

    'truncate datos
    Public Sub eliminarTodosDatos()
        Dim query As String = "TRUNCATE TABLE datos;"

        conectar()

        Try
            Dim cmd = New MySqlCommand(query, conexion)
            cmd.ExecuteNonQuery()
            'para devolver datos:
            'MySqlDataReader rdr = cmd.ExecuteReader();
            'MessageBox.Show("Usuario registrado")
        Catch ex As Exception
            MessageBox.Show("Error eliminarndo todos los datos")
        End Try

        desconectar()
    End Sub

    Public Function obtenerDatosConFechaComunidadConcretos(comunidadID As Integer, fecha As Date)
        Dim query As String = "SELECT * FROM datos WHERE fecha = '" & Format(fecha, "yyyy-MM-dd").ToString() & "' AND comunidad_id = '" & comunidadID & "' ;"

        If comunidadID = 0 Then
            query = "SELECT * FROM datos WHERE fecha = '" & Format(fecha, "yyyy-MM-dd").ToString() & "' ;"
        End If
        conectar()


        Try
            Dim cmd = New MySqlCommand(query, conexion)
            Dim dr As MySqlDataReader
            Dim dt As New DataTable
            dr = cmd.ExecuteReader()
            dt.Load(dr)

            Dim ListOfData = New List(Of Datos)
            Dim ListOfCommunities = listarComunidades()


            For Each row As DataRow In dt.Rows

                Dim id As Integer = Integer.Parse(row("id"))
                Dim dosisAdministradas As Double = Double.Parse(row("dosisAdministradas"))
                Dim dosisEntregadas As Double = Double.Parse(row("dosisEntregadas"))
                Dim dosisEntregadasModerna As Double = Double.Parse(row("dosisEntregadasModerna"))
                Dim dosisEntregadasPfizer As Double = Double.Parse(row("dosisEntregadasPfizer"))
                Dim dosisEntregadasAstrazeneca As Double = Double.Parse(row("dosisEntregadasAstrazeneca"))
                Dim dosisPautaCompletada As Double = Double.Parse(row("dosisPautaCompletada"))
                Dim porcentajeEntregadas As Double = Double.Parse(row("porcentajeEntregadas"))
                Dim porcentajePoblacionAdministradas As Double = Double.Parse(row("porcentajePoblacionAdministradas"))
                Dim porcentajePoblacionCompletas As Double = Double.Parse(row("porcentajePoblacionCompletas"))
                Dim dateBBDD As Date = CDate(CStr(row("fecha")))
                Dim comunidadIdBBDD As Integer = Integer.Parse(row("comunidad_id"))

                Dim comunidad = Nothing

                For Each com As Comunidad In ListOfCommunities
                    If com.id = comunidadIdBBDD Then
                        comunidad = New Comunidad(com.id, com.nombre)
                        Exit For
                    End If
                Next


                Dim dato As New Datos(id, dosisAdministradas, dosisEntregadas, dosisEntregadasModerna,
                                      dosisEntregadasPfizer, dosisEntregadasAstrazeneca,
                                      dosisPautaCompletada, porcentajeEntregadas, porcentajePoblacionAdministradas,
                                      porcentajePoblacionCompletas, dateBBDD, comunidad)

                'dato.imprimir()
                ListOfData.Add(dato)
            Next
            desconectar()


            Return ListOfData

        Catch ex As MySqlException
            MessageBox.Show("Error sacando el listado de datos concretos")
        End Try

        Return Nothing
    End Function

    Public Function getDato(id As Integer)
        Dim query As String = ""

        query = "SELECT * FROM datos WHERE id = '" & id & "' ;"
        conectar()

        Try
            Dim cmd = New MySqlCommand(query, conexion)
            Dim dr As MySqlDataReader
            Dim dt As New DataTable
            dr = cmd.ExecuteReader()
            dt.Load(dr)

            Dim ListOfCommunities = listarComunidades()


            For Each row As DataRow In dt.Rows

                Dim idBBDD As Integer = Integer.Parse(row("id"))
                Dim dosisAdministradas As Double = Double.Parse(row("dosisAdministradas"))
                Dim dosisEntregadas As Double = Double.Parse(row("dosisEntregadas"))
                Dim dosisEntregadasModerna As Double = Double.Parse(row("dosisEntregadasModerna"))
                Dim dosisEntregadasPfizer As Double = Double.Parse(row("dosisEntregadasPfizer"))
                Dim dosisEntregadasAstrazeneca As Double = Double.Parse(row("dosisEntregadasAstrazeneca"))
                Dim dosisPautaCompletada As Double = Double.Parse(row("dosisPautaCompletada"))
                Dim porcentajeEntregadas As Double = Double.Parse(row("porcentajeEntregadas"))
                Dim porcentajePoblacionAdministradas As Double = Double.Parse(row("porcentajePoblacionAdministradas"))
                Dim porcentajePoblacionCompletas As Double = Double.Parse(row("porcentajePoblacionCompletas"))
                Dim dateBBDD As Date = CDate(CStr(row("fecha")))
                Dim comunidadIdBBDD As Integer = Integer.Parse(row("comunidad_id"))

                Dim comunidad = Nothing

                For Each com As Comunidad In ListOfCommunities
                    If com.id = comunidadIdBBDD Then
                        comunidad = New Comunidad(com.id, com.nombre)
                        Exit For
                    End If
                Next


                Dim dato As New Datos(idBBDD, dosisAdministradas, dosisEntregadas, dosisEntregadasModerna,
                                      dosisEntregadasPfizer, dosisEntregadasAstrazeneca,
                                      dosisPautaCompletada, porcentajeEntregadas, porcentajePoblacionAdministradas,
                                      porcentajePoblacionCompletas, dateBBDD, comunidad)

                Return dato

            Next
            desconectar()



        Catch ex As MySqlException
            MessageBox.Show("Error sacando el un dato")
        End Try

        Return 0
    End Function

End Class
