Module Module1
    Dim soyGlobal As Integer = 2323
    Sub Main()
        Dim numero As Integer = 26
        Console.WriteLine(numero)
        Const PALABRA As String = "helloo"
        Console.WriteLine(PALABRA)
        Const NUMEERO As Double = 23.5
        Console.WriteLine(NUMEERO)
        Dim letra As Char = "p"
        Console.WriteLine(letra)
        Console.WriteLine(soyGlobal)
        Dim variable As String = "kjsd"

        soyGlobal = 2323

        ' Sumas aritmeticas 
        Dim suma As Double = 2 + 3
        Console.WriteLine(suma)

        Dim division As Double = 3 / 2
        Console.WriteLine(division)

        Dim resta As Integer = 2 - 2
        Console.WriteLine(resta)

        Dim multiplicacion As Integer = 2 * 2
        Console.WriteLine(multiplicacion)

        Dim modulo As Double = 3 Mod 2
        Console.WriteLine(modulo)

        Dim adicion As Integer = 3
        adicion += adicion
        Console.WriteLine(adicion)

        Dim res As Integer = 3
        res -= res
        Console.WriteLine(res)

        Dim condicion As Boolean = 3 > 2
        Console.WriteLine(condicion)

        ' Entrada de nombres
        Console.Write("Ingrese su nombre ")
        Dim miNombre As String = Console.ReadLine()
        ' Console.Write(miNombre)
        Console.WriteLine("hola " & miNombre & " Como te encuentras")

        ' Condicionales if Else
        If 3 > 4 Then
            Console.WriteLine("Es cierta la condicin")
        Else
            Console.WriteLine("No se ha cumplido")
        End If
    End Sub


End Module
