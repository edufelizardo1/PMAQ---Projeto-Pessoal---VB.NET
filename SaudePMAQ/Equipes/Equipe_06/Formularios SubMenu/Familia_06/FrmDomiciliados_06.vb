Public Class FrmDomiciliados_06
    Private Sub FrmDomiciliados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CbBTCDSexo.SelectedIndex = 0
    End Sub

#Region "Formatação TextBox"

    Private Sub TxtCDDataNascemento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCDDataNascemento.KeyPress
        Data.ApenasNumeros(e, sender)
    End Sub

    Private Sub TxtCDDataNascemento_TextChanged(sender As Object, e As EventArgs) Handles TxtCDDataNascemento.TextChanged
        Data.MaskData(Caixa:=sender)
    End Sub

    Private Sub TxtCDCNS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCDCNS.KeyPress
        CNS.ApenasNumeros(e, sender)
    End Sub

    Private Sub TxtCDCNS_TextChanged(sender As Object, e As EventArgs) Handles TxtCDCNS.TextChanged
        CNS.MaskData(Caixa:=sender)
    End Sub

#End Region
#Region "Navegação de formulario"
    Private Sub BtnVoltar_Click(sender As Object, e As EventArgs) Handles BtnVoltar.Click
        FrmMenuCadastros.MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmResponsavelFamilia_06)()
    End Sub

    Private Sub BtnAdiantar_Click(sender As Object, e As EventArgs) Handles BtnAdiantar.Click
        FrmMenuCadastros.MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmRespDomConsulta_06)()
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        FrmMenuCadastros.MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmMenuCadastros)()
    End Sub
#End Region

End Class