Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.InteropServices
Imports Guna.UI.WinForms

Public Class EsqueciSenha

    Inherits UserControl
    Private Shared _instance As EsqueciSenha
    Public Shared ReadOnly Property Instance() As EsqueciSenha
        Get
            If _instance Is Nothing Then
                _instance = New EsqueciSenha()
            End If
            Return _instance
        End Get
    End Property

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Form1.ExibirControles(Form1.btn_fechar, Form1.PictureBox1, Form1.Label4, Form1.txt_usuario, Form1.txt_senha, Form1.PictureBox2, Form1.PictureBox3, Form1.chk_mostrar, Form1.btn_login, Form1.lbl_esqueci)
        Form1.Panel.Controls.Remove(_instance)
        Form1.txt_usuario.Select()
    End Sub
    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Application.Exit()
    End Sub
    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        If Not String.IsNullOrWhiteSpace(txt_cpf.Text) And Not String.IsNullOrWhiteSpace(txt_senha.Text) And Not String.IsNullOrWhiteSpace(txt_confirmarsenha.Text) Then
            If txt_senha.Text = txt_confirmarsenha.Text Then
                Dim SQL As String = ""
                SQL &= "SELECT * FROM tb_login "
                SQL &= "WHERE CPF = '" & txt_cpf.Text & "' "

                Dim UserData As DataTable = UseSQL(SQL)

                If UserData.Rows.Count > 0 Then
                    Dim resultado As DialogResult
                    resultado = MsgBox("Deseja alterar a senha?", vbQuestion + vbYesNo, "Atenção")

                    If resultado = vbYes Then
                        Dim sqlUpdate As String = String.Empty
                        sqlUpdate &= "UPDATE tb_login "
                        sqlUpdate &= "SET PASSWORD = '" & txt_senha.Text & "' "
                        sqlUpdate &= "WHERE CPF = '" & txt_cpf.Text & "' "
                        UseSQL(sqlUpdate)
                        MsgBox("Senha alterada com sucesso!", vbInformation + vbOKOnly, "Atenção")
                    End If
                Else
                    MsgBox("O CPF digitado é inválido!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                    txt_cpf.Focus()
                    txt_cpf.SelectAll()
                End If
            Else
                MsgBox("As senhas não coincidem!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                txt_cpf.Select()
            End If
        Else
            MsgBox("Por favor, preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
            txt_cpf.Select()
        End If
    End Sub

    Private Sub EsqueciSenha_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_cpf.Select()
    End Sub
    Private Sub UserEnter(sender As Object, e As KeyEventArgs) Handles txt_cpf.KeyDown, txt_senha.KeyDown, txt_confirmarsenha.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_salvar.PerformClick()
        End If
    End Sub
End Class