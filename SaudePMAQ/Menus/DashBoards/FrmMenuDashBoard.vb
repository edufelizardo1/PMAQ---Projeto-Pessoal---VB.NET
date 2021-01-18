Public Class FrmMenuDashBoard
    Public Sub FrmMenuDashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuRelatorio_hide()
    End Sub
#Region "Esconder Menu Cadastro"
    Private Sub MenuRelatorio_hide()
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
            MenuRelatorio_hide()
            PnMCFamilia.Visible = True
        Else
            PnMCFamilia.Visible = False
        End If
    End Sub
    Private Sub MCImuno_Show()
        If PnMCImuno.Visible = False Then
            MenuRelatorio_hide()
            PnMCImuno.Visible = True
        Else
            PnMCImuno.Visible = False
        End If
    End Sub

    Private Sub MCNPV_Show()
        If PnMCNucleoPrevencaoViolencia.Visible = False Then
            MenuRelatorio_hide()
            PnMCNucleoPrevencaoViolencia.Visible = True
        Else
            PnMCNucleoPrevencaoViolencia.Visible = False
        End If
    End Sub
    Private Sub MCAD_Show()
        If PnMCAD.Visible = False Then
            MenuRelatorio_hide()
            PnMCAD.Visible = True
        Else
            PnMCAD.Visible = False
        End If
    End Sub
    Private Sub MCEncaminhamento_Show()
        If PnMCEncaminhamento.Visible = False Then
            MenuRelatorio_hide()
            PnMCEncaminhamento.Visible = True
        Else
            PnMCEncaminhamento.Visible = False
        End If
    End Sub
    Private Sub MCAMG_Show()
        If PnMCAMG.Visible = False Then
            MenuRelatorio_hide()
            PnMCAMG.Visible = True
        Else
            PnMCAMG.Visible = False
        End If
    End Sub
    Private Sub MCMP_Show()
        If PnMCMP.Visible = False Then
            MenuRelatorio_hide()
            PnMCMP.Visible = True
        Else
            PnMCMP.Visible = False
        End If
    End Sub
    Private Sub MCH_Show()
        If PnMCH.Visible = False Then
            MenuRelatorio_hide()
            PnMCH.Visible = True
        Else
            PnMCH.Visible = False
        End If
    End Sub
    Private Sub MCUS_Show()
        If PnMCUF.Visible = False Then
            MenuRelatorio_hide()
            PnMCUF.Visible = True
        Else
            PnMCUF.Visible = False
        End If
    End Sub
    Private Sub MCNASF_Show()
        If PnMCNASF.Visible = False Then
            MenuRelatorio_hide()
            PnMCNASF.Visible = True
        Else
            PnMCNASF.Visible = False
        End If
    End Sub
    Private Sub MCMaPa_Show()
        If PnMCMaPa.Visible = False Then
            MenuRelatorio_hide()
            PnMCMaPa.Visible = True
        Else
            PnMCMaPa.Visible = False
        End If
    End Sub
    Private Sub MCIO_Show()
        If PnMCIO.Visible = False Then
            MenuRelatorio_hide()
            PnMCIO.Visible = True
        Else
            PnMCIO.Visible = False
        End If
    End Sub
    Private Sub MCAMPI_Show()
        If PnMCAMPI.Visible = False Then
            MenuRelatorio_hide()
            PnMCAMPI.Visible = True
        Else
            PnMCAMPI.Visible = False
        End If
    End Sub
    Private Sub MCD_Show()
        If PnMCD.Visible = False Then
            MenuRelatorio_hide()
            PnMCD.Visible = True
        Else
            PnMCD.Visible = False
        End If
    End Sub
    Private Sub MCVE_Show()
        If PnMCVE.Visible = False Then
            MenuRelatorio_hide()
            PnMCVE.Visible = True
        Else
            PnMCVE.Visible = False
        End If
    End Sub
    Private Sub MCS_Show()
        If PnMCS.Visible = False Then
            MenuRelatorio_hide()
            PnMCS.Visible = True
        Else
            PnMCS.Visible = False
        End If
    End Sub
    Private Sub MCSG_Show()
        If PnMCSG.Visible = False Then
            MenuRelatorio_hide()
            PnMCSG.Visible = True
        Else
            PnMCSG.Visible = False
        End If
    End Sub
    Private Sub MCTB_Show()
        If PnMCTB.Visible = False Then
            MenuRelatorio_hide()
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

End Class