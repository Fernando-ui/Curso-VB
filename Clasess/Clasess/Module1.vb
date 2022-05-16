Module Module1

    Sub Main()
        Dim elAire As AireAcondicionado = New AireAcondicionado()
        elAire.color = "azul"
        elAire.modelo = "no se cual modelo"
        elAire.marca = "La mejor de todas"
        elAire.voltaje = 233
        elAire.btu = 3324
        elAire.temperatura = 0

        Console.WriteLine(elAire.color)
        Console.WriteLine(elAire.modelo)
        Console.WriteLine(elAire.marca)
        Console.WriteLine(elAire.voltaje)
        Console.WriteLine(elAire.btu)
        elAire.subirTemperatura()
        Console.WriteLine(elAire.temperatura)
    End Sub

End Module
