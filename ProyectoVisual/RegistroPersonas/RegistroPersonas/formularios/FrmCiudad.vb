Public Class FrmCiudad
    Private Sub FrmCiudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarRegistros()
    End Sub

    Sub LlenarRegistros()
        Dim dCiudad As New DCiudades
        DgvRegistros.DataSource = dCiudad.MostrarRegistros.Tables(0)
        DgvRegistros.Refresh()
        GbRegistro.Text = "Registros almacenados: " &
            DgvRegistros.Rows.Count
    End Sub


    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Dim ciudad As New Ciudades()
            ciudad.Nombre = TxtNombre.Text.Trim
            Dim dCiudad As New DCiudades
            If (dCiudad.GuardarRegistros(ciudad)) Then
                MsgBox("Registro guardado exitosamente",
                   MsgBoxStyle.Information, "Ciudades")
            End If
        Catch ex As Exception
            MsgBox("No se pudo guardar el registro",
                   MsgBoxStyle.Critical, "ERROR")
        End Try
        LlenarRegistros()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Dim ciudad As New Ciudades(CInt(TxtId.Text), TxtNombre.Text, True)
        Dim dao As New DCiudades
        If (dao.EditarRegistro(ciudad)) Then
            MsgBox("Registro editado exitosamente",
                   MsgBoxStyle.Information, "Ciudades")
        Else
            MsgBox("No se pudo editar el registro",
                   MsgBoxStyle.Critical, "ERROR")
            LlenarRegistros()
        End If
    End Sub

    'Seleccionando registros de la tabla'
    Private Sub DgvRegistros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvRegistros.CellClick
        Dim fila As Integer = DgvRegistros.CurrentRow.Index
        TxtId.Text = DgvRegistros.Rows(fila).Cells(0).Value
        TxtNombre.Text = DgvRegistros.Rows(fila).Cells(1).Value
    End Sub
End Class