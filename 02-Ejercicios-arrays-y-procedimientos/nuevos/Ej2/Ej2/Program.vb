Imports System

Module Program
    Sub Main(args As String())
        Dim numeroDepartamentos As Integer
        'Pedir numero de departamentos
        Console.WriteLine("Inserta el número de departamentos:")
        While Not (Integer.TryParse(Console.ReadLine(), numeroDepartamentos) And numeroDepartamentos > 0)
            Console.WriteLine("Inserta otro numero natural y mayor de 0.")
        End While

        'Creo una matriz de departamentos
        Dim departamentos(numeroDepartamentos, 3) As Array

        For i = 1 To numeroDepartamentos
            'Pedir nombre de departamento
            Dim nombreDepartamento(1) As String
            Console.WriteLine("Inserta el nombre de departamento:")
            nombreDepartamento(1) = Console.ReadLine()
            departamentos(i, 1) = nombreDepartamento

            'Pedir jefe de departamento
            Dim nombreJefeDepartamento(1) As String
            Console.WriteLine("Inserta el nombre del jefe/a del departamento:")
            nombreJefeDepartamento(1) = Console.ReadLine()
            departamentos(i, 2) = nombreJefeDepartamento

            'Pedir nombres de trabajadores/as de departamento
            Dim numeroTrabajadoresDepartamento As Integer = 1
            Console.WriteLine("Inserta el número de trabajadores que hay en el departamento {0}:", nombreDepartamento)
            While Not (Integer.TryParse(Console.ReadLine(), numeroTrabajadoresDepartamento))
                Console.WriteLine("Numero entero mayor de 0 introducido erróneo, inténtelo de nuevo")
            End While
            Dim nombresTrabajadores(numeroTrabajadoresDepartamento) As String
            For j = 0 To numeroTrabajadoresDepartamento
                Console.WriteLine("Introduce el nombre del trabajador/a {0}:", j)
                nombresTrabajadores(j) = Console.ReadLine()
            Next
            departamentos(i, 3) = nombresTrabajadores
        Next

        imprimirDepartamentos(departamentos)



    End Sub

    Sub imprimirDepartamentos(departamentos As Array)

        For i = 0 To departamentos.Length
            Dim nombreDepartamento As Array = departamentos(i)(0)
            Console.WriteLine("Departamento: {0}", nombreDepartamento(0))
            Dim jefeDepartamento As Array = departamentos(i)(2)

            Console.WriteLine("Jefe/a del departamento: {0}", jefeDepartamento(1))
            For j = 1 To departamentos(i)(3).Length
                Console.WriteLine("    {0}. Trabajador/a: {1}", j, departamentos(i)(3)(j))
            Next
        Next

    End Sub

End Module
