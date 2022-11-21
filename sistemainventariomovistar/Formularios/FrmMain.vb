Public Class FrmMain
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2BtnUsuario.Click
        If UCase(tipousuario) = "ADMINISTRADOR" Then
            frmUsuarios.Show()
            Me.Visible = False
        Else
            MsgBox("NO TIENE LOS PRIVILEGIOS PARA ACCEDER A ESTE MODULO", vbInformation, "OPERACION CANCELADA")

        End If
    End Sub

    Private Sub Guna2BtnEmpleados_Click(sender As Object, e As EventArgs) Handles Guna2BtnEmpleados.Click
        If UCase(tipousuario) = "ADMINISTRADOR" Then
            FrmEmpleados.Show()
            Me.Visible = False
        Else
            MsgBox("NO TIENE LOS PRIVILEGIOS PARA ACCEDER A ESTE MODULO", vbInformation, "OPERACION CANCELADA")

        End If
    End Sub

    Private Sub Guna2BtnArticulos_Click(sender As Object, e As EventArgs) Handles Guna2BtnArticulos.Click
        FrmArticulos.Show()
        Me.Visible = False
    End Sub

    Private Sub Guna2BtnPuestos_Click(sender As Object, e As EventArgs) Handles Guna2BtnPuestos.Click
        frmPuestosTrabajo.Show()
        Me.Visible = False
    End Sub

    Private Sub Guna2BtnActivos_Click(sender As Object, e As EventArgs) Handles Guna2BtnActivos.Click
        FrmSelecActivos.Show()
        Me.Visible = False
    End Sub

    Private Sub Guna2BtnPortabilidades_Click(sender As Object, e As EventArgs) Handles Guna2BtnPortabilidades.Click
        FrmRegistroAltasPortabilidades.Show()
        Me.Visible = False
    End Sub

    Private Sub Guna2BtnExit_Click(sender As Object, e As EventArgs) Handles Guna2BtnExit.Click
        On Error Resume Next
        Dim salir As String
        salir = MsgBox("¿Desea salir del sistema?", vbYesNo, "Salir")
        If salir = vbYes Then
            Global.System.Windows.Forms.Application.Exit()
        Else
            Me.Show()
        End If
    End Sub
End Class