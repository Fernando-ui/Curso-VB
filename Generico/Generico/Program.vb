Imports System

Module Program
    Sub Main()
        Dim general As Object = New Persona("Fernando", "123456")
        'De esta menra podemos tener los elementos que contiene Persona
        Dim miPersona As Persona = TryCast(general, Persona)
        Dim general2 As New Objetos(Of Persona)
        general2.elObjeto = New Persona("Juan", "Perez")
        Console.WriteLine(general2.elObjeto)
        Console.WriteLine("elemento impreso")
    End Sub

End Module
