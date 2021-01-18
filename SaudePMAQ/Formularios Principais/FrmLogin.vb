Imports System.Runtime.InteropServices
Imports DominioPMAQ
Imports SaudePMAQ
Public Class FrmLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#Region "Controle do formulario"
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Application.Exit()
    End Sub
    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region
#Region "Arrastar e mover fromulario"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    'Evento do mouse
    Private Sub TitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PnTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    'Barra de titulos
    Private Sub FormLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#End Region
#Region "Acesso a dados"
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim userModel As New UserModel()
        Dim validLogin = userModel.Login(TxtUser.Text, TxtPass.Text)
        If validLogin = True Then
            '-----Agregamos estos codigos antes de mostrar el formulario principal-----'
            Me.Hide()
            Dim formwelcome As New FrmWelcome()
            formwelcome.ShowDialog()
            '----------------------------------------------------------------'
            Dim frm As New FrmTelaPrincipal()
            frm.Show()
            AddHandler frm.FormClosed, AddressOf Me.Logout
        Else
            MessageBox.Show("Incorrect username or password entered." + vbNewLine + "Please try again.")
            TxtPass.Clear()
            TxtPass.Focus()
        End If
    End Sub

    Private Sub Logout(sender As Object, e As FormClosedEventArgs)
        TxtUser.Clear()
        TxtPass.Clear()
        Me.Show()
        TxtUser.Focus()
    End Sub
#End Region
#Region "Recuperar senha do usuario"
    Private Sub LblrecoverPassword_Click(sender As Object, e As EventArgs) Handles LblrecoverPassword.Click
        Dim frmRecoverPassword As New FrmRecoveryPassword()
        frmRecoverPassword.ShowDialog()
    End Sub
#End Region
End Class
