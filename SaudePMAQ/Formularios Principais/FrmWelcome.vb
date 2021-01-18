Imports SuportePMAQ
Public Class FrmWelcome
    Private Sub FormWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblUsername.Text = ActiveUser.firstName & "  " & ActiveUser.lastName 'Mostramos los datos del usuario'
        'LblEquipe.Text = ActiveUser.Equipe
        CorEquipe()
        CircularProgressBar1.Value = 0
        Me.Opacity = 0 'Iniciamos la opacidad en 0'
        Timer1.Start() 'Iniciamos el temporizador 1'
    End Sub
    Private Sub CorEquipe()
        'If ActiveUser.Equipe = 0 Then
        'PnEquipe.BackColor = Color.Silver
        'End If
        'If ActiveUser.Equipe = 1 Then
        'PnEquipe.BackColor = Color.Red
        'End If
        'If ActiveUser.Equipe = 2 Then
        'PnEquipe.BackColor = Color.White
        'End If
        'If ActiveUser.Equipe = 3 Then
        'PnEquipe.BackColor = Color.Green
        'End If
        'If ActiveUser.Equipe = 4 Then
        'PnEquipe.BackColor = Color.Blue
        'End If
        'If ActiveUser.Equipe = 5 Then
        'PnEquipe.BackColor = Color.Yellow
        'End If
        'If ActiveUser.Equipe = 6 Then
        'PnEquipe.BackColor = Color.Pink
        'End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CircularProgressBar1.Value += 1
        CircularProgressBar1.Text = CircularProgressBar1.Value.ToString()
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        End If

        If CircularProgressBar1.Value = 100 Then
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Opacity -= 0.1
        If Me.Opacity = 0 Then
            Timer2.Stop()
            Me.Close()
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub
End Class