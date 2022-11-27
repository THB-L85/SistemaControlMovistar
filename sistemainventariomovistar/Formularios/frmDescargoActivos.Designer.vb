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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDescargoActivos))
        Me.TxtIdEmpleado = New System.Windows.Forms.TextBox()
        Me.TxtIdArticulo = New System.Windows.Forms.TextBox()
        Me.TxtIdCargo = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2DgbDescargoActivos = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2RbCodigoA = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RbFecha = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RbNombreA = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2TxtBuscar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2BtnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2TxtCodigoInv = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TxtDescripcion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TxtDepartamento = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TxtCurp = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2BtnCodigoInv = New Guna.UI2.WinForms.Guna2Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Guna2DTPFechaEntrega = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2TxtNombreE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TxtNombreArt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TxtNSerie = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Guna2CboMotivo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Guna2DtpDescargo = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2BtnCancelar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnNuevo = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnBuscar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnBorrar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BntEditar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnGuardar = New Guna.UI2.WinForms.Guna2Button()
        Me.txtIdDescargo = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2DgbDescargoActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtIdEmpleado
        '
        Me.TxtIdEmpleado.Location = New System.Drawing.Point(489, 60)
        Me.TxtIdEmpleado.Name = "TxtIdEmpleado"
        Me.TxtIdEmpleado.Size = New System.Drawing.Size(32, 20)
        Me.TxtIdEmpleado.TabIndex = 139
        Me.TxtIdEmpleado.Visible = False
        '
        'TxtIdArticulo
        '
        Me.TxtIdArticulo.Location = New System.Drawing.Point(451, 60)
        Me.TxtIdArticulo.Name = "TxtIdArticulo"
        Me.TxtIdArticulo.Size = New System.Drawing.Size(32, 20)
        Me.TxtIdArticulo.TabIndex = 138
        Me.TxtIdArticulo.Visible = False
        '
        'TxtIdCargo
        '
        Me.TxtIdCargo.Location = New System.Drawing.Point(527, 60)
        Me.TxtIdCargo.Name = "TxtIdCargo"
        Me.TxtIdCargo.Size = New System.Drawing.Size(32, 20)
        Me.TxtIdCargo.TabIndex = 119
        Me.TxtIdCargo.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Guna2DgbDescargoActivos)
        Me.Panel1.Controls.Add(Me.Guna2RbCodigoA)
        Me.Panel1.Controls.Add(Me.Guna2RbFecha)
        Me.Panel1.Controls.Add(Me.Guna2RbNombreA)
        Me.Panel1.Controls.Add(Me.Guna2TxtBuscar)
        Me.Panel1.Controls.Add(Me.LblTotal)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(50, 288)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(931, 358)
        Me.Panel1.TabIndex = 118
        '
        'Guna2DgbDescargoActivos
        '
        Me.Guna2DgbDescargoActivos.AllowUserToAddRows = False
        Me.Guna2DgbDescargoActivos.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Guna2DgbDescargoActivos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.Guna2DgbDescargoActivos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Guna2DgbDescargoActivos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DgbDescargoActivos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.Guna2DgbDescargoActivos.ColumnHeadersHeight = 40
        Me.Guna2DgbDescargoActivos.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DgbDescargoActivos.DefaultCellStyle = DataGridViewCellStyle12
        Me.Guna2DgbDescargoActivos.GridColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Guna2DgbDescargoActivos.Location = New System.Drawing.Point(1, 51)
        Me.Guna2DgbDescargoActivos.Name = "Guna2DgbDescargoActivos"
        Me.Guna2DgbDescargoActivos.ReadOnly = True
        Me.Guna2DgbDescargoActivos.RowHeadersVisible = False
        Me.Guna2DgbDescargoActivos.Size = New System.Drawing.Size(926, 281)
        Me.Guna2DgbDescargoActivos.TabIndex = 140
        Me.Guna2DgbDescargoActivos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green
        Me.Guna2DgbDescargoActivos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Guna2DgbDescargoActivos.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DgbDescargoActivos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DgbDescargoActivos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DgbDescargoActivos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DgbDescargoActivos.ThemeStyle.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2DgbDescargoActivos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Guna2DgbDescargoActivos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2DgbDescargoActivos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DgbDescargoActivos.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DgbDescargoActivos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DgbDescargoActivos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Guna2DgbDescargoActivos.ThemeStyle.HeaderStyle.Height = 40
        Me.Guna2DgbDescargoActivos.ThemeStyle.ReadOnly = True
        Me.Guna2DgbDescargoActivos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Guna2DgbDescargoActivos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DgbDescargoActivos.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DgbDescargoActivos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.Guna2DgbDescargoActivos.ThemeStyle.RowsStyle.Height = 22
        Me.Guna2DgbDescargoActivos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White
        Me.Guna2DgbDescargoActivos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
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
        Me.Guna2RbCodigoA.Location = New System.Drawing.Point(736, 15)
        Me.Guna2RbCodigoA.Name = "Guna2RbCodigoA"
        Me.Guna2RbCodigoA.Size = New System.Drawing.Size(116, 20)
        Me.Guna2RbCodigoA.TabIndex = 139
        Me.Guna2RbCodigoA.Text = "Código de Artículo"
        Me.Guna2RbCodigoA.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RbCodigoA.UncheckedState.BorderThickness = 2
        Me.Guna2RbCodigoA.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RbCodigoA.UncheckedState.InnerColor = System.Drawing.Color.Transparent
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
        Me.Guna2RbFecha.Location = New System.Drawing.Point(675, 15)
        Me.Guna2RbFecha.Name = "Guna2RbFecha"
        Me.Guna2RbFecha.Size = New System.Drawing.Size(55, 20)
        Me.Guna2RbFecha.TabIndex = 138
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
        Me.Guna2RbNombreA.Location = New System.Drawing.Point(532, 15)
        Me.Guna2RbNombreA.Name = "Guna2RbNombreA"
        Me.Guna2RbNombreA.Size = New System.Drawing.Size(133, 20)
        Me.Guna2RbNombreA.TabIndex = 137
        Me.Guna2RbNombreA.TabStop = True
        Me.Guna2RbNombreA.Text = "Nombre de Empleado"
        Me.Guna2RbNombreA.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RbNombreA.UncheckedState.BorderThickness = 2
        Me.Guna2RbNombreA.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RbNombreA.UncheckedState.InnerColor = System.Drawing.Color.Transparent
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
        Me.Guna2TxtBuscar.TabIndex = 136
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
        Me.Label2.Size = New System.Drawing.Size(136, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = " Descargos Registrados"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
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
        Me.Guna2BtnExit.TabIndex = 150
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(442, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 24)
        Me.Label9.TabIndex = 149
        Me.Label9.Text = "Descargo Activos"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1027, 20)
        Me.Panel2.TabIndex = 148
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
        Me.Guna2TxtCodigoInv.Location = New System.Drawing.Point(51, 87)
        Me.Guna2TxtCodigoInv.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtCodigoInv.Name = "Guna2TxtCodigoInv"
        Me.Guna2TxtCodigoInv.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtCodigoInv.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtCodigoInv.PlaceholderText = "Código Inventario"
        Me.Guna2TxtCodigoInv.SelectedText = ""
        Me.Guna2TxtCodigoInv.Size = New System.Drawing.Size(150, 36)
        Me.Guna2TxtCodigoInv.TabIndex = 151
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
        Me.Guna2TxtDescripcion.TabIndex = 154
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
        Me.Guna2TxtDepartamento.TabIndex = 153
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
        Me.Guna2TxtCurp.TabIndex = 152
        '
        'Guna2BtnCodigoInv
        '
        Me.Guna2BtnCodigoInv.Animated = True
        Me.Guna2BtnCodigoInv.BorderRadius = 7
        Me.Guna2BtnCodigoInv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2BtnCodigoInv.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnCodigoInv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnCodigoInv.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2BtnCodigoInv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2BtnCodigoInv.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2BtnCodigoInv.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!)
        Me.Guna2BtnCodigoInv.ForeColor = System.Drawing.Color.Black
        Me.Guna2BtnCodigoInv.Location = New System.Drawing.Point(211, 87)
        Me.Guna2BtnCodigoInv.Name = "Guna2BtnCodigoInv"
        Me.Guna2BtnCodigoInv.Size = New System.Drawing.Size(42, 36)
        Me.Guna2BtnCodigoInv.TabIndex = 155
        Me.Guna2BtnCodigoInv.Text = "..."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(281, 186)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 21)
        Me.Label10.TabIndex = 160
        Me.Label10.Text = "F. Entrega:"
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
        Me.Guna2DTPFechaEntrega.Location = New System.Drawing.Point(371, 179)
        Me.Guna2DTPFechaEntrega.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DTPFechaEntrega.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DTPFechaEntrega.Name = "Guna2DTPFechaEntrega"
        Me.Guna2DTPFechaEntrega.Size = New System.Drawing.Size(134, 36)
        Me.Guna2DTPFechaEntrega.TabIndex = 159
        Me.Guna2DTPFechaEntrega.Value = New Date(2022, 11, 13, 22, 42, 37, 926)
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
        Me.Guna2TxtNombreE.Location = New System.Drawing.Point(280, 133)
        Me.Guna2TxtNombreE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtNombreE.Name = "Guna2TxtNombreE"
        Me.Guna2TxtNombreE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtNombreE.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtNombreE.PlaceholderText = "Nombre del Empleado"
        Me.Guna2TxtNombreE.ReadOnly = True
        Me.Guna2TxtNombreE.SelectedText = ""
        Me.Guna2TxtNombreE.Size = New System.Drawing.Size(225, 36)
        Me.Guna2TxtNombreE.TabIndex = 158
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
        Me.Guna2TxtNombreArt.Location = New System.Drawing.Point(280, 87)
        Me.Guna2TxtNombreArt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtNombreArt.Name = "Guna2TxtNombreArt"
        Me.Guna2TxtNombreArt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtNombreArt.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtNombreArt.PlaceholderText = "Nombre del Artículo"
        Me.Guna2TxtNombreArt.ReadOnly = True
        Me.Guna2TxtNombreArt.SelectedText = ""
        Me.Guna2TxtNombreArt.Size = New System.Drawing.Size(225, 36)
        Me.Guna2TxtNombreArt.TabIndex = 157
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
        Me.Guna2TxtNSerie.TabIndex = 161
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(538, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 21)
        Me.Label11.TabIndex = 163
        Me.Label11.Text = "Motivo:"
        '
        'Guna2CboMotivo
        '
        Me.Guna2CboMotivo.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CboMotivo.BorderColor = System.Drawing.Color.Black
        Me.Guna2CboMotivo.BorderRadius = 7
        Me.Guna2CboMotivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2CboMotivo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2CboMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2CboMotivo.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2CboMotivo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CboMotivo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CboMotivo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2CboMotivo.ForeColor = System.Drawing.Color.Black
        Me.Guna2CboMotivo.ItemHeight = 30
        Me.Guna2CboMotivo.Items.AddRange(New Object() {"Obsoleto", "Cambio"})
        Me.Guna2CboMotivo.Location = New System.Drawing.Point(603, 133)
        Me.Guna2CboMotivo.Name = "Guna2CboMotivo"
        Me.Guna2CboMotivo.Size = New System.Drawing.Size(159, 36)
        Me.Guna2CboMotivo.TabIndex = 162
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(538, 186)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 21)
        Me.Label12.TabIndex = 165
        Me.Label12.Text = "F. Decargo:"
        '
        'Guna2DtpDescargo
        '
        Me.Guna2DtpDescargo.Animated = True
        Me.Guna2DtpDescargo.BorderRadius = 7
        Me.Guna2DtpDescargo.BorderThickness = 1
        Me.Guna2DtpDescargo.Checked = True
        Me.Guna2DtpDescargo.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2DtpDescargo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2DtpDescargo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Guna2DtpDescargo.Location = New System.Drawing.Point(628, 179)
        Me.Guna2DtpDescargo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DtpDescargo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DtpDescargo.Name = "Guna2DtpDescargo"
        Me.Guna2DtpDescargo.Size = New System.Drawing.Size(134, 36)
        Me.Guna2DtpDescargo.TabIndex = 164
        Me.Guna2DtpDescargo.Value = New Date(2022, 11, 13, 22, 42, 37, 926)
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
        Me.Guna2BtnCancelar.TabIndex = 171
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
        Me.Guna2BtnNuevo.TabIndex = 170
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
        Me.Guna2BtnBuscar.Location = New System.Drawing.Point(621, 225)
        Me.Guna2BtnBuscar.Name = "Guna2BtnBuscar"
        Me.Guna2BtnBuscar.Size = New System.Drawing.Size(141, 35)
        Me.Guna2BtnBuscar.TabIndex = 169
        Me.Guna2BtnBuscar.Text = "Buscar"
        Me.Guna2BtnBuscar.Visible = False
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
        Me.Guna2BtnBorrar.TabIndex = 168
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
        Me.Guna2BntEditar.Location = New System.Drawing.Point(798, 179)
        Me.Guna2BntEditar.Name = "Guna2BntEditar"
        Me.Guna2BntEditar.Size = New System.Drawing.Size(141, 35)
        Me.Guna2BntEditar.TabIndex = 167
        Me.Guna2BntEditar.Text = "Editar"
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
        Me.Guna2BtnGuardar.TabIndex = 166
        Me.Guna2BtnGuardar.Text = "Guardar"
        '
        'txtIdDescargo
        '
        Me.txtIdDescargo.Location = New System.Drawing.Point(565, 60)
        Me.txtIdDescargo.Name = "txtIdDescargo"
        Me.txtIdDescargo.Size = New System.Drawing.Size(32, 20)
        Me.txtIdDescargo.TabIndex = 172
        Me.txtIdDescargo.Visible = False
        '
        'frmDescargoActivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1027, 661)
        Me.Controls.Add(Me.txtIdDescargo)
        Me.Controls.Add(Me.Guna2BtnCancelar)
        Me.Controls.Add(Me.Guna2BtnNuevo)
        Me.Controls.Add(Me.Guna2BtnBuscar)
        Me.Controls.Add(Me.Guna2BtnBorrar)
        Me.Controls.Add(Me.Guna2BntEditar)
        Me.Controls.Add(Me.Guna2BtnGuardar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Guna2DtpDescargo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Guna2CboMotivo)
        Me.Controls.Add(Me.Guna2TxtNSerie)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Guna2DTPFechaEntrega)
        Me.Controls.Add(Me.Guna2TxtNombreE)
        Me.Controls.Add(Me.Guna2TxtNombreArt)
        Me.Controls.Add(Me.Guna2BtnCodigoInv)
        Me.Controls.Add(Me.Guna2TxtDescripcion)
        Me.Controls.Add(Me.Guna2TxtDepartamento)
        Me.Controls.Add(Me.Guna2TxtCurp)
        Me.Controls.Add(Me.Guna2TxtCodigoInv)
        Me.Controls.Add(Me.Guna2BtnExit)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TxtIdEmpleado)
        Me.Controls.Add(Me.TxtIdArticulo)
        Me.Controls.Add(Me.TxtIdCargo)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmDescargoActivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTRO DE BAJAS DE ACTIVOS A EMPLEADOS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Guna2DgbDescargoActivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtIdEmpleado As TextBox
    Friend WithEvents TxtIdArticulo As TextBox
    Friend WithEvents TxtIdCargo As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2BtnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2TxtCodigoInv As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TxtDescripcion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TxtDepartamento As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TxtCurp As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2BtnCodigoInv As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Guna2DTPFechaEntrega As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2TxtNombreE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TxtNombreArt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TxtNSerie As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Guna2CboMotivo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Guna2DtpDescargo As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2BtnCancelar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BtnNuevo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BtnBuscar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BtnBorrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BntEditar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BtnGuardar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TxtBuscar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2RbCodigoA As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RbFecha As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RbNombreA As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2DgbDescargoActivos As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtIdDescargo As TextBox
End Class
