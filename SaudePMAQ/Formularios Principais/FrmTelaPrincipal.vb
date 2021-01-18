Imports SuportePMAQ
Imports DominioPMAQ
Imports System.Runtime.InteropServices
Public Class FrmTelaPrincipal
    Private Sub FrmTelaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUser()
        Security()
    End Sub
#Region "Acesso a dados"
    Private Sub LoadUser()
        LblUsuario.Text = ActiveUser.loginName
        LblEmail.Text = ActiveUser.email
        LblOcupacao.Text = ActiveUser.position
    End Sub
#End Region
#Region "Logout"
    Private Sub BtnLogout_Click_(sender As Object, e As EventArgs) Handles BtnLogout.Click
        If MessageBox.Show("Are you sure to log out?", "Warning",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub BtnLogoutImage_Click(sender As Object, e As EventArgs) Handles BtnLogoutImage.Click
        If MessageBox.Show("Are you sure to log out?", "Warning",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
#End Region
#Region "Segurança e previlégio de usuários"
    Private Sub Security()
        Dim user As New UserModel()
        If user.SecurityLogin() = False Then
            'Codes
            MessageBox.Show("Error")
            Application.Exit()
        End If
    End Sub
#End Region
#Region "Editar perfil do usuario"
    Private Sub LinkEditarPerfil_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkEditarPerfil.LinkClicked
        AbrirFormEnPanel(Of FrmEditarPerfil)()
    End Sub
#End Region
#Region "TAMANHO DO FORMULÁRIO"
    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO'
    Dim cGrip As Integer = 10

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL' 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PanelContenedor.Region = region
        Me.Invalidate()
    End Sub

    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR'
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(244, 244, 244))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub
#End Region
#Region "Normal, Maximizar, Minimizar e fechar formulario"
    Private Sub BtnClosedAplication_Click(sender As Object, e As EventArgs) Handles BtnClosedAplication.Click
        If MessageBox.Show("Are you sure to log out?", "Warning",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Dim lx, ly As Integer
    Dim sw, sh As Integer

    Private Sub BtnjanelaMaximizada_Click(sender As Object, e As EventArgs) Handles BtnjanelaMaximizada.Click

        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height

        BtnjanelaMaximizada.Visible = False
        BtnJanelaNormal.Visible = True

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location

    End Sub

    Private Sub BtnJanelaNormal_Click(sender As Object, e As EventArgs) Handles BtnJanelaNormal.Click
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)

        BtnjanelaMaximizada.Visible = True
        BtnJanelaNormal.Visible = False
    End Sub

    Private Sub BtnJanelaMinimizada_Click(sender As Object, e As EventArgs) Handles BtnJanelaMinimizada.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region
#Region "Arrastar formulario"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    'Evento do mouse
    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PnTopPrincipal.MouseMove

        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub
#End Region
#Region "Abrir fromularios filhos"
    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()

        Dim Formulario As Form
        Formulario = PnNavegacao.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion'

        'Si form no fue econtrado/ no existe'
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False

            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill

            PnNavegacao.Controls.Add(Formulario)
            PnNavegacao.Tag = Formulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If

    End Sub
#End Region
#Region "Menu Animado"
    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        If PnMenuLateral1Principal.Width = 254 Then
            PnMenuLateral1Principal.Width = 80
        Else
            PnMenuLateral1Principal.Width = 254
        End If
    End Sub
#End Region
#Region "Botão abre formulario"
    Private Sub BtnPCadastros_Click(sender As Object, e As EventArgs) Handles BtnPCadastros.Click
        AbrirFormEnPanel(Of FrmMenuCadastros)()
    End Sub
#End Region
End Class