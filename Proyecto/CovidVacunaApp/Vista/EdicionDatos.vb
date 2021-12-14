Public Class EdicionDatos
    Dim dato As Datos

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        Dim controladorDatos = New ControladorDatos

        dato.comunidad.nombre = tbComunidad.Text
        dato.fecha = fecha.Text
        dato.dosisAdministradas = nDosisAdministradas.Value
        dato.dosisEntregadas = nDosisEntregadas.Value
        dato.dosisEntregadasModerna = nDosisEntregadasModerna.Value
        dato.dosisEntregadasPfizer = nDosisEntregadasPfizer.Value
        dato.dosisEntregadasAstrazeneca = nDosisEntregadasAstrazeneca.Value
        dato.dosisPautaCompletada = nDosisPautaCompleta.Value
        dato.porcentajeEntregadas = nPorcentajeEntregadas.Value
        dato.porcentajePoblacionAdministradas = nPorcentajePoblacionAdministradas.Value
        dato.porcentajePoblacionCompletas = nPorcentajePoblacionCompletas.Value

        controladorDatos.modificarDato(dato)
        MessageBox.Show("Datos modificados")

    End Sub

    Private Sub bEliminarRegistro_Click(sender As Object, e As EventArgs) Handles bEliminarRegistro.Click
        Dim controladorDatos = New ControladorDatos
        controladorDatos.eliminarDato(dato.id)
        MessageBox.Show("Dato eliminado")
        Me.Hide()
        DatosCovid.Show()
    End Sub

    Private Sub bVolver_Click(sender As Object, e As EventArgs) Handles bVolver.Click
        Me.Hide()
        DatosCovid.Show()
    End Sub

    Public Sub mostrarDatos(id As Integer)
        Dim controladorDatos = New ControladorDatos
        dato = controladorDatos.mostrarDato(id)

        dato.imprimir()

        tbComunidad.Text = dato.comunidad.nombre
        fecha.Text = dato.fecha
        nDosisAdministradas.Value = CInt(dato.dosisAdministradas)
        nDosisEntregadas.Value = dato.dosisEntregadas
        nDosisEntregadasModerna.Value = dato.dosisEntregadasModerna
        nDosisEntregadasPfizer.Value = dato.dosisEntregadasPfizer
        nDosisEntregadasAstrazeneca.Value = dato.dosisEntregadasAstrazeneca
        nDosisPautaCompleta.Value = dato.dosisPautaCompletada
        nPorcentajeEntregadas.Value = dato.porcentajeEntregadas
        nPorcentajePoblacionAdministradas.Value = dato.porcentajePoblacionAdministradas
        nPorcentajePoblacionCompletas.Value = dato.porcentajePoblacionCompletas

        'nDosisAdministradas.Value = 0
        'nDosisEntregadas.Value = 0
        'nDosisEntregadasModerna.Value = 0
        'nDosisEntregadasPfizer.Value = 0
        'nDosisEntregadasAstrazeneca.Value = 0
        'nDosisPautaCompleta.Value = 0
        'nPorcentajeEntregadas.Value = 0
        'nPorcentajePoblacionAdministradas.Value = 0
        'nPorcentajePoblacionCompletas.Value = 0



    End Sub


End Class