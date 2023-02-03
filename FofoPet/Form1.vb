Public Class form1

    Private Sub TXT_CPF_DoubleClick(sender As Object, e As EventArgs) Handles TXT_CPF.DoubleClick
        limparTela_CadastroCliente()
    End Sub

    Private Sub BTN_GRAVAR_Click(sender As Object, e As EventArgs) Handles BTN_GRAVAR.Click
        Try
            sqlQuery = "insert into tb_cadastrar_cliente values ('" & TXT_CPF.Text & "'," & _
                                                  "'" & TXT_NOME.Text & "'," & _
                                                  "'" & TXT_CEP.Text & "'," & _
                                                  "'" & TXT_ENDERECO.Text & "'," & _
                                                  "'" & TXT_COMPLE.Text & "'," & _
                                                  "'" & TXT_BAIRRO.Text & "'," & _
                                                  "'" & TXT_CIDADE.Text & "'," & _
                                                  "'" & TXT_UF.Text & "'," & _
                                                  "'" & TXT_FONE.Text & "'," & _
                                                  "'" & TXT_CELU.Text & "'," & _
                                                  "'" & TXTEMAIL.Text & "')"
            If Me.TXT_CPF.Text = String.Empty Or Me.TXT_NOME.Text = String.Empty Or TXT_CEP.Text = String.Empty Or TXT_ENDERECO.Text = String.Empty Or TXT_COMPLE.Text = String.Empty Or TXT_BAIRRO.Text = String.Empty Or TXT_CIDADE.Text = String.Empty Or TXT_UF.Text = String.Empty Or TXT_FONE.Text = String.Empty Or TXT_CELU.Text = String.Empty Or TXT_EMAIL.Text = String.Empty Then
                MsgBox("Campos estão Vazios!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End If
            tabela = banco_Dados.Execute(UCase(sqlQuery))
            MsgBox("Cliente cadastrado com Sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            limparTela_CadastroCliente()
        Catch ex As Exception
            MsgBox("Erro ao cadastrar Cliente!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub TXT_CPF_LostFocus(sender As Object, e As EventArgs) Handles TXT_CPF.LostFocus
        Try
            sqlQuery = "select * from tb_cadastrar_cliente where cpf='" & TXT_CPF.Text & "'"
            tabela = banco_Dados.Execute(sqlQuery)
            If tabela.EOF = False Then
                TXT_NOME.Text = tabela.Fields(1).Value
                TXT_CEP.Text = tabela.Fields(2).Value
                TXT_ENDERECO.Text = tabela.Fields(3).Value
                TXT_COMPLE.Text = tabela.Fields(4).Value
                TXT_BAIRRO.Text = tabela.Fields(5).Value
                TXT_CIDADE.Text = tabela.Fields(6).Value
                TXT_UF.Text = tabela.Fields(7).Value
                TXT_FONE.Text = tabela.Fields(8).Value
                TXT_CELU.Text = tabela.Fields(9).Value
                TXTEMAIL.Text = tabela.Fields(10).Value
            Else
                TXT_NOME.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro ao Carregar informações do Cliente!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_Banco()
    End Sub

    Private Sub BTN_EXCLUIR_Click(sender As Object, e As EventArgs) Handles BTN_EXCLUIR.Click

        If Me.TXT_CPF.Text = String.Empty Or Me.TXT_NOME.Text = String.Empty Or TXT_CEP.Text = String.Empty Or TXT_ENDERECO.Text = String.Empty Or TXT_COMPLE.Text = String.Empty Or TXT_BAIRRO.Text = String.Empty Or TXT_CIDADE.Text = String.Empty Or TXT_UF.Text = String.Empty Or TXT_FONE.Text = String.Empty Or TXT_CELU.Text = String.Empty Or TXT_EMAIL.Text = String.Empty Then
            MsgBox("Campos estão Vazios!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End If

        resposta = MsgBox("Deseja excluir o Cliente: " & TXT_NOME.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resposta = MsgBoxResult.Yes Then
            sqlQuery = "delete from tb_cadastrar_cliente where cpf= '" & TXT_CPF.Text & "'"
            tabela = banco_Dados.Execute(sqlQuery)
            MsgBox("Cliente apagado com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            limparTela_CadastroCliente()
        End If
    End Sub

    Private Sub btn_alterar_Click(sender As Object, e As EventArgs)
        Try
            sqlQuery = "update tb_cadastrar_cliente set nome= '" & TXT_NOME.Text & "', emial= '" & TXTEMAIL.Text & "', where cpf= '" & TXT_CPF.Text & "'"
            tabela = banco_Dados.Execute(sqlQuery)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_Consultar_Click(sender As Object, e As EventArgs) Handles btn_Consultar.Click
        Form8.Show()
    End Sub

    Private Sub TXT_COMPLE_TextChanged(sender As Object, e As EventArgs) Handles TXT_COMPLE.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Form6.Show()
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
End Class