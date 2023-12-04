Imports Guna.UI.WinForms
Imports Guna.UI2.WinForms

Public Class HistoricoPedido
    Inherits UserControl
    Private Shared _instance As HistoricoPedido
    Private category = "p_number"
    Public Shared ReadOnly Property instance() As HistoricoPedido
        Get
            If _instance Is Nothing Then
                _instance = New HistoricoPedido()
            End If
            Return _instance
        End Get
    End Property

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Hide()
        If Not Form2.Panel9.Controls.Contains(Historico.instance) Then
            Form2.Controls.Add(Historico.instance)
            Historico.instance.Dock = DockStyle.Fill
            Historico.instance.BringToFront()
            Historico.instance.Visible = True
        End If
        Historico.instance.BringToFront()
        Historico.instance.Visible = True
    End Sub

    Private Sub HistoricoPedido_Load(sender As Object, e As EventArgs) Handles Me.Load
        load_data("tb_pedidos", "orderDate", datagrid_pedido)
        With cmb_type.Items
            .Add("ID")
            .Add("Nome")
            .Add("CPF")
            .Add("Quantidade")
            .Add("Sabor")
            .Add("Forma de Pagamento")
            .Add("Colaborador")
            .Add("Data da Compra")
        End With
        cmb_type.SelectedIndex = 1
    End Sub

    Private Sub cmb_type_TextChanged(sender As Object, e As EventArgs) Handles cmb_type.SelectedValueChanged
        Select Case cmb_type.Text
            Case "ID"
                category = "p_number"
            Case "Nome"
                category = "customerFullName"
            Case "CPF"
                category = "customerCPF"
            Case "Quantidade"
                category = "quantity"
            Case "Sabor"
                category = "pizzaFlavor"
            Case "Forma de Pagamento"
                category = "paymentMethod"
            Case "Colaborador"
                category = "Employee"
            Case "Data da Compra"
                category = "orderDate"
        End Select
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged, cmb_type.SelectedValueChanged
        Dim columnMappings As New Dictionary(Of String, String)
        columnMappings.Add("p_number", "ID")
        columnMappings.Add("orderDate", "orderDate")
        columnMappings.Add("Employee", "employee")
        columnMappings.Add("customerFullName", "CLIENTE")
        columnMappings.Add("customerPhone", "CELULAR")
        columnMappings.Add("customerCPF", "CPF")
        columnMappings.Add("pizzaFlavor", "pizzaFlavor")
        columnMappings.Add("pizzaSize", "pizzaSize")
        columnMappings.Add("quantity", "quantity")
        columnMappings.Add("paymentMethod", "PAGAMENTO")
        columnMappings.Add("orderValue", "PRECO")
        columnMappings.Add("discount", "DESCONTO")
        columnMappings.Add("totalPrice", "TOTAL")
        columnMappings.Add("pricePaid", "VALORPAGO")
        columnMappings.Add("changeNeeded", "TROCO")

        Dim SQL As String = "Select * from tb_pedidos where " & category & " Like '%" & txt_search.Text & "%'"
        Dim UserData As DataTable = UseSQL(SQL)

        datagrid_pedido.Rows.Clear()

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
            datagrid_pedido.Rows.Add(specificColumns.ToArray())
        Next
    End Sub
    Public Sub load_data(table As String, name As String, datagridview As Guna2DataGridView)
        Dim columnMappings As New Dictionary(Of String, String)
        columnMappings.Add("p_number", "ID")
        columnMappings.Add("orderDate", "orderDate")
        columnMappings.Add("Employee", "employee")
        columnMappings.Add("customerFullName", "CLIENTE")
        columnMappings.Add("customerPhone", "CELULAR")
        columnMappings.Add("customerCPF", "CPF")
        columnMappings.Add("pizzaFlavor", "pizzaFlavor")
        columnMappings.Add("pizzaSize", "pizzaSize")
        columnMappings.Add("quantity", "quantity")
        columnMappings.Add("paymentMethod", "PAGAMENTO")
        columnMappings.Add("orderValue", "PRECO")
        columnMappings.Add("discount", "DESCONTO")
        columnMappings.Add("totalPrice", "TOTAL")
        columnMappings.Add("pricePaid", "VALORPAGO")
        columnMappings.Add("changeNeeded", "TROCO")

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
End Class