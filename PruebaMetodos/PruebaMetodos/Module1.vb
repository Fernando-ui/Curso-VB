Module Module1

    Sub Main()
        Console.WriteLine("Tenemos el procedimiento del primero")
        mostrarNombre()
        nombresColocados("Fernando", "Sosa")
        Dim numero = 3
        cambiarNumeroVariable(numero)
        Console.WriteLine(numero)
    End Sub
    Sub mostrarNombre()
        Console.WriteLine("Como se llaman")
    End Sub
    Sub nombresColocados(nombre1 As String, nombre2 As String)
        Console.WriteLine(nombre1, nombre2)

    End Sub

    Sub cambiarNumeroVariable(ByRef numero As Integer)
        numero = 20

    End Sub
End Module