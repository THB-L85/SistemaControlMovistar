Imports System.Data.SqlClient
Public Class frmDescargoActivos
    Private Sub frmDescargoActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarcontroles()
        limpiarcontroles()
        ' Llenardatos()

        Guna2TxtCodigoInv.AutoCompleteMode = AutoCompleteMode.Suggest
        Guna2TxtCodigoInv.AutoCompleteSource = AutoCompleteSource.CustomSource
        Guna2TxtCodigoInv.AutoCompleteCustomSource = obtenercodigoinventario()

        'TxtCurp.AutoCompleteMode = AutoCompleteMode.Suggest
        'TxtCurp.AutoCompleteSource = AutoCompleteSource.CustomSource
        'TxtCurp.AutoCompleteCustomSource = obtenerIdentidades()

        Guna2DgbDescargoActivos.AutoGenerateColumns = False

    End Sub
    Sub desactivarcontroles()
        Guna2BtnGuardar.Enabled = False
        Guna2BntEditar.Enabled = False
        Guna2BtnCancelar.Enabled = False
        Guna2BtnBorrar.Enabled = False
        Guna2BtnCodigoInv.Enabled = False

        Guna2TxtNombreArt.Enabled = False
        Guna2TxtCodigoInv.Enabled = False
        Guna2TxtNSerie.Enabled = False
        Guna2TxtCodigoInv.Enabled = False
        Guna2TxtDescripcion.Enabled = False
        Guna2TxtCurp.Enabled = False
        Guna2TxtDepartamento.Enabled = False
        Guna2TxtNombreE.Enabled = False
        Guna2CboMotivo.Enabled = False
        Guna2DTPFechaEntrega.Enabled = False
        Guna2DtpDescargo.Enabled = False

        Guna2BtnNuevo.Enabled = True
    End Sub
    Sub activarcontroles()
        Guna2BtnGuardar.Enabled = True
        Guna2BntEditar.Enabled = False
        Guna2BtnCancelar.Enabled = True
        Guna2BtnBorrar.Enabled = False
        Guna2BtnCodigoInv.Enabled = True


        Guna2TxtNombreArt.Enabled = True
        Guna2TxtCodigoInv.Enabled = True
        Guna2TxtNSerie.Enabled = True
        Guna2TxtCodigoInv.Enabled = True
        Guna2TxtDescripcion.Enabled = True
        Guna2TxtCurp.Enabled = True
        Guna2TxtDepartamento.Enabled = True
        Guna2TxtNombreE.Enabled = True
        Guna2CboMotivo.Enabled = True
        Guna2DTPFechaEntrega.Enabled = False
        Guna2DtpDescargo.Enabled = True


        Guna2BtnNuevo.Enabled = False
    End Sub
    Sub limpiarcontroles()
        Guna2TxtNombreArt.Clear()
        Guna2TxtCodigoInv.Clear()
        Guna2TxtNSerie.Clear()
        Guna2TxtCodigoInv.Clear()
        Guna2TxtDescripcion.Clear()
        Guna2TxtCurp.Clear()
        Guna2TxtDepartamento.Clear()
        Guna2TxtNombreE.Clear()
        Guna2CboMotivo.Text = ""
        Guna2DTPFechaEntrega.Text = ""
        Guna2DtpDescargo.Text = ""
    End Sub
    Private Function obtenercodigoinventario() As AutoCompleteStringCollection
        adaptador = New SqlDataAdapter("SELECT CodigoInventario FROM CargoActivos ", obtenerconexion)
        Dim dt As New DataTable("CargoActivos")
        adaptador.Fill(dt)
        Dim ListarDatos As New AutoCompleteStringCollection()
        For Each row As DataRow In dt.Rows
            ListarDatos.Add(CStr(row(0)))
        Next
        Return ListarDatos
    End Function

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles Guna2BtnNuevo.Click
        activarcontroles()
        limpiarcontroles()

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles Guna2BtnCancelar.Click
        desactivarcontroles()
        limpiarcontroles()

    End Sub

    Private Sub TxtCodigoInv_TextChanged(sender As Object, e As EventArgs)
        If Guna2TxtCodigoInv.Text <> "" Then
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo,CargoActivos.fechaAsignacion,Articulo.IdArticulo,
            Articulo.NombreA,Articulo.NumeroSerie,Empleados.Nombre,Empleados.Curp,Departamentos.NombreD
            FROM Articulo INNER JOIN CargoActivos ON Articulo.IdArticulo = CargoActivos.IdArticulo 
                          INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                          INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento
                          WHERE CargoActivos.CodigoInventario='" & Guna2TxtCodigoInv.Text & "'", obtenerconexion)
            Dim tabla As New DataTable
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count = 1 Then
                Dim fila As DataRow = tabla.Rows(0)
                Guna2TxtNombreArt.Text = fila("NombreA").ToString
                Guna2TxtNSerie.Text = fila("NumeroSerie").ToString
                TxtIdArticulo.Text = fila("idArticulo").ToString
                Guna2TxtCurp.Text = fila("Curp").ToString
                Guna2TxtNombreE.Text = fila("Nombre").ToString
                Guna2TxtDepartamento.Text = fila("NombreD").ToString
                Guna2DTPFechaEntrega.Text = fila("fechaAsignacion").ToString
            Else
                Guna2TxtNombreArt.Clear()
                Guna2TxtCodigoInv.Focus()
            End If
        End If
    End Sub
    Sub buscardatos()
        If Guna2RbNombreA.Checked Then
            If Guna2TxtBuscar.Text = " " Then
                Llenardatos()

            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo,CargoActivos.CodigoInventario,
              Articulo.NombreA,Articulo.IdArticulo,Articulo.NumeroSerie,
              Empleados.Nombre,Empleados.Curp,Departamentos.NombreD,
              DescargoActivos.IdDescargo,DescargoActivos.FechaDescargo,DescargoActivos.motivo,
              DescargoActivos.Descripcion FROM Articulo
              INNER JOIN CargoActivos ON Articulo.IdArticulo = CargoActivos.IdArticulo
              INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
              INNER JOIN Departamentos ON Empleados.IdDepartamento = departamentos.IdDepartamento
              INNER JOIN DescargoActivos ON CargoActivos.Idcargo = DescargoActivos.IdCargoActivo
              WHERE Empleados.Nombre Like '%" & Guna2TxtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                Guna2DgbDescargoActivos.DataSource = tabla
                LblTotal.Text = tabla.Rows.Count
            Else
                Guna2DgbDescargoActivos.DataSource = ""
            End If

        End If
        If Guna2RbFecha.Checked Then
            If Guna2TxtBuscar.Text = " " Then
                Llenardatos()

            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo,CargoActivos.CodigoInventario,
              Articulo.NombreA,Articulo.IdArticulo,Articulo.NumeroSerie,
              Empleados.Nombre,Empleados.Curp,Departamentos.NombreD,
              DescargoActivos.IdDescargo,DescargoActivos.FechaDescargo,DescargoActivos.motivo,
              DescargoActivos.Descripcion FROM Articulo
              INNER JOIN CargoActivos ON Articulo.IdArticulo = CargoActivos.IdArticulo
              INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
              INNER JOIN Departamentos ON Empleados.IdDepartamento = departamentos.IdDepartamento
              INNER JOIN DescargoActivos ON CargoActivos.Idcargo = DescargoActivos.IdCargoActivo WHERE DescargoActivos.FechaDescargo LIKE '%" & Guna2TxtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                Guna2DgbDescargoActivos.DataSource = tabla
                LblTotal.Text = tabla.Rows.Count
            Else
                Guna2DgbDescargoActivos.DataSource = ""
            End If
        End If
        If Guna2RbCodigoA.Checked Then
            If Guna2TxtBuscar.Text = " " Then
                Llenardatos()

            End If
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo,CargoActivos.CodigoInventario,
              Articulo.NombreA,Articulo.IdArticulo,Articulo.NumeroSerie,
              Empleados.Nombre,Empleados.Curp,Departamentos.NombreD,
              DescargoActivos.IdDescargo,DescargoActivos.FechaDescargo,DescargoActivos.motivo,
              DescargoActivos.Descripcion FROM Articulo
              INNER JOIN CargoActivos ON Articulo.IdArticulo = CargoActivos.IdArticulo
              INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
              INNER JOIN Departamentos ON Empleados.IdDepartamento = departamentos.IdDepartamento
              INNER JOIN DescargoActivos ON CargoActivos.Idcargo = DescargoActivos.IdCargoActivo WHERE Articulo.CodigoA LIKE '%" & Guna2TxtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                Guna2DgbDescargoActivos.DataSource = tabla
                LblTotal.Text = tabla.Rows.Count
            Else
                Guna2DgbDescargoActivos.DataSource = ""
            End If
        End If
    End Sub
    Sub Llenardatos()
        Dim sql As String
        sql = "SELECT CargoActivos.IdCargo,CargoActivos.CodigoInventario,
              Articulo.NombreA,Articulo.IdArticulo,Articulo.NumeroSerie,
              Empleados.Nombre,Empleados.Curp,Departamentos.NombreD,
              DescargoActivos.IdDescargo,DescargoActivos.FechaDescargo,DescargoActivos.motivo,
              DescargoActivos.Descripcion FROM Articulo
              INNER JOIN CargoActivos ON Articulo.IdArticulo = CargoActivos.IdArticulo
              INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
              INNER JOIN Departamentos ON Empleados.IdDepartamento = departamentos.IdDepartamento
              INNER JOIN DescargoActivos ON CargoActivos.Idcargo = DescargoActivos.IdCargoActivo"
        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            Guna2DgbDescargoActivos.DataSource = tabla
            LblTotal.Text = tabla.Rows.Count

        Catch ex As Exception
            MsgBox("Se ha encontrado el siguiente error ", ex.ToString + "Sistema inventario")
        End Try
    End Sub
    Sub insertar()
        Dim sql As String
        Dim id As Integer
        If MsgBox("Guardar Nuevo Registro", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
            Exit Sub

        End If
        adaptador = New SqlDataAdapter("SELECT CargoActivos.CodigoInventario  FROM CargoActivos
        INNER JOIN DescargoActivos On CargoActivos.IdCargo = DescargoActivos.IdCargoActivo
        WHERE CargoActivos.CodigoInventario = '" & Guna2TxtCodigoInv.Text & "' ", obtenerconexion)
        tabla.Clear() 'borra datos que trae datatable
        adaptador.Fill(tabla) 'actualiza o agrega dataset
        If tabla.Rows.Count > 0 Then
            Guna2TxtCodigoInv.Text = tabla.Rows(0).Item("CodigoInventario")
            MsgBox("El registro ya se encuentra en la base de datos ", vbInformation, "Sistema inventario")
            Exit Sub

        End If
        If TxtIdArticulo.Text = "" Or TxtIdCargo.Text = "" Or Guna2DtpDescargo.Text = "" Or Guna2CboMotivo.Text = "" Then
            MsgBox("Completar todos los campos", vbCritical, "Sistema inventario")
            Exit Sub
        Else
            sql = "INSERT INTO DescargoActivos(FechaDescargo,Descripcion,motivo,IdCargoActivo) VALUES
           ('" & Guna2DtpDescargo.Text & "','" & Guna2TxtDescripcion.Text & "','" & Guna2CboMotivo.Text & "','" & TxtIdCargo.Text & "')"

            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()
            MsgBox("Registro realizado correctamente", vbInformation, "Sistema inventario")
        End If

    End Sub
    Sub EliminarCargo()
        Dim id As Integer

        Dim sql As String
        sql = "UPDATE CargoActivos SET EstadoArticulo = 'ELIMINADO' WHERE IdCargo = " & Trim(TxtIdCargo.Text)
        Dim conect As New SqlConnection(obtenerconexion)
        conect.Open()
        Using comando As New SqlCommand(sql, conect)
            id = comando.ExecuteScalar()
        End Using
        conect.Close()
    End Sub
    Sub modificararticuloPendiente()

        Dim id As Integer

        Dim sql As String
        sql = "UPDATE Articulo SET EstadoArticulo ='PENDIENTE' WHERE IdArticulo= '" & TxtIdArticulo.Text & "'"
        Dim conect As New SqlConnection(obtenerconexion)
        conect.Open()
        Using comando As New SqlCommand(sql, conect)
            id = comando.ExecuteScalar()
        End Using
        conect.Close()
    End Sub
    Sub modificararticuloCompletado()

        Dim id As Integer

        Dim sql As String
        sql = "UPDATE Articulo SET EstadoArticulo ='COMPLETADO' WHERE IdArticulo= '" & TxtIdArticulo.Text & "'"
        Dim conect As New SqlConnection(obtenerconexion)
        conect.Open()
        Using comando As New SqlCommand(sql, conect)
            id = comando.ExecuteScalar()
        End Using
        conect.Close()
    End Sub
    Private Sub Guna2BtnExit_Click(sender As Object, e As EventArgs) Handles Guna2BtnExit.Click
        Me.Close()
        FrmMain.Visible = True
    End Sub

    Private Sub Guna2TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles Guna2TxtBuscar.TextChanged
        buscardatos()
    End Sub

    Private Sub Guna2DgbDescargoActivos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DgbDescargoActivos.CellDoubleClick
        On Error Resume Next

        TxtIdArticulo.Text = CStr(Guna2DgbDescargoActivos.Item("IdArticulo", Guna2DgbDescargoActivos.CurrentCell.RowIndex).Value)
        Guna2TxtNombreArt.Text = CStr(Guna2DgbDescargoActivos.Item("NombreA", Guna2DgbDescargoActivos.CurrentCell.RowIndex).Value)
        Guna2TxtNSerie.Text = CStr(Guna2DgbDescargoActivos.Item("NumeroSerie", Guna2DgbDescargoActivos.CurrentCell.RowIndex).Value)

        TxtIdEmpleado.Text = CStr(Guna2DgbDescargoActivos.Item("IdEmpleado", Guna2DgbDescargoActivos.CurrentCell.RowIndex).Value)
        Guna2TxtCurp.Text = CStr(Guna2DgbDescargoActivos.Item("Curp", Guna2DgbDescargoActivos.CurrentCell.RowIndex).Value)
        Guna2TxtNombreE.Text = CStr(Guna2DgbDescargoActivos.Item("Nombre", Guna2DgbDescargoActivos.CurrentCell.RowIndex).Value)
        Guna2TxtDepartamento.Text = CStr(Guna2DgbDescargoActivos.Item("NombreD", Guna2DgbDescargoActivos.CurrentCell.RowIndex).Value)


        TxtIdCargo.Text = CStr(Guna2DgbDescargoActivos.Item("IdCargo", Guna2DgbDescargoActivos.CurrentCell.RowIndex).Value)
        TxtIdDescargo.Text = CStr(Guna2DgbDescargoActivos.Item("IdDescargo", Guna2DgbDescargoActivos.CurrentCell.RowIndex).Value)
        Guna2TxtCodigoInv.Text = CStr(Guna2DgbDescargoActivos.Item("CodigoInventario", Guna2DgbDescargoActivos.CurrentCell.RowIndex).Value)
        Guna2CboMotivo.Text = CStr(Guna2DgbDescargoActivos.Item("motivo", Guna2DgbDescargoActivos.CurrentCell.RowIndex).Value)
        Guna2TxtDescripcion.Text = CStr(Guna2DgbDescargoActivos.Item("Descripcion", Guna2DgbDescargoActivos.CurrentCell.RowIndex).Value)
        Guna2DTPFechaEntrega.Text = CStr(Guna2DgbDescargoActivos.Item("fechaAsignacion", Guna2DgbDescargoActivos.CurrentCell.RowIndex).Value)
        Guna2DtpDescargo.Text = CStr(Guna2DgbDescargoActivos.Item("FechaDescargo", Guna2DgbDescargoActivos.CurrentCell.RowIndex).Value)
        Guna2BtnCancelar.Enabled = True
        Guna2BtnCodigoInv.Enabled = True
        Guna2BntEditar.Enabled = True
        Guna2BtnBorrar.Enabled = True

        Guna2TxtNombreArt.Enabled = True
        TxtIdArticulo.Enabled = True
        Guna2TxtNSerie.Enabled = True

        Guna2TxtNombreE.Enabled = True
        Guna2TxtCurp.Enabled = True
        Guna2TxtDepartamento.Enabled = True

        Guna2TxtDescripcion.Enabled = True
        Guna2DTPFechaEntrega.Enabled = True
        Guna2DtpDescargo.Enabled = True
        Guna2CboMotivo.Enabled = True
        Guna2TxtCodigoInv.Enabled = True
        'TxtCodigo.Focus()
        Guna2BtnBuscar.Enabled = False
        Guna2BtnNuevo.Enabled = False

    End Sub

    Private Sub Guna2BtnCodigoInv_Click(sender As Object, e As EventArgs) Handles Guna2BtnCodigoInv.Click
        FrmBusquedaActivos.Show()
    End Sub

    Private Sub Guna2BntEditar_Click(sender As Object, e As EventArgs) Handles Guna2BntEditar.Click
        desactivarcontroles()
        Llenardatos()
    End Sub

    Private Sub Guna2BtnGuardar_Click(sender As Object, e As EventArgs) Handles Guna2BtnGuardar.Click
        If Guna2CboMotivo.Text = "COMPLETADO" Then
            insertar()
            EliminarCargo()
            modificararticuloCompletado()
            Llenardatos()
            desactivarcontroles()
            limpiarcontroles()
        Else
            insertar()
            EliminarCargo()
            modificararticuloPendiente()
            Llenardatos()
            desactivarcontroles()
            limpiarcontroles()

        End If
    End Sub
End Class