Public Class FrmMenuCadastros
    Private Sub FrmMenuCadastros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuCadstro_hide()
    End Sub

#Region "Esconder Menu Cadastro"
    Public Sub MenuCadstro_hide()
        PnMCFamilia.Visible = False
        PnMCImuno.Visible = False
        PnMCNucleoPrevencaoViolencia.Visible = False
        PnMCAD.Visible = False
        PnMCEncaminhamento.Visible = False
        PnMCAMG.Visible = False
        PnMCMP.Visible = False
        PnMCH.Visible = False
        PnMCUF.Visible = False
        PnMCNASF.Visible = False
        PnMCMaPa.Visible = False
        PnMCIO.Visible = False
        PnMCAMPI.Visible = False
        PnMCD.Visible = False
        PnMCVE.Visible = False
        PnMCS.Visible = False
        PnMCSG.Visible = False
        PnMCTB.Visible = False
    End Sub
#End Region

#Region "Mostra Menu Cadastro"
    Private Sub MCFamilia_Show()
        If PnMCFamilia.Visible = False Then
            MenuCadstro_hide()
            PnMCFamilia.Visible = True
        Else
            PnMCFamilia.Visible = False
        End If
    End Sub
    Private Sub MCImuno_Show()
        If PnMCImuno.Visible = False Then
            MenuCadstro_hide()
            PnMCImuno.Visible = True
        Else
            PnMCImuno.Visible = False
        End If
    End Sub

    Private Sub MCNPV_Show()
        If PnMCNucleoPrevencaoViolencia.Visible = False Then
            MenuCadstro_hide()
            PnMCNucleoPrevencaoViolencia.Visible = True
        Else
            PnMCNucleoPrevencaoViolencia.Visible = False
        End If
    End Sub
    Private Sub MCAD_Show()
        If PnMCAD.Visible = False Then
            MenuCadstro_hide()
            PnMCAD.Visible = True
        Else
            PnMCAD.Visible = False
        End If
    End Sub
    Private Sub MCEncaminhamento_Show()
        If PnMCEncaminhamento.Visible = False Then
            MenuCadstro_hide()
            PnMCEncaminhamento.Visible = True
        Else
            PnMCEncaminhamento.Visible = False
        End If
    End Sub
    Private Sub MCAMG_Show()
        If PnMCAMG.Visible = False Then
            MenuCadstro_hide()
            PnMCAMG.Visible = True
        Else
            PnMCAMG.Visible = False
        End If
    End Sub
    Private Sub MCMP_Show()
        If PnMCMP.Visible = False Then
            MenuCadstro_hide()
            PnMCMP.Visible = True
        Else
            PnMCMP.Visible = False
        End If
    End Sub
    Private Sub MCH_Show()
        If PnMCH.Visible = False Then
            MenuCadstro_hide()
            PnMCH.Visible = True
        Else
            PnMCH.Visible = False
        End If
    End Sub
    Private Sub MCUS_Show()
        If PnMCUF.Visible = False Then
            MenuCadstro_hide()
            PnMCUF.Visible = True
        Else
            PnMCUF.Visible = False
        End If
    End Sub
    Private Sub MCNASF_Show()
        If PnMCNASF.Visible = False Then
            MenuCadstro_hide()
            PnMCNASF.Visible = True
        Else
            PnMCNASF.Visible = False
        End If
    End Sub
    Private Sub MCMaPa_Show()
        If PnMCMaPa.Visible = False Then
            MenuCadstro_hide()
            PnMCMaPa.Visible = True
        Else
            PnMCMaPa.Visible = False
        End If
    End Sub
    Private Sub MCIO_Show()
        If PnMCIO.Visible = False Then
            MenuCadstro_hide()
            PnMCIO.Visible = True
        Else
            PnMCIO.Visible = False
        End If
    End Sub
    Private Sub MCAMPI_Show()
        If PnMCAMPI.Visible = False Then
            MenuCadstro_hide()
            PnMCAMPI.Visible = True
        Else
            PnMCAMPI.Visible = False
        End If
    End Sub
    Private Sub MCD_Show()
        If PnMCD.Visible = False Then
            MenuCadstro_hide()
            PnMCD.Visible = True
        Else
            PnMCD.Visible = False
        End If
    End Sub
    Private Sub MCVE_Show()
        If PnMCVE.Visible = False Then
            MenuCadstro_hide()
            PnMCVE.Visible = True
        Else
            PnMCVE.Visible = False
        End If
    End Sub
    Private Sub MCS_Show()
        If PnMCS.Visible = False Then
            MenuCadstro_hide()
            PnMCS.Visible = True
        Else
            PnMCS.Visible = False
        End If
    End Sub
    Private Sub MCSG_Show()
        If PnMCSG.Visible = False Then
            MenuCadstro_hide()
            PnMCSG.Visible = True
        Else
            PnMCSG.Visible = False
        End If
    End Sub
    Private Sub MCTB_Show()
        If PnMCTB.Visible = False Then
            MenuCadstro_hide()
            PnMCTB.Visible = True
        Else
            PnMCTB.Visible = False
        End If
    End Sub
