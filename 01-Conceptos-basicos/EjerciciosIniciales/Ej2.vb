Imports System

Module Ej2
    Sub Main(args As String())
        Dim mes, anio, diasDelMes As Integer

        diasDelMes = 31

        Console.WriteLine("Introduce un mes:")
        mes = Integer.Parse(Console.ReadLine())
        While Not Integer.TryParse(Console.ReadLine(), mes) OrElse mes <= 0 OrElse mes > 12
            Console.WriteLine("No has introducidido correctamante el dato. Vuévelo a intentar.")
        End While


        Console.WriteLine("Introduce un anio:")
        anio = Integer.Parse(Console.ReadLine())

        If (mes Mod 2) = 0 Then
            diasDelMes = 30
            If mes = 2 Then
                diasDelMes = 28
                If anio Mod 4 = 0 Then
                    diasDelMes = diasDelMes + 1
                End If
            End If
        End If

        Console.WriteLine("El mes {0}, el anio {1} TIENEN {2} DIAS", mes, anio, diasDelMes)



    End Sub
End Module
