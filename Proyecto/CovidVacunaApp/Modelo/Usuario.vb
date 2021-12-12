Public Class Usuario

    Property id As Integer
    Property nombre As String
    Property usuario As String
    Property password As String

    Public Sub New(nombre As String, usuario As String, password As String)
        Me.nombre = nombre
        Me.usuario = usuario
        Me.password = password
    End Sub

    Public Sub New(id As Integer, nombre As String, usuario As String, password As String)
        Me.id = id
        Me.nombre = nombre
        Me.usuario = usuario
        Me.password = password
    End Sub

    Public Sub imprimir()
        MessageBox.Show("Id: " & Me.id & "; Nombre: " & Me.nombre & "; Usuario: " & Me.usuario & "; Password: " & Me.password)
    End Sub


End Class
