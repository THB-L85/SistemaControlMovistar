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

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs)
        activarcontroles()
        limpiarcontroles()

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs)
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

    Private Sub Guna2BtnExit_Click(sender As Object, e As EventArgs) Handles Guna2BtnExit.Click
        Me.Close()
        FrmMain.Visible = True
    End Sub
End Class