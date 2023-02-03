Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_Banco()
        carregar_cargo()
    End Sub
    Private Sub TXT_CPF_CADASTRAR_DoubleClick(sender As Object, e As EventArgs) Handles TXT_CPF_CADASTRAR.DoubleClick
        limparTela_CadastroCliente()
    End Sub


    Private Sub BTN_CADASTRAR_CONTA_Click(sender As Object, e As EventArgs) Handles BTN_CADASTRAR_CONTA.Click
        Try
            sqlQuery = "insert into tb_cadastrar_funcionario values ('" & TXT_CPF_CADASTRAR.Text & "'," & _
                                                              "'" & TXT_NOME_CADASTRAR.Text & "'," & _
                                                              "'" & TXT_SENHA_CADASTRAR.Text & "'," & _
                                                              "'" & TXT_RSENHA_CADASTRAR.Text & "'," & _
                                                              "'" & CBM_CARGO.Text & "')"

            If Me.TXT_CPF_CADASTRAR.Text = String.Empty Or Me.TXT_NOME_CADASTRAR.Text = String.Empty Or Me.TXT_SENHA_CADASTRAR.Text = String.Empty Or Me.TXT_RSENHA_CADASTRAR.Text = String.Empty Or Me.CBM_CARGO.Text = String.Empty Then
                MsgBox("Campos estão Vazios!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End If

                If TXT_SENHA_CADASTRAR.Text = TXT_RSENHA_CADASTRAR.Text Then
                    tabela = banco_Dados.Execute(UCase(sqlQuery))
                    MsgBox("Conta Criada com Sucesso!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    resposta = MsgBox("Deseja Criar outra conta ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
                    If resposta = vbYes Then
                    Me.Visible = False
                    Me.Visible = True
                    limparTela_CadastroConta()
                    End If
                Else
                    MsgBox("As senhas não são iguais!!", MsgBoxStyle.Critical + vbOKOnly)
                End If
        Catch ex As Exception
            MsgBox("Erro ao criar um Conta!!", MsgBoxStyle.Critical + vbOKOnly, "AVISO")
        End Try
    End Sub

    Private Sub BNT_CONSULTAR_CONTAS_Click(sender As Object, e As EventArgs) Handles BNT_CONSULTAR_CONTAS.Click
        Form9.Show()
    End Sub

    Private Sub TXT_CPF_CADASTRAR_LostFocus(sender As Object, e As EventArgs) Handles TXT_CPF_CADASTRAR.LostFocus
        Try
            sqlQuery = "select * from tb_cadastrar_funcionario where cpf='" & TXT_CPF_CADASTRAR.Text & "'"
            tabela = banco_Dados.Execute(sqlQuery)
            If tabela.EOF = False Then
                TXT_NOME_CADASTRAR.Text = tabela.Fields(1).Value
                TXT_SENHA_CADASTRAR.Text = tabela.Fields(2).Value
                TXT_RSENHA_CADASTRAR.Text = tabela.Fields(3).Value
                CBM_CARGO.Text = tabela.Fields(4).Value
            Else
                TXT_NOME_CADASTRAR.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro ao Carregar informações do Cliente!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Me.TXT_CPF_CADASTRAR.Text = String.Empty Or Me.TXT_NOME_CADASTRAR.Text = String.Empty Or Me.TXT_SENHA_CADASTRAR.Text = String.Empty Or Me.TXT_RSENHA_CADASTRAR.Text = String.Empty Or Me.CBM_CARGO.Text = String.Empty Then
            MsgBox("Campos estão Vazios!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End If

        resposta = MsgBox("Deseja excluir o Funcionário: '" & TXT_NOME_CADASTRAR.Text & "?'", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")
        If resposta = MsgBoxResult.Yes Then
            sqlQuery = "delete from tb_cadastrar_funcionario where cpf= '" & TXT_CPF_CADASTRAR.Text & "'"
            tabela = banco_Dados.Execute(sqlQuery)
            MsgBox("Funcionário excluido com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            limparTela_CadastroConta()
        End If
    End Sub
End Class