<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Historico))
        Me.btn_historicoPedido = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_historicoSangria = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.SuspendLayout()
        '
        'btn_historicoPedido
        '
        Me.btn_historicoPedido.AutoRoundedCorners = True
        Me.btn_historicoPedido.BorderRadius = 76
        Me.btn_historicoPedido.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_historicoPedido.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_historicoPedido.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_historicoPedido.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_historicoPedido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_historicoPedido.FillColor = System.Drawing.Color.Orange
        Me.btn_historicoPedido.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_historicoPedido.Font = New System.Drawing.Font("Roboto", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_historicoPedido.ForeColor = System.Drawing.Color.White
        Me.btn_historicoPedido.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_historicoPedido.Image = CType(resources.GetObject("btn_historicoPedido.Image"), System.Drawing.Image)
        Me.btn_historicoPedido.ImageOffset = New System.Drawing.Point(-70, 30)
        Me.btn_historicoPedido.ImageSize = New System.Drawing.Size(65, 65)
        Me.btn_historicoPedido.Location = New System.Drawing.Point(727, 305)
        Me.btn_historicoPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_historicoPedido.Name = "btn_historicoPedido"
        Me.btn_historicoPedido.Size = New System.Drawing.Size(333, 155)
        Me.btn_historicoPedido.TabIndex = 31
        Me.btn_historicoPedido.Text = "                                                        Histórico                " &
    "  De Pedidos"
        Me.btn_historicoPedido.TextOffset = New System.Drawing.Point(15, -46)
        '
        'btn_historicoSangria
        '
        Me.btn_historicoSangria.AutoRoundedCorners = True
        Me.btn_historicoSangria.BorderRadius = 76
        Me.btn_historicoSangria.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_historicoSangria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_historicoSangria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_historicoSangria.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_historicoSangria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_historicoSangria.FillColor = System.Drawing.Color.Orange
        Me.btn_historicoSangria.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_historicoSangria.Font = New System.Drawing.Font("Roboto", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_historicoSangria.ForeColor = System.Drawing.Color.White
        Me.btn_historicoSangria.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btn_historicoSangria.Image = CType(resources.GetObject("btn_historicoSangria.Image"), System.Drawing.Image)
        Me.btn_historicoSangria.ImageOffset = New System.Drawing.Point(-69, 31)
        Me.btn_historicoSangria.ImageSize = New System.Drawing.Size(65, 65)
        Me.btn_historicoSangria.Location = New System.Drawing.Point(88, 305)
        Me.btn_historicoSangria.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_historicoSangria.Name = "btn_historicoSangria"
        Me.btn_historicoSangria.Size = New System.Drawing.Size(333, 155)
        Me.btn_historicoSangria.TabIndex = 32
        Me.btn_historicoSangria.Text = "                                                         Histórico               " &
    "   De Sangria"
        Me.btn_historicoSangria.TextOffset = New System.Drawing.Point(15, -46)
        '
        'Historico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_historicoPedido)
        Me.Controls.Add(Me.btn_historicoSangria)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Historico"
        Me.Size = New System.Drawing.Size(1179, 730)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_historicoPedido As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_historicoSangria As Guna.UI2.WinForms.Guna2GradientButton
End Class
