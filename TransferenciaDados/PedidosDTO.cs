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
    public class PedidosDTO
    {
        // Declaração dos atributos
        public string nomeCliente { get; set; }
        public int canalPgto { get; set; }
        public int formaPgto { get; set; }
        public int codFuncionario { get; set; }
        public DateTime dataPgto { get; set; }
        public DateTime dataEnvio { get; set; }
        public string produto { get; set; } //Irá receber a descrição, quantidade e o preco convertidos em Json 
        public int nPedido { get; set; }
        public string mensagens { get; set; }


    }
    public class ListarPedidos
    {

        public ListarPedidos() { }

        //Terão que ser convertidos em um único Json e popular a string do produto.
        public int codProduto { get; set; }
        public decimal preco { get; set; }
        public int qtde { get; set; }


        public ListarPedidos(int codProduto, int qtde, decimal preco)
        {
            this.codProduto = codProduto;
            this.preco = preco;
            this.qtde = qtde;



        }
    }


    public class SalvarPedidos
    {
        public void InserirPedidos(PedidosDTO dados)
        {
            try
            {
                //Definir o tipo de comandos do SQL
                //chamando a Stored Procedure de inclusão de dados
                MySqlCommand cmd = new MySqlCommand("spInserirPedidos", Conexao.obterConexao());
                cmd.CommandType = CommandType.StoredProcedure;

                //Popular os parâmetros da entrada(Input)
                cmd.Parameters.AddWithValue("@pnomecliente", dados.nomeCliente);
                cmd.Parameters.AddWithValue("@pcanal", dados.canalPgto);
                cmd.Parameters.AddWithValue("@pforma", dados.formaPgto);
                cmd.Parameters.AddWithValue("@pcodigofuncionario", dados.codFuncionario);
                cmd.Parameters.AddWithValue("@pdpgto", dados.dataPgto);
                cmd.Parameters.AddWithValue("@pdenvio", dados.dataEnvio);
                cmd.Parameters.AddWithValue("@pproduto", dados.produto); // Ser transformado em json 


                //Parametros de saída (Output)
                cmd.Parameters.Add(new MySqlParameter("pnumeropedido", MySqlDbType.Int32));
                cmd.Parameters["pnumeropedido"].Direction = ParameterDirection.Output;



                //Executar os comandos SQL
                int resultado = cmd.ExecuteNonQuery();


                //Popular resultado 
                dados.nPedido = Convert.ToInt32(cmd.Parameters["pnumeropedido"].Value.ToString());



                Conexao.fecharConexao();

            }
            catch (MySqlException e)
            {
                dados.mensagens = "ERRO - SalvarPedidos - InserirPedidos -" + e.Message.ToString();
            }

            catch (JsonException ex)
            {
                dados.mensagens = " ERRO - SalvarPedidos - InserirPedidos - \r\n " + ex.Message.ToString();
            }


        }

    }




}
