Public Class Form5

    Private Sub BTN_CADASTRAR_CONTA_Click(sender As Object, e As EventArgs) Handles BTN_CADASTRAR_CONTA.Click
        Call Form4.Show()
    End Sub

    Private Sub BTN_CONSULTAR_PROD_Click(sender As Object, e As EventArgs) Handles BTN_CONSULTAR_PROD.Click
        Form7.Show()
    End Sub

    Private Sub BTN_CONSULTAR_CLIENTES_Click_1(sender As Object, e As EventArgs) Handles BTN_CONSULTAR_CLIENTES.Click
        Form8.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Visible = False
        limparTela_Login()
    End Sub

    Private Sub BTN_MIN_Click(sender As Object, e As EventArgs) Handles BTN_MIN.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BTN_MAX_Click(sender As Object, e As EventArgs) Handles BTN_MAX.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub BTN_FECHAR_Click(sender As Object, e As EventArgs) Handles BTN_FECHAR.Click
        Call Form3.Show()
        Me.Visible = False
        limparTela_Login()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class