Public Class Asignatura

    Public nombre As String
    Public nota As Double

    Sub New(nombre As String, nota As Double)
        Me.nombre = nombre
        Me.nota = nota
    End Sub

    Property prop_nombre As String
    Property prop_nota As Double

End Class
