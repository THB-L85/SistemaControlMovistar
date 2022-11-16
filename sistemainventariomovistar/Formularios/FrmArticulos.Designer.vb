<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArticulos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.DgbArticulos = New System.Windows.Forms.DataGridView()
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
        Me.IdArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroSerie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DgbArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(679, 148)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(73, 23)
        Me.BtnBuscar.TabIndex = 69
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(120, 121)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(533, 50)
        Me.TxtDescripcion.TabIndex = 68
        '
        'Lbldireccion
        '
        Me.Lbldireccion.AutoSize = True
        Me.Lbldireccion.Location = New System.Drawing.Point(24, 121)
        Me.Lbldireccion.Name = "Lbldireccion"
        Me.Lbldireccion.Size = New System.Drawing.Size(63, 13)
        Me.Lbldireccion.TabIndex = 67
        Me.Lbldireccion.Text = "Descripcion"
        '
        'TxtNserie
        '
        Me.TxtNserie.Location = New System.Drawing.Point(120, 86)
        Me.TxtNserie.Name = "TxtNserie"
        Me.TxtNserie.Size = New System.Drawing.Size(120, 20)
        Me.TxtNserie.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "N.serie"
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(27, 13)
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
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtBuscar)
        Me.Panel1.Controls.Add(Me.DgbArticulos)
        Me.Panel1.Location = New System.Drawing.Point(27, 187)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(903, 289)
        Me.Panel1.TabIndex = 59
        '
        'RbCodigoA
        '
        Me.RbCodigoA.AutoSize = True
        Me.RbCodigoA.Location = New System.Drawing.Point(231, 40)
        Me.RbCodigoA.Name = "RbCodigoA"
        Me.RbCodigoA.Size = New System.Drawing.Size(110, 17)
        Me.RbCodigoA.TabIndex = 22
        Me.RbCodigoA.Text = "Codigo de articulo"
        Me.RbCodigoA.UseVisualStyleBackColor = True
        '
        'Rbfecha
        '
        Me.Rbfecha.AutoSize = True
        Me.Rbfecha.Location = New System.Drawing.Point(145, 42)
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
        Me.rbNombreA.Size = New System.Drawing.Size(115, 17)
        Me.rbNombreA.TabIndex = 20
        Me.rbNombreA.TabStop = True
        Me.rbNombreA.Text = "Nombre de Articulo"
        Me.rbNombreA.UseVisualStyleBackColor = True
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(127, 265)
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
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Empleados Registrados"
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
        Me.TxtBuscar.Location = New System.Drawing.Point(384, 39)
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
        Me.DgbArticulos.Location = New System.Drawing.Point(1, 75)
        Me.DgbArticulos.Name = "DgbArticulos"
        Me.DgbArticulos.ReadOnly = True
        Me.DgbArticulos.RowHeadersVisible = False
        Me.DgbArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgbArticulos.Size = New System.Drawing.Size(897, 187)
        Me.DgbArticulos.TabIndex = 0
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(779, 148)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(73, 23)
        Me.BtnCancelar.TabIndex = 58
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Location = New System.Drawing.Point(779, 102)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(73, 23)
        Me.BtnBorrar.TabIndex = 57
        Me.BtnBorrar.Text = "Eliminar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(679, 102)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(73, 23)
        Me.BtnEditar.TabIndex = 56
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(779, 53)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(73, 23)
        Me.BtnGuardar.TabIndex = 55
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(679, 53)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(73, 23)
        Me.BtnNuevo.TabIndex = 54
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(301, 89)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(133, 20)
        Me.TxtCodigo.TabIndex = 51
        '
        'txtNombreA
        '
        Me.txtNombreA.Location = New System.Drawing.Point(120, 53)
        Me.txtNombreA.Name = "txtNombreA"
        Me.txtNombreA.Size = New System.Drawing.Size(314, 20)
        Me.txtNombreA.TabIndex = 50
        '
        'lbcurp
        '
        Me.lbcurp.AutoSize = True
        Me.lbcurp.Location = New System.Drawing.Point(255, 92)
        Me.lbcurp.Name = "lbcurp"
        Me.lbcurp.Size = New System.Drawing.Size(40, 13)
        Me.lbcurp.TabIndex = 47
        Me.lbcurp.Text = "Codigo"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(24, 53)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(85, 13)
        Me.lblnombre.TabIndex = 46
        Me.lblnombre.Text = "Nombre  Articulo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(450, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Fecha de Compra"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(557, 53)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(96, 20)
        Me.TxtPrecio.TabIndex = 71
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(504, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Precio"
        '
        'DTPFechacompra
        '
        Me.DTPFechacompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechacompra.Location = New System.Drawing.Point(557, 92)
        Me.DTPFechacompra.Name = "DTPFechacompra"
        Me.DTPFechacompra.Size = New System.Drawing.Size(96, 20)
        Me.DTPFechacompra.TabIndex = 74
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
        'FrmArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 527)
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
        Me.Name = "FrmArticulos"
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
    Friend WithEvents Label1 As Label
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
End Class
