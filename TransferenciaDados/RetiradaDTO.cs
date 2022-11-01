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
   public class RetiradaDTO
    {
        // Declaração dos atributos
        public int nPedido { get; set; }
        public int codProduto { get; set; }
        public int qtde { get; set; }
        public int formaPgto { get; set; }
        public decimal preco { get; set; }
        public string cpf { get; set; }
        public string mensagens { get; set; }

    }

    public class SalvarRetirada
    {
        public async Task RetirarPedidos(RetiradaDTO dados)
        {
         

            try
            {
                string URL = "http://10.38.45.24:8080/farmatec-api/pedidos/concluir/";

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(URL);

                var data = new Dictionary<string, string>
                {
                    {"txtnumpedido", dados.nPedido.ToString()},
                    {"txtcpf", dados.cpf},
                    {"txtforma", dados.formaPgto.ToString()},
                    {"HTTP_ACCEPT", "application/Json"}

                };

                var response = await client.PostAsync(URL, new FormUrlEncodedContent(data));

                var result = await response.Content.ReadAsStringAsync();



                JObject obj = JObject.Parse(result);

                JArray arrayRetirada = (JArray)obj["RetornoDados"];

                foreach (var item in arrayRetirada)
                {
                    dados.nPedido = Convert.ToInt32(item["numeropedido"].ToString());

                }

            }

            catch (JsonException e)
            {
                dados.mensagens = "ERRO - SalvarPedidos - InserirPedidos - \r\n " + e.Message.ToString();
            }

            catch (HttpRequestException ex)
            {
                dados.mensagens = " ERRO - SalvarPedidos - InserirPedidos - \r\n " + ex.Message.ToString();
            }


        }

    }






}
