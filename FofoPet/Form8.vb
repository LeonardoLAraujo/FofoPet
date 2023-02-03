Public Class Form8

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_Banco()
        carregar_dados()
        carregar_Busca_Cliente()
    End Sub

    Private Sub TXT_BUSCA_TextChanged(sender As Object, e As EventArgs) Handles TXT_BUSCA_CLIENTE.TextChanged
        Try
            With dgv_dados_cliente
                sqlQuery = "select * from tb_cadastrar_cliente where " & CMB_TIPO_CLIENTE.Text & " like '" & TXT_BUSCA_CLIENTE.Text & "%'"
                tabela = banco_Dados.Execute(sqlQuery)
                .Rows.Clear()
                Do While tabela.EOF = False
                    .Rows.Add(tabela.Fields(0).Value, tabela.Fields(1).Value, tabela.Fields(2).Value, tabela.Fields(3).Value, tabela.Fields(4).Value, tabela.Fields(5).Value, tabela.Fields(6).Value, tabela.Fields(7).Value, tabela.Fields(8).Value, tabela.Fields(9).Value, Nothing, Nothing)
                    tabela.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub dgv_dados_cliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados_cliente.CellContentClick
        Try
            With dgv_dados_cliente
                If .CurrentRow.Cells(11).Selected = True Then
                    aux = .CurrentRow.Cells(0).Value
                    resposta = MsgBox("Deseja excluir o Cliente do " + vbNewLine & _
                                       "CPF: " & aux & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resposta = MsgBoxResult.Yes Then
                        sqlQuery = "delete from tb_cadastrar_cliente where cpf='" & aux & "'"
                        tabela = banco_Dados.Execute(sqlQuery)
                        MsgBox("CPF excluido com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        carregar_dados()
                    End If
                ElseIf .CurrentRow.Cells(10).Selected = True Then
                    aux = .CurrentRow.Cells(0).Value
                    sqlQuery = "select * from tb_cadastrar_cliente where cpf='" & aux & "'"
                    tabela = banco_Dados.Execute(sqlQuery)
                    If tabela.EOF = False Then
                        form1.TXT_CPF.Text = tabela.Fields(0).Value
                        form1.TXT_NOME.Text = tabela.Fields(1).Value
                        form1.TXT_ENDERECO.Text = tabela.Fields(2).Value
                        form1.TXT_COMPLE.Text = tabela.Fields(3).Value
                        form1.TXT_BAIRRO.Text = tabela.Fields(4).Value
                        form1.TXT_CIDADE.Text = tabela.Fields(5).Value
                        form1.TXT_UF.Text = tabela.Fields(6).Value
                        form1.TXT_FONE.Text = tabela.Fields(7).Value
                        form1.TXT_CELU.Text = tabela.Fields(8).Value
                        form1.TXTEMAIL.Text = tabela.Fields(9).Value
                        form1.Show()
                        carregar_dados()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao excluir Produto", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

End Class