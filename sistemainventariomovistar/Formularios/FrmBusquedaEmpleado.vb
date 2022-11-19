Imports System.Data.SqlClient


Public Class FrmBusquedaEmpleado
    Private Sub FrmBusquedaEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Llenardatos()

    End Sub
    Sub buscardatos()
        If Guna2RbNombreEmpleado.Checked Then
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
        If Guna2RbDepartamento.Checked Then
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

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        buscardatos()
    End Sub
    Dim FrmEmpleados As New FrmEmpleados

    Private Sub DgbEmpleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DgbEmpleados.CellDoubleClick
        On Error Resume Next 'cuando se produce un error en tiempo de ejecucion esta instruccion se transfiere y no se interrumpe la ejecucion
        FrmEmpleados.TxtId.Text = CStr(Guna2DgbEmpleados.Item("IdEmpleado", Guna2DgbEmpleados.CurrentCell.RowIndex).Value)
        FrmEmpleados.Guna2TxtNombreC.Text = CStr(Guna2DgbEmpleados.Item("Nombre", Guna2DgbEmpleados.CurrentCell.RowIndex).Value)
        FrmEmpleados.Guna2TxtCurp.Text = CStr(Guna2DgbEmpleados.Item("Curp", Guna2DgbEmpleados.CurrentCell.RowIndex).Value)
        FrmEmpleados.Guna2CboDepto.Text = CStr(Guna2DgbEmpleados.Item("NombreD", Guna2DgbEmpleados.CurrentCell.RowIndex).Value)
        Me.Close()

    End Sub
End Class