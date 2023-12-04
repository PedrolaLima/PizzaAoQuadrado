Public Class Caixa
    Inherits UserControl
    Private Shared _instance As Caixa
    Public Shared ReadOnly Property instance() As Caixa
        Get
            If _instance Is Nothing Then
                _instance = New Caixa()
            End If
            Return _instance
        End Get
    End Property
    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        chamar_cadastroCliente()
    End Sub
    Function chamar_cadastroCliente()
        Me.Hide()
        If Not Form2.Panel9.Controls.Contains(CadastroCliente.instance) Then
            Form2.Controls.Add(CadastroCliente.instance)
            CadastroCliente.instance.Dock = DockStyle.Fill
            CadastroCliente.instance.BringToFront()
            CadastroCliente.instance.Visible = True
            Me.Hide()
        End If
        CadastroCliente.instance.BringToFront()
        CadastroCliente.instance.Visible = True
        Return Nothing
    End Function
    Private Sub btn_addpizza_Click(sender As Object, e As EventArgs) Handles btn_addpizza.Click
        chamar_adicionarPizza()
    End Sub
    Function chamar_adicionarPizza()
        Me.Hide()
        If Not Form2.Panel9.Controls.Contains(AdicionarPizza.instance) Then
            Form2.Controls.Add(AdicionarPizza.instance)
            AdicionarPizza.instance.Dock = DockStyle.Fill
            AdicionarPizza.instance.BringToFront()
            AdicionarPizza.instance.Visible = True
            Me.Hide()
        End If
        AdicionarPizza.instance.BringToFront()
        AdicionarPizza.instance.Visible = True
        Return Nothing
    End Function
    Private Sub btn_pedido_Click(sender As Object, e As EventArgs) Handles btn_pedido.Click
        chamar_Pedido()
        UserControl1.instance.LimparItens()
        UserControl1.instance.CarregarComboBoxes()
    End Sub
    Function chamar_Pedido()
        Me.Hide()
        If Not Form2.Panel9.Controls.Contains(UserControl1.instance) Then
            Form2.Controls.Add(UserControl1.instance)
            UserControl1.instance.Dock = DockStyle.Fill
            UserControl1.instance.BringToFront()
            UserControl1.instance.Visible = True
            Me.Hide()
        End If
        UserControl1.instance.BringToFront()
        UserControl1.instance.Visible = True
        Return Nothing
    End Function
End Class
