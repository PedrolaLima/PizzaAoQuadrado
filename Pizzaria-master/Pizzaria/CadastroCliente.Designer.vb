<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadastroCliente))
        Me.GunaLabel14 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_celular = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_cpf = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.lbl_email = New Guna.UI.WinForms.GunaLabel()
        Me.txt_bairro = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_logradouro = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_cep = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_email = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_nome = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.pic_cliente = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.lbl_cpf = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.lbl_celular = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel16 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_cidade = New Guna.UI.WinForms.GunaTextBox()
        Me.dtp_birthDate = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.GunaLabel12 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_complemento = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_uf = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_numero = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.chk_sim = New MetroFramework.Controls.MetroCheckBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.btn_salvar = New Guna.UI2.WinForms.Guna2GradientButton()
        CType(Me.pic_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GunaGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaLabel14
        '
        Me.GunaLabel14.AutoSize = True
        Me.GunaLabel14.BackColor = System.Drawing.Color.White
        Me.GunaLabel14.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel14.Location = New System.Drawing.Point(23, 182)
        Me.GunaLabel14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel14.Name = "GunaLabel14"
        Me.GunaLabel14.Size = New System.Drawing.Size(105, 18)
        Me.GunaLabel14.TabIndex = 88
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
        Me.txt_celular.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_celular.Location = New System.Drawing.Point(27, 204)
        Me.txt_celular.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_celular.MaxLength = 11
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_celular.SelectedText = ""
        Me.txt_celular.Size = New System.Drawing.Size(232, 38)
        Me.txt_celular.TabIndex = 71
        '
        'txt_cpf
        '
        Me.txt_cpf.BaseColor = System.Drawing.Color.White
        Me.txt_cpf.BorderColor = System.Drawing.Color.Silver
        Me.txt_cpf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cpf.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_cpf.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cpf.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_cpf.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(285, 204)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cpf.MaxLength = 11
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cpf.SelectedText = ""
        Me.txt_cpf.Size = New System.Drawing.Size(232, 38)
        Me.txt_cpf.TabIndex = 72
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.BackColor = System.Drawing.Color.White
        Me.GunaLabel10.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.Location = New System.Drawing.Point(23, 386)
        Me.GunaLabel10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(52, 18)
        Me.GunaLabel10.TabIndex = 85
        Me.GunaLabel10.Text = "Bairro:"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.BackColor = System.Drawing.Color.White
        Me.lbl_email.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.ForeColor = System.Drawing.Color.Red
        Me.lbl_email.Location = New System.Drawing.Point(83, 108)
        Me.lbl_email.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(143, 18)
        Me.lbl_email.TabIndex = 67
        Me.lbl_email.Text = "Email já cadastrado!"
        Me.lbl_email.Visible = False
        '
        'txt_bairro
        '
        Me.txt_bairro.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.txt_bairro.BorderColor = System.Drawing.Color.Silver
        Me.txt_bairro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_bairro.Enabled = False
        Me.txt_bairro.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_bairro.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_bairro.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_bairro.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bairro.Location = New System.Drawing.Point(27, 409)
        Me.txt_bairro.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_bairro.SelectedText = ""
        Me.txt_bairro.Size = New System.Drawing.Size(232, 38)
        Me.txt_bairro.TabIndex = 76
        '
        'txt_logradouro
        '
        Me.txt_logradouro.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.txt_logradouro.BorderColor = System.Drawing.Color.Silver
        Me.txt_logradouro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_logradouro.Enabled = False
        Me.txt_logradouro.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_logradouro.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_logradouro.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_logradouro.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_logradouro.Location = New System.Drawing.Point(285, 341)
        Me.txt_logradouro.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_logradouro.Name = "txt_logradouro"
        Me.txt_logradouro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_logradouro.SelectedText = ""
        Me.txt_logradouro.Size = New System.Drawing.Size(232, 38)
        Me.txt_logradouro.TabIndex = 74
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.BackColor = System.Drawing.Color.White
        Me.GunaLabel7.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.Location = New System.Drawing.Point(23, 319)
        Me.GunaLabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(40, 18)
        Me.GunaLabel7.TabIndex = 83
        Me.GunaLabel7.Text = "CEP:"
        '
        'txt_cep
        '
        Me.txt_cep.BaseColor = System.Drawing.Color.White
        Me.txt_cep.BorderColor = System.Drawing.Color.Silver
        Me.txt_cep.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cep.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_cep.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cep.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_cep.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cep.Location = New System.Drawing.Point(27, 341)
        Me.txt_cep.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cep.MaxLength = 8
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cep.SelectedText = ""
        Me.txt_cep.Size = New System.Drawing.Size(232, 38)
        Me.txt_cep.TabIndex = 73
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.White
        Me.GunaLabel2.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(23, 108)
        Me.GunaLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(49, 18)
        Me.GunaLabel2.TabIndex = 79
        Me.GunaLabel2.Text = "Email:"
        '
        'txt_email
        '
        Me.txt_email.BaseColor = System.Drawing.Color.White
        Me.txt_email.BorderColor = System.Drawing.Color.Silver
        Me.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_email.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_email.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_email.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_email.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(27, 130)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_email.SelectedText = ""
        Me.txt_email.Size = New System.Drawing.Size(491, 38)
        Me.txt_email.TabIndex = 68
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.White
        Me.GunaLabel1.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(23, 39)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(118, 18)
        Me.GunaLabel1.TabIndex = 78
        Me.GunaLabel1.Text = "Nome completo:"
        '
        'txt_nome
        '
        Me.txt_nome.BaseColor = System.Drawing.Color.White
        Me.txt_nome.BorderColor = System.Drawing.Color.Silver
        Me.txt_nome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nome.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_nome.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_nome.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_nome.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(27, 62)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nome.SelectedText = ""
        Me.txt_nome.Size = New System.Drawing.Size(491, 38)
        Me.txt_nome.TabIndex = 66
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.BackColor = System.Drawing.Color.White
        Me.GunaLabel9.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.Location = New System.Drawing.Point(284, 386)
        Me.GunaLabel9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(58, 18)
        Me.GunaLabel9.TabIndex = 50
        Me.GunaLabel9.Text = "Cidade:"
        '
        'pic_cliente
        '
        Me.pic_cliente.BackColor = System.Drawing.SystemColors.Control
        Me.pic_cliente.BaseColor = System.Drawing.Color.White
        Me.pic_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_cliente.Image = CType(resources.GetObject("pic_cliente.Image"), System.Drawing.Image)
        Me.pic_cliente.Location = New System.Drawing.Point(887, 112)
        Me.pic_cliente.Margin = New System.Windows.Forms.Padding(4)
        Me.pic_cliente.Name = "pic_cliente"
        Me.pic_cliente.Size = New System.Drawing.Size(397, 324)
        Me.pic_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_cliente.TabIndex = 86
        Me.pic_cliente.TabStop = False
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.BackColor = System.Drawing.Color.White
        Me.GunaLabel6.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(281, 319)
        Me.GunaLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(87, 18)
        Me.GunaLabel6.TabIndex = 84
        Me.GunaLabel6.Text = "Logradouro:"
        '
        'lbl_cpf
        '
        Me.lbl_cpf.AutoSize = True
        Me.lbl_cpf.BackColor = System.Drawing.Color.White
        Me.lbl_cpf.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cpf.ForeColor = System.Drawing.Color.Red
        Me.lbl_cpf.Location = New System.Drawing.Point(333, 182)
        Me.lbl_cpf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(134, 18)
        Me.lbl_cpf.TabIndex = 65
        Me.lbl_cpf.Text = "CPF já cadastrado!"
        Me.lbl_cpf.Visible = False
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel5.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(948, 465)
        Me.GunaLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(151, 18)
        Me.GunaLabel5.TabIndex = 82
        Me.GunaLabel5.Text = "Serviço de fidelidade:"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.White
        Me.GunaLabel4.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(283, 181)
        Me.GunaLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(40, 18)
        Me.GunaLabel4.TabIndex = 81
        Me.GunaLabel4.Text = "CPF:"
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
        Me.Panel3.TabIndex = 77
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.Transparent
        Me.btn_voltar.BackgroundImage = CType(resources.GetObject("btn_voltar.BackgroundImage"), System.Drawing.Image)
        Me.btn_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_voltar.FlatAppearance.BorderSize = 0
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Location = New System.Drawing.Point(1376, 0)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(51, 33)
        Me.btn_voltar.TabIndex = 15
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'GunaGradientPanel1
        '
        Me.GunaGradientPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GunaGradientPanel1.BackgroundImage = CType(resources.GetObject("GunaGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel1.Controls.Add(Me.lbl_celular)
        Me.GunaGradientPanel1.Controls.Add(Me.lbl_email)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel14)
        Me.GunaGradientPanel1.Controls.Add(Me.txt_email)
        Me.GunaGradientPanel1.Controls.Add(Me.lbl_cpf)
        Me.GunaGradientPanel1.Controls.Add(Me.txt_celular)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel9)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel16)
        Me.GunaGradientPanel1.Controls.Add(Me.txt_cidade)
        Me.GunaGradientPanel1.Controls.Add(Me.dtp_birthDate)
        Me.GunaGradientPanel1.Controls.Add(Me.txt_cpf)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel12)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel10)
        Me.GunaGradientPanel1.Controls.Add(Me.txt_complemento)
        Me.GunaGradientPanel1.Controls.Add(Me.txt_bairro)
        Me.GunaGradientPanel1.Controls.Add(Me.txt_uf)
        Me.GunaGradientPanel1.Controls.Add(Me.txt_logradouro)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel8)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel7)
        Me.GunaGradientPanel1.Controls.Add(Me.txt_numero)
        Me.GunaGradientPanel1.Controls.Add(Me.txt_cep)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel11)
        Me.GunaGradientPanel1.Controls.Add(Me.txt_nome)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel4)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel6)
        Me.GunaGradientPanel1.GradientColor1 = System.Drawing.Color.White
        Me.GunaGradientPanel1.GradientColor2 = System.Drawing.Color.White
        Me.GunaGradientPanel1.GradientColor3 = System.Drawing.Color.White
        Me.GunaGradientPanel1.GradientColor4 = System.Drawing.Color.White
        Me.GunaGradientPanel1.Location = New System.Drawing.Point(105, 112)
        Me.GunaGradientPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaGradientPanel1.Name = "GunaGradientPanel1"
        Me.GunaGradientPanel1.Size = New System.Drawing.Size(555, 562)
        Me.GunaGradientPanel1.TabIndex = 94
        Me.GunaGradientPanel1.Text = "GunaGradientPanel1"
        '
        'lbl_celular
        '
        Me.lbl_celular.AutoSize = True
        Me.lbl_celular.BackColor = System.Drawing.Color.White
        Me.lbl_celular.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_celular.ForeColor = System.Drawing.Color.Red
        Me.lbl_celular.Location = New System.Drawing.Point(125, 182)
        Me.lbl_celular.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_celular.Name = "lbl_celular"
        Me.lbl_celular.Size = New System.Drawing.Size(153, 18)
        Me.lbl_celular.TabIndex = 93
        Me.lbl_celular.Text = "Celular já cadastrado!"
        Me.lbl_celular.Visible = False
        '
        'GunaLabel16
        '
        Me.GunaLabel16.AutoSize = True
        Me.GunaLabel16.BackColor = System.Drawing.Color.White
        Me.GunaLabel16.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel16.Location = New System.Drawing.Point(23, 250)
        Me.GunaLabel16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel16.Name = "GunaLabel16"
        Me.GunaLabel16.Size = New System.Drawing.Size(148, 18)
        Me.GunaLabel16.TabIndex = 92
        Me.GunaLabel16.Text = "Data de Nascimento:"
        '
        'txt_cidade
        '
        Me.txt_cidade.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.txt_cidade.BorderColor = System.Drawing.Color.Silver
        Me.txt_cidade.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cidade.Enabled = False
        Me.txt_cidade.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_cidade.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cidade.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_cidade.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cidade.Location = New System.Drawing.Point(288, 409)
        Me.txt_cidade.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cidade.SelectedText = ""
        Me.txt_cidade.Size = New System.Drawing.Size(231, 38)
        Me.txt_cidade.TabIndex = 49
        '
        'dtp_birthDate
        '
        Me.dtp_birthDate.BaseColor = System.Drawing.Color.White
        Me.dtp_birthDate.BorderColor = System.Drawing.Color.Silver
        Me.dtp_birthDate.CustomFormat = Nothing
        Me.dtp_birthDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtp_birthDate.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtp_birthDate.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_birthDate.ForeColor = System.Drawing.Color.Black
        Me.dtp_birthDate.Location = New System.Drawing.Point(27, 272)
        Me.dtp_birthDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtp_birthDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtp_birthDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtp_birthDate.Name = "dtp_birthDate"
        Me.dtp_birthDate.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtp_birthDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtp_birthDate.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtp_birthDate.OnPressedColor = System.Drawing.Color.Black
        Me.dtp_birthDate.Size = New System.Drawing.Size(491, 37)
        Me.dtp_birthDate.TabIndex = 90
        Me.dtp_birthDate.Text = "quinta-feira, 30 de novembro de 2023"
        Me.dtp_birthDate.Value = New Date(2023, 11, 30, 0, 0, 0, 0)
        '
        'GunaLabel12
        '
        Me.GunaLabel12.AutoSize = True
        Me.GunaLabel12.BackColor = System.Drawing.Color.White
        Me.GunaLabel12.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel12.Location = New System.Drawing.Point(285, 453)
        Me.GunaLabel12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(105, 18)
        Me.GunaLabel12.TabIndex = 48
        Me.GunaLabel12.Text = "Complemento:"
        '
        'txt_complemento
        '
        Me.txt_complemento.BaseColor = System.Drawing.Color.White
        Me.txt_complemento.BorderColor = System.Drawing.Color.Silver
        Me.txt_complemento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_complemento.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_complemento.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_complemento.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_complemento.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_complemento.Location = New System.Drawing.Point(289, 475)
        Me.txt_complemento.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_complemento.Name = "txt_complemento"
        Me.txt_complemento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_complemento.SelectedText = ""
        Me.txt_complemento.Size = New System.Drawing.Size(231, 38)
        Me.txt_complemento.TabIndex = 9
        '
        'txt_uf
        '
        Me.txt_uf.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.txt_uf.BorderColor = System.Drawing.Color.Silver
        Me.txt_uf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_uf.Enabled = False
        Me.txt_uf.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_uf.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_uf.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_uf.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_uf.Location = New System.Drawing.Point(29, 475)
        Me.txt_uf.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_uf.MaxLength = 2
        Me.txt_uf.Name = "txt_uf"
        Me.txt_uf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_uf.SelectedText = ""
        Me.txt_uf.Size = New System.Drawing.Size(64, 38)
        Me.txt_uf.TabIndex = 9
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.BackColor = System.Drawing.Color.White
        Me.GunaLabel8.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.Location = New System.Drawing.Point(25, 454)
        Me.GunaLabel8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(30, 18)
        Me.GunaLabel8.TabIndex = 40
        Me.GunaLabel8.Text = "UF:"
        '
        'txt_numero
        '
        Me.txt_numero.BaseColor = System.Drawing.Color.White
        Me.txt_numero.BorderColor = System.Drawing.Color.Silver
        Me.txt_numero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_numero.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_numero.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_numero.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_numero.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero.Location = New System.Drawing.Point(115, 475)
        Me.txt_numero.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_numero.MaxLength = 5
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_numero.SelectedText = ""
        Me.txt_numero.Size = New System.Drawing.Size(145, 38)
        Me.txt_numero.TabIndex = 8
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.BackColor = System.Drawing.Color.White
        Me.GunaLabel11.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.Location = New System.Drawing.Point(111, 454)
        Me.GunaLabel11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(65, 18)
        Me.GunaLabel11.TabIndex = 46
        Me.GunaLabel11.Text = "Número:"
        '
        'chk_sim
        '
        Me.chk_sim.AutoSize = True
        Me.chk_sim.BackColor = System.Drawing.Color.Transparent
        Me.chk_sim.Checked = True
        Me.chk_sim.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_sim.CustomBackground = False
        Me.chk_sim.Enabled = False
        Me.chk_sim.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chk_sim.FontSize = MetroFramework.MetroLinkSize.Small
        Me.chk_sim.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.chk_sim.Location = New System.Drawing.Point(952, 487)
        Me.chk_sim.Margin = New System.Windows.Forms.Padding(4)
        Me.chk_sim.Name = "chk_sim"
        Me.chk_sim.Size = New System.Drawing.Size(248, 17)
        Me.chk_sim.Style = MetroFramework.MetroColorStyle.Blue
        Me.chk_sim.StyleManager = Nothing
        Me.chk_sim.TabIndex = 96
        Me.chk_sim.Text = "Sim, será um membro do Clube Pizza²"
        Me.chk_sim.Theme = MetroFramework.MetroThemeStyle.Light
        Me.chk_sim.UseStyleColors = False
        Me.chk_sim.UseVisualStyleBackColor = False
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Roboto", 24.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(156, 54)
        Me.GunaLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(397, 48)
        Me.GunaLabel3.TabIndex = 97
        Me.GunaLabel3.Text = "Cadastro de Clientes"
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
        Me.btn_salvar.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar.ForeColor = System.Drawing.Color.White
        Me.btn_salvar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_salvar.Image = CType(resources.GetObject("btn_salvar.Image"), System.Drawing.Image)
        Me.btn_salvar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_salvar.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btn_salvar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_salvar.Location = New System.Drawing.Point(952, 603)
        Me.btn_salvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(265, 71)
        Me.btn_salvar.TabIndex = 98
        Me.btn_salvar.Text = "SALVAR"
        Me.btn_salvar.TextOffset = New System.Drawing.Point(10, 0)
        Me.btn_salvar.UseTransparentBackground = True
        '
        'CadastroCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_salvar)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.chk_sim)
        Me.Controls.Add(Me.pic_cliente)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CadastroCliente"
        Me.Size = New System.Drawing.Size(1425, 768)
        CType(Me.pic_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.GunaGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaLabel14 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_celular As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_cpf As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_email As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_bairro As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_logradouro As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_cep As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_email As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_nome As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents pic_cliente As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_cpf As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_voltar As Button
    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents txt_cidade As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel12 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_complemento As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_uf As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_numero As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents chk_sim As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel16 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dtp_birthDate As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents btn_salvar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lbl_celular As Guna.UI.WinForms.GunaLabel
End Class
