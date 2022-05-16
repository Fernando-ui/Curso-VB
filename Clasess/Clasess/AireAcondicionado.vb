Public Class AireAcondicionado
    Public marca As String
    Public modelo As String
    Public color As String
    Public voltaje As Integer
    Public btu As Integer
    Public temperatura As Integer
    Private contrasenia As String

    Public Sub subirTemperatura()
        temperatura += 1
        contrasenia = "asdkjf"
        Console.WriteLine(contrasenia)
    End Sub
    Public Sub bajarTemperatura()
        temperatura -= 1
    End Sub
    Public Function darTemperaturaActual() As Integer
        Return temperatura
    End Function
End Class
