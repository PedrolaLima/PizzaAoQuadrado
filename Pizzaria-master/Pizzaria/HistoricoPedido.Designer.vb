<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoricoPedido
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HistoricoPedido))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.datagrid_pedido = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.orderDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CELULAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pizzaFlavor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pizzaSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAGAMENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCONTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALORPAGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TROCO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.cmb_type = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_search = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel3.SuspendLayout()
        CType(Me.datagrid_pedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btn_voltar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1069, 27)
        Me.Panel3.TabIndex = 96
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.Transparent
        Me.btn_voltar.BackgroundImage = CType(resources.GetObject("btn_voltar.BackgroundImage"), System.Drawing.Image)
        Me.btn_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_voltar.FlatAppearance.BorderSize = 0
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Location = New System.Drawing.Point(1031, 0)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(38, 27)
        Me.btn_voltar.TabIndex = 15
        Me.btn_voltar.Text = " "
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'datagrid_pedido
        '
        Me.datagrid_pedido.AllowUserToAddRows = False
        Me.datagrid_pedido.AllowUserToDeleteRows = False
        Me.datagrid_pedido.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.datagrid_pedido.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagrid_pedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.datagrid_pedido.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.datagrid_pedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.datagrid_pedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_pedido.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datagrid_pedido.ColumnHeadersHeight = 50
        Me.datagrid_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagrid_pedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.orderDate, Me.employee, Me.CLIENTE, Me.CELULAR, Me.CPF, Me.pizzaFlavor, Me.pizzaSize, Me.quantity, Me.PAGAMENTO, Me.PRECO, Me.DESCONTO, Me.TOTAL, Me.VALORPAGO, Me.TROCO})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid_pedido.DefaultCellStyle = DataGridViewCellStyle3
        Me.datagrid_pedido.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.datagrid_pedido.Location = New System.Drawing.Point(20, 123)
        Me.datagrid_pedido.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.datagrid_pedido.Name = "datagrid_pedido"
        Me.datagrid_pedido.ReadOnly = True
        Me.datagrid_pedido.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_pedido.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.datagrid_pedido.RowHeadersVisible = False
        Me.datagrid_pedido.RowHeadersWidth = 51
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.datagrid_pedido.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.datagrid_pedido.Size = New System.Drawing.Size(1025, 487)
        Me.datagrid_pedido.TabIndex = 122
        Me.datagrid_pedido.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt
        Me.datagrid_pedido.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.datagrid_pedido.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid_pedido.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.datagrid_pedido.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.datagrid_pedido.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datagrid_pedido.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.datagrid_pedido.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.datagrid_pedido.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid_pedido.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.datagrid_pedido.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid_pedido.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.datagrid_pedido.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagrid_pedido.ThemeStyle.HeaderStyle.Height = 50
        Me.datagrid_pedido.ThemeStyle.ReadOnly = True
        Me.datagrid_pedido.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.datagrid_pedido.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagrid_pedido.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid_pedido.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.datagrid_pedido.ThemeStyle.RowsStyle.Height = 22
        Me.datagrid_pedido.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.datagrid_pedido.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'ID
        '
        Me.ID.FillWeight = 50.0!
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 43
        '
        'orderDate
        '
        Me.orderDate.FillWeight = 170.0!
        Me.orderDate.HeaderText = "DATA"
        Me.orderDate.MinimumWidth = 6
        Me.orderDate.Name = "orderDate"
        Me.orderDate.ReadOnly = True
        Me.orderDate.Width = 61
        '
        'employee
        '
        Me.employee.HeaderText = "COLABORADOR"
        Me.employee.MinimumWidth = 6
        Me.employee.Name = "employee"
        Me.employee.ReadOnly = True
        Me.employee.Width = 114
        '
        'CLIENTE
        '
        Me.CLIENTE.FillWeight = 150.0!
        Me.CLIENTE.HeaderText = "CLIENTE"
        Me.CLIENTE.MinimumWidth = 6
        Me.CLIENTE.Name = "CLIENTE"
        Me.CLIENTE.ReadOnly = True
        Me.CLIENTE.Width = 77
        '
        'CELULAR
        '
        Me.CELULAR.HeaderText = "CELULAR"
        Me.CELULAR.MinimumWidth = 6
        Me.CELULAR.Name = "CELULAR"
        Me.CELULAR.ReadOnly = True
        Me.CELULAR.Width = 81
        '
        'CPF
        '
        Me.CPF.HeaderText = "CPF DO CLIENTE"
        Me.CPF.MinimumWidth = 6
        Me.CPF.Name = "CPF"
        Me.CPF.ReadOnly = True
        Me.CPF.Width = 109
        '
        'pizzaFlavor
        '
        Me.pizzaFlavor.HeaderText = "SABOR DA PIZZA"
        Me.pizzaFlavor.MinimumWidth = 6
        Me.pizzaFlavor.Name = "pizzaFlavor"
        Me.pizzaFlavor.ReadOnly = True
        Me.pizzaFlavor.Width = 75
        '
        'pizzaSize
        '
        Me.pizzaSize.HeaderText = "TAMANHO DA PIZZA"
        Me.pizzaSize.MinimumWidth = 6
        Me.pizzaSize.Name = "pizzaSize"
        Me.pizzaSize.ReadOnly = True
        Me.pizzaSize.Width = 98
        '
        'quantity
        '
        Me.quantity.HeaderText = "QUANTIDADE"
        Me.quantity.MinimumWidth = 6
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        Me.quantity.Width = 103
        '
        'PAGAMENTO
        '
        Me.PAGAMENTO.FillWeight = 120.0!
        Me.PAGAMENTO.HeaderText = "FORMA DE PAGAMENTO"
        Me.PAGAMENTO.MinimumWidth = 6
        Me.PAGAMENTO.Name = "PAGAMENTO"
        Me.PAGAMENTO.ReadOnly = True
        Me.PAGAMENTO.Width = 145
        '
        'PRECO
        '
        Me.PRECO.FillWeight = 80.0!
        Me.PRECO.HeaderText = "PREÇO"
        Me.PRECO.MinimumWidth = 6
        Me.PRECO.Name = "PRECO"
        Me.PRECO.ReadOnly = True
        Me.PRECO.Width = 69
        '
        'DESCONTO
        '
        Me.DESCONTO.HeaderText = "DESCONTO"
        Me.DESCONTO.MinimumWidth = 6
        Me.DESCONTO.Name = "DESCONTO"
        Me.DESCONTO.ReadOnly = True
        Me.DESCONTO.Width = 92
        '
        'TOTAL
        '
        Me.TOTAL.HeaderText = "TOTAL"
        Me.TOTAL.MinimumWidth = 6
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.ReadOnly = True
        Me.TOTAL.Width = 67
        '
        'VALORPAGO
        '
        Me.VALORPAGO.HeaderText = "VALOR PAGO"
        Me.VALORPAGO.MinimumWidth = 6
        Me.VALORPAGO.Name = "VALORPAGO"
        Me.VALORPAGO.ReadOnly = True
        Me.VALORPAGO.Width = 93
        '
        'TROCO
        '
        Me.TROCO.FillWeight = 80.0!
        Me.TROCO.HeaderText = "TROCO"
        Me.TROCO.MinimumWidth = 6
        Me.TROCO.Name = "TROCO"
        Me.TROCO.ReadOnly = True
        Me.TROCO.Width = 70
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.BorderColor = System.Drawing.Color.Black
        Me.Guna2GradientPanel2.BorderThickness = 1
        Me.Guna2GradientPanel2.Controls.Add(Me.cmb_type)
        Me.Guna2GradientPanel2.Controls.Add(Me.GunaLabel5)
        Me.Guna2GradientPanel2.Controls.Add(Me.txt_search)
        Me.Guna2GradientPanel2.Controls.Add(Me.GunaLabel4)
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.LightSalmon
        Me.Guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(20, 33)
        Me.Guna2GradientPanel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(600, 84)
        Me.Guna2GradientPanel2.TabIndex = 123
        '
        'cmb_type
        '
        Me.cmb_type.BackColor = System.Drawing.Color.Transparent
        Me.cmb_type.BorderThickness = 2
        Me.cmb_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_type.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_type.Font = New System.Drawing.Font("Roboto", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_type.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_type.ItemHeight = 23
        Me.cmb_type.Location = New System.Drawing.Point(377, 27)
        Me.cmb_type.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(182, 29)
        Me.cmb_type.TabIndex = 83
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel5.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(378, 10)
        Me.GunaLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(139, 14)
        Me.GunaLabel5.TabIndex = 82
        Me.GunaLabel5.Text = "Selecione uma categoria:"
        '
        'txt_search
        '
        Me.txt_search.BackColor = System.Drawing.SystemColors.Window
        Me.txt_search.BaseColor = System.Drawing.Color.White
        Me.txt_search.BorderColor = System.Drawing.Color.Silver
        Me.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_search.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_search.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_search.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_search.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(64, 26)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_search.MaxLength = 30
        Me.txt_search.Name = "txt_search"
        Me.txt_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_search.SelectedText = ""
        Me.txt_search.Size = New System.Drawing.Size(205, 29)
        Me.txt_search.TabIndex = 72
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(61, 10)
        Me.GunaLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(185, 14)
        Me.GunaLabel4.TabIndex = 81
        Me.GunaLabel4.Text = "Digite um parâmetro de pesquisa:"
        '
        'HistoricoPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.Controls.Add(Me.datagrid_pedido)
        Me.Controls.Add(Me.Panel3)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "HistoricoPedido"
        Me.Size = New System.Drawing.Size(1069, 624)
        Me.Panel3.ResumeLayout(False)
        CType(Me.datagrid_pedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_voltar As Button
    Friend WithEvents datagrid_pedido As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents cmb_type As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_search As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents orderDate As DataGridViewTextBoxColumn
    Friend WithEvents employee As DataGridViewTextBoxColumn
    Friend WithEvents CLIENTE As DataGridViewTextBoxColumn
    Friend WithEvents CELULAR As DataGridViewTextBoxColumn
    Friend WithEvents CPF As DataGridViewTextBoxColumn
    Friend WithEvents pizzaFlavor As DataGridViewTextBoxColumn
    Friend WithEvents pizzaSize As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents PAGAMENTO As DataGridViewTextBoxColumn
    Friend WithEvents PRECO As DataGridViewTextBoxColumn
    Friend WithEvents DESCONTO As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As DataGridViewTextBoxColumn
    Friend WithEvents VALORPAGO As DataGridViewTextBoxColumn
    Friend WithEvents TROCO As DataGridViewTextBoxColumn
End Class
