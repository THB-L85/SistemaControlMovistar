<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.Guna2BtnUsuario = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnEmpleados = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnArticulos = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnPuestos = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnActivos = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnPortabilidades = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(502, 25)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblTipo)
        Me.Panel1.Controls.Add(Me.lblNombre)
        Me.Panel1.Location = New System.Drawing.Point(405, 97)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(263, 49)
        Me.Panel1.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblNombre.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblNombre.Location = New System.Drawing.Point(0, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(263, 21)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre Completo"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTipo
        '
        Me.lblTipo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTipo.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(0, 21)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(263, 28)
        Me.lblTipo.TabIndex = 1
        Me.lblTipo.Text = "TipoUsuario"
        Me.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2BtnUsuario
        '
        Me.Guna2BtnUsuario.Animated = True
        Me.Guna2BtnUsuario.BackColor = System.Drawing.Color.Transparent
        Me.Guna2BtnUsuario.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Guna2BtnUsuario.BorderRadius = 20
        Me.Guna2BtnUsuario.BorderThickness = 2
        Me.Guna2BtnUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2BtnUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2BtnUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2BtnUsuario.FillColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2BtnUsuario.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Guna2BtnUsuario.ForeColor = System.Drawing.Color.White
        Me.Guna2BtnUsuario.Image = CType(resources.GetObject("Guna2BtnUsuario.Image"), System.Drawing.Image)
        Me.Guna2BtnUsuario.ImageSize = New System.Drawing.Size(100, 100)
        Me.Guna2BtnUsuario.Location = New System.Drawing.Point(161, 181)
        Me.Guna2BtnUsuario.Name = "Guna2BtnUsuario"
        Me.Guna2BtnUsuario.Size = New System.Drawing.Size(225, 225)
        Me.Guna2BtnUsuario.TabIndex = 2
        Me.Guna2BtnUsuario.Text = "Usuarios"
        '
        'Guna2BtnEmpleados
        '
        Me.Guna2BtnEmpleados.Animated = True
        Me.Guna2BtnEmpleados.BackColor = System.Drawing.Color.Transparent
        Me.Guna2BtnEmpleados.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Guna2BtnEmpleados.BorderRadius = 20
        Me.Guna2BtnEmpleados.BorderThickness = 2
        Me.Guna2BtnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2BtnEmpleados.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnEmpleados.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnEmpleados.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2BtnEmpleados.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2BtnEmpleados.FillColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2BtnEmpleados.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Guna2BtnEmpleados.ForeColor = System.Drawing.Color.White
        Me.Guna2BtnEmpleados.Image = CType(resources.GetObject("Guna2BtnEmpleados.Image"), System.Drawing.Image)
        Me.Guna2BtnEmpleados.ImageSize = New System.Drawing.Size(80, 80)
        Me.Guna2BtnEmpleados.Location = New System.Drawing.Point(420, 181)
        Me.Guna2BtnEmpleados.Name = "Guna2BtnEmpleados"
        Me.Guna2BtnEmpleados.Size = New System.Drawing.Size(225, 225)
        Me.Guna2BtnEmpleados.TabIndex = 3
        Me.Guna2BtnEmpleados.Text = "Empleados"
        '
        'Guna2BtnArticulos
        '
        Me.Guna2BtnArticulos.Animated = True
        Me.Guna2BtnArticulos.BackColor = System.Drawing.Color.Transparent
        Me.Guna2BtnArticulos.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Guna2BtnArticulos.BorderRadius = 20
        Me.Guna2BtnArticulos.BorderThickness = 2
        Me.Guna2BtnArticulos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2BtnArticulos.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnArticulos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnArticulos.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2BtnArticulos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2BtnArticulos.FillColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2BtnArticulos.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Guna2BtnArticulos.ForeColor = System.Drawing.Color.White
        Me.Guna2BtnArticulos.Image = CType(resources.GetObject("Guna2BtnArticulos.Image"), System.Drawing.Image)
        Me.Guna2BtnArticulos.ImageSize = New System.Drawing.Size(80, 80)
        Me.Guna2BtnArticulos.Location = New System.Drawing.Point(673, 181)
        Me.Guna2BtnArticulos.Name = "Guna2BtnArticulos"
        Me.Guna2BtnArticulos.Size = New System.Drawing.Size(225, 225)
        Me.Guna2BtnArticulos.TabIndex = 4
        Me.Guna2BtnArticulos.Text = "Artículos"
        Me.Guna2BtnArticulos.TextOffset = New System.Drawing.Point(2, 0)
        '
        'Guna2BtnPuestos
        '
        Me.Guna2BtnPuestos.Animated = True
        Me.Guna2BtnPuestos.BackColor = System.Drawing.Color.Transparent
        Me.Guna2BtnPuestos.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Guna2BtnPuestos.BorderRadius = 20
        Me.Guna2BtnPuestos.BorderThickness = 2
        Me.Guna2BtnPuestos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2BtnPuestos.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnPuestos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnPuestos.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2BtnPuestos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2BtnPuestos.FillColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2BtnPuestos.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Guna2BtnPuestos.ForeColor = System.Drawing.Color.White
        Me.Guna2BtnPuestos.Image = CType(resources.GetObject("Guna2BtnPuestos.Image"), System.Drawing.Image)
        Me.Guna2BtnPuestos.ImageSize = New System.Drawing.Size(65, 65)
        Me.Guna2BtnPuestos.Location = New System.Drawing.Point(161, 442)
        Me.Guna2BtnPuestos.Name = "Guna2BtnPuestos"
        Me.Guna2BtnPuestos.Size = New System.Drawing.Size(225, 225)
        Me.Guna2BtnPuestos.TabIndex = 5
        Me.Guna2BtnPuestos.Text = "Puestos"
        Me.Guna2BtnPuestos.TextOffset = New System.Drawing.Point(4, 0)
        '
        'Guna2BtnActivos
        '
        Me.Guna2BtnActivos.Animated = True
        Me.Guna2BtnActivos.BackColor = System.Drawing.Color.Transparent
        Me.Guna2BtnActivos.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Guna2BtnActivos.BorderRadius = 20
        Me.Guna2BtnActivos.BorderThickness = 2
        Me.Guna2BtnActivos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2BtnActivos.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnActivos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnActivos.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2BtnActivos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2BtnActivos.FillColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2BtnActivos.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Guna2BtnActivos.ForeColor = System.Drawing.Color.White
        Me.Guna2BtnActivos.Image = CType(resources.GetObject("Guna2BtnActivos.Image"), System.Drawing.Image)
        Me.Guna2BtnActivos.ImageSize = New System.Drawing.Size(70, 70)
        Me.Guna2BtnActivos.Location = New System.Drawing.Point(420, 442)
        Me.Guna2BtnActivos.Name = "Guna2BtnActivos"
        Me.Guna2BtnActivos.Size = New System.Drawing.Size(225, 225)
        Me.Guna2BtnActivos.TabIndex = 6
        Me.Guna2BtnActivos.Text = "Activos"
        Me.Guna2BtnActivos.TextOffset = New System.Drawing.Point(5, 0)
        '
        'Guna2BtnPortabilidades
        '
        Me.Guna2BtnPortabilidades.Animated = True
        Me.Guna2BtnPortabilidades.BackColor = System.Drawing.Color.Transparent
        Me.Guna2BtnPortabilidades.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Guna2BtnPortabilidades.BorderRadius = 20
        Me.Guna2BtnPortabilidades.BorderThickness = 2
        Me.Guna2BtnPortabilidades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2BtnPortabilidades.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnPortabilidades.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnPortabilidades.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2BtnPortabilidades.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2BtnPortabilidades.FillColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2BtnPortabilidades.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Guna2BtnPortabilidades.ForeColor = System.Drawing.Color.White
        Me.Guna2BtnPortabilidades.Image = CType(resources.GetObject("Guna2BtnPortabilidades.Image"), System.Drawing.Image)
        Me.Guna2BtnPortabilidades.ImageSize = New System.Drawing.Size(70, 70)
        Me.Guna2BtnPortabilidades.Location = New System.Drawing.Point(673, 442)
        Me.Guna2BtnPortabilidades.Name = "Guna2BtnPortabilidades"
        Me.Guna2BtnPortabilidades.Size = New System.Drawing.Size(225, 225)
        Me.Guna2BtnPortabilidades.TabIndex = 7
        Me.Guna2BtnPortabilidades.Text = "Portabilidades"
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
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.FillColor = System.Drawing.Color.Gray
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(926, 21)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(127, 85)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 151
        Me.Guna2PictureBox2.TabStop = False
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1080, 720)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.Guna2BtnExit)
        Me.Controls.Add(Me.Guna2BtnPortabilidades)
        Me.Controls.Add(Me.Guna2BtnActivos)
        Me.Controls.Add(Me.Guna2BtnPuestos)
        Me.Controls.Add(Me.Guna2BtnArticulos)
        Me.Controls.Add(Me.Guna2BtnEmpleados)
        Me.Controls.Add(Me.Guna2BtnUsuario)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMain"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2BtnUsuario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2BtnArticulos As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BtnEmpleados As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BtnPortabilidades As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BtnActivos As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BtnPuestos As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BtnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
End Class
