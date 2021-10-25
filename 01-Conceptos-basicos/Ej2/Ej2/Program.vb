Imports System

Module Program
    Sub Main(args As String())
        Dim month, year As Integer

        Console.WriteLine("Introduce un mes:")
        While (Not (Integer.TryParse(Console.ReadLine(), month)) Or month < 1 Or month > 12)
            Console.WriteLine("No has introducido un numero entero positivo comprendiendo entre el 1 y el 12. Intentalo de nuevo:")
        End While

        Console.WriteLine("Introduce un a�o:")
        While (Not (Integer.TryParse(Console.ReadLine(), year)))
            Console.WriteLine("No has introducido un numero entero positivoa�o. Intentalo de nuevo:")
        End While


        Select Case (month)
            Case 4, 6, 9, 11
                Console.WriteLine("El mes {0} tiene 30 d�as", month)
            Case 1, 3, 5, 7, 8, 10, 12
                Console.WriteLine("El mes {0} tiene 31 d�as", month)
            Case 2
                If year Mod 4 = 0 Then
                    Console.WriteLine("El mes {0} tiene 29 d�as porque el a�o {1} es bisiesto.", month, year)
                Else
                    Console.WriteLine("El mes {0} tiene 28 d�as", month)
                End If
        End Select




    End Sub
End Module
