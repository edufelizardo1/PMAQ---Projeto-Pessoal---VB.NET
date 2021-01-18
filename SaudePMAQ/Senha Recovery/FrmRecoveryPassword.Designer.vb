<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecoveryPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRecoveryPassword))
        Me.txtRequestingUser = New System.Windows.Forms.TextBox()
        Me.BtnSend = New System.Windows.Forms.Button()
        Me.lblResultMessage = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtRequestingUser
        '
        Me.txtRequestingUser.Location = New System.Drawing.Point(24, 31)
        Me.txtRequestingUser.Name = "txtRequestingUser"
        Me.txtRequestingUser.Size = New System.Drawing.Size(512, 20)
        Me.txtRequestingUser.TabIndex = 0
        '
        'BtnSend
        '
        Me.BtnSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnSend.FlatAppearance.BorderSize = 0
        Me.BtnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSend.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSend.Location = New System.Drawing.Point(461, 57)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Size = New System.Drawing.Size(75, 23)
        Me.BtnSend.TabIndex = 1
        Me.BtnSend.Text = "Enviar"
        Me.BtnSend.UseVisualStyleBackColor = False
        '
        'lblResultMessage
        '
        Me.lblResultMessage.AutoSize = True
        Me.lblResultMessage.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultMessage.ForeColor = System.Drawing.Color.Red
        Me.lblResultMessage.Location = New System.Drawing.Point(21, 95)
        Me.lblResultMessage.Name = "lblResultMessage"
        Me.lblResultMessage.Size = New System.Drawing.Size(78, 19)
        Me.lblResultMessage.TabIndex = 2
        Me.lblResultMessage.Text = "Resultado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Entre com seu UserName ou Email."
        '
        'FrmRecoveryPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(561, 256)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblResultMessage)
        Me.Controls.Add(Me.BtnSend)
        Me.Controls.Add(Me.txtRequestingUser)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRecoveryPassword"
        Me.Text = "Recuperar Senha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtRequestingUser As TextBox
    Friend WithEvents BtnSend As Button
    Friend WithEvents lblResultMessage As Label
    Friend WithEvents Label1 As Label
End Class
