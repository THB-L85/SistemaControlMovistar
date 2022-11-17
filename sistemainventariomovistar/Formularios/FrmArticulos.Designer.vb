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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmArticulos))
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.Guna2RbNombreA = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RbFecha = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RbCodigoA = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2TxtBuscar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2DgbActivos = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.BtnBuscar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2DgbActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.Controls.Add(Me.Guna2DgbActivos)
        Me.Panel1.Controls.Add(Me.Guna2TxtBuscar)
        Me.Panel1.Controls.Add(Me.Guna2RbCodigoA)
        Me.Panel1.Controls.Add(Me.Guna2RbFecha)
        Me.Panel1.Controls.Add(Me.Guna2RbNombreA)
        Me.Panel1.Location = New System.Drawing.Point(51, 240)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(852, 258)
        Me.Panel1.TabIndex = 59
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(188, 501)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(35, 17)
        Me.LblTotal.TabIndex = 19
        Me.LblTotal.Text = "Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 501)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Empleados Registrados"
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
        'Guna2RbNombreA
        '
        Me.Guna2RbNombreA.Animated = True
        Me.Guna2RbNombreA.AutoSize = True
        Me.Guna2RbNombreA.Checked = True
        Me.Guna2RbNombreA.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RbNombreA.CheckedState.BorderThickness = 0
        Me.Guna2RbNombreA.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RbNombreA.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RbNombreA.CheckedState.InnerOffset = -4
        Me.Guna2RbNombreA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2RbNombreA.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!)
        Me.Guna2RbNombreA.Location = New System.Drawing.Point(496, 11)
        Me.Guna2RbNombreA.Name = "Guna2RbNombreA"
        Me.Guna2RbNombreA.Size = New System.Drawing.Size(125, 20)
        Me.Guna2RbNombreA.TabIndex = 133
        Me.Guna2RbNombreA.Text = "Nombre del Artículo"
        Me.Guna2RbNombreA.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RbNombreA.UncheckedState.BorderThickness = 2
        Me.Guna2RbNombreA.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RbNombreA.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Guna2RbFecha
        '
        Me.Guna2RbFecha.Animated = True
        Me.Guna2RbFecha.AutoSize = True
        Me.Guna2RbFecha.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RbFecha.CheckedState.BorderThickness = 0
        Me.Guna2RbFecha.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RbFecha.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RbFecha.CheckedState.InnerOffset = -4
        Me.Guna2RbFecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2RbFecha.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!)
        Me.Guna2RbFecha.Location = New System.Drawing.Point(629, 11)
        Me.Guna2RbFecha.Name = "Guna2RbFecha"
        Me.Guna2RbFecha.Size = New System.Drawing.Size(55, 20)
        Me.Guna2RbFecha.TabIndex = 134
        Me.Guna2RbFecha.Text = "Fecha"
        Me.Guna2RbFecha.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RbFecha.UncheckedState.BorderThickness = 2
        Me.Guna2RbFecha.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RbFecha.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Guna2RbCodigoA
        '
        Me.Guna2RbCodigoA.Animated = True
        Me.Guna2RbCodigoA.AutoSize = True
        Me.Guna2RbCodigoA.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RbCodigoA.CheckedState.BorderThickness = 0
        Me.Guna2RbCodigoA.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RbCodigoA.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RbCodigoA.CheckedState.InnerOffset = -4
        Me.Guna2RbCodigoA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2RbCodigoA.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!)
        Me.Guna2RbCodigoA.Location = New System.Drawing.Point(701, 11)
        Me.Guna2RbCodigoA.Name = "Guna2RbCodigoA"
        Me.Guna2RbCodigoA.Size = New System.Drawing.Size(116, 20)
        Me.Guna2RbCodigoA.TabIndex = 135
        Me.Guna2RbCodigoA.Text = "Código de Artículo"
        Me.Guna2RbCodigoA.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RbCodigoA.UncheckedState.BorderThickness = 2
        Me.Guna2RbCodigoA.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RbCodigoA.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Guna2TxtBuscar
        '
        Me.Guna2TxtBuscar.Animated = True
        Me.Guna2TxtBuscar.BorderColor = System.Drawing.Color.Black
        Me.Guna2TxtBuscar.BorderRadius = 7
        Me.Guna2TxtBuscar.BorderThickness = 0
        Me.Guna2TxtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TxtBuscar.DefaultText = ""
        Me.Guna2TxtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TxtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TxtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtBuscar.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TxtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtBuscar.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.Guna2TxtBuscar.ForeColor = System.Drawing.Color.Black
        Me.Guna2TxtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtBuscar.IconLeft = CType(resources.GetObject("Guna2TxtBuscar.IconLeft"), System.Drawing.Image)
        Me.Guna2TxtBuscar.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.Guna2TxtBuscar.Location = New System.Drawing.Point(0, 4)
        Me.Guna2TxtBuscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtBuscar.Name = "Guna2TxtBuscar"
        Me.Guna2TxtBuscar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtBuscar.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtBuscar.PlaceholderText = "Buscar.."
        Me.Guna2TxtBuscar.SelectedText = ""
        Me.Guna2TxtBuscar.Size = New System.Drawing.Size(456, 36)
        Me.Guna2TxtBuscar.TabIndex = 136
        '
        'Guna2DgbActivos
        '
        Me.Guna2DgbActivos.AllowUserToAddRows = False
        Me.Guna2DgbActivos.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Guna2DgbActivos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Guna2DgbActivos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Guna2DgbActivos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DgbActivos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Guna2DgbActivos.ColumnHeadersHeight = 40
        Me.Guna2DgbActivos.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DgbActivos.DefaultCellStyle = DataGridViewCellStyle6
        Me.Guna2DgbActivos.GridColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Guna2DgbActivos.Location = New System.Drawing.Point(0, 51)
        Me.Guna2DgbActivos.Name = "Guna2DgbActivos"
        Me.Guna2DgbActivos.ReadOnly = True
        Me.Guna2DgbActivos.RowHeadersVisible = False
        Me.Guna2DgbActivos.Size = New System.Drawing.Size(852, 207)
        Me.Guna2DgbActivos.TabIndex = 137
        Me.Guna2DgbActivos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green
        Me.Guna2DgbActivos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Guna2DgbActivos.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DgbActivos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DgbActivos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DgbActivos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DgbActivos.ThemeStyle.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2DgbActivos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Guna2DgbActivos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2DgbActivos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DgbActivos.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DgbActivos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DgbActivos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Guna2DgbActivos.ThemeStyle.HeaderStyle.Height = 40
        Me.Guna2DgbActivos.ThemeStyle.ReadOnly = True
        Me.Guna2DgbActivos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Guna2DgbActivos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DgbActivos.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DgbActivos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.Guna2DgbActivos.ThemeStyle.RowsStyle.Height = 22
        Me.Guna2DgbActivos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White
        Me.Guna2DgbActivos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Animated = True
        Me.BtnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.BtnBuscar.BorderRadius = 7
        Me.BtnBuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnBuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnBuscar.Enabled = False
        Me.BtnBuscar.FillColor = System.Drawing.Color.SteelBlue
        Me.BtnBuscar.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        Me.BtnBuscar.ForeColor = System.Drawing.Color.White
        Me.BtnBuscar.Location = New System.Drawing.Point(640, 43)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(141, 35)
        Me.BtnBuscar.TabIndex = 148
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.Visible = False
        '
        'Guna2BtnExit
        '
        Me.Guna2BtnExit.Animated = True
        Me.Guna2BtnExit.BackColor = System.Drawing.Color.Transparent
        Me.Guna2BtnExit.BackgroundImage = CType(resources.GetObject("Guna2BtnExit.BackgroundImage"), System.Drawing.Image)
        Me.Guna2BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2BtnExit.BorderRadius = 7
        Me.Guna2BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2BtnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2BtnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2BtnExit.FillColor = System.Drawing.Color.Transparent
        Me.Guna2BtnExit.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        Me.Guna2BtnExit.ForeColor = System.Drawing.Color.White
        Me.Guna2BtnExit.Location = New System.Drawing.Point(23, 22)
        Me.Guna2BtnExit.Name = "Guna2BtnExit"
        Me.Guna2BtnExit.Size = New System.Drawing.Size(45, 45)
        Me.Guna2BtnExit.TabIndex = 149
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 20
        Me.Guna2Elipse2.TargetControl = Me.Guna2DgbActivos
        '
        'FrmArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(958, 540)
        Me.Controls.Add(Me.Guna2BtnExit)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.Guna2BtnCancelar)
        Me.Controls.Add(Me.Guna2BtnNuevo)
        Me.Controls.Add(Me.Guna2BtnBorrar)
        Me.Controls.Add(Me.Guna2BntEditar)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2BtnGuardar)
        Me.Controls.Add(Me.Guna2DTPFechaEntrega)
        Me.Controls.Add(Me.Guna2TxtDescripcion)
        Me.Controls.Add(Me.Guna2TxtPrecio)
        Me.Controls.Add(Me.Guna2TxtCodigo)
        Me.Controls.Add(Me.Guna2TxtNSerie)
        Me.Controls.Add(Me.Guna2TxtNombreA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario de articulos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Guna2DgbActivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblTotal As Label
    Friend WithEvents Label2 As Label
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
    Friend WithEvents Guna2RbCodigoA As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RbFecha As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RbNombreA As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2TxtBuscar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2DgbActivos As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BtnBuscar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BtnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
End Class
