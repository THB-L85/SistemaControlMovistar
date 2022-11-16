<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistroAltasPortabilidades
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
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.DgbUsuarios = New System.Windows.Forms.DataGridView()
        Me.IdUsuarios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPOUSUARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.cboestado = New System.Windows.Forms.ComboBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtNombrecompleto = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblcontraseña = New System.Windows.Forms.Label()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DgbUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(12, 70)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(75, 20)
        Me.TxtId.TabIndex = 34
        Me.TxtId.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LblTotal)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtBuscar)
        Me.Panel1.Controls.Add(Me.DgbUsuarios)
        Me.Panel1.Location = New System.Drawing.Point(466, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(460, 235)
        Me.Panel1.TabIndex = 33
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(143, 197)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(31, 13)
        Me.LblTotal.TabIndex = 19
        Me.LblTotal.Text = "Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Portabilidades realizadas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Buscar"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(60, 28)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(397, 20)
        Me.TxtBuscar.TabIndex = 1
        '
        'DgbUsuarios
        '
        Me.DgbUsuarios.AllowUserToAddRows = False
        Me.DgbUsuarios.AllowUserToDeleteRows = False
        Me.DgbUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgbUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdUsuarios, Me.NombreCompleto, Me.Usuario, Me.Password, Me.TIPOUSUARIO, Me.ESTADO})
        Me.DgbUsuarios.Location = New System.Drawing.Point(17, 54)
        Me.DgbUsuarios.Name = "DgbUsuarios"
        Me.DgbUsuarios.ReadOnly = True
        Me.DgbUsuarios.RowHeadersVisible = False
        Me.DgbUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgbUsuarios.Size = New System.Drawing.Size(440, 121)
        Me.DgbUsuarios.TabIndex = 0
        '
        'IdUsuarios
        '
        Me.IdUsuarios.DataPropertyName = "IdUsuarios"
        Me.IdUsuarios.HeaderText = "ID"
        Me.IdUsuarios.Name = "IdUsuarios"
        Me.IdUsuarios.ReadOnly = True
        Me.IdUsuarios.Visible = False
        '
        'NombreCompleto
        '
        Me.NombreCompleto.DataPropertyName = "NombreCompleto"
        Me.NombreCompleto.HeaderText = "NOMBRE COMPLETO"
        Me.NombreCompleto.Name = "NombreCompleto"
        Me.NombreCompleto.ReadOnly = True
        Me.NombreCompleto.Width = 180
        '
        'Usuario
        '
        Me.Usuario.DataPropertyName = "Usuario"
        Me.Usuario.HeaderText = "USUARIO"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        '
        'Password
        '
        Me.Password.DataPropertyName = "Password"
        Me.Password.HeaderText = "CONTRASEÑA"
        Me.Password.Name = "Password"
        Me.Password.ReadOnly = True
        '
        'TIPOUSUARIO
        '
        Me.TIPOUSUARIO.DataPropertyName = "TipoUsuario"
        Me.TIPOUSUARIO.HeaderText = "TIPO  DE USUARIO"
        Me.TIPOUSUARIO.Name = "TIPOUSUARIO"
        Me.TIPOUSUARIO.ReadOnly = True
        Me.TIPOUSUARIO.Width = 180
        '
        'ESTADO
        '
        Me.ESTADO.DataPropertyName = "Estado"
        Me.ESTADO.HeaderText = "ESTADO"
        Me.ESTADO.Name = "ESTADO"
        Me.ESTADO.ReadOnly = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(378, 228)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 32
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Location = New System.Drawing.Point(297, 228)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBorrar.TabIndex = 31
        Me.BtnBorrar.Text = "Eliminar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(204, 228)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditar.TabIndex = 30
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(105, 228)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 29
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(12, 228)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevo.TabIndex = 28
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'cboestado
        '
        Me.cboestado.FormattingEnabled = True
        Me.cboestado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.cboestado.Location = New System.Drawing.Point(321, 151)
        Me.cboestado.Name = "cboestado"
        Me.cboestado.Size = New System.Drawing.Size(121, 21)
        Me.cboestado.TabIndex = 27
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(107, 151)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(121, 20)
        Me.txtUsuario.TabIndex = 24
        '
        'txtNombrecompleto
        '
        Me.txtNombrecompleto.Location = New System.Drawing.Point(107, 101)
        Me.txtNombrecompleto.Name = "txtNombrecompleto"
        Me.txtNombrecompleto.Size = New System.Drawing.Size(338, 20)
        Me.txtNombrecompleto.TabIndex = 23
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(270, 151)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(40, 13)
        Me.lblEstado.TabIndex = 22
        Me.lblEstado.Text = "Estado"
        '
        'lblcontraseña
        '
        Me.lblcontraseña.AutoSize = True
        Me.lblcontraseña.Location = New System.Drawing.Point(252, 151)
        Me.lblcontraseña.Name = "lblcontraseña"
        Me.lblcontraseña.Size = New System.Drawing.Size(0, 13)
        Me.lblcontraseña.TabIndex = 20
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.Location = New System.Drawing.Point(11, 158)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(81, 13)
        Me.lblusuario.TabIndex = 19
        Me.lblusuario.Text = "numero a portar"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(11, 102)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(89, 13)
        Me.lblnombre.TabIndex = 18
        Me.lblnombre.Text = "Nombre Promotor"
        '
        'FrmRegistroAltasPortabilidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 576)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.cboestado)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtNombrecompleto)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.lblcontraseña)
        Me.Controls.Add(Me.lblusuario)
        Me.Controls.Add(Me.lblnombre)
        Me.Name = "FrmRegistroAltasPortabilidades"
        Me.Text = "FrmRegistroAltasPortabilidades"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgbUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtId As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents DgbUsuarios As DataGridView
    Friend WithEvents IdUsuarios As DataGridViewTextBoxColumn
    Friend WithEvents NombreCompleto As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents Password As DataGridViewTextBoxColumn
    Friend WithEvents TIPOUSUARIO As DataGridViewTextBoxColumn
    Friend WithEvents ESTADO As DataGridViewTextBoxColumn
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents cboestado As ComboBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtNombrecompleto As TextBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblcontraseña As Label
    Friend WithEvents lblusuario As Label
    Friend WithEvents lblnombre As Label
End Class
