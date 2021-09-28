Imports System

Module Ej1v2
    Sub Main(args As String())

        Dim number1, number2 As Integer
        Console.WriteLine("Introduce un numero 1:")
        number1 = Integer.Parse(Console.ReadLine())
        Console.WriteLine("Introduce un numero 2:")
        number2 = Integer.Parse(Console.ReadLine())


        If number1 > number2 Then
            Console.WriteLine("La resta es igual a {0}", number1 - number2)
        End If
        Console.WriteLine("La suba es igual a {0}", number1 + number2)

    End Sub
End Module
