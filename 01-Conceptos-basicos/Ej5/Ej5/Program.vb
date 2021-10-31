Imports System

Module Program
    Sub Main(args As String())

        Dim number As Integer

        Console.WriteLine("Introduce un número mayor de 0 y entero")
        While Not (Integer.TryParse(Console.ReadLine(), number) And number > 0)
            Console.WriteLine("Escribe otro numero, porque el que has introducido no es un número natural mayor de 0.")
        End While


        Dim asteriscos As Integer = number * 2 - 1
        Dim espacios As Integer = 0

        For i = 1 To number
            ' generar espacios
            For k = 0 To espacios
                Console.Write(" ")
            Next
            ' generar asteriscos
            For j = 1 To asteriscos
                Console.Write("*")
            Next
            ' calculo de asteriscos que tiene que imprimir
            asteriscos = asteriscos - 2
            ' calculo de espacios que hay que dejar
            espacios = espacios + 1
            Console.WriteLine("")
        Next





    End Sub
End Module