#End Region

#Region "Chama Mostra Menu Cadastro"
    Private Sub BtnMCFamilia_Click(sender As Object, e As EventArgs) Handles BtnMCFamilia.Click
        MCFamilia_Show()
    End Sub
    Private Sub BtnMCImuno_Click(sender As Object, e As EventArgs) Handles BtnMCImuno.Click
        MCImuno_Show()
    End Sub
    Private Sub BtnMCNPV_Click(sender As Object, e As EventArgs) Handles BtnMCNPV.Click
        MCNPV_Show()
    End Sub
    Private Sub BtnMCAD_Click(sender As Object, e As EventArgs) Handles BtnMCAD.Click
        MCAD_Show()
    End Sub
    Private Sub BtnMCE_Click(sender As Object, e As EventArgs) Handles BtnMCE.Click
        MCEncaminhamento_Show()
    End Sub
    Private Sub BtnMCAMG_Click(sender As Object, e As EventArgs) Handles BtnMCAMG.Click
        MCAMG_Show()
    End Sub
    Private Sub BtnMCMP_Click(sender As Object, e As EventArgs) Handles BtnMCMP.Click
        MCMP_Show()
    End Sub
    Private Sub BtnMCH_Click(sender As Object, e As EventArgs) Handles BtnMCH.Click
        MCH_Show()
    End Sub
    Private Sub BtnMCUS_Click(sender As Object, e As EventArgs) Handles BtnMCUS.Click
        MCUS_Show()
    End Sub
    Private Sub BtnMCNASF_Click(sender As Object, e As EventArgs) Handles BtnMCNASF.Click
        MCNASF_Show()
    End Sub
    Private Sub BtnMCMaPa_Click(sender As Object, e As EventArgs) Handles BtnMCMaPa.Click
        MCMaPa_Show()
    End Sub
    Private Sub BtnMCIO_Click(sender As Object, e As EventArgs) Handles BtnMCIO.Click
        MCIO_Show()
    End Sub

    Private Sub BtnMCAMPI_Click(sender As Object, e As EventArgs) Handles BtnMCAMPI.Click
        MCAMPI_Show()
    End Sub

    Private Sub BtnMCD_Click(sender As Object, e As EventArgs) Handles BtnMCD.Click
        MCD_Show()
    End Sub

    Private Sub BtnMCVE_Click(sender As Object, e As EventArgs) Handles BtnMCVE.Click
        MCVE_Show()
    End Sub

    Private Sub BtnMCS_Click(sender As Object, e As EventArgs) Handles BtnMCS.Click
        MCS_Show()
    End Sub

    Private Sub BtnMCSG_Click(sender As Object, e As EventArgs) Handles BtnMCSG.Click
        MCSG_Show()
    End Sub

    Private Sub BtnMCTB_Click(sender As Object, e As EventArgs) Handles BtnMCTB.Click
        MCTB_Show()
    End Sub
#End Region

