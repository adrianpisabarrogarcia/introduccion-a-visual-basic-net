Public Class Datos

    Property id As Integer
    Property dosisAdministradas As Double
    Property dosisEntregadas As Double
    Property dosisEntregadasModerna As Double
    Property dosisEntregadasPfizer As Double
    Property dosisEntregadasAstrazeneca As Double
    Property dosisPautaCompletada As Double
    Property porcentajeEntregadas As Double
    Property porcentajePoblacionAdministradas As Double
    Property porcentajePoblacionCompletas As Double
    Property fecha As Date
    Property comunidad As Comunidad


    Public Sub New(id As Integer,
                  dosisAdministradas As Double,
                   dosisEntregadas As Double,
                   dosisEntregadasModerna As Double,
                   dosisEntregadasPfizer As Double,
                   dosisEntregadasAstrazeneca As Double,
                   dosisPautaCompletada As Double,
                   porcentajeEntregadas As Double,
                   porcentajePoblacionAdministradas As Double,
                   porcentajePoblacionCompletas As Double,
                   fecha As Date,
                   comunidad As Comunidad)
        Me.id = id
        Me.dosisAdministradas = dosisAdministradas
        Me.dosisEntregadas = dosisEntregadas
        Me.dosisEntregadasModerna = dosisEntregadasModerna
        Me.dosisEntregadasPfizer = dosisEntregadasPfizer
        Me.dosisEntregadasAstrazeneca = dosisEntregadasAstrazeneca
        Me.dosisPautaCompletada = dosisPautaCompletada
        Me.porcentajeEntregadas = porcentajeEntregadas
        Me.porcentajePoblacionAdministradas = porcentajePoblacionAdministradas
        Me.porcentajePoblacionCompletas = porcentajePoblacionCompletas
        Me.fecha = fecha
        Me.comunidad = comunidad
    End Sub


    Public Sub New(dosisAdministradas As Double,
                   dosisEntregadas As Double,
                   dosisEntregadasModerna As Double,
                   dosisEntregadasPfizer As Double,
                   dosisEntregadasAstrazeneca As Double,
                   dosisPautaCompletada As Double,
                   porcentajeEntregadas As Double,
                   porcentajePoblacionAdministradas As Double,
                   porcentajePoblacionCompletas As Double,
                   fecha As Date, comunidad As Comunidad)
        Me.dosisAdministradas = dosisAdministradas
        Me.dosisEntregadas = dosisEntregadas
        Me.dosisEntregadasModerna = dosisEntregadasModerna
        Me.dosisEntregadasPfizer = dosisEntregadasPfizer
        Me.dosisEntregadasAstrazeneca = dosisEntregadasAstrazeneca
        Me.dosisPautaCompletada = dosisPautaCompletada
        Me.porcentajeEntregadas = porcentajeEntregadas
        Me.porcentajePoblacionAdministradas = porcentajePoblacionAdministradas
        Me.porcentajePoblacionCompletas = porcentajePoblacionCompletas
        Me.fecha = fecha
        Me.comunidad = comunidad

    End Sub


    Public Sub imprimir()
        MessageBox.Show(
                "
                Dosis Administradas: " & Me.dosisAdministradas & ";
                Dosis Entregadas: " & Me.dosisEntregadas & ";
                Dosis Entregadas Moderna: " & Me.dosisEntregadasModerna & ";
                Dosis Entregadas Pfizer: " & Me.dosisEntregadasPfizer & ";
                Dosis Entregadas Astrazeneca: " & Me.dosisEntregadasAstrazeneca & ";
                Dosis Pauta Completada: " & Me.dosisPautaCompletada & ";
                Porcentaje porcentajeEntregadas: " & Me.porcentajeEntregadas & ";
                Porcentaje porcentajePoblacionAdministradas: " & Me.porcentajePoblacionAdministradas & ";
                Porcentaje porcentajePoblacionCompletas: " & Me.porcentajePoblacionCompletas & ";
                Fecha: " & Me.fecha & "
                Comunidad: " & Me.comunidad.nombre & "-" & Me.comunidad.id
               )
    End Sub


End Class
