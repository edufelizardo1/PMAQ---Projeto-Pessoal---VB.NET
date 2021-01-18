Imports DominioPMAQ
Public Class FrmRecoveryPassword
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        Dim userModel As New UserModel()
        Dim result = userModel.recoverPassword(txtRequestingUser.Text)
        lblResultMessage.Text = result
    End Sub
End Class