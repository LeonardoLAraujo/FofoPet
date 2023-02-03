Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_CLIENTE.Click
        Call form1.ShowDialog()
    End Sub

    Private Sub BTN_CADASTRAR_Click_1(sender As Object, e As EventArgs) Handles BTN_CADASTRAR.Click
        Call Form2.ShowDialog()
    End Sub

    Private Sub BTN_SAIR_CONTA_Click_1(sender As Object, e As EventArgs) Handles BTN_SAIR_CONTA.Click
        Call Form3.Show()
        Me.Visible = False
        limparTela_Login()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BTN_FECHAR.Click
        Call Form3.Show()
        Me.Visible = False
        limparTela_Login()
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

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class