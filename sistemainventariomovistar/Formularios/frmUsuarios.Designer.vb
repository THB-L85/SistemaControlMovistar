<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2dtgUsuario = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DgbUsuarios = New System.Windows.Forms.DataGridView()
        Me.IdUsuarios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPOUSUARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2btnNew = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2cbState = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2cbType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2tbPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2tbUser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Guna2tbName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2btnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2dtgUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgbUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Guna2txtSearch)
        Me.Panel1.Controls.Add(Me.Guna2dtgUsuario)
        Me.Panel1.Controls.Add(Me.LblTotal)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DgbUsuarios)
        Me.Panel1.Location = New System.Drawing.Point(48, 325)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(616, 271)
        Me.Panel1.TabIndex = 16
        '
        'Guna2txtSearch
        '
        Me.Guna2txtSearch.Animated = True
        Me.Guna2txtSearch.BorderRadius = 7
        Me.Guna2txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2txtSearch.DefaultText = ""
        Me.Guna2txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2txtSearch.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2txtSearch.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!)
        Me.Guna2txtSearch.ForeColor = System.Drawing.Color.Black
        Me.Guna2txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2txtSearch.IconLeft = CType(resources.GetObject("Guna2txtSearch.IconLeft"), System.Drawing.Image)
        Me.Guna2txtSearch.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.Guna2txtSearch.Location = New System.Drawing.Point(17, 11)
        Me.Guna2txtSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2txtSearch.Name = "Guna2txtSearch"
        Me.Guna2txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2txtSearch.PlaceholderText = ""
        Me.Guna2txtSearch.SelectedText = ""
        Me.Guna2txtSearch.Size = New System.Drawing.Size(283, 36)
        Me.Guna2txtSearch.TabIndex = 20
        '
        'Guna2dtgUsuario
        '
        Me.Guna2dtgUsuario.AllowUserToAddRows = False
        Me.Guna2dtgUsuario.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Guna2dtgUsuario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Guna2dtgUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
        Me.Guna2dtgUsuario.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Guna2dtgUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2dtgUsuario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2dtgUsuario.ColumnHeadersHeight = 40
        Me.Guna2dtgUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2dtgUsuario.DefaultCellStyle = DataGridViewCellStyle3
        Me.Guna2dtgUsuario.GridColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Guna2dtgUsuario.Location = New System.Drawing.Point(17, 54)
        Me.Guna2dtgUsuario.Name = "Guna2dtgUsuario"
        Me.Guna2dtgUsuario.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2dtgUsuario.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Guna2dtgUsuario.RowHeadersVisible = False
        Me.Guna2dtgUsuario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Guna2dtgUsuario.Size = New System.Drawing.Size(581, 183)
        Me.Guna2dtgUsuario.TabIndex = 19
        Me.Guna2dtgUsuario.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green
        Me.Guna2dtgUsuario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Guna2dtgUsuario.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2dtgUsuario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2dtgUsuario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2dtgUsuario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2dtgUsuario.ThemeStyle.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2dtgUsuario.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Guna2dtgUsuario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2dtgUsuario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2dtgUsuario.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2dtgUsuario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2dtgUsuario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Guna2dtgUsuario.ThemeStyle.HeaderStyle.Height = 40
        Me.Guna2dtgUsuario.ThemeStyle.ReadOnly = True
        Me.Guna2dtgUsuario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Guna2dtgUsuario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2dtgUsuario.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2dtgUsuario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.Guna2dtgUsuario.ThemeStyle.RowsStyle.Height = 22
        Me.Guna2dtgUsuario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White
        Me.Guna2dtgUsuario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(399, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Usuarios Registrados"
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
        Me.DgbUsuarios.Size = New System.Drawing.Size(581, 121)
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
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(712, 20)
        Me.Guna2Panel1.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(274, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 24)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Registro de Usuarios"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Guna2btnSave
        '
        Me.Guna2btnSave.Animated = True
        Me.Guna2btnSave.BorderRadius = 7
        Me.Guna2btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2btnSave.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.25!)
        Me.Guna2btnSave.ForeColor = System.Drawing.Color.White
        Me.Guna2btnSave.Location = New System.Drawing.Point(451, 151)
        Me.Guna2btnSave.Name = "Guna2btnSave"
        Me.Guna2btnSave.Size = New System.Drawing.Size(170, 35)
        Me.Guna2btnSave.TabIndex = 28
        Me.Guna2btnSave.Text = "Guardar"
        '
        'Guna2btnDelete
        '
        Me.Guna2btnDelete.Animated = True
        Me.Guna2btnDelete.BorderRadius = 7
        Me.Guna2btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2btnDelete.FillColor = System.Drawing.Color.Brown
        Me.Guna2btnDelete.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.25!)
        Me.Guna2btnDelete.ForeColor = System.Drawing.Color.White
        Me.Guna2btnDelete.Location = New System.Drawing.Point(451, 233)
        Me.Guna2btnDelete.Name = "Guna2btnDelete"
        Me.Guna2btnDelete.Size = New System.Drawing.Size(170, 35)
        Me.Guna2btnDelete.TabIndex = 29
        Me.Guna2btnDelete.Text = "Eliminar"
        '
        'Guna2btnEdit
        '
        Me.Guna2btnEdit.Animated = True
        Me.Guna2btnEdit.BorderRadius = 7
        Me.Guna2btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2btnEdit.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Guna2btnEdit.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.25!)
        Me.Guna2btnEdit.ForeColor = System.Drawing.Color.White
        Me.Guna2btnEdit.Location = New System.Drawing.Point(451, 192)
        Me.Guna2btnEdit.Name = "Guna2btnEdit"
        Me.Guna2btnEdit.Size = New System.Drawing.Size(170, 35)
        Me.Guna2btnEdit.TabIndex = 30
        Me.Guna2btnEdit.Text = "Editar"
        '
        'Guna2btnNew
        '
        Me.Guna2btnNew.Animated = True
        Me.Guna2btnNew.AutoRoundedCorners = True
        Me.Guna2btnNew.BackColor = System.Drawing.Color.Transparent
        Me.Guna2btnNew.BackgroundImage = CType(resources.GetObject("Guna2btnNew.BackgroundImage"), System.Drawing.Image)
        Me.Guna2btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2btnNew.BorderRadius = 31
        Me.Guna2btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2btnNew.DisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2btnNew.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2btnNew.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2btnNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2btnNew.DisabledState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.Guna2btnNew.FillColor = System.Drawing.Color.Transparent
        Me.Guna2btnNew.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.25!)
        Me.Guna2btnNew.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2btnNew.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2btnNew.Location = New System.Drawing.Point(451, 79)
        Me.Guna2btnNew.Name = "Guna2btnNew"
        Me.Guna2btnNew.Size = New System.Drawing.Size(64, 64)
        Me.Guna2btnNew.TabIndex = 31
        '
        'Guna2btnCancel
        '
        Me.Guna2btnCancel.Animated = True
        Me.Guna2btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.Guna2btnCancel.BackgroundImage = CType(resources.GetObject("Guna2btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.Guna2btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2btnCancel.DisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2btnCancel.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2btnCancel.DisabledState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.Guna2btnCancel.FillColor = System.Drawing.Color.Transparent
        Me.Guna2btnCancel.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.25!)
        Me.Guna2btnCancel.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2btnCancel.ImageSize = New System.Drawing.Size(54, 54)
        Me.Guna2btnCancel.Location = New System.Drawing.Point(557, 86)
        Me.Guna2btnCancel.Name = "Guna2btnCancel"
        Me.Guna2btnCancel.Size = New System.Drawing.Size(54, 54)
        Me.Guna2btnCancel.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(82, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 21)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Tipo de Usuario:"
        '
        'Guna2cbState
        '
        Me.Guna2cbState.BackColor = System.Drawing.Color.Transparent
        Me.Guna2cbState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2cbState.BorderRadius = 7
        Me.Guna2cbState.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2cbState.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2cbState.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2cbState.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2cbState.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2cbState.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.25!)
        Me.Guna2cbState.ForeColor = System.Drawing.Color.Black
        Me.Guna2cbState.ItemHeight = 30
        Me.Guna2cbState.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.Guna2cbState.Location = New System.Drawing.Point(215, 258)
        Me.Guna2cbState.Name = "Guna2cbState"
        Me.Guna2cbState.Size = New System.Drawing.Size(150, 36)
        Me.Guna2cbState.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(141, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 21)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Estado:"
        '
        'Guna2cbType
        '
        Me.Guna2cbType.BackColor = System.Drawing.Color.Transparent
        Me.Guna2cbType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2cbType.BorderRadius = 7
        Me.Guna2cbType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2cbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2cbType.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2cbType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2cbType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2cbType.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2cbType.ForeColor = System.Drawing.Color.Black
        Me.Guna2cbType.ItemHeight = 30
        Me.Guna2cbType.Items.AddRange(New Object() {"Administrador", "Invitado"})
        Me.Guna2cbType.Location = New System.Drawing.Point(215, 216)
        Me.Guna2cbType.Name = "Guna2cbType"
        Me.Guna2cbType.Size = New System.Drawing.Size(150, 36)
        Me.Guna2cbType.TabIndex = 24
        '
        'Guna2tbPassword
        '
        Me.Guna2tbPassword.Animated = True
        Me.Guna2tbPassword.BorderColor = System.Drawing.Color.Black
        Me.Guna2tbPassword.BorderRadius = 7
        Me.Guna2tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2tbPassword.DefaultText = ""
        Me.Guna2tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2tbPassword.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2tbPassword.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.Guna2tbPassword.ForeColor = System.Drawing.Color.Black
        Me.Guna2tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2tbPassword.Location = New System.Drawing.Point(65, 171)
        Me.Guna2tbPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2tbPassword.Name = "Guna2tbPassword"
        Me.Guna2tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2tbPassword.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2tbPassword.PlaceholderText = "Contraseña"
        Me.Guna2tbPassword.SelectedText = ""
        Me.Guna2tbPassword.Size = New System.Drawing.Size(300, 36)
        Me.Guna2tbPassword.TabIndex = 23
        '
        'Guna2tbUser
        '
        Me.Guna2tbUser.Animated = True
        Me.Guna2tbUser.BorderColor = System.Drawing.Color.Black
        Me.Guna2tbUser.BorderRadius = 7
        Me.Guna2tbUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2tbUser.DefaultText = ""
        Me.Guna2tbUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2tbUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2tbUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2tbUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2tbUser.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2tbUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2tbUser.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2tbUser.ForeColor = System.Drawing.Color.Black
        Me.Guna2tbUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2tbUser.Location = New System.Drawing.Point(65, 130)
        Me.Guna2tbUser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2tbUser.Name = "Guna2tbUser"
        Me.Guna2tbUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2tbUser.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2tbUser.PlaceholderText = "Usuario"
        Me.Guna2tbUser.SelectedText = ""
        Me.Guna2tbUser.Size = New System.Drawing.Size(300, 36)
        Me.Guna2tbUser.TabIndex = 20
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(82, 264)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(58, 20)
        Me.TxtId.TabIndex = 17
        Me.TxtId.Visible = False
        '
        'Guna2tbName
        '
        Me.Guna2tbName.Animated = True
        Me.Guna2tbName.BorderColor = System.Drawing.Color.Black
        Me.Guna2tbName.BorderRadius = 7
        Me.Guna2tbName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2tbName.DefaultText = ""
        Me.Guna2tbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2tbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2tbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2tbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2tbName.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2tbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2tbName.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!)
        Me.Guna2tbName.ForeColor = System.Drawing.Color.Black
        Me.Guna2tbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2tbName.Location = New System.Drawing.Point(65, 86)
        Me.Guna2tbName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2tbName.Name = "Guna2tbName"
        Me.Guna2tbName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2tbName.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2tbName.PlaceholderText = "Nombre Completo"
        Me.Guna2tbName.SelectedText = ""
        Me.Guna2tbName.Size = New System.Drawing.Size(300, 36)
        Me.Guna2tbName.TabIndex = 19
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
        Me.Guna2btnExit.TabIndex = 33
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(712, 615)
        Me.Controls.Add(Me.Guna2btnExit)
        Me.Controls.Add(Me.Guna2btnCancel)
        Me.Controls.Add(Me.Guna2btnNew)
        Me.Controls.Add(Me.Guna2btnEdit)
        Me.Controls.Add(Me.Guna2btnDelete)
        Me.Controls.Add(Me.Guna2btnSave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Guna2cbState)
        Me.Controls.Add(Me.Guna2cbType)
        Me.Controls.Add(Me.Guna2tbPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2tbUser)
        Me.Controls.Add(Me.Guna2tbName)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de usuarios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Guna2dtgUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgbUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DgbUsuarios As DataGridView
    Friend WithEvents LblTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents IdUsuarios As DataGridViewTextBoxColumn
    Friend WithEvents NombreCompleto As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents Password As DataGridViewTextBoxColumn
    Friend WithEvents TIPOUSUARIO As DataGridViewTextBoxColumn
    Friend WithEvents ESTADO As DataGridViewTextBoxColumn
    Friend WithEvents Guna2dtgUsuario As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2btnNew As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2btnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2cbState As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2cbType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2tbPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2tbUser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2tbName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtId As TextBox
End Class
