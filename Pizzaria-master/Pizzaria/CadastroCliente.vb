Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.InteropServices
Imports Guna.UI.WinForms

Public Class CadastroCliente
    Inherits UserControl
    Private Shared _instance As CadastroCliente
    Private isMember As Boolean = False
    Public Shared ReadOnly Property instance() As CadastroCliente
        Get
            If _instance Is Nothing Then
                _instance = New CadastroCliente()
            End If
            Return _instance
        End Get
    End Property

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Hide()
        If Not Form2.Panel9.Controls.Contains(Caixa.instance) Then
            Form2.Controls.Add(Caixa.instance)
            Caixa.instance.Dock = DockStyle.Fill
            Caixa.instance.BringToFront()
            Caixa.instance.Visible = True
        End If
        Caixa.instance.BringToFront()
        Caixa.instance.Visible = True
    End Sub
    Private Function TodosOsItensTemValor() As Boolean
        Dim itens As Control() = {txt_nome, txt_celular, txt_cep, txt_cpf, txt_logradouro, txt_uf, txt_cidade, txt_bairro, txt_numero, txt_complemento}
        For Each item In itens
            If item.Text = "" Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub TextBoxes_TextChanged(sender As Object, e As EventArgs) Handles txt_nome.TextChanged, txt_email.TextChanged,
        txt_celular.TextChanged, txt_cep.TextChanged, txt_cpf.TextChanged,
        txt_logradouro.TextChanged, txt_cidade.TextChanged, txt_uf.TextChanged, txt_bairro.TextChanged, txt_numero.TextChanged,
        txt_complemento.TextChanged
        If verifyAccount(txt_cpf, lbl_cpf, "CCPF") = True And verifyAccount(txt_email, lbl_email, "Email") = True And verifyAccount(txt_celular, lbl_celular, "Phone") Then
            btn_salvar.Enabled = TodosOsItensTemValor()
        Else
            btn_salvar.Enabled = False
        End If
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Dim resultado As DialogResult
        resultado = MsgBox("Deseja cadastrar esse cliente?", vbQuestion + vbYesNo, "Atenção")

        If resultado = vbYes Then
            Dim sqlInsert As String = String.Empty
            sqlInsert &= "INSERT INTO tb_customers (CCPF, CName, CCEP, Phone, Email, CBirth, CNumber, CComp, isMember) "
            sqlInsert &= "VALUES ('" & txt_cpf.Text & "','" & txt_nome.Text & "','" & txt_cep.Text & "','" _
                                & txt_celular.Text & "','" & txt_email.Text & "','" & dtp_birthDate.Value.ToString.Substring(0, 10) & "','" _
                                & txt_numero.Text & "','" & txt_complemento.Text & "','" & isMember & "')"

            MsgBox(dtp_birthDate.Value)
            UseSQL(sqlInsert)
            LimparItens()
            resultado = MsgBox("Cliente cadastrado com sucesso!" + vbNewLine + "Deseja cadastrar outro cliente?", vbQuestion + vbYesNo, "Atenção")
            If resultado = vbYes Then
                txt_nome.Focus()
            Else
                Me.Hide()
                If Not Form2.Panel9.Controls.Contains(Caixa.instance) Then
                    Form2.Controls.Add(Caixa.instance)
                    Caixa.instance.Dock = DockStyle.Fill
                    Caixa.instance.BringToFront()
                    Caixa.instance.Visible = True
                End If
                Caixa.instance.BringToFront()
                Caixa.instance.Visible = True
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
        SQL &= "SELECT * FROM tb_customers "
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
    Private Sub LimparItens()
        Dim itens As Control() = {txt_nome, txt_celular, txt_cpf, txt_email, txt_cep, txt_logradouro, txt_uf, txt_cidade, txt_bairro, txt_numero, txt_complemento}
        For Each item In itens
            If TypeOf item Is GunaTextBox Then
                CType(item, GunaTextBox).Clear()
            ElseIf TypeOf item Is GunaComboBox Then
                CType(item, GunaComboBox).SelectedIndex = -1
            End If
        Next
    End Sub
    Private Sub onlyNumbers(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cpf.KeyPress, txt_celular.KeyPress, txt_cep.KeyPress, txt_numero.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub chk_sim_CheckedChanged(sender As Object, e As EventArgs) Handles chk_sim.CheckedChanged
        With chk_sim
            If .Checked Then
                isMember = True
            Else
                isMember = False
            End If
        End With
    End Sub
End Class