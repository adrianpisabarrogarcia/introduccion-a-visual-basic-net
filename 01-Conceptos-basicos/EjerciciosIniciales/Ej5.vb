Imports System

Module Ej5
    Sub Main(args As String())
        Dim n, espacios As Integer
        espacios = 0
        Console.WriteLine("Introduce un numero de asteriscos para realizar una pirámide invertida")
        n = Integer.Parse(Console.ReadLine())

        While (n <> 0)
            Dim aux As Integer
            aux = n * 2 - 1
            For i = 0 To espacios
                Console.Write(" ")
            Next
            While (aux <> 0)
                Console.Write("*")
                aux = aux - 1
            End While

            n = n - 1
            espacios = espacios + 1
            Console.WriteLine()
        End While



    End Sub
End Module
