Imports System

Module Program
    Sub Main(args As String())
        Dim numero, seleccion As Integer

        Do
            Console.WriteLine("Escribe un número:")
            While Not (Integer.TryParse(Console.ReadLine(), numero))
                Console.WriteLine("No has introducido un número entero , vuelve a hacerlo")
            End While

            Console.WriteLine("Escribe un número para seleccionar en este menú:")
            Console.WriteLine("1) Comprobar si es primo")
            Console.WriteLine("2) Calcular si el factorial")
            Console.WriteLine("3) Visualizar la tabla de multiplicar")
            Console.WriteLine("4) Salir del programa.")

            While Not (Integer.TryParse(Console.ReadLine(), seleccion)) OrElse (seleccion > 4 And seleccion < 1)
                Console.WriteLine("No has introducido un número comprendido entre el 1 y 4 , vuelve a hacerlo")
            End While

            Select Case seleccion
                Case 1
                    esPrimo(numero)
                Case 2
                    Console.WriteLine("El factorial de {0} es {1}", numero, calcularFactorial(numero))
                Case 3
                    tablaMultiplicar(numero)
            End Select

        Loop While seleccion <> 4
    End Sub

    Sub esPrimo(numero As Integer)
        Dim contador As Integer
        Dim primo As Boolean
        contador = 2
        primo = True

        While primo And contador <> numero
            If numero Mod contador = 0 Then
                primo = False
            End If
            contador += 1
        End While

        Console.Write("El numero {0} es primo? {1}", numero, primo)
    End Sub
    Function calcularFactorial(numero As Integer) As Integer
        If numero = 0 Then
            Return 1
        End If

        Return numero * calcularFactorial(numero - 1)
    End Function
    Sub tablaMultiplicar(numero As Integer)
        Dim i As Integer

        For i = 0 To 9
            Console.WriteLine("{0} * {1} = {2}", numero, i, numero * i)
        Next
    End Sub

End Module
