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
        Dim departamentos(numeroDepartamentos - 1, 3) As String

        For i = 0 To numeroDepartamentos - 1
            'Pedir nombre de departamento
            Dim nombreDepartamento As String
            Console.WriteLine("Inserta el nombre de departamento:")
            nombreDepartamento = Console.ReadLine()
            departamentos(i, 0) = nombreDepartamento

            'Pedir jefe de departamento
            Dim nombreJefeDepartamento As String
            Console.WriteLine("Inserta el nombre del jefe/a del departamento:")
            nombreJefeDepartamento = Console.ReadLine()
            departamentos(i, 1) = nombreJefeDepartamento

            'Pedir nombres de trabajadores/as de departamento
            Dim numeroTrabajadoresDepartamento As Integer = 1
            Console.WriteLine("Inserta el número de trabajadores que hay en el departamento {0}:", nombreDepartamento)
            While Not (Integer.TryParse(Console.ReadLine(), numeroTrabajadoresDepartamento))
                Console.WriteLine("Numero entero mayor de 0 introducido erróneo, inténtelo de nuevo")
            End While
            Dim nombresTrabajadores(numeroTrabajadoresDepartamento) As String
            For j = 2 To numeroTrabajadoresDepartamento
                Console.WriteLine("Introduce el nombre del trabajador/a {0}:", j)
                departamentos(i, j) = Console.ReadLine()
            Next
        Next

        imprimirDepartamentos(departamentos)



    End Sub

    Sub imprimirDepartamentos(departamentos As Array)

        For i = 0 To (departamentos.Length - 1)
            Dim nombreDepartamento As String = departamentos(i)(0)
            Console.WriteLine("Departamento: {0}", nombreDepartamento)

            Dim jefeDepartamento As String = departamentos(i)(1)
            Console.WriteLine("Jefe/a del departamento: {0}", jefeDepartamento)

            For j = 2 To departamentos(i).Length - 1
                Console.WriteLine("    {0}. Trabajador/a: {1}", j, departamentos(i)(j))
            Next
        Next

    End Sub

End Module
