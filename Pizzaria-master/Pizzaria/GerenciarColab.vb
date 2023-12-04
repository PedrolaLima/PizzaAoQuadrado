Imports Guna.UI2.WinForms

Public Class GerenciarColab
    Inherits UserControl
    Private Shared _instance As GerenciarColab
    Private category = "Name"
    Private ValorCelulaSelecionada As Object
    Private formLoaded As Boolean = False
    Public Shared ReadOnly Property instance() As GerenciarColab
        Get
            If _instance Is Nothing Then
                _instance = New GerenciarColab()
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
            Form2.loadForm()
        End If
        Admin.instance.BringToFront()
        Admin.instance.Visible = True
        Form2.loadForm()
    End Sub

    Sub formLoad()
        load_data("tb_login", "Name", datagrid_colab)
        With cmb_type.Items
            .Add("Nome")
            .Add("Usuário")
            .Add("Celular")
            .Add("Email")
            .Add("CPF")
            .Add("CEP")
        End With
        cmb_type.SelectedIndex = 0

        FormatCargoColumnLoad()
        formLoaded = True
        datagrid_colab.ClearSelection()
    End Sub
    Private Sub GerenciarColab_Load(sender As Object, e As EventArgs) Handles Me.Load
        formLoad()
    End Sub
    Private Sub cmb_type_TextChanged(sender As Object, e As EventArgs) Handles cmb_type.SelectedValueChanged
        Select Case cmb_type.Text
            Case "Nome"
                category = "Name"
            Case "Usuário"
                category = "Username"
            Case "Email"
                category = "Email"
            Case "Celular"
                category = "Phone"
            Case "CPF"
                category = "CPF"
            Case "CEP"
                category = "CEP"
        End Select
    End Sub
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged, cmb_type.SelectedValueChanged
        Dim columnMappings As New Dictionary(Of String, String)
        columnMappings.Add("Name", "nome")
        columnMappings.Add("Username", "user")
        columnMappings.Add("Phone", "celular")
        columnMappings.Add("Email", "email")
        columnMappings.Add("CPF", "CPF")
        columnMappings.Add("Jcode", "cargo")
        columnMappings.Add("Password", "senha")
        columnMappings.Add("", "vendas")
        columnMappings.Add("BDate", "data_nasc")
        columnMappings.Add("CEP", "cep")
        columnMappings.Add("NumAdress", "numero")
        columnMappings.Add("Comp", "complemento")

        Dim SQL As String = "Select * from tb_login WHERE " & category & " Like '%" & txt_search.Text & "%'"
        Dim UserData As DataTable = UseSQL(SQL)

        datagrid_colab.Rows.Clear()

        If datagrid_colab.ColumnCount > 0 Then
            For Each row As DataRow In UserData.Rows
                Dim specificColumns As New List(Of Object)

                For Each kvp As KeyValuePair(Of String, String) In columnMappings
                    Dim columnName As String = kvp.Key
                    Dim dataGridViewColumnName As String = kvp.Value

                    If UserData.Columns.Contains(columnName) AndAlso Not IsDBNull(row(columnName)) Then
                        If columnName = "BDate" Then ' Verifica se é a coluna de data
                            ' Formata a data para dd/mm/yyyy
                            specificColumns.Add(Convert.ToDateTime(row(columnName)).ToString("dd/MM/yyyy"))
                        Else
                            specificColumns.Add(row(columnName).ToString())
                        End If
                    Else
                        Dim email As String = row("email").ToString()
                        Dim username As String = row("Username").ToString()

                        Dim Query As String = "SELECT COUNT(DISTINCT p_number) AS SomaValores " &
                                            "FROM tb_pedidos " &
                                            "WHERE Employee = '" & email & "' OR Employee = '" & username & "'"

                        Dim resultadoSoma As DataTable = UseSQL(Query)
                        specificColumns.Add(resultadoSoma.Rows(0)(0).ToString())
                    End If
                Next
                datagrid_colab.Rows.Add(specificColumns.ToArray())
            Next
        Else
        End If
    End Sub

    Sub load_data(table As String, name As String, datagridview As Guna2DataGridView)
        Dim columnMappings As New Dictionary(Of String, String)
        columnMappings.Add("Name", "nome")
        columnMappings.Add("Username", "user")
        columnMappings.Add("Phone", "celular")
        columnMappings.Add("Email", "email")
        columnMappings.Add("CPF", "CPF")
        columnMappings.Add("Jcode", "cargo")
        columnMappings.Add("Password", "senha")
        columnMappings.Add("", "vendas")
        columnMappings.Add("BDate", "data_nasc")
        columnMappings.Add("CEP", "cep")
        columnMappings.Add("NumAdress", "numero")
        columnMappings.Add("Comp", "complemento")


        Dim SQL As String = "SELECT * FROM " & table & " ORDER BY " & name & " ASC"
        Dim UserData As DataTable = UseSQL(SQL)

        datagridview.Rows.Clear()

        For Each row As DataRow In UserData.Rows
            Dim specificColumns As New List(Of Object)

            For Each kvp As KeyValuePair(Of String, String) In columnMappings
                Dim columnName As String = kvp.Key
                Dim dataGridViewColumnName As String = kvp.Value

                If UserData.Columns.Contains(columnName) AndAlso Not IsDBNull(row(columnName)) Then
                    If columnName = "BDate" Then ' Verifica se é a coluna de data
                        specificColumns.Add(Convert.ToDateTime(row(columnName)).ToString("dd/MM/yyyy"))
                    Else
                        specificColumns.Add(row(columnName).ToString())
                    End If
                Else
                    Dim email As String = row("email").ToString()
                    Dim username As String = row("Username").ToString()

                    Dim Query As String = "SELECT COUNT(DISTINCT p_number) AS SomaValores " &
                                        "FROM tb_pedidos " &
                                        "WHERE Employee = '" & email & "' OR Employee = '" & username & "'"

                    Dim resultadoSoma As DataTable = UseSQL(Query)
                    specificColumns.Add(resultadoSoma.Rows(0)(0).ToString())
                End If
            Next
            datagridview.Rows.Add(specificColumns.ToArray())
        Next
    End Sub
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If datagrid_colab.CurrentRow IsNot Nothing Then
            Dim row As DataGridViewRow = datagrid_colab.CurrentRow

            If Not row.IsNewRow AndAlso row.Cells("CPF").Value IsNot Nothing Then
                Dim id As String = row.Cells("CPF").Value.ToString()

                Dim result As DialogResult = MessageBox.Show("Tem certeza que deseja atualizar os dados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    Dim query As String = "UPDATE tb_login SET "
                    Dim columnValue As String = ""

                    columnValue &= "Name = '" & row.Cells("nome").Value.ToString() & "', "
                    columnValue &= "Username = '" & row.Cells("user").Value.ToString() & "', "
                    columnValue &= "Phone = '" & row.Cells("celular").Value.ToString() & "', "
                    columnValue &= "Email = '" & row.Cells("email").Value.ToString() & "', "
                    columnValue &= "CPF = '" & row.Cells("CPF").Value.ToString() & "', "
                    columnValue &= "CEP = '" & row.Cells("cep").Value.ToString() & "', "
                    columnValue &= "Photo = '" & path & "', "


                    Dim cargoValue As String = row.Cells("cargo").Value.ToString()
                    Dim cargoCode As String = ""
                    Select Case cargoValue
                        Case "Operador de Caixa"
                            cargoCode = "1"
                        Case "Gerente"
                            cargoCode = "2"
                        Case Else
                            cargoCode = "3" '
                    End Select

                    columnValue &= "Jcode = '" & cargoCode & "', "
                    columnValue &= "Password = '" & row.Cells("senha").Value.ToString() & "', "
                    columnValue &= "BDate = '" & Convert.ToDateTime(row.Cells("data_nasc").Value).ToString("yyyy-MM-dd") & "', "
                    columnValue &= "NumAddress = '" & row.Cells("numero").Value.ToString() & "', "
                    columnValue &= "Comp = '" & row.Cells("complemento").Value.ToString() & "'"

                    query &= columnValue.Trim()
                    query &= " WHERE CPF = '" & id & "'"

                    UseSQL(query)

                    load_data("tb_login", "Name", datagrid_colab)

                    FormatCargoColumnLoad()
                End If
            End If
        End If
    End Sub

    Private Sub datagrid_colab_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_colab.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim cellValue As Object = datagrid_colab.Rows(e.RowIndex).Cells("CPF").Value
            ValorCelulaSelecionada = cellValue

            Dim username As String = datagrid_colab.Rows(e.RowIndex).Cells("user").Value.ToString()

            ' Chama a função UserPhoto para obter o caminho da imagem do usuário
            Dim imagePath As String = UserPhoto(username)

            ' Atualiza a imagem na PictureBox
            If imagePath IsNot Nothing Then
                pic_user.ImageLocation = imagePath
            Else
                ' Se a imagem não estiver disponível, você pode definir uma imagem padrão ou limpar a PictureBox
                pic_user.Image = Nothing
            End If
        End If
    End Sub
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If ValorCelulaSelecionada IsNot Nothing Then
            Dim id As String = CStr(ValorCelulaSelecionada)

            ' Obter o email e o username da linha selecionada
            Dim emailCell As String = datagrid_colab.CurrentRow.Cells("email").Value.ToString().ToLower()
            Dim usernameCell As String = datagrid_colab.CurrentRow.Cells("user").Value.ToString().ToLower()

            ' Verificar se o email ou username da célula selecionada é igual ao userLogged
            If emailCell = userLogged.ToLower OrElse usernameCell = userLogged.ToLower Then
                MessageBox.Show("Você não pode excluir o usuário que está logado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else
                Dim result As DialogResult = MessageBox.Show("Tem certeza que deseja excluir esta linha?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    Dim query As String = "DELETE FROM tb_login WHERE CPF = '" & id & "'"
                    UseSQL(query)

                    load_data("tb_login", "Name", datagrid_colab)
                    ValorCelulaSelecionada = Nothing
                End If
            End If
        Else
            MessageBox.Show("Selecione uma célula para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub datagrid_colab_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles datagrid_colab.EditingControlShowing
        Dim textBox As TextBox = TryCast(e.Control, TextBox)

        If textBox IsNot Nothing Then
            datagrid_colab.Columns("vendas").ReadOnly = True
            datagrid_colab.Columns("cargo").ReadOnly = True

            If datagrid_colab.CurrentCell.ColumnIndex <> datagrid_colab.Columns("CPF").Index AndAlso
            datagrid_colab.CurrentCell.ColumnIndex <> datagrid_colab.Columns("celular").Index AndAlso
            datagrid_colab.CurrentCell.ColumnIndex <> datagrid_colab.Columns("data_nasc").Index AndAlso
            datagrid_colab.CurrentCell.ColumnIndex <> datagrid_colab.Columns("cep").Index Then

                RemoveHandler textBox.KeyPress, AddressOf NumericalCells_KeyPress
                RemoveHandler textBox.KeyPress, AddressOf DateOfBirthCell_KeyPress
                RemoveHandler textBox.TextChanged, AddressOf TextBox_MaxLength
                textBox.MaxLength = Integer.MaxValue

            ElseIf datagrid_colab.CurrentCell.ColumnIndex = datagrid_colab.Columns("CPF").Index _
             OrElse datagrid_colab.CurrentCell.ColumnIndex = datagrid_colab.Columns("celular").Index Then

                RemoveHandler textBox.KeyPress, AddressOf NumericalCells_KeyPress
                AddHandler textBox.KeyPress, AddressOf NumericalCells_KeyPress

                AddHandler textBox.TextChanged, AddressOf TextBox_MaxLength
                textBox.MaxLength = 11 ' CPF e Celular

            ElseIf datagrid_colab.CurrentCell.ColumnIndex = datagrid_colab.Columns("data_nasc").Index Then

                RemoveHandler textBox.KeyPress, AddressOf DateOfBirthCell_KeyPress
                AddHandler textBox.KeyPress, AddressOf DateOfBirthCell_KeyPress

                AddHandler textBox.TextChanged, AddressOf TextBox_MaxLength
                textBox.MaxLength = 10 ' Data de Nascimento

            ElseIf datagrid_colab.CurrentCell.ColumnIndex = datagrid_colab.Columns("cep").Index Then

                RemoveHandler textBox.KeyPress, AddressOf NumericalCells_KeyPress
                AddHandler textBox.KeyPress, AddressOf NumericalCells_KeyPress

                AddHandler textBox.TextChanged, AddressOf TextBox_MaxLength
                textBox.MaxLength = 8 ' CEP


            ElseIf datagrid_colab.CurrentCell.ColumnIndex = datagrid_colab.Columns("numero").Index Then

                RemoveHandler textBox.KeyPress, AddressOf NumericalCells_KeyPress
                AddHandler textBox.KeyPress, AddressOf NumericalCells_KeyPress

                AddHandler textBox.TextChanged, AddressOf TextBox_MaxLength
                textBox.MaxLength = 5 ' Número de Residência
            End If
        End If
    End Sub

    Private Sub TextBox_MaxLength(sender As Object, e As EventArgs)
        Dim textBox As TextBox = DirectCast(sender, TextBox)
        Dim maxLength As Integer = 0

        If datagrid_colab.CurrentCell.ColumnIndex = datagrid_colab.Columns("CPF").Index _
        OrElse datagrid_colab.CurrentCell.ColumnIndex = datagrid_colab.Columns("celular").Index Then
            maxLength = 11 ' CPF e Celular
        ElseIf datagrid_colab.CurrentCell.ColumnIndex = datagrid_colab.Columns("data_nasc").Index Then
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
        ElseIf datagrid_colab.CurrentCell.ColumnIndex = datagrid_colab.Columns("cep").Index Then
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
    Private Sub FormatCargoColumnLoad()
        For Each row As DataGridViewRow In datagrid_colab.Rows
            If row.Cells("cargo").Value IsNot Nothing Then
                Dim cargoValue As String = row.Cells("cargo").Value.ToString()

                ' Substitui os valores de acordo com as condições
                Select Case cargoValue
                    Case "1"
                        row.Cells("cargo").Value = "Operador de Caixa"
                        row.DefaultCellStyle.BackColor = Color.FromArgb(216, 242, 208)
                    Case "2"
                        row.Cells("cargo").Value = "Gerente"
                        row.DefaultCellStyle.BackColor = Color.FromArgb(207, 240, 252)
                    Case Else
                        row.Cells("cargo").Value = "Bloqueado"
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 220, 228)
                End Select
            End If
        Next
    End Sub
    Private Sub datagrid_colab_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_colab.CellDoubleClick
        If formLoaded AndAlso e.ColumnIndex = datagrid_colab.Columns("cargo").Index AndAlso e.RowIndex >= 0 Then
            Dim currentCellValue As String = datagrid_colab.Rows(e.RowIndex).Cells("cargo").Value.ToString()
            If currentCellValue = "Operador de Caixa" Then
                datagrid_colab.Rows(e.RowIndex).Cells("cargo").Value = "2"
            ElseIf currentCellValue = "Gerente" Then
                datagrid_colab.Rows(e.RowIndex).Cells("cargo").Value = "1"
            End If
            FormatCargoColumn(datagrid_colab.Rows(e.RowIndex))
        End If
    End Sub

    Private Sub FormatCargoColumn(row As DataGridViewRow)
        If row.Cells("cargo").Value IsNot Nothing Then
            Dim cargoValue As String = row.Cells("cargo").Value.ToString()

            ' Substitui os valores de acordo com as condições
            Select Case cargoValue
                Case "1"
                    row.Cells("cargo").Value = "Operador de Caixa"
                    row.DefaultCellStyle.BackColor = Color.FromArgb(216, 242, 208)
                Case "2"
                    row.Cells("cargo").Value = "Gerente"
                    row.DefaultCellStyle.BackColor = Color.FromArgb(207, 240, 252)
                Case Else
                    row.Cells("cargo").Value = "Bloqueado"
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 220, 228)
            End Select
        End If
    End Sub

    Private Sub btn_status_Click(sender As Object, e As EventArgs) Handles btn_status.Click
        If ValorCelulaSelecionada IsNot Nothing Then
            Dim id As String = CStr(ValorCelulaSelecionada)
            Dim row As DataGridViewRow = datagrid_colab.CurrentRow

            If row.Cells("cargo").Value IsNot Nothing Then
                Dim cargoValue As String = row.Cells("cargo").Value.ToString()

                ' Verifica o valor atual e atualiza conforme necessário
                If cargoValue = "Operador de Caixa" Then
                    row.Cells("cargo").Value = "3"
                ElseIf cargoValue = "Gerente" Then
                    row.Cells("cargo").Value = "3"
                ElseIf cargoValue = "Bloqueado" Then
                    row.Cells("cargo").Value = "1"
                End If

                ' Atualiza a exibição da coluna "cargo"
                FormatCargoColumn(row)
            End If
        Else
            MessageBox.Show("Selecione uma célula para atualizar o status.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

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

    Private Sub pic_user_Click(sender As Object, e As EventArgs) Handles pic_user.Click
        If datagrid_colab.CurrentRow IsNot Nothing Then
            Dim OpenFileDialog As New OpenFileDialog
            With OpenFileDialog
                .Filter = "Arquivos de Imagem (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG"
                .Title = "Selecione uma Foto"
                .InitialDirectory = Application.StartupPath & "\Imagens"
                .ShowDialog()
                path = .FileName
                If path <> Nothing Then
                    pic_user.Load(path)
                End If
            End With

        Else
            MessageBox.Show("Selecione uma célula antes de adicionar uma foto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub GerenciarColab_Click(sender As Object, e As EventArgs) Handles Me.Click
        datagrid_colab.ClearSelection()
    End Sub
End Class
