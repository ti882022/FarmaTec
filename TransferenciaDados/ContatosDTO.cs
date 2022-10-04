﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using AcessoBanco;

namespace TransferenciaDados
{
    public class ContatosDTO
    {
        // Declaração dos atributos
        public int codigo { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public string uf { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string mensagens { get; set; }

    }

    public class ForncedoresDTO
    {
        // Declaração dos atributos
        public int codigo { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string cep { get; set; }
        public string cnpj { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string mensagens { get; set; }
    }

    public class ClassesDTO
    {
        // Declaração dos atributos
        public int classe { get; set; }
        public string descricao { get; set; }
        public string mensagens { get; set; }

    }

    




    public class ConsultarContatos

    {
        //Container para dados
        public DataTable ContatosDataTable;

        public void MostrarClasse(ClassesDTO dados)
        {
            //Definir o tipo de comandos SQL
            try
            {
                string sql = "Select * from tbclasseusuario order by descricao asc";
                //Interação de dados
                MySqlDataAdapter ContatosDataAdapter = new MySqlDataAdapter(sql, Conexao.obterConexao());
                //Instanciar objeto
                ContatosDataTable = new DataTable();
                //Popular o DataTable
                ContatosDataAdapter.Fill(ContatosDataTable);

                Conexao.fecharConexao();
            }
            catch (MySqlException e)
            {
                dados.mensagens = "Erro - ConsultarClasse - Mostrarclasse" + e.Message.ToString();
            }
        }
    }

    public class SalvarContatos
    {
        public void ClientesIncluir(ContatosDTO dados)
        {
            try
            {
                //Definir o tipo de comandos do SQL
                //chamando a Stored Procedure de inclusão de dados
                MySqlCommand cmd = new MySqlCommand("spInserirClientes", Conexao.obterConexao());
                cmd.CommandType = CommandType.StoredProcedure;

                //Popular os parâmetros da procedure
                
                cmd.Parameters.AddWithValue("@pnome", dados.nome);
                cmd.Parameters.AddWithValue("@pendereco", dados.endereco);
                cmd.Parameters.AddWithValue("@pcep", dados.cep);
                cmd.Parameters.AddWithValue("@pcidade", dados.cidade);
                cmd.Parameters.AddWithValue("@pbairro", dados.bairro);  
                cmd.Parameters.AddWithValue("@puf", dados.uf);
                cmd.Parameters.AddWithValue("@pcpf", dados.cpf);
                cmd.Parameters.AddWithValue("@pfone", dados.telefone);
                cmd.Parameters.AddWithValue("@pemail", dados.email);

                //Executar os comandos SQL
                MySqlDataReader dr = cmd.ExecuteReader();

                //Verificar a existência de registros

                if (dr.HasRows)
                {
                    //Percorre os registros se tiver linhas
                    while (dr.Read())
                    {
                        //Converter int para string
                        dados.codigo = Convert.ToInt32(dr.GetValue(0).ToString());
                    }
                }

                dr.Close();

                Conexao.fecharConexao();

            }
            catch (MySqlException e)
            {
                dados.mensagens = "ERRO - SalvarContatos - ClientesIncluir -" + e.Message.ToString();
            }

        } //Fechamento clientes Incluir

        public void FornecedoresIncluir(ForncedoresDTO dados)
        {
            try
            {
                //Definir o tipo de comandos do SQL
                //chamando a Stored Procedure de inclusão de dados
                MySqlCommand cmd = new MySqlCommand("spInserirFornecedores", Conexao.obterConexao());
                cmd.CommandType = CommandType.StoredProcedure;

                //Popular os parâmetros da procedure
                cmd.Parameters.AddWithValue("@pnome", dados.nome);
                cmd.Parameters.AddWithValue("@pendereco", dados.endereco + "," + dados.numero);
                cmd.Parameters.AddWithValue("@pbairro", dados.bairro);
                cmd.Parameters.AddWithValue("@pcidade", dados.cidade);
                cmd.Parameters.AddWithValue("@puf", dados.uf);
                cmd.Parameters.AddWithValue("@pcep", dados.cep);
                cmd.Parameters.AddWithValue("@pcnpj", dados.cnpj);
                cmd.Parameters.AddWithValue("@pfone", dados.telefone);
                cmd.Parameters.AddWithValue("@pemail", dados.email);

                //Executar os comandos SQL
                MySqlDataReader dr = cmd.ExecuteReader();

                //Verificar a existência de registros

                if (dr.HasRows)
                {
                    //Percorre os registros se tiver linhas
                    while (dr.Read())
                    {
                        //Converter int para string
                        dados.codigo = Convert.ToInt32(dr.GetValue(0).ToString());
                    }
                }

                dr.Close();

                Conexao.fecharConexao();

            }
            catch (MySqlException e)
            {
                dados.mensagens = "ERRO - SalvarContatos - FornecedoresIncluir -" + e.Message.ToString();
            }

        } //Fechamento Fornecedores Incluir

    } 
}
