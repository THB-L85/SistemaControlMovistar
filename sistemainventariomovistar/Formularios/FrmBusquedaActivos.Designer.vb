<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaActivos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBusquedaActivos))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2BtnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2DgbActivos = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2TxtBuscar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2RbnCodigoA = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RbFecha = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RbNombreE = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2DgbActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Guna2BtnExit.Location = New System.Drawing.Point(22, 15)
        Me.Guna2BtnExit.Name = "Guna2BtnExit"
        Me.Guna2BtnExit.Size = New System.Drawing.Size(45, 45)
        Me.Guna2BtnExit.TabIndex = 153
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(378, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 24)
        Me.Label1.TabIndex = 152
        Me.Label1.Text = "Buscar Activo"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Guna2DgbActivos)
        Me.Panel1.Controls.Add(Me.Guna2TxtBuscar)
        Me.Panel1.Controls.Add(Me.Guna2RbnCodigoA)
        Me.Panel1.Controls.Add(Me.Guna2RbFecha)
        Me.Panel1.Controls.Add(Me.Guna2RbNombreE)
        Me.Panel1.Location = New System.Drawing.Point(51, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(773, 250)
        Me.Panel1.TabIndex = 154
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
        Me.Guna2DgbActivos.Location = New System.Drawing.Point(0, 47)
        Me.Guna2DgbActivos.Name = "Guna2DgbActivos"
        Me.Guna2DgbActivos.ReadOnly = True
        Me.Guna2DgbActivos.RowHeadersVisible = False
        Me.Guna2DgbActivos.Size = New System.Drawing.Size(773, 200)
        Me.Guna2DgbActivos.TabIndex = 27
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
        'Guna2TxtBuscar
        '
        Me.Guna2TxtBuscar.BorderRadius = 7
        Me.Guna2TxtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TxtBuscar.DefaultText = ""
        Me.Guna2TxtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TxtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TxtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TxtBuscar.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TxtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtBuscar.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!)
        Me.Guna2TxtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TxtBuscar.IconLeft = CType(resources.GetObject("Guna2TxtBuscar.IconLeft"), System.Drawing.Image)
        Me.Guna2TxtBuscar.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.Guna2TxtBuscar.Location = New System.Drawing.Point(0, 4)
        Me.Guna2TxtBuscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TxtBuscar.Name = "Guna2TxtBuscar"
        Me.Guna2TxtBuscar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TxtBuscar.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TxtBuscar.PlaceholderText = "Buscar..."
        Me.Guna2TxtBuscar.SelectedText = ""
        Me.Guna2TxtBuscar.Size = New System.Drawing.Size(381, 36)
        Me.Guna2TxtBuscar.TabIndex = 26
        '
        'Guna2RbnCodigoA
        '
        Me.Guna2RbnCodigoA.AutoSize = True
        Me.Guna2RbnCodigoA.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RbnCodigoA.CheckedState.BorderThickness = 0
        Me.Guna2RbnCodigoA.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RbnCodigoA.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RbnCodigoA.CheckedState.InnerOffset = -4
        Me.Guna2RbnCodigoA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2RbnCodigoA.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!)
        Me.Guna2RbnCodigoA.Location = New System.Drawing.Point(642, 10)
        Me.Guna2RbnCodigoA.Name = "Guna2RbnCodigoA"
        Me.Guna2RbnCodigoA.Size = New System.Drawing.Size(116, 20)
        Me.Guna2RbnCodigoA.TabIndex = 25
        Me.Guna2RbnCodigoA.Text = "Código de Artículo"
        Me.Guna2RbnCodigoA.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RbnCodigoA.UncheckedState.BorderThickness = 2
        Me.Guna2RbnCodigoA.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RbnCodigoA.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Guna2RbFecha
        '
        Me.Guna2RbFecha.AutoSize = True
        Me.Guna2RbFecha.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RbFecha.CheckedState.BorderThickness = 0
        Me.Guna2RbFecha.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RbFecha.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RbFecha.CheckedState.InnerOffset = -4
        Me.Guna2RbFecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2RbFecha.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!)
        Me.Guna2RbFecha.Location = New System.Drawing.Point(555, 10)
        Me.Guna2RbFecha.Name = "Guna2RbFecha"
        Me.Guna2RbFecha.Size = New System.Drawing.Size(55, 20)
        Me.Guna2RbFecha.TabIndex = 24
        Me.Guna2RbFecha.Text = "Fecha"
        Me.Guna2RbFecha.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RbFecha.UncheckedState.BorderThickness = 2
        Me.Guna2RbFecha.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RbFecha.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Guna2RbNombreE
        '
        Me.Guna2RbNombreE.AutoSize = True
        Me.Guna2RbNombreE.Checked = True
        Me.Guna2RbNombreE.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RbNombreE.CheckedState.BorderThickness = 0
        Me.Guna2RbNombreE.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RbNombreE.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RbNombreE.CheckedState.InnerOffset = -4
        Me.Guna2RbNombreE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2RbNombreE.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!)
        Me.Guna2RbNombreE.Location = New System.Drawing.Point(410, 10)
        Me.Guna2RbNombreE.Name = "Guna2RbNombreE"
        Me.Guna2RbNombreE.Size = New System.Drawing.Size(133, 20)
        Me.Guna2RbNombreE.TabIndex = 23
        Me.Guna2RbNombreE.TabStop = True
        Me.Guna2RbNombreE.Text = "Nombre de Empleado"
        Me.Guna2RbNombreE.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RbNombreE.UncheckedState.BorderThickness = 2
        Me.Guna2RbNombreE.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RbNombreE.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(193, 320)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(35, 17)
        Me.LblTotal.TabIndex = 156
        Me.LblTotal.Text = "Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 320)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 17)
        Me.Label2.TabIndex = 155
        Me.Label2.Text = "Empleados Registrados"
        '
        'FrmBusquedaActivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(875, 347)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2BtnExit)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmBusquedaActivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBusquedaActivos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Guna2DgbActivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BtnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2DgbActivos As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2TxtBuscar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2RbnCodigoA As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RbFecha As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RbNombreE As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents LblTotal As Label
    Friend WithEvents Label2 As Label
End Class
