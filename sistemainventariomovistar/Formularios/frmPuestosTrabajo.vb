Imports System.Data.SqlClient
Public Class frmPuestosTrabajo
    Private Sub frmPuestosTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarcontroles()
        tamañoformulario()
        Llenardatos()

    End Sub
    Sub desactivarcontroles()
        BtnGuardar.Enabled = False
        BtnEditar.Enabled = False
        BtnCancelar.Enabled = False
        BtnBorrar.Enabled = False

        TxtNombreP.Enabled = False
        TxtDescripcionP.Enabled = False
        TxtId.Enabled = False

        BtnNuevo.Enabled = True
        BtnBuscar.Enabled = True
    End Sub
    Sub activarcontroles()
        BtnGuardar.Enabled = True
        BtnEditar.Enabled = False
        BtnCancelar.Enabled = True
        BtnBorrar.Enabled = False
        BtnBuscar.Enabled = False

        TxtNombreP.Enabled = True
        TxtDescripcionP.Enabled = True
        TxtId.Enabled = True
        BtnNuevo.Enabled = False
    End Sub
    Sub limpiarcontroles()
        TxtNombreP.Text = ""
        TxtDescripcionP.Text = ""
        TxtId.Text = ""
        TxtBuscar.Text = ""

    End Sub
    Sub tamañoformulario()
        Width = 516
        Height = 252
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
        adaptador = New SqlDataAdapter("SELECT * FROM Puestos Where NombreP = '" & TxtNombreP.Text & "' ", obtenerconexion)
        tabla.Clear() 'borra datos que trae datatable
        adaptador.Fill(tabla) 'actualiza o agrega dataset
        If tabla.Rows.Count > 0 Then
            TxtNombreP.Text = tabla.Rows(0).Item("NombreP")
            MsgBox("El registro ya se encuentra en la base de datos ", vbInformation, "Sistema inventario")
            Exit Sub

        End If
        If TxtNombreP.Text = "" Or TxtDescripcionP.Text = "" Then
            MsgBox("Completar todos los campos", vbCritical, "Sistema inventario")
            Exit Sub
        Else
            sql = "INSERT INTO Puestos (NombreP,DescripcionP)VALUES ('" & TxtNombreP.Text & "','" & TxtDescripcionP.Text & "' )" ' consulta de insercion
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
            DgbPuestos.DataSource = tabla
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
            sql = "UPDATE Puestos SET NombreP ='" & TxtNombreP.Text & "',DescripcionP= '" & TxtDescripcionP.Text & "' WHERE IdPuesto = '" & TxtId.Text & "'"
                Dim conect As New SqlConnection(obtenerconexion)
                conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            If MsgBox("¿seguro de editar a " + Trim(TxtNombreP.Text) + " De su registro?", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
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
            If MsgBox("¿seguro de eliminar a " + Trim(TxtNombreP.Text) + " De su registro?" + vbCr + "Esta accion ya no se puede revertir.", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
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
        adaptador = New SqlDataAdapter("SELECT * FROM Puestos WHERE NombreP LIKE '%" & TxtBuscar.Text & "%'", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            DgbPuestos.DataSource = tabla
            LblTotal.Text = tabla.Rows.Count
        Else
            DgbPuestos.DataSource = ""
        End If

    End Sub

    Private Sub DgbPuestos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgbPuestos.CellDoubleClick
        On Error Resume Next 'cuando se produce un error en tiempo de ejecucion esta instruccion se transfiere y no se interrumpe la ejecucion
        TxtId.Text = CStr(DgbPuestos.Item("IdPuesto", DgbPuestos.CurrentCell.RowIndex).Value)
        TxtNombreP.Text = CStr(DgbPuestos.Item("NombreP", DgbPuestos.CurrentCell.RowIndex).Value)
        TxtDescripcionP.Text = CStr(DgbPuestos.Item("DescripcionP", DgbPuestos.CurrentCell.RowIndex).Value)
        BtnCancelar.Enabled = True
        BtnEditar.Enabled = True
        BtnBorrar.Enabled = True

        TxtNombreP.Enabled = True
        TxtDescripcionP.Enabled = True
        TxtNombreP.Focus()

        BtnNuevo.Enabled = False

    End Sub
End Class