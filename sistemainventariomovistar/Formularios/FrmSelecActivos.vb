Public Class FrmSelecActivos
    Private Sub Guna2BtnExit_Click(sender As Object, e As EventArgs) Handles Guna2BtnExit.Click
        Me.Close()
        FrmMain.Visible = True
    End Sub

    Private Sub Guna2BtnCargo_Click(sender As Object, e As EventArgs) Handles Guna2BtnCargo.Click
        Me.Close()
        FrmCargoActivos.Show()
    End Sub

    Private Sub Guna2BtnDescargo_Click(sender As Object, e As EventArgs) Handles Guna2BtnDescargo.Click
        Me.Close()
        frmDescargoActivos.Show()
    End Sub
End Class