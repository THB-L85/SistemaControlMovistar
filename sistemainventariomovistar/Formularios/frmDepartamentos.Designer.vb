<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartamentos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDepartamentos))
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2DgbDepartamentos = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2txtBuscar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2btnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2tbNameD = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TxtDescripcionD = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2btnGuardar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2btnEditar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2btnBorrar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2btnCancelar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2btnNuevo = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2DgbDepartamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(372, 178)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(74, 20)
        Me.TxtId.TabIndex = 4
        Me.TxtId.Visible = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(371, 204)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 21
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        Me.BtnBuscar.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Guna2DgbDepartamentos)
        Me.Panel1.Controls.Add(Me.Guna2txtBuscar)
        Me.Panel1.Controls.Add(Me.LblTotal)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(48, 287)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(616, 269)
        Me.Panel1.TabIndex = 22
        '
        'Guna2DgbDepartamentos
        '
        Me.Guna2DgbDepartamentos.AllowUserToAddRows = False
        Me.Guna2DgbDepartamentos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Guna2DgbDepartamentos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Guna2DgbDepartamentos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Guna2DgbDepartamentos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DgbDepartamentos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DgbDepartamentos.ColumnHeadersHeight = 40
        Me.Guna2DgbDepartamentos.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DgbDepartamentos.DefaultCellStyle = DataGridViewCellStyle3
        Me.Guna2DgbDepartamentos.GridColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Guna2DgbDepartamentos.Location = New System.Drawing.Point(17, 55)
        Me.Guna2DgbDepartamentos.Name = "Guna2DgbDepartamentos"
        Me.Guna2DgbDepartamentos.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DgbDepartamentos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Guna2DgbDepartamentos.RowHeadersVisible = False
        Me.Guna2DgbDepartamentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Guna2DgbDepartamentos.Size = New System.Drawing.Size(581, 190)
        Me.Guna2DgbDepartamentos.TabIndex = 22
        Me.Guna2DgbDepartamentos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green
        Me.Guna2DgbDepartamentos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Guna2DgbDepartamentos.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DgbDepartamentos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DgbDepartamentos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DgbDepartamentos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DgbDepartamentos.ThemeStyle.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2DgbDepartamentos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Guna2DgbDepartamentos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2DgbDepartamentos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DgbDepartamentos.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DgbDepartamentos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DgbDepartamentos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Guna2DgbDepartamentos.ThemeStyle.HeaderStyle.Height = 40
        Me.Guna2DgbDepartamentos.ThemeStyle.ReadOnly = True
        Me.Guna2DgbDepartamentos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Guna2DgbDepartamentos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DgbDepartamentos.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DgbDepartamentos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.Guna2DgbDepartamentos.ThemeStyle.RowsStyle.Height = 22
        Me.Guna2DgbDepartamentos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White
        Me.Guna2DgbDepartamentos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Guna2txtBuscar
        '
        Me.Guna2txtBuscar.Animated = True
        Me.Guna2txtBuscar.BorderRadius = 7
        Me.Guna2txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2txtBuscar.DefaultText = ""
        Me.Guna2txtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2txtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2txtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2txtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2txtBuscar.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2txtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2txtBuscar.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!)
        Me.Guna2txtBuscar.ForeColor = System.Drawing.Color.Black
        Me.Guna2txtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2txtBuscar.IconLeft = CType(resources.GetObject("Guna2txtBuscar.IconLeft"), System.Drawing.Image)
        Me.Guna2txtBuscar.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.Guna2txtBuscar.Location = New System.Drawing.Point(17, 11)
        Me.Guna2txtBuscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2txtBuscar.Name = "Guna2txtBuscar"
        Me.Guna2txtBuscar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2txtBuscar.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2txtBuscar.PlaceholderText = "Buscar..."
        Me.Guna2txtBuscar.SelectedText = ""
        Me.Guna2txtBuscar.Size = New System.Drawing.Size(283, 36)
        Me.Guna2txtBuscar.TabIndex = 21
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(545, 27)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(41, 20)
        Me.LblTotal.TabIndex = 19
        Me.LblTotal.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(399, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Usuarios Registrados"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(262, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(198, 24)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Registro de Departamentos"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(712, 20)
        Me.Guna2Panel1.TabIndex = 23
        '
        'Guna2btnExit
        '
        Me.Guna2btnExit.Animated = True
        Me.Guna2btnExit.BackgroundImage = CType(resources.GetObject("Guna2btnExit.BackgroundImage"), System.Drawing.Image)
        Me.Guna2btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2btnExit.BorderRadius = 7
        Me.Guna2btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2btnExit.FillColor = System.Drawing.Color.Transparent
        Me.Guna2btnExit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2btnExit.ForeColor = System.Drawing.Color.White
        Me.Guna2btnExit.Location = New System.Drawing.Point(23, 22)
        Me.Guna2btnExit.Name = "Guna2btnExit"
        Me.Guna2btnExit.Size = New System.Drawing.Size(45, 45)
        Me.Guna2btnExit.TabIndex = 34
        '
        'Guna2tbNameD
        '
        Me.Guna2tbNameD.Animated = True
        Me.Guna2tbNameD.BorderColor = System.Drawing.Color.Black
        Me.Guna2tbNameD.BorderRadius = 7
        Me.Guna2tbNameD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2tbNameD.DefaultText = ""
        Me.Guna2tbNameD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2tbNameD.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2tbNameD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2tbNameD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2tbNameD.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2tbNameD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2tbNameD.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!)
        Me.Guna2tbNameD.ForeColor = System.Drawing.Color.Black
        Me.Guna2tbNameD.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2tbNameD.Location = New System.Drawing.Point(65, 86)
        Me.Guna2tbNameD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2tbNameD.Name = "Guna2tbNameD"
        Me.Guna2tbNameD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2tbNameD.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2tbNameD.PlaceholderText = "Departamento"
        Me.Guna2tbNameD.SelectedText = ""
        Me.Guna2tbNameD.Size = New System.Drawing.Size(300, 36)
        Me.Guna2tbNameD.TabIndex = 35
        '
        'Guna2TxtDescripcionD
        '
        Me.Guna2TxtDescripcionD.Animated = True
        Me.Guna2TxtDescripcionD.BorderColor = System.Drawing.Color.Black
        Me.Guna2TxtDescripcionD.BorderRadius = 7
        Me.Guna2TxtDescripcionD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TxtDescripcionD.DefaultText = ""
        Me.Guna2TxtDescripcionD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TxtDescripcionD.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TxtDescripcionD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtDescripcionD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtDescripcionD.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TxtDescripcionD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtDescripcionD.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!)
        Me.Guna2TxtDescripcionD.ForeColor = System.Drawing.Color.Black
        Me.Guna2TxtDescripcionD.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtDescripcionD.Location = New System.Drawing.Point(65, 130)
        Me.Guna2TxtDescripcionD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtDescripcionD.Multiline = True
        Me.Guna2TxtDescripcionD.Name = "Guna2TxtDescripcionD"
        Me.Guna2TxtDescripcionD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtDescripcionD.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtDescripcionD.PlaceholderText = "Descripción"
        Me.Guna2TxtDescripcionD.SelectedText = ""
        Me.Guna2TxtDescripcionD.Size = New System.Drawing.Size(300, 138)
        Me.Guna2TxtDescripcionD.TabIndex = 36
        '
        'Guna2btnGuardar
        '
        Me.Guna2btnGuardar.Animated = True
        Me.Guna2btnGuardar.BorderRadius = 7
        Me.Guna2btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2btnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2btnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2btnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2btnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2btnGuardar.FillColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2btnGuardar.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.25!)
        Me.Guna2btnGuardar.ForeColor = System.Drawing.Color.White
        Me.Guna2btnGuardar.Location = New System.Drawing.Point(451, 151)
        Me.Guna2btnGuardar.Name = "Guna2btnGuardar"
        Me.Guna2btnGuardar.Size = New System.Drawing.Size(170, 35)
        Me.Guna2btnGuardar.TabIndex = 37
        Me.Guna2btnGuardar.Text = "Guardar"
        '
        'Guna2btnEditar
        '
        Me.Guna2btnEditar.Animated = True
        Me.Guna2btnEditar.BorderRadius = 7
        Me.Guna2btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2btnEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2btnEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2btnEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2btnEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2btnEditar.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Guna2btnEditar.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.25!)
        Me.Guna2btnEditar.ForeColor = System.Drawing.Color.White
        Me.Guna2btnEditar.Location = New System.Drawing.Point(451, 192)
        Me.Guna2btnEditar.Name = "Guna2btnEditar"
        Me.Guna2btnEditar.Size = New System.Drawing.Size(170, 35)
        Me.Guna2btnEditar.TabIndex = 38
        Me.Guna2btnEditar.Text = "Editar"
        '
        'Guna2btnBorrar
        '
        Me.Guna2btnBorrar.Animated = True
        Me.Guna2btnBorrar.BorderRadius = 7
        Me.Guna2btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2btnBorrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2btnBorrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2btnBorrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2btnBorrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2btnBorrar.FillColor = System.Drawing.Color.Brown
        Me.Guna2btnBorrar.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.25!)
        Me.Guna2btnBorrar.ForeColor = System.Drawing.Color.White
        Me.Guna2btnBorrar.Location = New System.Drawing.Point(451, 233)
        Me.Guna2btnBorrar.Name = "Guna2btnBorrar"
        Me.Guna2btnBorrar.Size = New System.Drawing.Size(170, 35)
        Me.Guna2btnBorrar.TabIndex = 39
        Me.Guna2btnBorrar.Text = "Eliminar"
        '
        'Guna2btnCancelar
        '
        Me.Guna2btnCancelar.Animated = True
        Me.Guna2btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.Guna2btnCancelar.BackgroundImage = CType(resources.GetObject("Guna2btnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.Guna2btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2btnCancelar.DisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2btnCancelar.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2btnCancelar.DisabledState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.Guna2btnCancelar.FillColor = System.Drawing.Color.Transparent
        Me.Guna2btnCancelar.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.25!)
        Me.Guna2btnCancelar.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2btnCancelar.ImageSize = New System.Drawing.Size(54, 54)
        Me.Guna2btnCancelar.Location = New System.Drawing.Point(557, 86)
        Me.Guna2btnCancelar.Name = "Guna2btnCancelar"
        Me.Guna2btnCancelar.Size = New System.Drawing.Size(54, 54)
        Me.Guna2btnCancelar.TabIndex = 40
        '
        'Guna2btnNuevo
        '
        Me.Guna2btnNuevo.Animated = True
        Me.Guna2btnNuevo.AutoRoundedCorners = True
        Me.Guna2btnNuevo.BackColor = System.Drawing.Color.Transparent
        Me.Guna2btnNuevo.BackgroundImage = CType(resources.GetObject("Guna2btnNuevo.BackgroundImage"), System.Drawing.Image)
        Me.Guna2btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2btnNuevo.BorderRadius = 31
        Me.Guna2btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2btnNuevo.DisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2btnNuevo.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2btnNuevo.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2btnNuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2btnNuevo.DisabledState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.Guna2btnNuevo.FillColor = System.Drawing.Color.Transparent
        Me.Guna2btnNuevo.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.25!)
        Me.Guna2btnNuevo.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2btnNuevo.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2btnNuevo.Location = New System.Drawing.Point(456, 79)
        Me.Guna2btnNuevo.Name = "Guna2btnNuevo"
        Me.Guna2btnNuevo.Size = New System.Drawing.Size(64, 64)
        Me.Guna2btnNuevo.TabIndex = 41
        '
        'frmDepartamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(712, 568)
        Me.Controls.Add(Me.Guna2btnNuevo)
        Me.Controls.Add(Me.Guna2btnCancelar)
        Me.Controls.Add(Me.Guna2btnBorrar)
        Me.Controls.Add(Me.Guna2btnEditar)
        Me.Controls.Add(Me.Guna2btnGuardar)
        Me.Controls.Add(Me.Guna2TxtDescripcionD)
        Me.Controls.Add(Me.Guna2tbNameD)
        Me.Controls.Add(Me.Guna2btnExit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtId)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmDepartamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Departamentos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Guna2DgbDepartamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtId As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2btnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2tbNameD As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TxtDescripcionD As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2btnGuardar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2btnEditar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2btnBorrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2btnCancelar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2btnNuevo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2txtBuscar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2DgbDepartamentos As Guna.UI2.WinForms.Guna2DataGridView
End Class
