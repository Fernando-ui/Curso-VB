Module Module1

    Sub Main()
        'Colocando los valores desde su declaracion
        Dim valores = New Integer(,) {{25, 23, 84}, {6, 22, 39}}

        ' Colocando los valores con for 
        Dim numeros(2, 3) As Integer
        For filas = 0 To 1 Step 1
            For columna = 0 To 2 Step 1
                Console.Write("Ingrese el nmero en la posicion" & filas & "," & columna & ":")
                numeros(filas, columna) = Console.ReadLine()
            Next
        Next

        numeros(0, 0) = 25
        numeros(0, 1) = 10
        numeros(0, 2) = 24
    End Sub

End Module
