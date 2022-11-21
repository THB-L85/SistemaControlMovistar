Imports System.Data.SqlClient

Public Class FrmEmpleados
    Private tablaDepartamentos As New DataTable
    Private tablaPuestos As New DataTable

    Sub desactivarcontroles()
        Guna2BtnGuardar.Enabled = False
        Guna2BntEditar.Enabled = False
        Guna2BtnCancelar.Enabled = False
        Guna2BtnBorrar.Enabled = False

        Guna2TxtNombreC.Enabled = False
        Guna2Correo.Enabled = False
        TxtId.Enabled = False
        Guna2TxtCurp.Enabled = False
        Guna2TxtTelefono.Enabled = False
        Guna2TxtDireccion.Enabled = False
        Guna2CboDepto.Enabled = False
        Guna2CboGenero.Enabled = False
        Guna2CboPuesto.Enabled = False

        Guna2BtnNuevo.Enabled = True
        BtnBuscar.Enabled = True
    End Sub
    Sub activarcontroles()
        Guna2BtnGuardar.Enabled = True
        Guna2BntEditar.Enabled = False
        Guna2BtnCancelar.Enabled = True
        Guna2BtnBorrar.Enabled = False
        BtnBuscar.Enabled = False

        Guna2TxtNombreC.Enabled = True
        Guna2Correo.Enabled = True
        TxtId.Enabled = True
        Guna2TxtCurp.Enabled = True
        Guna2TxtTelefono.Enabled = True
        Guna2TxtDireccion.Enabled = True
        Guna2CboDepto.Enabled = True
        Guna2CboGenero.Enabled = True
        Guna2CboPuesto.Enabled = True
    End Sub

    Sub limpiarcontroles()
        Guna2TxtNombreC.Text = ""
        Guna2Correo.Text = ""
        TxtId.Text = ""
        Guna2TxtCurp.Text = ""
        Guna2TxtTelefono.Text = ""
        Guna2TxtDireccion.Text = ""
        Guna2CboDepto.Text = ""
        Guna2CboGenero.Text = ""
        Guna2CboPuesto.Text = ""

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
        Guna2CboDepto.DataSource = tablaDepartamentos
        Guna2CboDepto.DisplayMember = "NombreD"
        Guna2CboDepto.ValueMember = "IdDepartamento"
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
        Guna2CboPuesto.DataSource = tablaPuestos
        Guna2CboPuesto.DisplayMember = "NombreP"
        Guna2CboPuesto.ValueMember = "IdPuesto"
    End Sub
    Sub insertar()
        Dim sql As String
        Dim id As Integer
        If MsgBox("Guardar Nuevo Registro", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
            Exit Sub

        End If
        adaptador = New SqlDataAdapter("SELECT * FROM Empleados Where Curp = '" & Guna2TxtCurp.Text & "' ", obtenerconexion)
        tabla.Clear() 'borra datos que trae datatable
        adaptador.Fill(tabla) 'actualiza o agrega dataset
        If tabla.Rows.Count > 0 Then
            Guna2TxtCurp.Text = tabla.Rows(0).Item("Curp")
            MsgBox("El registro ya se encuentra en la base de datos ", vbInformation, "Sistema inventario")
            Exit Sub

        End If
        If Guna2TxtNombreC.Text = "" Or Guna2TxtCurp.Text = "" Or Guna2Correo.Text = "" Or Guna2TxtTelefono.Text = "" Or Guna2TxtDireccion.Text = "" Or Guna2CboDepto.Text = "" Or Guna2CboGenero.Text = "" Or Guna2CboPuesto.Text = "" Then
            MsgBox("Completar todos los campos", vbCritical, "Sistema inventario")
            Exit Sub
        Else
            sql = "INSERT INTO Empleados(Nombre,Curp,Genero,Telefono,Correo,Direccion,IdPuesto,IdDepartamento)VALUES
           ('" & Guna2TxtNombreC.Text & "','" & Guna2TxtCurp.Text & "','" & Guna2CboGenero.Text & "','" & Guna2TxtTelefono.Text & "',
           '" & Guna2Correo.Text & "','" & Guna2TxtDireccion.Text & "','" & Trim(Guna2CboPuesto.SelectedValue) & "','" & Trim(Guna2CboDepto.SelectedValue) & "') " ' consulta de insercion

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
        If Guna2RbNombreC.Checked Then
            If Guna2TxtBuscar.Text = " " Then
                Llenardatos()

            End If
            adaptador = New SqlDataAdapter("SELECT Empleados.IdEmpleado, Empleados.Nombre, Empleados.Curp, Empleados.Genero,Empleados.Telefono,Empleados.Correo ,
              Empleados.Direccion, Departamentos.NombreD, Puestos.NombreP FROM Departamentos INNER JOIN Empleados 
              ON Departamentos.IdDepartamento = Empleados.IdDepartamento 
              INNER JOIN Puestos ON Empleados.IdPuesto = Puestos.IdPuesto WHERE Empleados.Nombre LIKE '%" & Guna2TxtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                Guna2DgbEmpleados.DataSource = tabla
                LblTotal.Text = tabla.Rows.Count
            Else
                Guna2DgbEmpleados.DataSource = ""
            End If

        End If
        If Guna2RbCurp.Checked Then
            If Guna2TxtBuscar.Text = " " Then
                Llenardatos()

            End If
            adaptador = New SqlDataAdapter("SELECT Empleados.IdEmpleado, Empleados.Nombre, Empleados.Curp, Empleados.Genero,Empleados.Telefono,Empleados.Correo ,
              Empleados.Direccion, Departamentos.NombreD, Puestos.NombreP FROM Departamentos INNER JOIN Empleados 
              ON Departamentos.IdDepartamento = Empleados.IdDepartamento 
              INNER JOIN Puestos ON Empleados.IdPuesto = Puestos.IdPuesto WHERE Empleados.Curp LIKE '%" & Guna2TxtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                Guna2DgbEmpleados.DataSource = tabla
                LblTotal.Text = tabla.Rows.Count
            Else
                Guna2DgbEmpleados.DataSource = ""
            End If
        End If
        If Guna2RbDepto.Checked Then
            If Guna2TxtBuscar.Text = " " Then
                Llenardatos()

            End If
            adaptador = New SqlDataAdapter("SELECT Empleados.IdEmpleado, Empleados.Nombre, Empleados.Curp, Empleados.Genero,Empleados.Telefono,Empleados.Correo ,
              Empleados.Direccion, Departamentos.NombreD, Puestos.NombreP FROM Departamentos INNER JOIN Empleados 
              ON Departamentos.IdDepartamento = Empleados.IdDepartamento 
              INNER JOIN Puestos ON Empleados.IdPuesto = Puestos.IdPuesto WHERE Departamentos.NombreD LIKE '%" & Guna2TxtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                Guna2DgbEmpleados.DataSource = tabla
                LblTotal.Text = tabla.Rows.Count
            Else
                Guna2DgbEmpleados.DataSource = ""
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
            Guna2DgbEmpleados.DataSource = tabla
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
            sql = "UPDATE Empleados SET Nombre ='" & Guna2TxtNombreC.Text & "',Curp= '" & Guna2TxtCurp.Text & "', 
            Genero='" & Guna2CboGenero.Text & "',Telefono ='" & Guna2TxtTelefono.Text & "',Correo='" & Guna2Correo.Text & "',
            IdDepartamento= '" & Trim(Guna2CboDepto.SelectedValue) & "',IdPuesto= '" & Trim(Guna2CboPuesto.SelectedValue) & "' WHERE IdEmpleado= '" & TxtId.Text & "'"
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
            If MsgBox("¿seguro de eliminar a" + Trim(Guna2TxtNombreC.Text) + "De su registro?" + vbCr + "Esta accion ya no se puede revertir.", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtId_TextChanged(sender As Object, e As EventArgs) Handles TxtId.TextChanged

    End Sub

    Private Sub FrmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarcontroles()
        Llenardatos()
        Guna2DgbEmpleados.AutoGenerateColumns = False
        Mostrar_Departamentos()
        Guna2CboDepto.SelectedIndex = -1
        Mostrar_Puestos()
        Guna2CboPuesto.SelectedIndex = -1
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles Guna2BtnNuevo.Click
        activarcontroles()
        limpiarcontroles()
        Guna2BtnNuevo.Enabled = False
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles Guna2BtnGuardar.Click
        insertar()
        Llenardatos()
        desactivarcontroles()
        limpiarcontroles()

    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles Guna2TxtDireccion.TextChanged
        buscardatos()

    End Sub

    Private Sub rbNombreEmpleado_CheckedChanged(sender As Object, e As EventArgs)
        Guna2TxtBuscar.Focus()
    End Sub

    Private Sub RbCurp_CheckedChanged(sender As Object, e As EventArgs)
        Guna2TxtBuscar.Focus()

    End Sub

    Private Sub RbDepartamento_CheckedChanged(sender As Object, e As EventArgs)
        Guna2TxtBuscar.Focus()

    End Sub

    Private Sub DgbEmpleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DgbEmpleados.CellDoubleClick
        On Error Resume Next 'cuando se produce un error en tiempo de ejecucion esta instruccion se transfiere y no se interrumpe la ejecucion
        TxtId.Text = CStr(Guna2DgbEmpleados.Item("IdEmpleado", Guna2DgbEmpleados.CurrentCell.RowIndex).Value)
        Guna2TxtNombreC.Text = CStr(Guna2DgbEmpleados.Item("Nombre", Guna2DgbEmpleados.CurrentCell.RowIndex).Value)
        Guna2TxtCurp.Text = CStr(Guna2DgbEmpleados.Item("Curp", Guna2DgbEmpleados.CurrentCell.RowIndex).Value)
        Guna2TxtDireccion.Text = CStr(Guna2DgbEmpleados.Item("Direccion", Guna2DgbEmpleados.CurrentCell.RowIndex).Value)
        Guna2CboGenero.Text = CStr(Guna2DgbEmpleados.Item("Genero", Guna2DgbEmpleados.CurrentCell.RowIndex).Value)
        Guna2CboPuesto.Text = CStr(Guna2DgbEmpleados.Item("NombreP", Guna2DgbEmpleados.CurrentCell.RowIndex).Value)
        Guna2CboDepto.Text = CStr(Guna2DgbEmpleados.Item("NombreD", Guna2DgbEmpleados.CurrentCell.RowIndex).Value)
        Guna2TxtTelefono.Text = CStr(Guna2DgbEmpleados.Item("Telefono", Guna2DgbEmpleados.CurrentCell.RowIndex).Value)
        Guna2Correo.Text = CStr(Guna2DgbEmpleados.Item("Correo", Guna2DgbEmpleados.CurrentCell.RowIndex).Value)
        Guna2BtnCancelar.Enabled = True
        Guna2BntEditar.Enabled = True
        Guna2BtnBorrar.Enabled = True

        Guna2TxtNombreC.Enabled = True
        Guna2TxtCurp.Enabled = True
        Guna2TxtDireccion.Enabled = True
        Guna2TxtTelefono.Enabled = True
        Guna2Correo.Enabled = True
        Guna2CboDepto.Enabled = True
        Guna2CboGenero.Enabled = True
        Guna2CboPuesto.Enabled = True
        Guna2TxtNombreC.Focus()
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

    Private Sub BtnDepartamento_Click(sender As Object, e As EventArgs) Handles Guna2BtnDepto.Click
        frmDepartamentos.Show()

    End Sub
    'Dim frmPuestos As New frmPuestosTrabajo
    'Dim frmDepartamentos As New frmDepartamentos

    Private Sub BtnPuesto_Click(sender As Object, e As EventArgs) Handles Guna2BtnPuesto.Click
        'frmPuestos.Show()
        frmPuestosTrabajo.Show()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles Guna2BtnCancelar.Click
        desactivarcontroles()
        limpiarcontroles()

    End Sub

    Private Sub Guna2BtnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Guna2BtnExit_Click_1(sender As Object, e As EventArgs) Handles Guna2BtnExit.Click
        Me.Close()
        FrmMain.Visible = True
    End Sub
End Class