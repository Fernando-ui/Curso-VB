Module Module1

    Sub Main()
        Console.Write("Coloque su ingreso: ")
        Try
            Dim ingreso As Double = Console.ReadLine()
            If ingreso <= 600 Then
                Console.WriteLine("Su dinero no cumple")
            ElseIf ingreso >= 600 And ingreso <= 700 Then
                Console.WriteLine("Su dinero esta entre 600 y 700")
            End If
            Console.WriteLine("Usted ha ingresado el monto de " & ingreso)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Console.WriteLine("Entrando al error")
        End Try
    End Sub

End Module
