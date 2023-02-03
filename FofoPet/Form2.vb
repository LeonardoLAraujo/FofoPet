
Public Class Form2

    Private Sub BTN_GRAVAR_Click(sender As Object, e As EventArgs) Handles BTN_GRAVAR.Click
        Try
            sqlQuery = "insert into tb_cadastrar_produto values ('" & TXT_COD.Text & "'," & _
                                                                "'" & TXT_NOME_PROD.Text & "'," & _
                                                                "'" & TXT_QUANT.Text & "'," & _
                                                                "'" & CMB_TIPO_PROD.Text & "'," & _
                                                                "'" & TXT_PRECO.Text & "'," & _
                                                                "'" & TXT_TAMANHO.Text & "'," & _
                                                                "'" & TXT_DETALHE.Text & "')"

            If Me.TXT_NOME_PROD.Text = String.Empty Or Me.CMB_TIPO_PROD.Text = String.Empty Or Me.TXT_PRECO.Text = String.Empty Or Me.TXT_TAMANHO.Text = String.Empty Then
                If Me.TXT_COD.Text = Nothing Or Me.TXT_QUANT.Text = Nothing Then
                    MsgBox("Campos estão Vazios!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                End If
                Exit Sub
            End If

            tabela = banco_Dados.Execute(UCase(sqlQuery))
            MsgBox("Dados Gravados com Sucesso!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            resposta = MsgBox("Deseja Gravar um novo Produto ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
            If resposta = vbYes Then
                limparTela_CadastrarProd()
            End If
        Catch ex As Exception
            MsgBox("Erro ao Gravar Dados!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub TXT_COD_DoubleClick(sender As Object, e As EventArgs) Handles TXT_COD.DoubleClick
        limparTela_CadastrarProd()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_Banco()
        carregar_tipo_produtos()
    End Sub

    Private Sub TXT_COD_LostFocus(sender As Object, e As EventArgs) Handles TXT_COD.LostFocus
        Try
            sqlQuery = "select * from tb_cadastrar_produto where codigo='" & TXT_COD.Text & "'"
            tabela = banco_Dados.Execute(sqlQuery)
            If tabela.EOF = False Then
                TXT_NOME_PROD.Text = tabela.Fields(1).Value
                TXT_QUANT.Text = tabela.Fields(2).Value
                CMB_TIPO_PROD.Text = tabela.Fields(3).Value
                TXT_PRECO.Text = tabela.Fields(4).Value
                TXT_TAMANHO.Text = tabela.Fields(5).Value
                TXT_DETALHE.Text = tabela.Fields(6).Value
            Else
                TXT_NOME_PROD.Focus()
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_Consultar_Click(sender As Object, e As EventArgs) Handles btn_Consultar.Click
        Form7.Show()
        Me.Visible = False
    End Sub

    Private Sub BTN_EXCLUIR_Click(sender As Object, e As EventArgs) Handles BTN_EXCLUIR.Click

        If Me.TXT_NOME_PROD.Text = String.Empty Or Me.CMB_TIPO_PROD.Text = String.Empty Or Me.TXT_PRECO.Text = String.Empty Or Me.TXT_TAMANHO.Text = String.Empty Then
            If Me.TXT_COD.Text = Nothing Or Me.TXT_QUANT.Text = Nothing Then
                MsgBox("Campos estão Vazios!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
            Exit Sub
        End If

        resposta = MsgBox("Deseja Apagar o Produto: " & TXT_NOME_PROD.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resposta = MsgBoxResult.Yes Then
            sqlQuery = "delete from tb_cadastrar_produto where codigo= '" & TXT_COD.Text & "'"
            tabela = banco_Dados.Execute(sqlQuery)
            MsgBox("Produto apagado com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            limparTela_CadastrarProd()

        End If
    End Sub
End Class