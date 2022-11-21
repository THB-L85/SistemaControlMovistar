Imports System.Data.SqlClient
Public Class FrmArticulos
    Private Sub FrmArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarcontroles()
        Llenardatos()
        Guna2DgbActivos.AutoGenerateColumns = False
        Guna2DgbActivos.Columns("PrecioCompra").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight 'centrar a la derecha
        Guna2DgbActivos.Columns("PrecioCompra").DefaultCellStyle.Format = "N2" 'decimales
    End Sub


    Sub desactivarcontroles()
        Guna2BtnGuardar.Enabled = False
        Guna2BntEditar.Enabled = False
        Guna2BtnCancelar.Enabled = False
        Guna2BtnBorrar.Enabled = False

        Guna2TxtNombreA.Enabled = False
        Guna2TxtCodigo.Enabled = False
        Guna2TxtNSerie.Enabled = False
        Guna2TxtPrecio.Enabled = False
        Guna2TxtDescripcion.Enabled = False
        Guna2DTPFechaEntrega.Enabled = False
        Guna2BtnNuevo.Enabled = True
    End Sub
    Sub activarcontroles()
        Guna2BtnGuardar.Enabled = True
        Guna2BntEditar.Enabled = False
        Guna2BtnCancelar.Enabled = True
        Guna2BtnBorrar.Enabled = False

        Guna2TxtNombreA.Enabled = True
        Guna2TxtCodigo.Enabled = True
        Guna2TxtNSerie.Enabled = True
        Guna2TxtPrecio.Enabled = True
        Guna2TxtDescripcion.Enabled = True
        Guna2DTPFechaEntrega.Enabled = True
        Guna2BtnNuevo.Enabled = False
    End Sub
    Sub limpiarcontroles()
        Guna2TxtNombreA.Text = ""
        Guna2TxtCodigo.Text = ""
        Guna2TxtDescripcion.Text = ""
        Guna2DTPFechaEntrega.Text = ""
        Guna2TxtNSerie.Text = ""
        Guna2TxtPrecio.Text = ""
        TxtId.Text = ""
        Guna2TxtBuscar.Text = ""

    End Sub
    Sub insertar()
        Dim sql As String
        Dim id As Integer
        If MsgBox("Guardar Nuevo Registro", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
            Exit Sub

        End If
        adaptador = New SqlDataAdapter("SELECT * FROM Articulo Where CodigoA = '" & Guna2TxtCodigo.Text & "' ", obtenerconexion)
        tabla.Clear() 'borra datos que trae datatable
        adaptador.Fill(tabla) 'actualiza o agrega dataset
        If tabla.Rows.Count > 0 Then
            Guna2TxtCodigo.Text = tabla.Rows(0).Item("CodigoA")
            MsgBox("El registro ya se encuentra en la base de datos ", vbInformation, "Sistema inventario")
            Exit Sub

        End If
        If Guna2TxtNombreA.Text = "" Or Guna2TxtCodigo.Text = "" Then
            MsgBox("Completar todos los campos", vbCritical, "Sistema inventario")
            Exit Sub
        Else
            sql = "INSERT INTO Articulo(NombreA,NumeroSerie,CodigoA,PrecioCompra,FechaCompra,EstadoArticulo,Descripcion)" & " VALUES
           ('" & Guna2TxtNombreA.Text & "','" & Guna2TxtNSerie.Text & "','" & Guna2TxtCodigo.Text & "','" & Guna2TxtPrecio.Text & "',
           '" & Guna2DTPFechaEntrega.Text & "','PENDIENTE','" & Guna2TxtDescripcion.Text & "')"

            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()
            MsgBox("Registro realizado correctamente", vbInformation, "Sistema inventario")
        End If

    End Sub
    Sub buscardatos()
        If Guna2RbNombreA.Checked Then
            If Guna2TxtBuscar.Text = " " Then
                Llenardatos()

            End If
            adaptador = New SqlDataAdapter("SELECT Articulo.NombreA,Articulo.NumeroSerie,
            Articulo.CodigoA,Articulo.PrecioCompra,Articulo.FechaCompra,Articulo.EstadoArticulo,
            Articulo.Descripcion FROM Articulo  WHERE Articulo.NombreA Like '%" & Guna2TxtBuscar.Text & "%' AND Articulo.EstadoArticulo='PENDIENTE' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                Guna2DgbActivos.DataSource = tabla
                LblTotal.Text = tabla.Rows.Count
            Else
                Guna2DgbActivos.DataSource = ""
            End If

        End If
        If Guna2RbCodigoA.Checked Then
            If Guna2TxtBuscar.Text = " " Then
                Llenardatos()

            End If
            adaptador = New SqlDataAdapter("SELECT Articulo.NombreA,Articulo.NumeroSerie,
            Articulo.CodigoA,Articulo.PrecioCompra,Articulo.FechaCompra,Articulo.EstadoArticulo,
            Articulo.Descripcion FROM Articulo  WHERE Articulo.CodigoA Like '%" & Guna2TxtBuscar.Text & "%' AND Articulo.EstadoArticulo='PENDIENTE' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                Guna2DgbActivos.DataSource = tabla
                LblTotal.Text = tabla.Rows.Count
            Else
                Guna2DgbActivos.DataSource = ""
            End If

        End If
        If Guna2RbFecha.Checked Then
            If Guna2TxtBuscar.Text = " " Then
                Llenardatos()

            End If
            adaptador = New SqlDataAdapter("SELECT Articulo.NombreA,Articulo.NumeroSerie,
            Articulo.CodigoA,Articulo.PrecioCompra,Articulo.FechaCompra,Articulo.EstadoArticulo,
            Articulo.Descripcion FROM Articulo  WHERE Articulo.FechaCompra Like '%" & Guna2TxtBuscar.Text & "%' AND Articulo.EstadoArticulo='PENDIENTE'", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                Guna2DgbActivos.DataSource = tabla
                LblTotal.Text = tabla.Rows.Count
            Else
                Guna2DgbActivos.DataSource = ""
            End If

        End If



    End Sub


    Sub Llenardatos()
        Dim sql As String
        sql = "SELECT Articulo.IdArticulo,Articulo.NombreA,Articulo.NumeroSerie,Articulo.CodigoA,
              Articulo.PrecioCompra,Articulo.FechaCompra,Articulo.EstadoArticulo,Articulo.Descripcion FROM Articulo WHERE Articulo.EstadoArticulo='PENDIENTE'"
        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            Guna2DgbActivos.DataSource = tabla
            LblTotal.Text = tabla.Rows.Count

        Catch ex As Exception
            MsgBox("Se ha encontrado el siguiente error ", ex.ToString + "Sistema inventario")
        End Try
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles Guna2BtnNuevo.Click
        activarcontroles()
        limpiarcontroles()

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles Guna2BtnGuardar.Click
        insertar()
        Llenardatos()
        desactivarcontroles()
        limpiarcontroles()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles Guna2BtnCancelar.Click
        desactivarcontroles()
        limpiarcontroles()

    End Sub

    Private Sub RbCodigoA_CheckedChanged(sender As Object, e As EventArgs)
        Guna2TxtBuscar.Focus()

    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs)
        buscardatos()
    End Sub

    Private Sub rbNombreA_CheckedChanged(sender As Object, e As EventArgs)
        Guna2TxtBuscar.Focus()

    End Sub

    Private Sub Rbfecha_CheckedChanged(sender As Object, e As EventArgs)
        Guna2TxtBuscar.Focus()

    End Sub

    Private Sub DgbArticulos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        On Error Resume Next

        TxtId.Text = CStr(Guna2DgbActivos.Item("IdArticulo", Guna2DgbActivos.CurrentCell.RowIndex).Value)
        Guna2TxtNombreA.Text = CStr(Guna2DgbActivos.Item("NombreA", Guna2DgbActivos.CurrentCell.RowIndex).Value)
        Guna2TxtCodigo.Text = CStr(Guna2DgbActivos.Item("CodigoA", Guna2DgbActivos.CurrentCell.RowIndex).Value)
        Guna2TxtNSerie.Text = CStr(Guna2DgbActivos.Item("NumeroSerie", Guna2DgbActivos.CurrentCell.RowIndex).Value)
        Guna2TxtPrecio.Text = CStr(Guna2DgbActivos.Item("PrecioCompra", Guna2DgbActivos.CurrentCell.RowIndex).Value)
        Guna2TxtDescripcion.Text = CStr(Guna2DgbActivos.Item("Descripcion", Guna2DgbActivos.CurrentCell.RowIndex).Value)
        Guna2DTPFechaEntrega.Text = CStr(Guna2DgbActivos.Item("FechaCompra", Guna2DgbActivos.CurrentCell.RowIndex).Value)
        Guna2BtnCancelar.Enabled = True
        Guna2BntEditar.Enabled = True
        Guna2BtnBorrar.Enabled = True

        Guna2TxtNombreA.Enabled = True
        Guna2TxtNSerie.Enabled = True
        Guna2TxtCodigo.Enabled = True
        Guna2TxtPrecio.Enabled = True
        Guna2TxtDescripcion.Enabled = True
        Guna2DTPFechaEntrega.Enabled = True
        Guna2TxtNombreA.Focus()
        BtnBuscar.Enabled = False
        Guna2BtnNuevo.Enabled = False
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles Guna2BntEditar.Click
        Editar()
        desactivarcontroles()
        Llenardatos()

    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles Guna2BtnBorrar.Click
        Eliminar()
        desactivarcontroles()
        Llenardatos()
    End Sub
    Sub Editar()
        Dim id As Integer
        If TxtId.Text = 0 Then
            MsgBox("Existen datos vacios", vbInformation, "Sistema de inventario")
        Else
            Dim sql As String
            sql = "UPDATE Articulo SET NombreA ='" & Guna2TxtNombreA.Text & "',NumeroSerie= '" & Guna2TxtNSerie.Text & "', 
            CodigoA='" & Guna2TxtCodigo.Text & "',PrecioCompra ='" & Guna2TxtPrecio.Text & "',FechaCompra='" & Guna2DTPFechaEntrega.Text & "',
            Descripcion= '" & Guna2TxtDescripcion.Text & "' WHERE IdArticulo= '" & TxtId.Text & "'"
            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()
            MsgBox("Registro Editado correctamente", vbInformation, "Sistema inventario")
            limpiarcontroles()

        End If
    End Sub
    Sub Eliminar()
        Dim id As Integer
        If TxtId.Text = 0 Then
            MsgBox("Existen datos vacios", vbInformation, "Sistema de inventario")
        Else
            If MsgBox("¿seguro de eliminar a" + Trim(Guna2TxtNombreA.Text) + "De su registro?" + vbCr + "Esta accion ya no se puede revertir.", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
                limpiarcontroles()
                desactivarcontroles()
                Exit Sub
            Else


                Dim sql As String
                sql = "DELETE FROM Articulo WHERE IdArticulo = " & Trim(TxtId.Text)
                Dim conect As New SqlConnection(obtenerconexion)
                conect.Open()
                Using comando As New SqlCommand(sql, conect)
                    id = comando.ExecuteScalar()
                End Using
                conect.Close()
                MsgBox("Registro Eliminado correctamente", vbInformation, "Sistema inventario")
                limpiarcontroles()
            End If
        End If
    End Sub

    Private Sub TxtPrecio_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2TxtCodigo_TextChanged(sender As Object, e As EventArgs) Handles Guna2TxtNombreA.TextChanged

    End Sub

    Private Sub Guna2BtnExit_Click(sender As Object, e As EventArgs) Handles Guna2BtnExit.Click
        Me.Close()
        FrmMain.Visible = True
    End Sub
End Class