Imports System.Data.SqlClient
Public Class frmPuestosTrabajo
    Private Sub frmPuestosTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarcontroles()
        'tamañoformulario()
        Llenardatos()

    End Sub
    Sub desactivarcontroles()
        Guna2btnGuardar.Enabled = False
        Guna2btnEditar.Enabled = False
        Guna2btnCancelar.Enabled = False
        Guna2btnBorrar.Enabled = False

        Guna2tbNameP.Enabled = False
        Guna2TxtDescripcionP.Enabled = False
        TxtId.Enabled = False

        Guna2btnNuevo.Enabled = True
        BtnBuscar.Enabled = True
    End Sub
    Sub activarcontroles()
        Guna2btnGuardar.Enabled = True
        Guna2btnEditar.Enabled = False
        Guna2btnCancelar.Enabled = True
        Guna2btnBorrar.Enabled = False
        BtnBuscar.Enabled = False

        Guna2tbNameP.Enabled = True
        Guna2TxtDescripcionP.Enabled = True
        TxtId.Enabled = True
        Guna2btnNuevo.Enabled = False
    End Sub
    Sub limpiarcontroles()
        Guna2tbNameP.Text = ""
        Guna2TxtDescripcionP.Text = ""
        TxtId.Text = ""
        Guna2txtBuscar.Text = ""

    End Sub
    Sub tamañoformulario()
        Width = 516
        Height = 252
        Panel1.Visible = False
        Guna2txtBuscar.Focus()
        Guna2txtBuscar.BackColor = Color.YellowGreen
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
        adaptador = New SqlDataAdapter("SELECT * FROM Puestos Where NombreP = '" & Guna2tbNameP.Text & "' ", obtenerconexion)
        tabla.Clear() 'borra datos que trae datatable
        adaptador.Fill(tabla) 'actualiza o agrega dataset
        If tabla.Rows.Count > 0 Then
            Guna2tbNameP.Text = tabla.Rows(0).Item("NombreP")
            MsgBox("El registro ya se encuentra en la base de datos ", vbInformation, "Sistema inventario")
            Exit Sub

        End If
        If Guna2tbNameP.Text = "" Or Guna2TxtDescripcionP.Text = "" Then
            MsgBox("Completar todos los campos", vbCritical, "Sistema inventario")
            Exit Sub
        Else
            sql = "INSERT INTO Puestos (NombreP,DescripcionP)VALUES ('" & Guna2tbNameP.Text & "','" & Guna2TxtDescripcionP.Text & "' )" ' consulta de insercion
            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()
            MsgBox("Registro realizado correctamente", vbInformation, "Sistema inventario")
        End If

    End Sub
    Sub Llenardatos()
        Dim sql As String
        sql = "SELECT * FROM Puestos"
        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            Guna2DgbPuestos.DataSource = tabla
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
            sql = "UPDATE Puestos SET NombreP ='" & Guna2tbNameP.Text & "',DescripcionP= '" & Guna2TxtDescripcionP.Text & "' WHERE IdPuesto = '" & TxtId.Text & "'"
            Dim conect As New SqlConnection(obtenerconexion)
                conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            If MsgBox("¿seguro de editar a " + Trim(Guna2tbNameP.Text) + " De su registro?", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
                limpiarcontroles()
                desactivarcontroles()
                Exit Sub
            Else

                conect.Close()
                MsgBox("Registro Editado correctamente", vbInformation, "Sistema inventario")
                limpiarcontroles()

            End If
        End If
    End Sub
    Sub Eliminar()
        Dim id As Integer
        If TxtId.Text = 0 Then
            MsgBox("Existen datos vacios", vbInformation, "Sistema de inventario")
        Else
            If MsgBox("¿seguro de eliminar a " + Trim(Guna2tbNameP.Text) + " De su registro?" + vbCr + "Esta accion ya no se puede revertir.", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
                limpiarcontroles()
                desactivarcontroles()
                Exit Sub
            Else

                Dim sql As String
                sql = "DELETE FROM Puestos WHERE IdPuesto = " & Trim(TxtId.Text)
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

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles Guna2btnNuevo.Click
        activarcontroles()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles Guna2btnGuardar.Click
        insertar()
        Llenardatos()
        desactivarcontroles()
        limpiarcontroles()

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        'tamañoformulariobuscar()
        Guna2btnCancelar.Enabled = True
        BtnBuscar.Enabled = False
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles Guna2btnEditar.Click
        Editar()
        desactivarcontroles()
        Llenardatos()
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles Guna2btnBorrar.Click
        Eliminar()
        desactivarcontroles()
        Llenardatos()

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles Guna2btnCancelar.Click
        'tamañoformulario()
        limpiarcontroles()
        desactivarcontroles()
        'Panel1.Visible = False
        Guna2btnCancelar.Enabled = False
        BtnBuscar.Enabled = True

    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles Guna2txtBuscar.TextChanged
        If Guna2txtBuscar.Text = " " Then
            Llenardatos()

        End If
        adaptador = New SqlDataAdapter("SELECT * FROM Puestos WHERE NombreP LIKE '%" & Guna2txtBuscar.Text & "%'", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            Guna2DgbPuestos.DataSource = tabla
            LblTotal.Text = tabla.Rows.Count
        Else
            Guna2DgbPuestos.DataSource = ""
        End If

    End Sub

    Private Sub DgbPuestos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DgbPuestos.CellDoubleClick
        On Error Resume Next 'cuando se produce un error en tiempo de ejecucion esta instruccion se transfiere y no se interrumpe la ejecucion
        TxtId.Text = CStr(Guna2DgbPuestos.Item("IdPuesto", Guna2DgbPuestos.CurrentCell.RowIndex).Value)
        Guna2tbNameP.Text = CStr(Guna2DgbPuestos.Item("NombreP", Guna2DgbPuestos.CurrentCell.RowIndex).Value)
        Guna2TxtDescripcionP.Text = CStr(Guna2DgbPuestos.Item("DescripcionP", Guna2DgbPuestos.CurrentCell.RowIndex).Value)
        Guna2btnCancelar.Enabled = True
        Guna2btnEditar.Enabled = True
        Guna2btnBorrar.Enabled = True

        Guna2tbNameP.Enabled = True
        Guna2TxtDescripcionP.Enabled = True
        Guna2tbNameP.Focus()

        Guna2btnNuevo.Enabled = False

    End Sub

    Private Sub Guna2btnExit_Click(sender As Object, e As EventArgs) Handles Guna2btnExit.Click
        Me.Close()
    End Sub
End Class