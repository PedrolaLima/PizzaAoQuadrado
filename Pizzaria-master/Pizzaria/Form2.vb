Imports System.Runtime.InteropServices

Public Class Form2
 
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub Form2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_data.Text = DateTime.Now
    End Sub

    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Application.Exit()
    End Sub

    Private Sub buttonsColor()
        btn_admin.ForeColor = Color.White
        btn_caixa.ForeColor = Color.White
        btn_dashboard.ForeColor = Color.White
        btn_historico.ForeColor = Color.White
    End Sub
    Private Function UserPhoto(user As String) As String


        Dim SQL As String = ""
        SQL &= "SELECT Photo FROM tb_login "
        SQL &= "WHERE Username = '" & user & "' or Email = '" & user & "'"

        Dim result As DataTable = UseSQL(SQL)

        If result.Rows.Count > 0 Then
            Dim foto As String = result.Rows(0)("Photo").ToString()
            Dim indiceDebug As Integer = foto.IndexOf("Debug")
            If indiceDebug <> -1 Then
                Dim resultado As String = foto.Substring(indiceDebug + "Debug".Length)
                Return Application.StartupPath + resultado
            Else
                Return result.Rows(0)("Photo").ToString()
            End If
        Else
            Return Nothing
        End If
    End Function

    Private Sub Job(user As String)
        Dim SQL As String = ""
        SQL &= "SELECT tb_jobs.Jname "
        SQL &= "FROM tb_login "
        SQL &= "INNER JOIN tb_jobs ON tb_jobs.Jcode = tb_login.Jcode "
        SQL &= "WHERE Username = '" & user & "' OR Email = '" & user & "';"

        Dim UserData As DataTable = UseSQL(SQL)
        If UserData.Rows(0)("Jname").ToString = "Gerente" Then
            btn_admin.Visible = True
            btn_admin.Enabled = True
        ElseIf UserData.Rows(0)("Jname").ToString = "Operador de Caixa" Then
            btn_admin.Visible = False
            btn_admin.Enabled = False
        Else
            MsgBox("Conta bloqueada!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
            Form1.Show()
            Me.Hide()
            Exit Sub
        End If
    End Sub

    Private Sub btn_admin_Click(sender As Object, e As EventArgs) Handles btn_admin.Click
        SidePanel.Visible = True
        SidePanel.Height = btn_admin.Height
        SidePanel.Top = btn_admin.Top
        buttonsColor()
        btn_admin.ForeColor = Color.FromArgb(255, 168, 87)

        If Not Panel9.Controls.Contains(Admin.instance) Then
            Panel9.Controls.Add(Admin.instance)
            Admin.instance.Dock = DockStyle.Fill
            Admin.instance.BringToFront()
            Admin.instance.Visible = True
        End If
        Admin.instance.BringToFront()
        Admin.instance.Visible = True
    End Sub

    Private Sub btn_dashboard_Click(sender As Object, e As EventArgs) Handles btn_dashboard.Click
        SidePanel.Visible = True
        SidePanel.Height = btn_dashboard.Height
        SidePanel.Top = btn_dashboard.Top
        buttonsColor()
        btn_dashboard.ForeColor = Color.FromArgb(255, 168, 87)
        Dashboard.instance.load_information()

        If Not Panel9.Controls.Contains(Dashboard.instance) Then
            Panel9.Controls.Add(Dashboard.instance)
            Dashboard.instance.Dock = DockStyle.Fill
            Dashboard.instance.BringToFront()
            Dashboard.instance.Visible = True
        End If
        Dashboard.instance.BringToFront()
        Dashboard.instance.Visible = True
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddHandler AdicionarPizza.instance.Panel3.MouseDown, AddressOf Form2_MouseDown
        AddHandler Cadastro.instance.Panel3.MouseDown, AddressOf Form2_MouseDown
        AddHandler CadastroCliente.instance.Panel3.MouseDown, AddressOf Form2_MouseDown
        AddHandler GerenciarCliente.instance.Panel3.MouseDown, AddressOf Form2_MouseDown
        AddHandler GerenciarColab.instance.Panel3.MouseDown, AddressOf Form2_MouseDown
        AddHandler HistoricoPedido.instance.Panel3.MouseDown, AddressOf Form2_MouseDown
        AddHandler HistoricoSangria.instance.Panel3.MouseDown, AddressOf Form2_MouseDown
        AddHandler Sangria.instance.Panel3.MouseDown, AddressOf Form2_MouseDown

        loadForm()
    End Sub

    Sub loadForm()
        Job(userLogged)
        SidePanel.Visible = False
        lbl_data.Text = DateTime.Now
        lbl_usuario.Text = userLogged
        pic_user.ImageLocation = UserPhoto(userLogged)
        If Not Panel9.Controls.Contains(Dashboard.instance) Then
            Panel9.Controls.Add(Dashboard.instance)
            Dashboard.instance.Dock = DockStyle.Fill
            Dashboard.instance.BringToFront()
        End If
        Dashboard.instance.BringToFront()
    End Sub
    Private Sub btn_historico_Click(sender As Object, e As EventArgs) Handles btn_historico.Click
        SidePanel.Visible = True
        SidePanel.Height = btn_historico.Height
        SidePanel.Top = btn_historico.Top
        buttonsColor()
        btn_historico.ForeColor = Color.FromArgb(255, 168, 87)

        If Not Panel9.Controls.Contains(Historico.instance) Then
            Panel9.Controls.Add(Historico.instance)
            Historico.instance.Dock = DockStyle.Fill
            Historico.instance.BringToFront()
            Historico.instance.Visible = True
        End If
        Historico.instance.BringToFront()
        Historico.instance.Visible = True
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        resp = MsgBox("Tem certeza que deseja sair?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Atenção")

        If resp = vbYes Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btn_caixa_Click(sender As Object, e As EventArgs) Handles btn_caixa.Click
        SidePanel.Visible = True
        SidePanel.Height = btn_caixa.Height
        SidePanel.Top = btn_caixa.Top
        buttonsColor()
        btn_caixa.ForeColor = Color.FromArgb(255, 168, 87)

        If Not Panel9.Controls.Contains(Caixa.instance) Then
            Panel9.Controls.Add(Caixa.instance)
            Caixa.instance.Dock = DockStyle.Fill
            Caixa.instance.BringToFront()
            Caixa.instance.Visible = True

        End If
        Caixa.instance.BringToFront()
        Caixa.instance.Visible = True
    End Sub

    Private Sub pic_user_Click(sender As Object, e As EventArgs) Handles pic_user.Click, Guna2PictureBox1.Click
        SidePanel.Visible = False
        buttonsColor()
        Profile.instance.LoadProfile()

        If Not Panel9.Controls.Contains(Profile.instance) Then
            Panel9.Controls.Add(Profile.instance)
            Profile.instance.Dock = DockStyle.Fill
            Profile.instance.BringToFront()
            Profile.instance.Visible = True
        End If
        Profile.instance.BringToFront()
        Profile.instance.Visible = True

    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class