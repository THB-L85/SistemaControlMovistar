Imports System.Data.SqlClient
Public Class FrmLogin
    Dim formConfiguracion As New FrmConfiguracion
    Dim formPrincipal As New frmPrincipal
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2BtnAccept.Click
        If Guna2tbUser.Text = "" Or Guna2tbPassword.Text = "" Then
            MsgBox("Existen datos vacios", vbExclamation, "Operacion Cancelada")
        Else
            Try
                conexion.Open()
                adaptador = New SqlDataAdapter("SELECT * FROM Usuarios WHERE Usuario= '" & Guna2tbUser.Text & "' AND Password= '" & Guna2tbPassword.Text & "' ", conexion)
                tabla.Clear()
                adaptador.Fill(tabla)
                If tabla.Rows.Count = 1 Then
                    Dim fila As DataRow = tabla.Rows(0)
                    Nombre = Trim(fila("NombreCompleto").ToString)
                    tipousuario = Trim(fila("TipoUsuario").ToString)
                    FrmMain.lblNombre.Text = Nombre
                    FrmMain.lblTipo.Text = tipousuario

                    MsgBox("Datos verificados", vbInformation, "Operacion completada")
                    Guna2tbUser.Text = ""
                    Guna2tbPassword.Text = ""
                    Me.Hide()
                    FrmMain.Show()
                Else
                    MsgBox("Nombre de Usuario o contraseña no valido", vbExclamation, "Operacion Cancelada")
                    Guna2tbUser.Text = ""
                    Guna2tbPassword.Text = ""
                End If
                conexion.Close()

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click

        formConfiguracion.Show()


    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        establecerconexion()
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles Guna2tbUser.TextChanged

    End Sub
End Class
