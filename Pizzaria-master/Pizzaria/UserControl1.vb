Imports Guna.UI.WinForms
Imports Guna.UI2.WinForms

Public Class UserControl1
    Inherits UserControl
    Private Shared _instance As UserControl1

    Public Shared ReadOnly Property instance() As UserControl1
        Get
            If _instance Is Nothing Then
                _instance = New UserControl1()
            End If
            Return _instance
        End Get
    End Property

    Dim initialPrice As Decimal = 00.00
    Public firstLine As Boolean = True
    Dim ValorCelulaSelecionada As Object

    Private Sub btn_addpizza_Click(sender As Object, e As EventArgs) Handles btn_addpizza.Click
        If cmb_sabor.SelectedIndex = -1 Then
            MessageBox.Show("Selecione pelo menos um sabor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If cmb_tamanho.SelectedIndex = -1 Then
            MessageBox.Show("Selecione o tamanho da pizza.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If cmb_qtd.SelectedIndex = -1 Then
            MessageBox.Show("Selecione a quantidade desejada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim pedidoCliente As String = If(chk_doisSabores.Checked, "Meia " & cmb_sabor.SelectedItem.ToString(), cmb_sabor.SelectedItem.ToString())

        If chk_doisSabores.Checked AndAlso cmb_sabor2.SelectedIndex <> -1 Then
            pedidoCliente += " e Meia " & cmb_sabor2.SelectedItem.ToString()
        End If

        Dim rowIndex As Integer = 0
        For Each row As DataGridViewRow In datagrid_pedido.Rows
            If row.IsNewRow Then
                Exit For
            End If
            rowIndex = row.Index + 1
        Next

        If firstLine <> True Then
            rowIndex = rowIndex - 1
        End If

        firstLine = False

        Dim TOTAL As Decimal = lbl_price.Text * cmb_qtd.SelectedItem

        If rowIndex < datagrid_pedido.Rows.Count Then
            datagrid_pedido.Rows(rowIndex).Cells("ID").Value = ObterID()
            datagrid_pedido.Rows(rowIndex).Cells("PEDIDOCLIENTE").Value = pedidoCliente
            datagrid_pedido.Rows(rowIndex).Cells("PRECO").Value = lbl_price.Text
            datagrid_pedido.Rows(rowIndex).Cells("QUANTIDADE").Value = cmb_qtd.Text
            datagrid_pedido.Rows(rowIndex).Cells("TAMANHO").Value = cmb_tamanho.Text
            datagrid_pedido.Rows(rowIndex).Cells("TOTAL").Value = FormatCurrency(TOTAL)
        Else
            datagrid_pedido.Rows.Add()
            datagrid_pedido.Rows(rowIndex).Cells("ID").Value = ObterID()
            datagrid_pedido.Rows(rowIndex).Cells("PEDIDOCLIENTE").Value = pedidoCliente
            datagrid_pedido.Rows(rowIndex).Cells("PRECO").Value = lbl_price.Text
            datagrid_pedido.Rows(rowIndex).Cells("QUANTIDADE").Value = cmb_qtd.Text
            datagrid_pedido.Rows(rowIndex).Cells("TAMANHO").Value = cmb_tamanho.Text
            datagrid_pedido.Rows(rowIndex).Cells("TOTAL").Value = FormatCurrency(TOTAL)
        End If
        datagrid_pedido.Rows.Add()
        calculoTotal()
    End Sub

    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles Me.Load
        LimparItens()
        CarregarComboBoxes()
    End Sub

    Private Sub chk_doisSabores_CheckedChanged(sender As Object, e As EventArgs) Handles chk_doisSabores.CheckedChanged
        If chk_doisSabores.Checked Then
            cmb_sabor2.FillColor = Color.White
            cmb_sabor2.Enabled = True
            If cmb_sabor.SelectedIndex = -1 Or cmb_sabor2.SelectedIndex = -1 Then
                cmb_qtd.Enabled = False
                cmb_qtd.SelectedIndex = -1
            Else
                cmb_qtd.Enabled = True
            End If
        Else
            cmb_sabor2.FillColor = Color.FromArgb(224, 224, 224)
            cmb_sabor2.SelectedIndex = -1
            cmb_sabor2.Enabled = False
            If cmb_sabor.SelectedItem <> Nothing Then
                initialPrice = ObterPrecoDoSabor(cmb_sabor.Text)
            End If
            cmb_qtd.Enabled = True
        End If
    End Sub
    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        datagrid_pedido.Rows.Clear()
        firstLine = True
        LimparItens()
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

    Public Sub CarregarComboBoxes()
        cmb_sabor.Items.Clear()
        cmb_sabor2.Items.Clear()
        cmb_tamanho.Items.Clear()
        cmb_qtd.Items.Clear()
        cmb_bebida.Items.Clear()

        With cmb_tamanho.Items
            .Add("Pequena")
            .Add("Grande")
        End With

        With cmb_qtd.Items
            For i As Integer = 1 To 20
                .Add(i)
            Next

        End With

        Dim query As String = "SELECT dish_name FROM tb_menu WHERE availability = 1 AND description LIKE '%pizza%'"
        Dim UserData As DataTable = UseSQL(query)

        For Each row As DataRow In UserData.Rows
            cmb_sabor.Items.Add(row("dish_name").ToString())
            cmb_sabor2.Items.Add(row("dish_name").ToString())
        Next

        Dim sql As String = "SELECT dish_name FROM tb_menu WHERE availability = 1 AND description NOT LIKE '%pizza%'"
        Dim UserData2 As DataTable = UseSQL(sql)

        For Each row2 As DataRow In UserData2.Rows
            cmb_bebida.Items.Add(row2("dish_name").ToString())
        Next
    End Sub
    Private Sub cmb_sabor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_sabor.SelectedIndexChanged
        If cmb_sabor.SelectedItem <> Nothing Then
            cmb_bebida.Text = Nothing
            pic_pizza.ImageLocation = PizzaPhoto(cmb_sabor.SelectedItem.ToString)
            If Not chk_doisSabores.Checked Then
                initialPrice = ObterPrecoDoSabor(cmb_sabor.Text)
                lbl_price.Text = FormatCurrency(initialPrice)
            End If
        End If
    End Sub

    Private Sub cmb_sabor2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_sabor2.SelectedIndexChanged
        If cmb_sabor2.SelectedItem <> Nothing Then
            cmb_bebida.Text = Nothing
            cmb_qtd.Enabled = True
            pic_pizza.ImageLocation = PizzaPhoto(cmb_sabor2.SelectedItem.ToString)
            initialPrice = (ObterPrecoDoSabor(cmb_sabor.Text) + ObterPrecoDoSabor(cmb_sabor2.Text) / 2)
            lbl_price.Text = FormatCurrency(initialPrice)
        End If
    End Sub

    Private Sub cmb_tamanho_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tamanho.SelectedIndexChanged,
        cmb_sabor.SelectedIndexChanged, cmb_sabor2.SelectedIndexChanged, chk_doisSabores.CheckStateChanged
        If chk_doisSabores.Checked = False AndAlso cmb_sabor.SelectedItem <> Nothing Then
            If cmb_tamanho.SelectedItem = "Pequena" Then
                initialPrice = ObterPrecoDoSabor(cmb_sabor.Text) / 2
                lbl_price.Text = FormatCurrency(initialPrice)
            ElseIf cmb_tamanho.SelectedItem = "Grande" Then
                initialPrice = ObterPrecoDoSabor(cmb_sabor.Text)
                lbl_price.Text = FormatCurrency(initialPrice)
            End If
        Else
            If cmb_tamanho.SelectedItem = "Pequena" AndAlso cmb_sabor2.SelectedItem <> Nothing AndAlso cmb_sabor.SelectedItem <> Nothing Then
                initialPrice = (ObterPrecoDoSabor(cmb_sabor.Text) + ObterPrecoDoSabor(cmb_sabor2.Text)) / 4
                lbl_price.Text = FormatCurrency(initialPrice)
            ElseIf cmb_tamanho.SelectedItem = "Grande" AndAlso cmb_sabor2.SelectedItem <> Nothing AndAlso cmb_sabor.SelectedItem <> Nothing Then
                initialPrice = (ObterPrecoDoSabor(cmb_sabor.Text) + ObterPrecoDoSabor(cmb_sabor2.Text)) / 2
                lbl_price.Text = FormatCurrency(initialPrice)
            End If
        End If
    End Sub
    Private Function ObterPrecoDoSabor(sabor As String) As Decimal
        If sabor <> Nothing Then
            Dim query As String = "SELECT price FROM tb_menu WHERE dish_name = '" & sabor & "'"
            Dim preco As Object = UseSQL(query).Rows(0)("price")
            Return preco
        End If
        Return 0
    End Function

    Private Function ObterID() As Decimal
        Dim query As String = "SELECT MAX(p_number) FROM tb_pedidos"
        Dim ultimoID As Object = UseSQL(query).Rows(0)(0)

        Dim novoID As Integer

        If ultimoID IsNot DBNull.Value Then
            novoID = Convert.ToInt32(ultimoID) + 1
        Else
            novoID = 1
        End If

        Return novoID
    End Function

    Public Sub LimparItens()
        Dim itens As Control() = {cmb_qtd, cmb_sabor, cmb_sabor2, cmb_tamanho}
        For Each item In itens
            CType(item, Guna2ComboBox).SelectedIndex = -1
        Next
        chk_doisSabores.CheckState = False
        initialPrice = FormatCurrency(00.00)
        lbl_price.Text = FormatCurrency(initialPrice)
        pic_pizza.Image = Image.FromFile(Application.StartupPath & "\Imagens\pizzaExemplo.png")
    End Sub
    Private Function PizzaPhoto(user As String) As String
        Dim SQL As String = ""
        SQL &= "SELECT photo FROM tb_menu "
        SQL &= "WHERE dish_name = '" & user & "'"

        Dim result As DataTable = UseSQL(SQL)

        If result.Rows.Count > 0 Then
            Dim foto As String = result.Rows(0)("photo").ToString()
            Dim indiceDebug As Integer = foto.IndexOf("Debug")

            If indiceDebug <> -1 Then
                Dim resultado As String = foto.Substring(indiceDebug + "Debug".Length)
                Return Application.StartupPath + resultado
            Else
                Return result.Rows(0)("photo").ToString()
            End If
        Else
            Return Nothing
        End If
    End Function

    Private Sub datagrid_pedido_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_pedido.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim cellValue As Object = datagrid_pedido.Rows(e.RowIndex).Cells("ID").Value
            ValorCelulaSelecionada = cellValue
        End If
    End Sub
    Private Sub calculoTotal()
        Dim somaTotal As Decimal = 0
        For Each row As DataGridViewRow In datagrid_pedido.Rows
            If Not row.IsNewRow AndAlso row.Index < datagrid_pedido.Rows.Count - 1 Then
                Dim totalCellValue As Object = row.Cells("TOTAL").Value
                If totalCellValue IsNot DBNull.Value Then
                    somaTotal += CDec(totalCellValue)
                End If
            End If
        Next
        datagrid_pedido.Rows(datagrid_pedido.Rows.Count - 1).Cells("TOTAL").Value = FormatCurrency(somaTotal)
    End Sub
    Private Sub btn_removepizza_Click(sender As Object, e As EventArgs) Handles btn_removepizza.Click
        If ValorCelulaSelecionada IsNot Nothing Then
            For Each row As DataGridViewRow In datagrid_pedido.Rows
                If Not row.IsNewRow Then
                    Dim idCellValue As Object = row.Cells("ID").Value
                    If idCellValue IsNot Nothing AndAlso idCellValue.Equals(ValorCelulaSelecionada) Then
                        datagrid_pedido.Rows.Remove(row)
                        calculoTotal()
                        Exit For
                    End If
                End If
            Next
            ValorCelulaSelecionada = Nothing
        End If
    End Sub
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim pedidoFeito As Boolean = False

        For Each row As DataGridViewRow In datagrid_pedido.Rows
            If row.Cells.Cast(Of DataGridViewCell).Any(Function(c) c.Value IsNot Nothing AndAlso c.Value.ToString() <> "") Then
                pedidoFeito = True
                Exit For
            End If
        Next

        If pedidoFeito = True Then
            Dim confirmResult As DialogResult = MessageBox.Show("Deseja seguir com o pedido?", "Confirmação", MessageBoxButtons.YesNo)
            If confirmResult = DialogResult.Yes Then
                For i As Integer = 0 To datagrid_pedido.Rows.Count - 2
                    Dim row As DataGridViewRow = datagrid_pedido.Rows(i)
                    If Not row.IsNewRow Then
                        Dim orderID As Integer = CInt(row.Cells("ID").Value)
                        Dim pizzaFlavor As String = row.Cells("PEDIDOCLIENTE").Value.ToString()
                        Dim pizzaSize As String = row.Cells("TAMANHO").Value.ToString()
                        Dim orderValue As Decimal = CDec(row.Cells("TOTAL").Value.ToString)
                        Dim formattedValue As String = CStr(orderValue).Replace(”,”, “.”)
                        Dim quantity As Integer = CInt(row.Cells("QUANTIDADE").Value)

                        Dim sqlInsert As String = "INSERT INTO tb_pedidos (Employee, p_number, pizzaFlavor, pizzaSize, orderValue, quantity) VALUES "

                        sqlInsert &= "('" & userLogged & "'," & orderID & ",'" & pizzaFlavor & "','" & pizzaSize & "'," & formattedValue & "," & quantity & ")"
                        UseSQL(sqlInsert)
                    End If
                Next

                tela_compra()
            End If
        Else
            MessageBox.Show("Por favor, adicione uma pizza!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

    End Sub
    Function tela_compra()
        Me.Hide()
        If Not Form2.Panel9.Controls.Contains(Pedido.instance) Then
            Form2.Controls.Add(Pedido.instance)
            Pedido.instance.Dock = DockStyle.Fill
            Pedido.instance.BringToFront()
            Pedido.instance.Visible = True
            Me.Hide()
        End If
        Pedido.instance.BringToFront()
        Pedido.instance.Visible = True
        Pedido.instance.pedidoFormLoad()
        Return Nothing
    End Function

    Private Sub btn_bebida_Click(sender As Object, e As EventArgs) Handles btn_bebida.Click
        If cmb_bebida.SelectedIndex = -1 Then
            MessageBox.Show("Selecione pelo menos uma bebida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim rowIndex As Integer = 0
        For Each row As DataGridViewRow In datagrid_pedido.Rows
            If row.IsNewRow Then
                Exit For
            End If
            rowIndex = row.Index + 1
        Next

        If firstLine <> True Then
            rowIndex = rowIndex - 1
        End If

        firstLine = False
        If rowIndex < datagrid_pedido.Rows.Count Then
            datagrid_pedido.Rows(rowIndex).Cells("ID").Value = ObterID()
            datagrid_pedido.Rows(rowIndex).Cells("PEDIDOCLIENTE").Value = cmb_bebida.Text
            datagrid_pedido.Rows(rowIndex).Cells("PRECO").Value = lbl_price.Text
            datagrid_pedido.Rows(rowIndex).Cells("QUANTIDADE").Value = 1
            datagrid_pedido.Rows(rowIndex).Cells("TAMANHO").Value = "2L"
            datagrid_pedido.Rows(rowIndex).Cells("TOTAL").Value = FormatCurrency(lbl_price.Text)
        Else
            datagrid_pedido.Rows.Add()
            datagrid_pedido.Rows(rowIndex).Cells("ID").Value = ObterID()
            datagrid_pedido.Rows(rowIndex).Cells("PEDIDOCLIENTE").Value = cmb_bebida.Text
            datagrid_pedido.Rows(rowIndex).Cells("PRECO").Value = lbl_price.Text
            datagrid_pedido.Rows(rowIndex).Cells("QUANTIDADE").Value = 1
            datagrid_pedido.Rows(rowIndex).Cells("TAMANHO").Value = "2L"
            datagrid_pedido.Rows(rowIndex).Cells("TOTAL").Value = FormatCurrency(lbl_price.Text)
        End If
        datagrid_pedido.Rows.Add()
        calculoTotal()

    End Sub

    Private Sub cmb_bebida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_bebida.SelectedIndexChanged
        If cmb_bebida.SelectedItem <> Nothing Then
            cmb_sabor.Text = Nothing
            cmb_sabor2.Text = Nothing
            pic_pizza.ImageLocation = PizzaPhoto(cmb_bebida.SelectedItem.ToString)
            initialPrice = ObterPrecoDoSabor(cmb_bebida.Text)
            lbl_price.Text = FormatCurrency(initialPrice)
        End If
    End Sub
End Class
