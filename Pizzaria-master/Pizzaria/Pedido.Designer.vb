<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pedido
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pedido))
        Me.datagrid_pedido = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CELULAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAGAMENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCONTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALORPAGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TROCO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_preco = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GunaLabel14 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_celular = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_cpf = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_nome = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.btn_realizar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.cmb_pagamento = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btn_cancel = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txt_total = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_desconto = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_troco = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.btn_save = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txt_pag = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.chk_member = New Guna.UI2.WinForms.Guna2CheckBox()
        CType(Me.datagrid_pedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'datagrid_pedido
        '
        Me.datagrid_pedido.AllowUserToAddRows = False
        Me.datagrid_pedido.AllowUserToDeleteRows = False
        Me.datagrid_pedido.AllowUserToResizeRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        Me.datagrid_pedido.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.datagrid_pedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_pedido.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.datagrid_pedido.ColumnHeadersHeight = 50
        Me.datagrid_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagrid_pedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.CLIENTE, Me.CPF, Me.CELULAR, Me.PAGAMENTO, Me.PRECO, Me.DESCONTO, Me.TOTAL, Me.VALORPAGO, Me.TROCO})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid_pedido.DefaultCellStyle = DataGridViewCellStyle13
        Me.datagrid_pedido.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.datagrid_pedido.Location = New System.Drawing.Point(19, 438)
        Me.datagrid_pedido.Name = "datagrid_pedido"
        Me.datagrid_pedido.ReadOnly = True
        Me.datagrid_pedido.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_pedido.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.datagrid_pedido.RowHeadersVisible = False
        Me.datagrid_pedido.RowHeadersWidth = 51
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.datagrid_pedido.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.datagrid_pedido.Size = New System.Drawing.Size(1022, 149)
        Me.datagrid_pedido.TabIndex = 121
        Me.datagrid_pedido.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt
        Me.datagrid_pedido.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.datagrid_pedido.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid_pedido.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.datagrid_pedido.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.datagrid_pedido.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datagrid_pedido.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.datagrid_pedido.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.datagrid_pedido.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid_pedido.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datagrid_pedido.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid_pedido.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.datagrid_pedido.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagrid_pedido.ThemeStyle.HeaderStyle.Height = 50
        Me.datagrid_pedido.ThemeStyle.ReadOnly = True
        Me.datagrid_pedido.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.datagrid_pedido.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagrid_pedido.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid_pedido.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.datagrid_pedido.ThemeStyle.RowsStyle.Height = 22
        Me.datagrid_pedido.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.datagrid_pedido.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'ID
        '
        Me.ID.FillWeight = 50.0!
        Me.ID.HeaderText = "     ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'CLIENTE
        '
        Me.CLIENTE.HeaderText = "     CLIENTE"
        Me.CLIENTE.MinimumWidth = 6
        Me.CLIENTE.Name = "CLIENTE"
        Me.CLIENTE.ReadOnly = True
        '
        'CPF
        '
        Me.CPF.HeaderText = "         CPF DO           CLIENTE"
        Me.CPF.MinimumWidth = 6
        Me.CPF.Name = "CPF"
        Me.CPF.ReadOnly = True
        '
        'CELULAR
        '
        Me.CELULAR.HeaderText = "     CELULAR"
        Me.CELULAR.MinimumWidth = 6
        Me.CELULAR.Name = "CELULAR"
        Me.CELULAR.ReadOnly = True
        '
        'PAGAMENTO
        '
        Me.PAGAMENTO.FillWeight = 120.0!
        Me.PAGAMENTO.HeaderText = "              FORMA                  DE PAGAMENTO"
        Me.PAGAMENTO.MinimumWidth = 6
        Me.PAGAMENTO.Name = "PAGAMENTO"
        Me.PAGAMENTO.ReadOnly = True
        '
        'PRECO
        '
        Me.PRECO.FillWeight = 80.0!
        Me.PRECO.HeaderText = "     PREÇO"
        Me.PRECO.MinimumWidth = 6
        Me.PRECO.Name = "PRECO"
        Me.PRECO.ReadOnly = True
        '
        'DESCONTO
        '
        Me.DESCONTO.HeaderText = "     DESCONTO"
        Me.DESCONTO.MinimumWidth = 6
        Me.DESCONTO.Name = "DESCONTO"
        Me.DESCONTO.ReadOnly = True
        '
        'TOTAL
        '
        Me.TOTAL.HeaderText = "       TOTAL"
        Me.TOTAL.MinimumWidth = 6
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.ReadOnly = True
        '
        'VALORPAGO
        '
        Me.VALORPAGO.HeaderText = "    VALOR PAGO"
        Me.VALORPAGO.MinimumWidth = 6
        Me.VALORPAGO.Name = "VALORPAGO"
        Me.VALORPAGO.ReadOnly = True
        '
        'TROCO
        '
        Me.TROCO.FillWeight = 80.0!
        Me.TROCO.HeaderText = "     TROCO"
        Me.TROCO.MinimumWidth = 6
        Me.TROCO.Name = "TROCO"
        Me.TROCO.ReadOnly = True
        '
        'txt_preco
        '
        Me.txt_preco.BackColor = System.Drawing.Color.Transparent
        Me.txt_preco.BaseColor = System.Drawing.Color.Gainsboro
        Me.txt_preco.BorderColor = System.Drawing.Color.Silver
        Me.txt_preco.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_preco.Enabled = False
        Me.txt_preco.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_preco.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_preco.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_preco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_preco.Location = New System.Drawing.Point(62, 171)
        Me.txt_preco.MaxLength = 5
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_preco.SelectedText = ""
        Me.txt_preco.Size = New System.Drawing.Size(173, 37)
        Me.txt_preco.TabIndex = 6
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.BackColor = System.Drawing.Color.White
        Me.GunaLabel11.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.Location = New System.Drawing.Point(58, 154)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(41, 14)
        Me.GunaLabel11.TabIndex = 99
        Me.GunaLabel11.Text = "Preço:"
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.Transparent
        Me.btn_voltar.BackgroundImage = CType(resources.GetObject("btn_voltar.BackgroundImage"), System.Drawing.Image)
        Me.btn_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_voltar.FlatAppearance.BorderSize = 0
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Location = New System.Drawing.Point(1028, 0)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(41, 27)
        Me.btn_voltar.TabIndex = 15
        Me.btn_voltar.Text = " "
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btn_voltar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1069, 27)
        Me.Panel3.TabIndex = 104
        '
        'GunaLabel14
        '
        Me.GunaLabel14.AutoSize = True
        Me.GunaLabel14.BackColor = System.Drawing.Color.White
        Me.GunaLabel14.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel14.Location = New System.Drawing.Point(253, 95)
        Me.GunaLabel14.Name = "GunaLabel14"
        Me.GunaLabel14.Size = New System.Drawing.Size(84, 14)
        Me.GunaLabel14.TabIndex = 113
        Me.GunaLabel14.Text = "DDD + Celular:"
        '
        'txt_celular
        '
        Me.txt_celular.BaseColor = System.Drawing.Color.White
        Me.txt_celular.BorderColor = System.Drawing.Color.Silver
        Me.txt_celular.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_celular.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_celular.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_celular.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_celular.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_celular.Location = New System.Drawing.Point(256, 112)
        Me.txt_celular.MaxLength = 11
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_celular.SelectedText = ""
        Me.txt_celular.Size = New System.Drawing.Size(173, 37)
        Me.txt_celular.TabIndex = 2
        '
        'txt_cpf
        '
        Me.txt_cpf.BaseColor = System.Drawing.Color.White
        Me.txt_cpf.BorderColor = System.Drawing.Color.Silver
        Me.txt_cpf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cpf.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_cpf.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cpf.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_cpf.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(62, 112)
        Me.txt_cpf.MaxLength = 11
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cpf.SelectedText = ""
        Me.txt_cpf.Size = New System.Drawing.Size(173, 37)
        Me.txt_cpf.TabIndex = 1
        '
        'txt_nome
        '
        Me.txt_nome.BaseColor = System.Drawing.Color.White
        Me.txt_nome.BorderColor = System.Drawing.Color.Silver
        Me.txt_nome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nome.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_nome.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_nome.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_nome.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(62, 54)
        Me.txt_nome.MaxLength = 150
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nome.SelectedText = ""
        Me.txt_nome.Size = New System.Drawing.Size(368, 37)
        Me.txt_nome.TabIndex = 0
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.White
        Me.GunaLabel2.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(58, 37)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(94, 14)
        Me.GunaLabel2.TabIndex = 111
        Me.GunaLabel2.Text = "Nome completo:"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.White
        Me.GunaLabel3.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(58, 95)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(88, 14)
        Me.GunaLabel3.TabIndex = 112
        Me.GunaLabel3.Text = "CPF do cliente:"
        '
        'btn_realizar
        '
        Me.btn_realizar.Animated = True
        Me.btn_realizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_realizar.BorderRadius = 5
        Me.btn_realizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_realizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_realizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_realizar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_realizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_realizar.FillColor = System.Drawing.Color.Orange
        Me.btn_realizar.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_realizar.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_realizar.ForeColor = System.Drawing.Color.White
        Me.btn_realizar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_realizar.Image = CType(resources.GetObject("btn_realizar.Image"), System.Drawing.Image)
        Me.btn_realizar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_realizar.ImageOffset = New System.Drawing.Point(5, -1)
        Me.btn_realizar.ImageSize = New System.Drawing.Size(33, 33)
        Me.btn_realizar.Location = New System.Drawing.Point(730, 247)
        Me.btn_realizar.Name = "btn_realizar"
        Me.btn_realizar.Size = New System.Drawing.Size(202, 50)
        Me.btn_realizar.TabIndex = 116
        Me.btn_realizar.Text = "        FINALIZAR         PEDIDO"
        Me.btn_realizar.TextOffset = New System.Drawing.Point(5, 0)
        Me.btn_realizar.UseTransparentBackground = True
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.BackColor = System.Drawing.Color.White
        Me.GunaLabel8.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.Location = New System.Drawing.Point(253, 154)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(123, 14)
        Me.GunaLabel8.TabIndex = 125
        Me.GunaLabel8.Text = "Forma de pagamento:"
        '
        'cmb_pagamento
        '
        Me.cmb_pagamento.BackColor = System.Drawing.Color.Transparent
        Me.cmb_pagamento.BorderColor = System.Drawing.Color.Silver
        Me.cmb_pagamento.BorderThickness = 2
        Me.cmb_pagamento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_pagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_pagamento.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_pagamento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_pagamento.Font = New System.Drawing.Font("Roboto", 8.25!)
        Me.cmb_pagamento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_pagamento.IntegralHeight = False
        Me.cmb_pagamento.ItemHeight = 30
        Me.cmb_pagamento.Location = New System.Drawing.Point(256, 171)
        Me.cmb_pagamento.Name = "cmb_pagamento"
        Me.cmb_pagamento.Size = New System.Drawing.Size(174, 36)
        Me.cmb_pagamento.TabIndex = 7
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BackColor = System.Drawing.Color.White
        Me.Guna2GradientPanel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2GradientPanel1.BorderRadius = 5
        Me.Guna2GradientPanel1.BorderThickness = 1
        Me.Guna2GradientPanel1.Controls.Add(Me.btn_cancel)
        Me.Guna2GradientPanel1.Controls.Add(Me.txt_total)
        Me.Guna2GradientPanel1.Controls.Add(Me.GunaLabel5)
        Me.Guna2GradientPanel1.Controls.Add(Me.txt_desconto)
        Me.Guna2GradientPanel1.Controls.Add(Me.GunaLabel4)
        Me.Guna2GradientPanel1.Controls.Add(Me.txt_troco)
        Me.Guna2GradientPanel1.Controls.Add(Me.GunaLabel1)
        Me.Guna2GradientPanel1.Controls.Add(Me.btn_save)
        Me.Guna2GradientPanel1.Controls.Add(Me.btn_realizar)
        Me.Guna2GradientPanel1.Controls.Add(Me.txt_pag)
        Me.Guna2GradientPanel1.Controls.Add(Me.GunaLabel10)
        Me.Guna2GradientPanel1.Controls.Add(Me.chk_member)
        Me.Guna2GradientPanel1.Controls.Add(Me.txt_nome)
        Me.Guna2GradientPanel1.Controls.Add(Me.GunaLabel2)
        Me.Guna2GradientPanel1.Controls.Add(Me.txt_celular)
        Me.Guna2GradientPanel1.Controls.Add(Me.GunaLabel14)
        Me.Guna2GradientPanel1.Controls.Add(Me.GunaLabel8)
        Me.Guna2GradientPanel1.Controls.Add(Me.GunaLabel11)
        Me.Guna2GradientPanel1.Controls.Add(Me.cmb_pagamento)
        Me.Guna2GradientPanel1.Controls.Add(Me.GunaLabel3)
        Me.Guna2GradientPanel1.Controls.Add(Me.txt_preco)
        Me.Guna2GradientPanel1.Controls.Add(Me.txt_cpf)
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(19, 41)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1022, 402)
        Me.Guna2GradientPanel1.TabIndex = 119
        '
        'btn_cancel
        '
        Me.btn_cancel.Animated = True
        Me.btn_cancel.BackColor = System.Drawing.Color.Transparent
        Me.btn_cancel.BorderRadius = 5
        Me.btn_cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_cancel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_cancel.FillColor = System.Drawing.Color.Red
        Me.btn_cancel.FillColor2 = System.Drawing.Color.DarkRed
        Me.btn_cancel.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_cancel.ImageOffset = New System.Drawing.Point(5, 0)
        Me.btn_cancel.ImageSize = New System.Drawing.Size(33, 33)
        Me.btn_cancel.Location = New System.Drawing.Point(730, 122)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(202, 50)
        Me.btn_cancel.TabIndex = 142
        Me.btn_cancel.Text = "              CANCELAR                PEDIDO"
        Me.btn_cancel.UseTransparentBackground = True
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.Color.Transparent
        Me.txt_total.BaseColor = System.Drawing.Color.Gainsboro
        Me.txt_total.BorderColor = System.Drawing.Color.Silver
        Me.txt_total.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_total.Enabled = False
        Me.txt_total.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_total.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_total.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_total.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(255, 229)
        Me.txt_total.MaxLength = 5
        Me.txt_total.Name = "txt_total"
        Me.txt_total.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_total.SelectedText = ""
        Me.txt_total.Size = New System.Drawing.Size(173, 37)
        Me.txt_total.TabIndex = 140
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.BackColor = System.Drawing.Color.White
        Me.GunaLabel5.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(254, 212)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(36, 14)
        Me.GunaLabel5.TabIndex = 141
        Me.GunaLabel5.Text = "Total:"
        '
        'txt_desconto
        '
        Me.txt_desconto.BackColor = System.Drawing.Color.Transparent
        Me.txt_desconto.BaseColor = System.Drawing.Color.Gainsboro
        Me.txt_desconto.BorderColor = System.Drawing.Color.Silver
        Me.txt_desconto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_desconto.Enabled = False
        Me.txt_desconto.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_desconto.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_desconto.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_desconto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desconto.Location = New System.Drawing.Point(61, 229)
        Me.txt_desconto.MaxLength = 5
        Me.txt_desconto.Name = "txt_desconto"
        Me.txt_desconto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_desconto.SelectedText = ""
        Me.txt_desconto.Size = New System.Drawing.Size(173, 37)
        Me.txt_desconto.TabIndex = 138
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.White
        Me.GunaLabel4.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(58, 212)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(61, 14)
        Me.GunaLabel4.TabIndex = 139
        Me.GunaLabel4.Text = "Desconto:"
        '
        'txt_troco
        '
        Me.txt_troco.BackColor = System.Drawing.Color.Transparent
        Me.txt_troco.BaseColor = System.Drawing.Color.Gainsboro
        Me.txt_troco.BorderColor = System.Drawing.Color.Silver
        Me.txt_troco.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_troco.Enabled = False
        Me.txt_troco.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_troco.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_troco.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_troco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_troco.Location = New System.Drawing.Point(255, 288)
        Me.txt_troco.MaxLength = 5
        Me.txt_troco.Name = "txt_troco"
        Me.txt_troco.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_troco.SelectedText = ""
        Me.txt_troco.Size = New System.Drawing.Size(173, 37)
        Me.txt_troco.TabIndex = 136
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.White
        Me.GunaLabel1.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(254, 271)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(41, 14)
        Me.GunaLabel1.TabIndex = 137
        Me.GunaLabel1.Text = "Troco:"
        '
        'btn_save
        '
        Me.btn_save.Animated = True
        Me.btn_save.BackColor = System.Drawing.Color.Transparent
        Me.btn_save.BorderRadius = 5
        Me.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_save.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_save.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_save.FillColor2 = System.Drawing.Color.DarkGreen
        Me.btn_save.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_save.ImageOffset = New System.Drawing.Point(7, -1)
        Me.btn_save.ImageSize = New System.Drawing.Size(33, 33)
        Me.btn_save.Location = New System.Drawing.Point(730, 184)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(202, 50)
        Me.btn_save.TabIndex = 120
        Me.btn_save.Text = "SALVAR"
        Me.btn_save.TextOffset = New System.Drawing.Point(4, 0)
        Me.btn_save.UseTransparentBackground = True
        '
        'txt_pag
        '
        Me.txt_pag.BackColor = System.Drawing.Color.Transparent
        Me.txt_pag.BaseColor = System.Drawing.Color.White
        Me.txt_pag.BorderColor = System.Drawing.Color.Silver
        Me.txt_pag.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_pag.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_pag.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_pag.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_pag.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pag.Location = New System.Drawing.Point(60, 288)
        Me.txt_pag.MaxLength = 9
        Me.txt_pag.Name = "txt_pag"
        Me.txt_pag.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_pag.SelectedText = ""
        Me.txt_pag.Size = New System.Drawing.Size(173, 37)
        Me.txt_pag.TabIndex = 8
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.BackColor = System.Drawing.Color.White
        Me.GunaLabel10.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.Location = New System.Drawing.Point(59, 271)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(71, 14)
        Me.GunaLabel10.TabIndex = 135
        Me.GunaLabel10.Text = "Pagamento:"
        '
        'chk_member
        '
        Me.chk_member.AutoSize = True
        Me.chk_member.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chk_member.CheckedState.BorderRadius = 0
        Me.chk_member.CheckedState.BorderThickness = 0
        Me.chk_member.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chk_member.CheckMarkColor = System.Drawing.SystemColors.Window
        Me.chk_member.Enabled = False
        Me.chk_member.Font = New System.Drawing.Font("Roboto", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_member.Location = New System.Drawing.Point(452, 119)
        Me.chk_member.Name = "chk_member"
        Me.chk_member.Size = New System.Drawing.Size(149, 17)
        Me.chk_member.TabIndex = 129
        Me.chk_member.Text = "É do Clube de Membros?"
        Me.chk_member.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.chk_member.UncheckedState.BorderRadius = 2
        Me.chk_member.UncheckedState.BorderThickness = 1
        Me.chk_member.UncheckedState.FillColor = System.Drawing.Color.WhiteSmoke
        '
        'Pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.datagrid_pedido)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Pedido"
        Me.Size = New System.Drawing.Size(1069, 624)
        CType(Me.datagrid_pedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_preco As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_voltar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GunaLabel14 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_celular As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_cpf As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_nome As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_realizar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents chk_member As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents txt_pag As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_save As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents datagrid_pedido As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txt_troco As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_total As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_desconto As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents CLIENTE As DataGridViewTextBoxColumn
    Friend WithEvents CPF As DataGridViewTextBoxColumn
    Friend WithEvents CELULAR As DataGridViewTextBoxColumn
    Friend WithEvents PAGAMENTO As DataGridViewTextBoxColumn
    Friend WithEvents PRECO As DataGridViewTextBoxColumn
    Friend WithEvents DESCONTO As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As DataGridViewTextBoxColumn
    Friend WithEvents VALORPAGO As DataGridViewTextBoxColumn
    Friend WithEvents TROCO As DataGridViewTextBoxColumn
    Friend WithEvents btn_cancel As Guna.UI2.WinForms.Guna2GradientButton
    Private WithEvents cmb_pagamento As Guna.UI2.WinForms.Guna2ComboBox
End Class
