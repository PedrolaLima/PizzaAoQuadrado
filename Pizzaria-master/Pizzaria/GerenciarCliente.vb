Imports Guna.UI2.WinForms

Public Class GerenciarCliente
    Inherits UserControl
    Private Shared _instance As GerenciarCliente
    Private category = "CName"
    Private ValorCelulaSelecionada As Object


    Public Shared ReadOnly Property instance() As GerenciarCliente
        Get
            If _instance Is Nothing Then
                _instance = New GerenciarCliente()
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

    Private Sub GerenciarCliente_Load(sender As Object, e As EventArgs) Handles Me.Load
        load_data("tb_customers", "CName", datagrid_cliente)
        With cmb_type.Items
            .Add("Nome")
            .Add("CPF")
            .Add("Email")
            .Add("Celular")
            .Add("CEP")
            .Add("Data de Nascimento")
        End With
        cmb_type.SelectedIndex = 0
    End Sub
    Private Sub cmb_type_TextChanged(sender As Object, e As EventArgs) Handles cmb_type.SelectedValueChanged
        Select Case cmb_type.Text
            Case "Nome"
                category = "CName"
            Case "CPF"
                category = "CCPF"
            Case "Email"
                category = "Email"
            Case "Celular"
                category = "Phone"
            Case "CEP"
                category = "CCEP"
            Case "Data de Nascimento"
                category = "CBirth"
        End Select
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged, cmb_type.SelectedValueChanged
        Dim columnMappings As New Dictionary(Of String, String)
        columnMappings.Add("CName", "nome")
        columnMappings.Add("CCPF", "CPF")
        columnMappings.Add("Phone", "celular")
        columnMappings.Add("Email", "email")
        columnMappings.Add("CCEP", "cep")
        columnMappings.Add("CBirth", "data_nasc")
        columnMappings.Add("isMember", "fidelidade")

        Dim SQL As String = "Select * from tb_customers WHERE " & category & " Like '%" & txt_search.Text & "%'"
        Dim UserData As DataTable = UseSQL(SQL)

        datagrid_cliente.Rows.Clear()

        If datagrid_cliente.ColumnCount > 0 Then
            For Each row As DataRow In UserData.Rows
                Dim specificColumns As New List(Of Object)

                For Each kvp As KeyValuePair(Of String, String) In columnMappings
                    Dim columnName As String = kvp.Key
                    Dim dataGridViewColumnName As String = kvp.Value
                    If UserData.Columns.Contains(columnName) AndAlso Not IsDBNull(row(columnName)) Then
                        specificColumns.Add(row(columnName).ToString())
                    Else
                        specificColumns.Add(DBNull.Value.ToString())
                    End If
                Next
                datagrid_cliente.Rows.Add(specificColumns.ToArray())
            Next
        Else
        End If
    End Sub

    Sub load_data(table As String, name As String, datagridview As Guna2DataGridView)
        Dim columnMappings As New Dictionary(Of String, String)
        columnMappings.Add("CName", "nome")
        columnMappings.Add("CCPF", "CPF")
        columnMappings.Add("Phone", "celular")
        columnMappings.Add("Email", "email")
        columnMappings.Add("CCEP", "cep")
        columnMappings.Add("CBirth", "data_nasc")
        columnMappings.Add("isMember", "fidelidade")

        Dim SQL As String = "SELECT * FROM " & table & " ORDER BY " & name & " ASC"
        Dim UserData As DataTable = UseSQL(SQL)

        datagridview.Rows.Clear()

        For Each row As DataRow In UserData.Rows
            Dim specificColumns As New List(Of Object)

            For Each kvp As KeyValuePair(Of String, String) In columnMappings
                Dim columnName As String = kvp.Key
                Dim dataGridViewColumnName As String = kvp.Value
                If UserData.Columns.Contains(columnName) AndAlso Not IsDBNull(row(columnName)) Then
                    specificColumns.Add(row(columnName).ToString())
                Else
                    specificColumns.Add(DBNull.Value.ToString())
                End If
            Next
            datagridview.Rows.Add(specificColumns.ToArray())
        Next
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If datagrid_cliente.CurrentRow IsNot Nothing Then
            Dim row As DataGridViewRow = datagrid_cliente.CurrentRow

            If Not row.IsNewRow AndAlso row.Cells("CPF").Value IsNot Nothing Then
                Dim id As String = row.Cells("CPF").Value.ToString()

                ' Mensagem de confirmação para atualização
                Dim result As DialogResult = MessageBox.Show("Tem certeza que deseja atualizar os dados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    Dim query As String = "UPDATE tb_customers SET "
                    Dim columnValue As String = ""

                    ' Atualiza cada campo manualmente
                    columnValue &= "CName = '" & row.Cells("nome").Value.ToString() & "', "
                    columnValue &= "CCPF = '" & row.Cells("CPF").Value.ToString() & "', "
                    columnValue &= "Phone = '" & row.Cells("celular").Value.ToString() & "', "
                    columnValue &= "Email = '" & row.Cells("email").Value.ToString() & "', "
                    columnValue &= "CCEP = '" & row.Cells("cep").Value.ToString() & "', "
                    columnValue &= "CBirth = '" & row.Cells("data_nasc").Value.ToString() & "', "
                    columnValue &= "isMember = '" & row.Cells("fidelidade").Value.ToString() & "' "

                    query &= columnValue.Trim() ' Remove espaços extras
                    query &= " WHERE CCPF = '" & id & "'"

                    UseSQL(query)

                    ' Recarrega os dados após a atualização para exibir as alterações no DataGridView
                    load_data("tb_customers", "CName", datagrid_cliente)
                End If
            End If
        End If
    End Sub


    Private Sub datagrid_cliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_cliente.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim cellValue As Object = datagrid_cliente.Rows(e.RowIndex).Cells("CPF").Value
            ValorCelulaSelecionada = cellValue
        End If
    End Sub
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If ValorCelulaSelecionada IsNot Nothing Then
            Dim id As String = CStr(ValorCelulaSelecionada)

            Dim result As DialogResult = MessageBox.Show("Tem certeza que deseja excluir esta linha?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Dim query As String = "DELETE FROM tb_customers WHERE CCPF = '" & id & "'"
                UseSQL(query)

                load_data("tb_customers", "CName", datagrid_cliente)
                ValorCelulaSelecionada = Nothing

            End If
        Else
            MessageBox.Show("Selecione uma célula para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub datagrid_cliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_cliente.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim cellValue As Object = datagrid_cliente.Rows(e.RowIndex).Cells("CPF").Value
            ValorCelulaSelecionada = cellValue
        End If
    End Sub

    Private Sub datagrid_cliente_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles datagrid_cliente.EditingControlShowing
        Dim textBox As TextBox = TryCast(e.Control, TextBox)

        If textBox IsNot Nothing Then
            If datagrid_cliente.CurrentCell.ColumnIndex = datagrid_cliente.Columns("CPF").Index _
            OrElse datagrid_cliente.CurrentCell.ColumnIndex = datagrid_cliente.Columns("celular").Index Then

                ' Manipulador de evento para colunas que aceitam somente caracteres numéricos e limite de tamanho
                RemoveHandler textBox.KeyPress, AddressOf NumericalCells_KeyPress
                AddHandler textBox.KeyPress, AddressOf NumericalCells_KeyPress

                ' Limita o número máximo de caracteres permitidos
                AddHandler textBox.TextChanged, AddressOf TextBox_MaxLength
                textBox.MaxLength = 11 ' CPF e Celular

            ElseIf datagrid_cliente.CurrentCell.ColumnIndex = datagrid_cliente.Columns("data_nasc").Index Then

                ' Manipulador de evento para a coluna "Data de Nascimento" que aceita números, '/' e limite de tamanho
                RemoveHandler textBox.KeyPress, AddressOf DateOfBirthCell_KeyPress
                AddHandler textBox.KeyPress, AddressOf DateOfBirthCell_KeyPress

                ' Limita o número máximo de caracteres permitidos
                AddHandler textBox.TextChanged, AddressOf TextBox_MaxLength
                textBox.MaxLength = 10 ' Data de Nascimento

            ElseIf datagrid_cliente.CurrentCell.ColumnIndex = datagrid_cliente.Columns("cep").Index Then

                ' Manipulador de evento para a coluna "CEP" que aceita somente caracteres numéricos e limite de tamanho
                RemoveHandler textBox.KeyPress, AddressOf NumericalCells_KeyPress
                AddHandler textBox.KeyPress, AddressOf NumericalCells_KeyPress

                ' Limita o número máximo de caracteres permitidos
                AddHandler textBox.TextChanged, AddressOf TextBox_MaxLength
                textBox.MaxLength = 8 ' CEP
            End If
        End If
    End Sub

    Private Sub TextBox_MaxLength(sender As Object, e As EventArgs)
        Dim textBox As TextBox = DirectCast(sender, TextBox)
        Dim maxLength As Integer = 0

        If datagrid_cliente.CurrentCell.ColumnIndex = datagrid_cliente.Columns("CPF").Index _
    OrElse datagrid_cliente.CurrentCell.ColumnIndex = datagrid_cliente.Columns("celular").Index Then
            maxLength = 11 ' CPF e Celular
        ElseIf datagrid_cliente.CurrentCell.ColumnIndex = datagrid_cliente.Columns("data_nasc").Index Then
            maxLength = 10 ' Data de Nascimento

            If textBox.TextLength = 2 OrElse textBox.TextLength = 5 Then
                If textBox.Text.EndsWith("/") Then
                    textBox.Text = textBox.Text.Substring(0, textBox.TextLength - 1)
                    textBox.SelectionStart = textBox.Text.Length
                Else
                    textBox.Text += "/"
                    textBox.SelectionStart = textBox.Text.Length
                End If
            End If

            If textBox.TextLength >= 10 Then
                Dim enteredDate As Date
                If Date.TryParseExact(textBox.Text, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, enteredDate) Then
                    textBox.Text = enteredDate.ToString("dd/MM/yyyy")
                End If
            End If
        ElseIf datagrid_cliente.CurrentCell.ColumnIndex = datagrid_cliente.Columns("cep").Index Then
            maxLength = 8 ' CEP
        End If

        If textBox.Text.Length >= maxLength Then
            textBox.Text = textBox.Text.Substring(0, maxLength)
        End If
    End Sub


    Private Sub NumericalCells_KeyPress(sender As Object, e As KeyPressEventArgs)
        ' Aceita apenas caracteres numéricos e teclas de controle
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Ignora a entrada do teclado
        End If
    End Sub

    Private Sub DateOfBirthCell_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim textBox As TextBox = DirectCast(sender, TextBox)

        ' Trata o Backspace para apagar todo o texto
        If e.KeyChar = Convert.ToChar(Keys.Back) Then
            textBox.Text = ""
            e.Handled = True ' Marca o evento como tratado para evitar a inserção do caractere Backspace
            Return
        End If

        ' Aceita apenas caracteres numéricos e teclas de controle
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Ignora a entrada do teclado
        End If


    End Sub

End Class