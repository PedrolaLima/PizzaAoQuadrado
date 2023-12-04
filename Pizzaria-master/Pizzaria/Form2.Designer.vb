<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.lbl_data = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_minimize = New System.Windows.Forms.Button()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.pic_user = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btn_admin = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_logout = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_historico = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_caixa = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_dashboard = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pic_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_data
        '
        Me.lbl_data.AutoSize = True
        Me.lbl_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data.ForeColor = System.Drawing.Color.White
        Me.lbl_data.Location = New System.Drawing.Point(67, 718)
        Me.lbl_data.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(38, 17)
        Me.lbl_data.TabIndex = 13
        Me.lbl_data.Text = "Data"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(21, 718)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Data:"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.ForeColor = System.Drawing.Color.White
        Me.lbl_usuario.Location = New System.Drawing.Point(100, 693)
        Me.lbl_usuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(57, 17)
        Me.lbl_usuario.TabIndex = 1
        Me.lbl_usuario.Text = "Usuario"
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.SidePanel.Location = New System.Drawing.Point(2, 304)
        Me.SidePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(18, 36)
        Me.SidePanel.TabIndex = 1
        Me.SidePanel.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(21, 693)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Bem vindo, "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(2, 5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 108)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(114, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 28)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "QUADRADO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 89)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(210, 41)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "________________"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(115, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 28)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "AO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(116, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "PIZZA"
        '
        'Panel9
        '
        Me.Panel9.Location = New System.Drawing.Point(247, 34)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1179, 734)
        Me.Panel9.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btn_minimize)
        Me.Panel3.Controls.Add(Me.btn_fechar)
        Me.Panel3.Location = New System.Drawing.Point(248, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1179, 34)
        Me.Panel3.TabIndex = 1
        '
        'btn_minimize
        '
        Me.btn_minimize.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_minimize.FlatAppearance.BorderSize = 0
        Me.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_minimize.Location = New System.Drawing.Point(1084, -5)
        Me.btn_minimize.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(48, 38)
        Me.btn_minimize.TabIndex = 15
        Me.btn_minimize.Text = "_"
        Me.btn_minimize.UseVisualStyleBackColor = False
        '
        'btn_fechar
        '
        Me.btn_fechar.BackColor = System.Drawing.Color.Transparent
        Me.btn_fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_fechar.FlatAppearance.BorderSize = 0
        Me.btn_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fechar.Location = New System.Drawing.Point(1132, -2)
        Me.btn_fechar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(48, 36)
        Me.btn_fechar.TabIndex = 14
        Me.btn_fechar.Text = "X"
        Me.btn_fechar.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.pic_user)
        Me.Panel1.Controls.Add(Me.btn_admin)
        Me.Panel1.Controls.Add(Me.btn_logout)
        Me.Panel1.Controls.Add(Me.btn_historico)
        Me.Panel1.Controls.Add(Me.btn_caixa)
        Me.Panel1.Controls.Add(Me.btn_dashboard)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lbl_data)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lbl_usuario)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.SidePanel)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Panel1.ForeColor = System.Drawing.Color.Coral
        Me.Panel1.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 768)
        Me.Panel1.TabIndex = 0
        '
        'pic_user
        '
        Me.pic_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_user.ErrorImage = CType(resources.GetObject("pic_user.ErrorImage"), System.Drawing.Image)
        Me.pic_user.FillColor = System.Drawing.Color.Wheat
        Me.pic_user.Image = CType(resources.GetObject("pic_user.Image"), System.Drawing.Image)
        Me.pic_user.ImageRotate = 0!
        Me.pic_user.Location = New System.Drawing.Point(52, 148)
        Me.pic_user.Margin = New System.Windows.Forms.Padding(4)
        Me.pic_user.Name = "pic_user"
        Me.pic_user.Size = New System.Drawing.Size(141, 136)
        Me.pic_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_user.TabIndex = 0
        Me.pic_user.TabStop = False
        '
        'btn_admin
        '
        Me.btn_admin.Animated = True
        Me.btn_admin.BackColor = System.Drawing.Color.Transparent
        Me.btn_admin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_admin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_admin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_admin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_admin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_admin.FillColor = System.Drawing.Color.Empty
        Me.btn_admin.FillColor2 = System.Drawing.Color.Empty
        Me.btn_admin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btn_admin.ForeColor = System.Drawing.Color.White
        Me.btn_admin.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_admin.Location = New System.Drawing.Point(27, 434)
        Me.btn_admin.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_admin.Name = "btn_admin"
        Me.btn_admin.Size = New System.Drawing.Size(200, 36)
        Me.btn_admin.TabIndex = 70
        Me.btn_admin.Text = "Admin"
        Me.btn_admin.UseTransparentBackground = True
        '
        'btn_logout
        '
        Me.btn_logout.Animated = True
        Me.btn_logout.BackColor = System.Drawing.Color.Transparent
        Me.btn_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_logout.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_logout.FillColor = System.Drawing.Color.Empty
        Me.btn_logout.FillColor2 = System.Drawing.Color.Empty
        Me.btn_logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btn_logout.ForeColor = System.Drawing.Color.White
        Me.btn_logout.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_logout.Location = New System.Drawing.Point(27, 588)
        Me.btn_logout.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(200, 36)
        Me.btn_logout.TabIndex = 69
        Me.btn_logout.Text = "Sair"
        Me.btn_logout.UseTransparentBackground = True
        '
        'btn_historico
        '
        Me.btn_historico.Animated = True
        Me.btn_historico.BackColor = System.Drawing.Color.Transparent
        Me.btn_historico.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_historico.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_historico.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_historico.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_historico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_historico.FillColor = System.Drawing.Color.Empty
        Me.btn_historico.FillColor2 = System.Drawing.Color.Empty
        Me.btn_historico.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btn_historico.ForeColor = System.Drawing.Color.White
        Me.btn_historico.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_historico.Location = New System.Drawing.Point(27, 390)
        Me.btn_historico.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_historico.Name = "btn_historico"
        Me.btn_historico.Size = New System.Drawing.Size(200, 36)
        Me.btn_historico.TabIndex = 68
        Me.btn_historico.Text = "Histórico"
        Me.btn_historico.UseTransparentBackground = True
        '
        'btn_caixa
        '
        Me.btn_caixa.Animated = True
        Me.btn_caixa.BackColor = System.Drawing.Color.Transparent
        Me.btn_caixa.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_caixa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_caixa.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_caixa.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_caixa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_caixa.FillColor = System.Drawing.Color.Empty
        Me.btn_caixa.FillColor2 = System.Drawing.Color.Empty
        Me.btn_caixa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btn_caixa.ForeColor = System.Drawing.Color.White
        Me.btn_caixa.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_caixa.Location = New System.Drawing.Point(27, 347)
        Me.btn_caixa.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_caixa.Name = "btn_caixa"
        Me.btn_caixa.Size = New System.Drawing.Size(200, 36)
        Me.btn_caixa.TabIndex = 67
        Me.btn_caixa.Text = "Caixa"
        Me.btn_caixa.UseTransparentBackground = True
        '
        'btn_dashboard
        '
        Me.btn_dashboard.Animated = True
        Me.btn_dashboard.BackColor = System.Drawing.Color.Transparent
        Me.btn_dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_dashboard.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_dashboard.FillColor = System.Drawing.Color.Empty
        Me.btn_dashboard.FillColor2 = System.Drawing.Color.Empty
        Me.btn_dashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btn_dashboard.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_dashboard.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_dashboard.Location = New System.Drawing.Point(27, 304)
        Me.btn_dashboard.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_dashboard.Name = "btn_dashboard"
        Me.btn_dashboard.Size = New System.Drawing.Size(200, 36)
        Me.btn_dashboard.TabIndex = 66
        Me.btn_dashboard.Text = "Dashboard"
        Me.btn_dashboard.UseTransparentBackground = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Wheat
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(46, 142)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(155, 148)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 71
        Me.Guna2PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1426, 768)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pic_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents SidePanel As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl_data As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn_fechar As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel1 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents btn_dashboard As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_caixa As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_logout As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_historico As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_admin As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents pic_user As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btn_minimize As Button
End Class
