Imports System

Module Program
    Sub Main()
        Dim nom, id As String
        Dim edad As Integer
        Try
            Console.WriteLine("Ingresa el nombre de la persona")
            nom = Console.ReadLine


            Console.WriteLine("Ingrese el numero de identificacion de la persona")
            id = Console.ReadLine

            Console.WriteLine("Ingrese la edad de la persona")
            edad = Console.ReadLine

            Dim p As New Persona(nom, id, edad)
            p.datos(nom, id, edad)

        Catch ex As Exception
            Console.WriteLine("Tenemos un error")
        End Try
    End Sub
End Module
