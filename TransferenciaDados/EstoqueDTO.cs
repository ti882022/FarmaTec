using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using AcessoBanco;

namespace TransferenciaDados
{
    public class EstoqueDTO
    {
        public int codigo { get; set; }

        public string descricao { get; set; }

        public int qtde { get; set; }

        public string status { get; set; }

        public string mensagens { get; set; }

    }

    public class EstoqueContatos
    {
        public DataTable EstoqueDataTable;
        public void MostrarEstoque(EstoqueDTO dados)
        {
            //Definir o tipo de comandos do SQL
            try
            {
                string sql = "Select * from tbestoque order by nomedocontato asc";
                //Interação de dados
                MySqlDataAdapter EstoqueDataAdapter = new MySqlDataAdapter(sql, Conexao.obterConexao());
                //Instanciar o objeto
                EstoqueDataTable = new DataTable();
                //Popular o DataTable
                EstoqueDataAdapter.Fill(EstoqueDataTable);

                Conexao.fecharConexao();
            }
            catch (MySqlException e)
            {
                dados.mensagens = "Erro - ConsultarEstoque - MostrarEstoque " + e.Message.ToString();
            }
        }

    }




}
