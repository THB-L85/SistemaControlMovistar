<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPuestosTrabajo
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.DgbPuestos = New System.Windows.Forms.DataGridView()
        Me.IdPuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.TxtDescripcionP = New System.Windows.Forms.TextBox()
        Me.TxtNombreP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DgbPuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LblTotal)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TxtBuscar)
        Me.Panel1.Controls.Add(Me.DgbPuestos)
        Me.Panel1.Location = New System.Drawing.Point(3, 214)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(473, 235)
        Me.Panel1.TabIndex = 34
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(128, 197)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(31, 13)
        Me.LblTotal.TabIndex = 19
        Me.LblTotal.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Usuarios Registrados"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Buscar"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(60, 28)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(397, 20)
        Me.TxtBuscar.TabIndex = 1
        '
        'DgbPuestos
        '
        Me.DgbPuestos.AllowUserToAddRows = False
        Me.DgbPuestos.AllowUserToDeleteRows = False
        Me.DgbPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgbPuestos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPuesto, Me.NombreP, Me.DescripcionP})
        Me.DgbPuestos.Location = New System.Drawing.Point(17, 54)
        Me.DgbPuestos.Name = "DgbPuestos"
        Me.DgbPuestos.ReadOnly = True
        Me.DgbPuestos.RowHeadersVisible = False
        Me.DgbPuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgbPuestos.Size = New System.Drawing.Size(440, 121)
        Me.DgbPuestos.TabIndex = 0
        '
        'IdPuesto
        '
        Me.IdPuesto.DataPropertyName = "IdPuesto"
        Me.IdPuesto.HeaderText = "ID"
        Me.IdPuesto.Name = "IdPuesto"
        Me.IdPuesto.ReadOnly = True
        Me.IdPuesto.Visible = False
        Me.IdPuesto.Width = 50
        '
        'NombreP
        '
        Me.NombreP.DataPropertyName = "NombreP"
        Me.NombreP.HeaderText = "PUESTO DE TRABAJO"
        Me.NombreP.Name = "NombreP"
        Me.NombreP.ReadOnly = True
        Me.NombreP.Width = 200
        '
        'DescripcionP
        '
        Me.DescripcionP.DataPropertyName = "DescripcionP"
        Me.DescripcionP.HeaderText = "DESCRIPCION"
        Me.DescripcionP.Name = "DescripcionP"
        Me.DescripcionP.ReadOnly = True
        Me.DescripcionP.Width = 250
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(308, 176)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 33
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(401, 176)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 32
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Location = New System.Drawing.Point(401, 108)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBorrar.TabIndex = 31
        Me.BtnBorrar.Text = "Eliminar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(308, 108)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditar.TabIndex = 30
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(401, 44)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 29
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(308, 44)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevo.TabIndex = 28
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(3, 12)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 20)
        Me.TxtId.TabIndex = 27
        Me.TxtId.Visible = False
        '
        'TxtDescripcionP
        '
        Me.TxtDescripcionP.Location = New System.Drawing.Point(101, 106)
        Me.TxtDescripcionP.Multiline = True
        Me.TxtDescripcionP.Name = "TxtDescripcionP"
        Me.TxtDescripcionP.Size = New System.Drawing.Size(175, 91)
        Me.TxtDescripcionP.TabIndex = 26
        '
        'TxtNombreP
        '
        Me.TxtNombreP.Location = New System.Drawing.Point(101, 44)
        Me.TxtNombreP.Name = "TxtNombreP"
        Me.TxtNombreP.Size = New System.Drawing.Size(175, 20)
        Me.TxtNombreP.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Descripcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Puesto"
        '
        'frmPuestosTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 453)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.TxtDescripcionP)
        Me.Controls.Add(Me.TxtNombreP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPuestosTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de puesto de trabajo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgbPuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents DgbPuestos As DataGridView
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents TxtId As TextBox
    Friend WithEvents TxtDescripcionP As TextBox
    Friend WithEvents TxtNombreP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents IdPuesto As DataGridViewTextBoxColumn
    Friend WithEvents NombreP As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionP As DataGridViewTextBoxColumn
End Class
