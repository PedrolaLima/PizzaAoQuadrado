<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sangria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sangria))
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_descricao = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_saldoDepois = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_valor = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_saldoAntes = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btn_confirmar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Panel3.SuspendLayout()
        Me.GunaGradientPanel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btn_voltar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1425, 33)
        Me.Panel3.TabIndex = 97
        '
        'GunaGradientPanel1
        '
        Me.GunaGradientPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GunaGradientPanel1.BackgroundImage = CType(resources.GetObject("GunaGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel4)
        Me.GunaGradientPanel1.Controls.Add(Me.txt_descricao)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel3)
        Me.GunaGradientPanel1.Controls.Add(Me.txt_saldoDepois)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaGradientPanel1.Controls.Add(Me.txt_valor)
        Me.GunaGradientPanel1.Controls.Add(Me.txt_saldoAntes)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaGradientPanel1.GradientColor1 = System.Drawing.Color.White
        Me.GunaGradientPanel1.GradientColor2 = System.Drawing.Color.White
        Me.GunaGradientPanel1.GradientColor3 = System.Drawing.Color.White
        Me.GunaGradientPanel1.GradientColor4 = System.Drawing.Color.White
        Me.GunaGradientPanel1.Location = New System.Drawing.Point(135, 103)
        Me.GunaGradientPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaGradientPanel1.Name = "GunaGradientPanel1"
        Me.GunaGradientPanel1.Size = New System.Drawing.Size(643, 452)
        Me.GunaGradientPanel1.TabIndex = 98
        Me.GunaGradientPanel1.Text = "GunaGradientPanel1"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.White
        Me.GunaLabel4.Cursor = System.Windows.Forms.Cursors.Default
        Me.GunaLabel4.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(22, 260)
        Me.GunaLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(151, 18)
        Me.GunaLabel4.TabIndex = 83
        Me.GunaLabel4.Text = "Descrição (Opcional):"
        '
        'txt_descricao
        '
        Me.txt_descricao.BaseColor = System.Drawing.Color.White
        Me.txt_descricao.BorderColor = System.Drawing.Color.Silver
        Me.txt_descricao.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_descricao.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_descricao.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_descricao.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_descricao.Font = New System.Drawing.Font("Roboto", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descricao.Location = New System.Drawing.Point(26, 282)
        Me.txt_descricao.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_descricao.MaxLength = 120
        Me.txt_descricao.Multiline = True
        Me.txt_descricao.Name = "txt_descricao"
        Me.txt_descricao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_descricao.SelectedText = ""
        Me.txt_descricao.Size = New System.Drawing.Size(501, 105)
        Me.txt_descricao.TabIndex = 82
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.White
        Me.GunaLabel3.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(23, 156)
        Me.GunaLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(139, 18)
        Me.GunaLabel3.TabIndex = 81
        Me.GunaLabel3.Text = "Saldo após sangria:"
        '
        'txt_saldoDepois
        '
        Me.txt_saldoDepois.BaseColor = System.Drawing.Color.Gainsboro
        Me.txt_saldoDepois.BorderColor = System.Drawing.Color.Silver
        Me.txt_saldoDepois.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_saldoDepois.Enabled = False
        Me.txt_saldoDepois.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_saldoDepois.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_saldoDepois.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_saldoDepois.Font = New System.Drawing.Font("Roboto", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_saldoDepois.Location = New System.Drawing.Point(27, 178)
        Me.txt_saldoDepois.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_saldoDepois.MaxLength = 12
        Me.txt_saldoDepois.Name = "txt_saldoDepois"
        Me.txt_saldoDepois.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_saldoDepois.SelectedText = ""
        Me.txt_saldoDepois.Size = New System.Drawing.Size(500, 49)
        Me.txt_saldoDepois.TabIndex = 80
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.White
        Me.GunaLabel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.GunaLabel2.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(296, 52)
        Me.GunaLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(121, 18)
        Me.GunaLabel2.TabIndex = 79
        Me.GunaLabel2.Text = "Valor da sangria:"
        '
        'txt_valor
        '
        Me.txt_valor.BaseColor = System.Drawing.Color.White
        Me.txt_valor.BorderColor = System.Drawing.Color.Silver
        Me.txt_valor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_valor.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_valor.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_valor.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_valor.Font = New System.Drawing.Font("Roboto", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_valor.Location = New System.Drawing.Point(300, 74)
        Me.txt_valor.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_valor.MaxLength = 11
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_valor.SelectedText = ""
        Me.txt_valor.Size = New System.Drawing.Size(227, 49)
        Me.txt_valor.TabIndex = 68
        '
        'txt_saldoAntes
        '
        Me.txt_saldoAntes.BaseColor = System.Drawing.Color.Gainsboro
        Me.txt_saldoAntes.BorderColor = System.Drawing.Color.Silver
        Me.txt_saldoAntes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_saldoAntes.Enabled = False
        Me.txt_saldoAntes.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_saldoAntes.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_saldoAntes.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_saldoAntes.Font = New System.Drawing.Font("Roboto", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_saldoAntes.Location = New System.Drawing.Point(27, 74)
        Me.txt_saldoAntes.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_saldoAntes.Name = "txt_saldoAntes"
        Me.txt_saldoAntes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_saldoAntes.SelectedText = ""
        Me.txt_saldoAntes.Size = New System.Drawing.Size(231, 49)
        Me.txt_saldoAntes.TabIndex = 66
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.White
        Me.GunaLabel1.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(23, 52)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(86, 18)
        Me.GunaLabel1.TabIndex = 78
        Me.GunaLabel1.Text = "Saldo atual:"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(886, 103)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(497, 452)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 99
        Me.Guna2PictureBox1.TabStop = False
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Animated = True
        Me.btn_confirmar.BackColor = System.Drawing.Color.Transparent
        Me.btn_confirmar.BorderRadius = 5
        Me.btn_confirmar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_confirmar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_confirmar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_confirmar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_confirmar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_confirmar.FillColor = System.Drawing.Color.Orange
        Me.btn_confirmar.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_confirmar.Font = New System.Drawing.Font("Roboto", 16.2!, System.Drawing.FontStyle.Bold)
        Me.btn_confirmar.ForeColor = System.Drawing.Color.White
        Me.btn_confirmar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_confirmar.Image = CType(resources.GetObject("btn_confirmar.Image"), System.Drawing.Image)
        Me.btn_confirmar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_confirmar.ImageOffset = New System.Drawing.Point(50, 0)
        Me.btn_confirmar.ImageSize = New System.Drawing.Size(40, 40)
        Me.btn_confirmar.Location = New System.Drawing.Point(886, 627)
        Me.btn_confirmar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(497, 71)
        Me.btn_confirmar.TabIndex = 109
        Me.btn_confirmar.Text = "CONFIRMAR"
        Me.btn_confirmar.TextOffset = New System.Drawing.Point(15, 0)
        Me.btn_confirmar.UseTransparentBackground = True
        '
        'Sangria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.Controls.Add(Me.Panel3)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Sangria"
        Me.Size = New System.Drawing.Size(1425, 768)
        Me.Panel3.ResumeLayout(False)
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.GunaGradientPanel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_voltar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_saldoDepois As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_valor As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_saldoAntes As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btn_confirmar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_descricao As Guna.UI.WinForms.GunaTextBox
End Class
