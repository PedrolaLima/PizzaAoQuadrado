Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.InteropServices
Imports Guna.UI.WinForms

Public Class Cadastro
    Inherits UserControl
    Private Shared _instance As Cadastro
    Private passValidation As Boolean = False
    Private imageValidation As Boolean = False
    Private Jcode As Integer

    Public Shared ReadOnly Property instance() As Cadastro
        Get
            If _instance Is Nothing Then
                _instance = New Cadastro()
            End If
            Return _instance
        End Get
    End Property

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Hide()
        If Not Form2.Panel9.Controls.Contains(Admin.instance) Then
            Form2.Controls.Add(Admin.instance)
            Admin.instance.Dock = DockStyle.Fill
            Admin.instance.BringToFront()
            Admin.instance.Visible = True
        End If
        Admin.instance.BringToFront()
        Admin.instance.Visible = True
    End Sub
    Private Function TodosOsItensTemValor() As Boolean
        Dim itens As Control() = {txt_nome, txt_login, txt_senha, txt_confsenha, txt_celular, txt_cep, txt_cpf, txt_logradouro, txt_uf, txt_cidade, txt_bairro, txt_numero, txt_complemento, cmb_cargo}
        For Each item In itens
            If item.Text = "" Then
                Return False
            End If
        Next
        If txt_senha.Text = txt_confsenha.Text AndAlso imageValidation = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub TextBoxes_TextChanged(sender As Object, e As EventArgs) Handles txt_nome.TextChanged, txt_login.TextChanged, txt_email.TextChanged,
    txt_senha.TextChanged, txt_confsenha.TextChanged, txt_celular.TextChanged, txt_cep.TextChanged, txt_cpf.TextChanged,
    txt_logradouro.TextChanged, txt_cidade.TextChanged, txt_uf.TextChanged, txt_bairro.TextChanged, txt_numero.TextChanged,
    txt_complemento.TextChanged, cmb_cargo.SelectedValueChanged
        If verifyAccount(txt_login, lbl_login, "Username") = True And verifyAccount(txt_cpf, lbl_cpf, "CPF") = True And verifyAccount(txt_email, lbl_email, "Email") = True Then
            btn_salvar.Enabled = TodosOsItensTemValor()
        Else
            btn_salvar.Enabled = False
        End If
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Dim resultado As DialogResult
        resultado = MsgBox("Deseja cadastrar essa conta?", vbQuestion + vbYesNo, "Atenção")

        If resultado = vbYes Then
            Dim sqlInsert As String = String.Empty
            sqlInsert &= "INSERT INTO tb_login (Name, Email, Username, Password, Jcode, BDate, CEP, CPF, Phone, Photo, NumAddress, Comp) "
            sqlInsert &= "VALUES ('" & txt_nome.Text & "','" & txt_email.Text & "','" & txt_login.Text & "','" & txt_senha.Text & "','" _
                                        & jobCodeCalc() & "','" & dtp_birthDate.Value & "','" & txt_cep.Text & "','" & txt_cpf.Text & "','" _
                                        & txt_celular.Text & "','" & path & "','" & txt_numero.Text & "','" & txt_complemento.Text & "')"

            UseSQL(sqlInsert)
            LimparItens()
            resultado = MsgBox("Dados cadastrados com sucesso!" + vbNewLine + "Deseja cadastrar outra conta?", vbQuestion + vbYesNo, "Atenção")
            If resultado = vbYes Then
                txt_nome.Focus()
            Else
                Me.Hide()
                If Not Form2.Panel9.Controls.Contains(Admin.instance) Then
                    Form2.Controls.Add(Admin.instance)
                    Admin.instance.Dock = DockStyle.Fill
                    Admin.instance.BringToFront()
                    Admin.instance.Visible = True
                End If
                Admin.instance.BringToFront()
                Admin.instance.Visible = True
            End If
        Else
            Return
        End If
    End Sub
    Private Sub txt_cep_LostFocus(sender As Object, e As EventArgs) Handles txt_cep.LostFocus

        Dim SQL As String = ""
        SQL &= "Select CEP FROM tb_cep "
        SQL &= "WHERE CEP = '" & txt_cep.Text & "' "

        Dim UserData As DataTable = UseSQL(SQL)

        If UserData.Rows.Count > 0 Then
            Dim sqlInsert As String = String.Empty
            sqlInsert &= "SELECT * FROM TB_CEP where CEP = '" & txt_cep.Text & " '"
            UserData = UseSQL(sqlInsert)
            txt_logradouro.Text = UserData.Rows(0)("LOGRADOURO").ToString()
            txt_cidade.Text = UserData.Rows(0)("CIDADE").ToString()
            txt_bairro.Text = UserData.Rows(0)("BAIRRO").ToString()
            txt_uf.Text = UserData.Rows(0)("UF").ToString()
            txt_numero.Focus()
        Else
            If txt_cep.Text <> "" Then
                MsgBox("CEP inválido, digite novamente!", MsgBoxStyle.Exclamation + vbOKOnly, "Atenção")
                txt_cep.Clear()
                txt_cep.Focus()
            End If
        End If
    End Sub
    Function verifyAccount(textBox As GunaTextBox, errorLabel As GunaLabel, collum As String) As Boolean
        Dim SQL As String = ""
        SQL &= "SELECT * FROM tb_login "
        SQL &= "WHERE " & collum & " = '" & textBox.Text & "' "

        Dim UserData As DataTable = UseSQL(SQL)

        If UserData.Rows.Count > 0 Then
            textBox.FocusedBorderColor = Color.FromArgb(255, 128, 128)
            errorLabel.Visible = True
            Return False
        Else
            textBox.FocusedBorderColor = Color.FromArgb(100, 88, 255)
            errorLabel.Visible = False
            Return True
        End If
    End Function

    Private Sub txt_confsenha_Leave(sender As Object, e As EventArgs) Handles txt_confsenha.Leave
        If Not passValidation = True Then
            If txt_confsenha.Text <> "" AndAlso txt_senha.Text <> txt_confsenha.Text Then
                passValidation = True
                MsgBox("As senhas não coincidem, digite novamente!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                txt_confsenha.Focus()
            End If
        Else
        End If
    End Sub
    Private Sub Cadastro_Load(sender As Object, e As EventArgs) Handles Me.Load
        imageValidation = False
        btn_salvar.Enabled = False
        cmb_cargo.Items.Clear()
        cmb_cargo.Items.Add("Operador de Caixa")
        cmb_cargo.Items.Add("Gerente")
    End Sub
    Private Sub pic_perfil_Click(sender As Object, e As EventArgs) Handles pic_perfil.Click
        Try
            Dim OpenFileDialog As New OpenFileDialog
            With OpenFileDialog
                .Filter = "Arquivos de Imagem (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG"
                .Title = "Selecione uma Foto"
                .InitialDirectory = Application.StartupPath & "\Imagens"
                .ShowDialog()
                path = .FileName
                imageValidation = True
                pic_perfil.Load(path)
            End With
            btn_salvar.Enabled = TodosOsItensTemValor()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Function jobCodeCalc() As String
        If cmb_cargo.SelectedItem = "Operador de Caixa" Then
            Return 1
        Else
            Return 2
        End If
    End Function
    Private Sub LimparItens()
        Dim itens As Control() = {txt_nome, txt_login, txt_senha, txt_confsenha, txt_celular, txt_cep, txt_logradouro, txt_uf, txt_cidade, txt_bairro, txt_numero, txt_complemento, cmb_cargo}
        For Each item In itens
            If TypeOf item Is GunaTextBox Then
                CType(item, GunaTextBox).Clear()
            ElseIf TypeOf item Is GunaComboBox Then
                CType(item, GunaComboBox).SelectedIndex = -1
            End If
        Next
        pic_perfil.Image = Image.FromFile(Application.StartupPath & "\Imagens\FotoNova.png")
        passValidation = False
        imageValidation = False
    End Sub

    Private Sub txt_uf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_uf.KeyPress
        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub onlyNumbers(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cpf.KeyPress, txt_celular.KeyPress, txt_cep.KeyPress, txt_numero.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
