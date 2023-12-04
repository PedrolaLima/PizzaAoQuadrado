Imports System.Text.RegularExpressions

Public Class Profile
    Inherits UserControl
    Private Shared _instance As Profile

    Public Shared ReadOnly Property instance() As Profile
        Get
            If _instance Is Nothing Then
                _instance = New Profile()
            End If
            Return _instance
        End Get
    End Property
    Private Function UserPhoto(user As String) As String


        Dim SQL As String = ""
        SQL &= "SELECT Photo FROM tb_login "
        SQL &= "WHERE Username = '" & user & "' or Email = '" & user & "'"

        Dim result As DataTable = UseSQL(SQL)

        If result.Rows.Count > 0 Then
            Dim foto As String = result.Rows(0)("Photo").ToString()
            Dim indiceDebug As Integer = foto.IndexOf("Debug")

            If indiceDebug <> -1 Then
                Dim resultado As String = foto.Substring(indiceDebug + "Debug".Length)
                Return Application.StartupPath + resultado
            Else
                Return result.Rows(0)("Photo").ToString()
            End If
        Else
            Return Nothing
        End If
    End Function
    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProfile()
    End Sub

    Public Sub LoadProfile()
        pic_userInfo.ImageLocation = UserPhoto(userLogged)
        Dim SQL As String = ""
        SQL &= "SELECT tb_login.Name, tb_login.Username, tb_login.Email, tb_login.BDate, tb_login.CEP, tb_login.CPF, tb_jobs.Jname, tb_login.Phone "
        SQL &= "FROM tb_login "
        SQL &= "INNER JOIN tb_jobs ON tb_jobs.Jcode = tb_login.Jcode "
        SQL &= "WHERE Username = '" & userLogged & "' OR Email = '" & userLogged & "';"

        Dim UserData As DataTable = UseSQL(SQL)

        Dim celular As String = UserData.Rows(0)("Phone").ToString()
        Dim cpf As String = UserData.Rows(0)("CPF").ToString()
        Dim cep As String = UserData.Rows(0)("CEP").ToString()

        lbl_nome.Text = UserData.Rows(0)("Name").ToString()
        lbl_username.Text = UserData.Rows(0)("Username").ToString()
        lbl_email.Text = UserData.Rows(0)("Email").ToString()
        lbl_celular.Text = If(celular.Length >= 11, "(" & celular.Substring(0, 2) & ") " & celular.Substring(2, 5) & "-" & celular.Substring(7, 4), celular)
        lbl_datanasc.Text = UserData.Rows(0)("BDate").ToString().Substring(0, 10)
        lbl_cep.Text = If(cep.Length >= 8, cep.Substring(0, 5) & "-" & cep.Substring(5, 3), cep)
        lbl_cpf.Text = If(cpf.Length >= 11, cpf.Substring(0, 3) & "." & cpf.Substring(3, 3) & "." & cpf.Substring(6, 3) & "-" & cpf.Substring(9, 2), cpf)
        lbl_cargo.Text = UserData.Rows(0)("Jname").ToString()


    End Sub
End Class
