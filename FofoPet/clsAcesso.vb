Imports System.Data.SqlClient
Imports FofoPet.clsConexao
Public Class clsAcesso

    Public Shared Function AcessoLogin(ByVal Usuario As String, ByVal Senha As String) As Boolean
        Dim sql As String = "Select CPF, SENHA from tb_cadastrar_funcionario Where CPF = '" & Usuario & "' And senha = '" & Senha & "'"
        Dim dtr As SqlDataReader = Nothing
        Dim cn As SqlConnection = clsConexao.GetConection()
        Dim cmd As SqlCommand = New SqlCommand(sql, cn)
        dtr = cmd.ExecuteReader
        Dim valida As Boolean = False
        Try
            If dtr.HasRows Then
                valida = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return valida
    End Function


End Class
