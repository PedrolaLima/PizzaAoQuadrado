<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControl1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl1))
        Me.datagrid_pedido = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PEDIDOCLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TAMANHO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QUANTIDADE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btn_bebida = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.cmb_bebida = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.pic_pizza = New Guna.UI.WinForms.GunaPictureBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lbl_price = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btn_removepizza = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_update = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_addpizza = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.cmb_sabor2 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.chk_doisSabores = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.cmb_tamanho = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmb_sabor = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.cmb_qtd = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_voltar = New System.Windows.Forms.Button()
        CType(Me.datagrid_pedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.pic_pizza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_pedido.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datagrid_pedido.ColumnHeadersHeight = 34
        Me.datagrid_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagrid_pedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.PEDIDOCLIENTE, Me.TAMANHO, Me.PRECO, Me.QUANTIDADE, Me.TOTAL})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid_pedido.DefaultCellStyle = DataGridViewCellStyle3
        Me.datagrid_pedido.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.datagrid_pedido.Location = New System.Drawing.Point(25, 447)
        Me.datagrid_pedido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.datagrid_pedido.Name = "datagrid_pedido"
        Me.datagrid_pedido.ReadOnly = True
        Me.datagrid_pedido.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_pedido.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.datagrid_pedido.RowHeadersVisible = False
        Me.datagrid_pedido.RowHeadersWidth = 51
        Me.datagrid_pedido.Size = New System.Drawing.Size(1363, 299)
        Me.datagrid_pedido.TabIndex = 124
        Me.datagrid_pedido.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt
        Me.datagrid_pedido.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.datagrid_pedido.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid_pedido.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.datagrid_pedido.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.datagrid_pedido.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datagrid_pedido.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.datagrid_pedido.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.datagrid_pedido.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.datagrid_pedido.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datagrid_pedido.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid_pedido.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.datagrid_pedido.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagrid_pedido.ThemeStyle.HeaderStyle.Height = 34
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
        Me.ID.MinimumWidth = 60
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'PEDIDOCLIENTE
        '
        Me.PEDIDOCLIENTE.FillWeight = 313.4242!
        Me.PEDIDOCLIENTE.HeaderText = "PEDIDO"
        Me.PEDIDOCLIENTE.MinimumWidth = 6
        Me.PEDIDOCLIENTE.Name = "PEDIDOCLIENTE"
        Me.PEDIDOCLIENTE.ReadOnly = True
        '
        'TAMANHO
        '
        Me.TAMANHO.FillWeight = 110.4873!
        Me.TAMANHO.HeaderText = "       TAMANHO"
        Me.TAMANHO.MinimumWidth = 6
        Me.TAMANHO.Name = "TAMANHO"
        Me.TAMANHO.ReadOnly = True
        '
        'PRECO
        '
        Me.PRECO.FillWeight = 110.4873!
        Me.PRECO.HeaderText = "       PREÇO"
        Me.PRECO.MinimumWidth = 6
        Me.PRECO.Name = "PRECO"
        Me.PRECO.ReadOnly = True
        '
        'QUANTIDADE
        '
        Me.QUANTIDADE.FillWeight = 110.4873!
        Me.QUANTIDADE.HeaderText = "       QUANTIDADE"
        Me.QUANTIDADE.MinimumWidth = 6
        Me.QUANTIDADE.Name = "QUANTIDADE"
        Me.QUANTIDADE.ReadOnly = True
        '
        'TOTAL
        '
        Me.TOTAL.FillWeight = 110.4873!
        Me.TOTAL.HeaderText = "       TOTAL"
        Me.TOTAL.MinimumWidth = 6
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.ReadOnly = True
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BackColor = System.Drawing.Color.White
        Me.Guna2GradientPanel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2GradientPanel1.BorderRadius = 5
        Me.Guna2GradientPanel1.BorderThickness = 1
        Me.Guna2GradientPanel1.Controls.Add(Me.btn_bebida)
        Me.Guna2GradientPanel1.Controls.Add(Me.cmb_bebida)
        Me.Guna2GradientPanel1.Controls.Add(Me.GunaLabel2)
        Me.Guna2GradientPanel1.Controls.Add(Me.pic_pizza)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2GradientPanel1.Controls.Add(Me.lbl_price)
        Me.Guna2GradientPanel1.Controls.Add(Me.btn_removepizza)
        Me.Guna2GradientPanel1.Controls.Add(Me.btn_update)
        Me.Guna2GradientPanel1.Controls.Add(Me.btn_addpizza)
        Me.Guna2GradientPanel1.Controls.Add(Me.cmb_sabor2)
        Me.Guna2GradientPanel1.Controls.Add(Me.GunaLabel7)
        Me.Guna2GradientPanel1.Controls.Add(Me.chk_doisSabores)
        Me.Guna2GradientPanel1.Controls.Add(Me.cmb_tamanho)
        Me.Guna2GradientPanel1.Controls.Add(Me.cmb_sabor)
        Me.Guna2GradientPanel1.Controls.Add(Me.GunaLabel4)
        Me.Guna2GradientPanel1.Controls.Add(Me.GunaLabel1)
        Me.Guna2GradientPanel1.Controls.Add(Me.cmb_qtd)
        Me.Guna2GradientPanel1.Controls.Add(Me.GunaLabel5)
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(25, 74)
        Me.Guna2GradientPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1363, 495)
        Me.Guna2GradientPanel1.TabIndex = 123
        '
        'btn_bebida
        '
        Me.btn_bebida.Animated = True
        Me.btn_bebida.BackColor = System.Drawing.Color.Transparent
        Me.btn_bebida.BorderRadius = 5
        Me.btn_bebida.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_bebida.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_bebida.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_bebida.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_bebida.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_bebida.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_bebida.FillColor2 = System.Drawing.Color.DarkGreen
        Me.btn_bebida.Font = New System.Drawing.Font("Roboto", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bebida.ForeColor = System.Drawing.Color.White
        Me.btn_bebida.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_bebida.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_bebida.ImageOffset = New System.Drawing.Point(7, -1)
        Me.btn_bebida.ImageSize = New System.Drawing.Size(33, 33)
        Me.btn_bebida.Location = New System.Drawing.Point(1127, 165)
        Me.btn_bebida.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_bebida.Name = "btn_bebida"
        Me.btn_bebida.Size = New System.Drawing.Size(63, 46)
        Me.btn_bebida.TabIndex = 144
        Me.btn_bebida.Text = "+"
        Me.btn_bebida.TextOffset = New System.Drawing.Point(2, -2)
        Me.btn_bebida.UseTransparentBackground = True
        '
        'cmb_bebida
        '
        Me.cmb_bebida.BackColor = System.Drawing.Color.Transparent
        Me.cmb_bebida.BorderColor = System.Drawing.Color.Silver
        Me.cmb_bebida.BorderThickness = 2
        Me.cmb_bebida.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_bebida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_bebida.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_bebida.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_bebida.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_bebida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_bebida.IntegralHeight = False
        Me.cmb_bebida.ItemHeight = 30
        Me.cmb_bebida.Location = New System.Drawing.Point(887, 171)
        Me.cmb_bebida.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_bebida.MaxDropDownItems = 10
        Me.cmb_bebida.Name = "cmb_bebida"
        Me.cmb_bebida.Size = New System.Drawing.Size(224, 36)
        Me.cmb_bebida.TabIndex = 142
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.White
        Me.GunaLabel2.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(884, 149)
        Me.GunaLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(58, 18)
        Me.GunaLabel2.TabIndex = 143
        Me.GunaLabel2.Text = "Bebida:"
        '
        'pic_pizza
        '
        Me.pic_pizza.BackColor = System.Drawing.SystemColors.Control
        Me.pic_pizza.BaseColor = System.Drawing.Color.White
        Me.pic_pizza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_pizza.Image = CType(resources.GetObject("pic_pizza.Image"), System.Drawing.Image)
        Me.pic_pizza.Location = New System.Drawing.Point(49, 48)
        Me.pic_pizza.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pic_pizza.Name = "pic_pizza"
        Me.pic_pizza.Size = New System.Drawing.Size(265, 228)
        Me.pic_pizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_pizza.TabIndex = 140
        Me.pic_pizza.TabStop = False
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2PictureBox2.FillColor = System.Drawing.Color.Wheat
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(40, 41)
        Me.Guna2PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(285, 246)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 141
        Me.Guna2PictureBox2.TabStop = False
        '
        'lbl_price
        '
        Me.lbl_price.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_price.Font = New System.Drawing.Font("Roboto", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(103, 300)
        Me.lbl_price.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(134, 43)
        Me.lbl_price.TabIndex = 139
        Me.lbl_price.Text = "R$ 00,00"
        '
        'btn_removepizza
        '
        Me.btn_removepizza.Animated = True
        Me.btn_removepizza.BackColor = System.Drawing.Color.Transparent
        Me.btn_removepizza.BorderRadius = 5
        Me.btn_removepizza.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_removepizza.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_removepizza.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_removepizza.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_removepizza.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_removepizza.FillColor = System.Drawing.Color.Red
        Me.btn_removepizza.FillColor2 = System.Drawing.Color.DarkRed
        Me.btn_removepizza.Font = New System.Drawing.Font("Roboto", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_removepizza.ForeColor = System.Drawing.Color.White
        Me.btn_removepizza.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_removepizza.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_removepizza.ImageOffset = New System.Drawing.Point(7, -1)
        Me.btn_removepizza.ImageSize = New System.Drawing.Size(33, 33)
        Me.btn_removepizza.Location = New System.Drawing.Point(624, 238)
        Me.btn_removepizza.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_removepizza.Name = "btn_removepizza"
        Me.btn_removepizza.Size = New System.Drawing.Size(225, 43)
        Me.btn_removepizza.TabIndex = 138
        Me.btn_removepizza.Text = "-"
        Me.btn_removepizza.TextOffset = New System.Drawing.Point(2, -10)
        Me.btn_removepizza.UseTransparentBackground = True
        '
        'btn_update
        '
        Me.btn_update.Animated = True
        Me.btn_update.BackColor = System.Drawing.Color.Transparent
        Me.btn_update.BorderRadius = 5
        Me.btn_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_update.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_update.FillColor = System.Drawing.Color.Orange
        Me.btn_update.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_update.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_update.Image = CType(resources.GetObject("btn_update.Image"), System.Drawing.Image)
        Me.btn_update.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_update.ImageOffset = New System.Drawing.Point(7, -1)
        Me.btn_update.ImageSize = New System.Drawing.Size(33, 33)
        Me.btn_update.Location = New System.Drawing.Point(1053, 282)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(269, 62)
        Me.btn_update.TabIndex = 120
        Me.btn_update.Text = "SALVAR"
        Me.btn_update.TextOffset = New System.Drawing.Point(4, 0)
        Me.btn_update.UseTransparentBackground = True
        '
        'btn_addpizza
        '
        Me.btn_addpizza.Animated = True
        Me.btn_addpizza.BackColor = System.Drawing.Color.Transparent
        Me.btn_addpizza.BorderRadius = 5
        Me.btn_addpizza.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_addpizza.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_addpizza.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_addpizza.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_addpizza.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_addpizza.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_addpizza.FillColor2 = System.Drawing.Color.DarkGreen
        Me.btn_addpizza.Font = New System.Drawing.Font("Roboto", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addpizza.ForeColor = System.Drawing.Color.White
        Me.btn_addpizza.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_addpizza.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_addpizza.ImageOffset = New System.Drawing.Point(7, -1)
        Me.btn_addpizza.ImageSize = New System.Drawing.Size(33, 33)
        Me.btn_addpizza.Location = New System.Drawing.Point(365, 238)
        Me.btn_addpizza.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_addpizza.Name = "btn_addpizza"
        Me.btn_addpizza.Size = New System.Drawing.Size(225, 43)
        Me.btn_addpizza.TabIndex = 137
        Me.btn_addpizza.Text = "+"
        Me.btn_addpizza.TextOffset = New System.Drawing.Point(2, -8)
        Me.btn_addpizza.UseTransparentBackground = True
        '
        'cmb_sabor2
        '
        Me.cmb_sabor2.BackColor = System.Drawing.Color.Transparent
        Me.cmb_sabor2.BorderColor = System.Drawing.Color.Silver
        Me.cmb_sabor2.BorderThickness = 2
        Me.cmb_sabor2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_sabor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_sabor2.Enabled = False
        Me.cmb_sabor2.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_sabor2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_sabor2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_sabor2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_sabor2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_sabor2.ItemHeight = 30
        Me.cmb_sabor2.Location = New System.Drawing.Point(624, 74)
        Me.cmb_sabor2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_sabor2.Name = "cmb_sabor2"
        Me.cmb_sabor2.Size = New System.Drawing.Size(224, 36)
        Me.cmb_sabor2.TabIndex = 133
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.BackColor = System.Drawing.Color.White
        Me.GunaLabel7.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.Location = New System.Drawing.Point(620, 52)
        Me.GunaLabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(123, 18)
        Me.GunaLabel7.TabIndex = 132
        Me.GunaLabel7.Text = "Sabor 2 da pizza:"
        '
        'chk_doisSabores
        '
        Me.chk_doisSabores.AutoSize = True
        Me.chk_doisSabores.CheckedState.BorderColor = System.Drawing.Color.Orange
        Me.chk_doisSabores.CheckedState.BorderRadius = 0
        Me.chk_doisSabores.CheckedState.BorderThickness = 0
        Me.chk_doisSabores.CheckedState.FillColor = System.Drawing.Color.Orange
        Me.chk_doisSabores.Location = New System.Drawing.Point(887, 80)
        Me.chk_doisSabores.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chk_doisSabores.Name = "chk_doisSabores"
        Me.chk_doisSabores.Size = New System.Drawing.Size(150, 20)
        Me.chk_doisSabores.TabIndex = 131
        Me.chk_doisSabores.Text = "Pizza de 2 sabores?"
        Me.chk_doisSabores.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.chk_doisSabores.UncheckedState.BorderRadius = 2
        Me.chk_doisSabores.UncheckedState.BorderThickness = 1
        Me.chk_doisSabores.UncheckedState.FillColor = System.Drawing.Color.White
        '
        'cmb_tamanho
        '
        Me.cmb_tamanho.BackColor = System.Drawing.Color.Transparent
        Me.cmb_tamanho.BorderColor = System.Drawing.Color.Silver
        Me.cmb_tamanho.BorderThickness = 2
        Me.cmb_tamanho.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_tamanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tamanho.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_tamanho.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_tamanho.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tamanho.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_tamanho.ItemHeight = 30
        Me.cmb_tamanho.Location = New System.Drawing.Point(365, 171)
        Me.cmb_tamanho.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_tamanho.Name = "cmb_tamanho"
        Me.cmb_tamanho.Size = New System.Drawing.Size(224, 36)
        Me.cmb_tamanho.TabIndex = 4
        '
        'cmb_sabor
        '
        Me.cmb_sabor.BackColor = System.Drawing.Color.Transparent
        Me.cmb_sabor.BorderColor = System.Drawing.Color.Silver
        Me.cmb_sabor.BorderThickness = 2
        Me.cmb_sabor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_sabor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_sabor.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_sabor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_sabor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_sabor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_sabor.ItemHeight = 30
        Me.cmb_sabor.Location = New System.Drawing.Point(365, 74)
        Me.cmb_sabor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_sabor.Name = "cmb_sabor"
        Me.cmb_sabor.Size = New System.Drawing.Size(224, 36)
        Me.cmb_sabor.TabIndex = 3
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.White
        Me.GunaLabel4.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(361, 149)
        Me.GunaLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(133, 18)
        Me.GunaLabel4.TabIndex = 103
        Me.GunaLabel4.Text = "Tamanho da pizza:"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.White
        Me.GunaLabel1.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(361, 52)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(110, 18)
        Me.GunaLabel1.TabIndex = 102
        Me.GunaLabel1.Text = "Sabor da pizza:"
        '
        'cmb_qtd
        '
        Me.cmb_qtd.BackColor = System.Drawing.Color.Transparent
        Me.cmb_qtd.BorderColor = System.Drawing.Color.Silver
        Me.cmb_qtd.BorderThickness = 2
        Me.cmb_qtd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_qtd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_qtd.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_qtd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_qtd.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_qtd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_qtd.IntegralHeight = False
        Me.cmb_qtd.ItemHeight = 30
        Me.cmb_qtd.Location = New System.Drawing.Point(624, 171)
        Me.cmb_qtd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_qtd.MaxDropDownItems = 10
        Me.cmb_qtd.Name = "cmb_qtd"
        Me.cmb_qtd.Size = New System.Drawing.Size(224, 36)
        Me.cmb_qtd.TabIndex = 5
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.BackColor = System.Drawing.Color.White
        Me.GunaLabel5.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(620, 149)
        Me.GunaLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(87, 18)
        Me.GunaLabel5.TabIndex = 115
        Me.GunaLabel5.Text = "Quantidade:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btn_voltar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1425, 33)
        Me.Panel3.TabIndex = 122
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.Transparent
        Me.btn_voltar.BackgroundImage = CType(resources.GetObject("btn_voltar.BackgroundImage"), System.Drawing.Image)
        Me.btn_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_voltar.FlatAppearance.BorderSize = 0
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Location = New System.Drawing.Point(1371, 0)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(55, 33)
        Me.btn_voltar.TabIndex = 15
        Me.btn_voltar.Text = " "
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.datagrid_pedido)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.Panel3)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(1425, 768)
        CType(Me.datagrid_pedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.pic_pizza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents datagrid_pedido As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btn_removepizza As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_update As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_addpizza As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents cmb_sabor2 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents chk_doisSabores As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents cmb_tamanho As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmb_sabor As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cmb_qtd As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_voltar As Button
    Friend WithEvents lbl_price As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pic_pizza As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents PEDIDOCLIENTE As DataGridViewTextBoxColumn
    Friend WithEvents TAMANHO As DataGridViewTextBoxColumn
    Friend WithEvents PRECO As DataGridViewTextBoxColumn
    Friend WithEvents QUANTIDADE As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As DataGridViewTextBoxColumn
    Friend WithEvents btn_bebida As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents cmb_bebida As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2DataGridViewStyler1 As Guna.UI2.WinForms.Guna2DataGridViewStyler
End Class
