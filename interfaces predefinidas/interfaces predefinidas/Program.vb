Imports System

Module Program
    Sub Main()
        Dim numeros = New Integer() {10, 8, 23, 5, 7}
        Dim miObjeto As Object = New Persona("Fernando", 36)
        Dim miPersona As Persona = TryCast(miObjeto, Persona)
        Console.WriteLine(miPersona.getNombres)
        Console.WriteLine("Nombre")
    End Sub
End Module
