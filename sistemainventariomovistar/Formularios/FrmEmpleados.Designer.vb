<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEmpleados
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
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RbDepartamento = New System.Windows.Forms.RadioButton()
        Me.RbCurp = New System.Windows.Forms.RadioButton()
        Me.rbNombreEmpleado = New System.Windows.Forms.RadioButton()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.DgbEmpleados = New System.Windows.Forms.DataGridView()
        Me.IdEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Curp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.cboGenero = New System.Windows.Forms.ComboBox()
        Me.cboDepartamento = New System.Windows.Forms.ComboBox()
        Me.TxtCurp = New System.Windows.Forms.TextBox()
        Me.txtNombrecompleto = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lbltipousuario = New System.Windows.Forms.Label()
        Me.lbcurp = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CboPuesto = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Lbldireccion = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnDepartamento = New System.Windows.Forms.Button()
        Me.BtnPuesto = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DgbEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(7, 3)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(32, 20)
        Me.TxtId.TabIndex = 34
        Me.TxtId.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RbDepartamento)
        Me.Panel1.Controls.Add(Me.RbCurp)
        Me.Panel1.Controls.Add(Me.rbNombreEmpleado)
        Me.Panel1.Controls.Add(Me.LblTotal)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtBuscar)
        Me.Panel1.Controls.Add(Me.DgbEmpleados)
        Me.Panel1.Location = New System.Drawing.Point(12, 214)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(903, 289)
        Me.Panel1.TabIndex = 33
        '
        'RbDepartamento
        '
        Me.RbDepartamento.AutoSize = True
        Me.RbDepartamento.Location = New System.Drawing.Point(183, 42)
        Me.RbDepartamento.Name = "RbDepartamento"
        Me.RbDepartamento.Size = New System.Drawing.Size(92, 17)
        Me.RbDepartamento.TabIndex = 22
        Me.RbDepartamento.Text = "Departamento"
        Me.RbDepartamento.UseVisualStyleBackColor = True
        '
        'RbCurp
        '
        Me.RbCurp.AutoSize = True
        Me.RbCurp.Location = New System.Drawing.Point(130, 42)
        Me.RbCurp.Name = "RbCurp"
        Me.RbCurp.Size = New System.Drawing.Size(47, 17)
        Me.RbCurp.TabIndex = 21
        Me.RbCurp.Text = "Curp"
        Me.RbCurp.UseVisualStyleBackColor = True
        '
        'rbNombreEmpleado
        '
        Me.rbNombreEmpleado.AutoSize = True
        Me.rbNombreEmpleado.Checked = True
        Me.rbNombreEmpleado.Location = New System.Drawing.Point(17, 42)
        Me.rbNombreEmpleado.Name = "rbNombreEmpleado"
        Me.rbNombreEmpleado.Size = New System.Drawing.Size(106, 17)
        Me.rbNombreEmpleado.TabIndex = 20
        Me.rbNombreEmpleado.TabStop = True
        Me.rbNombreEmpleado.Text = "NombreCompleto"
        Me.rbNombreEmpleado.UseVisualStyleBackColor = True
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
        Me.TxtBuscar.Location = New System.Drawing.Point(503, 39)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(397, 20)
        Me.TxtBuscar.TabIndex = 1
        '
        'DgbEmpleados
        '
        Me.DgbEmpleados.AllowUserToAddRows = False
        Me.DgbEmpleados.AllowUserToDeleteRows = False
        Me.DgbEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgbEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEmpleado, Me.Nombre, Me.Curp, Me.Genero, Me.Telefono, Me.Correo, Me.Direccion, Me.NombreP, Me.NombreD})
        Me.DgbEmpleados.Location = New System.Drawing.Point(1, 75)
        Me.DgbEmpleados.Name = "DgbEmpleados"
        Me.DgbEmpleados.ReadOnly = True
        Me.DgbEmpleados.RowHeadersVisible = False
        Me.DgbEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgbEmpleados.Size = New System.Drawing.Size(897, 187)
        Me.DgbEmpleados.TabIndex = 0
        '
        'IdEmpleado
        '
        Me.IdEmpleado.DataPropertyName = "IdEmpleado"
        Me.IdEmpleado.HeaderText = "ID"
        Me.IdEmpleado.Name = "IdEmpleado"
        Me.IdEmpleado.ReadOnly = True
        Me.IdEmpleado.Visible = False
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "NOMBRE COMPLETO"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 180
        '
        'Curp
        '
        Me.Curp.DataPropertyName = "Curp"
        Me.Curp.HeaderText = "CURP"
        Me.Curp.Name = "Curp"
        Me.Curp.ReadOnly = True
        '
        'Genero
        '
        Me.Genero.DataPropertyName = "Genero"
        Me.Genero.HeaderText = "GENERO"
        Me.Genero.Name = "Genero"
        Me.Genero.ReadOnly = True
        '
        'Telefono
        '
        Me.Telefono.DataPropertyName = "Telefono"
        Me.Telefono.HeaderText = "TELEFONO"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        Me.Telefono.Width = 180
        '
        'Correo
        '
        Me.Correo.DataPropertyName = "Correo"
        Me.Correo.HeaderText = "CORREO"
        Me.Correo.Name = "Correo"
        Me.Correo.ReadOnly = True
        '
        'Direccion
        '
        Me.Direccion.DataPropertyName = "Direccion"
        Me.Direccion.HeaderText = "DIRECCION"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        '
        'NombreP
        '
        Me.NombreP.DataPropertyName = "NombreP"
        Me.NombreP.HeaderText = "PUESTO"
        Me.NombreP.Name = "NombreP"
        Me.NombreP.ReadOnly = True
        '
        'NombreD
        '
        Me.NombreD.DataPropertyName = "NombreD"
        Me.NombreD.HeaderText = "DEPARTAMENTO"
        Me.NombreD.Name = "NombreD"
        Me.NombreD.ReadOnly = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(830, 138)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(80, 32)
        Me.BtnCancelar.TabIndex = 32
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Location = New System.Drawing.Point(830, 92)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(80, 32)
        Me.BtnBorrar.TabIndex = 31
        Me.BtnBorrar.Text = "Eliminar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(730, 92)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(80, 32)
        Me.BtnEditar.TabIndex = 30
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(830, 43)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(80, 32)
        Me.BtnGuardar.TabIndex = 29
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(730, 43)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(80, 32)
        Me.BtnNuevo.TabIndex = 28
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'cboGenero
        '
        Me.cboGenero.FormattingEnabled = True
        Me.cboGenero.Items.AddRange(New Object() {"MASCULINO" & Global.Microsoft.VisualBasic.ChrW(9), "FEMENINO"})
        Me.cboGenero.Location = New System.Drawing.Point(100, 82)
        Me.cboGenero.Name = "cboGenero"
        Me.cboGenero.Size = New System.Drawing.Size(121, 21)
        Me.cboGenero.TabIndex = 27
        '
        'cboDepartamento
        '
        Me.cboDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDepartamento.FormattingEnabled = True
        Me.cboDepartamento.Items.AddRange(New Object() {"Administrador", "Invitado"})
        Me.cboDepartamento.Location = New System.Drawing.Point(522, 109)
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.Size = New System.Drawing.Size(151, 21)
        Me.cboDepartamento.TabIndex = 26
        '
        'TxtCurp
        '
        Me.TxtCurp.Location = New System.Drawing.Point(522, 43)
        Me.TxtCurp.Name = "TxtCurp"
        Me.TxtCurp.Size = New System.Drawing.Size(202, 20)
        Me.TxtCurp.TabIndex = 24
        '
        'txtNombrecompleto
        '
        Me.txtNombrecompleto.Location = New System.Drawing.Point(100, 43)
        Me.txtNombrecompleto.Name = "txtNombrecompleto"
        Me.txtNombrecompleto.Size = New System.Drawing.Size(314, 20)
        Me.txtNombrecompleto.TabIndex = 23
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(427, 112)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(74, 13)
        Me.lblEstado.TabIndex = 22
        Me.lblEstado.Text = "Departamento"
        '
        'lbltipousuario
        '
        Me.lbltipousuario.AutoSize = True
        Me.lbltipousuario.Location = New System.Drawing.Point(4, 82)
        Me.lbltipousuario.Name = "lbltipousuario"
        Me.lbltipousuario.Size = New System.Drawing.Size(40, 13)
        Me.lbltipousuario.TabIndex = 21
        Me.lbltipousuario.Text = "genero"
        '
        'lbcurp
        '
        Me.lbcurp.AutoSize = True
        Me.lbcurp.Location = New System.Drawing.Point(473, 43)
        Me.lbcurp.Name = "lbcurp"
        Me.lbcurp.Size = New System.Drawing.Size(28, 13)
        Me.lbcurp.TabIndex = 19
        Me.lbcurp.Text = "curp"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(4, 43)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(90, 13)
        Me.lblnombre.TabIndex = 18
        Me.lblnombre.Text = "Nombre completo"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(293, 83)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(121, 20)
        Me.TxtTelefono.TabIndex = 38
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(522, 79)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(202, 20)
        Me.TxtCorreo.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(461, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "correo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(242, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "telefono"
        '
        'CboPuesto
        '
        Me.CboPuesto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboPuesto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboPuesto.FormattingEnabled = True
        Me.CboPuesto.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.CboPuesto.Location = New System.Drawing.Point(522, 145)
        Me.CboPuesto.Name = "CboPuesto"
        Me.CboPuesto.Size = New System.Drawing.Size(151, 21)
        Me.CboPuesto.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(461, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Puesto"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(100, 111)
        Me.TxtDireccion.Multiline = True
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(314, 59)
        Me.TxtDireccion.TabIndex = 42
        '
        'Lbldireccion
        '
        Me.Lbldireccion.AutoSize = True
        Me.Lbldireccion.Location = New System.Drawing.Point(4, 111)
        Me.Lbldireccion.Name = "Lbldireccion"
        Me.Lbldireccion.Size = New System.Drawing.Size(52, 13)
        Me.Lbldireccion.TabIndex = 41
        Me.Lbldireccion.Text = "Direccion"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(730, 138)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(80, 32)
        Me.BtnBuscar.TabIndex = 43
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnDepartamento
        '
        Me.BtnDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDepartamento.Location = New System.Drawing.Point(679, 109)
        Me.BtnDepartamento.Name = "BtnDepartamento"
        Me.BtnDepartamento.Size = New System.Drawing.Size(45, 21)
        Me.BtnDepartamento.TabIndex = 44
        Me.BtnDepartamento.Text = "..."
        Me.BtnDepartamento.UseVisualStyleBackColor = True
        '
        'BtnPuesto
        '
        Me.BtnPuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPuesto.Location = New System.Drawing.Point(679, 149)
        Me.BtnPuesto.Name = "BtnPuesto"
        Me.BtnPuesto.Size = New System.Drawing.Size(45, 21)
        Me.BtnPuesto.TabIndex = 45
        Me.BtnPuesto.Text = "..."
        Me.BtnPuesto.UseVisualStyleBackColor = True
        '
        'FrmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 501)
        Me.Controls.Add(Me.BtnPuesto)
        Me.Controls.Add(Me.BtnDepartamento)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.Lbldireccion)
        Me.Controls.Add(Me.CboPuesto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.TxtCorreo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.cboGenero)
        Me.Controls.Add(Me.cboDepartamento)
        Me.Controls.Add(Me.TxtCurp)
        Me.Controls.Add(Me.txtNombrecompleto)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.lbltipousuario)
        Me.Controls.Add(Me.lbcurp)
        Me.Controls.Add(Me.lblnombre)
        Me.Name = "FrmEmpleados"
        Me.Text = "Registro de Empleados"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgbEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtId As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents DgbEmpleados As DataGridView
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents cboGenero As ComboBox
    Friend WithEvents cboDepartamento As ComboBox
    Friend WithEvents TxtCurp As TextBox
    Friend WithEvents txtNombrecompleto As TextBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents lbltipousuario As Label
    Friend WithEvents lbcurp As Label
    Friend WithEvents lblnombre As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CboPuesto As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Lbldireccion As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents IdEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Curp As DataGridViewTextBoxColumn
    Friend WithEvents Genero As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Correo As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents NombreP As DataGridViewTextBoxColumn
    Friend WithEvents NombreD As DataGridViewTextBoxColumn
    Friend WithEvents RbDepartamento As RadioButton
    Friend WithEvents RbCurp As RadioButton
    Friend WithEvents rbNombreEmpleado As RadioButton
    Friend WithEvents BtnDepartamento As Button
    Friend WithEvents BtnPuesto As Button
End Class
