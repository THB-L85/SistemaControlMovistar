<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelecActivos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSelecActivos))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2BtnCargo = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnDescargo = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BtnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2BtnCargo
        '
        Me.Guna2BtnCargo.Animated = True
        Me.Guna2BtnCargo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Guna2BtnCargo.BorderRadius = 15
        Me.Guna2BtnCargo.BorderThickness = 2
        Me.Guna2BtnCargo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2BtnCargo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnCargo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnCargo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2BtnCargo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2BtnCargo.FillColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2BtnCargo.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!)
        Me.Guna2BtnCargo.ForeColor = System.Drawing.Color.White
        Me.Guna2BtnCargo.Location = New System.Drawing.Point(60, 53)
        Me.Guna2BtnCargo.Name = "Guna2BtnCargo"
        Me.Guna2BtnCargo.Size = New System.Drawing.Size(190, 126)
        Me.Guna2BtnCargo.TabIndex = 0
        Me.Guna2BtnCargo.Text = "Cargo Activos"
        '
        'Guna2BtnDescargo
        '
        Me.Guna2BtnDescargo.Animated = True
        Me.Guna2BtnDescargo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Guna2BtnDescargo.BorderRadius = 15
        Me.Guna2BtnDescargo.BorderThickness = 2
        Me.Guna2BtnDescargo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2BtnDescargo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnDescargo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2BtnDescargo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2BtnDescargo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2BtnDescargo.FillColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2BtnDescargo.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!)
        Me.Guna2BtnDescargo.ForeColor = System.Drawing.Color.White
        Me.Guna2BtnDescargo.Location = New System.Drawing.Point(295, 53)
        Me.Guna2BtnDescargo.Name = "Guna2BtnDescargo"
        Me.Guna2BtnDescargo.Size = New System.Drawing.Size(190, 126)
        Me.Guna2BtnDescargo.TabIndex = 1
        Me.Guna2BtnDescargo.Text = "Descargo Activos"
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
        Me.Guna2BtnExit.Location = New System.Drawing.Point(249, 193)
        Me.Guna2BtnExit.Name = "Guna2BtnExit"
        Me.Guna2BtnExit.Size = New System.Drawing.Size(45, 45)
        Me.Guna2BtnExit.TabIndex = 151
        '
        'FrmSelecActivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(535, 257)
        Me.Controls.Add(Me.Guna2BtnExit)
        Me.Controls.Add(Me.Guna2BtnDescargo)
        Me.Controls.Add(Me.Guna2BtnCargo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSelecActivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSelecActivos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2BtnCargo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BtnDescargo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BtnExit As Guna.UI2.WinForms.Guna2Button
End Class
