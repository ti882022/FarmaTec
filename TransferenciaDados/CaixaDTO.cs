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
        public int codigo { get; set; }
        public string descricao  { get; set; }
        public DateTime dataPagamento { get; set; }
        public int canalPgto { get; set; }
        public int formaPgto { get; set; }
        public int nPedido { get; set; }
        public string nomeCliente { get; set; }

    }
    public class ListPedidos
    {
        public string nomeFunc { get; set; }
        public string usuarioFunc { get; set; }
        public string emailFunc { get; set; }
        public int cargoFunc { get; set; }
        public int statusFunc { get; set; }
        public string descricaoCargo { get; set; }
        public string mensagens { get; set; }

        public ListPedidos(string nome, string email, int classeUsuario, int logado, string descricao)
        {
            this.nomeFunc = nome;
            this.emailFunc = email;
            this.cargoFunc = classeUsuario;
            this.statusFunc = logado;
            this.descricaoCargo = descricao;
        }
    }





}
