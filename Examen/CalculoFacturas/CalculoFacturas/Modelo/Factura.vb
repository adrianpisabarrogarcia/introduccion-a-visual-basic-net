Public Class Factura

    Property numHoras As Integer
    Property numTrabajadores As Integer
    Property metodoPago As String
    Property listaMateriales As New List(Of Material)


    Public Sub New(numHoras As Integer, numTrabajadores As Integer, metodoPago As String, listaMateriales As List(Of Material))
        Me.numHoras = numHoras
        Me.numTrabajadores = numTrabajadores
        Me.metodoPago = metodoPago
        Me.listaMateriales = listaMateriales
    End Sub

End Class
