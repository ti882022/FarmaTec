using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using AcessoBanco;


//Namespace para APi rest
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TransferenciaDados
{
   public class PagamentoDTO
    {
        public int formaPgto { get; set; }
        public string descricao { get; set; }
        public string mensagens { get; set; }

    }

    public class ConsultarPagamento
    {
        public DataTable PagamentoDataTable;


        public void CarregarCombo(PagamentoDTO dados)
        {
            try
            {
                string sql = "Select * from tbformapgto order by descricao asc";
                //Interação de dados
                MySqlDataAdapter PagamentoDataAdapter = new MySqlDataAdapter(sql, Conexao.obterConexao());
                //Instanciar objeto
                PagamentoDataTable = new DataTable();
                //Popular o DataTable
                PagamentoDataAdapter.Fill(PagamentoDataTable);

                Conexao.fecharConexao();
            }
            catch (JsonException e)
            {
                dados.mensagens = " ERRO - ConsultarPagamento - CarregarCombo - " + e.Message.ToString();
            }
        }
    }


}
