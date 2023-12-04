<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_esqueci = New System.Windows.Forms.Label()
        Me.chk_mostrar = New Guna.UI.WinForms.GunaCheckBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_usuario = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_senha = New Guna.UI.WinForms.GunaTextBox()
        Me.btn_login = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.Panel = New Guna.UI2.WinForms.Guna2Panel()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(21, 209)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 34)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(21, 267)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 34)
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
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
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "________________"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(84, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 161)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'lbl_esqueci
        '
        Me.lbl_esqueci.AutoSize = True
        Me.lbl_esqueci.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_esqueci.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_esqueci.Location = New System.Drawing.Point(130, 433)
        Me.lbl_esqueci.Name = "lbl_esqueci"
        Me.lbl_esqueci.Size = New System.Drawing.Size(113, 13)
        Me.lbl_esqueci.TabIndex = 13
        Me.lbl_esqueci.Text = "Esqueci minha senha"
        '
        'chk_mostrar
        '
        Me.chk_mostrar.BaseColor = System.Drawing.Color.White
        Me.chk_mostrar.CheckedOffColor = System.Drawing.Color.Gray
        Me.chk_mostrar.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chk_mostrar.FillColor = System.Drawing.Color.White
        Me.chk_mostrar.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_mostrar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk_mostrar.Location = New System.Drawing.Point(57, 307)
        Me.chk_mostrar.Name = "chk_mostrar"
        Me.chk_mostrar.Size = New System.Drawing.Size(103, 20)
        Me.chk_mostrar.TabIndex = 14
        Me.chk_mostrar.Text = "Mostrar senha"
        '
        'txt_usuario
        '
        Me.txt_usuario.BaseColor = System.Drawing.Color.White
        Me.txt_usuario.BorderColor = System.Drawing.Color.Silver
        Me.txt_usuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_usuario.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_usuario.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_usuario.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_usuario.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.Location = New System.Drawing.Point(56, 209)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_usuario.SelectedText = ""
        Me.txt_usuario.Size = New System.Drawing.Size(263, 34)
        Me.txt_usuario.TabIndex = 15
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
        Me.txt_senha.Location = New System.Drawing.Point(57, 267)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_senha.SelectedText = ""
        Me.txt_senha.Size = New System.Drawing.Size(263, 34)
        Me.txt_senha.TabIndex = 16
        '
        'btn_login
        '
        Me.btn_login.Animated = True
        Me.btn_login.BackColor = System.Drawing.Color.Transparent
        Me.btn_login.BorderRadius = 5
        Me.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_login.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_login.FillColor = System.Drawing.Color.Orange
        Me.btn_login.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_login.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_login.Location = New System.Drawing.Point(56, 355)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(263, 39)
        Me.btn_login.TabIndex = 65
        Me.btn_login.Text = "Login"
        Me.btn_login.UseTransparentBackground = True
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
        Me.btn_fechar.TabIndex = 66
        Me.btn_fechar.Text = "X"
        Me.btn_fechar.UseVisualStyleBackColor = False
        '
        'Panel
        '
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(367, 457)
        Me.Panel.TabIndex = 67
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(367, 457)
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.chk_mostrar)
        Me.Controls.Add(Me.lbl_esqueci)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pizza²"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_esqueci As Label
    Friend WithEvents chk_mostrar As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents txt_usuario As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_senha As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btn_login As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_fechar As Button
    Friend WithEvents Panel As Guna.UI2.WinForms.Guna2Panel
End Class
