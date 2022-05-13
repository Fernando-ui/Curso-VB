Module Module1

    Sub Main()
        ' Ordenamiento por seleccion
        Dim randomNumbers = New Integer() {233, 301, 192, 169, 215}
        Dim numeroMenor As Integer = randomNumbers(0)
        Dim posNumeroMenor As Integer = 0

        For i = 1 To randomNumbers.Length - 1 Step 1
            If randomNumbers(i) < numeroMenor Then
                numeroMenor = randomNumbers(i + 1)
                posNumeroMenor = i
            End If
        Next
        ' Metodo de la burbuja
        ' Nos permita cambiar el valor de dos variables
        Dim aux As Integer = randomNumbers(0)
        randomNumbers(0) = randomNumbers(posNumeroMenor)
        randomNumbers(posNumeroMenor) = aux
        For Each num As Integer In randomNumbers
            Console.Write(num & " ")
        Next
    End Sub

End Module
