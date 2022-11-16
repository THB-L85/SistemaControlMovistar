Imports System.Data.SqlClient
Public Class frmDescargoActivos
    Private Sub frmDescargoActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarcontroles()
        limpiarcontroles()
        ' Llenardatos()

        TxtCodigoInv.AutoCompleteMode = AutoCompleteMode.Suggest
        TxtCodigoInv.AutoCompleteSource = AutoCompleteSource.CustomSource
        TxtCodigoInv.AutoCompleteCustomSource = obtenercodigoinventario()

        'TxtCurp.AutoCompleteMode = AutoCompleteMode.Suggest
        'TxtCurp.AutoCompleteSource = AutoCompleteSource.CustomSource
        'TxtCurp.AutoCompleteCustomSource = obtenerIdentidades()

        DgbActivosDescargados.AutoGenerateColumns = False

    End Sub
    Sub desactivarcontroles()
        BtnGuardar.Enabled = False
        BtnEditar.Enabled = False
        BtnCancelar.Enabled = False
        BtnBorrar.Enabled = False
        Btncodigoinv.Enabled = False

        txtNombreArt.Enabled = False
        TxtCodigoInv.Enabled = False
        TxtNserie.Enabled = False
        TxtCodigoInv.Enabled = False
        TxtDescripcion.Enabled = False
        TxtCurp.Enabled = False
        TxtDepartamento.Enabled = False
        TxtNombreE.Enabled = False
        CboMotivo.Enabled = False
        DTPFechaEntrega.Enabled = False
        DTPFechaDescargo.Enabled = False

        BtnNuevo.Enabled = True
    End Sub
    Sub activarcontroles()
        BtnGuardar.Enabled = True
        BtnEditar.Enabled = False
        BtnCancelar.Enabled = True
        BtnBorrar.Enabled = False
        Btncodigoinv.Enabled = True


        txtNombreArt.Enabled = True
        TxtCodigoInv.Enabled = True
        TxtNserie.Enabled = True
        TxtCodigoInv.Enabled = True
        TxtDescripcion.Enabled = True
        TxtCurp.Enabled = True
        TxtDepartamento.Enabled = True
        TxtNombreE.Enabled = True
        CboMotivo.Enabled = True
        DTPFechaEntrega.Enabled = False
        DTPFechaDescargo.Enabled = True


        BtnNuevo.Enabled = False
    End Sub
    Sub limpiarcontroles()
        txtNombreArt.Clear()
        TxtCodigoInv.Clear()
        TxtNserie.Clear()
        TxtCodigoInv.Clear()
        TxtDescripcion.Clear()
        TxtCurp.Clear()
        TxtDepartamento.Clear()
        TxtNombreE.Clear()
        CboMotivo.Text = ""
        DTPFechaEntrega.Text = ""
        DTPFechaDescargo.Text = ""
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

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        activarcontroles()
        limpiarcontroles()

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        desactivarcontroles()
        limpiarcontroles()

    End Sub

    Private Sub TxtCodigoInv_TextChanged(sender As Object, e As EventArgs) Handles TxtCodigoInv.TextChanged
        If TxtCodigoInv.Text <> "" Then
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo,CargoActivos.fechaAsignacion,Articulo.IdArticulo,
            Articulo.NombreA,Articulo.NumeroSerie,Empleados.Nombre,Empleados.Curp,Departamentos.NombreD
            FROM Articulo INNER JOIN CargoActivos ON Articulo.IdArticulo = CargoActivos.IdArticulo 
                          INNER JOIN Empleados ON CargoActivos.IdEmpleado = Empleados.IdEmpleado
                          INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento
                          WHERE CargoActivos.CodigoInventario='" & TxtCodigoInv.Text & "'", obtenerconexion)
            Dim tabla As New DataTable
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count = 1 Then
                Dim fila As DataRow = tabla.Rows(0)
                txtNombreArt.Text = fila("NombreA").ToString
                TxtNserie.Text = fila("NumeroSerie").ToString
                TxtIdArticulo.Text = fila("idArticulo").ToString
                TxtCurp.Text = fila("Curp").ToString
                TxtNombreE.Text = fila("Nombre").ToString
                TxtDepartamento.Text = fila("NombreD").ToString
                DTPFechaEntrega.Text = fila("fechaAsignacion").ToString
            Else
                txtNombreArt.Clear()
                TxtCodigoInv.Focus()
            End If
        End If
    End Sub
End Class