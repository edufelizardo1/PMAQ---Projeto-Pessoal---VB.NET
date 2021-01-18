Public Class FrmResponsavelFamilia_06
    Private Sub FrmResponsavelFamilia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CbBCRSexo.SelectedIndex = 0
    End Sub
#Region "Navegação do formulario"
    Private Sub BtnAdiantar_Click(sender As Object, e As EventArgs) Handles BtnAdiantar.Click
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmDomiciliados_06)()
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        FrmMenuCadastros.MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmMenuCadastros)()
    End Sub
#End Region
#Region "Formatação textBox"
    Private Sub TxtCRFNumeroProntuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCRFNumeroProntuario.KeyPress
        NumeroProntuario.ApenasNumeros(e, sender)
    End Sub

    Private Sub TxtCRFNumeroProntuario_TextChanged(sender As Object, e As EventArgs) Handles TxtCRFNumeroProntuario.TextChanged
        NumeroProntuario.MaskData(Caixa:=sender)
    End Sub

    Private Sub TxtCRDataNascimento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCRDataNascimento.KeyPress
        Data.ApenasNumeros(e, sender)
    End Sub

    Private Sub TxtCRDataNascimento_TextChanged(sender As Object, e As EventArgs) Handles TxtCRDataNascimento.TextChanged
        Data.MaskData(Caixa:=sender)
    End Sub

    Private Sub TxtCRCNS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCRCNS.KeyPress
        CNS.ApenasNumeros(e, sender)
    End Sub

    Private Sub TxtCRCNS_TextChanged(sender As Object, e As EventArgs) Handles TxtCRCNS.TextChanged
        CNS.MaskData(Caixa:=sender)
    End Sub

    Private Sub TxtCRTelefone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCRTelefone.KeyPress
        Telefone.ApenasNumeros(e, sender)
    End Sub

    Private Sub TxtCRTelefone_TextChanged(sender As Object, e As EventArgs) Handles TxtCRTelefone.TextChanged
        Telefone.MaskData(Caixa:=sender)
    End Sub
#End Region
End Class