Module Module1

    Public banco_Dados As ADODB.Connection 'Variável do Banco de Dados
    Public tabela As ADODB.Recordset 'Variável da Tabela
    Public sqlQuery, resposta, aux As String 'Variável da Query
    Public cont As Integer

    Sub conectar_Banco()
        Try
            banco_Dados = CreateObject("ADODB.Connection")
            banco_Dados.Open("Provider=SQLOLEDB; Data Source=FAMILIA-PC; initial catalog=fofopet;trusted_connection=yes;")
            MsgBox("Conexão feita com Sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao conectar com o Banco de Dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Public Function Nome() As String

        Dim titulo As String = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        Return titulo
    End Function
    Sub carregar_tipo_produtos()
        Try
            With Form2.CMB_TIPO_PROD.Items
                .Add("Rações e Petiscos")
                .Add("Medicamentos Veterinários")
                .Add("Higiene")
                .Add("Camas")
                .Add("Roupinhas")
                .Add("Brinquedos")
                .Add("Acessórios Complementares")
                .Add("Acessórios para Passeios")
            End With
        Catch ex As Exception
            MsgBox("Erro ao Carregar Items", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_cargo()
        Try
            With Form4.CBM_CARGO.Items
                .Add("Vendedor")
                .Add("Recepcionista")
                .Add("Estocador")
                .Add("Estagiario")
                .Add("MotoBoy")
                .Add("Gerente")
            End With
        Catch ex As Exception

        End Try
    End Sub

    Sub carregar_dados()
        Try
            With Form8.dgv_dados_cliente
                sqlQuery = "select * from tb_cadastrar_cliente order by nome asc"
                tabela = banco_Dados.Execute(sqlQuery)
                .Rows.Clear()
                Do While tabela.EOF = False
                    .Rows.Add(tabela.Fields(0).Value, tabela.Fields(1).Value, tabela.Fields(2).Value, tabela.Fields(3).Value, tabela.Fields(4).Value, tabela.Fields(5).Value, tabela.Fields(6).Value, tabela.Fields(7).Value, tabela.Fields(8).Value, tabela.Fields(9).Value, Nothing, Nothing)
                    tabela.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao consultar Produtos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_consulta_dados()
        Try
            With Form7.dgv_dados_prod
                sqlQuery = "select * from tb_cadastrar_produto order by nome asc"
                tabela = banco_Dados.Execute(sqlQuery)
                .Rows.Clear()
                Do While tabela.EOF = False
                    .Rows.Add(tabela.Fields(0).Value, tabela.Fields(1).Value, tabela.Fields(2).Value, tabela.Fields(3).Value, tabela.Fields(4).Value, tabela.Fields(5).Value, tabela.Fields(6).Value, Nothing, Nothing)
                    tabela.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao consultar Produtos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_consulta_funcionario()
        Try
            With Form9.dgv_consultar_funcionario
                sqlQuery = "select * from tb_cadastrar_funcionario order by nome asc"
                tabela = banco_Dados.Execute(sqlQuery)
                .Rows.Clear()
                Do While tabela.EOF = False
                    .Rows.Add(tabela.Fields(0).Value, tabela.Fields(1).Value, tabela.Fields(2).Value, tabela.Fields(3).Value, tabela.Fields(4).Value, Nothing, Nothing)
                    tabela.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao consultar conta dos funcionários", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_Busca_Cliente()
        Try
            With Form8.CMB_TIPO_CLIENTE.Items
                .Add("CPF")
                .Add("NOME")
            End With
            Form8.CMB_TIPO_CLIENTE.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao Carregar Itens", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_Busca_Prod()
        Try
            With Form7.CMB_TIPO.Items
                .Add("CODIGO")
                .Add("NOME")
                .Add("TIPO_PRODUTO")
            End With
            Form7.CMB_TIPO.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao Carregar Busca", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_Busca_funcionario()
        Try
            With Form9.CMB_TIPO_FUNCIONARIO.Items
                .Add("CPF")
                .Add("NOME")
                .Add("CARGO")
            End With
            Form9.CMB_TIPO_FUNCIONARIO.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao Carregar Busca do Funcionário", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Sub limparTela_CadastroCliente()
        With form1
            .TXT_CPF.Clear()
            .TXT_NOME.Clear()
            .TXT_ENDERECO.Clear()
            .TXT_COMPLE.Clear()
            .TXT_BAIRRO.Clear()
            .TXT_CIDADE.Clear()
            .TXT_UF.Clear()
            .TXT_FONE.Clear()
            .TXT_CELU.Clear()
            .TXTEMAIL.Clear()
            .TXT_CPF.Focus()
        End With
    End Sub

    Sub limparTela_CadastroConta()
        With Form4
            .TXT_CPF_CADASTRAR.Clear()
            .TXT_NOME_CADASTRAR.Clear()
            .TXT_SENHA_CADASTRAR.Clear()
            .TXT_RSENHA_CADASTRAR.Clear()
            .CBM_CARGO = Nothing
            .TXT_CPF_CADASTRAR.Focus()
        End With
    End Sub

    Sub limparTela_Login()
        With Form3
            .TXT_CPF_LOGIN.Clear()
            .TXT_SENHA_LOGIN.Clear()
            .TXT_CPF_LOGIN.Focus()
        End With
    End Sub

    Sub limparTela_CadastrarProd()
        With Form2
            .TXT_COD.Clear()
            .TXT_NOME_PROD.Clear()
            .TXT_QUANT.Clear()
            .TXT_PRECO.Clear()
            .TXT_TAMANHO.Clear()
            .TXT_DETALHE.Clear()
        End With
    End Sub
End Module