#Region "Abrir fromularios filhos"
    'Cadastro da familia
    Private Sub BtnMCFResponsavel_Click(sender As Object, e As EventArgs) Handles BtnMCFResponsavel.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmResponsavelFamilia_06)()
    End Sub

    Private Sub BtnMCFDomiciliados_Click(sender As Object, e As EventArgs) Handles BtnMCFDomiciliados.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmDomiciliados_06)()
    End Sub

    Private Sub BtnMCFRelatorio_Click(sender As Object, e As EventArgs) Handles BtnMCFRelatorio.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmRespDomConsulta_06)()
    End Sub

    'Imuno
    Private Sub BtnMCIPaciente_Click(sender As Object, e As EventArgs) Handles BtnMCIPaciente.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmCImuno_06)()
    End Sub

    Private Sub BtnMCIRelatorio_Click(sender As Object, e As EventArgs) Handles BtnMCIRelatorio.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmCImunoConsulta_06)()
    End Sub

    'NPV
    Private Sub BtnMCNPVPaciente_Click(sender As Object, e As EventArgs) Handles BtnMCNPVPaciente.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmCNPV_06)()
    End Sub

    Private Sub BtnMCNPVRelatorio_Click(sender As Object, e As EventArgs) Handles BtnMCNPVRelatorio.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmNPVConsulta_06)()
    End Sub

    'Atenção Domiciliar
    Private Sub BtnADPaciente_Click(sender As Object, e As EventArgs) Handles BtnADPaciente.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmCAD1_06)()
    End Sub

    Private Sub BtnADConsulta_Click(sender As Object, e As EventArgs) Handles BtnADConsulta.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmCAD1RelSimples_06)()
    End Sub

    'Encaminhamento
    Private Sub BtnEPaciente_Click(sender As Object, e As EventArgs) Handles BtnEPaciente.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmCEncaminhamento_06)()
    End Sub

    Private Sub BtnEConsulta_Click(sender As Object, e As EventArgs) Handles BtnEConsulta.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmCEncaminhamentoRelSimples_06)()
    End Sub

    'AMG
    Private Sub BtnAMGPaciente_Click(sender As Object, e As EventArgs) Handles BtnAMGPaciente.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmCAMG_06)()
    End Sub

    Private Sub BtnAMGConsulta_Click(sender As Object, e As EventArgs) Handles BtnAMGConsulta.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmCAMGRelaSimples_06)()
    End Sub

    'Mae Apulistana
    Private Sub BtnMPPaciente_Click(sender As Object, e As EventArgs) Handles BtnMPPaciente.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmCMaePaulistana_06)()
    End Sub

    Private Sub BtnMPConsulta_Click(sender As Object, e As EventArgs) Handles BtnMPConsulta.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmCMaePaulistanaConsulta_06)()
    End Sub

    'Hipertensos
    Private Sub BtnHPaciente_Click(sender As Object, e As EventArgs) Handles BtnHPaciente.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmCHipertensos_06)()
    End Sub

    Private Sub BtnHConsulta_Click(sender As Object, e As EventArgs) Handles BtnHConsulta.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmCHipertensosConsulta_06)()
    End Sub

    'Usuários fraldas
    Private Sub BtnUSPaciente_Click(sender As Object, e As EventArgs) Handles BtnUSPaciente.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmCUsuarioFraldas_06)()
    End Sub

    Private Sub BtnUSConsulta_Click(sender As Object, e As EventArgs) Handles BtnUSConsulta.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmCUsuFraldasConsulta_06)()
    End Sub

    'NASF
    Private Sub BtnNASFPAciente_Click(sender As Object, e As EventArgs) Handles BtnNASFPAciente.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmNASF_06)()
    End Sub

    Private Sub BtnNASFConsulta_Click(sender As Object, e As EventArgs) Handles BtnNASFConsulta.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmNASFConsulta_06)()
    End Sub

    'Mamografia e Papanicolau
    Private Sub BtnMaPaPAciente_Click(sender As Object, e As EventArgs) Handles BtnMaPaPAciente.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmCPapaMamo_06)()
    End Sub

    Private Sub BtnMaPaConsulta_Click(sender As Object, e As EventArgs) Handles BtnMaPaConsulta.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmPapaMamoConsulta_06)()
    End Sub

    'Internaçõese Obitos
    Private Sub BtnIOPaciente_Click(sender As Object, e As EventArgs) Handles BtnIOPaciente.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmInternacoesObitos_06)()
    End Sub

    Private Sub BtnIOConsulta_Click(sender As Object, e As EventArgs) Handles BtnIOConsulta.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmInternaObtosConsulta_06)()
    End Sub

    'AMPI
    Private Sub BtnAMPIPaciente_Click(sender As Object, e As EventArgs) Handles BtnAMPIPaciente.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of frmAMPI_06)()
    End Sub

    Private Sub BtnAMPIConsulta_Click(sender As Object, e As EventArgs) Handles BtnAMPIConsulta.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmAMPIRelSimples_06)()
    End Sub

    'Diabetes
    Private Sub BtnDPaciente_Click(sender As Object, e As EventArgs) Handles BtnDPaciente.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmDiabetes_06)()
    End Sub

    Private Sub BtnDConsulta_Click(sender As Object, e As EventArgs) Handles BtnDConsulta.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmDiabetesRelSimples_06)()
    End Sub

    'Vigilância Epidemiologica
    Private Sub BtnVEPAciente_Click(sender As Object, e As EventArgs) Handles BtnVEPAciente.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmVIgilanciaEpidemiologica_06)()
    End Sub

    Private Sub BtnVEConsulta_Click(sender As Object, e As EventArgs) Handles BtnVEConsulta.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FRmViEConsulta_06)()
    End Sub

    'Sifilis
    Private Sub BtnSPaciente_Click(sender As Object, e As EventArgs) Handles BtnSPaciente.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmSifilis_06)()
    End Sub

    Private Sub BtnSConsulta_Click(sender As Object, e As EventArgs) Handles BtnSConsulta.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmSifilisGestCompanheiro_06)()
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmSifilisConsulta_06)()
    End Sub

    'Sifilis Gestacional
    Private Sub BtnSGPaciente_Click(sender As Object, e As EventArgs) Handles BtnSGPaciente.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmSifilisGestacional_06)()
    End Sub

    Private Sub BtnSGCompanheiro_Click(sender As Object, e As EventArgs) Handles BtnSGCompanheiro.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmSifilisGestCompanheiro_06)()
    End Sub

    Private Sub BtnSGConsulta_Click(sender As Object, e As EventArgs) Handles BtnSGConsulta.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmSifilisGestConsulta_06)()
    End Sub

    'Tuberculose
    Private Sub BtnTBPaciente_Click(sender As Object, e As EventArgs) Handles BtnTBPaciente.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmTuberculose_06)()
    End Sub

    Private Sub BtnTBComunicante_Click(sender As Object, e As EventArgs) Handles BtnTBComunicante.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmComunicante_06)()
    End Sub

    Private Sub BtnTBConsulta_Click(sender As Object, e As EventArgs) Handles BtnTBConsulta.Click
        MenuCadstro_hide()
        FrmTelaPrincipal.AbrirFormEnPanel(Of FrmTuberculoseConsulta_06)()
    End Sub

#End Region
End Class