<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdicionarPizza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdicionarPizza))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.pic_pizza = New Guna.UI.WinForms.GunaPictureBox()
        Me.txt_pizza = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_price = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.btn_salvar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.datagrid_pizza = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.id_menu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dish_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.availability = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btn_delete = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_update = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.cmb_type = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_search = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.chk_availability = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_desc = New Guna.UI.WinForms.GunaTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.pic_pizza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.datagrid_pizza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2GradientPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.Transparent
        Me.btn_voltar.BackgroundImage = CType(resources.GetObject("btn_voltar.BackgroundImage"), System.Drawing.Image)
        Me.btn_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_voltar.FlatAppearance.BorderSize = 0
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Location = New System.Drawing.Point(1375, 0)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(51, 33)
        Me.btn_voltar.TabIndex = 15
        Me.btn_voltar.Text = " "
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'pic_pizza
        '
        Me.pic_pizza.BackColor = System.Drawing.SystemColors.Control
        Me.pic_pizza.BaseColor = System.Drawing.Color.White
        Me.pic_pizza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_pizza.Image = CType(resources.GetObject("pic_pizza.Image"), System.Drawing.Image)
        Me.pic_pizza.Location = New System.Drawing.Point(1080, 81)
        Me.pic_pizza.Margin = New System.Windows.Forms.Padding(4)
        Me.pic_pizza.Name = "pic_pizza"
        Me.pic_pizza.Size = New System.Drawing.Size(265, 228)
        Me.pic_pizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_pizza.TabIndex = 96
        Me.pic_pizza.TabStop = False
        '
        'txt_pizza
        '
        Me.txt_pizza.BackColor = System.Drawing.SystemColors.Window
        Me.txt_pizza.BaseColor = System.Drawing.Color.White
        Me.txt_pizza.BorderColor = System.Drawing.Color.Silver
        Me.txt_pizza.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_pizza.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_pizza.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_pizza.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_pizza.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pizza.Location = New System.Drawing.Point(45, 59)
        Me.txt_pizza.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_pizza.Name = "txt_pizza"
        Me.txt_pizza.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_pizza.SelectedText = ""
        Me.txt_pizza.Size = New System.Drawing.Size(523, 37)
        Me.txt_pizza.TabIndex = 66
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.White
        Me.GunaLabel1.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(41, 37)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(128, 18)
        Me.GunaLabel1.TabIndex = 78
        Me.GunaLabel1.Text = "Nome do Produto:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btn_voltar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1425, 33)
        Me.Panel3.TabIndex = 95
        '
        'txt_price
        '
        Me.txt_price.BackColor = System.Drawing.SystemColors.Window
        Me.txt_price.BaseColor = System.Drawing.Color.White
        Me.txt_price.BorderColor = System.Drawing.Color.Silver
        Me.txt_price.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_price.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_price.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_price.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_price.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(45, 199)
        Me.txt_price.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_price.MaxLength = 8
        Me.txt_price.Name = "txt_price"
        Me.txt_price.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_price.SelectedText = ""
        Me.txt_price.Size = New System.Drawing.Size(283, 37)
        Me.txt_price.TabIndex = 8
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.BackColor = System.Drawing.Color.White
        Me.GunaLabel11.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.Location = New System.Drawing.Point(41, 177)
        Me.GunaLabel11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(51, 18)
        Me.GunaLabel11.TabIndex = 46
        Me.GunaLabel11.Text = "Preço:"
        '
        'btn_salvar
        '
        Me.btn_salvar.Animated = True
        Me.btn_salvar.BackColor = System.Drawing.Color.Transparent
        Me.btn_salvar.BorderRadius = 5
        Me.btn_salvar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_salvar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_salvar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_salvar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_salvar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_salvar.FillColor = System.Drawing.Color.Orange
        Me.btn_salvar.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_salvar.Font = New System.Drawing.Font("Roboto", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar.ForeColor = System.Drawing.Color.White
        Me.btn_salvar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_salvar.Image = CType(resources.GetObject("btn_salvar.Image"), System.Drawing.Image)
        Me.btn_salvar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_salvar.ImageOffset = New System.Drawing.Point(5, 0)
        Me.btn_salvar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_salvar.Location = New System.Drawing.Point(1091, 639)
        Me.btn_salvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(265, 71)
        Me.btn_salvar.TabIndex = 99
        Me.btn_salvar.Text = "SALVAR"
        Me.btn_salvar.UseTransparentBackground = True
        '
        'datagrid_pizza
        '
        Me.datagrid_pizza.AllowUserToAddRows = False
        Me.datagrid_pizza.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid_pizza.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagrid_pizza.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.datagrid_pizza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.datagrid_pizza.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_pizza.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datagrid_pizza.ColumnHeadersHeight = 34
        Me.datagrid_pizza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagrid_pizza.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_menu, Me.dish_name, Me.description, Me.price, Me.availability})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid_pizza.DefaultCellStyle = DataGridViewCellStyle3
        Me.datagrid_pizza.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.datagrid_pizza.Location = New System.Drawing.Point(105, 465)
        Me.datagrid_pizza.Margin = New System.Windows.Forms.Padding(4)
        Me.datagrid_pizza.Name = "datagrid_pizza"
        Me.datagrid_pizza.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_pizza.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.datagrid_pizza.RowHeadersVisible = False
        Me.datagrid_pizza.RowHeadersWidth = 51
        Me.datagrid_pizza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect
        Me.datagrid_pizza.Size = New System.Drawing.Size(800, 245)
        Me.datagrid_pizza.TabIndex = 0
        Me.datagrid_pizza.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt
        Me.datagrid_pizza.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.datagrid_pizza.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid_pizza.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.datagrid_pizza.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid_pizza.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid_pizza.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.datagrid_pizza.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.datagrid_pizza.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid_pizza.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.datagrid_pizza.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid_pizza.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.datagrid_pizza.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagrid_pizza.ThemeStyle.HeaderStyle.Height = 34
        Me.datagrid_pizza.ThemeStyle.ReadOnly = True
        Me.datagrid_pizza.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.datagrid_pizza.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagrid_pizza.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid_pizza.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.datagrid_pizza.ThemeStyle.RowsStyle.Height = 22
        Me.datagrid_pizza.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.datagrid_pizza.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'id_menu
        '
        Me.id_menu.FillWeight = 30.0!
        Me.id_menu.HeaderText = "ID"
        Me.id_menu.MinimumWidth = 6
        Me.id_menu.Name = "id_menu"
        Me.id_menu.ReadOnly = True
        '
        'dish_name
        '
        Me.dish_name.FillWeight = 120.0!
        Me.dish_name.HeaderText = "NOME"
        Me.dish_name.MinimumWidth = 6
        Me.dish_name.Name = "dish_name"
        Me.dish_name.ReadOnly = True
        '
        'description
        '
        Me.description.FillWeight = 120.0!
        Me.description.HeaderText = "DESCRIÇÃO"
        Me.description.MinimumWidth = 6
        Me.description.Name = "description"
        Me.description.ReadOnly = True
        '
        'price
        '
        Me.price.FillWeight = 58.80173!
        Me.price.HeaderText = "PREÇO"
        Me.price.MinimumWidth = 6
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'availability
        '
        Me.availability.FillWeight = 104.5579!
        Me.availability.HeaderText = "DISPONIBILIDADE"
        Me.availability.MinimumWidth = 6
        Me.availability.Name = "availability"
        Me.availability.ReadOnly = True
        Me.availability.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'btn_delete
        '
        Me.btn_delete.Animated = True
        Me.btn_delete.BackColor = System.Drawing.Color.Transparent
        Me.btn_delete.BorderRadius = 5
        Me.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_delete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_delete.FillColor = System.Drawing.Color.Red
        Me.btn_delete.FillColor2 = System.Drawing.Color.DarkRed
        Me.btn_delete.Font = New System.Drawing.Font("Roboto", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_delete.Image = CType(resources.GetObject("btn_delete.Image"), System.Drawing.Image)
        Me.btn_delete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_delete.ImageOffset = New System.Drawing.Point(5, 0)
        Me.btn_delete.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_delete.Location = New System.Drawing.Point(1091, 454)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(265, 71)
        Me.btn_delete.TabIndex = 101
        Me.btn_delete.Text = "EXCLUIR"
        Me.btn_delete.UseTransparentBackground = True
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
        Me.btn_update.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_update.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_update.Font = New System.Drawing.Font("Roboto", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_update.Image = CType(resources.GetObject("btn_update.Image"), System.Drawing.Image)
        Me.btn_update.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_update.ImageOffset = New System.Drawing.Point(5, 0)
        Me.btn_update.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_update.Location = New System.Drawing.Point(1091, 546)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(265, 71)
        Me.btn_update.TabIndex = 102
        Me.btn_update.Text = "ATUALIZAR"
        Me.btn_update.TextOffset = New System.Drawing.Point(15, 0)
        Me.btn_update.UseTransparentBackground = True
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BackColor = System.Drawing.Color.White
        Me.Guna2GradientPanel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2GradientPanel1.BorderRadius = 5
        Me.Guna2GradientPanel1.BorderThickness = 1
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2GradientPanel2)
        Me.Guna2GradientPanel1.Controls.Add(Me.chk_availability)
        Me.Guna2GradientPanel1.Controls.Add(Me.GunaLabel2)
        Me.Guna2GradientPanel1.Controls.Add(Me.txt_desc)
        Me.Guna2GradientPanel1.Controls.Add(Me.GunaLabel1)
        Me.Guna2GradientPanel1.Controls.Add(Me.txt_price)
        Me.Guna2GradientPanel1.Controls.Add(Me.txt_pizza)
        Me.Guna2GradientPanel1.Controls.Add(Me.GunaLabel11)
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(105, 81)
        Me.Guna2GradientPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(800, 388)
        Me.Guna2GradientPanel1.TabIndex = 103
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
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(0, 282)
        Me.Guna2GradientPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(800, 103)
        Me.Guna2GradientPanel2.TabIndex = 87
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
        Me.cmb_type.ItemHeight = 30
        Me.cmb_type.Location = New System.Drawing.Point(507, 33)
        Me.cmb_type.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(174, 36)
        Me.cmb_type.TabIndex = 83
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel5.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(504, 12)
        Me.GunaLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(177, 18)
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
        Me.txt_search.Location = New System.Drawing.Point(85, 33)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_search.MaxLength = 11
        Me.txt_search.Name = "txt_search"
        Me.txt_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_search.SelectedText = ""
        Me.txt_search.Size = New System.Drawing.Size(229, 36)
        Me.txt_search.TabIndex = 72
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(81, 12)
        Me.GunaLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(233, 18)
        Me.GunaLabel4.TabIndex = 81
        Me.GunaLabel4.Text = "Digite um parâmetro de pesquisa:"
        '
        'chk_availability
        '
        Me.chk_availability.AutoSize = True
        Me.chk_availability.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chk_availability.CheckedState.BorderRadius = 0
        Me.chk_availability.CheckedState.BorderThickness = 0
        Me.chk_availability.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chk_availability.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_availability.Location = New System.Drawing.Point(364, 208)
        Me.chk_availability.Margin = New System.Windows.Forms.Padding(4)
        Me.chk_availability.Name = "chk_availability"
        Me.chk_availability.Size = New System.Drawing.Size(178, 21)
        Me.chk_availability.TabIndex = 86
        Me.chk_availability.Text = "Disponível para vendas"
        Me.chk_availability.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.chk_availability.UncheckedState.BorderRadius = 2
        Me.chk_availability.UncheckedState.BorderThickness = 1
        Me.chk_availability.UncheckedState.FillColor = System.Drawing.Color.White
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.White
        Me.GunaLabel2.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(41, 107)
        Me.GunaLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(79, 18)
        Me.GunaLabel2.TabIndex = 83
        Me.GunaLabel2.Text = "Descrição:"
        '
        'txt_desc
        '
        Me.txt_desc.BackColor = System.Drawing.SystemColors.Window
        Me.txt_desc.BaseColor = System.Drawing.Color.White
        Me.txt_desc.BorderColor = System.Drawing.Color.Silver
        Me.txt_desc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_desc.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_desc.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_desc.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_desc.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desc.Location = New System.Drawing.Point(45, 129)
        Me.txt_desc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_desc.SelectedText = ""
        Me.txt_desc.Size = New System.Drawing.Size(523, 37)
        Me.txt_desc.TabIndex = 82
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(1071, 75)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(285, 245)
        Me.Panel1.TabIndex = 88
        '
        'AdicionarPizza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.datagrid_pizza)
        Me.Controls.Add(Me.btn_salvar)
        Me.Controls.Add(Me.pic_pizza)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AdicionarPizza"
        Me.Size = New System.Drawing.Size(1425, 768)
        CType(Me.pic_pizza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.datagrid_pizza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_voltar As Button
    Friend WithEvents pic_pizza As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents txt_pizza As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_price As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_salvar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents datagrid_pizza As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btn_delete As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_update As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_desc As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents chk_availability As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_search As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents cmb_type As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents id_menu As DataGridViewTextBoxColumn
    Friend WithEvents dish_name As DataGridViewTextBoxColumn
    Friend WithEvents description As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents availability As DataGridViewCheckBoxColumn
End Class
