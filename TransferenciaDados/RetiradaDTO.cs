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
    class RetiradaDTO
    {
        // Declaração dos atributos
        public int nPedido { get; set; }
        public int codProduto { get; set; }
        public int qtde { get; set; }
        public decimal preco { get; set; }
        public string cpf { get; set; }
        
    }
}
