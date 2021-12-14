Imports Microsoft.AspNetCore.Mvc.ViewFeatures
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.IO


Public Class ControladorDatos


    Public Sub importarDatosEnBBDD()
        Dim thisDate As Date
        thisDate = #1/1/2021#
        Dim days As Integer
        days = DateDiff("d", thisDate, Now)

        Dim listOfDatos = New List(Of Datos)

        'Inicializar el bbdd manager
        Dim bbdd = New BBDD()
        'Lista de comunidades
        Dim listaComunidades = New List(Of Comunidad)
        listaComunidades = bbdd.listarComunidades()

        'Saltarte ese dato
        Dim skip As Boolean = False

        For index As Integer = 0 To days
            Dim dia As String = CStr(Format(thisDate.AddDays(index), "yyyyMMdd"))
            'Try
            Dim rutaDescarga As String = "C:\Users\apisabarro\Desktop\Git\introduccion-a-visual-basic-net\Proyecto\CovidVacunaApp\Datos\" & dia & ".json"



            If My.Computer.FileSystem.FileExists(rutaDescarga) Then
                Dim json As String = File.ReadAllText(rutaDescarga)

                Dim array = JArray.Parse(json)

                For i As Integer = 0 To array.Count - 1

                    'datos extraidos del json
                    Dim comunidad As Comunidad = Nothing
                    Dim ccaa As String = Nothing
                    If array.ElementAt(i).SelectToken("ccaa") IsNot Nothing Then
                        ccaa = array.ElementAt(i).SelectToken("ccaa")

                        'Buscar a que comunidad pertenece
                        For Each com As Comunidad In listaComunidades
                            If com.nombre = ccaa Then
                                comunidad = com
                                Exit For
                            End If
                        Next
                    End If
                    If comunidad Is Nothing Then
                        skip = True
                    End If


                    Dim dosisAdministradas As Double = Nothing
                    If array.ElementAt(i).SelectToken("dosisAdministradas") IsNot Nothing Then
                        dosisAdministradas = array.ElementAt(i).SelectToken("dosisAdministradas")
                    End If

                    Dim dosisEntregadas As Double = Nothing
                    If array.ElementAt(i).SelectToken("dosisEntregadas") IsNot Nothing Then
                        dosisEntregadas = array.ElementAt(i).SelectToken("dosisEntregadas")
                    End If

                    Dim dosisEntregadasModerna As Double = Nothing
                    If array.ElementAt(i).SelectToken("dosisEntregadasModerna") IsNot Nothing Then
                        dosisEntregadasModerna = array.ElementAt(i).SelectToken("dosisEntregadasModerna")
                    End If

                    Dim dosisEntregadasPfizer As Double = Nothing
                    If array.ElementAt(i).SelectToken("dosisEntregadasPfizer") IsNot Nothing Then
                        dosisEntregadasPfizer = array.ElementAt(i).SelectToken("dosisEntregadasPfizer")
                    End If

                    Dim dosisEntregadasAstrazeneca As Double = Nothing
                    If array.ElementAt(i).SelectToken("dosisEntregadasAstrazeneca") IsNot Nothing Then
                        dosisEntregadasAstrazeneca = array.ElementAt(i).SelectToken("dosisEntregadasAstrazeneca")
                    End If

                    Dim dosisPautaCompletada As Double = Nothing
                    If array.ElementAt(i).SelectToken("dosisPautaCompletada") IsNot Nothing Then
                        dosisPautaCompletada = array.ElementAt(i).SelectToken("dosisPautaCompletada")
                    End If

                    Dim porcentajeEntregadas As Double = Nothing
                    If array.ElementAt(i).SelectToken("porcentajeEntregadas") IsNot Nothing Then
                        porcentajeEntregadas = array.ElementAt(i).SelectToken("porcentajeEntregadas")
                    End If

                    Dim porcentajePoblacionAdministradas As Double = Nothing
                    If array.ElementAt(i).SelectToken("porcentajePoblacionAdministradas") IsNot Nothing Then
                        If Not (array.ElementAt(i).SelectToken("porcentajePoblacionAdministradas").ToString = "") Then
                            porcentajePoblacionAdministradas = array.ElementAt(i).SelectToken("porcentajePoblacionAdministradas")
                        End If
                    End If

                        Dim porcentajePoblacionCompletas As Double = Nothing
                    If array.ElementAt(i).SelectToken("porcentajePoblacionCompletas") IsNot Nothing Then
                        If Not (array.ElementAt(i).SelectToken("porcentajePoblacionCompletas").ToString = "") Then
                            porcentajePoblacionCompletas = array.ElementAt(i).SelectToken("porcentajePoblacionCompletas")
                        End If
                    End If

                    'fecha de los datos
                    Dim fecha As Date = Format(thisDate.AddDays(index), "dd/MM/yyyy")



                    If Not skip Then

                        'Inserción del objeto entero
                        Dim dato = New Datos(
                        dosisAdministradas,
                        dosisEntregadas,
                        dosisEntregadasModerna,
                        dosisEntregadasPfizer,
                        dosisEntregadasAstrazeneca,
                        dosisPautaCompletada,
                        porcentajeEntregadas,
                        porcentajePoblacionAdministradas,
                        porcentajePoblacionCompletas,
                        fecha, comunidad)
                        'dato.imprimir()


                        'inserto los datos en una lista
                        listOfDatos.Add(dato)

                    End If

                    skip = False

                Next


            End If

            'Catch ex As Exception
            'Para un futuro estaría bien implementar un fichero que marque que ficheros no se han descargado
            'Pero por el momento no vamos a añadir ninguna excepción
            'End Try
        Next

        'Ahora introducimos los datos en la bbdd

        For Each dato As Datos In listOfDatos
            bbdd.insertarDatos(dato)
            'dato.imprimir()
        Next

        'Mensaje de operación terminada
        MessageBox.Show("Operación realizada.")


    End Sub

    Public Sub descargarArchivos()
        Dim thisDate As Date
        thisDate = #1/1/2021#
        Dim days As Integer
        days = DateDiff("d", thisDate, Now)

        Dim texto As String = ""

        For index As Integer = 0 To days
            Dim dia As String = CStr(Format(thisDate.AddDays(index), "yyyyMMdd"))

            Try
                Dim url As String = "https://covid-vacuna.app/data/" & dia & ".json"
                Dim rutaDescarga As String = "C:\Users\apisabarro\Desktop\Git\introduccion-a-visual-basic-net\Proyecto\CovidVacunaApp\Datos\" & dia & ".json"

                If Not My.Computer.FileSystem.FileExists(rutaDescarga) Then
                    My.Computer.Network.DownloadFile(url, rutaDescarga)
                End If

            Catch ex As Exception
                'Para un futuro estaría bien implementar un fichero que marque que ficheros no se han descargado
                'Pero por el momento no vamos a añadir ninguna excepción
            End Try
        Next

        Dim todayDate As Date
        todayDate = Now

        Try
            Dim url As String = "https://covid-vacuna.app/data/latest.json"
            Dim rutaDescarga As String = "C:\Users\apisabarro\Desktop\Git\introduccion-a-visual-basic-net\Proyecto\CovidVacunaApp\Datos\" & CStr(Format(todayDate, "yyyyMMdd")) & ".json"

            If Not My.Computer.FileSystem.FileExists(rutaDescarga) Then
                My.Computer.Network.DownloadFile(url, rutaDescarga)
            End If


        Catch ex As Exception
            'Para un futuro estaría bien implementar un fichero que marque que ficheros no se han descargado
            'Pero por el momento no vamos a añadir ninguna excepción
        End Try


        MessageBox.Show("Proceso terminado.")

    End Sub

End Class
