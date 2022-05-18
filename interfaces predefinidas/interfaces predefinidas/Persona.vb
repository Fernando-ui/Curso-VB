Public Class Persona
    Private nombres As String
    Private edad As Integer
    Public Sub New(nom As String, e As Integer)
        nombres = nom
        edad = e
    End Sub
    Public Function getNombres() As String
        Return nombres
    End Function
    Public Function getEdad() As String
        Return edad
    End Function
End Class
