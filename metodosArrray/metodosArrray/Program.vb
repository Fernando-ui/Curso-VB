Imports System

Module Program
    Sub Main()
        Dim miLista As New List(Of Integer)
        miLista.Add(3)
        miLista.Add(19)
        miLista.Add(4)
        'Console.WriteLine(miLista)
        'For i = 0 To miLista.Count - 1 Step 1
        '    Console.WriteLine(miLista.Item(i))
        '    Console.WriteLine(miLista(i))
        'Next
        Dim copiaLista() As Integer = miLista.ToArray
        miLista.Clear()
        Console.WriteLine(copiaLista)
        Console.WriteLine("Imprimiendo la lista de arriba")

        For Each elemento As Integer In copiaLista
            Console.WriteLine(elemento)
            Console.WriteLine("No tenemos nada")
        Next
    End Sub
End Module
