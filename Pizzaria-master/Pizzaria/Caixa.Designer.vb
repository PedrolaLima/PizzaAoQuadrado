<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Caixa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Caixa))
        Me.btn_cadastrar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_addpizza = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_pedido = New Guna.UI2.WinForms.Guna2GradientButton()
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
        Me.btn_cadastrar.Font = New System.Drawing.Font("Roboto", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar.ForeColor = System.Drawing.Color.Black
        Me.btn_cadastrar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_cadastrar.Image = CType(resources.GetObject("btn_cadastrar.Image"), System.Drawing.Image)
        Me.btn_cadastrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_cadastrar.ImageOffset = New System.Drawing.Point(25, -3)
        Me.btn_cadastrar.ImageSize = New System.Drawing.Size(68, 68)
        Me.btn_cadastrar.Location = New System.Drawing.Point(99, 136)
        Me.btn_cadastrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(369, 187)
        Me.btn_cadastrar.TabIndex = 67
        Me.btn_cadastrar.Text = "             Adicionar          Cliente"
        Me.btn_cadastrar.TextOffset = New System.Drawing.Point(13, 0)
        '
        'btn_addpizza
        '
        Me.btn_addpizza.Animated = True
        Me.btn_addpizza.AutoRoundedCorners = True
        Me.btn_addpizza.BackColor = System.Drawing.Color.Transparent
        Me.btn_addpizza.BorderRadius = 92
        Me.btn_addpizza.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_addpizza.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_addpizza.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_addpizza.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_addpizza.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_addpizza.FillColor = System.Drawing.Color.Orange
        Me.btn_addpizza.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_addpizza.Font = New System.Drawing.Font("Roboto", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addpizza.ForeColor = System.Drawing.Color.Black
        Me.btn_addpizza.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_addpizza.Image = CType(resources.GetObject("btn_addpizza.Image"), System.Drawing.Image)
        Me.btn_addpizza.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_addpizza.ImageOffset = New System.Drawing.Point(25, 0)
        Me.btn_addpizza.ImageSize = New System.Drawing.Size(68, 68)
        Me.btn_addpizza.Location = New System.Drawing.Point(415, 408)
        Me.btn_addpizza.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_addpizza.Name = "btn_addpizza"
        Me.btn_addpizza.Size = New System.Drawing.Size(369, 187)
        Me.btn_addpizza.TabIndex = 68
        Me.btn_addpizza.Text = "             Adicionar              Produto"
        Me.btn_addpizza.TextOffset = New System.Drawing.Point(23, 0)
        '
        'btn_pedido
        '
        Me.btn_pedido.Animated = True
        Me.btn_pedido.AutoRoundedCorners = True
        Me.btn_pedido.BackColor = System.Drawing.Color.Transparent
        Me.btn_pedido.BorderRadius = 92
        Me.btn_pedido.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_pedido.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_pedido.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_pedido.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_pedido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_pedido.FillColor = System.Drawing.Color.Orange
        Me.btn_pedido.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_pedido.Font = New System.Drawing.Font("Roboto", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pedido.ForeColor = System.Drawing.Color.Black
        Me.btn_pedido.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_pedido.Image = CType(resources.GetObject("btn_pedido.Image"), System.Drawing.Image)
        Me.btn_pedido.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_pedido.ImageOffset = New System.Drawing.Point(25, 0)
        Me.btn_pedido.ImageSize = New System.Drawing.Size(68, 68)
        Me.btn_pedido.Location = New System.Drawing.Point(733, 136)
        Me.btn_pedido.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_pedido.Name = "btn_pedido"
        Me.btn_pedido.Size = New System.Drawing.Size(369, 187)
        Me.btn_pedido.TabIndex = 69
        Me.btn_pedido.Text = "                Realizar                 Pedido"
        Me.btn_pedido.TextOffset = New System.Drawing.Point(13, 0)
        '
        'Caixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_pedido)
        Me.Controls.Add(Me.btn_addpizza)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Caixa"
        Me.Size = New System.Drawing.Size(1179, 730)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_cadastrar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_addpizza As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_pedido As Guna.UI2.WinForms.Guna2GradientButton
End Class
