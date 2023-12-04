<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EsqueciSenha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EsqueciSenha))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_senha = New Guna.UI.WinForms.GunaTextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txt_confirmarsenha = New Guna.UI.WinForms.GunaTextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.txt_cpf = New Guna.UI.WinForms.GunaTextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.btn_salvar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_fechar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(84, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 161)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(15, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(348, 65)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "________________"
        '
        'txt_senha
        '
        Me.txt_senha.BaseColor = System.Drawing.Color.White
        Me.txt_senha.BorderColor = System.Drawing.Color.Silver
        Me.txt_senha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_senha.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_senha.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_senha.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_senha.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(65, 275)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_senha.SelectedText = ""
        Me.txt_senha.Size = New System.Drawing.Size(263, 34)
        Me.txt_senha.TabIndex = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(29, 275)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 34)
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'txt_confirmarsenha
        '
        Me.txt_confirmarsenha.BaseColor = System.Drawing.Color.White
        Me.txt_confirmarsenha.BorderColor = System.Drawing.Color.Silver
        Me.txt_confirmarsenha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_confirmarsenha.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_confirmarsenha.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_confirmarsenha.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_confirmarsenha.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_confirmarsenha.Location = New System.Drawing.Point(65, 340)
        Me.txt_confirmarsenha.Name = "txt_confirmarsenha"
        Me.txt_confirmarsenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_confirmarsenha.SelectedText = ""
        Me.txt_confirmarsenha.Size = New System.Drawing.Size(263, 34)
        Me.txt_confirmarsenha.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(29, 340)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 34)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(26, 257)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(131, 14)
        Me.GunaLabel3.TabIndex = 29
        Me.GunaLabel3.Text = "Digite uma nova senha:"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(26, 322)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(98, 14)
        Me.GunaLabel1.TabIndex = 30
        Me.GunaLabel1.Text = "Confirmar senha:"
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.Transparent
        Me.btn_voltar.BackgroundImage = CType(resources.GetObject("btn_voltar.BackgroundImage"), System.Drawing.Image)
        Me.btn_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_voltar.FlatAppearance.BorderSize = 0
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Location = New System.Drawing.Point(0, 0)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(38, 28)
        Me.btn_voltar.TabIndex = 64
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'txt_cpf
        '
        Me.txt_cpf.BaseColor = System.Drawing.Color.White
        Me.txt_cpf.BorderColor = System.Drawing.Color.Silver
        Me.txt_cpf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cpf.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_cpf.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_cpf.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_cpf.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(65, 211)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cpf.SelectedText = ""
        Me.txt_cpf.Size = New System.Drawing.Size(263, 34)
        Me.txt_cpf.TabIndex = 0
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(29, 211)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(29, 34)
        Me.PictureBox4.TabIndex = 65
        Me.PictureBox4.TabStop = False
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(27, 193)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(33, 14)
        Me.GunaLabel2.TabIndex = 67
        Me.GunaLabel2.Text = "CPF:"
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
        Me.btn_salvar.ImageOffset = New System.Drawing.Point(25, 0)
        Me.btn_salvar.ImageSize = New System.Drawing.Size(25, 25)
        Me.btn_salvar.Location = New System.Drawing.Point(58, 397)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(269, 39)
        Me.btn_salvar.TabIndex = 99
        Me.btn_salvar.Text = "SALVAR"
        Me.btn_salvar.UseTransparentBackground = True
        '
        'btn_fechar
        '
        Me.btn_fechar.BackColor = System.Drawing.Color.Transparent
        Me.btn_fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_fechar.FlatAppearance.BorderSize = 0
        Me.btn_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fechar.Font = New System.Drawing.Font("Roboto Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fechar.Location = New System.Drawing.Point(331, 0)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(36, 28)
        Me.btn_fechar.TabIndex = 100
        Me.btn_fechar.Text = "X"
        Me.btn_fechar.UseVisualStyleBackColor = False
        '
        'EsqueciSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.btn_salvar)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.txt_confirmarsenha)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "EsqueciSenha"
        Me.Size = New System.Drawing.Size(367, 457)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_senha As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txt_confirmarsenha As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_voltar As Button
    Friend WithEvents txt_cpf As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_salvar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_fechar As Button
End Class
