<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDescargoActivos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtIdEmpleado = New System.Windows.Forms.TextBox()
        Me.TxtIdArticulo = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Lbldireccion = New System.Windows.Forms.Label()
        Me.TxtDepartamento = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Btncodigoinv = New System.Windows.Forms.Button()
        Me.TxtCurp = New System.Windows.Forms.TextBox()
        Me.Ll = New System.Windows.Forms.Label()
        Me.TxtCodigoInv = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNombreE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblestado = New System.Windows.Forms.Label()
        Me.CboMotivo = New System.Windows.Forms.ComboBox()
        Me.TxtNserie = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DTPFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RbCodigoA = New System.Windows.Forms.RadioButton()
        Me.Rbfecha = New System.Windows.Forms.RadioButton()
        Me.rbNombreA = New System.Windows.Forms.RadioButton()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.DgbActivosDescargados = New System.Windows.Forms.DataGridView()
        Me.IdArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoInventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroSerie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNombreArt = New System.Windows.Forms.TextBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.DTPFechaDescargo = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DgbActivosDescargados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtIdEmpleado
        '
        Me.TxtIdEmpleado.Location = New System.Drawing.Point(714, 200)
        Me.TxtIdEmpleado.Name = "TxtIdEmpleado"
        Me.TxtIdEmpleado.Size = New System.Drawing.Size(32, 20)
        Me.TxtIdEmpleado.TabIndex = 139
        Me.TxtIdEmpleado.Visible = False
        '
        'TxtIdArticulo
        '
        Me.TxtIdArticulo.Location = New System.Drawing.Point(665, 200)
        Me.TxtIdArticulo.Name = "TxtIdArticulo"
        Me.TxtIdArticulo.Size = New System.Drawing.Size(32, 20)
        Me.TxtIdArticulo.TabIndex = 138
        Me.TxtIdArticulo.Visible = False
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(82, 200)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(553, 31)
        Me.TxtDescripcion.TabIndex = 137
        '
        'Lbldireccion
        '
        Me.Lbldireccion.AutoSize = True
        Me.Lbldireccion.Location = New System.Drawing.Point(10, 203)
        Me.Lbldireccion.Name = "Lbldireccion"
        Me.Lbldireccion.Size = New System.Drawing.Size(63, 13)
        Me.Lbldireccion.TabIndex = 136
        Me.Lbldireccion.Text = "Descripcion"
        '
        'TxtDepartamento
        '
        Me.TxtDepartamento.Location = New System.Drawing.Point(109, 142)
        Me.TxtDepartamento.Name = "TxtDepartamento"
        Me.TxtDepartamento.ReadOnly = True
        Me.TxtDepartamento.Size = New System.Drawing.Size(120, 20)
        Me.TxtDepartamento.TabIndex = 135
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 134
        Me.Label8.Text = "Departamento"
        '
        'Btncodigoinv
        '
        Me.Btncodigoinv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncodigoinv.Location = New System.Drawing.Point(234, 30)
        Me.Btncodigoinv.Name = "Btncodigoinv"
        Me.Btncodigoinv.Size = New System.Drawing.Size(45, 21)
        Me.Btncodigoinv.TabIndex = 132
        Me.Btncodigoinv.Text = "..."
        Me.Btncodigoinv.UseVisualStyleBackColor = True
        '
        'TxtCurp
        '
        Me.TxtCurp.Location = New System.Drawing.Point(109, 80)
        Me.TxtCurp.Name = "TxtCurp"
        Me.TxtCurp.ReadOnly = True
        Me.TxtCurp.Size = New System.Drawing.Size(121, 20)
        Me.TxtCurp.TabIndex = 131
        '
        'Ll
        '
        Me.Ll.AutoSize = True
        Me.Ll.Location = New System.Drawing.Point(10, 83)
        Me.Ll.Name = "Ll"
        Me.Ll.Size = New System.Drawing.Size(29, 13)
        Me.Ll.TabIndex = 130
        Me.Ll.Text = "Curp"
        '
        'TxtCodigoInv
        '
        Me.TxtCodigoInv.Location = New System.Drawing.Point(109, 31)
        Me.TxtCodigoInv.Name = "TxtCodigoInv"
        Me.TxtCodigoInv.Size = New System.Drawing.Size(121, 20)
        Me.TxtCodigoInv.TabIndex = 129
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 128
        Me.Label6.Text = "Codigo Inventario"
        '
        'TxtNombreE
        '
        Me.TxtNombreE.Location = New System.Drawing.Point(388, 76)
        Me.TxtNombreE.Name = "TxtNombreE"
        Me.TxtNombreE.ReadOnly = True
        Me.TxtNombreE.Size = New System.Drawing.Size(247, 20)
        Me.TxtNombreE.TabIndex = 127
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(285, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "Nombre empleado"
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.Location = New System.Drawing.Point(662, 76)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(54, 26)
        Me.lblestado.TabIndex = 125
        Me.lblestado.Text = "Motivo de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "descargo"
        '
        'CboMotivo
        '
        Me.CboMotivo.FormattingEnabled = True
        Me.CboMotivo.Items.AddRange(New Object() {"obsoleto", "cambio"})
        Me.CboMotivo.Location = New System.Drawing.Point(769, 77)
        Me.CboMotivo.Name = "CboMotivo"
        Me.CboMotivo.Size = New System.Drawing.Size(121, 21)
        Me.CboMotivo.TabIndex = 124
        '
        'TxtNserie
        '
        Me.TxtNserie.Location = New System.Drawing.Point(770, 26)
        Me.TxtNserie.Name = "TxtNserie"
        Me.TxtNserie.ReadOnly = True
        Me.TxtNserie.Size = New System.Drawing.Size(120, 20)
        Me.TxtNserie.TabIndex = 123
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(662, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 122
        Me.Label5.Text = "Numero de serie"
        '
        'DTPFechaEntrega
        '
        Me.DTPFechaEntrega.Enabled = False
        Me.DTPFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaEntrega.Location = New System.Drawing.Point(388, 138)
        Me.DTPFechaEntrega.Name = "DTPFechaEntrega"
        Me.DTPFechaEntrega.Size = New System.Drawing.Size(247, 20)
        Me.DTPFechaEntrega.TabIndex = 121
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(285, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "Fecha de Entrega"
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(4, -2)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(32, 20)
        Me.TxtId.TabIndex = 119
        Me.TxtId.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RbCodigoA)
        Me.Panel1.Controls.Add(Me.Rbfecha)
        Me.Panel1.Controls.Add(Me.rbNombreA)
        Me.Panel1.Controls.Add(Me.LblTotal)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtBuscar)
        Me.Panel1.Controls.Add(Me.DgbActivosDescargados)
        Me.Panel1.Location = New System.Drawing.Point(4, 237)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1084, 289)
        Me.Panel1.TabIndex = 118
        '
        'RbCodigoA
        '
        Me.RbCodigoA.AutoSize = True
        Me.RbCodigoA.Location = New System.Drawing.Point(384, 44)
        Me.RbCodigoA.Name = "RbCodigoA"
        Me.RbCodigoA.Size = New System.Drawing.Size(111, 17)
        Me.RbCodigoA.TabIndex = 22
        Me.RbCodigoA.Text = "Codigo de Articulo"
        Me.RbCodigoA.UseVisualStyleBackColor = True
        '
        'Rbfecha
        '
        Me.Rbfecha.AutoSize = True
        Me.Rbfecha.Location = New System.Drawing.Point(243, 42)
        Me.Rbfecha.Name = "Rbfecha"
        Me.Rbfecha.Size = New System.Drawing.Size(55, 17)
        Me.Rbfecha.TabIndex = 21
        Me.Rbfecha.Text = "Fecha"
        Me.Rbfecha.UseVisualStyleBackColor = True
        '
        'rbNombreA
        '
        Me.rbNombreA.AutoSize = True
        Me.rbNombreA.Checked = True
        Me.rbNombreA.Location = New System.Drawing.Point(17, 42)
        Me.rbNombreA.Name = "rbNombreA"
        Me.rbNombreA.Size = New System.Drawing.Size(127, 17)
        Me.rbNombreA.TabIndex = 20
        Me.rbNombreA.TabStop = True
        Me.rbNombreA.Text = "Nombre de Empleado"
        Me.rbNombreA.UseVisualStyleBackColor = True
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(75, 265)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(31, 13)
        Me.LblTotal.TabIndex = 19
        Me.LblTotal.Text = "Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = " Registrados"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Buscar"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(568, 41)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(516, 20)
        Me.TxtBuscar.TabIndex = 1
        '
        'DgbActivosDescargados
        '
        Me.DgbActivosDescargados.AllowUserToAddRows = False
        Me.DgbActivosDescargados.AllowUserToDeleteRows = False
        Me.DgbActivosDescargados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgbActivosDescargados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdArticulo, Me.CodigoInventario, Me.NombreA, Me.Nombre, Me.fechaAsignacion, Me.NombreD, Me.NumeroSerie, Me.Descripcion})
        Me.DgbActivosDescargados.Location = New System.Drawing.Point(1, 75)
        Me.DgbActivosDescargados.Name = "DgbActivosDescargados"
        Me.DgbActivosDescargados.ReadOnly = True
        Me.DgbActivosDescargados.RowHeadersVisible = False
        Me.DgbActivosDescargados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgbActivosDescargados.Size = New System.Drawing.Size(1083, 187)
        Me.DgbActivosDescargados.TabIndex = 0
        '
        'IdArticulo
        '
        Me.IdArticulo.DataPropertyName = "IdArticulo"
        Me.IdArticulo.HeaderText = "ID"
        Me.IdArticulo.Name = "IdArticulo"
        Me.IdArticulo.ReadOnly = True
        Me.IdArticulo.Visible = False
        '
        'CodigoInventario
        '
        Me.CodigoInventario.DataPropertyName = "CodigoInventario"
        Me.CodigoInventario.HeaderText = "CODIGO DE INVENTARIO"
        Me.CodigoInventario.Name = "CodigoInventario"
        Me.CodigoInventario.ReadOnly = True
        Me.CodigoInventario.Width = 150
        '
        'NombreA
        '
        Me.NombreA.DataPropertyName = "NombreA"
        Me.NombreA.HeaderText = "NOMBRE ACTIVO"
        Me.NombreA.Name = "NombreA"
        Me.NombreA.ReadOnly = True
        Me.NombreA.Width = 200
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "NOMBRE DE EMPLEADO"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 200
        '
        'fechaAsignacion
        '
        Me.fechaAsignacion.DataPropertyName = "fechaAsignacion"
        Me.fechaAsignacion.HeaderText = "FECHA DE ASIGNACION"
        Me.fechaAsignacion.Name = "fechaAsignacion"
        Me.fechaAsignacion.ReadOnly = True
        Me.fechaAsignacion.Width = 150
        '
        'NombreD
        '
        Me.NombreD.DataPropertyName = "NombreD"
        Me.NombreD.HeaderText = "DEPARTAMENTO"
        Me.NombreD.Name = "NombreD"
        Me.NombreD.ReadOnly = True
        Me.NombreD.Width = 150
        '
        'NumeroSerie
        '
        Me.NumeroSerie.DataPropertyName = "NumeroSerie"
        Me.NumeroSerie.HeaderText = "NUMERO DE SERIE"
        Me.NumeroSerie.Name = "NumeroSerie"
        Me.NumeroSerie.ReadOnly = True
        Me.NumeroSerie.Width = 200
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "DESCRIPCION"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 200
        '
        'txtNombreArt
        '
        Me.txtNombreArt.Location = New System.Drawing.Point(388, 26)
        Me.txtNombreArt.Name = "txtNombreArt"
        Me.txtNombreArt.ReadOnly = True
        Me.txtNombreArt.Size = New System.Drawing.Size(247, 20)
        Me.txtNombreArt.TabIndex = 116
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(285, 29)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(85, 13)
        Me.lblnombre.TabIndex = 114
        Me.lblnombre.Text = "Nombre  Articulo"
        '
        'DTPFechaDescargo
        '
        Me.DTPFechaDescargo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaDescargo.Location = New System.Drawing.Point(769, 139)
        Me.DTPFechaDescargo.Name = "DTPFechaDescargo"
        Me.DTPFechaDescargo.Size = New System.Drawing.Size(134, 20)
        Me.DTPFechaDescargo.TabIndex = 141
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(662, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 13)
        Me.Label7.TabIndex = 140
        Me.Label7.Text = "Fecha de Descargo"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(921, 136)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(73, 23)
        Me.BtnBuscar.TabIndex = 147
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(1000, 136)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(73, 23)
        Me.BtnCancelar.TabIndex = 146
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Location = New System.Drawing.Point(999, 75)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(73, 23)
        Me.BtnBorrar.TabIndex = 145
        Me.BtnBorrar.Text = "Eliminar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(920, 75)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(73, 23)
        Me.BtnEditar.TabIndex = 144
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(999, 26)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(73, 23)
        Me.BtnGuardar.TabIndex = 143
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(920, 26)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(73, 23)
        Me.BtnNuevo.TabIndex = 142
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'frmDescargoActivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 602)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.DTPFechaDescargo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtIdEmpleado)
        Me.Controls.Add(Me.TxtIdArticulo)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.Lbldireccion)
        Me.Controls.Add(Me.TxtDepartamento)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Btncodigoinv)
        Me.Controls.Add(Me.TxtCurp)
        Me.Controls.Add(Me.Ll)
        Me.Controls.Add(Me.TxtCodigoInv)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtNombreE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblestado)
        Me.Controls.Add(Me.CboMotivo)
        Me.Controls.Add(Me.TxtNserie)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DTPFechaEntrega)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtNombreArt)
        Me.Controls.Add(Me.lblnombre)
        Me.MaximizeBox = False
        Me.Name = "frmDescargoActivos"
        Me.Text = "REGISTRO DE BAJAS DE ACTIVOS A EMPLEADOS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgbActivosDescargados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtIdEmpleado As TextBox
    Friend WithEvents TxtIdArticulo As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Lbldireccion As Label
    Friend WithEvents TxtDepartamento As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Btncodigoinv As Button
    Friend WithEvents TxtCurp As TextBox
    Friend WithEvents Ll As Label
    Friend WithEvents TxtCodigoInv As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNombreE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblestado As Label
    Friend WithEvents CboMotivo As ComboBox
    Friend WithEvents TxtNserie As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DTPFechaEntrega As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RbCodigoA As RadioButton
    Friend WithEvents Rbfecha As RadioButton
    Friend WithEvents rbNombreA As RadioButton
    Friend WithEvents LblTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents DgbActivosDescargados As DataGridView
    Friend WithEvents IdArticulo As DataGridViewTextBoxColumn
    Friend WithEvents CodigoInventario As DataGridViewTextBoxColumn
    Friend WithEvents NombreA As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents fechaAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents NombreD As DataGridViewTextBoxColumn
    Friend WithEvents NumeroSerie As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents txtNombreArt As TextBox
    Friend WithEvents lblnombre As Label
    Friend WithEvents DTPFechaDescargo As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
End Class
