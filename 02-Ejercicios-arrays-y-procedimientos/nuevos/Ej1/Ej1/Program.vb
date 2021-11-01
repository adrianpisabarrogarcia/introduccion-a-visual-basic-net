Imports System

Module Program
    Sub Main(args As String())

        Dim numeroEscogido As Integer

        Do
            numeroEscogido = escogerNumero()
            Console.WriteLine(numeroEscogido)

            Select Case numeroEscogido
                Case 1
                    Dim numero As Double = pedirNumero()
                    If esPrimo(numero) Then
                        Console.WriteLine("El numero {0} es primo", numero)
                    Else
                        Console.WriteLine("El numero {0} NO es primo", numero)
                    End If
                Case 2
                    Dim numero As Double = pedirNumero()
                    factoriales(numero)
                Case 3
                    Dim numero As Double = pedirNumero()
                    tablaMultiplicar(numero)
            End Select



        Loop Until numeroEscogido = 4
        Console.WriteLine("Saliendo....")





    End Sub

    Function pedirNumero() As Double
        Dim numero As Double
        Console.WriteLine("Escibe un número: ")
        While Not (Double.TryParse(Console.ReadLine(), numero))
            Console.WriteLine("No has introducido un número válido inténtalo de nuevo.")
        End While

        Return numero
    End Function

    Function escogerNumero() As Integer

        Dim number As Integer
        Console.WriteLine("Escoge una de las opciones del menú:")
        Console.WriteLine("1) comprobar si el numero es primo")
        Console.WriteLine("2) calcular el factoriald e un numero")
        Console.WriteLine("3) visualizar la tabla de multiplicar de un número")
        Console.WriteLine("4) salir del programa")
        While Not (Integer.TryParse(Console.ReadLine(), number)) Or number < 1 Or number > 4
            Console.WriteLine("Introduzca un número válido comprendido entre el 1 y el 4:")
        End While

        Return number

    End Function

    Function esPrimo(numero As Double) As Boolean
        Dim contador As Integer = 2

        If numero = 1 Then
            Return False
        End If

        While contador <> numero
            If (numero Mod contador) = 0 Then
                Return False
            End If
            contador = contador + 1
        End While

        Return True

    End Function

    Sub factoriales(numero As Double)

        Dim resultado As Double = 1
        Console.Write("{0}! = ", numero)
        If numero <> 0 Then
            For i = 1 To numero
                If (i = numero) Then
                    Console.Write("{0} ", i)
                Else
                    Console.Write("{0} * ", i)
                End If
                resultado = resultado * i
            Next
            Console.Write("= {0}", resultado)
        Else
            Console.Write("= 1")
        End If

        Console.WriteLine("")
    End Sub

    Sub tablaMultiplicar(numero As Double)
        For i = 0 To 9
            Console.WriteLine("{0} * {1} = {2}", numero, i, numero * i)
        Next
    End Sub




End Module



