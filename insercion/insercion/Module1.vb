Module Module1

    Sub Main()
        Dim listOfNumbers = New Integer() {233, 301, 192, 169, 215}
        For j = 1 To 1 Step -1
            If listOfNumbers(j) < listOfNumbers(j - 1) Then
                Dim number As Integer = listOfNumbers(j)
                listOfNumbers(j) = listOfNumbers(j - 1)
                listOfNumbers(j - 1) = number
            End If
        Next
        For Each number As Integer In listOfNumbers
            Console.WriteLine(number)
        Next
    End Sub
End Module
