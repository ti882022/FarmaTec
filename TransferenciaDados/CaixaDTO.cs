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
    public class CaixaDTO
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


    }
    public class ListPedidos
    {


        //Terão que ser convertidos em um único Json e popular a string do produto.
        public int codProduto { get; set; }
        public int qtde { get; set; }
        public decimal preco { get; set; }

        public ListPedidos(int codProduto, int qtde, decimal preco)
        {
            this.codProduto = codProduto;
            this.qtde = qtde;
            this.preco = preco;


        }
    }



}
