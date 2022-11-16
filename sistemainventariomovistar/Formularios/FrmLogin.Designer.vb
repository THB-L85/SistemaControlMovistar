<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class FrmLogin
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2BtnAccept = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnCancel = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2tbPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2tbUser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(155, 79)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(124, 116)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(434, 35)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(0, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(434, 22)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Iniciar Sesion"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Guna2BtnAccept
        '
        Me.Guna2BtnAccept.Animated = True
        Me.Guna2BtnAccept.AutoRoundedCorners = True
        Me.Guna2BtnAccept.BackgroundImage = CType(resources.GetObject("Guna2BtnAccept.BackgroundImage"), System.Drawing.Image)
        Me.Guna2BtnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2BtnAccept.BorderRadius = 29
        Me.Guna2BtnAccept.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnAccept.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnAccept.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2BtnAccept.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2BtnAccept.FillColor = System.Drawing.Color.Transparent
        Me.Guna2BtnAccept.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2BtnAccept.ForeColor = System.Drawing.Color.White
        Me.Guna2BtnAccept.Location = New System.Drawing.Point(130, 380)
        Me.Guna2BtnAccept.Name = "Guna2BtnAccept"
        Me.Guna2BtnAccept.Size = New System.Drawing.Size(60, 60)
        Me.Guna2BtnAccept.TabIndex = 10
        '
        'Guna2BtnCancel
        '
        Me.Guna2BtnCancel.Animated = True
        Me.Guna2BtnCancel.BackgroundImage = CType(resources.GetObject("Guna2BtnCancel.BackgroundImage"), System.Drawing.Image)
        Me.Guna2BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2BtnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2BtnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2BtnCancel.FillColor = System.Drawing.Color.Empty
        Me.Guna2BtnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2BtnCancel.ForeColor = System.Drawing.Color.White
        Me.Guna2BtnCancel.Location = New System.Drawing.Point(240, 380)
        Me.Guna2BtnCancel.Name = "Guna2BtnCancel"
        Me.Guna2BtnCancel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2BtnCancel.Size = New System.Drawing.Size(60, 60)
        Me.Guna2BtnCancel.TabIndex = 11
        '
        'Guna2tbPassword
        '
        Me.Guna2tbPassword.Animated = True
        Me.Guna2tbPassword.BorderColor = System.Drawing.Color.Black
        Me.Guna2tbPassword.BorderRadius = 7
        Me.Guna2tbPassword.BorderThickness = 2
        Me.Guna2tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2tbPassword.DefaultText = ""
        Me.Guna2tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2tbPassword.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2tbPassword.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!)
        Me.Guna2tbPassword.ForeColor = System.Drawing.Color.Black
        Me.Guna2tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2tbPassword.IconLeft = CType(resources.GetObject("Guna2tbPassword.IconLeft"), System.Drawing.Image)
        Me.Guna2tbPassword.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.Guna2tbPassword.Location = New System.Drawing.Point(85, 304)
        Me.Guna2tbPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2tbPassword.Name = "Guna2tbPassword"
        Me.Guna2tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Guna2tbPassword.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2tbPassword.PlaceholderText = "Contraseña"
        Me.Guna2tbPassword.SelectedText = ""
        Me.Guna2tbPassword.Size = New System.Drawing.Size(270, 50)
        Me.Guna2tbPassword.TabIndex = 12
        '
        'Guna2tbUser
        '
        Me.Guna2tbUser.Animated = True
        Me.Guna2tbUser.BorderColor = System.Drawing.Color.Black
        Me.Guna2tbUser.BorderRadius = 7
        Me.Guna2tbUser.BorderThickness = 2
        Me.Guna2tbUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2tbUser.DefaultText = ""
        Me.Guna2tbUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2tbUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2tbUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2tbUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2tbUser.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2tbUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2tbUser.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!)
        Me.Guna2tbUser.ForeColor = System.Drawing.Color.Black
        Me.Guna2tbUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2tbUser.IconLeft = CType(resources.GetObject("Guna2tbUser.IconLeft"), System.Drawing.Image)
        Me.Guna2tbUser.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.Guna2tbUser.Location = New System.Drawing.Point(85, 228)
        Me.Guna2tbUser.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2tbUser.Name = "Guna2tbUser"
        Me.Guna2tbUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2tbUser.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2tbUser.PlaceholderText = "Usuario"
        Me.Guna2tbUser.SelectedText = ""
        Me.Guna2tbUser.Size = New System.Drawing.Size(270, 50)
        Me.Guna2tbUser.TabIndex = 13
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(434, 465)
        Me.Controls.Add(Me.Guna2BtnCancel)
        Me.Controls.Add(Me.Guna2BtnAccept)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.Guna2tbUser)
        Me.Controls.Add(Me.Guna2tbPassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2BtnAccept As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BtnCancel As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2tbPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2tbUser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
End Class
