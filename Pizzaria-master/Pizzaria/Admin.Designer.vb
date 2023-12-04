<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.btn_cadastrar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_gerenciarColab = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_sangria = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_gerenciarcli = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.SuspendLayout()
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.Animated = True
        Me.btn_cadastrar.AutoRoundedCorners = True
        Me.btn_cadastrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_cadastrar.BorderRadius = 92
        Me.btn_cadastrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_cadastrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_cadastrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_cadastrar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_cadastrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_cadastrar.FillColor = System.Drawing.Color.Orange
        Me.btn_cadastrar.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_cadastrar.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar.ForeColor = System.Drawing.Color.White
        Me.btn_cadastrar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_cadastrar.Image = CType(resources.GetObject("btn_cadastrar.Image"), System.Drawing.Image)
        Me.btn_cadastrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_cadastrar.ImageOffset = New System.Drawing.Point(16, -8)
        Me.btn_cadastrar.ImageSize = New System.Drawing.Size(65, 65)
        Me.btn_cadastrar.Location = New System.Drawing.Point(109, 146)
        Me.btn_cadastrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(369, 187)
        Me.btn_cadastrar.TabIndex = 66
        Me.btn_cadastrar.Text = "           Adicionar      Colaborador  "
        Me.btn_cadastrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btn_cadastrar.TextOffset = New System.Drawing.Point(-10, 0)
        '
        'btn_gerenciarColab
        '
        Me.btn_gerenciarColab.Animated = True
        Me.btn_gerenciarColab.AutoRoundedCorners = True
        Me.btn_gerenciarColab.BackColor = System.Drawing.Color.Transparent
        Me.btn_gerenciarColab.BorderRadius = 92
        Me.btn_gerenciarColab.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_gerenciarColab.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_gerenciarColab.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_gerenciarColab.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_gerenciarColab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_gerenciarColab.FillColor = System.Drawing.Color.Orange
        Me.btn_gerenciarColab.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_gerenciarColab.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gerenciarColab.ForeColor = System.Drawing.Color.White
        Me.btn_gerenciarColab.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_gerenciarColab.Image = CType(resources.GetObject("btn_gerenciarColab.Image"), System.Drawing.Image)
        Me.btn_gerenciarColab.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_gerenciarColab.ImageOffset = New System.Drawing.Point(10, -6)
        Me.btn_gerenciarColab.ImageSize = New System.Drawing.Size(80, 80)
        Me.btn_gerenciarColab.Location = New System.Drawing.Point(639, 146)
        Me.btn_gerenciarColab.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_gerenciarColab.Name = "btn_gerenciarColab"
        Me.btn_gerenciarColab.Size = New System.Drawing.Size(369, 187)
        Me.btn_gerenciarColab.TabIndex = 67
        Me.btn_gerenciarColab.Text = "Gerenciar          Colaboradores  "
        Me.btn_gerenciarColab.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btn_gerenciarColab.TextOffset = New System.Drawing.Point(-5, -2)
        '
        'btn_sangria
        '
        Me.btn_sangria.Animated = True
        Me.btn_sangria.AutoRoundedCorners = True
        Me.btn_sangria.BackColor = System.Drawing.Color.Transparent
        Me.btn_sangria.BorderRadius = 92
        Me.btn_sangria.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_sangria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_sangria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_sangria.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_sangria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_sangria.FillColor = System.Drawing.Color.Orange
        Me.btn_sangria.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_sangria.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sangria.ForeColor = System.Drawing.Color.White
        Me.btn_sangria.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_sangria.Image = CType(resources.GetObject("btn_sangria.Image"), System.Drawing.Image)
        Me.btn_sangria.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_sangria.ImageOffset = New System.Drawing.Point(13, 2)
        Me.btn_sangria.ImageSize = New System.Drawing.Size(70, 70)
        Me.btn_sangria.Location = New System.Drawing.Point(109, 432)
        Me.btn_sangria.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_sangria.Name = "btn_sangria"
        Me.btn_sangria.Size = New System.Drawing.Size(369, 187)
        Me.btn_sangria.TabIndex = 68
        Me.btn_sangria.Text = "                Realizar                  Sangria"
        Me.btn_sangria.TextOffset = New System.Drawing.Point(10, 0)
        '
        'btn_gerenciarcli
        '
        Me.btn_gerenciarcli.Animated = True
        Me.btn_gerenciarcli.AutoRoundedCorners = True
        Me.btn_gerenciarcli.BackColor = System.Drawing.Color.Transparent
        Me.btn_gerenciarcli.BorderRadius = 92
        Me.btn_gerenciarcli.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_gerenciarcli.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_gerenciarcli.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_gerenciarcli.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_gerenciarcli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_gerenciarcli.FillColor = System.Drawing.Color.Orange
        Me.btn_gerenciarcli.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_gerenciarcli.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gerenciarcli.ForeColor = System.Drawing.Color.White
        Me.btn_gerenciarcli.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_gerenciarcli.Image = CType(resources.GetObject("btn_gerenciarcli.Image"), System.Drawing.Image)
        Me.btn_gerenciarcli.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_gerenciarcli.ImageOffset = New System.Drawing.Point(22, -1)
        Me.btn_gerenciarcli.ImageSize = New System.Drawing.Size(65, 65)
        Me.btn_gerenciarcli.Location = New System.Drawing.Point(639, 432)
        Me.btn_gerenciarcli.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_gerenciarcli.Name = "btn_gerenciarcli"
        Me.btn_gerenciarcli.Size = New System.Drawing.Size(369, 187)
        Me.btn_gerenciarcli.TabIndex = 69
        Me.btn_gerenciarcli.Text = "                  Gerenciar                    Clientes"
        Me.btn_gerenciarcli.TextOffset = New System.Drawing.Point(-10, 0)
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_gerenciarcli)
        Me.Controls.Add(Me.btn_sangria)
        Me.Controls.Add(Me.btn_gerenciarColab)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Admin"
        Me.Size = New System.Drawing.Size(1179, 730)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_cadastrar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_gerenciarColab As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_sangria As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_gerenciarcli As Guna.UI2.WinForms.Guna2GradientButton
End Class
