<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.LbUser = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.PnTitleBar = New System.Windows.Forms.Panel()
        Me.BtnMinimizar = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblrecoverPassword = New System.Windows.Forms.Label()
        Me.PnFooter = New System.Windows.Forms.Panel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PnTitleBar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtUser
        '
        Me.TxtUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUser.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUser.ForeColor = System.Drawing.Color.Silver
        Me.TxtUser.Location = New System.Drawing.Point(41, 328)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(350, 20)
        Me.TxtUser.TabIndex = 0
        '
        'TxtPass
        '
        Me.TxtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPass.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass.ForeColor = System.Drawing.Color.Silver
        Me.TxtPass.Location = New System.Drawing.Point(41, 391)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.Size = New System.Drawing.Size(350, 20)
        Me.TxtPass.TabIndex = 1
        Me.TxtPass.UseSystemPasswordChar = True
        '
        'LbUser
        '
        Me.LbUser.AutoSize = True
        Me.LbUser.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbUser.ForeColor = System.Drawing.Color.Silver
        Me.LbUser.Location = New System.Drawing.Point(39, 306)
        Me.LbUser.Name = "LbUser"
        Me.LbUser.Size = New System.Drawing.Size(65, 19)
        Me.LbUser.TabIndex = 2
        Me.LbUser.Text = "Usuário"
        Me.LbUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(39, 369)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Senha"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Silver
        Me.CheckBox1.Location = New System.Drawing.Point(40, 431)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(103, 23)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Lembre-me"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnLogin.FlatAppearance.BorderSize = 0
        Me.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.White
        Me.BtnLogin.Location = New System.Drawing.Point(40, 480)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(350, 50)
        Me.BtnLogin.TabIndex = 5
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'PnTitleBar
        '
        Me.PnTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.PnTitleBar.Controls.Add(Me.BtnMinimizar)
        Me.PnTitleBar.Controls.Add(Me.BtnClose)
        Me.PnTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.PnTitleBar.Name = "PnTitleBar"
        Me.PnTitleBar.Size = New System.Drawing.Size(430, 30)
        Me.PnTitleBar.TabIndex = 6
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.BtnMinimizar.BackgroundImage = Global.SaudePMAQ.My.Resources.Resources.arrow_in_down___345_
        Me.BtnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMinimizar.FlatAppearance.BorderSize = 0
        Me.BtnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimizar.Location = New System.Drawing.Point(383, 5)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(18, 18)
        Me.BtnMinimizar.TabIndex = 1
        Me.BtnMinimizar.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.Color.Transparent
        Me.BtnClose.BackgroundImage = Global.SaudePMAQ.My.Resources.Resources.arrow_all___378_
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Location = New System.Drawing.Point(407, 5)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(18, 18)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'LblrecoverPassword
        '
        Me.LblrecoverPassword.AutoSize = True
        Me.LblrecoverPassword.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblrecoverPassword.ForeColor = System.Drawing.Color.Silver
        Me.LblrecoverPassword.Location = New System.Drawing.Point(140, 610)
        Me.LblrecoverPassword.Name = "LblrecoverPassword"
        Me.LblrecoverPassword.Size = New System.Drawing.Size(152, 20)
        Me.LblrecoverPassword.TabIndex = 7
        Me.LblrecoverPassword.Text = "Esqueceu a senha?"
        Me.LblrecoverPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnFooter
        '
        Me.PnFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.PnFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnFooter.Location = New System.Drawing.Point(0, 670)
        Me.PnFooter.Name = "PnFooter"
        Me.PnFooter.Size = New System.Drawing.Size(430, 10)
        Me.PnFooter.TabIndex = 8
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(430, 680)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Silver
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.SelectionColor = System.Drawing.Color.Silver
        Me.LineShape1.X1 = 43
        Me.LineShape1.X2 = 391
        Me.LineShape1.Y1 = 597
        Me.LineShape1.Y2 = 597
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SaudePMAQ.My.Resources.Resources.SAUDE_PMAQ
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(43, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(349, 213)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(430, 680)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PnFooter)
        Me.Controls.Add(Me.LblrecoverPassword)
        Me.Controls.Add(Me.PnTitleBar)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LbUser)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.TxtUser)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLogin"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PnTitleBar.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtUser As TextBox
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents LbUser As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents PnTitleBar As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnMinimizar As Button
    Friend WithEvents LblrecoverPassword As Label
    Friend WithEvents PnFooter As Panel
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents PictureBox1 As PictureBox
End Class
