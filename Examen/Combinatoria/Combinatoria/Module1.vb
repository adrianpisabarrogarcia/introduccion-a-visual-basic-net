Module Module1

    Sub Main()
        Dim num1, num2 As Integer
        Dim resultado As Double

        Console.WriteLine("Inserta un numero positivo")
        While Not (Integer.TryParse(Console.ReadLine(), num1)) Or num1 < 1
            Console.WriteLine("El numero tiene que ser positivo y mayor que 0")
        End While
        Console.WriteLine("Inserta un numero positivo y menor que el anterior")
        While Not (Integer.TryParse(Console.ReadLine(), num2)) Or num1 < 1 Or num1 < num2
            Console.WriteLine("El numero tiene que ser positivo, mayor que 0 y menor que {0}", num1)
        End While


        resultado = factorial(num1) / (factorial(num2) * factorial(num1 - num2))

        Console.WriteLine("El resultado es {0}", resultado)

        Console.ReadLine()



    End Sub


    Function factorial(num As Integer) As Integer
        Dim resultado As Integer = 1

        For i = 1 To num
            resultado = resultado * i
        Next

        Return resultado
    End Function

End Module
