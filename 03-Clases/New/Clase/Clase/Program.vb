Imports System

Module Program
    Sub Main(args As String())
        Dim listaAsignaturas As List(Of Asignatura) = cargarAsignaturas()
        menu()
    End Sub

    Function cargarAsignaturas()
        Dim listasAsignaturas As List(Of Asignatura)

        Dim asignatura1 = New Asignatura("Matem�ticas")
        listasAsignaturas.Add(asignatura1)

        Dim asignatura2 = New Asignatura("F�sica")
        listasAsignaturas.Add(asignatura2)

        Dim asignatura3 = New Asignatura("Qu�mica")
        listasAsignaturas.Add(asignatura3)

        Dim asignatura4 = New Asignatura("Lenguaje")
        listasAsignaturas.Add(asignatura4)

        Dim asignatura5 = New Asignatura("Biolog�a")
        listasAsignaturas.Add(asignatura5)

        Dim asignatura6 = New Asignatura("Dibujo")
        listasAsignaturas.Add(asignatura6)


        Return listasAsignaturas
    End Function

    Sub menu()
        Console.WriteLine()

    End Sub
End Module
