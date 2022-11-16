Imports System.Data.SqlClient
Public Class FrmArticulos
    Private Sub FrmArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarcontroles()
        Llenardatos()
        DgbArticulos.AutoGenerateColumns = False
        DgbArticulos.Columns("PrecioCompra").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight 'centrar a la derecha
        DgbArticulos.Columns("PrecioCompra").DefaultCellStyle.Format = "N2" 'decimales
    End Sub


    Sub desactivarcontroles()
        BtnGuardar.Enabled = False
        BtnEditar.Enabled = False
        BtnCancelar.Enabled = False
        BtnBorrar.Enabled = False

        txtNombreA.Enabled = False
        TxtCodigo.Enabled = False
        TxtNserie.Enabled = False
        TxtPrecio.Enabled = False
        TxtDescripcion.Enabled = False
        DTPFechacompra.Enabled = False
        BtnNuevo.Enabled = True
    End Sub
    Sub activarcontroles()
        BtnGuardar.Enabled = True
        BtnEditar.Enabled = False
        BtnCancelar.Enabled = True
        BtnBorrar.Enabled = False

        txtNombreA.Enabled = True
        TxtCodigo.Enabled = True
        TxtNserie.Enabled = True
        TxtPrecio.Enabled = True
        TxtDescripcion.Enabled = True
        DTPFechacompra.Enabled = True
        BtnNuevo.Enabled = False
    End Sub
    Sub limpiarcontroles()
        txtNombreA.Text = ""
        TxtCodigo.Text = ""
        TxtDescripcion.Text = ""
        DTPFechacompra.Text = ""
        TxtNserie.Text = ""
        TxtPrecio.Text = ""
        TxtId.Text = ""
        TxtBuscar.Text = ""

    End Sub
    Sub insertar()
        Dim sql As String
        Dim id As Integer
        If MsgBox("Guardar Nuevo Registro", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
            Exit Sub

        End If
        adaptador = New SqlDataAdapter("SELECT * FROM Articulo Where CodigoA = '" & TxtCodigo.Text & "' ", obtenerconexion)
        tabla.Clear() 'borra datos que trae datatable
        adaptador.Fill(tabla) 'actualiza o agrega dataset
        If tabla.Rows.Count > 0 Then
            TxtCodigo.Text = tabla.Rows(0).Item("CodigoA")
            MsgBox("El registro ya se encuentra en la base de datos ", vbInformation, "Sistema inventario")
            Exit Sub

        End If
        If txtNombreA.Text = "" Or TxtCodigo.Text = "" Then
            MsgBox("Completar todos los campos", vbCritical, "Sistema inventario")
            Exit Sub
        Else
            sql = "INSERT INTO Articulo(NombreA,NumeroSerie,CodigoA,PrecioCompra,FechaCompra,EstadoArticulo,Descripcion)" & " VALUES
           ('" & txtNombreA.Text & "','" & TxtNserie.Text & "','" & TxtCodigo.Text & "','" & TxtPrecio.Text & "',
           '" & DTPFechacompra.Text & "','PENDIENTE','" & TxtDescripcion.Text & "')"

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
        If rbNombreA.Checked Then
            If TxtBuscar.Text = " " Then
                Llenardatos()

            End If
            adaptador = New SqlDataAdapter("SELECT Articulo.NombreA,Articulo.NumeroSerie,
            Articulo.CodigoA,Articulo.PrecioCompra,Articulo.FechaCompra,Articulo.EstadoArticulo,
            Articulo.Descripcion FROM Articulo  WHERE Articulo.NombreA Like '%" & TxtBuscar.Text & "%' AND Articulo.EstadoArticulo='PENDIENTE' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                DgbArticulos.DataSource = tabla
                LblTotal.Text = tabla.Rows.Count
            Else
                DgbArticulos.DataSource = ""
            End If

        End If
        If RbCodigoA.Checked Then
            If TxtBuscar.Text = " " Then
                Llenardatos()

            End If
            adaptador = New SqlDataAdapter("SELECT Articulo.NombreA,Articulo.NumeroSerie,
            Articulo.CodigoA,Articulo.PrecioCompra,Articulo.FechaCompra,Articulo.EstadoArticulo,
            Articulo.Descripcion FROM Articulo  WHERE Articulo.CodigoA Like '%" & TxtBuscar.Text & "%' AND Articulo.EstadoArticulo='PENDIENTE' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                DgbArticulos.DataSource = tabla
                LblTotal.Text = tabla.Rows.Count
            Else
                DgbArticulos.DataSource = ""
            End If

        End If
        If Rbfecha.Checked Then
            If TxtBuscar.Text = " " Then
                Llenardatos()

            End If
            adaptador = New SqlDataAdapter("SELECT Articulo.NombreA,Articulo.NumeroSerie,
            Articulo.CodigoA,Articulo.PrecioCompra,Articulo.FechaCompra,Articulo.EstadoArticulo,
            Articulo.Descripcion FROM Articulo  WHERE Articulo.FechaCompra Like '%" & TxtBuscar.Text & "%' AND Articulo.EstadoArticulo='PENDIENTE'", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                DgbArticulos.DataSource = tabla
                LblTotal.Text = tabla.Rows.Count
            Else
                DgbArticulos.DataSource = ""
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
            DgbArticulos.DataSource = tabla
            LblTotal.Text = tabla.Rows.Count

        Catch ex As Exception
            MsgBox("Se ha encontrado el siguiente error ", ex.ToString + "Sistema inventario")
        End Try
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        activarcontroles()
        limpiarcontroles()

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        insertar()
        Llenardatos()
        desactivarcontroles()
        limpiarcontroles()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        desactivarcontroles()
        limpiarcontroles()

    End Sub

    Private Sub RbCodigoA_CheckedChanged(sender As Object, e As EventArgs) Handles RbCodigoA.CheckedChanged
        TxtBuscar.Focus()

    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        buscardatos()
    End Sub

    Private Sub rbNombreA_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombreA.CheckedChanged
        TxtBuscar.Focus()

    End Sub

    Private Sub Rbfecha_CheckedChanged(sender As Object, e As EventArgs) Handles Rbfecha.CheckedChanged
        TxtBuscar.Focus()

    End Sub

    Private Sub DgbArticulos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgbArticulos.CellDoubleClick
        On Error Resume Next

        TxtId.Text = CStr(DgbArticulos.Item("IdArticulo", DgbArticulos.CurrentCell.RowIndex).Value)
        txtNombreA.Text = CStr(DgbArticulos.Item("NombreA", DgbArticulos.CurrentCell.RowIndex).Value)
        TxtCodigo.Text = CStr(DgbArticulos.Item("CodigoA", DgbArticulos.CurrentCell.RowIndex).Value)
        TxtNserie.Text = CStr(DgbArticulos.Item("NumeroSerie", DgbArticulos.CurrentCell.RowIndex).Value)
        TxtPrecio.Text = CStr(DgbArticulos.Item("PrecioCompra", DgbArticulos.CurrentCell.RowIndex).Value)
        TxtDescripcion.Text = CStr(DgbArticulos.Item("Descripcion", DgbArticulos.CurrentCell.RowIndex).Value)
        DTPFechacompra.Text = CStr(DgbArticulos.Item("FechaCompra", DgbArticulos.CurrentCell.RowIndex).Value)
        BtnCancelar.Enabled = True
        BtnEditar.Enabled = True
        BtnBorrar.Enabled = True

        txtNombreA.Enabled = True
        TxtNserie.Enabled = True
        TxtCodigo.Enabled = True
        TxtPrecio.Enabled = True
        TxtDescripcion.Enabled = True
        DTPFechacompra.Enabled = True
        txtNombreA.Focus()
        BtnBuscar.Enabled = False
        BtnNuevo.Enabled = False
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Editar()
        desactivarcontroles()
        Llenardatos()

    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
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
            sql = "UPDATE Articulo SET NombreA ='" & txtNombreA.Text & "',NumeroSerie= '" & TxtNserie.Text & "', 
            CodigoA='" & TxtCodigo.Text & "',PrecioCompra ='" & TxtPrecio.Text & "',FechaCompra='" & DTPFechacompra.Text & "',
            Descripcion= '" & TxtDescripcion.Text & "' WHERE IdArticulo= '" & TxtId.Text & "'"
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
            If MsgBox("¿seguro de eliminar a" + Trim(txtNombreA.Text) + "De su registro?" + vbCr + "Esta accion ya no se puede revertir.", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
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

    Private Sub TxtPrecio_TextChanged(sender As Object, e As EventArgs) Handles TxtPrecio.TextChanged

    End Sub
End Class