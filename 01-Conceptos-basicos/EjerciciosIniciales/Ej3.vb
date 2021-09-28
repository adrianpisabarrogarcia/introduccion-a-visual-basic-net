Imports System

Module Ej3
    Sub Main(args As String())
        Dim seleccion As Integer

        Console.WriteLine("Introduce un numero acorde a lo que quieras ejecutar:")
        Console.WriteLine("1) sumar")
        Console.WriteLine("2) restar")
        Console.WriteLine("3) multiplicar")
        Console.WriteLine("4) dividir")
        Console.WriteLine("Cualquier otro numero) salir")
        seleccion = Integer.Parse(Console.ReadLine())

        If seleccion > 0 And seleccion < 5 Then
            Dim number1, number2 As Integer
            Console.WriteLine("Introduce un numero 1:")
            number1 = Integer.Parse(Console.ReadLine())
            Console.WriteLine("Introduce un numero 2:")
            number2 = Integer.Parse(Console.ReadLine())

            Select Case seleccion
                Case 1
                    Console.WriteLine("La suma es: {0}", number1 + number2)
                Case 2
                    Console.WriteLine("La resta es: {0}", number1 - number2)
                Case 3
                    Console.WriteLine("La multiplicacion es: {0}", number1 * number2)
                Case 4
                    Console.WriteLine("La division es: {0}", number1 / number2)
            End Select
        Else
            Console.WriteLine("Saliendo del programa...")
        End If


    End Sub
End Module
