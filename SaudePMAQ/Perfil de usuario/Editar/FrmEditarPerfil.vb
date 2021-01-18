Imports SuportePMAQ
Imports DominioPMAQ
Imports MySql.Data.MySqlClient
Public Class FrmEditarPerfil
    Private Sub FormEditUserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadUserData()
        initializeControlsEditPass()
    End Sub

    Private Sub LoadUserData()
        'View
        LblUserName.Text = ActiveUser.loginName
        LblFirstName.Text = ActiveUser.firstName
        LblLastName.Text = ActiveUser.lastName
        LblEmail.Text = ActiveUser.email
        LblPosition.Text = ActiveUser.position

        'Edit
        TxtUserName.Text = ActiveUser.loginName
        TxtFirstName.Text = ActiveUser.firstName
        TxtLastName.Text = ActiveUser.lastName
        TxtEmail.Text = ActiveUser.email
        TxtPassword.Text = ActiveUser.password
        TxtConfirmPassword.Text = ActiveUser.password
    End Sub

    Private Sub InitializeControlsEditPass()
        LinkEditPass.Text = "Edit"
        TxtPassword.UseSystemPasswordChar = True
        TxtPassword.Enabled = False
        TxtConfirmPassword.UseSystemPasswordChar = True
        TxtConfirmPassword.Enabled = False
        TxtCurrentPassword.Text = ""
    End Sub

    Private Sub Reset()
        LoadUserData()
        InitializeControlsEditPass()
    End Sub

    Private Sub LinkEditPass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkEditPass.LinkClicked
        If LinkEditPass.Text = "Edit" Then
            LinkEditPass.Text = "Cancel"
            TxtPassword.Enabled = True
            TxtPassword.Text = ""
            TxtConfirmPassword.Enabled = True
            TxtConfirmPassword.Text = ""

        ElseIf LinkEditPass.Text = "Cancel" Then
            initializeControlsEditPass()
            TxtPassword.Text = ActiveUser.password
            TxtConfirmPassword.Text = ActiveUser.password
        End If
    End Sub

    Private Sub LinkEdit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkEdit.LinkClicked
        GroupBox1.Visible = True
        loadUserData()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If TxtPassword.Text = TxtConfirmPassword.Text Then
            If TxtCurrentPassword.Text = ActiveUser.password Then

                Dim userModel As New UserModel(idUser:=ActiveUser.idUser,
                                               loginName:=TxtUserName.Text,
                                               password:=TxtPassword.Text,
                                               firstName:=TxtFirstName.Text,
                                               lastName:=TxtLastName.Text,
                                               position:=Nothing,
                                               email:=TxtEmail.Text)
                Dim result = userModel.EditUserProfile()
                MessageBox.Show(result)
                reset()
                GroupBox1.Visible = False
            Else
                MessageBox.Show("Incorrect current password")
            End If
        Else
            MessageBox.Show("The passwords do not match, try again")
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancela.Click
        GroupBox1.Visible = False
        reset()
    End Sub


End Class