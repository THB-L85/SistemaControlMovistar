<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCargoActivos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCargoActivos))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2TxtBuscar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2RbCodigoA = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2DgbCargoActivos = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2RbFecha = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RbNombreA = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtIdArticulo = New System.Windows.Forms.TextBox()
        Me.TxtIdEmpleado = New System.Windows.Forms.TextBox()
        Me.Guna2TxtCodigo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2TxtCurp = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TxtDepartamento = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TxtDescripcion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TxtNombreArt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TxtNombreE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Btncodigo = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnCurp = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DTPFechaEntrega = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2TxtNSerie = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TxtCodigoInv = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2CboEstado = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2BtnGuardar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BntEditar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnBorrar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnBuscar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnNuevo = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnCancelar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2DgbCargoActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(51, 268)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(32, 20)
        Me.TxtId.TabIndex = 85
        Me.TxtId.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Guna2TxtBuscar)
        Me.Panel1.Controls.Add(Me.Guna2RbCodigoA)
        Me.Panel1.Controls.Add(Me.Guna2DgbCargoActivos)
        Me.Panel1.Controls.Add(Me.Guna2RbFecha)
        Me.Panel1.Controls.Add(Me.Guna2RbNombreA)
        Me.Panel1.Controls.Add(Me.LblTotal)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(50, 288)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(931, 358)
        Me.Panel1.TabIndex = 84
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
        Me.Guna2TxtBuscar.Location = New System.Drawing.Point(1, 4)
        Me.Guna2TxtBuscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtBuscar.Name = "Guna2TxtBuscar"
        Me.Guna2TxtBuscar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtBuscar.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtBuscar.PlaceholderText = "Buscar.."
        Me.Guna2TxtBuscar.SelectedText = ""
        Me.Guna2TxtBuscar.Size = New System.Drawing.Size(456, 36)
        Me.Guna2TxtBuscar.TabIndex = 135
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
        Me.Guna2RbCodigoA.Location = New System.Drawing.Point(744, 13)
        Me.Guna2RbCodigoA.Name = "Guna2RbCodigoA"
        Me.Guna2RbCodigoA.Size = New System.Drawing.Size(116, 20)
        Me.Guna2RbCodigoA.TabIndex = 134
        Me.Guna2RbCodigoA.Text = "Código de Artículo"
        Me.Guna2RbCodigoA.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RbCodigoA.UncheckedState.BorderThickness = 2
        Me.Guna2RbCodigoA.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RbCodigoA.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Guna2DgbCargoActivos
        '
        Me.Guna2DgbCargoActivos.AllowUserToAddRows = False
        Me.Guna2DgbCargoActivos.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Guna2DgbCargoActivos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Guna2DgbCargoActivos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Guna2DgbCargoActivos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DgbCargoActivos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Guna2DgbCargoActivos.ColumnHeadersHeight = 40
        Me.Guna2DgbCargoActivos.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DgbCargoActivos.DefaultCellStyle = DataGridViewCellStyle6
        Me.Guna2DgbCargoActivos.GridColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Guna2DgbCargoActivos.Location = New System.Drawing.Point(1, 51)
        Me.Guna2DgbCargoActivos.Name = "Guna2DgbCargoActivos"
        Me.Guna2DgbCargoActivos.ReadOnly = True
        Me.Guna2DgbCargoActivos.RowHeadersVisible = False
        Me.Guna2DgbCargoActivos.Size = New System.Drawing.Size(926, 281)
        Me.Guna2DgbCargoActivos.TabIndex = 23
        Me.Guna2DgbCargoActivos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green
        Me.Guna2DgbCargoActivos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Guna2DgbCargoActivos.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DgbCargoActivos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DgbCargoActivos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DgbCargoActivos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DgbCargoActivos.ThemeStyle.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2DgbCargoActivos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Guna2DgbCargoActivos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2DgbCargoActivos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DgbCargoActivos.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DgbCargoActivos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DgbCargoActivos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Guna2DgbCargoActivos.ThemeStyle.HeaderStyle.Height = 40
        Me.Guna2DgbCargoActivos.ThemeStyle.ReadOnly = True
        Me.Guna2DgbCargoActivos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Guna2DgbCargoActivos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DgbCargoActivos.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DgbCargoActivos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.Guna2DgbCargoActivos.ThemeStyle.RowsStyle.Height = 22
        Me.Guna2DgbCargoActivos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White
        Me.Guna2DgbCargoActivos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
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
        Me.Guna2RbFecha.Location = New System.Drawing.Point(683, 13)
        Me.Guna2RbFecha.Name = "Guna2RbFecha"
        Me.Guna2RbFecha.Size = New System.Drawing.Size(55, 20)
        Me.Guna2RbFecha.TabIndex = 133
        Me.Guna2RbFecha.Text = "Fecha"
        Me.Guna2RbFecha.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RbFecha.UncheckedState.BorderThickness = 2
        Me.Guna2RbFecha.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RbFecha.UncheckedState.InnerColor = System.Drawing.Color.Transparent
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
        Me.Guna2RbNombreA.Location = New System.Drawing.Point(540, 13)
        Me.Guna2RbNombreA.Name = "Guna2RbNombreA"
        Me.Guna2RbNombreA.Size = New System.Drawing.Size(133, 20)
        Me.Guna2RbNombreA.TabIndex = 132
        Me.Guna2RbNombreA.TabStop = True
        Me.Guna2RbNombreA.Text = "Nombre de Empleado"
        Me.Guna2RbNombreA.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RbNombreA.UncheckedState.BorderThickness = 2
        Me.Guna2RbNombreA.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RbNombreA.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(142, 335)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(35, 17)
        Me.LblTotal.TabIndex = 19
        Me.LblTotal.Text = "Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 335)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Empleados Registrados"
        '
        'TxtIdArticulo
        '
        Me.TxtIdArticulo.Location = New System.Drawing.Point(96, 268)
        Me.TxtIdArticulo.Name = "TxtIdArticulo"
        Me.TxtIdArticulo.Size = New System.Drawing.Size(32, 20)
        Me.TxtIdArticulo.TabIndex = 112
        Me.TxtIdArticulo.Visible = False
        '
        'TxtIdEmpleado
        '
        Me.TxtIdEmpleado.Location = New System.Drawing.Point(138, 268)
        Me.TxtIdEmpleado.Name = "TxtIdEmpleado"
        Me.TxtIdEmpleado.Size = New System.Drawing.Size(32, 20)
        Me.TxtIdEmpleado.TabIndex = 113
        Me.TxtIdEmpleado.Visible = False
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
        Me.Guna2TxtCodigo.Location = New System.Drawing.Point(51, 87)
        Me.Guna2TxtCodigo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtCodigo.Name = "Guna2TxtCodigo"
        Me.Guna2TxtCodigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtCodigo.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtCodigo.PlaceholderText = "Código"
        Me.Guna2TxtCodigo.SelectedText = ""
        Me.Guna2TxtCodigo.Size = New System.Drawing.Size(150, 36)
        Me.Guna2TxtCodigo.TabIndex = 114
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2TxtCurp
        '
        Me.Guna2TxtCurp.Animated = True
        Me.Guna2TxtCurp.BorderColor = System.Drawing.Color.Black
        Me.Guna2TxtCurp.BorderRadius = 7
        Me.Guna2TxtCurp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TxtCurp.DefaultText = ""
        Me.Guna2TxtCurp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TxtCurp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TxtCurp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtCurp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtCurp.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TxtCurp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtCurp.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.Guna2TxtCurp.ForeColor = System.Drawing.Color.Black
        Me.Guna2TxtCurp.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtCurp.Location = New System.Drawing.Point(51, 133)
        Me.Guna2TxtCurp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtCurp.Name = "Guna2TxtCurp"
        Me.Guna2TxtCurp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtCurp.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtCurp.PlaceholderText = "Curp"
        Me.Guna2TxtCurp.SelectedText = ""
        Me.Guna2TxtCurp.Size = New System.Drawing.Size(150, 36)
        Me.Guna2TxtCurp.TabIndex = 115
        '
        'Guna2TxtDepartamento
        '
        Me.Guna2TxtDepartamento.Animated = True
        Me.Guna2TxtDepartamento.BorderColor = System.Drawing.Color.Black
        Me.Guna2TxtDepartamento.BorderRadius = 7
        Me.Guna2TxtDepartamento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TxtDepartamento.DefaultText = ""
        Me.Guna2TxtDepartamento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TxtDepartamento.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TxtDepartamento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtDepartamento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtDepartamento.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TxtDepartamento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtDepartamento.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.Guna2TxtDepartamento.ForeColor = System.Drawing.Color.Black
        Me.Guna2TxtDepartamento.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtDepartamento.Location = New System.Drawing.Point(51, 179)
        Me.Guna2TxtDepartamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtDepartamento.Name = "Guna2TxtDepartamento"
        Me.Guna2TxtDepartamento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtDepartamento.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtDepartamento.PlaceholderText = "Departamento"
        Me.Guna2TxtDepartamento.SelectedText = ""
        Me.Guna2TxtDepartamento.Size = New System.Drawing.Size(150, 36)
        Me.Guna2TxtDepartamento.TabIndex = 116
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
        Me.Guna2TxtDescripcion.Location = New System.Drawing.Point(51, 225)
        Me.Guna2TxtDescripcion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtDescripcion.Name = "Guna2TxtDescripcion"
        Me.Guna2TxtDescripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtDescripcion.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtDescripcion.PlaceholderText = "Descripción"
        Me.Guna2TxtDescripcion.SelectedText = ""
        Me.Guna2TxtDescripcion.Size = New System.Drawing.Size(456, 36)
        Me.Guna2TxtDescripcion.TabIndex = 117
        '
        'Guna2TxtNombreArt
        '
        Me.Guna2TxtNombreArt.Animated = True
        Me.Guna2TxtNombreArt.BorderColor = System.Drawing.Color.Black
        Me.Guna2TxtNombreArt.BorderRadius = 7
        Me.Guna2TxtNombreArt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TxtNombreArt.DefaultText = ""
        Me.Guna2TxtNombreArt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TxtNombreArt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TxtNombreArt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtNombreArt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtNombreArt.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TxtNombreArt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtNombreArt.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.Guna2TxtNombreArt.ForeColor = System.Drawing.Color.Black
        Me.Guna2TxtNombreArt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtNombreArt.Location = New System.Drawing.Point(282, 87)
        Me.Guna2TxtNombreArt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtNombreArt.Name = "Guna2TxtNombreArt"
        Me.Guna2TxtNombreArt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtNombreArt.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtNombreArt.PlaceholderText = "Nombre del Artículo"
        Me.Guna2TxtNombreArt.ReadOnly = True
        Me.Guna2TxtNombreArt.SelectedText = ""
        Me.Guna2TxtNombreArt.Size = New System.Drawing.Size(225, 36)
        Me.Guna2TxtNombreArt.TabIndex = 118
        '
        'Guna2TxtNombreE
        '
        Me.Guna2TxtNombreE.Animated = True
        Me.Guna2TxtNombreE.BorderColor = System.Drawing.Color.Black
        Me.Guna2TxtNombreE.BorderRadius = 7
        Me.Guna2TxtNombreE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TxtNombreE.DefaultText = ""
        Me.Guna2TxtNombreE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TxtNombreE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TxtNombreE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtNombreE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtNombreE.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TxtNombreE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtNombreE.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.Guna2TxtNombreE.ForeColor = System.Drawing.Color.Black
        Me.Guna2TxtNombreE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtNombreE.Location = New System.Drawing.Point(282, 133)
        Me.Guna2TxtNombreE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtNombreE.Name = "Guna2TxtNombreE"
        Me.Guna2TxtNombreE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtNombreE.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtNombreE.PlaceholderText = "Nombre del Empleado"
        Me.Guna2TxtNombreE.ReadOnly = True
        Me.Guna2TxtNombreE.SelectedText = ""
        Me.Guna2TxtNombreE.Size = New System.Drawing.Size(225, 36)
        Me.Guna2TxtNombreE.TabIndex = 119
        '
        'Guna2Btncodigo
        '
        Me.Guna2Btncodigo.Animated = True
        Me.Guna2Btncodigo.BorderRadius = 7
        Me.Guna2Btncodigo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Btncodigo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Btncodigo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Btncodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Btncodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Btncodigo.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2Btncodigo.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!)
        Me.Guna2Btncodigo.ForeColor = System.Drawing.Color.Black
        Me.Guna2Btncodigo.Location = New System.Drawing.Point(211, 87)
        Me.Guna2Btncodigo.Name = "Guna2Btncodigo"
        Me.Guna2Btncodigo.Size = New System.Drawing.Size(42, 36)
        Me.Guna2Btncodigo.TabIndex = 120
        Me.Guna2Btncodigo.Text = "..."
        '
        'Guna2BtnCurp
        '
        Me.Guna2BtnCurp.Animated = True
        Me.Guna2BtnCurp.BorderRadius = 7
        Me.Guna2BtnCurp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2BtnCurp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnCurp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnCurp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2BtnCurp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2BtnCurp.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2BtnCurp.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!)
        Me.Guna2BtnCurp.ForeColor = System.Drawing.Color.Black
        Me.Guna2BtnCurp.Location = New System.Drawing.Point(211, 133)
        Me.Guna2BtnCurp.Name = "Guna2BtnCurp"
        Me.Guna2BtnCurp.Size = New System.Drawing.Size(42, 36)
        Me.Guna2BtnCurp.TabIndex = 121
        Me.Guna2BtnCurp.Text = "..."
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
        Me.Guna2DTPFechaEntrega.Location = New System.Drawing.Point(373, 179)
        Me.Guna2DTPFechaEntrega.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DTPFechaEntrega.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DTPFechaEntrega.Name = "Guna2DTPFechaEntrega"
        Me.Guna2DTPFechaEntrega.Size = New System.Drawing.Size(134, 36)
        Me.Guna2DTPFechaEntrega.TabIndex = 122
        Me.Guna2DTPFechaEntrega.Value = New Date(2022, 11, 13, 22, 42, 37, 926)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(283, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 21)
        Me.Label7.TabIndex = 123
        Me.Label7.Text = "F. Compra:"
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
        Me.Guna2TxtNSerie.Location = New System.Drawing.Point(537, 87)
        Me.Guna2TxtNSerie.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtNSerie.Name = "Guna2TxtNSerie"
        Me.Guna2TxtNSerie.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtNSerie.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtNSerie.PlaceholderText = "Número de Serie"
        Me.Guna2TxtNSerie.ReadOnly = True
        Me.Guna2TxtNSerie.SelectedText = ""
        Me.Guna2TxtNSerie.Size = New System.Drawing.Size(225, 36)
        Me.Guna2TxtNSerie.TabIndex = 124
        '
        'Guna2TxtCodigoInv
        '
        Me.Guna2TxtCodigoInv.Animated = True
        Me.Guna2TxtCodigoInv.BorderColor = System.Drawing.Color.Black
        Me.Guna2TxtCodigoInv.BorderRadius = 7
        Me.Guna2TxtCodigoInv.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TxtCodigoInv.DefaultText = ""
        Me.Guna2TxtCodigoInv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TxtCodigoInv.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TxtCodigoInv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtCodigoInv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtCodigoInv.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TxtCodigoInv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtCodigoInv.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.Guna2TxtCodigoInv.ForeColor = System.Drawing.Color.Black
        Me.Guna2TxtCodigoInv.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtCodigoInv.Location = New System.Drawing.Point(537, 133)
        Me.Guna2TxtCodigoInv.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtCodigoInv.Name = "Guna2TxtCodigoInv"
        Me.Guna2TxtCodigoInv.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtCodigoInv.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtCodigoInv.PlaceholderText = "Código Inventario"
        Me.Guna2TxtCodigoInv.SelectedText = ""
        Me.Guna2TxtCodigoInv.Size = New System.Drawing.Size(225, 36)
        Me.Guna2TxtCodigoInv.TabIndex = 125
        '
        'Guna2CboEstado
        '
        Me.Guna2CboEstado.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CboEstado.BorderColor = System.Drawing.Color.Black
        Me.Guna2CboEstado.BorderRadius = 7
        Me.Guna2CboEstado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2CboEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2CboEstado.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2CboEstado.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CboEstado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CboEstado.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2CboEstado.ForeColor = System.Drawing.Color.Black
        Me.Guna2CboEstado.ItemHeight = 30
        Me.Guna2CboEstado.Items.AddRange(New Object() {"Nuevo", "Usado"})
        Me.Guna2CboEstado.Location = New System.Drawing.Point(628, 181)
        Me.Guna2CboEstado.Name = "Guna2CboEstado"
        Me.Guna2CboEstado.Size = New System.Drawing.Size(134, 36)
        Me.Guna2CboEstado.TabIndex = 126
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(545, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 21)
        Me.Label8.TabIndex = 127
        Me.Label8.Text = "E. Activo:"
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
        Me.Guna2BtnGuardar.Location = New System.Drawing.Point(798, 140)
        Me.Guna2BtnGuardar.Name = "Guna2BtnGuardar"
        Me.Guna2BtnGuardar.Size = New System.Drawing.Size(141, 35)
        Me.Guna2BtnGuardar.TabIndex = 128
        Me.Guna2BtnGuardar.Text = "Guardar"
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
        Me.Guna2BntEditar.Location = New System.Drawing.Point(798, 179)
        Me.Guna2BntEditar.Name = "Guna2BntEditar"
        Me.Guna2BntEditar.Size = New System.Drawing.Size(141, 35)
        Me.Guna2BntEditar.TabIndex = 129
        Me.Guna2BntEditar.Text = "Editar"
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
        Me.Guna2BtnBorrar.Location = New System.Drawing.Point(798, 220)
        Me.Guna2BtnBorrar.Name = "Guna2BtnBorrar"
        Me.Guna2BtnBorrar.Size = New System.Drawing.Size(141, 35)
        Me.Guna2BtnBorrar.TabIndex = 130
        Me.Guna2BtnBorrar.Text = "Eliminar"
        '
        'Guna2BtnBuscar
        '
        Me.Guna2BtnBuscar.Animated = True
        Me.Guna2BtnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.Guna2BtnBuscar.BorderRadius = 7
        Me.Guna2BtnBuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnBuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2BtnBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2BtnBuscar.Enabled = False
        Me.Guna2BtnBuscar.FillColor = System.Drawing.Color.SteelBlue
        Me.Guna2BtnBuscar.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        Me.Guna2BtnBuscar.ForeColor = System.Drawing.Color.White
        Me.Guna2BtnBuscar.Location = New System.Drawing.Point(594, 226)
        Me.Guna2BtnBuscar.Name = "Guna2BtnBuscar"
        Me.Guna2BtnBuscar.Size = New System.Drawing.Size(141, 35)
        Me.Guna2BtnBuscar.TabIndex = 131
        Me.Guna2BtnBuscar.Text = "Buscar"
        Me.Guna2BtnBuscar.Visible = False
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
        Me.Guna2BtnNuevo.Location = New System.Drawing.Point(804, 79)
        Me.Guna2BtnNuevo.Name = "Guna2BtnNuevo"
        Me.Guna2BtnNuevo.Size = New System.Drawing.Size(54, 54)
        Me.Guna2BtnNuevo.TabIndex = 132
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
        Me.Guna2BtnCancelar.Location = New System.Drawing.Point(883, 85)
        Me.Guna2BtnCancelar.Name = "Guna2BtnCancelar"
        Me.Guna2BtnCancelar.Size = New System.Drawing.Size(45, 45)
        Me.Guna2BtnCancelar.TabIndex = 133
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
        Me.Guna2BtnExit.TabIndex = 136
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 20
        Me.Guna2Elipse2.TargetControl = Me.Guna2DgbCargoActivos
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1027, 20)
        Me.Panel2.TabIndex = 134
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(465, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 24)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "Cargo Activos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmCargoActivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1027, 661)
        Me.Controls.Add(Me.Guna2BtnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Guna2BtnCancelar)
        Me.Controls.Add(Me.Guna2BtnNuevo)
        Me.Controls.Add(Me.Guna2BtnBuscar)
        Me.Controls.Add(Me.Guna2BtnBorrar)
        Me.Controls.Add(Me.Guna2BntEditar)
        Me.Controls.Add(Me.Guna2BtnGuardar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Guna2CboEstado)
        Me.Controls.Add(Me.Guna2TxtCodigoInv)
        Me.Controls.Add(Me.Guna2TxtNSerie)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Guna2DTPFechaEntrega)
        Me.Controls.Add(Me.Guna2BtnCurp)
        Me.Controls.Add(Me.Guna2Btncodigo)
        Me.Controls.Add(Me.Guna2TxtNombreE)
        Me.Controls.Add(Me.Guna2TxtNombreArt)
        Me.Controls.Add(Me.Guna2TxtDescripcion)
        Me.Controls.Add(Me.Guna2TxtDepartamento)
        Me.Controls.Add(Me.Guna2TxtCurp)
        Me.Controls.Add(Me.Guna2TxtCodigo)
        Me.Controls.Add(Me.TxtIdEmpleado)
        Me.Controls.Add(Me.TxtIdArticulo)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCargoActivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargo de Activos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Guna2DgbCargoActivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtIdArticulo As TextBox
    Friend WithEvents TxtIdEmpleado As TextBox
    Friend WithEvents Guna2TxtCodigo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2BtnCurp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Btncodigo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TxtNombreE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TxtNombreArt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TxtDescripcion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TxtDepartamento As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TxtCurp As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2DTPFechaEntrega As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Guna2CboEstado As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2TxtCodigoInv As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TxtNSerie As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2BtnGuardar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BtnBorrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BntEditar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BtnBuscar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2RbNombreA As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RbCodigoA As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RbFecha As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2TxtBuscar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2DgbCargoActivos As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2BtnCancelar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BtnNuevo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BtnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
End Class
