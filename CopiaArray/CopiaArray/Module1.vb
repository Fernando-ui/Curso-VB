Module Module1

    Sub Main()
        Dim numeros = New Integer() {14, 28, 56}
        Dim arrayCopia(3) As Integer
        For i = 0 To 2 Step 1
            arrayCopia(i) = numeros(i)
        Next
        For i = 0 To 2 Step 1
            Console.Write(arrayCopia(i) & "valores ")
        Next
    End Sub

End Module
