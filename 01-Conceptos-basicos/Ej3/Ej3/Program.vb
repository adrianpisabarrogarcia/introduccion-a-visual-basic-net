Imports System

Module Program
    Sub Main(args As String())

        Dim opcion As Integer


        Do
            'Pedir una de las opciones del programa
            Console.WriteLine("********************************************")
            Console.WriteLine("Introduce un numero para una de las opciones que tu quieras realizar:")
            Console.WriteLine("1) Sumar ")
            Console.WriteLine("2) Restar ")
            Console.WriteLine("3) Multiplicar ")
            Console.WriteLine("4) Dividir ")
            Console.WriteLine("5) Salir ")

            While (Not (Integer.TryParse(Console.ReadLine(), opcion))) Or opcion < 1 Or opcion > 5
                Console.WriteLine("Has introducido mal la opcion, Inténtalo de nuevo:")
            End While

            If (opcion >= 1 And opcion <= 4) Then

                'Pedir un numero
                Dim number1, number2 As Double
                Console.WriteLine("Introduce un numero: ")
                While Not Double.TryParse(Console.ReadLine(), number1)
                    Console.WriteLine("Has introducido mal la el número, Inténtalo de nuevo:")
                End While

                'Pedir un numero
                Console.WriteLine("Introduce otro numero: ")
                While Not Double.TryParse(Console.ReadLine(), number2)
                    Console.WriteLine("Has introducido mal la el número, Inténtalo de nuevo:")
                End While


                Select Case (opcion)
                    Case 1 'Sumar
                        Console.WriteLine("El resultado de {0} + {1} = {2} ", number1, number2, number1 + number2)
                    Case 2 'Restar
                        Console.WriteLine("El resultado de {0} - {1} = {2} ", number1, number2, number1 - number2)
                    Case 3 'Multiplicar
                        Console.WriteLine("El resultado de {0} * {1} = {2} ", number1, number2, number1 * number2)
                    Case 4 'Dividir
                        Console.WriteLine("El resultado de {0} / {1} = {2} ", number1, number2, number1 / number2)
                End Select

            End If


        Loop Until (opcion = 5)




    End Sub
End Module
