Module Module1

    Sub Main()
        Dim nombres(6) As String
        For i = 0 To nombres.Length - 1 Step 1
            Console.Write("INgrese el nombre de la posision: " & i)
            nombres(i) = Console.ReadLine()
            Console.WriteLine(nombres(i))
        Next

    End Sub

End Module
