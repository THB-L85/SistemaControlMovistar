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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistroAltasPortabilidades))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2btnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2tbNameP = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TxtNumero = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2cbEstado = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2btnBorrar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2btnEditar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2btnGuardar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2btnCancelar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2btnNuevo = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2DgbPortabilidades = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2txtBuscar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2DgbPortabilidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(65, 182)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(75, 20)
        Me.TxtId.TabIndex = 34
        Me.TxtId.Visible = False
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
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
        Me.Guna2btnExit.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(299, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 24)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Portabilidades"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(712, 20)
        Me.Guna2Panel1.TabIndex = 38
        '
        'Guna2tbNameP
        '
        Me.Guna2tbNameP.Animated = True
        Me.Guna2tbNameP.BorderColor = System.Drawing.Color.Black
        Me.Guna2tbNameP.BorderRadius = 7
        Me.Guna2tbNameP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2tbNameP.DefaultText = ""
        Me.Guna2tbNameP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2tbNameP.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2tbNameP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2tbNameP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2tbNameP.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2tbNameP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2tbNameP.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!)
        Me.Guna2tbNameP.ForeColor = System.Drawing.Color.Black
        Me.Guna2tbNameP.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2tbNameP.Location = New System.Drawing.Point(65, 86)
        Me.Guna2tbNameP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2tbNameP.Name = "Guna2tbNameP"
        Me.Guna2tbNameP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2tbNameP.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2tbNameP.PlaceholderText = "Nombre del Promotor"
        Me.Guna2tbNameP.SelectedText = ""
        Me.Guna2tbNameP.Size = New System.Drawing.Size(300, 36)
        Me.Guna2tbNameP.TabIndex = 41
        '
        'Guna2TxtNumero
        '
        Me.Guna2TxtNumero.Animated = True
        Me.Guna2TxtNumero.BorderColor = System.Drawing.Color.Black
        Me.Guna2TxtNumero.BorderRadius = 7
        Me.Guna2TxtNumero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TxtNumero.DefaultText = ""
        Me.Guna2TxtNumero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TxtNumero.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TxtNumero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtNumero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtNumero.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TxtNumero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtNumero.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!)
        Me.Guna2TxtNumero.ForeColor = System.Drawing.Color.Black
        Me.Guna2TxtNumero.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtNumero.Location = New System.Drawing.Point(65, 130)
        Me.Guna2TxtNumero.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtNumero.Name = "Guna2TxtNumero"
        Me.Guna2TxtNumero.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtNumero.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtNumero.PlaceholderText = "Número a Portar"
        Me.Guna2TxtNumero.SelectedText = ""
        Me.Guna2TxtNumero.Size = New System.Drawing.Size(300, 36)
        Me.Guna2TxtNumero.TabIndex = 42
        '
        'Guna2cbEstado
        '
        Me.Guna2cbEstado.BackColor = System.Drawing.Color.Transparent
        Me.Guna2cbEstado.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2cbEstado.BorderRadius = 7
        Me.Guna2cbEstado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2cbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2cbEstado.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2cbEstado.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2cbEstado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2cbEstado.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.25!)
        Me.Guna2cbEstado.ForeColor = System.Drawing.Color.Black
        Me.Guna2cbEstado.ItemHeight = 30
        Me.Guna2cbEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.Guna2cbEstado.Location = New System.Drawing.Point(215, 173)
        Me.Guna2cbEstado.Name = "Guna2cbEstado"
        Me.Guna2cbEstado.Size = New System.Drawing.Size(150, 36)
        Me.Guna2cbEstado.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(148, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 21)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Estado:"
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
        Me.Guna2btnBorrar.TabIndex = 51
        Me.Guna2btnBorrar.Text = "Eliminar"
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
        Me.Guna2btnEditar.TabIndex = 50
        Me.Guna2btnEditar.Text = "Editar"
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
        Me.Guna2btnGuardar.TabIndex = 49
        Me.Guna2btnGuardar.Text = "Guardar"
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
        Me.Guna2btnCancelar.DisabledState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.Guna2btnCancelar.FillColor = System.Drawing.Color.Transparent
        Me.Guna2btnCancelar.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.25!)
        Me.Guna2btnCancelar.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2btnCancelar.ImageSize = New System.Drawing.Size(54, 54)
        Me.Guna2btnCancelar.Location = New System.Drawing.Point(557, 86)
        Me.Guna2btnCancelar.Name = "Guna2btnCancelar"
        Me.Guna2btnCancelar.Size = New System.Drawing.Size(54, 54)
        Me.Guna2btnCancelar.TabIndex = 48
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
        Me.Guna2btnNuevo.DisabledState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.Guna2btnNuevo.FillColor = System.Drawing.Color.Transparent
        Me.Guna2btnNuevo.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.25!)
        Me.Guna2btnNuevo.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2btnNuevo.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2btnNuevo.Location = New System.Drawing.Point(456, 79)
        Me.Guna2btnNuevo.Name = "Guna2btnNuevo"
        Me.Guna2btnNuevo.Size = New System.Drawing.Size(64, 64)
        Me.Guna2btnNuevo.TabIndex = 47
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Guna2DgbPortabilidades)
        Me.Panel1.Controls.Add(Me.Guna2txtBuscar)
        Me.Panel1.Controls.Add(Me.LblTotal)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(48, 287)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(616, 269)
        Me.Panel1.TabIndex = 52
        '
        'Guna2DgbPortabilidades
        '
        Me.Guna2DgbPortabilidades.AllowUserToAddRows = False
        Me.Guna2DgbPortabilidades.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Guna2DgbPortabilidades.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.Guna2DgbPortabilidades.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Guna2DgbPortabilidades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DgbPortabilidades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.Guna2DgbPortabilidades.ColumnHeadersHeight = 40
        Me.Guna2DgbPortabilidades.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DgbPortabilidades.DefaultCellStyle = DataGridViewCellStyle11
        Me.Guna2DgbPortabilidades.GridColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Guna2DgbPortabilidades.Location = New System.Drawing.Point(17, 55)
        Me.Guna2DgbPortabilidades.Name = "Guna2DgbPortabilidades"
        Me.Guna2DgbPortabilidades.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DgbPortabilidades.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.Guna2DgbPortabilidades.RowHeadersVisible = False
        Me.Guna2DgbPortabilidades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Guna2DgbPortabilidades.Size = New System.Drawing.Size(581, 190)
        Me.Guna2DgbPortabilidades.TabIndex = 23
        Me.Guna2DgbPortabilidades.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green
        Me.Guna2DgbPortabilidades.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Guna2DgbPortabilidades.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DgbPortabilidades.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DgbPortabilidades.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DgbPortabilidades.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DgbPortabilidades.ThemeStyle.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2DgbPortabilidades.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Guna2DgbPortabilidades.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2DgbPortabilidades.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DgbPortabilidades.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DgbPortabilidades.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DgbPortabilidades.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Guna2DgbPortabilidades.ThemeStyle.HeaderStyle.Height = 40
        Me.Guna2DgbPortabilidades.ThemeStyle.ReadOnly = True
        Me.Guna2DgbPortabilidades.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Guna2DgbPortabilidades.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DgbPortabilidades.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DgbPortabilidades.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.Guna2DgbPortabilidades.ThemeStyle.RowsStyle.Height = 22
        Me.Guna2DgbPortabilidades.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White
        Me.Guna2DgbPortabilidades.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
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
        Me.Guna2txtBuscar.TabIndex = 22
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
        'FrmRegistroAltasPortabilidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(712, 568)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2btnBorrar)
        Me.Controls.Add(Me.Guna2btnEditar)
        Me.Controls.Add(Me.Guna2btnGuardar)
        Me.Controls.Add(Me.Guna2btnCancelar)
        Me.Controls.Add(Me.Guna2btnNuevo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Guna2cbEstado)
        Me.Controls.Add(Me.Guna2TxtNumero)
        Me.Controls.Add(Me.Guna2tbNameP)
        Me.Controls.Add(Me.Guna2btnExit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.TxtId)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmRegistroAltasPortabilidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmRegistroAltasPortabilidades"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Guna2DgbPortabilidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtId As TextBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2btnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2tbNameP As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TxtNumero As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2cbEstado As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2btnBorrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2btnEditar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2btnGuardar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2btnCancelar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2btnNuevo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2DgbPortabilidades As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2txtBuscar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblTotal As Label
    Friend WithEvents Label3 As Label
End Class
