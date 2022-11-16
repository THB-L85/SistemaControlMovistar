Imports System.Data.SqlClient

Public Class FrmBuscarArticulos

    Private Sub FrmBuscarArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Llenardatos()

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

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        buscardatos()

    End Sub
    Dim FrmcargoActivos As New FrmCargoActivos
    Private Sub DgbArticulos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgbArticulos.CellDoubleClick
        On Error Resume Next

        FrmCargoActivos.TxtIdArticulo.Text = CStr(DgbArticulos.Item("IdArticulo", DgbArticulos.CurrentCell.RowIndex).Value)
        FrmcargoActivos.Guna2TxtNombreArt.Text = CStr(DgbArticulos.Item("NombreA", DgbArticulos.CurrentCell.RowIndex).Value)
        FrmcargoActivos.Guna2TxtNSerie.Text = CStr(DgbArticulos.Item("NumeroSerie", DgbArticulos.CurrentCell.RowIndex).Value)
        FrmcargoActivos.Guna2TxtCodigo.Text = CStr(DgbArticulos.Item("CodigoA", DgbArticulos.CurrentCell.RowIndex).Value)
        Me.Close()

    End Sub
End Class