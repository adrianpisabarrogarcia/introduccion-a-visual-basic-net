Public Class Alumno

    Public nombre As String
    Public apellido As String
    Public segundoApellido As String
    Public asignaturas As ArrayList

    Sub New(nombre As String,
            apellido As String,
            segundoApellido As String,
            asignaturas As ArrayList
            )
        Me.nombre = nombre
        Me.apellido = apellido
        Me.segundoApellido = segundoApellido
        Me.asignaturas = asignaturas
    End Sub

    Property prop_nombre As String
    Property prop_apellido As String
    Property prop_segundoApellido As String
    Property prop_asignaturas As ArrayList


End Class
