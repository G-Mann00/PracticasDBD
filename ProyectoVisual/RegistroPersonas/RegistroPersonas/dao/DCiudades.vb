Imports System.Data.SqlClient
Public Class DCiudades
    Dim strConn As String = My.Settings.StrConnection.ToString()

    Public Function MostrarRegistros() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConn)
            Dim tSql As String = "Select idCiudad as N'Codigo', nombreCiudad as N'Ciudad' from Ciudad"
            Dim da As New SqlDataAdapter(tSql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al obtener los registros " & ex.Message,
                   MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function

    'Guardando registro'
    Public Function GuardarRegistros(ByVal ciudad As Ciudades) As Boolean
        Dim resultado As Boolean = False
        Try
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            Dim tsql = "insert into Ciudad(nombreCiudad) values(@nombre)"
            cmd.Parameters.AddWithValue("@nombre", ciudad.Nombre)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Connection = conn
            cmd.Connection.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                resultado = True
            End If
            cmd.Connection.Close()
        Catch ex As Exception
            MsgBox("Error al intentar guardar los datos",
                   MsgBoxStyle.Critical, "ERROR")
        End Try
        Return resultado
    End Function

    'Editando registro'
    Public Function EditarRegistro(ByVal ciudad As Ciudades)
        Dim flag = False
        Try
            Dim tsql = "UPDATE Ciudad SET nombreCiudad = @nombre, estado = @estado where idCiudad = @id"
            Dim conn As New SqlConnection(My.Settings.StrConnection)
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@nombre", ciudad.Nombre)
            cmd.Parameters.AddWithValue("@estado", ciudad.Estado)
            cmd.Parameters.AddWithValue("@id", ciudad.Id)
            cmd.Connection.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                flag = True
            End If
            cmd.Connection.Close()
        Catch ex As Exception
            MsgBox("Error al intentar modificar los datos",
                   MsgBoxStyle.Critical, "ERROR")
        End Try
        Return flag
    End Function
End Class
