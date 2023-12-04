Public Class Historico
    Inherits UserControl
    Private Shared _instance As Historico
    Public Shared ReadOnly Property instance() As Historico
        Get
            If _instance Is Nothing Then
                _instance = New Historico()
            End If
            Return _instance
        End Get
    End Property

    Private Sub btn_historicoPedido_Click(sender As Object, e As EventArgs) Handles btn_historicoPedido.Click
        Try
            Me.Hide()
            If Not Form2.Panel9.Controls.Contains(HistoricoPedido.instance) Then
                Form2.Controls.Add(HistoricoPedido.instance)
                HistoricoPedido.instance.Dock = DockStyle.Fill
                HistoricoPedido.instance.BringToFront()
                HistoricoPedido.instance.Visible = True
                Me.Hide()
            End If
            HistoricoPedido.instance.BringToFront()
            HistoricoPedido.instance.Visible = True
            HistoricoPedido.instance.load_data("tb_pedidos", "orderDate", HistoricoPedido.instance.datagrid_pedido)
        Catch ex As Exception
            MsgBox("Erro ao chamar histórico de pedido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub btn_historicoSangria_Click(sender As Object, e As EventArgs) Handles btn_historicoSangria.Click
        Try
            Me.Hide()
            If Not Form2.Panel9.Controls.Contains(HistoricoSangria.instance) Then
                Form2.Controls.Add(HistoricoSangria.instance)
                HistoricoSangria.instance.Dock = DockStyle.Fill
                HistoricoSangria.instance.BringToFront()
                HistoricoSangria.instance.Visible = True
                Me.Hide()
            End If
            HistoricoSangria.instance.BringToFront()
            HistoricoSangria.instance.Visible = True
            load_data("tb_sangria", "Manager", HistoricoSangria.instance.datagrid_sangria)
        Catch ex As Exception
            MsgBox("Erro ao chamar histórico de sangria!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub
End Class
