Imports System.Data.SqlClient

Public Class frmDepartamentos
    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TxtDescripcionD.TextChanged

    End Sub
    Sub desactivarcontroles()
        BtnGuardar.Enabled = False
        BtnEditar.Enabled = False
        BtnCancelar.Enabled = False
        BtnBorrar.Enabled = False

        TxtNombreD.Enabled = False
        TxtDescripcionD.Enabled = False
        TxtId.Enabled = False
        TxtNombreD.Enabled = False

        BtnNuevo.Enabled = True
        BtnBuscar.Enabled = True
    End Sub
    Sub activarcontroles()
        BtnGuardar.Enabled = True
        BtnEditar.Enabled = False
        BtnCancelar.Enabled = True
        BtnBorrar.Enabled = False
        BtnBuscar.Enabled = False

        TxtNombreD.Enabled = True
        TxtDescripcionD.Enabled = True
        TxtId.Enabled = True
        BtnNuevo.Enabled = False
    End Sub
    Sub limpiarcontroles()
        TxtNombreD.Text = ""
        TxtDescripcionD.Text = ""
        TxtId.Text = ""
        TxtBuscar.Text = ""

    End Sub
    Sub tamañoformulario()
        Width = 516
        Height = 229
        Panel1.Visible = False
        TxtBuscar.Focus()
        TxtBuscar.BackColor = Color.YellowGreen
    End Sub
    Sub tamañoformulariobuscar()
        Width = 516
        Height = 479
        Panel1.Visible = True
    End Sub
    Sub insertar()
        Dim sql As String
        Dim id As Integer
        If MsgBox("Guardar Nuevo Registro", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
            Exit Sub

        End If
        adaptador = New SqlDataAdapter("SELECT * FROM Departamentos Where NombreD = '" & TxtNombreD.Text & "' ", obtenerconexion)
        tabla.Clear() 'borra datos que trae datatable
        adaptador.Fill(tabla) 'actualiza o agrega dataset
        If tabla.Rows.Count > 0 Then
            TxtNombreD.Text = tabla.Rows(0).Item("NombreD")
            MsgBox("El registro ya se encuentra en la base de datos ", vbInformation, "Sistema inventario")
            Exit Sub

        End If
        If TxtNombreD.Text = "" Or TxtDescripcionD.Text = "" Then
            MsgBox("Completar todos los campos", vbCritical, "Sistema inventario")
            Exit Sub
        Else
            sql = "INSERT INTO Departamentos(NombreD,Descripcion)VALUES ('" & TxtNombreD.Text & "','" & TxtDescripcionD.Text & "' )" ' consulta de insercion
            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()
            MsgBox("Registro realizado correctamente", vbInformation, "Sistema inventario")
        End If

    End Sub
    Sub Editar()
        Dim id As Integer
        If TxtId.Text = 0 Then
            MsgBox("Existen datos vacios", vbInformation, "Sistema de inventario")
        Else
            Dim sql As String
            sql = "UPDATE Departamentos SET NombreD ='" & TxtNombreD.Text & "',Descripcion= '" & TxtDescripcionD.Text & "' WHERE IdDepartamento = '" & TxtId.Text & "'"
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
            If MsgBox("¿seguro de eliminar a " + Trim(TxtNombreD.Text) + " De su registro?" + vbCr + "Esta accion ya no se puede revertir.", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
                limpiarcontroles()
                desactivarcontroles()
                Exit Sub
            Else


                Dim sql As String
                sql = "DELETE FROM Departamentos WHERE IdDepartamento = " & Trim(TxtId.Text)
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

    Sub Llenardatos()
        Dim sql As String
        sql = "SELECT * FROM Departamentos"
        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            DgbDepartamentos.DataSource = tabla
            LblTotal.Text = tabla.Rows.Count

        Catch ex As Exception
            MsgBox("Se ha encontrado el siguiente error ", ex.ToString + "Sistema inventario")
        End Try
    End Sub

    Private Sub frmDepartamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarcontroles()
        tamañoformulario()
        Llenardatos()


    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        activarcontroles()

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        insertar()
        Llenardatos()
        desactivarcontroles()
        limpiarcontroles()

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        tamañoformulariobuscar()
        BtnCancelar.Enabled = True
        BtnBuscar.Enabled = False
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        tamañoformulario()
        limpiarcontroles()
        desactivarcontroles()
        Panel1.Visible = False
        BtnCancelar.Enabled = False
        BtnBuscar.Enabled = True

    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        If TxtBuscar.Text = " " Then
            Llenardatos()

        End If
        adaptador = New SqlDataAdapter("SELECT * FROM Departamentos WHERE NombreD LIKE '%" & TxtBuscar.Text & "%'", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            DgbDepartamentos.DataSource = tabla
            LblTotal.Text = tabla.Rows.Count
        Else
            DgbDepartamentos.DataSource = ""
        End If

    End Sub

    Private Sub DgbDepartamentos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgbDepartamentos.CellDoubleClick
        On Error Resume Next 'cuando se produce un error en tiempo de ejecucion esta instruccion se transfiere y no se interrumpe la ejecucion
        TxtId.Text = CStr(DgbDepartamentos.Item("IdDepartamento", DgbDepartamentos.CurrentCell.RowIndex).Value)
        TxtNombreD.Text = CStr(DgbDepartamentos.Item("NombreD", DgbDepartamentos.CurrentCell.RowIndex).Value)
        TxtDescripcionD.Text = CStr(DgbDepartamentos.Item("Descripcion", DgbDepartamentos.CurrentCell.RowIndex).Value)
        BtnCancelar.Enabled = True
        BtnEditar.Enabled = True
        BtnBorrar.Enabled = True

        TxtNombreD.Enabled = True
        TxtDescripcionD.Enabled = True
        TxtNombreD.Focus()

        BtnNuevo.Enabled = False

    End Sub

    Private Sub BtnEditar_Click_1(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Editar()
        desactivarcontroles()
        Llenardatos()
    End Sub

    Private Sub BtnBorrar_Click_1(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        Eliminar()
        desactivarcontroles()
        Llenardatos()

    End Sub
End Class