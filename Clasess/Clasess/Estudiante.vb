Public Class Estudiante
    Inherits AireAcondicionado
    Public Sub New(ma As String, co As String, vo As Integer, b As Integer, estudiara As String)
        MyBase.New(ma, co, vo, b)

    End Sub
    Private codigoEstudiante As Integer
    Private nombres As String
    Private Shared codigo As Integer = 1


    Public Function getCodigoEstudiante() As Integer
        Return codigoEstudiante
    End Function
    Public Function getNombre() As String
        Return nombres
    End Function
End Class
