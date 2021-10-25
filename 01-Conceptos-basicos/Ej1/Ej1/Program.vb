Imports System

Module Program
    Sub Main(args As String())
        Dim numberOne, numberTwo As Double

        Console.WriteLine("Introduce un numero:")
        While Not (Double.TryParse(Console.ReadLine(), numberOne))
            Console.WriteLine("No has intrducido un número entero positivo")
        End While

        Console.WriteLine("Introduce otro numero:")
        While Not (Double.TryParse(Console.ReadLine(), numberTwo))
            Console.WriteLine("No has intrducido un número entero positivo")
        End While

        If (numberOne > numberTwo) Then
            Console.WriteLine("El resultado de la resta {0} - {1} = {2}", numberOne, numberTwo, numberOne - numberTwo)
        End If

        Console.WriteLine("El resultado de la suma {0} + {1} = {2}", numberOne, numberTwo, numberOne + numberTwo)







    End Sub
End Module
