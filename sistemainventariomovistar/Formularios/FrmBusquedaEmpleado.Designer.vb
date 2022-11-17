<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBusquedaEmpleado))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RbDepartamento = New System.Windows.Forms.RadioButton()
        Me.RbCurp = New System.Windows.Forms.RadioButton()
        Me.rbNombreEmpleado = New System.Windows.Forms.RadioButton()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2RbNombreEmpleado = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RbCurp = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RbDepartamento = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2TxtBuscar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2DgbEmpleados = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2DgbEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Guna2DgbEmpleados)
        Me.Panel1.Controls.Add(Me.Guna2TxtBuscar)
        Me.Panel1.Controls.Add(Me.Guna2RbDepartamento)
        Me.Panel1.Controls.Add(Me.Guna2RbCurp)
        Me.Panel1.Controls.Add(Me.Guna2RbNombreEmpleado)
        Me.Panel1.Controls.Add(Me.RbDepartamento)
        Me.Panel1.Controls.Add(Me.RbCurp)
        Me.Panel1.Controls.Add(Me.rbNombreEmpleado)
        Me.Panel1.Controls.Add(Me.TxtBuscar)
        Me.Panel1.Location = New System.Drawing.Point(51, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(773, 250)
        Me.Panel1.TabIndex = 34
        '
        'RbDepartamento
        '
        Me.RbDepartamento.AutoSize = True
        Me.RbDepartamento.Location = New System.Drawing.Point(410, 165)
        Me.RbDepartamento.Name = "RbDepartamento"
        Me.RbDepartamento.Size = New System.Drawing.Size(92, 17)
        Me.RbDepartamento.TabIndex = 22
        Me.RbDepartamento.Text = "Departamento"
        Me.RbDepartamento.UseVisualStyleBackColor = True
        '
        'RbCurp
        '
        Me.RbCurp.AutoSize = True
        Me.RbCurp.Location = New System.Drawing.Point(357, 165)
        Me.RbCurp.Name = "RbCurp"
        Me.RbCurp.Size = New System.Drawing.Size(47, 17)
        Me.RbCurp.TabIndex = 21
        Me.RbCurp.Text = "Curp"
        Me.RbCurp.UseVisualStyleBackColor = True
        '
        'rbNombreEmpleado
        '
        Me.rbNombreEmpleado.AutoSize = True
        Me.rbNombreEmpleado.Checked = True
        Me.rbNombreEmpleado.Location = New System.Drawing.Point(244, 165)
        Me.rbNombreEmpleado.Name = "rbNombreEmpleado"
        Me.rbNombreEmpleado.Size = New System.Drawing.Size(106, 17)
        Me.rbNombreEmpleado.TabIndex = 20
        Me.rbNombreEmpleado.Text = "NombreCompleto"
        Me.rbNombreEmpleado.UseVisualStyleBackColor = True
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(195, 319)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(35, 17)
        Me.LblTotal.TabIndex = 19
        Me.LblTotal.Text = "Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 319)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Empleados Registrados"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(221, 188)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(397, 20)
        Me.TxtBuscar.TabIndex = 1
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
        Me.Panel2.Size = New System.Drawing.Size(875, 20)
        Me.Panel2.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(375, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 24)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Buscar Empleado"
        '
        'Guna2RbNombreEmpleado
        '
        Me.Guna2RbNombreEmpleado.AutoSize = True
        Me.Guna2RbNombreEmpleado.Checked = True
        Me.Guna2RbNombreEmpleado.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RbNombreEmpleado.CheckedState.BorderThickness = 0
        Me.Guna2RbNombreEmpleado.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RbNombreEmpleado.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RbNombreEmpleado.CheckedState.InnerOffset = -4
        Me.Guna2RbNombreEmpleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2RbNombreEmpleado.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!)
        Me.Guna2RbNombreEmpleado.Location = New System.Drawing.Point(410, 10)
        Me.Guna2RbNombreEmpleado.Name = "Guna2RbNombreEmpleado"
        Me.Guna2RbNombreEmpleado.Size = New System.Drawing.Size(116, 20)
        Me.Guna2RbNombreEmpleado.TabIndex = 24
        Me.Guna2RbNombreEmpleado.Text = "Nombre Completo"
        Me.Guna2RbNombreEmpleado.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RbNombreEmpleado.UncheckedState.BorderThickness = 2
        Me.Guna2RbNombreEmpleado.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RbNombreEmpleado.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Guna2RbCurp
        '
        Me.Guna2RbCurp.AutoSize = True
        Me.Guna2RbCurp.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RbCurp.CheckedState.BorderThickness = 0
        Me.Guna2RbCurp.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RbCurp.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RbCurp.CheckedState.InnerOffset = -4
        Me.Guna2RbCurp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2RbCurp.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!)
        Me.Guna2RbCurp.Location = New System.Drawing.Point(572, 10)
        Me.Guna2RbCurp.Name = "Guna2RbCurp"
        Me.Guna2RbCurp.Size = New System.Drawing.Size(49, 20)
        Me.Guna2RbCurp.TabIndex = 25
        Me.Guna2RbCurp.Text = "Curp"
        Me.Guna2RbCurp.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RbCurp.UncheckedState.BorderThickness = 2
        Me.Guna2RbCurp.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RbCurp.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Guna2RbDepartamento
        '
        Me.Guna2RbDepartamento.AutoSize = True
        Me.Guna2RbDepartamento.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RbDepartamento.CheckedState.BorderThickness = 0
        Me.Guna2RbDepartamento.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RbDepartamento.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RbDepartamento.CheckedState.InnerOffset = -4
        Me.Guna2RbDepartamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2RbDepartamento.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!)
        Me.Guna2RbDepartamento.Location = New System.Drawing.Point(664, 10)
        Me.Guna2RbDepartamento.Name = "Guna2RbDepartamento"
        Me.Guna2RbDepartamento.Size = New System.Drawing.Size(98, 20)
        Me.Guna2RbDepartamento.TabIndex = 26
        Me.Guna2RbDepartamento.Text = "Departamento"
        Me.Guna2RbDepartamento.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RbDepartamento.UncheckedState.BorderThickness = 2
        Me.Guna2RbDepartamento.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RbDepartamento.UncheckedState.InnerColor = System.Drawing.Color.Transparent
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
        Me.Guna2TxtBuscar.TabIndex = 27
        '
        'Guna2DgbEmpleados
        '
        Me.Guna2DgbEmpleados.AllowUserToAddRows = False
        Me.Guna2DgbEmpleados.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Guna2DgbEmpleados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Guna2DgbEmpleados.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Guna2DgbEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DgbEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DgbEmpleados.ColumnHeadersHeight = 40
        Me.Guna2DgbEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DgbEmpleados.DefaultCellStyle = DataGridViewCellStyle3
        Me.Guna2DgbEmpleados.GridColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Guna2DgbEmpleados.Location = New System.Drawing.Point(0, 47)
        Me.Guna2DgbEmpleados.Name = "Guna2DgbEmpleados"
        Me.Guna2DgbEmpleados.ReadOnly = True
        Me.Guna2DgbEmpleados.RowHeadersVisible = False
        Me.Guna2DgbEmpleados.Size = New System.Drawing.Size(773, 203)
        Me.Guna2DgbEmpleados.TabIndex = 28
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
        'FrmBusquedaEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(875, 347)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblTotal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBusquedaEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBusquedaEmpleado"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Guna2DgbEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents RbDepartamento As RadioButton
    Friend WithEvents RbCurp As RadioButton
    Friend WithEvents rbNombreEmpleado As RadioButton
    Friend WithEvents LblTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2RbDepartamento As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RbCurp As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RbNombreEmpleado As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2TxtBuscar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2DgbEmpleados As Guna.UI2.WinForms.Guna2DataGridView
End Class
