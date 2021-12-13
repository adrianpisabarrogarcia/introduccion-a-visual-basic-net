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

        For index As Integer = 0 To days
            Dim dia As String = CStr(Format(thisDate.AddDays(index), "yyyyMMdd"))
            'Try
            Dim rutaDescarga As String = "C:\Users\apisabarro\Desktop\Git\introduccion-a-visual-basic-net\Proyecto\CovidVacunaApp\Datos\" & dia & ".json"



            If My.Computer.FileSystem.FileExists(rutaDescarga) Then
                Dim json As String = File.ReadAllText(rutaDescarga)
                'Dim jsonres = JToken.Parse(json)
                'MessageBox.Show(jsonres.First().ToString)
                'MessageBox.Show(jsonres.Type)
                'Dim andalucia = jsonres.First().SelectToken("ccaa").ToString
                'MessageBox.Show(andalucia)

                Dim array = JArray.Parse(json)
                'MessageBox.Show(array.ElementAt(1).ToString)   'Comprobación que funciona
                Dim texto As String = ""
                For i As Integer = 0 To array.Count - 1
                    texto = array.ElementAt(i).SelectToken("ccaa").ToString & "\n"
                    texto = texto & array.ElementAt(i).SelectToken("dosisAdministradas").ToString & "\n"
                    texto = texto & array.ElementAt(i).SelectToken("dosisEntregadas").ToString & "\n"
                    texto = texto & array.ElementAt(i).SelectToken("porcentajeEntregadas").ToString & "\n"
                    texto = texto & array.ElementAt(i).SelectToken("porcentajePoblacionCompletas").ToString & "\n"
                    MessageBox.Show(texto)
                Next




            End If

            'Catch ex As Exception
            'Para un futuro estaría bien implementar un fichero que marque que ficheros no se han descargado
            'Pero por el momento no vamos a añadir ninguna excepción
            'End Try
        Next
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
