Imports System

Module Program
    Sub Main(args As String())
        Dim numeroHorasTrabajadas As Integer
        Dim estadoCivil, nivelEstudios As Char
        Dim sueldo As Double = 0

        Const horasExtra As Integer = 160
        Const preciohorasExtra As Integer = 15
        Const preciohorasNormal As Integer = 10
        Const plus As Integer = 100


        Console.WriteLine("Cuantas horas has tabajado en un mes?")
        While Not (Integer.TryParse(Console.ReadLine(), numeroHorasTrabajadas))
            Console.WriteLine("Introduce bien las horas trabajadas:")
        End While


        Console.WriteLine("Cual es tu estado civil? S, C, V, D")
        While (Not (Char.TryParse(Console.ReadLine(), estadoCivil))) Or (estadoCivil <> "S" And estadoCivil <> "C" And estadoCivil <> "V" And estadoCivil <> "D")
            Console.WriteLine("Introduce bien el estado civil: (S, C, V, D)")
        End While

        Console.WriteLine("Cual es tu nivel de estudios? P, M, S")
        While (Not (Char.TryParse(Console.ReadLine(), nivelEstudios))) Or (nivelEstudios <> "P" And nivelEstudios <> "M" And nivelEstudios <> "S")
            Console.WriteLine("Introduce bien el nivel de estudios: (P, M, S)")
        End While


        If numeroHorasTrabajadas > horasExtra Then
            'Numero de horas extras
            sueldo = ((numeroHorasTrabajadas - horasExtra) * preciohorasExtra) + (horasExtra * preciohorasNormal)
        Else
            sueldo = numeroHorasTrabajadas * preciohorasNormal
        End If

        If (estadoCivil = "S" And nivelEstudios = "P") Or (estadoCivil = "V" And nivelEstudios = "S") Or (estadoCivil = "S" And nivelEstudios = "M") Or (estadoCivil = "C" And nivelEstudios = "S") Or (estadoCivil = "V" And nivelEstudios = "P") Or (estadoCivil = "S" And nivelEstudios = "S") Or (estadoCivil = "D" And nivelEstudios = "S") Then

            sueldo = sueldo + plus
        End If


        Console.WriteLine("***************************************")
        Console.WriteLine("El sueldo sería de : {0}euros", sueldo)
        Console.WriteLine("***************************************")





    End Sub
End Module
