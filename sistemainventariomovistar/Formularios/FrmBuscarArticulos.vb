Imports System.Data.SqlClient

Public Class FrmBuscarArticulos

    Private Sub FrmBuscarArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Llenardatos()

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
                Guna2DgbArticulos.DataSource = tabla
                LblTotal.Text = tabla.Rows.Count
            Else
                Guna2DgbArticulos.DataSource = ""
            End If

        End If
        If Guna2RbnCodigoA.Checked Then
            If Guna2TxtBuscar.Text = " " Then
                Llenardatos()

            End If
            adaptador = New SqlDataAdapter("SELECT Articulo.NombreA,Articulo.NumeroSerie,
            Articulo.CodigoA,Articulo.PrecioCompra,Articulo.FechaCompra,Articulo.EstadoArticulo,
            Articulo.Descripcion FROM Articulo  WHERE Articulo.CodigoA Like '%" & Guna2TxtBuscar.Text & "%' AND Articulo.EstadoArticulo='PENDIENTE' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                Guna2DgbArticulos.DataSource = tabla
                LblTotal.Text = tabla.Rows.Count
            Else
                Guna2DgbArticulos.DataSource = ""
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
                Guna2DgbArticulos.DataSource = tabla
                LblTotal.Text = tabla.Rows.Count
            Else
                Guna2DgbArticulos.DataSource = ""
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
            Guna2DgbArticulos.DataSource = tabla
            LblTotal.Text = tabla.Rows.Count

        Catch ex As Exception
            MsgBox("Se ha encontrado el siguiente error ", ex.ToString + "Sistema inventario")
        End Try
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles Guna2TxtBuscar.TextChanged
        buscardatos()

    End Sub
    Dim FrmcargoActivos As New FrmCargoActivos
    Private Sub DgbArticulos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DgbArticulos.CellDoubleClick
        On Error Resume Next

        FrmcargoActivos.TxtIdArticulo.Text = CStr(Guna2DgbArticulos.Item("IdArticulo", Guna2DgbArticulos.CurrentCell.RowIndex).Value)
        FrmcargoActivos.Guna2TxtNombreArt.Text = CStr(Guna2DgbArticulos.Item("NombreA", Guna2DgbArticulos.CurrentCell.RowIndex).Value)
        FrmcargoActivos.Guna2TxtNSerie.Text = CStr(Guna2DgbArticulos.Item("NumeroSerie", Guna2DgbArticulos.CurrentCell.RowIndex).Value)
        FrmcargoActivos.Guna2TxtCodigo.Text = CStr(Guna2DgbArticulos.Item("CodigoA", Guna2DgbArticulos.CurrentCell.RowIndex).Value)
        Me.Close()

    End Sub
End Class