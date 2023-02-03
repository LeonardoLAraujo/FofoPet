Public Class Form9
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_Banco()
        carregar_consulta_funcionario()
        carregar_Busca_funcionario()
    End Sub

    Private Sub dgv_consultar_funcionario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_consultar_funcionario.CellContentClick
        Try
            With dgv_consultar_funcionario
                If .CurrentRow.Cells(6).Selected = True Then
                    aux = .CurrentRow.Cells(0).Value
                    resposta = MsgBox("Deseja excluir o Funcionário com" + vbNewLine & _
                                       "CPF: " & aux & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resposta = MsgBoxResult.Yes Then
                        sqlQuery = "delete from tb_cadastrar_funcionario where cpf='" & aux & "'"
                        tabela = banco_Dados.Execute(sqlQuery)
                        MsgBox("Funcionário excluido com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        carregar_consulta_funcionario()
                    End If
                ElseIf .CurrentRow.Cells(5).Selected = True Then
                    aux = .CurrentRow.Cells(0).Value
                    sqlQuery = "select * from tb_cadastrar_funcionario where cpf='" & aux & "'"
                    tabela = banco_Dados.Execute(sqlQuery)
                    If tabela.EOF = False Then
                        Form4.TXT_CPF_CADASTRAR.Text = tabela.Fields(0).Value
                        Form4.TXT_NOME_CADASTRAR.Text = tabela.Fields(1).Value
                        Form4.TXT_SENHA_CADASTRAR.Text = tabela.Fields(2).Value
                        Form4.TXT_RSENHA_CADASTRAR.Text = tabela.Fields(3).Value
                        Form4.CBM_CARGO.Text = tabela.Fields(4).Value
                        Form4.Show()
                        Me.Visible = False
                        carregar_consulta_funcionario()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao excluir Funcionário", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    
    Private Sub TXT_BUSCA_TextChanged(sender As Object, e As EventArgs) Handles TXT_BUSCA_FUNCIONARIO.TextChanged
        Try
            With dgv_consultar_funcionario
                sqlQuery = "select * from tb_cadastrar_funcionario where " & CMB_TIPO_FUNCIONARIO.Text & " like '" & TXT_BUSCA_FUNCIONARIO.Text & "%'"
                tabela = banco_Dados.Execute(sqlQuery)
                .Rows.Clear()
                Do While tabela.EOF = False
                    .Rows.Add(tabela.Fields(0).Value, tabela.Fields(1).Value, tabela.Fields(2).Value, tabela.Fields(3).Value, tabela.Fields(4).Value, Nothing, Nothing)
                    tabela.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub CMB_TIPO_Click(sender As Object, e As EventArgs) Handles CMB_TIPO_FUNCIONARIO.Click

    End Sub

    Private Sub TXT_BUSCA_FUNCIONARIO_Click(sender As Object, e As EventArgs) Handles TXT_BUSCA_FUNCIONARIO.Click

    End Sub
End Class