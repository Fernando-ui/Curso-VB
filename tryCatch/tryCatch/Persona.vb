Public Class Persona
    Public nombre As String
    Public id As Integer
    Public edad As Integer
    Public Sub New(name As String, i As Integer, ed As Integer)
        nombre = name
        id = i
        edad = ed
    End Sub
    Public Sub datos(nombre, id, edad)
        Try
            Console.WriteLine(nombre)
            Console.WriteLine(id)
            Console.WriteLine(edad)

        Catch ex As Exception
            Console.WriteLine(ex)
            Console.WriteLine("Tenemos un error con la ejecucion")
        End Try
    End Sub

End Class
