Imports System

Module Program
    Sub Main()
        Dim miLista As New List(Of Integer)
        miLista.Add(3)
        miLista.Add(19)
        miLista.Add(4)
        Console.WriteLine(miLista)
        For i = 0 To miLista.Count - 1 Step 1
            Console.WriteLine(miLista.Item(i))
        Next
    End Sub
End Module
