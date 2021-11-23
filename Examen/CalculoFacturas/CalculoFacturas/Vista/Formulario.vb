Public Class Formulario

    Dim controlador As New Controlador()
    Private Sub bCalcular_Click(sender As Object, e As EventArgs) Handles bCalcular.Click
        Dim comprobaciones As Boolean = False
        Dim mensajeErrores As String = ""

        'Total de Horas
        If Integer.Parse(numTotalHoras.Value) <= 0 Then
            mensajeErrores += "El valor Total de horas debe de ser mayor de 0. "
            comprobaciones = True
        End If

        'Numero de trabajadores
        If Integer.Parse(numTrabajadores.Value) <= 0 Then
            mensajeErrores += "El valor del Nº de trabajadores debe de ser mayor de 0. "
            comprobaciones = True
        End If

        'Materiales escogidos: mínimo uno
        If Not cbAluminio.Checked And Not cbCobre.Checked And Not cbHierro.Checked And Not cbLaton.Checked Then
            mensajeErrores += "Mínimo hay que escoger un material. "
            comprobaciones = True
        End If

        'Añadir a una lista los materiales que se ha escogido en la vista
        Dim listMaterialesEscogidos As New List(Of Material)
        If cbAluminio.Checked Then
            listMaterialesEscogidos.Add(New Material("Aluminio", 3.45))
        End If
        If cbHierro.Checked Then
            listMaterialesEscogidos.Add(New Material("Hierro", 2.31))
        End If
        If cbCobre.Checked Then
            listMaterialesEscogidos.Add(New Material("Cobre", 10.25))
        End If
        If cbLaton.Checked Then
            listMaterialesEscogidos.Add(New Material("Latón", 8.11))
        End If



        'Metodo de pago
        If Not rbContado.Checked And Not rbTresMeses.Checked Then
                mensajeErrores += "No has seleccionado ningun radio button tienes que seleccionar uno. "
                comprobaciones = True
            End If
        If rbContado.Checked And rbTresMeses.Checked Then
            mensajeErrores += "Has seleccionado todos los radio buttons tienes que seleccionar sólo uno."
            comprobaciones = True
        End If
        Dim metodoPago As String = "tres meses"
        If rbContado.Checked Then
            metodoPago = "contado"
        End If


        'Realizar las acciones oportunas si no ha habido ningun error
        If Not comprobaciones Then
            'Lo dejo así porque no me ha dado tiempo pero la idea es esa
            'tbTotalFactura.Text(controlador.calcular(Integer.Parse(numTotalHoras.Value),
            'metodoPago, Integer.Parse(numTrabajadores.Value),
            'listMaterialesEscogidos))
            MessageBox.Show(controlador.calcular(Integer.Parse(numTotalHoras.Value),
                                             metodoPago, Integer.Parse(numTrabajadores.Value),
                                               listMaterialesEscogidos) + "€ al mes")

        Else
            MessageBox.Show("Los errores son los siguientes: " + mensajeErrores)
        End If

    End Sub

    Private Sub cbAluminio_CheckedChanged(sender As Object, e As EventArgs) Handles cbAluminio.CheckedChanged
        If cbAluminio.Checked Then
            numAluminio.Visible = True
        Else
            numAluminio.Visible = False
        End If
    End Sub

    Private Sub cbHierro_CheckedChanged(sender As Object, e As EventArgs) Handles cbHierro.CheckedChanged
        If cbHierro.Checked Then
            numHierro.Visible = True
        Else
            numHierro.Visible = False
        End If
    End Sub

    Private Sub cbCobre_CheckedChanged(sender As Object, e As EventArgs) Handles cbCobre.CheckedChanged
        If cbCobre.Checked Then
            numCobre.Visible = True
        Else
            numCobre.Visible = False
        End If
    End Sub

    Private Sub cbLaton_CheckedChanged(sender As Object, e As EventArgs) Handles cbLaton.CheckedChanged
        If cbLaton.Checked Then
            numLaton.Visible = True
        Else
            numLaton.Visible = False
        End If
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        tbTotalFactura.Text = ""
        numTotalHoras.Value = 0.00
        numTrabajadores.Value = 0
        cbLaton.Checked = False
        cbHierro.Checked = False
        cbCobre.Checked = False
        cbAluminio.Checked = False
        numHierro.Visible = False
        numCobre.Visible = False
        numAluminio.Visible = False
        numLaton.Visible = False
        rbContado.Checked = False
        rbTresMeses.Checked = False
    End Sub
End Class