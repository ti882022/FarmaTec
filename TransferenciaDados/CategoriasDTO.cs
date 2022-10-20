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
   public class CategoriasDTO
    {
        public int catProduto { get; set; }
        public string categoria { get; set; }
        public string mensagens { get; set; }
    }

    public class ConsultarCategoria
    {
        public DataTable CategoriasDataTable;


        public void ListarCombo(CategoriasDTO dados)
        {
            try
            {
                string sql = "SELECT * FROM `tbcatprodutos` ORDER BY categoria ASC";
                //Interação de dados
                MySqlDataAdapter CategoriaDataAdapter = new MySqlDataAdapter(sql, Conexao.obterConexao());
                //Instanciar objeto
                CategoriasDataTable = new DataTable();
                //Popular o DataTable
                CategoriaDataAdapter.Fill(CategoriasDataTable);

                Conexao.fecharConexao();
            }
            catch (JsonException e)
            {
                dados.mensagens = " ERRO - ConsultarCategoria - ListarCombo - " + e.Message.ToString();
            }
        }
    }



}
