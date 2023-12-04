Public Class Admin
    Inherits UserControl
    Private Shared _instance As Admin
    Public Shared ReadOnly Property instance() As Admin
        Get
            If _instance Is Nothing Then
                _instance = New Admin()
            End If
            Return _instance
        End Get
    End Property

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            Me.Hide()
            If Not Form2.Panel9.Controls.Contains(Cadastro.instance) Then
                Form2.Controls.Add(Cadastro.instance)
                Cadastro.instance.Dock = DockStyle.Fill
                Cadastro.instance.BringToFront()
                Cadastro.instance.Visible = True
                Me.Hide()
            End If
            Cadastro.instance.BringToFront()
            Cadastro.instance.Visible = True
        Catch ex As Exception
            MsgBox("Erro ao chamar cadastro!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub
    Private Sub btn_gerenciarColab_Click(sender As Object, e As EventArgs) Handles btn_gerenciarColab.Click
        Me.Hide()
        If Not Form2.Panel9.Controls.Contains(GerenciarColab.instance) Then
            Form2.Controls.Add(GerenciarColab.instance)
            GerenciarColab.instance.Dock = DockStyle.Fill
            GerenciarColab.instance.BringToFront()
            GerenciarColab.instance.Visible = True
            Me.Hide()
        End If
        GerenciarColab.instance.BringToFront()
        GerenciarColab.instance.Visible = True
        GerenciarColab.instance.formLoad()
    End Sub

    Private Sub btn_gerenciarcli_Click(sender As Object, e As EventArgs) Handles btn_gerenciarcli.Click
        Me.Hide()
        If Not Form2.Panel9.Controls.Contains(GerenciarCliente.instance) Then
            Form2.Controls.Add(GerenciarCliente.instance)
            GerenciarCliente.instance.Dock = DockStyle.Fill
            GerenciarCliente.instance.BringToFront()
            GerenciarCliente.instance.Visible = True
            Me.Hide()
        End If
        GerenciarCliente.instance.BringToFront()
        GerenciarCliente.instance.Visible = True
        GerenciarCliente.instance.load_data("tb_customers", "CName", GerenciarCliente.instance.datagrid_cliente)
    End Sub

    Private Sub btn_sangria_Click(sender As Object, e As EventArgs) Handles btn_sangria.Click
        Try
            Me.Hide()
            If Not Form2.Panel9.Controls.Contains(Sangria.instance) Then
                Form2.Controls.Add(Sangria.instance)
                Sangria.instance.Dock = DockStyle.Fill
                Sangria.instance.BringToFront()
                Sangria.instance.Visible = True
                Me.Hide()
            End If
            Sangria.instance.BringToFront()
            Sangria.instance.Visible = True
            Sangria.instance.carregarDinheiro()
        Catch ex As Exception
            MsgBox("Erro ao chamar Sangria!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub
End Class
