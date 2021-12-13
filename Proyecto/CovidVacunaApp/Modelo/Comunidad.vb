Public Class Comunidad

    Property id As Integer
    Property nombre As String
    Property datos As List(Of Datos)


    Public Sub New(id As Integer, nombre As String)
        Me.id = id
        Me.nombre = nombre
    End Sub

    Public Sub New(id As Integer, nombre As String, datos As List(Of Datos))
        Me.id = id
        Me.nombre = nombre
        Me.datos = datos
    End Sub

    Public Sub imprimir()
        Dim texto As String = "Id: " & Me.id & "; Nombre: " & Me.nombre

        For Each dato As Datos In Me.datos
            texto = texto & 
                "Dosis Administradas: " & dato.dosisAdministradas & ";
                Dosis Entregadas: " & dato.dosisEntregadas & ";
                Dosis Entregadas Moderna: " & dato.dosisEntregadasModerna & ";
                Dosis Entregadas Pfizer: " & dato.dosisEntregadasPfizer & ";
                Dosis Entregadas Astrazeneca: " & dato.dosisEntregadasAstrazeneca & ";
                Dosis Pauta Completada: " & dato.dosisPautaCompletada & ";
                Porcentaje porcentajeEntregadas: " & dato.porcentajeEntregadas & ";
                Porcentaje porcentajePoblacionAdministradas: " & dato.porcentajePoblacionAdministradas & ";
                Porcentaje porcentajePoblacionCompletas: " & dato.porcentajePoblacionCompletas & ";
                Fecha: " & dato.fecha

        Next



        MessageBox.Show()
    End Sub


End Class
