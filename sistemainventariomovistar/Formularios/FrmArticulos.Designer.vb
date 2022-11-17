<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmArticulos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmArticulos))
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Lbldireccion = New System.Windows.Forms.Label()
        Me.TxtNserie = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RbCodigoA = New System.Windows.Forms.RadioButton()
        Me.Rbfecha = New System.Windows.Forms.RadioButton()
        Me.rbNombreA = New System.Windows.Forms.RadioButton()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.DgbArticulos = New System.Windows.Forms.DataGridView()
        Me.IdArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroSerie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNombreA = New System.Windows.Forms.TextBox()
        Me.lbcurp = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DTPFechacompra = New System.Windows.Forms.DateTimePicker()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2TxtNombreA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TxtNSerie = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TxtCodigo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TxtPrecio = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TxtDescripcion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2DTPFechaEntrega = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2BtnGuardar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnBorrar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BntEditar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnCancelar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnNuevo = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DgbArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(703, 562)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(73, 23)
        Me.BtnBuscar.TabIndex = 69
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(144, 559)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(533, 50)
        Me.TxtDescripcion.TabIndex = 68
        '
        'Lbldireccion
        '
        Me.Lbldireccion.AutoSize = True
        Me.Lbldireccion.Location = New System.Drawing.Point(49, 540)
        Me.Lbldireccion.Name = "Lbldireccion"
        Me.Lbldireccion.Size = New System.Drawing.Size(63, 13)
        Me.Lbldireccion.TabIndex = 67
        Me.Lbldireccion.Text = "Descripcion"
        '
        'TxtNserie
        '
        Me.TxtNserie.Location = New System.Drawing.Point(144, 524)
        Me.TxtNserie.Name = "TxtNserie"
        Me.TxtNserie.Size = New System.Drawing.Size(120, 20)
        Me.TxtNserie.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 527)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "N.serie"
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(57, 214)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(32, 20)
        Me.TxtId.TabIndex = 60
        Me.TxtId.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RbCodigoA)
        Me.Panel1.Controls.Add(Me.Rbfecha)
        Me.Panel1.Controls.Add(Me.rbNombreA)
        Me.Panel1.Controls.Add(Me.LblTotal)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtBuscar)
        Me.Panel1.Controls.Add(Me.DgbArticulos)
        Me.Panel1.Location = New System.Drawing.Point(51, 240)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(852, 258)
        Me.Panel1.TabIndex = 59
        '
        'RbCodigoA
        '
        Me.RbCodigoA.AutoSize = True
        Me.RbCodigoA.Location = New System.Drawing.Point(231, 8)
        Me.RbCodigoA.Name = "RbCodigoA"
        Me.RbCodigoA.Size = New System.Drawing.Size(110, 17)
        Me.RbCodigoA.TabIndex = 22
        Me.RbCodigoA.Text = "Codigo de articulo"
        Me.RbCodigoA.UseVisualStyleBackColor = True
        '
        'Rbfecha
        '
        Me.Rbfecha.AutoSize = True
        Me.Rbfecha.Location = New System.Drawing.Point(145, 10)
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
        Me.rbNombreA.Location = New System.Drawing.Point(17, 10)
        Me.rbNombreA.Name = "rbNombreA"
        Me.rbNombreA.Size = New System.Drawing.Size(115, 17)
        Me.rbNombreA.TabIndex = 20
        Me.rbNombreA.TabStop = True
        Me.rbNombreA.Text = "Nombre de Articulo"
        Me.rbNombreA.UseVisualStyleBackColor = True
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(127, 233)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(31, 13)
        Me.LblTotal.TabIndex = 19
        Me.LblTotal.Text = "Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Empleados Registrados"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(384, 7)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(516, 20)
        Me.TxtBuscar.TabIndex = 1
        '
        'DgbArticulos
        '
        Me.DgbArticulos.AllowUserToAddRows = False
        Me.DgbArticulos.AllowUserToDeleteRows = False
        Me.DgbArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgbArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdArticulo, Me.NombreA, Me.NumeroSerie, Me.CodigoA, Me.PrecioCompra, Me.FechaCompra, Me.EstadoArticulo, Me.Descripcion})
        Me.DgbArticulos.Location = New System.Drawing.Point(1, 43)
        Me.DgbArticulos.Name = "DgbArticulos"
        Me.DgbArticulos.ReadOnly = True
        Me.DgbArticulos.RowHeadersVisible = False
        Me.DgbArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgbArticulos.Size = New System.Drawing.Size(897, 187)
        Me.DgbArticulos.TabIndex = 0
        '
        'IdArticulo
        '
        Me.IdArticulo.DataPropertyName = "IdArticulo"
        Me.IdArticulo.HeaderText = "ID"
        Me.IdArticulo.Name = "IdArticulo"
        Me.IdArticulo.ReadOnly = True
        Me.IdArticulo.Visible = False
        '
        'NombreA
        '
        Me.NombreA.DataPropertyName = "NombreA"
        Me.NombreA.HeaderText = "NOMBRE ARTICULO"
        Me.NombreA.Name = "NombreA"
        Me.NombreA.ReadOnly = True
        Me.NombreA.Width = 180
        '
        'NumeroSerie
        '
        Me.NumeroSerie.DataPropertyName = "NumeroSerie"
        Me.NumeroSerie.HeaderText = "NUMERO DE SERIE"
        Me.NumeroSerie.Name = "NumeroSerie"
        Me.NumeroSerie.ReadOnly = True
        Me.NumeroSerie.Width = 150
        '
        'CodigoA
        '
        Me.CodigoA.DataPropertyName = "CodigoA"
        Me.CodigoA.HeaderText = "CODIGO"
        Me.CodigoA.Name = "CodigoA"
        Me.CodigoA.ReadOnly = True
        '
        'PrecioCompra
        '
        Me.PrecioCompra.DataPropertyName = "PrecioCompra"
        Me.PrecioCompra.HeaderText = "PRECIO DE COMPRA"
        Me.PrecioCompra.Name = "PrecioCompra"
        Me.PrecioCompra.ReadOnly = True
        Me.PrecioCompra.Width = 150
        '
        'FechaCompra
        '
        Me.FechaCompra.DataPropertyName = "FechaCompra"
        Me.FechaCompra.HeaderText = "FECHA DE COMPRA"
        Me.FechaCompra.Name = "FechaCompra"
        Me.FechaCompra.ReadOnly = True
        '
        'EstadoArticulo
        '
        Me.EstadoArticulo.DataPropertyName = "EstadoArticulo"
        Me.EstadoArticulo.HeaderText = "ESTADO "
        Me.EstadoArticulo.Name = "EstadoArticulo"
        Me.EstadoArticulo.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "DESCRIPCION"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 150
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(803, 562)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(73, 23)
        Me.BtnCancelar.TabIndex = 58
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Location = New System.Drawing.Point(803, 526)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(73, 23)
        Me.BtnBorrar.TabIndex = 57
        Me.BtnBorrar.Text = "Eliminar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(703, 526)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(73, 23)
        Me.BtnEditar.TabIndex = 56
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(803, 491)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(73, 23)
        Me.BtnGuardar.TabIndex = 55
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(703, 491)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(73, 23)
        Me.BtnNuevo.TabIndex = 54
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(325, 527)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(133, 20)
        Me.TxtCodigo.TabIndex = 51
        '
        'txtNombreA
        '
        Me.txtNombreA.Location = New System.Drawing.Point(144, 491)
        Me.txtNombreA.Name = "txtNombreA"
        Me.txtNombreA.Size = New System.Drawing.Size(314, 20)
        Me.txtNombreA.TabIndex = 50
        '
        'lbcurp
        '
        Me.lbcurp.AutoSize = True
        Me.lbcurp.Location = New System.Drawing.Point(279, 530)
        Me.lbcurp.Name = "lbcurp"
        Me.lbcurp.Size = New System.Drawing.Size(40, 13)
        Me.lbcurp.TabIndex = 47
        Me.lbcurp.Text = "Codigo"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(48, 514)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(85, 13)
        Me.lblnombre.TabIndex = 46
        Me.lblnombre.Text = "Nombre  Articulo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(474, 534)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Fecha de Compra"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(581, 491)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(96, 20)
        Me.TxtPrecio.TabIndex = 71
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(528, 494)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Precio"
        '
        'DTPFechacompra
        '
        Me.DTPFechacompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechacompra.Location = New System.Drawing.Point(581, 530)
        Me.DTPFechacompra.Name = "DTPFechacompra"
        Me.DTPFechacompra.Size = New System.Drawing.Size(96, 20)
        Me.DTPFechacompra.TabIndex = 74
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(958, 20)
        Me.Panel2.TabIndex = 75
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(417, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 24)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "Artículos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Guna2TxtNombreA
        '
        Me.Guna2TxtNombreA.Animated = True
        Me.Guna2TxtNombreA.BorderColor = System.Drawing.Color.Black
        Me.Guna2TxtNombreA.BorderRadius = 7
        Me.Guna2TxtNombreA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TxtNombreA.DefaultText = ""
        Me.Guna2TxtNombreA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TxtNombreA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TxtNombreA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtNombreA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtNombreA.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TxtNombreA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtNombreA.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.Guna2TxtNombreA.ForeColor = System.Drawing.Color.Black
        Me.Guna2TxtNombreA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtNombreA.Location = New System.Drawing.Point(51, 87)
        Me.Guna2TxtNombreA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtNombreA.Name = "Guna2TxtNombreA"
        Me.Guna2TxtNombreA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtNombreA.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtNombreA.PlaceholderText = "Nombre del Artículo"
        Me.Guna2TxtNombreA.SelectedText = ""
        Me.Guna2TxtNombreA.Size = New System.Drawing.Size(213, 36)
        Me.Guna2TxtNombreA.TabIndex = 137
        '
        'Guna2TxtNSerie
        '
        Me.Guna2TxtNSerie.Animated = True
        Me.Guna2TxtNSerie.BorderColor = System.Drawing.Color.Black
        Me.Guna2TxtNSerie.BorderRadius = 7
        Me.Guna2TxtNSerie.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TxtNSerie.DefaultText = ""
        Me.Guna2TxtNSerie.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TxtNSerie.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TxtNSerie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtNSerie.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtNSerie.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TxtNSerie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtNSerie.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.Guna2TxtNSerie.ForeColor = System.Drawing.Color.Black
        Me.Guna2TxtNSerie.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtNSerie.Location = New System.Drawing.Point(51, 132)
        Me.Guna2TxtNSerie.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtNSerie.Name = "Guna2TxtNSerie"
        Me.Guna2TxtNSerie.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtNSerie.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtNSerie.PlaceholderText = "Número de Serie"
        Me.Guna2TxtNSerie.SelectedText = ""
        Me.Guna2TxtNSerie.Size = New System.Drawing.Size(213, 36)
        Me.Guna2TxtNSerie.TabIndex = 138
        '
        'Guna2TxtCodigo
        '
        Me.Guna2TxtCodigo.Animated = True
        Me.Guna2TxtCodigo.BorderColor = System.Drawing.Color.Black
        Me.Guna2TxtCodigo.BorderRadius = 7
        Me.Guna2TxtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TxtCodigo.DefaultText = ""
        Me.Guna2TxtCodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TxtCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TxtCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtCodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtCodigo.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TxtCodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtCodigo.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.Guna2TxtCodigo.ForeColor = System.Drawing.Color.Black
        Me.Guna2TxtCodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtCodigo.Location = New System.Drawing.Point(296, 87)
        Me.Guna2TxtCodigo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtCodigo.Name = "Guna2TxtCodigo"
        Me.Guna2TxtCodigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtCodigo.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtCodigo.PlaceholderText = "Código"
        Me.Guna2TxtCodigo.SelectedText = ""
        Me.Guna2TxtCodigo.Size = New System.Drawing.Size(225, 36)
        Me.Guna2TxtCodigo.TabIndex = 139
        '
        'Guna2TxtPrecio
        '
        Me.Guna2TxtPrecio.Animated = True
        Me.Guna2TxtPrecio.BorderColor = System.Drawing.Color.Black
        Me.Guna2TxtPrecio.BorderRadius = 7
        Me.Guna2TxtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TxtPrecio.DefaultText = ""
        Me.Guna2TxtPrecio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TxtPrecio.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TxtPrecio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtPrecio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtPrecio.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TxtPrecio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtPrecio.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.Guna2TxtPrecio.ForeColor = System.Drawing.Color.Black
        Me.Guna2TxtPrecio.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtPrecio.Location = New System.Drawing.Point(296, 132)
        Me.Guna2TxtPrecio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtPrecio.Name = "Guna2TxtPrecio"
        Me.Guna2TxtPrecio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtPrecio.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtPrecio.PlaceholderText = "Precio"
        Me.Guna2TxtPrecio.SelectedText = ""
        Me.Guna2TxtPrecio.Size = New System.Drawing.Size(98, 36)
        Me.Guna2TxtPrecio.TabIndex = 140
        '
        'Guna2TxtDescripcion
        '
        Me.Guna2TxtDescripcion.Animated = True
        Me.Guna2TxtDescripcion.BorderColor = System.Drawing.Color.Black
        Me.Guna2TxtDescripcion.BorderRadius = 7
        Me.Guna2TxtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TxtDescripcion.DefaultText = ""
        Me.Guna2TxtDescripcion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TxtDescripcion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TxtDescripcion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtDescripcion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtDescripcion.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TxtDescripcion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtDescripcion.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.Guna2TxtDescripcion.ForeColor = System.Drawing.Color.Black
        Me.Guna2TxtDescripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtDescripcion.Location = New System.Drawing.Point(51, 176)
        Me.Guna2TxtDescripcion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtDescripcion.Name = "Guna2TxtDescripcion"
        Me.Guna2TxtDescripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtDescripcion.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtDescripcion.PlaceholderText = "Descripción"
        Me.Guna2TxtDescripcion.SelectedText = ""
        Me.Guna2TxtDescripcion.Size = New System.Drawing.Size(470, 36)
        Me.Guna2TxtDescripcion.TabIndex = 141
        '
        'Guna2DTPFechaEntrega
        '
        Me.Guna2DTPFechaEntrega.Animated = True
        Me.Guna2DTPFechaEntrega.BorderRadius = 7
        Me.Guna2DTPFechaEntrega.BorderThickness = 1
        Me.Guna2DTPFechaEntrega.Checked = True
        Me.Guna2DTPFechaEntrega.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2DTPFechaEntrega.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2DTPFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Guna2DTPFechaEntrega.Location = New System.Drawing.Point(400, 132)
        Me.Guna2DTPFechaEntrega.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DTPFechaEntrega.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DTPFechaEntrega.Name = "Guna2DTPFechaEntrega"
        Me.Guna2DTPFechaEntrega.Size = New System.Drawing.Size(121, 36)
        Me.Guna2DTPFechaEntrega.TabIndex = 142
        Me.Guna2DTPFechaEntrega.Value = New Date(2022, 11, 13, 22, 42, 37, 926)
        '
        'Guna2BtnGuardar
        '
        Me.Guna2BtnGuardar.Animated = True
        Me.Guna2BtnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.Guna2BtnGuardar.BorderRadius = 7
        Me.Guna2BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2BtnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2BtnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2BtnGuardar.FillColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2BtnGuardar.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        Me.Guna2BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.Guna2BtnGuardar.Location = New System.Drawing.Point(581, 137)
        Me.Guna2BtnGuardar.Name = "Guna2BtnGuardar"
        Me.Guna2BtnGuardar.Size = New System.Drawing.Size(141, 35)
        Me.Guna2BtnGuardar.TabIndex = 143
        Me.Guna2BtnGuardar.Text = "Guardar"
        '
        'Guna2BtnBorrar
        '
        Me.Guna2BtnBorrar.Animated = True
        Me.Guna2BtnBorrar.BackColor = System.Drawing.Color.Transparent
        Me.Guna2BtnBorrar.BorderRadius = 7
        Me.Guna2BtnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2BtnBorrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnBorrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnBorrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2BtnBorrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2BtnBorrar.FillColor = System.Drawing.Color.Brown
        Me.Guna2BtnBorrar.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        Me.Guna2BtnBorrar.ForeColor = System.Drawing.Color.White
        Me.Guna2BtnBorrar.Location = New System.Drawing.Point(581, 177)
        Me.Guna2BtnBorrar.Name = "Guna2BtnBorrar"
        Me.Guna2BtnBorrar.Size = New System.Drawing.Size(288, 35)
        Me.Guna2BtnBorrar.TabIndex = 145
        Me.Guna2BtnBorrar.Text = "Eliminar"
        '
        'Guna2BntEditar
        '
        Me.Guna2BntEditar.Animated = True
        Me.Guna2BntEditar.BackColor = System.Drawing.Color.Transparent
        Me.Guna2BntEditar.BorderRadius = 7
        Me.Guna2BntEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2BntEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BntEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BntEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2BntEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2BntEditar.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Guna2BntEditar.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        Me.Guna2BntEditar.ForeColor = System.Drawing.Color.White
        Me.Guna2BntEditar.Location = New System.Drawing.Point(728, 137)
        Me.Guna2BntEditar.Name = "Guna2BntEditar"
        Me.Guna2BntEditar.Size = New System.Drawing.Size(141, 35)
        Me.Guna2BntEditar.TabIndex = 144
        Me.Guna2BntEditar.Text = "Editar"
        '
        'Guna2BtnCancelar
        '
        Me.Guna2BtnCancelar.Animated = True
        Me.Guna2BtnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.Guna2BtnCancelar.BackgroundImage = CType(resources.GetObject("Guna2BtnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.Guna2BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2BtnCancelar.BorderRadius = 7
        Me.Guna2BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2BtnCancelar.DisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2BtnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2BtnCancelar.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2BtnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2BtnCancelar.DisabledState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.Guna2BtnCancelar.FillColor = System.Drawing.Color.Transparent
        Me.Guna2BtnCancelar.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        Me.Guna2BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.Guna2BtnCancelar.ImageSize = New System.Drawing.Size(45, 45)
        Me.Guna2BtnCancelar.Location = New System.Drawing.Point(736, 84)
        Me.Guna2BtnCancelar.Name = "Guna2BtnCancelar"
        Me.Guna2BtnCancelar.Size = New System.Drawing.Size(45, 45)
        Me.Guna2BtnCancelar.TabIndex = 147
        '
        'Guna2BtnNuevo
        '
        Me.Guna2BtnNuevo.Animated = True
        Me.Guna2BtnNuevo.BackColor = System.Drawing.Color.Transparent
        Me.Guna2BtnNuevo.BackgroundImage = CType(resources.GetObject("Guna2BtnNuevo.BackgroundImage"), System.Drawing.Image)
        Me.Guna2BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2BtnNuevo.BorderRadius = 7
        Me.Guna2BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2BtnNuevo.DisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2BtnNuevo.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2BtnNuevo.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2BtnNuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2BtnNuevo.DisabledState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.Guna2BtnNuevo.FillColor = System.Drawing.Color.Transparent
        Me.Guna2BtnNuevo.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        Me.Guna2BtnNuevo.ForeColor = System.Drawing.Color.White
        Me.Guna2BtnNuevo.ImageSize = New System.Drawing.Size(54, 54)
        Me.Guna2BtnNuevo.Location = New System.Drawing.Point(657, 78)
        Me.Guna2BtnNuevo.Name = "Guna2BtnNuevo"
        Me.Guna2BtnNuevo.Size = New System.Drawing.Size(54, 54)
        Me.Guna2BtnNuevo.TabIndex = 146
        '
        'FrmArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(958, 628)
        Me.Controls.Add(Me.Guna2BtnCancelar)
        Me.Controls.Add(Me.Guna2BtnNuevo)
        Me.Controls.Add(Me.Guna2BtnBorrar)
        Me.Controls.Add(Me.Guna2BntEditar)
        Me.Controls.Add(Me.Guna2BtnGuardar)
        Me.Controls.Add(Me.Guna2DTPFechaEntrega)
        Me.Controls.Add(Me.Guna2TxtDescripcion)
        Me.Controls.Add(Me.Guna2TxtPrecio)
        Me.Controls.Add(Me.Guna2TxtCodigo)
        Me.Controls.Add(Me.Guna2TxtNSerie)
        Me.Controls.Add(Me.Guna2TxtNombreA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DTPFechacompra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtPrecio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.Lbldireccion)
        Me.Controls.Add(Me.TxtNserie)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.txtNombreA)
        Me.Controls.Add(Me.lbcurp)
        Me.Controls.Add(Me.lblnombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario de articulos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgbArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Lbldireccion As Label
    Friend WithEvents TxtNserie As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RbCodigoA As RadioButton
    Friend WithEvents Rbfecha As RadioButton
    Friend WithEvents rbNombreA As RadioButton
    Friend WithEvents LblTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents DgbArticulos As DataGridView
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents txtNombreA As TextBox
    Friend WithEvents lbcurp As Label
    Friend WithEvents lblnombre As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DTPFechacompra As DateTimePicker
    Friend WithEvents IdArticulo As DataGridViewTextBoxColumn
    Friend WithEvents NombreA As DataGridViewTextBoxColumn
    Friend WithEvents NumeroSerie As DataGridViewTextBoxColumn
    Friend WithEvents CodigoA As DataGridViewTextBoxColumn
    Friend WithEvents PrecioCompra As DataGridViewTextBoxColumn
    Friend WithEvents FechaCompra As DataGridViewTextBoxColumn
    Friend WithEvents EstadoArticulo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2TxtNombreA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TxtDescripcion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TxtPrecio As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TxtCodigo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TxtNSerie As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2DTPFechaEntrega As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2BtnGuardar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BtnBorrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BntEditar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BtnCancelar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BtnNuevo As Guna.UI2.WinForms.Guna2Button
End Class
