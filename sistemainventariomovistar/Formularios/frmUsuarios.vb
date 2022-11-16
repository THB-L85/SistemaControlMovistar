Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices

Public Class frmUsuarios
    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles Guna2btnSave.Click
        insertar()
        Llenardatos()
        desactivarcontroles()
        limpiarcontroles()
    End Sub

    Private Sub lblcontraseña_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles Guna2btnCancel.Click
        desactivarcontroles()
        limpiarcontroles()
    End Sub

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call desactivarcontroles()
        Llenardatos()
        Guna2dtgUsuario.AutoGenerateColumns = False

    End Sub
    Sub desactivarcontroles()
        Guna2btnSave.Enabled = False
        Guna2btnEdit.Enabled = False
        Guna2btnCancel.Enabled = False
        Guna2btnDelete.Enabled = False

        Guna2tbUser.Enabled = False
        Guna2tbName.Enabled = False
        Guna2tbPassword.Enabled = False
        Guna2cbState.Enabled = False
        Guna2cbType.Enabled = False

        Guna2btnNew.Enabled = True
    End Sub
    Sub activarcontroles()
        Guna2btnSave.Enabled = True
        Guna2btnEdit.Enabled = False
        Guna2btnCancel.Enabled = True
        Guna2btnDelete.Enabled = False

        Guna2tbUser.Enabled = True
        Guna2tbName.Enabled = True
        Guna2tbPassword.Enabled = True
        Guna2cbState.Enabled = True
        Guna2cbType.Enabled = True

        Guna2btnNew.Enabled = False
    End Sub
    Sub limpiarcontroles()
        Guna2tbName.Text = ""
        Guna2tbPassword.Text = ""
        Guna2tbUser.Text = ""
        Guna2cbState.Text = ""
        Guna2cbType.Text = ""
        TxtId.Text = ""
        Guna2txtSearch.Text = ""

    End Sub
    Sub Llenardatos()
        Dim sql As String
        sql = "SELECT * FROM Usuarios"
        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            Guna2dtgUsuario.DataSource = tabla
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
            sql = "UPDATE Usuarios SET NombreCompleto ='" & Guna2tbName.Text & "',Usuario= '" & Guna2tbUser.Text & "',Password='" & Guna2tbPassword.Text & "',TipoUsuario ='" & Guna2cbType.Text & "',Estado='" & Guna2cbState.Text & "' WHERE IdUsuarios= '" & TxtId.Text & "'"
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
            If MsgBox("¿seguro de eliminar a" + Trim(Guna2tbName.Text) + "De su registro?" + vbCr + "Esta accion ya no se puede revertir.", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
                limpiarcontroles()
                desactivarcontroles()
                Exit Sub
            Else


                Dim sql As String
                sql = "DELETE FROM Usuarios WHERE IdUsuarios = " & Trim(TxtId.Text)
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
    Sub insertar()
        Dim sql As String
        Dim id As Integer
        If MsgBox("Guardar Nuevo Registro", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
            Exit Sub

        End If
        adaptador = New SqlDataAdapter("SELECT * FROM Usuarios Where Usuario = '" & Guna2tbUser.Text & "' ", obtenerconexion)
        tabla.Clear() 'borra datos que trae datatable
        adaptador.Fill(tabla) 'actualiza o agrega dataset
        If tabla.Rows.Count > 0 Then
            Guna2tbUser.Text = tabla.Rows(0).Item("Usuario")
            MsgBox("El registro ya se encuentra en la base de datos ", vbInformation, "Sistema inventario")
            Exit Sub

        End If
        If Guna2tbName.Text = "" Or Guna2tbUser.Text = "" Or Guna2tbPassword.Text = "" Or Guna2cbState.Text = "" Or Guna2cbType.Text = "" Then
            MsgBox("Completar todos los campos", vbCritical, "Sistema inventario")
            Exit Sub
        Else
            sql = "INSERT INTO Usuarios(NombreCompleto,Usuario,Password,TipoUsuario,Estado)VALUES ('" & Guna2tbName.Text & "','" & Guna2tbUser.Text & "','" & Guna2tbPassword.Text & "','" & Guna2cbType.Text & "','" & Guna2cbState.Text & "') " ' consulta de insercion
            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()
            MsgBox("Registro realizado correctamente", vbInformation, "Sistema inventario")
        End If

    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles Guna2btnNew.Click
        activarcontroles()
    End Sub

    Private Sub DgbUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgbUsuarios.CellContentClick, Guna2dtgUsuario.CellContentClick

    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles Guna2txtSearch.TextChanged
        If Guna2txtSearch.Text = " " Then
            Llenardatos()

        End If
        adaptador = New SqlDataAdapter("SELECT * FROM Usuarios WHERE NombreCompleto LIKE '%" & Guna2txtSearch.Text & "%'", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            Guna2dtgUsuario.DataSource = tabla
            LblTotal.Text = tabla.Rows.Count
        Else
            Guna2dtgUsuario.DataSource = ""
        End If

    End Sub

    Private Sub DgbUsuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgbUsuarios.CellDoubleClick, Guna2dtgUsuario.CellDoubleClick
        On Error Resume Next 'cuando se produce un error en tiempo de ejecucion esta instruccion se transfiere y no se interrumpe la ejecucion
        TxtId.Text = CStr(Guna2dtgUsuario.Item("IdUsuarios", Guna2dtgUsuario.CurrentCell.RowIndex).Value)
        Guna2tbName.Text = CStr(Guna2dtgUsuario.Item("NombreCompleto", Guna2dtgUsuario.CurrentCell.RowIndex).Value)
        Guna2tbUser.Text = CStr(Guna2dtgUsuario.Item("Usuario", Guna2dtgUsuario.CurrentCell.RowIndex).Value)
        Guna2tbPassword.Text = CStr(Guna2dtgUsuario.Item("Password", Guna2dtgUsuario.CurrentCell.RowIndex).Value)
        Guna2cbType.Text = CStr(Guna2dtgUsuario.Item("TipoUsuario", Guna2dtgUsuario.CurrentCell.RowIndex).Value)
        Guna2cbState.Text = CStr(Guna2dtgUsuario.Item("Estado", Guna2dtgUsuario.CurrentCell.RowIndex).Value)
        Guna2btnCancel.Enabled = True
        Guna2btnEdit.Enabled = True
        Guna2btnDelete.Enabled = True

        Guna2tbUser.Enabled = True
        Guna2tbName.Enabled = True
        Guna2tbPassword.Enabled = True
        Guna2cbState.Enabled = True
        Guna2cbType.Enabled = True
        Guna2tbName.Focus()

        Guna2btnNew.Enabled = False

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles Guna2btnEdit.Click
        Editar()
        desactivarcontroles()
        Llenardatos()

    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles Guna2btnDelete.Click
        Eliminar()
        desactivarcontroles()
        Llenardatos()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Guna2btnExit.Click
        Me.Close()
    End Sub
End Class