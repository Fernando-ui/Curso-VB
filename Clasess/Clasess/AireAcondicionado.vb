Public Class AireAcondicionado
    Public marca As String
    Public modelo As String
    Public color As String
    Public voltaje As Integer
    Public btu As Integer
    Public temperatura As Integer
    Private contrasenia As String
    Public Sub New(ma As String, co As String, vo As Integer, b As Integer)
        marca = ma
        color = co
        voltaje = vo
        btu = b
        modelo = marca.Substring(0, 2) & voltaje.ToString

    End Sub
    Public Sub New(co As String, vo As Integer, b As Integer)
        color = co
        voltaje = vo
        btu = b
        modelo = marca.Substring(0, 2) & voltaje.ToString
        ' Estaremos colocando un constructor sobrecargado
    End Sub

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

    Public Sub setMarca(ma As String)
        marca = ma
    End Sub
    Public Function getMarca() As String
        Return marca
    End Function
End Class
