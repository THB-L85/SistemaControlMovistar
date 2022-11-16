Imports System.Data.SqlClient

Public Class FrmEmpleados
    Private tablaDepartamentos As New DataTable
    Private tablaPuestos As New DataTable

    Sub desactivarcontroles()
        BtnGuardar.Enabled = False
        BtnEditar.Enabled = False
        BtnCancelar.Enabled = False
        BtnBorrar.Enabled = False

        txtNombrecompleto.Enabled = False
        TxtCorreo.Enabled = False
        TxtId.Enabled = False
        TxtCurp.Enabled = False
        TxtTelefono.Enabled = False
        TxtDireccion.Enabled = False
        cboDepartamento.Enabled = False
        cboGenero.Enabled = False
        CboPuesto.Enabled = False

        BtnNuevo.Enabled = True
        BtnBuscar.Enabled = True
    End Sub
    Sub activarcontroles()
        BtnGuardar.Enabled = True
        BtnEditar.Enabled = False
        BtnCancelar.Enabled = True
        BtnBorrar.Enabled = False
        BtnBuscar.Enabled = False

        txtNombrecompleto.Enabled = True
        TxtCorreo.Enabled = True
        TxtId.Enabled = True
        TxtCurp.Enabled = True
        TxtTelefono.Enabled = True
        TxtDireccion.Enabled = True
        cboDepartamento.Enabled = True
        cboGenero.Enabled = True
        CboPuesto.Enabled = True
    End Sub

    Sub limpiarcontroles()
        txtNombrecompleto.Text = ""
        TxtCorreo.Text = ""
        TxtId.Text = ""
        TxtCurp.Text = ""
        TxtTelefono.Text = ""
        TxtDireccion.Text = ""
        cboDepartamento.Text = ""
        cboGenero.Text = ""
        CboPuesto.Text = ""

    End Sub

    Public Function Departamento_Listar(activo As Integer) As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT IdDepartamento,NombreD From Departamentos"
        Using adaptador = New SqlDataAdapter(sql, obtenerconexion)
            tabla.Rows.Clear()
            adaptador.Fill(tabla)

        End Using
        Return tabla
    End Function
    Private Sub Mostrar_Departamentos()
        tablaDepartamentos = Departamento_Listar(True)
        cboDepartamento.DataSource = tablaDepartamentos
        cboDepartamento.DisplayMember = "NombreD"
        cboDepartamento.ValueMember = "IdDepartamento"
    End Sub

    Public Function Puesto_Listar(activo As Integer) As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT IdPuesto,NombreP From Puestos"
        Using adaptador = New SqlDataAdapter(sql, obtenerconexion)
            tabla.Rows.Clear()
            adaptador.Fill(tabla)

        End Using
        Return tabla
    End Function
    Private Sub Mostrar_Puestos()
        tablaPuestos = Puesto_Listar(True)
        CboPuesto.DataSource = tablaPuestos
        CboPuesto.DisplayMember = "NombreP"
        CboPuesto.ValueMember = "IdPuesto"
    End Sub
    Sub insertar()
        Dim sql As String
        Dim id As Integer
        If MsgBox("Guardar Nuevo Registro", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
            Exit Sub

        End If
        adaptador = New SqlDataAdapter("SELECT * FROM Empleados Where Curp = '" & TxtCurp.Text & "' ", obtenerconexion)
        tabla.Clear() 'borra datos que trae datatable
        adaptador.Fill(tabla) 'actualiza o agrega dataset
        If tabla.Rows.Count > 0 Then
            TxtCurp.Text = tabla.Rows(0).Item("Curp")
            MsgBox("El registro ya se encuentra en la base de datos ", vbInformation, "Sistema inventario")
            Exit Sub

        End If
        If txtNombrecompleto.Text = "" Or TxtCurp.Text = "" Or TxtCorreo.Text = "" Or TxtTelefono.Text = "" Or TxtDireccion.Text = "" Or cboDepartamento.Text = "" Or cboGenero.Text = "" Or CboPuesto.Text = "" Then
            MsgBox("Completar todos los campos", vbCritical, "Sistema inventario")
            Exit Sub
        Else
            sql = "INSERT INTO Empleados(Nombre,Curp,Genero,Telefono,Correo,Direccion,IdPuesto,IdDepartamento)VALUES
           ('" & txtNombrecompleto.Text & "','" & TxtCurp.Text & "','" & cboGenero.Text & "','" & TxtTelefono.Text & "',
           '" & TxtCorreo.Text & "','" & TxtDireccion.Text & "','" & Trim(CboPuesto.SelectedValue) & "','" & Trim(cboDepartamento.SelectedValue) & "') " ' consulta de insercion

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
        If rbNombreEmpleado.Checked Then
            If TxtBuscar.Text = " " Then
                Llenardatos()

            End If
            adaptador = New SqlDataAdapter("SELECT Empleados.IdEmpleado, Empleados.Nombre, Empleados.Curp, Empleados.Genero,Empleados.Telefono,Empleados.Correo ,
              Empleados.Direccion, Departamentos.NombreD, Puestos.NombreP FROM Departamentos INNER JOIN Empleados 
              ON Departamentos.IdDepartamento = Empleados.IdDepartamento 
              INNER JOIN Puestos ON Empleados.IdPuesto = Puestos.IdPuesto WHERE Empleados.Nombre LIKE '%" & TxtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                DgbEmpleados.DataSource = tabla
                LblTotal.Text = tabla.Rows.Count
            Else
                DgbEmpleados.DataSource = ""
            End If

        End If
        If RbCurp.Checked Then
            If TxtBuscar.Text = " " Then
                Llenardatos()

            End If
            adaptador = New SqlDataAdapter("SELECT Empleados.IdEmpleado, Empleados.Nombre, Empleados.Curp, Empleados.Genero,Empleados.Telefono,Empleados.Correo ,
              Empleados.Direccion, Departamentos.NombreD, Puestos.NombreP FROM Departamentos INNER JOIN Empleados 
              ON Departamentos.IdDepartamento = Empleados.IdDepartamento 
              INNER JOIN Puestos ON Empleados.IdPuesto = Puestos.IdPuesto WHERE Empleados.Curp LIKE '%" & TxtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                DgbEmpleados.DataSource = tabla
                LblTotal.Text = tabla.Rows.Count
            Else
                DgbEmpleados.DataSource = ""
            End If
        End If
        If RbDepartamento.Checked Then
            If TxtBuscar.Text = " " Then
                Llenardatos()

            End If
            adaptador = New SqlDataAdapter("SELECT Empleados.IdEmpleado, Empleados.Nombre, Empleados.Curp, Empleados.Genero,Empleados.Telefono,Empleados.Correo ,
              Empleados.Direccion, Departamentos.NombreD, Puestos.NombreP FROM Departamentos INNER JOIN Empleados 
              ON Departamentos.IdDepartamento = Empleados.IdDepartamento 
              INNER JOIN Puestos ON Empleados.IdPuesto = Puestos.IdPuesto WHERE Departamentos.NombreD LIKE '%" & TxtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                DgbEmpleados.DataSource = tabla
                LblTotal.Text = tabla.Rows.Count
            Else
                DgbEmpleados.DataSource = ""
            End If
        End If


    End Sub
    Sub Llenardatos()
        Dim sql As String
        sql = "SELECT Empleados.IdEmpleado, Empleados.Nombre, Empleados.Curp, Empleados.Genero,Empleados.Telefono,Empleados.Correo ,
              Empleados.Direccion, Departamentos.NombreD, Puestos.NombreP FROM Departamentos INNER JOIN Empleados 
              ON Departamentos.IdDepartamento = Empleados.IdDepartamento 
              INNER JOIN Puestos ON Empleados.IdPuesto = Puestos.IdPuesto"
        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            DgbEmpleados.DataSource = tabla
            LblTotal.Text = tabla.Rows.Count

        Catch ex As Exception
            MsgBox("Se ha encontrado el siguiente error ", ex.ToString + "Sistema inventario")
        End Try
    End Sub
    Sub Editar()
        Dim id As Integer
        If TxtId.Text = 0 Then
            MsgBox("Existen datos vacios", vbInformation, "Sistema de inventario")
        Else
            Dim sql As String
            sql = "UPDATE Empleados SET Nombre ='" & txtNombrecompleto.Text & "',Curp= '" & TxtCurp.Text & "', 
            Genero='" & cboGenero.Text & "',Telefono ='" & TxtTelefono.Text & "',Correo='" & TxtCorreo.Text & "',
            IdDepartamento= '" & Trim(cboDepartamento.SelectedValue) & "',IdPuesto= '" & Trim(CboPuesto.SelectedValue) & "' WHERE IdEmpleado= '" & TxtId.Text & "'"
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
            If MsgBox("¿seguro de eliminar a" + Trim(txtNombrecompleto.Text) + "De su registro?" + vbCr + "Esta accion ya no se puede revertir.", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
                limpiarcontroles()
                desactivarcontroles()
                Exit Sub
            Else


                Dim sql As String
                sql = "DELETE FROM Empleados WHERE IdEmpleado = " & Trim(TxtId.Text)
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPuesto.SelectedIndexChanged

    End Sub

    Private Sub TxtId_TextChanged(sender As Object, e As EventArgs) Handles TxtId.TextChanged

    End Sub

    Private Sub FrmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarcontroles()
        Llenardatos()
        DgbEmpleados.AutoGenerateColumns = False
        Mostrar_Departamentos()
        cboDepartamento.SelectedIndex = -1
        Mostrar_Puestos()
        CboPuesto.SelectedIndex = -1
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

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

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        buscardatos()

    End Sub

    Private Sub rbNombreEmpleado_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombreEmpleado.CheckedChanged
        TxtBuscar.Focus()
    End Sub

    Private Sub RbCurp_CheckedChanged(sender As Object, e As EventArgs) Handles RbCurp.CheckedChanged
        TxtBuscar.Focus()

    End Sub

    Private Sub RbDepartamento_CheckedChanged(sender As Object, e As EventArgs) Handles RbDepartamento.CheckedChanged
        TxtBuscar.Focus()

    End Sub

    Private Sub DgbEmpleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgbEmpleados.CellDoubleClick
        On Error Resume Next 'cuando se produce un error en tiempo de ejecucion esta instruccion se transfiere y no se interrumpe la ejecucion
        TxtId.Text = CStr(DgbEmpleados.Item("IdEmpleado", DgbEmpleados.CurrentCell.RowIndex).Value)
        txtNombrecompleto.Text = CStr(DgbEmpleados.Item("Nombre", DgbEmpleados.CurrentCell.RowIndex).Value)
        TxtCurp.Text = CStr(DgbEmpleados.Item("Curp", DgbEmpleados.CurrentCell.RowIndex).Value)
        TxtDireccion.Text = CStr(DgbEmpleados.Item("Direccion", DgbEmpleados.CurrentCell.RowIndex).Value)
        cboGenero.Text = CStr(DgbEmpleados.Item("Genero", DgbEmpleados.CurrentCell.RowIndex).Value)
        CboPuesto.Text = CStr(DgbEmpleados.Item("NombreP", DgbEmpleados.CurrentCell.RowIndex).Value)
        cboDepartamento.Text = CStr(DgbEmpleados.Item("NombreD", DgbEmpleados.CurrentCell.RowIndex).Value)
        TxtTelefono.Text = CStr(DgbEmpleados.Item("Telefono", DgbEmpleados.CurrentCell.RowIndex).Value)
        TxtCorreo.Text = CStr(DgbEmpleados.Item("Correo", DgbEmpleados.CurrentCell.RowIndex).Value)
        BtnCancelar.Enabled = True
        BtnEditar.Enabled = True
        BtnBorrar.Enabled = True

        txtNombrecompleto.Enabled = True
        TxtCurp.Enabled = True
        TxtDireccion.Enabled = True
        TxtTelefono.Enabled = True
        TxtCorreo.Enabled = True
        cboDepartamento.Enabled = True
        cboGenero.Enabled = True
        CboPuesto.Enabled = True
        txtNombrecompleto.Focus()
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

    Private Sub BtnDepartamento_Click(sender As Object, e As EventArgs) Handles BtnDepartamento.Click
        frmDepartamentos.Show()

    End Sub
    Dim frmPuestos As New frmPuestosTrabajo
    Dim frmDepartamentos As New frmDepartamentos

    Private Sub BtnPuesto_Click(sender As Object, e As EventArgs) Handles BtnPuesto.Click
        frmPuestos.Show()

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        desactivarcontroles()
        limpiarcontroles()

    End Sub
End Class