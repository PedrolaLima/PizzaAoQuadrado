<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoricoSangria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HistoricoSangria))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.cmb_type = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_search = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.datagrid_sangria = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.id_sangria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gerente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo_preSangria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor_sangria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo_posSangria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3.SuspendLayout()
        Me.Guna2GradientPanel2.SuspendLayout()
        CType(Me.datagrid_sangria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btn_voltar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1069, 27)
        Me.Panel3.TabIndex = 97
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
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(13, 33)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(600, 84)
        Me.Guna2GradientPanel2.TabIndex = 124
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
        Me.txt_search.MaxLength = 11
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
        'datagrid_sangria
        '
        Me.datagrid_sangria.AllowUserToAddRows = False
        Me.datagrid_sangria.AllowUserToDeleteRows = False
        Me.datagrid_sangria.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid_sangria.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagrid_sangria.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.datagrid_sangria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.datagrid_sangria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_sangria.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datagrid_sangria.ColumnHeadersHeight = 30
        Me.datagrid_sangria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagrid_sangria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_sangria, Me.gerente, Me.saldo_preSangria, Me.valor_sangria, Me.saldo_posSangria, Me.descricao, Me.data})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid_sangria.DefaultCellStyle = DataGridViewCellStyle3
        Me.datagrid_sangria.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.datagrid_sangria.Location = New System.Drawing.Point(13, 123)
        Me.datagrid_sangria.Name = "datagrid_sangria"
        Me.datagrid_sangria.ReadOnly = True
        Me.datagrid_sangria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_sangria.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.datagrid_sangria.RowHeadersVisible = False
        Me.datagrid_sangria.RowHeadersWidth = 51
        Me.datagrid_sangria.Size = New System.Drawing.Size(1041, 489)
        Me.datagrid_sangria.TabIndex = 125
        Me.datagrid_sangria.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt
        Me.datagrid_sangria.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.datagrid_sangria.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid_sangria.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.datagrid_sangria.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid_sangria.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid_sangria.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.datagrid_sangria.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.datagrid_sangria.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid_sangria.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.datagrid_sangria.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid_sangria.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.datagrid_sangria.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagrid_sangria.ThemeStyle.HeaderStyle.Height = 30
        Me.datagrid_sangria.ThemeStyle.ReadOnly = True
        Me.datagrid_sangria.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.datagrid_sangria.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagrid_sangria.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Roboto", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid_sangria.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.datagrid_sangria.ThemeStyle.RowsStyle.Height = 22
        Me.datagrid_sangria.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.datagrid_sangria.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'id_sangria
        '
        Me.id_sangria.HeaderText = "ID"
        Me.id_sangria.MinimumWidth = 6
        Me.id_sangria.Name = "id_sangria"
        Me.id_sangria.ReadOnly = True
        '
        'gerente
        '
        Me.gerente.HeaderText = "GERENTE"
        Me.gerente.MinimumWidth = 6
        Me.gerente.Name = "gerente"
        Me.gerente.ReadOnly = True
        '
        'saldo_preSangria
        '
        Me.saldo_preSangria.HeaderText = "SALDO PRÉ-SANGRIA"
        Me.saldo_preSangria.MinimumWidth = 6
        Me.saldo_preSangria.Name = "saldo_preSangria"
        Me.saldo_preSangria.ReadOnly = True
        '
        'valor_sangria
        '
        Me.valor_sangria.HeaderText = "VALOR DA SANGRIA"
        Me.valor_sangria.MinimumWidth = 6
        Me.valor_sangria.Name = "valor_sangria"
        Me.valor_sangria.ReadOnly = True
        '
        'saldo_posSangria
        '
        Me.saldo_posSangria.HeaderText = "SALDO PÓS-SANGRIA"
        Me.saldo_posSangria.MinimumWidth = 6
        Me.saldo_posSangria.Name = "saldo_posSangria"
        Me.saldo_posSangria.ReadOnly = True
        '
        'descricao
        '
        Me.descricao.HeaderText = "DESCRIÇÃO"
        Me.descricao.MinimumWidth = 6
        Me.descricao.Name = "descricao"
        Me.descricao.ReadOnly = True
        '
        'data
        '
        Me.data.HeaderText = "DATA"
        Me.data.MinimumWidth = 6
        Me.data.Name = "data"
        Me.data.ReadOnly = True
        '
        'HistoricoSangria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.datagrid_sangria)
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "HistoricoSangria"
        Me.Size = New System.Drawing.Size(1069, 624)
        Me.Panel3.ResumeLayout(False)
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        CType(Me.datagrid_sangria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_voltar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents cmb_type As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_search As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents datagrid_sangria As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents id_sangria As DataGridViewTextBoxColumn
    Friend WithEvents gerente As DataGridViewTextBoxColumn
    Friend WithEvents saldo_preSangria As DataGridViewTextBoxColumn
    Friend WithEvents valor_sangria As DataGridViewTextBoxColumn
    Friend WithEvents saldo_posSangria As DataGridViewTextBoxColumn
    Friend WithEvents descricao As DataGridViewTextBoxColumn
    Friend WithEvents data As DataGridViewTextBoxColumn
End Class
