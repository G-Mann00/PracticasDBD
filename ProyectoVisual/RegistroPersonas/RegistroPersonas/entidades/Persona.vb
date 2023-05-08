Public Class Persona

    'Atributos'
    Dim _id As Integer
    Dim _primerNombre As String
    Dim _segundoNombre As String
    Dim _primerApellido As String
    Dim _segundoApellido As String
    Dim _fechaNac As DateTime
    Dim _sexo As Boolean
    Dim _telefono As String
    Dim _email As String
    Dim _idCiudad As Integer
    Dim _direccion As String
    Dim _estado As Boolean

    'Constructor'
    Public Sub New(id As Integer, primerNombre As String, segundoNombre As String, primerApellido As String, segundoApellido As String, fechaNac As Date, sexo As Boolean?, telefono As String, email As String, idCiudad As Integer?, direccion As String, estado As Boolean?, ciudad As Ciudad)
        Me.id = id
        Me.primerNombre = primerNombre
        Me.segundoNombre = segundoNombre
        Me.primerApellido = primerApellido
        Me.segundoApellido = segundoApellido
        Me.fechaNac = fechaNac
        Me.sexo = sexo
        Me.telefono = telefono
        Me.email = email
        Me.idCiudad = idCiudad
        Me.direccion = direccion
        Me.estado = estado
        Me.Ciudad = ciudad
    End Sub
End Class
