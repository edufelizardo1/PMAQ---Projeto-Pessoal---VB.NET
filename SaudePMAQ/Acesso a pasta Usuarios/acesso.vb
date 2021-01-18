Imports SuportePMAQ
Public Class acesso
    Public Sub anyMethod()
#Region "Segurança e previlegio do usuario"
        If ActiveUser.position = Positions.desenvolvedor Then
            'Codes
        End If
        If ActiveUser.position = Positions.administrador Then
            'codes
        End If
    End Sub
#End Region
End Class
