<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GerenciarColab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GerenciarColab))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_delete = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.cmb_type = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_search = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.datagrid_colab = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.btn_update = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_status = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pic_user = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.celular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.senha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vendas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data_nasc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.complemento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2GradientPanel2.SuspendLayout()
        CType(Me.datagrid_colab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.pic_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btn_delete.Font = New System.Drawing.Font("Roboto", 16.2!, System.Drawing.FontStyle.Bold)
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_delete.Image = CType(resources.GetObject("btn_delete.Image"), System.Drawing.Image)
        Me.btn_delete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_delete.ImageOffset = New System.Drawing.Point(5, 0)
        Me.btn_delete.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_delete.Location = New System.Drawing.Point(854, 470)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(199, 58)
        Me.btn_delete.TabIndex = 108
        Me.btn_delete.Text = "EXCLUIR"
        Me.btn_delete.UseTransparentBackground = True
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
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(31, 54)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(600, 84)
        Me.Guna2GradientPanel2.TabIndex = 106
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
        Me.cmb_type.ItemHeight = 37
        Me.cmb_type.Location = New System.Drawing.Point(377, 27)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(134, 43)
        Me.cmb_type.TabIndex = 83
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel5.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(378, 10)
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
        Me.txt_search.Location = New System.Drawing.Point(64, 27)
        Me.txt_search.MaxLength = 30
        Me.txt_search.Name = "txt_search"
        Me.txt_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_search.SelectedText = ""
        Me.txt_search.Size = New System.Drawing.Size(172, 36)
        Me.txt_search.TabIndex = 72
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(61, 10)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(185, 14)
        Me.GunaLabel4.TabIndex = 81
        Me.GunaLabel4.Text = "Digite um parâmetro de pesquisa:"
        '
        'datagrid_colab
        '
        Me.datagrid_colab.AllowUserToAddRows = False
        Me.datagrid_colab.AllowUserToDeleteRows = False
        Me.datagrid_colab.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Roboto", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.datagrid_colab.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagrid_colab.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.datagrid_colab.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.datagrid_colab.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_colab.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datagrid_colab.ColumnHeadersHeight = 32
        Me.datagrid_colab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagrid_colab.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nome, Me.user, Me.celular, Me.email, Me.CPF, Me.cargo, Me.senha, Me.vendas, Me.data_nasc, Me.cep, Me.numero, Me.complemento})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid_colab.DefaultCellStyle = DataGridViewCellStyle3
        Me.datagrid_colab.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.datagrid_colab.Location = New System.Drawing.Point(31, 144)
        Me.datagrid_colab.Name = "datagrid_colab"
        Me.datagrid_colab.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_colab.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.datagrid_colab.RowHeadersVisible = False
        Me.datagrid_colab.RowHeadersWidth = 51
        Me.datagrid_colab.Size = New System.Drawing.Size(794, 474)
        Me.datagrid_colab.TabIndex = 105
        Me.datagrid_colab.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt
        Me.datagrid_colab.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.datagrid_colab.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Roboto", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid_colab.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.datagrid_colab.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid_colab.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datagrid_colab.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.datagrid_colab.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.datagrid_colab.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid_colab.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datagrid_colab.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid_colab.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.datagrid_colab.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagrid_colab.ThemeStyle.HeaderStyle.Height = 32
        Me.datagrid_colab.ThemeStyle.ReadOnly = False
        Me.datagrid_colab.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.datagrid_colab.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagrid_colab.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid_colab.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.datagrid_colab.ThemeStyle.RowsStyle.Height = 22
        Me.datagrid_colab.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid_colab.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
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
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.Transparent
        Me.btn_voltar.BackgroundImage = CType(resources.GetObject("btn_voltar.BackgroundImage"), System.Drawing.Image)
        Me.btn_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_voltar.FlatAppearance.BorderSize = 0
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Location = New System.Drawing.Point(1031, 0)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(38, 27)
        Me.btn_voltar.TabIndex = 15
        Me.btn_voltar.Text = " "
        Me.btn_voltar.UseVisualStyleBackColor = False
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
        Me.btn_update.Location = New System.Drawing.Point(854, 545)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(199, 58)
        Me.btn_update.TabIndex = 109
        Me.btn_update.Text = "ATUALIZAR"
        Me.btn_update.TextOffset = New System.Drawing.Point(15, 0)
        Me.btn_update.UseTransparentBackground = True
        '
        'btn_status
        '
        Me.btn_status.Animated = True
        Me.btn_status.BackColor = System.Drawing.Color.Transparent
        Me.btn_status.BorderRadius = 5
        Me.btn_status.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_status.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_status.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_status.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_status.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_status.FillColor = System.Drawing.Color.Gold
        Me.btn_status.FillColor2 = System.Drawing.Color.Goldenrod
        Me.btn_status.Font = New System.Drawing.Font("Roboto", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_status.ForeColor = System.Drawing.Color.White
        Me.btn_status.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_status.Image = CType(resources.GetObject("btn_status.Image"), System.Drawing.Image)
        Me.btn_status.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_status.ImageOffset = New System.Drawing.Point(5, 0)
        Me.btn_status.ImageSize = New System.Drawing.Size(38, 38)
        Me.btn_status.Location = New System.Drawing.Point(854, 394)
        Me.btn_status.Name = "btn_status"
        Me.btn_status.Size = New System.Drawing.Size(199, 58)
        Me.btn_status.TabIndex = 110
        Me.btn_status.Text = "          ALTERAR           STATUS"
        Me.btn_status.UseTransparentBackground = True
        '
        'pic_user
        '
        Me.pic_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_user.ErrorImage = CType(resources.GetObject("pic_user.ErrorImage"), System.Drawing.Image)
        Me.pic_user.FillColor = System.Drawing.Color.Wheat
        Me.pic_user.Image = CType(resources.GetObject("pic_user.Image"), System.Drawing.Image)
        Me.pic_user.ImageRotate = 0!
        Me.pic_user.Location = New System.Drawing.Point(863, 158)
        Me.pic_user.Name = "pic_user"
        Me.pic_user.Size = New System.Drawing.Size(175, 173)
        Me.pic_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_user.TabIndex = 111
        Me.pic_user.TabStop = False
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2PictureBox2.FillColor = System.Drawing.Color.Wheat
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(854, 150)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(194, 191)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 112
        Me.Guna2PictureBox2.TabStop = False
        '
        'nome
        '
        Me.nome.HeaderText = "NOME"
        Me.nome.MinimumWidth = 6
        Me.nome.Name = "nome"
        Me.nome.Width = 64
        '
        'user
        '
        Me.user.HeaderText = "USUÁRIO"
        Me.user.MinimumWidth = 6
        Me.user.Name = "user"
        Me.user.Width = 81
        '
        'celular
        '
        Me.celular.HeaderText = "CELULAR"
        Me.celular.MinimumWidth = 6
        Me.celular.Name = "celular"
        Me.celular.Width = 83
        '
        'email
        '
        Me.email.HeaderText = "EMAIL"
        Me.email.MinimumWidth = 6
        Me.email.Name = "email"
        Me.email.Width = 67
        '
        'CPF
        '
        Me.CPF.HeaderText = "CPF"
        Me.CPF.MinimumWidth = 6
        Me.CPF.Name = "CPF"
        Me.CPF.Width = 53
        '
        'cargo
        '
        Me.cargo.HeaderText = "CARGO"
        Me.cargo.MinimumWidth = 6
        Me.cargo.Name = "cargo"
        Me.cargo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cargo.Width = 70
        '
        'senha
        '
        Me.senha.HeaderText = "SENHA"
        Me.senha.MinimumWidth = 6
        Me.senha.Name = "senha"
        Me.senha.Width = 68
        '
        'vendas
        '
        Me.vendas.HeaderText = "VENDAS"
        Me.vendas.MinimumWidth = 6
        Me.vendas.Name = "vendas"
        Me.vendas.Width = 76
        '
        'data_nasc
        '
        Me.data_nasc.HeaderText = "DATA DE NASCIMENTO"
        Me.data_nasc.MinimumWidth = 6
        Me.data_nasc.Name = "data_nasc"
        Me.data_nasc.Width = 142
        '
        'cep
        '
        Me.cep.HeaderText = "CEP"
        Me.cep.MinimumWidth = 6
        Me.cep.Name = "cep"
        Me.cep.Width = 53
        '
        'numero
        '
        Me.numero.HeaderText = "NÚMERO DA RESIDÊNCIA"
        Me.numero.MinimumWidth = 6
        Me.numero.Name = "numero"
        Me.numero.Width = 156
        '
        'complemento
        '
        Me.complemento.HeaderText = "COMPLEMENTO"
        Me.complemento.MinimumWidth = 6
        Me.complemento.Name = "complemento"
        Me.complemento.Width = 120
        '
        'GerenciarColab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pic_user)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.btn_status)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.Controls.Add(Me.datagrid_colab)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "GerenciarColab"
        Me.Size = New System.Drawing.Size(1069, 624)
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        CType(Me.datagrid_colab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.pic_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_delete As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents cmb_type As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_search As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents datagrid_colab As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_voltar As Button
    Friend WithEvents btn_update As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_status As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents pic_user As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents user As DataGridViewTextBoxColumn
    Friend WithEvents celular As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents CPF As DataGridViewTextBoxColumn
    Friend WithEvents cargo As DataGridViewTextBoxColumn
    Friend WithEvents senha As DataGridViewTextBoxColumn
    Friend WithEvents vendas As DataGridViewTextBoxColumn
    Friend WithEvents data_nasc As DataGridViewTextBoxColumn
    Friend WithEvents cep As DataGridViewTextBoxColumn
    Friend WithEvents numero As DataGridViewTextBoxColumn
    Friend WithEvents complemento As DataGridViewTextBoxColumn
End Class
