Public Class Controlador



    Friend Function calcular(horasTrabajadas As Integer, modoPago As String, numTrabajadores As Integer, listMaterialesEscogidos As List(Of Material)) As String
        Const horaTrabajador As Integer = 25
        Const tresMeses As Integer = 3
        Dim resultado As Double = 0



        resultado = horasTrabajadas * horaTrabajador * numTrabajadores
        If modoPago = "tres meses" Then
            resultado = (resultado + (resultado * tresMeses / 100)) / 3
        End If



        Return resultado
    End Function



End Class
