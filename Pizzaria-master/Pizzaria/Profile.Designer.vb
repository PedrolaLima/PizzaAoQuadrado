<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Profile))
        Me.lbl_cep = New System.Windows.Forms.Label()
        Me.lbl_cpf = New System.Windows.Forms.Label()
        Me.lbl_datanasc = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.lbl_cargo = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.pic_userInfo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.batata = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_celular = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        CType(Me.pic_userInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_cep
        '
        Me.lbl_cep.AutoSize = True
        Me.lbl_cep.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cep.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cep.ForeColor = System.Drawing.Color.White
        Me.lbl_cep.Location = New System.Drawing.Point(299, 219)
        Me.lbl_cep.Name = "lbl_cep"
        Me.lbl_cep.Size = New System.Drawing.Size(50, 18)
        Me.lbl_cep.TabIndex = 102
        Me.lbl_cep.Text = "Email:"
        '
        'lbl_cpf
        '
        Me.lbl_cpf.AutoSize = True
        Me.lbl_cpf.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cpf.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cpf.ForeColor = System.Drawing.Color.White
        Me.lbl_cpf.Location = New System.Drawing.Point(299, 187)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(50, 18)
        Me.lbl_cpf.TabIndex = 100
        Me.lbl_cpf.Text = "Email:"
        '
        'lbl_datanasc
        '
        Me.lbl_datanasc.AutoSize = True
        Me.lbl_datanasc.BackColor = System.Drawing.Color.Transparent
        Me.lbl_datanasc.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_datanasc.ForeColor = System.Drawing.Color.White
        Me.lbl_datanasc.Location = New System.Drawing.Point(299, 155)
        Me.lbl_datanasc.Name = "lbl_datanasc"
        Me.lbl_datanasc.Size = New System.Drawing.Size(50, 18)
        Me.lbl_datanasc.TabIndex = 98
        Me.lbl_datanasc.Text = "Email:"
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.BackColor = System.Drawing.Color.Transparent
        Me.lbl_username.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.ForeColor = System.Drawing.Color.White
        Me.lbl_username.Location = New System.Drawing.Point(299, 59)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(80, 18)
        Me.lbl_username.TabIndex = 96
        Me.lbl_username.Text = "Username:"
        '
        'lbl_cargo
        '
        Me.lbl_cargo.AutoSize = True
        Me.lbl_cargo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cargo.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cargo.ForeColor = System.Drawing.Color.White
        Me.lbl_cargo.Location = New System.Drawing.Point(299, 251)
        Me.lbl_cargo.Name = "lbl_cargo"
        Me.lbl_cargo.Size = New System.Drawing.Size(50, 18)
        Me.lbl_cargo.TabIndex = 95
        Me.lbl_cargo.Text = "Email:"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.ForeColor = System.Drawing.Color.White
        Me.lbl_email.Location = New System.Drawing.Point(299, 123)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(50, 18)
        Me.lbl_email.TabIndex = 94
        Me.lbl_email.Text = "Email:"
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nome.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.ForeColor = System.Drawing.Color.White
        Me.lbl_nome.Location = New System.Drawing.Point(299, 27)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(53, 18)
        Me.lbl_nome.TabIndex = 93
        Me.lbl_nome.Text = "Nome:"
        '
        'pic_userInfo
        '
        Me.pic_userInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_userInfo.ErrorImage = CType(resources.GetObject("pic_userInfo.ErrorImage"), System.Drawing.Image)
        Me.pic_userInfo.FillColor = System.Drawing.Color.Wheat
        Me.pic_userInfo.Image = CType(resources.GetObject("pic_userInfo.Image"), System.Drawing.Image)
        Me.pic_userInfo.ImageRotate = 0!
        Me.pic_userInfo.Location = New System.Drawing.Point(326, 26)
        Me.pic_userInfo.Name = "pic_userInfo"
        Me.pic_userInfo.Size = New System.Drawing.Size(220, 222)
        Me.pic_userInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_userInfo.TabIndex = 88
        Me.pic_userInfo.TabStop = False
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2PictureBox2.FillColor = System.Drawing.Color.Wheat
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(317, 18)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(239, 240)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 89
        Me.Guna2PictureBox2.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(118, 217)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 21)
        Me.Label13.TabIndex = 101
        Me.Label13.Text = "CEP:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(118, 185)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 21)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "CPF:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(118, 153)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 21)
        Me.Label9.TabIndex = 97
        Me.Label9.Text = "Data de Nascimento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(118, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 21)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(118, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 21)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Cargo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 21)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Celular:"
        '
        'batata
        '
        Me.batata.AutoSize = True
        Me.batata.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.batata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.batata.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batata.Location = New System.Drawing.Point(118, 25)
        Me.batata.Name = "batata"
        Me.batata.Size = New System.Drawing.Size(59, 21)
        Me.batata.TabIndex = 87
        Me.batata.Text = "Nome:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(118, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 21)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Email:"
        '
        'lbl_celular
        '
        Me.lbl_celular.AutoSize = True
        Me.lbl_celular.BackColor = System.Drawing.Color.Transparent
        Me.lbl_celular.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_celular.ForeColor = System.Drawing.Color.White
        Me.lbl_celular.Location = New System.Drawing.Point(299, 91)
        Me.lbl_celular.Name = "lbl_celular"
        Me.lbl_celular.Size = New System.Drawing.Size(50, 18)
        Me.lbl_celular.TabIndex = 104
        Me.lbl_celular.Text = "Email:"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BorderColor = System.Drawing.Color.DarkOrange
        Me.Guna2GradientPanel1.BorderRadius = 30
        Me.Guna2GradientPanel1.BorderThickness = 5
        Me.Guna2GradientPanel1.Controls.Add(Me.lbl_celular)
        Me.Guna2GradientPanel1.Controls.Add(Me.batata)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label4)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel1.Controls.Add(Me.lbl_cep)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label2)
        Me.Guna2GradientPanel1.Controls.Add(Me.lbl_cpf)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label3)
        Me.Guna2GradientPanel1.Controls.Add(Me.lbl_datanasc)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label9)
        Me.Guna2GradientPanel1.Controls.Add(Me.lbl_username)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label11)
        Me.Guna2GradientPanel1.Controls.Add(Me.lbl_cargo)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label13)
        Me.Guna2GradientPanel1.Controls.Add(Me.lbl_email)
        Me.Guna2GradientPanel1.Controls.Add(Me.lbl_nome)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(52, 282)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(768, 298)
        Me.Guna2GradientPanel1.TabIndex = 105
        '
        'Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pic_userInfo)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Name = "Profile"
        Me.Size = New System.Drawing.Size(884, 597)
        CType(Me.pic_userInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_cep As Label
    Friend WithEvents lbl_cpf As Label
    Friend WithEvents lbl_datanasc As Label
    Friend WithEvents lbl_username As Label
    Friend WithEvents lbl_cargo As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_nome As Label
    Friend WithEvents pic_userInfo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents batata As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_celular As Label
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
End Class
