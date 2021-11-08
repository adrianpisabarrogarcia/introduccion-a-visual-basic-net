Imports System

Module Program
    Sub Main(args As String())
        Dim opcion As Integer
        Do
            opcion = menu()

        Loop While opcion > 1 And opcion < 7

        Console.WriteLine("Saliendo...")

    End Sub


    Function menu()
        Dim opcion As Integer

        Console.WriteLine("Inserta una opcion:")
        Console.WriteLine("1) Insertar un nuevo alumno/a")
        Console.WriteLine("2) Matricular a una persona en una asignatura")
        Console.WriteLine("3) Insertar notas")
        Console.WriteLine("4) Visualizar todos los datos de un alumno")
        Console.WriteLine("5) Visualizar todos los datos de los alumnos:")
        Console.WriteLine("6) Visualizar la nota media de una persona")
        Console.WriteLine("Pulsa otro numero cualquiera y sal")

        While Not (Integer.TryParse(Console.ReadLine(), opcion))
            Console.WriteLine("No has introducido un número entero , vuelve a hacerlo")
        End While

        Return opcion
    End Function
End Module
