Imports System.Data.SqlClient


Public Class FrmCargoActivos


    Sub desactivarcontroles()
        Guna2BtnGuardar.Enabled = False
        Guna2BntEditar.Enabled = False
        Guna2BtnCancelar.Enabled = False
        Guna2BtnBorrar.Enabled = False
        Guna2Btncodigo.Enabled = False
        Guna2BtnCurp.Enabled = False

        Guna2TxtNombreArt.Enabled = False
        Guna2TxtCodigo.Enabled = False
        Guna2TxtNSerie.Enabled = False
        Guna2TxtCodigoInv.Enabled = False
        Guna2TxtDescripcion.Enabled = False
        Guna2TxtCurp.Enabled = False
        Guna2TxtDepartamento.Enabled = False
        Guna2TxtNombreE.Enabled = False
        Guna2CboEstado.Enabled = False
        Guna2DTPFechaEntrega.Enabled = False
        Guna2BtnNuevo.Enabled = True
    End Sub
    Sub activarcontroles()
        Guna2BtnGuardar.Enabled = True
        Guna2BntEditar.Enabled = False
        Guna2BtnCancelar.Enabled = True
        Guna2BtnBorrar.Enabled = False
        Guna2Btncodigo.Enabled = True
        Guna2BtnCurp.Enabled = True

        Guna2TxtNombreArt.Enabled = True
        Guna2TxtCodigo.Enabled = True
        Guna2TxtNSerie.Enabled = True
        Guna2TxtCodigoInv.Enabled = True
        Guna2TxtDescripcion.Enabled = True
        Guna2TxtCurp.Enabled = True
        Guna2TxtDepartamento.Enabled = True
        Guna2TxtNombreE.Enabled = True
        Guna2CboEstado.Enabled = True
        Guna2DTPFechaEntrega.Enabled = True


        Guna2BtnNuevo.Enabled = False
    End Sub
    Sub limpiarcontroles()
        Guna2TxtNombreArt.Clear()
        Guna2TxtCodigo.Clear()
        Guna2TxtNSerie.Clear()
        Guna2TxtCodigoInv.Clear()
        Guna2TxtDescripcion.Clear()
        Guna2TxtCurp.Clear()
        Guna2TxtDepartamento.Clear()
        Guna2TxtNombreE.Clear()
        Guna2CboEstado.Text = ""
        Guna2DTPFechaEntrega.Text = ""
    End Sub
    Private Function obtenercodigos() As AutoCompleteStringCollection
        adaptador = New SqlDataAdapter("SELECT CodigoA FROM Articulo WHERE EstadoArticulo='PENDIENTE'", obtenerconexion)
        Dim dt As New DataTable("Articulo")
        adaptador.Fill(dt)
        Dim ListarDatos As New AutoCompleteStringCollection()
        For Each row As DataRow In dt.Rows
            ListarDatos.Add(CStr(row(0)))
        Next
        Return ListarDatos
    End Function
    Private Function obtenerIdentidades() As AutoCompleteStringCollection
        adaptador = New SqlDataAdapter("SELECT Curp FROM Empleados", obtenerconexion)
        Dim dt As New DataTable("Empleados")
        adaptador.Fill(dt)
        Dim ListarDatos As New AutoCompleteStringCollection()
        For Each row As DataRow In dt.Rows
            ListarDatos.Add(CStr(row(0)))
        Next
        Return ListarDatos
    End Function
    Sub insertar()
        Dim sql As String
        Dim id As Integer
        If MsgBox("Guardar Nuevo Registro", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
            Exit Sub

        End If
        adaptador = New SqlDataAdapter("SELECT * FROM CargoActivos Where CodigoInventario = '" & Guna2TxtCodigoInv.Text & "' ", obtenerconexion)
        tabla.Clear() 'borra datos que trae datatable
        adaptador.Fill(tabla) 'actualiza o agrega dataset
        If tabla.Rows.Count > 0 Then
            Guna2TxtCodigoInv.Text = tabla.Rows(0).Item("CodigoInventario")
            MsgBox("El registro ya se encuentra en la base de datos ", vbInformation, "Sistema inventario")
            Exit Sub

        End If
        If TxtIdArticulo.Text = "" Or TxtIdEmpleado.Text = "" Or Guna2TxtCodigoInv.Text = "" Or Guna2DTPFechaEntrega.Text = "" Then
            MsgBox("Completar todos los campos", vbCritical, "Sistema inventario")
            Exit Sub
        Else
            sql = "INSERT INTO CargoActivos(CodigoInventario,fechaAsignacion,EstadoArticulo,Descripcion,IdArticulo,IdEmpleado) VALUES
           ('" & Guna2TxtCodigoInv.Text & "','" & Guna2DTPFechaEntrega.Text & "','" & Guna2CboEstado.Text & "','" & Guna2TxtDescripcion.Text & "',
           '" & TxtIdArticulo.Text & "','" & TxtIdEmpleado.Text & "')"

            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()
            modificararticulos()
            MsgBox("Registro realizado correctamente", vbInformation, "Sistema inventario")
        End If

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
    Sub modificararticulos()

        Dim id As Integer

        Dim sql As String
        sql = "UPDATE Articulo SET EstadoArticulo ='ENTREGADO' WHERE IdArticulo= '" & TxtIdArticulo.Text & "'"
        Dim conect As New SqlConnection(obtenerconexion)
        conect.Open()
        Using comando As New SqlCommand(sql, conect)
            id = comando.ExecuteScalar()
        End Using
        conect.Close()
    End Sub
    Sub Editar()
        Dim id As Integer
        If TxtId.Text = "" Then
            MsgBox("Existen datos vacios", vbInformation, "Sistema de inventario")
        Else
            Dim sql As String
            sql = "UPDATE CargoActivos SET CodigoInventario ='" & Guna2TxtCodigoInv.Text & "',
            fechaAsignacion= '" & Guna2DTPFechaEntrega.Text & "', EstadoArticulo='" & Guna2CboEstado.Text & "', 
            Descripcion ='" & Guna2TxtDescripcion.Text & "',IdArticulo ='" & TxtIdArticulo.Text & "', 
            IdEmpleado ='" & TxtIdEmpleado.Text & "' WHERE IdCargo= '" & TxtId.Text & "'"
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
            Guna2DgbCargoActivos.DataSource = tabla
            LblTotal.Text = tabla.Rows.Count

        Catch ex As Exception
            MsgBox("Se ha encontrado el siguiente error ", ex.ToString + "Sistema inventario")
        End Try
    End Sub
    Sub buscardatos()
        If Guna2RbNombreA.Checked Then
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
                Guna2DgbCargoActivos.DataSource = tabla
                LblTotal.Text = tabla.Rows.Count
            Else
                Guna2DgbCargoActivos.DataSource = ""
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
                Guna2DgbCargoActivos.DataSource = tabla
                LblTotal.Text = tabla.Rows.Count
            Else
                Guna2DgbCargoActivos.DataSource = ""
            End If
        End If
        If Guna2RbCodigoA.Checked Then
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
                Guna2DgbCargoActivos.DataSource = tabla
                LblTotal.Text = tabla.Rows.Count
            Else
                Guna2DgbCargoActivos.DataSource = ""
            End If
        End If


    End Sub
    Sub Eliminar()
        Dim id As Integer
        If TxtId.Text = 0 Then
            MsgBox("Existen datos vacios", vbInformation, "Sistema de inventario")
        Else
            If MsgBox("¿seguro de eliminar al activo" + Trim(Guna2TxtNombreArt.Text) + "De su registro?" + vbCr + "Esta accion ya no se puede revertir.", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
                limpiarcontroles()
                desactivarcontroles()
                Exit Sub
            Else


                Dim sql As String
                sql = "DELETE FROM CargoActivos WHERE IdCargo = " & Trim(TxtId.Text)
                Dim conect As New SqlConnection(obtenerconexion)
                conect.Open()
                Using comando As New SqlCommand(sql, conect)
                    id = comando.ExecuteScalar()
                End Using
                conect.Close()
                modificararticuloPendiente()
                MsgBox("Registro Eliminado correctamente", vbInformation, "Sistema inventario")
                limpiarcontroles()
            End If
        End If
    End Sub

    Private Sub FrmCargoActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarcontroles()
        limpiarcontroles()
        Llenardatos()

        Guna2TxtCodigo.AutoCompleteMode = AutoCompleteMode.Suggest
        Guna2TxtCodigo.AutoCompleteSource = AutoCompleteSource.CustomSource
        Guna2TxtCodigo.AutoCompleteCustomSource = obtenercodigos()

        Guna2TxtCurp.AutoCompleteMode = AutoCompleteMode.Suggest
        Guna2TxtCurp.AutoCompleteSource = AutoCompleteSource.CustomSource
        Guna2TxtCurp.AutoCompleteCustomSource = obtenerIdentidades()

        Guna2DgbCargoActivos.AutoGenerateColumns = False





    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles Guna2BtnCancelar.Click
        desactivarcontroles()
        limpiarcontroles()

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

    Private Sub TxtCodigo_TextChanged(sender As Object, e As EventArgs) Handles Guna2TxtCodigo.TextChanged
        If Guna2TxtCodigo.Text <> "" Then
            adaptador = New SqlDataAdapter("SELECT IdArticulo,NombreA,NumeroSerie FROM Articulo WHERE CodigoA='" & Guna2TxtCodigo.Text & "'", obtenerconexion)
            Dim tabla As New DataTable
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count = 1 Then
                Dim fila As DataRow = tabla.Rows(0)
                Guna2TxtNombreArt.Text = fila("NombreA").ToString
                Guna2TxtNSerie.Text = fila("NumeroSerie").ToString
                TxtIdArticulo.Text = fila("idArticulo").ToString
            Else
                Guna2TxtNombreArt.Clear()
                Guna2TxtCodigo.Focus()
            End If
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TxtCurp_TextChanged(sender As Object, e As EventArgs) Handles Guna2TxtCurp.TextChanged
        If Guna2TxtCodigo.Text <> "" Then
            adaptador = New SqlDataAdapter("SELECT Empleados.IdEmpleado,Empleados.Nombre,Departamentos.NombreD FROM Departamentos INNER JOIN Empleados ON departamentos.IdDepartamento = Empleados.IdDepartamento WHERE Curp='" & Guna2TxtCurp.Text & "'", obtenerconexion)
            Dim tabla As New DataTable
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count = 1 Then
                Dim fila As DataRow = tabla.Rows(0)
                Guna2TxtNombreE.Text = fila("Nombre").ToString
                Guna2TxtDepartamento.Text = fila("NombreD").ToString
                TxtIdEmpleado.Text = fila("idEmpleado").ToString
            Else
                Guna2TxtDepartamento.Clear()
                Guna2TxtNombreE.Clear()
                Guna2TxtCurp.Focus()
            End If
        End If
    End Sub
    Private Sub Btncodigo_Click(sender As Object, e As EventArgs) Handles Guna2Btncodigo.Click
        Dim frmbusquedaarticulos As New FrmBuscarArticulos
        frmbusquedaarticulos.ShowDialog()
        Me.Visible = False
    End Sub
    Dim FrmBusquedaEmpleado As New FrmBusquedaEmpleado

    Private Sub BtnCurp_Click(sender As Object, e As EventArgs) Handles Guna2BtnCurp.Click
        FrmBusquedaEmpleado.ShowDialog()
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles Guna2TxtBuscar.TextChanged
        buscardatos()

    End Sub

    Private Sub rbNombreA_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RbNombreA.CheckedChanged
        Guna2TxtBuscar.Focus()

    End Sub

    Private Sub Rbfecha_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RbFecha.CheckedChanged
        Guna2TxtBuscar.Focus()

    End Sub

    Private Sub RbCodigoA_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RbCodigoA.CheckedChanged
        Guna2TxtBuscar.Focus()

    End Sub

    Private Sub DgbCargoActivos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        On Error Resume Next

        TxtIdArticulo.Text = CStr(Guna2DgbCargoActivos.Item("IdArticulo", Guna2DgbCargoActivos.CurrentCell.RowIndex).Value)
        Guna2TxtNombreArt.Text = CStr(Guna2DgbCargoActivos.Item("NombreA", Guna2DgbCargoActivos.CurrentCell.RowIndex).Value)
        Guna2TxtCodigo.Text = CStr(Guna2DgbCargoActivos.Item("CodigoA", Guna2DgbCargoActivos.CurrentCell.RowIndex).Value)
        Guna2TxtNSerie.Text = CStr(Guna2DgbCargoActivos.Item("NumeroSerie", Guna2DgbCargoActivos.CurrentCell.RowIndex).Value)

        TxtIdEmpleado.Text = CStr(Guna2DgbCargoActivos.Item("IdEmpleado", Guna2DgbCargoActivos.CurrentCell.RowIndex).Value)
        Guna2TxtCurp.Text = CStr(Guna2DgbCargoActivos.Item("Curp", Guna2DgbCargoActivos.CurrentCell.RowIndex).Value)
        Guna2TxtNombreE.Text = CStr(Guna2DgbCargoActivos.Item("Nombre", Guna2DgbCargoActivos.CurrentCell.RowIndex).Value)
        Guna2TxtDepartamento.Text = CStr(Guna2DgbCargoActivos.Item("NombreD", Guna2DgbCargoActivos.CurrentCell.RowIndex).Value)


        TxtId.Text = CStr(Guna2DgbCargoActivos.Item("IdCargo", Guna2DgbCargoActivos.CurrentCell.RowIndex).Value)
        Guna2TxtCodigoInv.Text = CStr(Guna2DgbCargoActivos.Item("CodigoInventario", Guna2DgbCargoActivos.CurrentCell.RowIndex).Value)
        Guna2CboEstado.Text = CStr(Guna2DgbCargoActivos.Item("EstadoArticulo", Guna2DgbCargoActivos.CurrentCell.RowIndex).Value)
        Guna2TxtDescripcion.Text = CStr(Guna2DgbCargoActivos.Item("Descripcion", Guna2DgbCargoActivos.CurrentCell.RowIndex).Value)
        Guna2DTPFechaEntrega.Text = CStr(Guna2DgbCargoActivos.Item("FechaAsignacion", Guna2DgbCargoActivos.CurrentCell.RowIndex).Value)
        Guna2BtnCancelar.Enabled = True
        Guna2Btncodigo.Enabled = True
        Guna2BtnCurp.Enabled = True
        Guna2BntEditar.Enabled = True
        Guna2BtnBorrar.Enabled = True

        Guna2TxtNombreArt.Enabled = True
        TxtIdArticulo.Enabled = True
        Guna2TxtNSerie.Enabled = True
        Guna2TxtCodigo.Enabled = True

        Guna2TxtNombreE.Enabled = True
        Guna2TxtCurp.Enabled = True
        Guna2TxtNombreE.Enabled = True
        Guna2TxtDepartamento.Enabled = True

        Guna2TxtDescripcion.Enabled = True
        Guna2DTPFechaEntrega.Enabled = True
        Guna2CboEstado.Enabled = True
        Guna2TxtCodigoInv.Enabled = True
        'TxtCodigo.Focus()
        Guna2BtnBuscar.Enabled = False
        Guna2BtnNuevo.Enabled = False

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles Guna2BntEditar.Click
        If UCase(tipousuario) = "ADMINISTRADOR" Then
            Editar()
            desactivarcontroles()
            Llenardatos()

        Else
            MsgBox("NO TIENE LOS PRIVILEGIOS PARA ACCEDER A ESTE MODULO", vbInformation, "OPERACION CANCELADA")

        End If

    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles Guna2BtnBorrar.Click
        If UCase(tipousuario) = "ADMINISTRADOR" Then
            Eliminar()

            desactivarcontroles()
            Llenardatos()

        Else
            MsgBox("NO TIENE LOS PRIVILEGIOS PARA ACCEDER A ESTE MODULO", vbInformation, "OPERACION CANCELADA")

        End If

    End Sub

    Private Sub Guna2BtnExit_Click(sender As Object, e As EventArgs) Handles Guna2BtnExit.Click
        Me.Close()
        FrmMain.Visible = True
    End Sub
End Class