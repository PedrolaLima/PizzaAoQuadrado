Public Class HistoricoSangria
    Inherits UserControl
    Private Shared _instance As HistoricoSangria
    Private category = "ID"

    Public Shared ReadOnly Property instance() As HistoricoSangria
        Get
            If _instance Is Nothing Then
                _instance = New HistoricoSangria()
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

    Private Sub HistoricoSangria_Load(sender As Object, e As EventArgs) Handles Me.Load
        load_data("tb_sangria", "Manager", datagrid_sangria)
        With cmb_type.Items
            .Add("ID")
            .Add("Gerente")
            .Add("Descrição")
            .Add("Data da Sangria")
        End With
        cmb_type.SelectedIndex = 1
    End Sub
    Private Sub cmb_type_TextChanged(sender As Object, e As EventArgs) Handles cmb_type.SelectedValueChanged
        Select Case cmb_type.Text
            Case "ID"
                category = "ID"
            Case "Gerente"
                category = "Manager"
            Case "Descrição"
                category = "Description"
            Case "Data da Sangria"
                category = "Date"
        End Select
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged, cmb_type.SelectedValueChanged
        If datagrid_sangria.ColumnCount > 0 Then
            Dim SQL As String = "Select * from tb_sangria where " & category & " Like '%" & txt_search.Text & "%'"
            Dim UserData As DataTable = UseSQL(SQL)

            With datagrid_sangria
                .Rows.Clear()
                For Each row As DataRow In UserData.Rows
                    Dim newRow As New List(Of Object)

                    For Each col As DataColumn In UserData.Columns
                        newRow.Add(row(col))
                    Next
                    .Rows.Add(newRow.ToArray())
                Next
            End With
        End If
    End Sub
End Class
