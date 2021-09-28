Imports System

Module Ej1
    Sub Main(args As String())
        Dim horasTrabajadas, sueldo As Integer
        Dim estadoCivil, nivelEstudios As String
        Const precioPorHora = 10
        Const precioPorHoraExtra = 15
        Const plus = 100
        Const horasExtra = 160


        Console.WriteLine("¿Cuantas horas trabajas al día?")
        horasTrabajadas = Integer.Parse(Console.ReadLine())
        Console.WriteLine("¿Cual es tu estado civil? Soltero, Casado, Viudo, Divorciado")
        estadoCivil = (Console.ReadLine().ToUpper)
        While Not (estadoCivil = "S" Or estadoCivil = "C" Or estadoCivil = "V" Or estadoCivil = "D")
            Console.WriteLine("inserta bien el estado civil: ")
            estadoCivil = (Console.ReadLine().ToUpper)
        End While
        Console.WriteLine("¿Cual es tu nivel de estudios?")
        nivelEstudios = (Console.ReadLine().ToUpper)
        While Not (nivelEstudios = "P" Or nivelEstudios = "M" Or nivelEstudios = "S")
            Console.WriteLine("inserta bien tu nivel de estudios: P, M, S")
            nivelEstudios = (Console.ReadLine().ToUpper)
        End While

        sueldo = horasExtra * precioPorHora

        If horasTrabajadas > horasExtra Then
            sueldo = sueldo + ((horasTrabajadas - horasExtra) * precioPorHoraExtra)
        End If

        If (estadoCivil = "S" And nivelEstudios = "P") Or (estadoCivil = "V" And nivelEstudios = "S") Or (estadoCivil = "S" And nivelEstudios = "M") Or (estadoCivil = "C" And nivelEstudios = "S") Or (estadoCivil = "V" And nivelEstudios = "P") Or (estadoCivil = "S" And nivelEstudios = "S") Or (estadoCivil = "D" And nivelEstudios = "S") Then
            sueldo = sueldo + plus
        End If


        Console.WriteLine("El sueldo es de {0}", sueldo)




    End Sub
End Module
