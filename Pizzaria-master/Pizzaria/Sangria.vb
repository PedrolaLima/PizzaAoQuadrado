Imports Guna.UI.WinForms

Public Class Sangria
    Inherits UserControl
    Private Shared _instance As Sangria
    Public Shared ReadOnly Property instance() As Sangria
        Get
            If _instance Is Nothing Then
                _instance = New Sangria()
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

    Private Sub Sangria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregarDinheiro()
    End Sub

    Sub carregarDinheiro()
        btn_confirmar.Enabled = False
        Dim Sql As String = ""
        Sql &= "SELECT cashAmount as totalDinheiro "
        Sql &= "FROM tb_cash "

        Dim totalDinheiro As DataTable = UseSQL(Sql)

        If Not IsDBNull(totalDinheiro.Rows(0)(0)) Then
            txt_saldoAntes.Text = "R$ " & totalDinheiro.Rows(0)(0).ToString().Replace(".", ",")
        Else
            txt_saldoAntes.Text = "R$ 0,00"
        End If
    End Sub
    Private Sub MoneySymbolDelete(sender As Object, e As KeyEventArgs) Handles txt_valor.KeyDown
        If e.KeyCode = Keys.Back Then
            Dim textBox As GunaTextBox = DirectCast(sender, GunaTextBox)
            If textBox.Text = "R$" Then
                textBox.Text = ""
            End If
        End If
    End Sub
    Private Sub OnlyNumbers(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_valor.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        If MessageBox.Show("Você confirma a realização desta sangria?", "Confirmação de Sangria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim valorSangria As Decimal = CDec(txt_valor.Text.Replace("R$ ", "").Replace(",", "."))
            Dim currentCashAmount As Decimal = CDec(UseSQL("SELECT cashAmount FROM tb_cash").Rows(0)(0))
            Dim newCashAmount As String = (currentCashAmount - valorSangria)
            newCashAmount = newCashAmount.Replace(",", ".")
            MsgBox(newCashAmount)
            UseSQL("UPDATE tb_cash SET cashAmount = " & newCashAmount)

            Dim managerName As String = GetManagerName()
            Dim insertQuery As String = "INSERT INTO tb_sangria (Manager, BalanceBefore, ValueWithdrawn, BalanceAfter, Description, Date) VALUES "
            insertQuery &= "( '" & managerName & "'," & (CStr(currentCashAmount)).Replace(",", ".") & "," & CDec(txt_valor.Text.Replace(",", ".")) & "," & (CStr(newCashAmount)).Replace(",", ".") & ",'" & txt_descricao.Text & "', GETDATE())"

            UseSQL(insertQuery)
            MsgBox("Sangria realizada com sucesso!", vbInformation, "Confirmação")
            txt_valor.Text = "R$ 0,00"
            btn_confirmar.Enabled = False
            txt_saldoAntes.Clear()
            txt_saldoDepois.Clear()
        End If

    End Sub

    Private Sub txt_valor_TextChanged(sender As Object, e As EventArgs) Handles txt_valor.TextChanged
        If txt_valor.Text <> "" Then
            If Not txt_valor.Text.StartsWith("R$") Then
                txt_valor.Text = "R$ " & txt_valor.Text
                txt_valor.SelectionStart = txt_valor.Text.Length
            End If
        End If

        If txt_valor.Text <> Nothing And txt_saldoAntes.Text <> Nothing And IsNumeric(txt_valor.Text) Then
            txt_saldoDepois.Text = FormatCurrency(CDec(txt_saldoAntes.Text) - CDec(txt_valor.Text))


            If CDec(txt_valor.Text) <= CDec(txt_saldoAntes.Text) Then
                btn_confirmar.Enabled = True
            Else
                btn_confirmar.Enabled = False
            End If

        Else
            txt_saldoDepois.Text = "R$ 0,00"
            btn_confirmar.Enabled = False
        End If
    End Sub

    Private Function GetManagerName() As String
        Dim selectQuery As String = "SELECT Name FROM tb_login WHERE Username = '" & userLogged & "' OR Email = '" & userLogged & "'"

        Dim result As DataTable = UseSQL(selectQuery)
        If result.Rows.Count > 0 AndAlso Not IsDBNull(result.Rows(0)("Name")) Then
            Return result.Rows(0)("Name").ToString()
        Else
            Return ""
        End If
    End Function
End Class
