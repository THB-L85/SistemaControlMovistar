Imports System.Data.SqlClient
Public Class FrmBusquedaActivos
    Dim frmdescargoactivos As New frmDescargoActivos
    Private Sub FrmBusquedaActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Llenardatos()
        Guna2TxtBuscar.Focus()

    End Sub
    Sub Llenardatos()
        Dim sql As String
        sql = "SELECT CargoActivos.IdCargo,CargoActivos.CodigoInventario,CargoActivos.FechaAsignacion,
              CargoActivos.EstadoArticulo,CargoActivos.Descripcion,
              Articulo.NombreA,Articulo.IdArticulo,Articulo.NumeroSerie,Articulo.CodigoA,
              Empleados.Nombre,Empleados.Curp,Empleados.IdEmpleado,Departamentos.NombreD FROM Articulo
              INNER JOIN CargoActivos ON Articulo.IdArticulo = CargoActivos.IdArticulo
              INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
              INNER JOIN Departamentos ON Empleados.IdDepartamento = departamentos.IdDepartamento"
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
    Sub buscardatos()
        If Guna2RbNombreE.Checked Then
            If Guna2TxtBuscar.Text = " " Then
                Llenardatos()

            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, CargoActivos.FechaAsignacion,
              CargoActivos.Descripcion,
              Articulo.NombreA, Articulo.IdArticulo, Articulo.NumeroSerie,
              Empleados.Nombre, Empleados.Curp, Empleados.IdEmpleado, Departamentos.NombreD FROM Articulo
              INNER Join CargoActivos ON Articulo.IdArticulo = CargoActivos.IdArticulo
              INNER Join Empleados ON Empleados.IdEmpleado = Empleados.IdEmpleado
              INNER Join Departamentos On Empleados.IdDepartamento = departamentos.IdDepartamento WHERE Empleados.Nombre LIKE '%" & Guna2TxtBuscar.Text & "%' ", obtenerconexion)
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
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, CargoActivos.FechaAsignacion,
              CargoActivos.Descripcion,
              Articulo.NombreA, Articulo.IdArticulo, Articulo.NumeroSerie,Articulo.CodigoA
              Empleados.Nombre, Empleados.Curp, Empleados.IdEmpleado, Departamentos.NombreD FROM Articulo
              INNER Join CargoActivos ON Articulo.IdArticulo = CargoActivos.IdArticulo
              INNER Join Empleados ON Empleados.IdEmpleado = Empleados.IdEmpleado
              INNER Join Departamentos On Empleados.IdDepartamento = departamentos.IdDepartamento WHERE CargoActivos.FechaAsignacion LIKE '%" & Guna2TxtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                Guna2DgbActivos.DataSource = tabla
                LblTotal.Text = tabla.Rows.Count
            Else
                Guna2DgbActivos.DataSource = ""
            End If
        End If
        If Guna2RbnCodigoA.Checked Then
            If Guna2TxtBuscar.Text = " " Then
                Llenardatos()

            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, CargoActivos.FechaAsignacion,
              CargoActivos.Descripcion,
              Articulo.NombreA, Articulo.IdArticulo, Articulo.NumeroSerie,
              Empleados.Nombre, Empleados.Curp, Empleados.IdEmpleado, Departamentos.NombreD FROM Articulo
              INNER Join CargoActivos ON Articulo.IdArticulo = CargoActivos.IdArticulo
              INNER Join Empleados ON Empleados.IdEmpleado = Empleados.IdEmpleado
              INNER Join Departamentos On Empleados.IdDepartamento = departamentos.IdDepartamento WHERE Articulo.CodigoA LIKE '%" & Guna2TxtBuscar.Text & "%' ", obtenerconexion)
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

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles Guna2TxtBuscar.TextChanged
        buscardatos()
    End Sub

    Private Sub Rbfecha_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RbFecha.CheckedChanged
        Guna2TxtBuscar.Focus()

    End Sub

    Private Sub RbCodigoA_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RbnCodigoA.CheckedChanged
        Guna2TxtBuscar.Focus()

    End Sub

    Private Sub DgbCargoActivos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DgbActivos.CellDoubleClick
        On Error Resume Next

        frmdescargoactivos.TxtIdArticulo.Text = CStr(Guna2DgbActivos.Item("IdArticulo", Guna2DgbActivos.CurrentCell.RowIndex).Value)
        frmdescargoactivos.Guna2TxtNombreArt.Text = CStr(Guna2DgbActivos.Item("NombreA", Guna2DgbActivos.CurrentCell.RowIndex).Value)
        frmdescargoactivos.Guna2TxtNSerie.Text = CStr(Guna2DgbActivos.Item("NumeroSerie", Guna2DgbActivos.CurrentCell.RowIndex).Value)

        frmdescargoactivos.TxtIdEmpleado.Text = CStr(Guna2DgbActivos.Item("IdEmpleado", Guna2DgbActivos.CurrentCell.RowIndex).Value)
        frmdescargoactivos.Guna2TxtCurp.Text = CStr(Guna2DgbActivos.Item("Curp", Guna2DgbActivos.CurrentCell.RowIndex).Value)
        frmdescargoactivos.Guna2TxtNombreE.Text = CStr(Guna2DgbActivos.Item("Nombre", Guna2DgbActivos.CurrentCell.RowIndex).Value)
        frmdescargoactivos.Guna2TxtDepartamento.Text = CStr(Guna2DgbActivos.Item("NombreD", Guna2DgbActivos.CurrentCell.RowIndex).Value)


        frmdescargoactivos.TxtIdCargo.Text = CStr(Guna2DgbActivos.Item("IdCargo", Guna2DgbActivos.CurrentCell.RowIndex).Value)
        frmdescargoactivos.Guna2TxtCodigoInv.Text = CStr(Guna2DgbActivos.Item("CodigoInventario", Guna2DgbActivos.CurrentCell.RowIndex).Value)
        frmdescargoactivos.Guna2CboMotivo.Text = CStr(Guna2DgbActivos.Item("EstadoArticulo", Guna2DgbActivos.CurrentCell.RowIndex).Value)
        frmdescargoactivos.Guna2TxtDescripcion.Text = CStr(Guna2DgbActivos.Item("Descripcion", Guna2DgbActivos.CurrentCell.RowIndex).Value)
        frmdescargoactivos.Guna2DTPFechaEntrega.Text = CStr(Guna2DgbActivos.Item("FechaAsignacion", Guna2DgbActivos.CurrentCell.RowIndex).Value)
        Me.Close()

    End Sub

    Private Sub Guna2BtnExit_Click(sender As Object, e As EventArgs) Handles Guna2BtnExit.Click
        Me.Close()
    End Sub
End Class