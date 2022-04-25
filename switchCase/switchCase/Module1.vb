Module Module1

    Sub Main()
        Console.Write("Coloque su valor 1 a 3: ")
        Dim respuesta As Double = Console.ReadLine()
        Select Case respuesta
            Case 1
                Console.WriteLine("Tenemos la respueta 1" & respuesta + 1)
            Case 2
                Console.WriteLine("Tenemos la resuesta 2" & respuesta * 2)
            Case 3
                Console.WriteLine("Tenemos la respuesta 3" & respuesta / 2)
            Case Else
                Console.WriteLine("Coloque un valor Correcto")
        End Select
    End Sub

End Module
