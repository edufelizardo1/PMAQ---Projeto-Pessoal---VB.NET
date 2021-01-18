<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTelaPrincipal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTelaPrincipal))
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PnNavegacao = New System.Windows.Forms.Panel()
        Me.PnMenuLateral1Principal = New System.Windows.Forms.Panel()
        Me.PnLateralMPLogout = New System.Windows.Forms.Panel()
        Me.BtnLogoutImage = New System.Windows.Forms.Button()
        Me.PiBMPLogout = New System.Windows.Forms.PictureBox()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.PnBtTP = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnCdashboardImage = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnPDashBoard = New System.Windows.Forms.Button()
        Me.BtnCrelatorioImage = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnPRelatorio = New System.Windows.Forms.Button()
        Me.BtnCcadastroImage = New System.Windows.Forms.Button()
        Me.PiBFB1 = New System.Windows.Forms.PictureBox()
        Me.BtnPCadastros = New System.Windows.Forms.Button()
        Me.PnPUsuario = New System.Windows.Forms.Panel()
        Me.LinkEditarPerfil = New System.Windows.Forms.LinkLabel()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.LblOcupacao = New System.Windows.Forms.Label()
        Me.PnLogoUsuario = New System.Windows.Forms.Panel()
        Me.PnPLogoEndereco = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnLogoUBS = New System.Windows.Forms.Panel()
        Me.PnTopPrincipal = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.picLogoTopPrincipal = New System.Windows.Forms.PictureBox()
        Me.BtnClosedAplication = New System.Windows.Forms.Button()
        Me.BtnjanelaMaximizada = New System.Windows.Forms.Button()
        Me.BtnJanelaMinimizada = New System.Windows.Forms.Button()
        Me.BtnJanelaNormal = New System.Windows.Forms.Button()
        Me.PanelContenedor.SuspendLayout()
        Me.PnMenuLateral1Principal.SuspendLayout()
        Me.PnLateralMPLogout.SuspendLayout()
        CType(Me.PiBMPLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnBtTP.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PiBFB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnPUsuario.SuspendLayout()
        Me.PnPLogoEndereco.SuspendLayout()
        Me.PnTopPrincipal.SuspendLayout()
        CType(Me.picLogoTopPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Controls.Add(Me.PnNavegacao)
        Me.PanelContenedor.Controls.Add(Me.PnMenuLateral1Principal)
        Me.PanelContenedor.Controls.Add(Me.PnTopPrincipal)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1506, 760)
        Me.PanelContenedor.TabIndex = 0
        '
        'PnNavegacao
        '
        Me.PnNavegacao.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PnNavegacao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnNavegacao.Location = New System.Drawing.Point(254, 40)
        Me.PnNavegacao.Name = "PnNavegacao"
        Me.PnNavegacao.Size = New System.Drawing.Size(1252, 720)
        Me.PnNavegacao.TabIndex = 5
        '
        'PnMenuLateral1Principal
        '
        Me.PnMenuLateral1Principal.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.PnMenuLateral1Principal.Controls.Add(Me.PnLateralMPLogout)
        Me.PnMenuLateral1Principal.Controls.Add(Me.PnBtTP)
        Me.PnMenuLateral1Principal.Controls.Add(Me.PnPUsuario)
        Me.PnMenuLateral1Principal.Controls.Add(Me.PnPLogoEndereco)
        Me.PnMenuLateral1Principal.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnMenuLateral1Principal.Location = New System.Drawing.Point(0, 40)
        Me.PnMenuLateral1Principal.Name = "PnMenuLateral1Principal"
        Me.PnMenuLateral1Principal.Size = New System.Drawing.Size(254, 720)
        Me.PnMenuLateral1Principal.TabIndex = 4
        '
        'PnLateralMPLogout
        '
        Me.PnLateralMPLogout.BackgroundImage = CType(resources.GetObject("PnLateralMPLogout.BackgroundImage"), System.Drawing.Image)
        Me.PnLateralMPLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnLateralMPLogout.Controls.Add(Me.BtnLogoutImage)
        Me.PnLateralMPLogout.Controls.Add(Me.PiBMPLogout)
        Me.PnLateralMPLogout.Controls.Add(Me.BtnLogout)
        Me.PnLateralMPLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnLateralMPLogout.Location = New System.Drawing.Point(0, 623)
        Me.PnLateralMPLogout.Name = "PnLateralMPLogout"
        Me.PnLateralMPLogout.Size = New System.Drawing.Size(254, 97)
        Me.PnLateralMPLogout.TabIndex = 3
        '
        'BtnLogoutImage
        '
        Me.BtnLogoutImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnLogoutImage.BackgroundImage = Global.SaudePMAQ.My.Resources.Resources.logout
        Me.BtnLogoutImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnLogoutImage.FlatAppearance.BorderSize = 0
        Me.BtnLogoutImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogoutImage.Location = New System.Drawing.Point(7, 42)
        Me.BtnLogoutImage.Name = "BtnLogoutImage"
        Me.BtnLogoutImage.Size = New System.Drawing.Size(65, 48)
        Me.BtnLogoutImage.TabIndex = 0
        Me.BtnLogoutImage.UseVisualStyleBackColor = True
        '
        'PiBMPLogout
        '
        Me.PiBMPLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PiBMPLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PiBMPLogout.Location = New System.Drawing.Point(7, 42)
        Me.PiBMPLogout.Name = "PiBMPLogout"
        Me.PiBMPLogout.Size = New System.Drawing.Size(74, 48)
        Me.PiBMPLogout.TabIndex = 3
        Me.PiBMPLogout.TabStop = False
        '
        'BtnLogout
        '
        Me.BtnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnLogout.BackColor = System.Drawing.Color.Transparent
        Me.BtnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogout.FlatAppearance.BorderSize = 0
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogout.Location = New System.Drawing.Point(7, 42)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(241, 48)
        Me.BtnLogout.TabIndex = 2
        Me.BtnLogout.Text = "LOGOUT"
        Me.BtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'PnBtTP
        '
        Me.PnBtTP.BackgroundImage = CType(resources.GetObject("PnBtTP.BackgroundImage"), System.Drawing.Image)
        Me.PnBtTP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnBtTP.Controls.Add(Me.Button2)
        Me.PnBtTP.Controls.Add(Me.BtnCdashboardImage)
        Me.PnBtTP.Controls.Add(Me.PictureBox2)
        Me.PnBtTP.Controls.Add(Me.BtnPDashBoard)
        Me.PnBtTP.Controls.Add(Me.BtnCrelatorioImage)
        Me.PnBtTP.Controls.Add(Me.PictureBox1)
        Me.PnBtTP.Controls.Add(Me.BtnPRelatorio)
        Me.PnBtTP.Controls.Add(Me.BtnCcadastroImage)
        Me.PnBtTP.Controls.Add(Me.PiBFB1)
        Me.PnBtTP.Controls.Add(Me.BtnPCadastros)
        Me.PnBtTP.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnBtTP.Location = New System.Drawing.Point(0, 210)
        Me.PnBtTP.Name = "PnBtTP"
        Me.PnBtTP.Size = New System.Drawing.Size(254, 383)
        Me.PnBtTP.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Image = Global.SaudePMAQ.My.Resources.Resources.BtnCadastros
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(7, 167)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(241, 48)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "CADASTRO"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'BtnCdashboardImage
        '
        Me.BtnCdashboardImage.BackgroundImage = Global.SaudePMAQ.My.Resources.Resources.cadastro
        Me.BtnCdashboardImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnCdashboardImage.FlatAppearance.BorderSize = 0
        Me.BtnCdashboardImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCdashboardImage.Location = New System.Drawing.Point(7, 114)
        Me.BtnCdashboardImage.Name = "BtnCdashboardImage"
        Me.BtnCdashboardImage.Size = New System.Drawing.Size(65, 48)
        Me.BtnCdashboardImage.TabIndex = 7
        Me.BtnCdashboardImage.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(7, 114)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(74, 48)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'BtnPDashBoard
        '
        Me.BtnPDashBoard.BackColor = System.Drawing.Color.Transparent
        Me.BtnPDashBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPDashBoard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPDashBoard.FlatAppearance.BorderSize = 0
        Me.BtnPDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPDashBoard.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPDashBoard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnPDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPDashBoard.Location = New System.Drawing.Point(7, 114)
        Me.BtnPDashBoard.Name = "BtnPDashBoard"
        Me.BtnPDashBoard.Size = New System.Drawing.Size(241, 48)
        Me.BtnPDashBoard.TabIndex = 8
        Me.BtnPDashBoard.Text = "DASHBOARD"
        Me.BtnPDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPDashBoard.UseVisualStyleBackColor = False
        '
        'BtnCrelatorioImage
        '
        Me.BtnCrelatorioImage.BackgroundImage = Global.SaudePMAQ.My.Resources.Resources.cadastro
        Me.BtnCrelatorioImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnCrelatorioImage.FlatAppearance.BorderSize = 0
        Me.BtnCrelatorioImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCrelatorioImage.Location = New System.Drawing.Point(7, 60)
        Me.BtnCrelatorioImage.Name = "BtnCrelatorioImage"
        Me.BtnCrelatorioImage.Size = New System.Drawing.Size(65, 48)
        Me.BtnCrelatorioImage.TabIndex = 4
        Me.BtnCrelatorioImage.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(7, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 48)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'BtnPRelatorio
        '
        Me.BtnPRelatorio.BackColor = System.Drawing.Color.Transparent
        Me.BtnPRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPRelatorio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPRelatorio.FlatAppearance.BorderSize = 0
        Me.BtnPRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPRelatorio.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPRelatorio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnPRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPRelatorio.Location = New System.Drawing.Point(7, 60)
        Me.BtnPRelatorio.Name = "BtnPRelatorio"
        Me.BtnPRelatorio.Size = New System.Drawing.Size(241, 48)
        Me.BtnPRelatorio.TabIndex = 5
        Me.BtnPRelatorio.Text = "RELATÓRIO"
        Me.BtnPRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPRelatorio.UseVisualStyleBackColor = False
        '
        'BtnCcadastroImage
        '
        Me.BtnCcadastroImage.BackgroundImage = Global.SaudePMAQ.My.Resources.Resources.cadastro
        Me.BtnCcadastroImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnCcadastroImage.FlatAppearance.BorderSize = 0
        Me.BtnCcadastroImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCcadastroImage.Location = New System.Drawing.Point(7, 6)
        Me.BtnCcadastroImage.Name = "BtnCcadastroImage"
        Me.BtnCcadastroImage.Size = New System.Drawing.Size(65, 48)
        Me.BtnCcadastroImage.TabIndex = 0
        Me.BtnCcadastroImage.UseVisualStyleBackColor = True
        '
        'PiBFB1
        '
        Me.PiBFB1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PiBFB1.Location = New System.Drawing.Point(7, 6)
        Me.PiBFB1.Name = "PiBFB1"
        Me.PiBFB1.Size = New System.Drawing.Size(74, 48)
        Me.PiBFB1.TabIndex = 3
        Me.PiBFB1.TabStop = False
        '
        'BtnPCadastros
        '
        Me.BtnPCadastros.BackColor = System.Drawing.Color.Transparent
        Me.BtnPCadastros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPCadastros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPCadastros.FlatAppearance.BorderSize = 0
        Me.BtnPCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPCadastros.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPCadastros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnPCadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPCadastros.Location = New System.Drawing.Point(7, 6)
        Me.BtnPCadastros.Name = "BtnPCadastros"
        Me.BtnPCadastros.Size = New System.Drawing.Size(241, 48)
        Me.BtnPCadastros.TabIndex = 2
        Me.BtnPCadastros.Text = "CADASTRO"
        Me.BtnPCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPCadastros.UseVisualStyleBackColor = False
        '
        'PnPUsuario
        '
        Me.PnPUsuario.Controls.Add(Me.LinkEditarPerfil)
        Me.PnPUsuario.Controls.Add(Me.LblEmail)
        Me.PnPUsuario.Controls.Add(Me.LblUsuario)
        Me.PnPUsuario.Controls.Add(Me.LblOcupacao)
        Me.PnPUsuario.Controls.Add(Me.PnLogoUsuario)
        Me.PnPUsuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnPUsuario.Location = New System.Drawing.Point(0, 100)
        Me.PnPUsuario.Name = "PnPUsuario"
        Me.PnPUsuario.Size = New System.Drawing.Size(254, 110)
        Me.PnPUsuario.TabIndex = 1
        '
        'LinkEditarPerfil
        '
        Me.LinkEditarPerfil.AutoSize = True
        Me.LinkEditarPerfil.LinkColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LinkEditarPerfil.Location = New System.Drawing.Point(125, 91)
        Me.LinkEditarPerfil.Name = "LinkEditarPerfil"
        Me.LinkEditarPerfil.Size = New System.Drawing.Size(60, 13)
        Me.LinkEditarPerfil.TabIndex = 6
        Me.LinkEditarPerfil.TabStop = True
        Me.LinkEditarPerfil.Text = "Editar Perfil"
        Me.LinkEditarPerfil.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblEmail.Location = New System.Drawing.Point(87, 70)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(122, 16)
        Me.LblEmail.TabIndex = 5
        Me.LblEmail.Text = "usuario@email.com"
        Me.LblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblUsuario.Location = New System.Drawing.Point(87, 43)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(57, 17)
        Me.LblUsuario.TabIndex = 4
        Me.LblUsuario.Text = "Usuário"
        Me.LblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblOcupacao
        '
        Me.LblOcupacao.AutoSize = True
        Me.LblOcupacao.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOcupacao.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblOcupacao.Location = New System.Drawing.Point(87, 16)
        Me.LblOcupacao.Name = "LblOcupacao"
        Me.LblOcupacao.Size = New System.Drawing.Size(62, 17)
        Me.LblOcupacao.TabIndex = 3
        Me.LblOcupacao.Text = "Posição"
        Me.LblOcupacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnLogoUsuario
        '
        Me.PnLogoUsuario.BackgroundImage = Global.SaudePMAQ.My.Resources.Resources.funcionarios1
        Me.PnLogoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PnLogoUsuario.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnLogoUsuario.Location = New System.Drawing.Point(0, 0)
        Me.PnLogoUsuario.Name = "PnLogoUsuario"
        Me.PnLogoUsuario.Size = New System.Drawing.Size(81, 110)
        Me.PnLogoUsuario.TabIndex = 1
        '
        'PnPLogoEndereco
        '
        Me.PnPLogoEndereco.Controls.Add(Me.Label3)
        Me.PnPLogoEndereco.Controls.Add(Me.Label2)
        Me.PnPLogoEndereco.Controls.Add(Me.Label1)
        Me.PnPLogoEndereco.Controls.Add(Me.PnLogoUBS)
        Me.PnPLogoEndereco.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnPLogoEndereco.Location = New System.Drawing.Point(0, 0)
        Me.PnPLogoEndereco.Name = "PnPLogoEndereco"
        Me.PnPLogoEndereco.Size = New System.Drawing.Size(254, 100)
        Me.PnPLogoEndereco.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(87, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 51)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "R. Interativa, 105  - " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jaraguá, São Paulo - SP," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CEP 02820-040"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(87, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Interativa"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(87, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "UBS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnLogoUBS
        '
        Me.PnLogoUBS.BackgroundImage = Global.SaudePMAQ.My.Resources.Resources.logo
        Me.PnLogoUBS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PnLogoUBS.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnLogoUBS.Location = New System.Drawing.Point(0, 0)
        Me.PnLogoUBS.Name = "PnLogoUBS"
        Me.PnLogoUBS.Size = New System.Drawing.Size(81, 100)
        Me.PnLogoUBS.TabIndex = 0
        '
        'PnTopPrincipal
        '
        Me.PnTopPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.PnTopPrincipal.Controls.Add(Me.Label4)
        Me.PnTopPrincipal.Controls.Add(Me.BtnMenu)
        Me.PnTopPrincipal.Controls.Add(Me.picLogoTopPrincipal)
        Me.PnTopPrincipal.Controls.Add(Me.BtnClosedAplication)
        Me.PnTopPrincipal.Controls.Add(Me.BtnjanelaMaximizada)
        Me.PnTopPrincipal.Controls.Add(Me.BtnJanelaMinimizada)
        Me.PnTopPrincipal.Controls.Add(Me.BtnJanelaNormal)
        Me.PnTopPrincipal.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnTopPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.PnTopPrincipal.Name = "PnTopPrincipal"
        Me.PnTopPrincipal.Size = New System.Drawing.Size(1506, 40)
        Me.PnTopPrincipal.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(87, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "MENU PRINCIPAL"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnMenu
        '
        Me.BtnMenu.BackgroundImage = Global.SaudePMAQ.My.Resources.Resources.align_text_distribute___914_
        Me.BtnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnMenu.FlatAppearance.BorderSize = 0
        Me.BtnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMenu.Location = New System.Drawing.Point(12, 8)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(35, 23)
        Me.BtnMenu.TabIndex = 9
        Me.BtnMenu.UseVisualStyleBackColor = True
        '
        'picLogoTopPrincipal
        '
        Me.picLogoTopPrincipal.BackgroundImage = Global.SaudePMAQ.My.Resources.Resources.LogoBT1
        Me.picLogoTopPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picLogoTopPrincipal.Location = New System.Drawing.Point(703, 0)
        Me.picLogoTopPrincipal.Name = "picLogoTopPrincipal"
        Me.picLogoTopPrincipal.Size = New System.Drawing.Size(100, 40)
        Me.picLogoTopPrincipal.TabIndex = 8
        Me.picLogoTopPrincipal.TabStop = False
        '
        'BtnClosedAplication
        '
        Me.BtnClosedAplication.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClosedAplication.BackColor = System.Drawing.Color.Transparent
        Me.BtnClosedAplication.BackgroundImage = Global.SaudePMAQ.My.Resources.Resources.arrow_all___378_
        Me.BtnClosedAplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnClosedAplication.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClosedAplication.FlatAppearance.BorderSize = 0
        Me.BtnClosedAplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.BtnClosedAplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClosedAplication.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClosedAplication.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnClosedAplication.Location = New System.Drawing.Point(1477, 8)
        Me.BtnClosedAplication.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.BtnClosedAplication.Name = "BtnClosedAplication"
        Me.BtnClosedAplication.Size = New System.Drawing.Size(23, 23)
        Me.BtnClosedAplication.TabIndex = 7
        Me.BtnClosedAplication.UseVisualStyleBackColor = False
        '
        'BtnjanelaMaximizada
        '
        Me.BtnjanelaMaximizada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnjanelaMaximizada.BackColor = System.Drawing.Color.Transparent
        Me.BtnjanelaMaximizada.BackgroundImage = Global.SaudePMAQ.My.Resources.Resources.arrow_right_corner___281_
        Me.BtnjanelaMaximizada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnjanelaMaximizada.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnjanelaMaximizada.FlatAppearance.BorderSize = 0
        Me.BtnjanelaMaximizada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.BtnjanelaMaximizada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnjanelaMaximizada.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnjanelaMaximizada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnjanelaMaximizada.Location = New System.Drawing.Point(1448, 8)
        Me.BtnjanelaMaximizada.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.BtnjanelaMaximizada.Name = "BtnjanelaMaximizada"
        Me.BtnjanelaMaximizada.Size = New System.Drawing.Size(23, 23)
        Me.BtnjanelaMaximizada.TabIndex = 6
        Me.BtnjanelaMaximizada.UseVisualStyleBackColor = False
        '
        'BtnJanelaMinimizada
        '
        Me.BtnJanelaMinimizada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnJanelaMinimizada.BackColor = System.Drawing.Color.Transparent
        Me.BtnJanelaMinimizada.BackgroundImage = Global.SaudePMAQ.My.Resources.Resources.arrow_in_down___345_
        Me.BtnJanelaMinimizada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnJanelaMinimizada.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnJanelaMinimizada.FlatAppearance.BorderSize = 0
        Me.BtnJanelaMinimizada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.BtnJanelaMinimizada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnJanelaMinimizada.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJanelaMinimizada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnJanelaMinimizada.Location = New System.Drawing.Point(1419, 8)
        Me.BtnJanelaMinimizada.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.BtnJanelaMinimizada.Name = "BtnJanelaMinimizada"
        Me.BtnJanelaMinimizada.Size = New System.Drawing.Size(23, 23)
        Me.BtnJanelaMinimizada.TabIndex = 5
        Me.BtnJanelaMinimizada.UseVisualStyleBackColor = False
        '
        'BtnJanelaNormal
        '
        Me.BtnJanelaNormal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnJanelaNormal.BackColor = System.Drawing.Color.Transparent
        Me.BtnJanelaNormal.BackgroundImage = Global.SaudePMAQ.My.Resources.Resources.arrow_corner___282_
        Me.BtnJanelaNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnJanelaNormal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnJanelaNormal.FlatAppearance.BorderSize = 0
        Me.BtnJanelaNormal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.BtnJanelaNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnJanelaNormal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJanelaNormal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnJanelaNormal.Location = New System.Drawing.Point(1448, 8)
        Me.BtnJanelaNormal.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.BtnJanelaNormal.Name = "BtnJanelaNormal"
        Me.BtnJanelaNormal.Size = New System.Drawing.Size(23, 23)
        Me.BtnJanelaNormal.TabIndex = 4
        Me.BtnJanelaNormal.UseVisualStyleBackColor = False
        '
        'FrmTelaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1506, 760)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(680, 500)
        Me.Name = "FrmTelaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTelaPrincipal"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PnMenuLateral1Principal.ResumeLayout(False)
        Me.PnLateralMPLogout.ResumeLayout(False)
        CType(Me.PiBMPLogout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnBtTP.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PiBFB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnPUsuario.ResumeLayout(False)
        Me.PnPUsuario.PerformLayout()
        Me.PnPLogoEndereco.ResumeLayout(False)
        Me.PnPLogoEndereco.PerformLayout()
        Me.PnTopPrincipal.ResumeLayout(False)
        Me.PnTopPrincipal.PerformLayout()
        CType(Me.picLogoTopPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PnNavegacao As Panel
    Friend WithEvents PnMenuLateral1Principal As Panel
    Friend WithEvents PnLateralMPLogout As Panel
    Friend WithEvents BtnLogoutImage As Button
    Friend WithEvents PiBMPLogout As PictureBox
    Friend WithEvents BtnLogout As Button
    Friend WithEvents PnBtTP As Panel
    Friend WithEvents BtnCdashboardImage As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnPDashBoard As Button
    Friend WithEvents BtnCrelatorioImage As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnPRelatorio As Button
    Friend WithEvents BtnCcadastroImage As Button
    Friend WithEvents PiBFB1 As PictureBox
    Friend WithEvents BtnPCadastros As Button
    Friend WithEvents PnPUsuario As Panel
    Friend WithEvents LinkEditarPerfil As LinkLabel
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblUsuario As Label
    Friend WithEvents LblOcupacao As Label
    Friend WithEvents PnLogoUsuario As Panel
    Friend WithEvents PnPLogoEndereco As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PnLogoUBS As Panel
    Friend WithEvents PnTopPrincipal As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnMenu As Button
    Friend WithEvents picLogoTopPrincipal As PictureBox
    Friend WithEvents BtnClosedAplication As Button
    Friend WithEvents BtnjanelaMaximizada As Button
    Friend WithEvents BtnJanelaMinimizada As Button
    Friend WithEvents BtnJanelaNormal As Button
    Friend WithEvents Button2 As Button
End Class
