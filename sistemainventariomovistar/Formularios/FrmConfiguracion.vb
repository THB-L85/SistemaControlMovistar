Imports System.IO
Public Class FrmConfiguracion
    Private Sub FrmConfigucion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If File.Exists(Application.StartupPath + "\IP.txt") Then
                TxtIP.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\IP.txt")
            End If
            If File.Exists(Application.StartupPath + "\USER.txt") Then
                TxtUsuario.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\USER.txt")
            End If

            If File.Exists(Application.StartupPath + "\PASS.txt") Then
                TxtPass.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\PASS.txt")
            End If
            If File.Exists(Application.StartupPath + "\BD.txt") Then
                TxtBD.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\BD.txt")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub BtnConectar_Click(sender As Object, e As EventArgs) Handles BtnConectar.Click
        If TxtIP.Text = "" Or TxtUsuario.Text = "" Or TxtPass.Text = "" Or TxtBD.Text = "" Then
            MsgBox("Completar todos los campos", vbCritical, "Operacion Cancelada")
        End If
        Dim archivo As StreamWriter
        Try
            archivo = New StreamWriter(Application.StartupPath + "\IP.txt")
            archivo.WriteLine(TxtIP.Text.Trim)
            archivo.Flush()
            archivo.Close()

            archivo = New StreamWriter(Application.StartupPath + "\BD.txt")
            archivo.WriteLine(TxtBD.Text.Trim)
            archivo.Flush()
            archivo.Close()

            archivo = New StreamWriter(Application.StartupPath + "\USER.txt")
            archivo.WriteLine(TxtUsuario.Text.Trim)
            archivo.Flush()
            archivo.Close()

            archivo = New StreamWriter(Application.StartupPath + "\PASS.txt")
            archivo.WriteLine(TxtPass.Text.Trim)
            archivo.Flush()
            archivo.Close()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        'BtnCancelar.PerformClick()
        FrmLogin.Show()

    End Sub
End Class
