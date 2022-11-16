Imports System.Data.SqlClient


Public Class FrmBusquedaEmpleado
    Private Sub FrmBusquedaEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Llenardatos()

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

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        buscardatos()
    End Sub
    Dim FrmEmpleados As New FrmEmpleados

    Private Sub DgbEmpleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgbEmpleados.CellDoubleClick
        On Error Resume Next 'cuando se produce un error en tiempo de ejecucion esta instruccion se transfiere y no se interrumpe la ejecucion
        FrmEmpleados.TxtId.Text = CStr(DgbEmpleados.Item("IdEmpleado", DgbEmpleados.CurrentCell.RowIndex).Value)
        FrmEmpleados.txtNombrecompleto.Text = CStr(DgbEmpleados.Item("Nombre", DgbEmpleados.CurrentCell.RowIndex).Value)
        FrmEmpleados.TxtCurp.Text = CStr(DgbEmpleados.Item("Curp", DgbEmpleados.CurrentCell.RowIndex).Value)
        FrmEmpleados.cboDepartamento.Text = CStr(DgbEmpleados.Item("NombreD", DgbEmpleados.CurrentCell.RowIndex).Value)
        Me.Close()

    End Sub
End Class