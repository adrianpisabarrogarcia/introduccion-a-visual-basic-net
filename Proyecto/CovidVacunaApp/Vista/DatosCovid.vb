﻿Public Class DatosCovid
    Private Sub bDescargarDatos_Click(sender As Object, e As EventArgs) Handles bDescargarDatos.Click
        Dim controladorDatos = New ControladorDatos
        controladorDatos.descargarArchivos()
    End Sub

    Private Sub bImportarDatos_Click(sender As Object, e As EventArgs) Handles bImportarDatos.Click
        Dim controladorDatos = New ControladorDatos
        controladorDatos.importarDatosEnBBDD()
    End Sub
End Class