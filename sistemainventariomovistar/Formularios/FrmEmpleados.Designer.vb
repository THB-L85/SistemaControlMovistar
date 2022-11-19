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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpleados))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2BtnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2TxtNombreC = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TxtTelefono = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TxtCurp = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Correo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TxtDireccion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2CboGenero = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2CboDepto = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Guna2CboPuesto = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2BtnNuevo = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnCancelar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnGuardar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BntEditar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnBorrar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2TxtBuscar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2RbNombreC = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RbCurp = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RbDepto = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2DgbEmpleados = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Guna2BtnDepto = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnPuesto = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2DgbEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(393, 70)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(32, 20)
        Me.TxtId.TabIndex = 34
        Me.TxtId.Visible = False
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 345)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Empleados Registrados"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(157, 345)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(35, 17)
        Me.LblTotal.TabIndex = 19
        Me.LblTotal.Text = "Total"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Guna2DgbEmpleados)
        Me.Panel1.Controls.Add(Me.Guna2RbDepto)
        Me.Panel1.Controls.Add(Me.Guna2RbCurp)
        Me.Panel1.Controls.Add(Me.Guna2RbNombreC)
        Me.Panel1.Controls.Add(Me.Guna2TxtBuscar)
        Me.Panel1.Controls.Add(Me.LblTotal)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(50, 260)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(933, 371)
        Me.Panel1.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(427, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 24)
        Me.Label6.TabIndex = 137
        Me.Label6.Text = "Registro de Empleados"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1027, 20)
        Me.Panel2.TabIndex = 136
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
        Me.Guna2BtnExit.TabIndex = 138
        '
        'Guna2TxtNombreC
        '
        Me.Guna2TxtNombreC.Animated = True
        Me.Guna2TxtNombreC.BorderColor = System.Drawing.Color.Black
        Me.Guna2TxtNombreC.BorderRadius = 7
        Me.Guna2TxtNombreC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TxtNombreC.DefaultText = ""
        Me.Guna2TxtNombreC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TxtNombreC.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TxtNombreC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtNombreC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtNombreC.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TxtNombreC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtNombreC.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.Guna2TxtNombreC.ForeColor = System.Drawing.Color.Black
        Me.Guna2TxtNombreC.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtNombreC.Location = New System.Drawing.Point(51, 102)
        Me.Guna2TxtNombreC.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtNombreC.Name = "Guna2TxtNombreC"
        Me.Guna2TxtNombreC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtNombreC.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtNombreC.PlaceholderText = "Nombre Completo"
        Me.Guna2TxtNombreC.SelectedText = ""
        Me.Guna2TxtNombreC.Size = New System.Drawing.Size(225, 36)
        Me.Guna2TxtNombreC.TabIndex = 139
        '
        'Guna2TxtTelefono
        '
        Me.Guna2TxtTelefono.Animated = True
        Me.Guna2TxtTelefono.BorderColor = System.Drawing.Color.Black
        Me.Guna2TxtTelefono.BorderRadius = 7
        Me.Guna2TxtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TxtTelefono.DefaultText = ""
        Me.Guna2TxtTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TxtTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TxtTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtTelefono.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TxtTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtTelefono.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.Guna2TxtTelefono.ForeColor = System.Drawing.Color.Black
        Me.Guna2TxtTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtTelefono.Location = New System.Drawing.Point(305, 146)
        Me.Guna2TxtTelefono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtTelefono.Name = "Guna2TxtTelefono"
        Me.Guna2TxtTelefono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtTelefono.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtTelefono.PlaceholderText = "Teléfono"
        Me.Guna2TxtTelefono.SelectedText = ""
        Me.Guna2TxtTelefono.Size = New System.Drawing.Size(184, 36)
        Me.Guna2TxtTelefono.TabIndex = 140
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
        Me.Guna2TxtCurp.Location = New System.Drawing.Point(51, 146)
        Me.Guna2TxtCurp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtCurp.Name = "Guna2TxtCurp"
        Me.Guna2TxtCurp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtCurp.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtCurp.PlaceholderText = "Curp"
        Me.Guna2TxtCurp.SelectedText = ""
        Me.Guna2TxtCurp.Size = New System.Drawing.Size(225, 36)
        Me.Guna2TxtCurp.TabIndex = 141
        '
        'Guna2Correo
        '
        Me.Guna2Correo.Animated = True
        Me.Guna2Correo.BorderColor = System.Drawing.Color.Black
        Me.Guna2Correo.BorderRadius = 7
        Me.Guna2Correo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Correo.DefaultText = ""
        Me.Guna2Correo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2Correo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2Correo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2Correo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2Correo.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2Correo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Correo.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.Guna2Correo.ForeColor = System.Drawing.Color.Black
        Me.Guna2Correo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Correo.Location = New System.Drawing.Point(305, 102)
        Me.Guna2Correo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2Correo.Name = "Guna2Correo"
        Me.Guna2Correo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2Correo.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2Correo.PlaceholderText = "Correo"
        Me.Guna2Correo.SelectedText = ""
        Me.Guna2Correo.Size = New System.Drawing.Size(184, 36)
        Me.Guna2Correo.TabIndex = 142
        '
        'Guna2TxtDireccion
        '
        Me.Guna2TxtDireccion.Animated = True
        Me.Guna2TxtDireccion.BorderColor = System.Drawing.Color.Black
        Me.Guna2TxtDireccion.BorderRadius = 7
        Me.Guna2TxtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TxtDireccion.DefaultText = ""
        Me.Guna2TxtDireccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TxtDireccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TxtDireccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtDireccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtDireccion.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TxtDireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtDireccion.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!)
        Me.Guna2TxtDireccion.ForeColor = System.Drawing.Color.Black
        Me.Guna2TxtDireccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtDireccion.Location = New System.Drawing.Point(51, 194)
        Me.Guna2TxtDireccion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtDireccion.Multiline = True
        Me.Guna2TxtDireccion.Name = "Guna2TxtDireccion"
        Me.Guna2TxtDireccion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtDireccion.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtDireccion.PlaceholderText = "Dirección"
        Me.Guna2TxtDireccion.SelectedText = ""
        Me.Guna2TxtDireccion.Size = New System.Drawing.Size(438, 36)
        Me.Guna2TxtDireccion.TabIndex = 143
        '
        'Guna2CboGenero
        '
        Me.Guna2CboGenero.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CboGenero.BorderColor = System.Drawing.Color.Black
        Me.Guna2CboGenero.BorderRadius = 7
        Me.Guna2CboGenero.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2CboGenero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2CboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2CboGenero.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2CboGenero.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CboGenero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CboGenero.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2CboGenero.ForeColor = System.Drawing.Color.Black
        Me.Guna2CboGenero.ItemHeight = 30
        Me.Guna2CboGenero.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.Guna2CboGenero.Location = New System.Drawing.Point(569, 99)
        Me.Guna2CboGenero.Name = "Guna2CboGenero"
        Me.Guna2CboGenero.Size = New System.Drawing.Size(156, 36)
        Me.Guna2CboGenero.TabIndex = 143
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(500, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 21)
        Me.Label7.TabIndex = 146
        Me.Label7.Text = "Genero:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(508, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 21)
        Me.Label8.TabIndex = 147
        Me.Label8.Text = "Depto:"
        '
        'Guna2CboDepto
        '
        Me.Guna2CboDepto.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CboDepto.BorderColor = System.Drawing.Color.Black
        Me.Guna2CboDepto.BorderRadius = 7
        Me.Guna2CboDepto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2CboDepto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2CboDepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2CboDepto.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2CboDepto.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CboDepto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CboDepto.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2CboDepto.ForeColor = System.Drawing.Color.Black
        Me.Guna2CboDepto.ItemHeight = 30
        Me.Guna2CboDepto.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.Guna2CboDepto.Location = New System.Drawing.Point(569, 148)
        Me.Guna2CboDepto.Name = "Guna2CboDepto"
        Me.Guna2CboDepto.Size = New System.Drawing.Size(156, 36)
        Me.Guna2CboDepto.TabIndex = 148
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(502, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 21)
        Me.Label9.TabIndex = 149
        Me.Label9.Text = "Puesto:"
        '
        'Guna2CboPuesto
        '
        Me.Guna2CboPuesto.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CboPuesto.BorderColor = System.Drawing.Color.Black
        Me.Guna2CboPuesto.BorderRadius = 7
        Me.Guna2CboPuesto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2CboPuesto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2CboPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2CboPuesto.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2CboPuesto.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CboPuesto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CboPuesto.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2CboPuesto.ForeColor = System.Drawing.Color.Black
        Me.Guna2CboPuesto.ItemHeight = 30
        Me.Guna2CboPuesto.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.Guna2CboPuesto.Location = New System.Drawing.Point(569, 194)
        Me.Guna2CboPuesto.Name = "Guna2CboPuesto"
        Me.Guna2CboPuesto.Size = New System.Drawing.Size(156, 36)
        Me.Guna2CboPuesto.TabIndex = 150
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
        Me.Guna2BtnNuevo.Location = New System.Drawing.Point(804, 75)
        Me.Guna2BtnNuevo.Name = "Guna2BtnNuevo"
        Me.Guna2BtnNuevo.Size = New System.Drawing.Size(54, 54)
        Me.Guna2BtnNuevo.TabIndex = 151
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
        Me.Guna2BtnCancelar.Location = New System.Drawing.Point(883, 81)
        Me.Guna2BtnCancelar.Name = "Guna2BtnCancelar"
        Me.Guna2BtnCancelar.Size = New System.Drawing.Size(45, 45)
        Me.Guna2BtnCancelar.TabIndex = 152
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
        Me.Guna2BtnGuardar.Location = New System.Drawing.Point(798, 136)
        Me.Guna2BtnGuardar.Name = "Guna2BtnGuardar"
        Me.Guna2BtnGuardar.Size = New System.Drawing.Size(141, 35)
        Me.Guna2BtnGuardar.TabIndex = 153
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
        Me.Guna2BntEditar.Location = New System.Drawing.Point(798, 175)
        Me.Guna2BntEditar.Name = "Guna2BntEditar"
        Me.Guna2BntEditar.Size = New System.Drawing.Size(141, 35)
        Me.Guna2BntEditar.TabIndex = 154
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
        Me.Guna2BtnBorrar.Location = New System.Drawing.Point(798, 216)
        Me.Guna2BtnBorrar.Name = "Guna2BtnBorrar"
        Me.Guna2BtnBorrar.Size = New System.Drawing.Size(141, 35)
        Me.Guna2BtnBorrar.TabIndex = 155
        Me.Guna2BtnBorrar.Text = "Eliminar"
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
        'Guna2RbNombreC
        '
        Me.Guna2RbNombreC.Animated = True
        Me.Guna2RbNombreC.AutoSize = True
        Me.Guna2RbNombreC.Checked = True
        Me.Guna2RbNombreC.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RbNombreC.CheckedState.BorderThickness = 0
        Me.Guna2RbNombreC.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RbNombreC.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RbNombreC.CheckedState.InnerOffset = -4
        Me.Guna2RbNombreC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2RbNombreC.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!)
        Me.Guna2RbNombreC.Location = New System.Drawing.Point(523, 12)
        Me.Guna2RbNombreC.Name = "Guna2RbNombreC"
        Me.Guna2RbNombreC.Size = New System.Drawing.Size(116, 20)
        Me.Guna2RbNombreC.TabIndex = 137
        Me.Guna2RbNombreC.Text = "Nombre Completo"
        Me.Guna2RbNombreC.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RbNombreC.UncheckedState.BorderThickness = 2
        Me.Guna2RbNombreC.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RbNombreC.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Guna2RbCurp
        '
        Me.Guna2RbCurp.Animated = True
        Me.Guna2RbCurp.AutoSize = True
        Me.Guna2RbCurp.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RbCurp.CheckedState.BorderThickness = 0
        Me.Guna2RbCurp.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RbCurp.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RbCurp.CheckedState.InnerOffset = -4
        Me.Guna2RbCurp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2RbCurp.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!)
        Me.Guna2RbCurp.Location = New System.Drawing.Point(654, 12)
        Me.Guna2RbCurp.Name = "Guna2RbCurp"
        Me.Guna2RbCurp.Size = New System.Drawing.Size(49, 20)
        Me.Guna2RbCurp.TabIndex = 138
        Me.Guna2RbCurp.Text = "Curp"
        Me.Guna2RbCurp.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RbCurp.UncheckedState.BorderThickness = 2
        Me.Guna2RbCurp.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RbCurp.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Guna2RbDepto
        '
        Me.Guna2RbDepto.Animated = True
        Me.Guna2RbDepto.AutoSize = True
        Me.Guna2RbDepto.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RbDepto.CheckedState.BorderThickness = 0
        Me.Guna2RbDepto.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RbDepto.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RbDepto.CheckedState.InnerOffset = -4
        Me.Guna2RbDepto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2RbDepto.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!)
        Me.Guna2RbDepto.Location = New System.Drawing.Point(723, 12)
        Me.Guna2RbDepto.Name = "Guna2RbDepto"
        Me.Guna2RbDepto.Size = New System.Drawing.Size(98, 20)
        Me.Guna2RbDepto.TabIndex = 139
        Me.Guna2RbDepto.Text = "Departamento"
        Me.Guna2RbDepto.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RbDepto.UncheckedState.BorderThickness = 2
        Me.Guna2RbDepto.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RbDepto.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Guna2DgbEmpleados
        '
        Me.Guna2DgbEmpleados.AllowUserToAddRows = False
        Me.Guna2DgbEmpleados.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Guna2DgbEmpleados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Guna2DgbEmpleados.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Guna2DgbEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DgbEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Guna2DgbEmpleados.ColumnHeadersHeight = 40
        Me.Guna2DgbEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DgbEmpleados.DefaultCellStyle = DataGridViewCellStyle6
        Me.Guna2DgbEmpleados.GridColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Guna2DgbEmpleados.Location = New System.Drawing.Point(1, 51)
        Me.Guna2DgbEmpleados.Name = "Guna2DgbEmpleados"
        Me.Guna2DgbEmpleados.ReadOnly = True
        Me.Guna2DgbEmpleados.RowHeadersVisible = False
        Me.Guna2DgbEmpleados.Size = New System.Drawing.Size(926, 286)
        Me.Guna2DgbEmpleados.TabIndex = 140
        Me.Guna2DgbEmpleados.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green
        Me.Guna2DgbEmpleados.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Guna2DgbEmpleados.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DgbEmpleados.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DgbEmpleados.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DgbEmpleados.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DgbEmpleados.ThemeStyle.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2DgbEmpleados.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Guna2DgbEmpleados.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2DgbEmpleados.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DgbEmpleados.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DgbEmpleados.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DgbEmpleados.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Guna2DgbEmpleados.ThemeStyle.HeaderStyle.Height = 40
        Me.Guna2DgbEmpleados.ThemeStyle.ReadOnly = True
        Me.Guna2DgbEmpleados.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Guna2DgbEmpleados.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DgbEmpleados.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DgbEmpleados.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.Guna2DgbEmpleados.ThemeStyle.RowsStyle.Height = 22
        Me.Guna2DgbEmpleados.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White
        Me.Guna2DgbEmpleados.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 20
        Me.Guna2Elipse2.TargetControl = Me.Guna2DgbEmpleados
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(431, 63)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(80, 32)
        Me.BtnBuscar.TabIndex = 43
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        Me.BtnBuscar.Visible = False
        '
        'Guna2BtnDepto
        '
        Me.Guna2BtnDepto.Animated = True
        Me.Guna2BtnDepto.BorderRadius = 7
        Me.Guna2BtnDepto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2BtnDepto.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnDepto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnDepto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2BtnDepto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2BtnDepto.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2BtnDepto.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!)
        Me.Guna2BtnDepto.ForeColor = System.Drawing.Color.Black
        Me.Guna2BtnDepto.Location = New System.Drawing.Point(731, 148)
        Me.Guna2BtnDepto.Name = "Guna2BtnDepto"
        Me.Guna2BtnDepto.Size = New System.Drawing.Size(42, 36)
        Me.Guna2BtnDepto.TabIndex = 156
        Me.Guna2BtnDepto.Text = "..."
        '
        'Guna2BtnPuesto
        '
        Me.Guna2BtnPuesto.Animated = True
        Me.Guna2BtnPuesto.BorderRadius = 7
        Me.Guna2BtnPuesto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2BtnPuesto.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnPuesto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnPuesto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2BtnPuesto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2BtnPuesto.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2BtnPuesto.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!)
        Me.Guna2BtnPuesto.ForeColor = System.Drawing.Color.Black
        Me.Guna2BtnPuesto.Location = New System.Drawing.Point(731, 194)
        Me.Guna2BtnPuesto.Name = "Guna2BtnPuesto"
        Me.Guna2BtnPuesto.Size = New System.Drawing.Size(42, 36)
        Me.Guna2BtnPuesto.TabIndex = 157
        Me.Guna2BtnPuesto.Text = "..."
        '
        'FrmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1027, 661)
        Me.Controls.Add(Me.Guna2BtnPuesto)
        Me.Controls.Add(Me.Guna2BtnDepto)
        Me.Controls.Add(Me.Guna2BtnBorrar)
        Me.Controls.Add(Me.Guna2BntEditar)
        Me.Controls.Add(Me.Guna2BtnGuardar)
        Me.Controls.Add(Me.Guna2BtnCancelar)
        Me.Controls.Add(Me.Guna2BtnNuevo)
        Me.Controls.Add(Me.Guna2CboPuesto)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Guna2TxtDireccion)
        Me.Controls.Add(Me.Guna2CboDepto)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Guna2CboGenero)
        Me.Controls.Add(Me.Guna2Correo)
        Me.Controls.Add(Me.Guna2TxtCurp)
        Me.Controls.Add(Me.Guna2TxtTelefono)
        Me.Controls.Add(Me.Guna2TxtNombreC)
        Me.Controls.Add(Me.Guna2BtnExit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Empleados"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Guna2DgbEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtId As TextBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2BtnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TxtNombreC As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Correo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TxtCurp As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TxtTelefono As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TxtDireccion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2CboGenero As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2CboDepto As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2CboPuesto As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Guna2BtnNuevo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BtnCancelar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BtnBorrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BntEditar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BtnGuardar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TxtBuscar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2RbNombreC As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RbDepto As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RbCurp As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2DgbEmpleados As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Guna2BtnPuesto As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BtnDepto As Guna.UI2.WinForms.Guna2Button
End Class
