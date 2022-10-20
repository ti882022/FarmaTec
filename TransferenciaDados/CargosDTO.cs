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

     public class CargosDTO
    {
        public int classeUsuario { get; set; }
        public string descricao { get; set; }
        public string mensagens { get; set; }


    }

    public class SalvarCargo
    {

    }

    public class ConsultarCargo
    {
        public DataTable CargosDataTable;


        public void CarregarCombo(CargosDTO dados)
        {
            try 
            {
                string sql = "Select * from tbclasseusuario order by descricao asc";
                //Interação de dados
                MySqlDataAdapter CargosDataAdapter = new MySqlDataAdapter(sql, Conexao.obterConexao());
                //Instanciar objeto
                CargosDataTable = new DataTable();
                //Popular o DataTable
                CargosDataAdapter.Fill(CargosDataTable);

                Conexao.fecharConexao();
            }
            catch (JsonException e)
            {
                dados.mensagens = " ERRO - ConsultarCargo - CarregarCombo - " + e.Message.ToString();
            }
        }
    }

}
