Imports System.Runtime.InteropServices
Imports Guna.UI.WinForms
Imports Guna.UI2.WinForms

Public Class Pedido
    Inherits UserControl
    Private Shared _instance As Pedido
    Private ultimoComboBoxAlterado As Guna2ComboBox = Nothing
    Public Shared ReadOnly Property instance() As Pedido
        Get
            If _instance Is Nothing Then
                _instance = New Pedido()
            End If
            Return _instance
        End Get
    End Property
    Private Sub VerificarCamposEVezes(sender As Object, e As EventArgs) Handles txt_nome.TextChanged, txt_cpf.TextChanged, txt_celular.TextChanged, txt_preco.TextChanged, datagrid_pedido.RowsAdded, datagrid_pedido.RowsRemoved
        If datagrid_pedido.Rows.Count > 0 Then
            btn_realizar.Enabled = VerificarTodosOsCamposPreenchidos()
        Else
            btn_realizar.Enabled = False
        End If
    End Sub
    Private Function VerificarTodosOsCamposPreenchidos() As Boolean
        Dim campos As Control() = {txt_nome, txt_cpf, txt_celular, txt_pag, txt_preco, cmb_pagamento}

        Return campos.All(Function(campo) (TypeOf campo Is ComboBox AndAlso DirectCast(campo, ComboBox).SelectedItem IsNot Nothing) OrElse (TypeOf campo Is TextBox AndAlso Not String.IsNullOrEmpty(DirectCast(campo, TextBox).Text)))
    End Function
    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Hide()
        If Not Form2.Panel9.Controls.Contains(UserControl1.instance) Then
            Form2.Controls.Add(UserControl1.instance)
            UserControl1.instance.Dock = DockStyle.Fill
            UserControl1.instance.BringToFront()
            UserControl1.instance.Visible = True
        End If
        UserControl1.instance.BringToFront()
        UserControl1.instance.Visible = True
        Dim sqlInsert As String = "DELETE FROM tb_pedidos WHERE p_number = (SELECT MAX(p_number) FROM tb_pedidos) "

        UseSQL(sqlInsert)
    End Sub
    Private Sub datagrid_pedido_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_pedido.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim cellValue As Object = datagrid_pedido.Rows(e.RowIndex).Cells("ID").Value
            ValorCelulaSelecionada = cellValue
        End If
    End Sub
    Private Sub btn_realizar_Click(sender As Object, e As EventArgs) Handles btn_realizar.Click
        Dim confirmResult As DialogResult = MessageBox.Show("Deseja finalizar o pedido?", "Confirmação", MessageBoxButtons.YesNo)
        If confirmResult = DialogResult.Yes Then

            Dim orderID As String = datagrid_pedido.Rows(0).Cells("ID").Value.ToString
            Dim client As String = datagrid_pedido.Rows(0).Cells("CLIENTE").Value.ToString()
            Dim clientCPF As String = datagrid_pedido.Rows(0).Cells("CPF").Value.ToString()
            Dim clientPhone As String = datagrid_pedido.Rows(0).Cells("CELULAR").Value.ToString
            Dim paymentMethod As String = datagrid_pedido.Rows(0).Cells("PAGAMENTO").Value.ToString
            Dim discount As String = formattedValue("DESCONTO")
            Dim total As String = formattedValue("TOTAL")
            Dim pricePaid As String = formattedValue("VALORPAGO")
            Dim changeNeeded As String = formattedValue("TROCO")

            If paymentMethod <> "Dinheiro" Then
                Dim diffAmount As Decimal = CDec(datagrid_pedido.Rows(0).Cells("VALORPAGO").Value) - CDec(datagrid_pedido.Rows(0).Cells("TROCO").Value)

                Dim currentBankAmount As Decimal = CDec(UseSQL("SELECT bankAccountAmount FROM tb_cash").Rows(0)(0))

                Dim newBankAmount As String = (currentBankAmount + diffAmount)
                newBankAmount = newBankAmount.Replace(",", ".")

                UseSQL("UPDATE tb_cash SET bankAccountAmount = " & newBankAmount)
            Else
                Dim currentCashAmount As Decimal = CDec(UseSQL("SELECT cashAmount FROM tb_cash").Rows(0)(0))

                Dim newCashAmount As String = currentCashAmount + CDec(datagrid_pedido.Rows(0).Cells("VALORPAGO").Value)
                newCashAmount = newCashAmount.Replace(",", ".")
                UseSQL("UPDATE tb_cash SET cashAmount = " & newCashAmount)
            End If

            Dim sqlUpdate As String = "UPDATE tb_pedidos SET customerFullName = '" & client & "', customerCPF = '" & clientCPF & "', customerPhone = '" & clientPhone & "', paymentMethod = '" & paymentMethod & "', discount = " & discount & ", totalPrice = " & total & ", pricePaid = " & pricePaid & ", changeNeeded = " & changeNeeded & " WHERE p_number = " & orderID & ""
            UseSQL(sqlUpdate)
        End If
        MsgBox("Pedido realizado com sucesso!", vbInformation, "Confirmação")

        Me.Hide()
        If Not Form2.Panel9.Controls.Contains(Caixa.instance) Then
            Form2.Controls.Add(Caixa.instance)
            Caixa.instance.Dock = DockStyle.Fill
            Caixa.instance.BringToFront()
            Caixa.instance.Visible = True
            UserControl1.instance.firstLine = True
            UserControl1.instance.datagrid_pedido.Rows.Clear()
            datagrid_pedido.Rows.Clear()
            LimparItens()
            CarregarComboBoxes()
            carregarPedido()
            btn_realizar.Enabled = False
            txt_preco.Text = "R$ " & calcularTotal()
        End If
        Caixa.instance.BringToFront()
        Caixa.instance.Visible = True
        UserControl1.instance.firstLine = True
        UserControl1.instance.datagrid_pedido.Rows.Clear()
        datagrid_pedido.Rows.Clear()
        LimparItens()
        CarregarComboBoxes()
        carregarPedido()
        btn_realizar.Enabled = False
        txt_preco.Text = "R$ " & calcularTotal()
    End Sub

    Private Function formattedValue(collum As String)
        Dim number As Decimal = CDec(datagrid_pedido.Rows(0).Cells(collum).Value.ToString)
        Dim result As String = CStr(number).Replace(”,”, “.”)
        Return result
    End Function

    Public Sub pedidoFormLoad()
        datagrid_pedido.Rows.Clear()
        LimparItens()
        CarregarComboBoxes()
        carregarPedido()
        btn_realizar.Enabled = False
        txt_preco.Text = "R$ " & calcularTotal()
    End Sub
    Private Sub Pedido_Load(sender As Object, e As EventArgs) Handles Me.Load
        pedidoFormLoad()
    End Sub
    Private Sub MoneySymbolDelete(sender As Object, e As KeyEventArgs) Handles txt_pag.KeyDown
        If e.KeyCode = Keys.Back Then
            Dim textBox As GunaTextBox = DirectCast(sender, GunaTextBox)
            If textBox.Text = "R$" Then
                textBox.Text = ""
            End If
        End If
    End Sub
    Private Sub OnlyNumbers(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pag.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_celular_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_celular.KeyPress, txt_cpf.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txt_TextChanged(sender As Object, e As EventArgs) Handles txt_pag.TextChanged
        Dim currentTextBox As GunaTextBox = DirectCast(sender, GunaTextBox)

        If currentTextBox.Text <> "" Then
            If Not currentTextBox.Text.StartsWith("R$") Then
                currentTextBox.Text = "R$ " & currentTextBox.Text
                currentTextBox.SelectionStart = currentTextBox.Text.Length
            End If
        End If

        If IsNumeric(txt_pag.Text) And txt_pag.Text <> Nothing And txt_total.Text <> Nothing Then
            If (CDec(txt_pag.Text.Replace("R$ ", "")) > CDec(txt_total.Text.Replace("R$ ", ""))) Then
                txt_troco.Text = FormatCurrency(CDec(txt_pag.Text.Replace("R$ ", "")) - CDec(txt_total.Text.Replace("R$ ", "")))
            Else
                txt_troco.Text = "R$ 00,00"
            End If
        Else
            txt_troco.Text = "R$ 00,00"
        End If
    End Sub
    Public Sub LimparItens()
        Dim itens As Control() = {txt_nome, txt_cpf, txt_celular, txt_pag, txt_preco, txt_desconto, txt_total, txt_troco, cmb_pagamento}
        For Each item In itens
            If TypeOf item Is GunaTextBox Then
                CType(item, GunaTextBox).Clear()
            End If
            If TypeOf item Is Guna2ComboBox Then
                CType(item, Guna2ComboBox).SelectedIndex = -1
            End If
        Next
        chk_member.CheckState = False
    End Sub
    Private Sub txt_CPF_TextChanged(sender As Object, e As EventArgs) Handles txt_cpf.TextChanged
        If verifyCPF(txt_cpf, "CCPF") = False Then
            chk_member.Checked = True
        Else
            chk_member.Checked = False
        End If
    End Sub
    Function verifyCPF(textBox As GunaTextBox, collum As String) As Boolean
        Dim SQL As String = ""
        SQL &= "SELECT * FROM tb_customers "
        SQL &= "WHERE " & collum & " = '" & textBox.Text & "' "

        Dim UserData As DataTable = UseSQL(SQL)

        If UserData.Rows.Count > 0 Then
            textBox.FocusedBorderColor = Color.FromArgb(255, 128, 0)
            txt_celular.Text = UserData.Rows(0)("Phone").ToString()
            txt_nome.Text = UserData.Rows(0)("CName").ToString

            calcularTotal()
            txt_desconto.Text = "R$ " & (calcularTotal() * 0.1)
            txt_total.Text = "R$ " & (txt_preco.Text - txt_desconto.Text)
            Return False
        Else
            textBox.FocusedBorderColor = Color.FromArgb(100, 88, 255)
            txt_desconto.Text = "R$ " & "00,00"
            txt_total.Text = txt_preco.Text
            Return True
        End If
    End Function
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim query As String = "SELECT MAX(p_number) FROM tb_pedidos"
        Dim novoID As Object = UseSQL(query).Rows(0)(0)

        datagrid_pedido.Rows(0).Cells("ID").Value = novoID
        datagrid_pedido.Rows(0).Cells("CLIENTE").Value = GetText(txt_nome)
        datagrid_pedido.Rows(0).Cells("CPF").Value = GetText(txt_cpf)
        datagrid_pedido.Rows(0).Cells("CELULAR").Value = GetText(txt_celular)

        If cmb_pagamento.SelectedIndex = -1 Then
            datagrid_pedido.Rows(0).Cells("PAGAMENTO").Value = DBNull.Value
        Else
            datagrid_pedido.Rows(0).Cells("PAGAMENTO").Value = cmb_pagamento.SelectedItem.ToString()
        End If

        datagrid_pedido.Rows(0).Cells("PRECO").Value = GetText(txt_preco)
        datagrid_pedido.Rows(0).Cells("DESCONTO").Value = GetText(txt_desconto)
        datagrid_pedido.Rows(0).Cells("TOTAL").Value = GetText(txt_total)
        datagrid_pedido.Rows(0).Cells("VALORPAGO").Value = FormatCurrency(GetText(txt_pag).ToString.Replace("R$ ", ""))
        datagrid_pedido.Rows(0).Cells("TROCO").Value = GetText(txt_troco)

        checarCarrinho()

    End Sub

    Private Sub checarCarrinho()
        Dim todasPreenchidas As Boolean = True

        For Each cell As DataGridViewCell In datagrid_pedido.Rows(0).Cells
            If cell.Value Is Nothing OrElse cell.Value.ToString() = "" Then
                MsgBox("A célula " & cell.ColumnIndex & " está vazia")
                cell.Value = "0"
                todasPreenchidas = False
            End If
        Next
        If todasPreenchidas Then
            If CDec(txt_pag.Text.Replace("R$ ", "")) < CDec(txt_total.Text.Replace("R$ ", "")) Then
                MsgBox("O valor pago é menor que o total" & vbNewLine & "O pagamento restante é de: R$ " & (CDec(txt_total.Text.Replace("R$ ", "")) - CDec(txt_pag.Text.Replace("R$ ", ""))))
            Else
                btn_realizar.Enabled = True
            End If
        End If
    End Sub

    Function loadLine(collum As String)
        Dim SQL As String = "SELECT " & collum & " FROM tb_pedidos WHERE p_number = (SELECT MAX(p_number) FROM tb_pedidos)  "
        Return UseSQL(SQL).Rows(0)(collum).ToString
    End Function
    Function GetText(txt As GunaTextBox) As Object
        If txt Is Nothing Then
            Return DBNull.Value
        Else
            Return txt.Text
        End If
    End Function

    Private Sub carregarPedido()
        With datagrid_pedido
            .Rows.Clear()
            .Rows.Add()
            .Rows(0).Cells("ID").Value = loadLine("p_number")
            .Rows(0).Cells("CLIENTE").Value = GetText(txt_nome)
            .Rows(0).Cells("CPF").Value = GetText(txt_cpf)
            .Rows(0).Cells("CELULAR").Value = GetText(txt_celular)

            If cmb_pagamento.SelectedIndex = -1 Then
                .Rows(0).Cells("PAGAMENTO").Value = DBNull.Value
            Else
                .Rows(0).Cells("PAGAMENTO").Value = cmb_pagamento.SelectedItem.ToString()
            End If

            .Rows(0).Cells("DESCONTO").Value = GetText(txt_desconto)
            .Rows(0).Cells("TOTAL").Value = GetText(txt_total)
            .Rows(0).Cells("VALORPAGO").Value = GetText(txt_pag)
            .Rows(0).Cells("TROCO").Value = GetText(txt_troco)
        End With
        calcularTotal()
    End Sub

    Function calcularTotal()
        Dim somaTotal As Decimal
        Dim Sql As String = "SELECT orderValue FROM tb_pedidos WHERE p_number = (SELECT MAX(p_number) FROM tb_pedidos)"
        UserData = UseSQL(Sql)
        For i = 0 To UserData.Rows.Count - 1
            If UserData.Rows(i)("orderValue") IsNot Nothing Then
                somaTotal += UserData.Rows(i)("orderValue")
            End If
        Next
        Return somaTotal
    End Function
    Public Sub CarregarComboBoxes()
        cmb_pagamento.Items.Clear()

        With cmb_pagamento.Items
            .Add("Crédito")
            .Add("Débito")
            .Add("Pix")
            .Add("Dinheiro")
        End With
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Dim confirmResult As DialogResult = MessageBox.Show("Deseja finalizar o pedido?", "Confirmação", MessageBoxButtons.YesNo)
        If confirmResult = DialogResult.Yes Then
            UserControl1.instance.datagrid_pedido.Rows.Clear()
            datagrid_pedido.Rows.Clear()
            LimparItens()
            Me.Hide()
            If Not Form2.Panel9.Controls.Contains(Caixa.instance) Then
                Form2.Controls.Add(Caixa.instance)
                Caixa.instance.Dock = DockStyle.Fill
                Caixa.instance.BringToFront()
                Caixa.instance.Visible = True
                UserControl1.instance.firstLine = True
            End If
            Caixa.instance.BringToFront()
            Caixa.instance.Visible = True
            UserControl1.instance.firstLine = True
        End If
    End Sub
End Class
