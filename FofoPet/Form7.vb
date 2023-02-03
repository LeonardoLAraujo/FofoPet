Public Class Form7

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_Banco()
        carregar_consulta_dados()
        carregar_Busca_Prod()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados_prod.CellContentClick
        Try
            With dgv_dados_prod
                If .CurrentRow.Cells(8).Selected = True Then
                    aux = .CurrentRow.Cells(0).Value
                    resposta = MsgBox("Deseja excluir o Produto " + vbNewLine & _
                                       "Codigo: " & aux & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resposta = MsgBoxResult.Yes Then
                        sqlQuery = "delete from tb_cadastrar_produto where codigo='" & aux & "'"
                        tabela = banco_Dados.Execute(sqlQuery)
                        MsgBox("Produto excluido com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        carregar_consulta_dados()
                    End If
                ElseIf .CurrentRow.Cells(7).Selected = True Then
                    aux = .CurrentRow.Cells(0).Value
                    sqlQuery = "select * from tb_cadastrar_produto where codigo='" & aux & "'"
                    tabela = banco_Dados.Execute(sqlQuery)
                    If tabela.EOF = False Then
                        Form2.TXT_COD.Text = tabela.Fields(0).Value
                        Form2.TXT_NOME_PROD.Text = tabela.Fields(1).Value
                        Form2.TXT_QUANT.Text = tabela.Fields(2).Value
                        Form2.CMB_TIPO_PROD.Text = tabela.Fields(3).Value
                        Form2.TXT_PRECO.Text = tabela.Fields(4).Value
                        Form2.TXT_TAMANHO.Text = tabela.Fields(5).Value
                        Form2.TXT_DETALHE.Text = tabela.Fields(6).Value
                        Form2.Show()
                        carregar_consulta_dados()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao excluir Produto", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub TXT_BUSCA_TextChanged(sender As Object, e As EventArgs) Handles TXT_BUSCA.TextChanged
        Try
            With dgv_dados_prod
                cont = 1
                sqlQuery = "select * from tb_cadastrar_produto where " & CMB_TIPO.Text & " like '" & TXT_BUSCA.Text & "%'"
                tabela = banco_Dados.Execute(sqlQuery)
                .Rows.Clear()
                Do While tabela.EOF = False
                    .Rows.Add(tabela.Fields(0).Value, tabela.Fields(1).Value, tabela.Fields(2).Value, tabela.Fields(3).Value, tabela.Fields(4).Value, tabela.Fields(5).Value, tabela.Fields(6).Value, Nothing, Nothing)
                    cont = cont + 1
                    tabela.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub TXT_BUSCA_Click(sender As Object, e As EventArgs) Handles TXT_BUSCA.Click

    End Sub


    Private Sub ToolStripProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class