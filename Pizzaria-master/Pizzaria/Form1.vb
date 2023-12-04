Imports System.Runtime.InteropServices

Public Class Form1

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2


    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function


    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel.MouseDown
        Dim alturaPermitida As Integer = 100

        If e.Button = Windows.Forms.MouseButtons.Left Then
            If e.Y <= alturaPermitida Then
                ReleaseCapture()
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
            End If
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_senha.UseSystemPasswordChar = True
        txt_usuario.Select()
    End Sub

    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Application.Exit()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If Not String.IsNullOrWhiteSpace(txt_usuario.Text) And Not String.IsNullOrWhiteSpace(txt_senha.Text) Then
            Dim SQL As String = ""
            SQL &= "SELECT * FROM tb_login "
            SQL &= "WHERE (UPPER(Username) = UPPER('" & txt_usuario.Text & "') OR UPPER(Email) =  UPPER('" & txt_usuario.Text & "')) "
            SQL &= "AND Password = '" & txt_senha.Text & "' "

            Dim UserData As DataTable = UseSQL(SQL)

            If UserData.Rows.Count > 0 Then
                userLogged = txt_usuario.Text
                If Job(userLogged) = False Then
                    MsgBox("Conta bloqueada!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
                    Exit Sub
                Else
                    txt_usuario.Clear()
                    txt_senha.Clear()
                    Me.Hide()
                    Form2.Show()
                    Form2.loadForm()
                    Me.txt_usuario.Select()
                    Dashboard.instance.load_information()
                End If
            Else
                MsgBox("O usuário ou senha não existem!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Erro ao entrar na conta!")
                txt_usuario.Focus()
                txt_usuario.SelectAll()
            End If

        Else
            MsgBox("Por favor, preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Erro ao entrar na conta!")
            txt_usuario.Select()
        End If
    End Sub

    Private Sub UserEnter(sender As Object, e As KeyEventArgs) Handles txt_usuario.KeyDown, txt_senha.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_login.PerformClick()
        End If
    End Sub

    Private Sub chk_mostrar_CheckedChanged(sender As Object, e As EventArgs) Handles chk_mostrar.CheckedChanged
        With chk_mostrar
            If .Checked Then
                txt_senha.UseSystemPasswordChar = False
            Else
                txt_senha.UseSystemPasswordChar = True
            End If
        End With
    End Sub

    Private Sub lbl_esqueci_Click(sender As Object, e As EventArgs) Handles lbl_esqueci.Click
        If Not Panel.Controls.Contains(EsqueciSenha.Instance) Then
            Panel.Controls.Add(EsqueciSenha.Instance)
            OcultarControles(btn_fechar, PictureBox1, Label4, txt_usuario, txt_senha, PictureBox2, PictureBox3, chk_mostrar, btn_login, lbl_esqueci)
            EsqueciSenha.Instance.Dock = DockStyle.Fill
            EsqueciSenha.Instance.BringToFront()
            EsqueciSenha.Instance.Visible = True
            AddHandler EsqueciSenha.Instance.MouseDown, AddressOf Form1_MouseDown

        End If
        OcultarControles(btn_fechar, PictureBox1, Label4, txt_usuario, txt_senha, PictureBox2, PictureBox3, chk_mostrar, btn_login, lbl_esqueci)
        EsqueciSenha.Instance.BringToFront()
        EsqueciSenha.Instance.Visible = True


    End Sub

    Function Job(user As String) As Boolean
        Dim SQL As String = ""
        SQL &= "SELECT tb_jobs.Jname "
        SQL &= "FROM tb_login "
        SQL &= "INNER JOIN tb_jobs ON tb_jobs.Jcode = tb_login.Jcode "
        SQL &= "WHERE Username = '" & user & "' OR Email = '" & user & "';"

        Dim UserData As DataTable = UseSQL(SQL)
        If UserData.Rows(0)("Jname").ToString = "Gerente" Or UserData.Rows(0)("Jname").ToString = "Operador de Caixa" Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub OcultarControles(ParamArray controles() As Control)
        For Each ctrl As Control In controles
            ctrl.Enabled = False
            ctrl.Visible = False
        Next
    End Sub
    Public Sub ExibirControles(ParamArray controles() As Control)
        For Each ctrl As Control In controles
            ctrl.Enabled = True
            ctrl.Visible = True
        Next
    End Sub
End Class