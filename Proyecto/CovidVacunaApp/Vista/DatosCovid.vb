Public Class DatosCovid

    Dim listaDatos = New List(Of Datos)



    Private Sub bDescargarDatos_Click(sender As Object, e As EventArgs) Handles bDescargarDatos.Click
        Dim controladorDatos = New ControladorDatos
        controladorDatos.descargarArchivos()
    End Sub

    Private Sub bImportarDatos_Click(sender As Object, e As EventArgs) Handles bImportarDatos.Click
        Dim controladorDatos = New ControladorDatos
        controladorDatos.importarDatosEnBBDD()
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        dataGridCovid.Rows.Clear()
        Dim comunidadElegida As String = cComunidades.SelectedItem.ToString()
        Dim fechaElegida As Date = Format(CDate(fecha.Value), "yyyy-MM-dd")
        Dim errores As Boolean = False

        Dim controladorValidador = New ControladorComprobacionDatos
        errores = controladorValidador.stringVacio(comunidadElegida)
        errores = controladorValidador.stringVacio(fechaElegida.ToString())

        If Not errores Then

            Dim controladorDatos = New ControladorDatos
            listaDatos = controladorDatos.obtenerDatosConFechaComunidadConcretos(comunidadElegida, fechaElegida)

            For Each dat As Datos In listaDatos
                'dat.imprimir()

                dataGridCovid.Rows.Add(dat.comunidad.nombre, dat.fecha.ToString(), dat.dosisAdministradas,
                                    dat.dosisEntregadas, dat.dosisEntregadasModerna, dat.dosisEntregadasPfizer,
                                    dat.dosisEntregadasAstrazeneca, dat.dosisPautaCompletada, dat.porcentajeEntregadas,
                                    dat.porcentajePoblacionAdministradas, dat.porcentajePoblacionCompletas, dat.id.ToString())

            Next


        Else
            MessageBox.Show("Elige comunidad y fecha antes.")

        End If


    End Sub

    Private Sub bCerrarSesion_Click(sender As Object, e As EventArgs) Handles bCerrarSesion.Click
        Me.Hide()
        InicioSesion.Show()
    End Sub

    Private Sub editarRow(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridCovid.CellDoubleClick

        Dim id As Integer
        id = dataGridCovid.Rows(dataGridCovid.CurrentRow.Index).Cells(11).Value

        Me.Hide()
        EdicionDatos.Show()
        EdicionDatos.mostrarDatos(id)


    End Sub
End Class