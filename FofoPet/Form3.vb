Imports FofoPet.clsAcesso
Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
     
    End Sub
    Private Sub TXT_CPF_LOGIN_DoubleClick(sender As Object, e As EventArgs)
        limparTela_Login()
    End Sub

    Private Sub BTN_ENTRAR_Click(sender As Object, e As EventArgs) Handles BTN_ENTRAR.Click
        Acesso()
        limpar()
    End Sub

#Region " Acesso ao Usuário"
    Private Sub Acesso()
        If Me.TXT_CPF_LOGIN.Text = String.Empty Or TXT_SENHA_LOGIN.Text = String.Empty Then
            MsgBox("Campos estão Vazios!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End If

        If Me.TXT_CPF_LOGIN.Text = "111.111.111-11" And TXT_SENHA_LOGIN.Text = "11111111111" Then
            MsgBox("Login feito com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Form5.ShowDialog()
        End If

        If AcessoLogin(TXT_CPF_LOGIN.Text, TXT_SENHA_LOGIN.Text) = True Then
            MsgBox("Login feito com Sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Me.Hide()
            Form6.ShowDialog()
        End If
    End Sub
#End Region

    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        resposta = MsgBox("Você realmente desejar Sair?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resposta = vbYes Then
            Me.Close()
        End If

    End Sub

#Region "Limpeza de objetos"
    Private Sub limpar()
        Dim ctrl As Control

        For Each ctrl In Me.Controls
            If TypeName(ctrl) = "TextBox" Then
                ctrl.Text = String.Empty
            End If
        Next

    End Sub
#End Region

    Private Sub MessageBox(p1 As String)
        Throw New NotImplementedException
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BTN_MAX_Click(sender As Object, e As EventArgs) Handles BTN_MAX.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub BTN_MIN_Click(sender As Object, e As EventArgs) Handles BTN_MIN.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TXT_CPF_LOGIN_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles TXT_CPF_LOGIN.MaskInputRejected

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub
End Class