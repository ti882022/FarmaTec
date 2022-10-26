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
    public class statussDTO
    {
        public int statusMvto { get; set; }
        public string descricao { get; set; }
        public string mensagens { get; set; }


    }

    

    public class Consultarstatus { 
        public DataTable statusDataTable;


        public void CarregarComboo(statussDTO dados)
        {
            try
            {
                string sql = "Select * from tbstatusmvto order by descricao asc";
                //Interação de dados
                MySqlDataAdapter statusDataAdapter = new MySqlDataAdapter(sql, Conexao.obterConexao());
                //Instanciar objeto
               statusDataTable = new DataTable();
                //Popular o DataTable
                statusDataAdapter.Fill(statusDataTable);

                Conexao.fecharConexao();
            }
            catch (JsonException e)
            {
                dados.mensagens = " ERRO - ConsultarCargo - CarregarCombo - " + e.Message.ToString();
            }
        }
    }

}
