Public Class Nota

    Property asignatura As Asignatura
    Property nota As Double

    Sub New(asignatura As Asignatura, nota As Double)
        Me.asignatura = asignatura
        Me.nota = nota
    End Sub

End Class
