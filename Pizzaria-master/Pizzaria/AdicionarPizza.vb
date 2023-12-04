Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles
Imports Guna.UI.WinForms
Imports Guna.UI2.WinForms

Public Class AdicionarPizza
    Inherits UserControl
    Private Shared _instance As AdicionarPizza
    Private imageValidation As Boolean = False
    Private category = "dish_name"
    Private ValorCelulaSelecionada As Object

    Public Shared ReadOnly Property instance() As AdicionarPizza
        Get
            If _instance Is Nothing Then
                _instance = New AdicionarPizza()
            End If
            Return _instance
        End Get
    End Property

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
    Private Sub datagrid_pizza_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagrid_pizza.CellMouseDoubleClick
        If e.RowIndex >= 0 Then

            Dim dishName As String = datagrid_pizza.Rows(e.RowIndex).Cells("dish_name").Value.ToString()
            Dim description As String = datagrid_pizza.Rows(e.RowIndex).Cells("description").Value.ToString()
            Dim price As String = datagrid_pizza.Rows(e.RowIndex).Cells("price").Value.ToString()
            Dim availability As CheckBoxState = datagrid_pizza.Rows(e.RowIndex).Cells("availability").Value()

            pic_pizza.ImageLocation = PizzaPhoto(dishName)
            txt_pizza.Text = dishName
            txt_desc.Text = description
            txt_price.Text = price
            chk_availability.Checked = availability
        End If
    End Sub
    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
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
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If ValorCelulaSelecionada IsNot Nothing Then
            Dim id As Integer = Convert.ToInt32(ValorCelulaSelecionada)

            Dim result As DialogResult = MessageBox.Show("Tem certeza que deseja atualizar esta linha?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Dim pricetag As String
                pricetag = txt_price.Text.Replace("R$", "")
                pricetag = pricetag.Replace(",", ".")
                Dim query As String = "UPDATE tb_menu SET dish_name = '" & txt_pizza.Text & "', description = '" & txt_desc.Text & "', price = " & pricetag & ", availability = '" & chk_availability.CheckState & "', photo = '" & pic_pizza.ImageLocation & "' WHERE id_menu = " & id & ""

                UseSQL(query)

                load_data("tb_menu", "dish_name", datagrid_pizza)
                ValorCelulaSelecionada = Nothing
                LimparItens()
            End If
        Else
            MessageBox.Show("Selecione uma célula para atualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub datagrid_pizza_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_pizza.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim cellValue As Object = datagrid_pizza.Rows(e.RowIndex).Cells("id_menu").Value
            ValorCelulaSelecionada = cellValue
        End If
        If ValorCelulaSelecionada <> Nothing Then
            btn_salvar.Enabled = False
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If ValorCelulaSelecionada IsNot Nothing Then
            Dim id As Integer = Convert.ToInt32(ValorCelulaSelecionada)

            Dim result As DialogResult = MessageBox.Show("Tem certeza que deseja excluir esta linha?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Dim query As String = "DELETE FROM tb_menu WHERE id_menu = '" & id & "'"
                UseSQL(query)

                load_data("tb_menu", "dish_name", datagrid_pizza)
                ValorCelulaSelecionada = Nothing

                pic_pizza.ImageLocation = Application.StartupPath & "Debug\Imagens\FotoNova.png"
            End If
        Else
            MessageBox.Show("Selecione uma célula para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function TodosOsItensTemValor() As Boolean
        Dim itens As Control() = {txt_pizza, txt_desc, txt_price}
        For Each item In itens
            If item.Text = "" Then
                Return False
            End If
        Next
        If imageValidation = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub TextBoxes_TextChanged(sender As Object, e As EventArgs) Handles txt_pizza.TextChanged, txt_desc.TextChanged, txt_price.TextChanged
        If txt_price.Text <> "" Then
            If Not txt_price.Text.StartsWith("R$") Then
                txt_price.Text = "R$" & txt_price.Text
                txt_price.SelectionStart = txt_price.Text.Length
            End If
        End If

        If verifyPizzaName(txt_pizza, "dish_name") = True Then
            btn_salvar.Enabled = TodosOsItensTemValor()
        Else
            btn_salvar.Enabled = False
        End If
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Dim resultado As DialogResult
        resultado = MsgBox("Deseja cadastrar esse produto?", vbQuestion + vbYesNo, "Atenção")

        If resultado = vbYes Then
            Dim sqlInsert As String = String.Empty
            Dim pricetag As String
            pricetag = txt_price.Text.Replace("R$", "")
            pricetag = pricetag.Replace(",", ".")
            Decimal.Parse(pricetag)
            sqlInsert &= "INSERT INTO tb_menu (dish_name, description, price, availability, photo) "
            sqlInsert &= "VALUES ('" & txt_pizza.Text & "','" & txt_desc.Text & "','" _
                                    & pricetag & "','" _
                                    & chk_availability.CheckState & "','" & path & "')"
            UseSQL(sqlInsert)
            LimparItens()
            load_data("tb_menu", "dish_name", datagrid_pizza)
            resultado = MsgBox("Produto cadastrado com sucesso!" + vbNewLine + "Deseja cadastrar outro produto?", vbQuestion + vbYesNo, "Atenção")
            If resultado = vbYes Then
                txt_pizza.Focus()
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
    Function verifyPizzaName(textBox As GunaTextBox, collum As String) As Boolean
        Dim SQL As String = ""
        SQL &= "SELECT * FROM tb_menu "
        SQL &= "WHERE " & collum & " = '" & textBox.Text & "' "

        Dim UserData As DataTable = UseSQL(SQL)

        If UserData.Rows.Count > 0 Then
            textBox.FocusedBorderColor = Color.FromArgb(255, 128, 0)
            Return False
        Else
            textBox.FocusedBorderColor = Color.FromArgb(100, 88, 255)
            Return True
        End If
    End Function
    Private Sub LimparItens()
        Dim itens As Control() = {txt_pizza, txt_search, txt_desc, txt_price}
        For Each item In itens
            If TypeOf item Is GunaTextBox Then
                CType(item, GunaTextBox).Clear()
            End If
        Next
        chk_availability.Checked = False
        pic_pizza.Image = Image.FromFile(Application.StartupPath & "\Imagens\FotoNova.png")
    End Sub
    Private Sub onlyNumbers(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub pic_pizza_Click(sender As Object, e As EventArgs) Handles pic_pizza.Click
        Dim OpenFileDialog As New OpenFileDialog
        With OpenFileDialog
            .Filter = "Arquivos de Imagem (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG"
            .Title = "Selecione uma Foto"
            .InitialDirectory = Application.StartupPath & "\Imagens"
            .ShowDialog()
            path = .FileName
            imageValidation = True
            If path <> Nothing Then
                pic_pizza.Load(path)
            End If
        End With
        btn_salvar.Enabled = TodosOsItensTemValor()

        If verifyPizzaName(txt_pizza, "dish_name") = True Then
            btn_salvar.Enabled = TodosOsItensTemValor()
        Else
            btn_salvar.Enabled = False
        End If
    End Sub

    Private Sub txt_price_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_price.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged, cmb_type.SelectedValueChanged
        Dim SQL As String = "Select * from tb_menu where " & category & " Like '%" & txt_search.Text & "%'"
        Dim UserData As DataTable = UseSQL(SQL)

        With datagrid_pizza
            .Rows.Clear()
            For Each row As DataRow In UserData.Rows
                Dim newRow As New List(Of Object)

                For Each col As DataColumn In UserData.Columns
                    newRow.Add(row(col))
                Next
                .Rows.Add(newRow.ToArray())
            Next
        End With
    End Sub

    Private Sub LoadFormPizza()
        txt_price.Text = ""
        load_data("tb_menu", "dish_name", datagrid_pizza)
        With cmb_type.Items
            .Add("ID")
            .Add("Sabor")
            .Add("Descrição")
        End With
        cmb_type.SelectedIndex = 1
    End Sub
    Private Sub AdicionarPizza_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadFormPizza()
    End Sub

    Private Sub cmb_type_TextChanged(sender As Object, e As EventArgs) Handles cmb_type.SelectedValueChanged
        Select Case cmb_type.Text
            Case "ID"
                category = "id_menu"
            Case "Sabor"
                category = "dish_name"
            Case "Descrição"
                category = "description"
        End Select
    End Sub

    Private Sub txt_price_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_price.KeyDown
        If e.KeyCode = Keys.Back Then
            If txt_price.Text = "R$" Then
                txt_price.Text = ""
            End If
        End If
    End Sub
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If Not datagrid_pizza.Bounds.Contains(e.Location) AndAlso Not btn_update.Bounds.Contains(e.Location) AndAlso ValorCelulaSelecionada <> Nothing Then
            ValorCelulaSelecionada = Nothing
            LimparItens()
        End If
    End Sub

    Private Sub chk_availability_Click(sender As Object, e As EventArgs) Handles chk_availability.Click
        If chk_availability.Checked = False Then
            chk_availability.Checked = True
        Else
            chk_availability.Checked = False
        End If
    End Sub
End Class
