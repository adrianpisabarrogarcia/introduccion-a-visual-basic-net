Imports System

Module Program

    Dim listaAsignaturas As List(Of Asignatura)
    Dim listaNotas As List(Of Nota)
    Dim listaAlumnos As List(Of Alumno)



    Sub Main(args As String())
        cargarAsignaturas()
        Dim opcion As Integer
        Do
            menu()
            opcion = escogerOpcion()
            Select Case opcion
                Case 1
                    Dim alumno As Alumno
                    alumno = anadirAlumno()
                    listaAlumnos.Add(alumno)
                Case 2
                    matricularAlumnoEnAsignatura()
                Case 3
                    insertarNotas()
                Case 4
                    visualizarDatosUnAlumno()
                Case 5
                    visualziarDatosTodosAlumnos()
                Case 6
                    VisualizarNotaMediaUnAlumno()

            End Select
        Loop While opcion < 1 Or opcion > 5

    End Sub

    Function anadirAlumno()
        Dim nombre, primerApellido, segundoApellido As String
        Console.WriteLine("Introduce nombre:")
        nombre = Console.ReadLine()
        Console.WriteLine("Introduce primer apellido:")
        primerApellido = Console.ReadLine
        Console.WriteLine("Introduce segundo apellido:")
        segundoApellido = Console.ReadLine

        Dim alumno As Alumno
        alumno = New Alumno(nombre, primerApellido, segundoApellido)

        Return alumno
    End Function

    Sub matricularAlumnoEnAsignatura()
        For Each asignatura As Asignatura In listaAsignaturas
            Console.WriteLine("Asginatura {0}", asignatura)
        Next
    End Sub

    Sub insertarNotas()

    End Sub

    Sub visualizarDatosUnAlumno()

    End Sub

    Sub visualziarDatosTodosAlumnos()

    End Sub

    Sub VisualizarNotaMediaUnAlumno()

    End Sub

    Sub cargarAsignaturas()

        listaAsignaturas.Add(New Asignatura("Matemáticas"))

        Dim asignatura2 As Asignatura = New Asignatura("Física")
        listaAsignaturas.Add(asignatura2)

        Dim asignatura3 As Asignatura = New Asignatura("Química")
        listaAsignaturas.Add(asignatura3)

        Dim asignatura4 As Asignatura = New Asignatura("Lenguaje")
        listaAsignaturas.Add(asignatura4)

        Dim asignatura5 As Asignatura = New Asignatura("Biología")
        listaAsignaturas.Add(asignatura5)

        Dim asignatura6 As Asignatura = New Asignatura("Dibujo")
        listaAsignaturas.Add(asignatura6)

    End Sub

    Sub menu()
        Console.WriteLine("Escoge entre las opciones:")
        Console.WriteLine("1. Añadir alumno/a")
        Console.WriteLine("2. Matricular a una persona en una asgignatura")
        Console.WriteLine("3. Insertar notas")
        Console.WriteLine("4. Visualizar todos los datos del alumno/a en concreto")
        Console.WriteLine("5. Visualizar todos los datos del alumnado")
        Console.WriteLine("6. Visualizar nota media de una persona")
        Console.WriteLine("Cualquier otra opción Salir")
    End Sub

    Function escogerOpcion()
        Dim opcion As Integer
        Console.WriteLine("Inserte numero: ")
        While Not (Integer.TryParse(Console.ReadLine(), opcion))
            Console.Write("Has insertado un número erróneo. Vuelve a intentarlo.")
        End While

        Return opcion
    End Function
End Module
