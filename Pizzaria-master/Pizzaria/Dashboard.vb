Public Class Dashboard
    Inherits UserControl
    Private Shared _instance As Dashboard
    Public Shared ReadOnly Property instance() As Dashboard
        Get
            If _instance Is Nothing Then
                _instance = New Dashboard()
            End If
            Return _instance
        End Get
    End Property

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        load_information()
    End Sub

    Public Sub load_information()
        Dim SQL As String = ""
        SQL &= "SELECT * FROM tb_pedidos "

        Dim UserData As DataTable = UseSQL(SQL)

        If UserData.Rows.Count > 0 Then
            Dim distinctPNumbers As IEnumerable(Of Integer) = UserData.AsEnumerable().Select(Function(row) row.Field(Of Integer)("p_number")).Distinct()
            Dim distinctCount As Integer = distinctPNumbers.Count()
            lbl_orders.Text = distinctCount.ToString
        End If

        SQL = ""
        SQL &= "SELECT cashAmount as totalDinheiro "
        SQL &= "FROM tb_cash "

        Dim totalDinheiro As DataTable = UseSQL(SQL)

        If Not IsDBNull(totalDinheiro.Rows(0)(0)) Then
            lbl_cash.Text = "R$ " & totalDinheiro.Rows(0)(0).ToString().Replace(".", ",")
        Else
            lbl_cash.Text = "R$ 0,00"
        End If

        SQL = ""
        SQL &= "SELECT bankAccountAmount as totalBanco "
        SQL &= "FROM tb_cash "

        Dim totalBanco As DataTable = UseSQL(SQL)

        If Not IsDBNull(totalBanco.Rows(0)(0)) Then
            lbl_bank.Text = "R$ " & totalBanco.Rows(0)(0).ToString().Replace(".", ",")
        Else
            lbl_bank.Text = "R$ 0,00"
        End If
    End Sub
End Class
