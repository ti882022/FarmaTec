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

    public class ListPedidos
    {
        public ListPedidos() { }

        public int codProduto { get; set; }
        public string descricao { get; set; }
        public int qtde { get; set; }
        public int preco { get; set; }
       

        public ListPedidos(int codProduto, string descricao, int qtde, int preco, string cidade, string bairro, string uf, string cpf, string foneCliente, string emailCliente)
        {
            this.codProduto = codProduto;
            this.descricao = descricao;
            this.qtde = qtde;
            this.preco = preco;
            
        }


    }


    public class ConsultarPedido
    {
        public List<ListPedidos> listPedidos = new List<ListPedidos>();


        public async Task MostrarCliente(RetiradaDTO dados)
        {

            try
            {
                string URL = "http://10.38.45.24:8080/farmatec-api/pedidos/listar/";

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(URL);

                var data = new Dictionary<string, string>
                {
                    
                    {"txtnumpedido", dados.cpf},
                    {"txtcpf", dados.cpf},
                    {"HTTP_ACCEPT", "application/Json"}


                };

                var response = await client.PostAsync(URL, new FormUrlEncodedContent(data));

                var result = await response.Content.ReadAsStringAsync();

                JObject obj = JObject.Parse(result);



                JArray arrayPedidos = (JArray)obj["RetornoDados"];


    /*
                foreach (var item in arrayPedidos)
                {


                    ListPedidos.add(new ListClientes(Convert.ToInt32(item["codCliente"].ToString()), item["nomeCliente"].ToString(),
                                                                                                        item["endereco"].ToString(),
                                                                                                        item["cep"].ToString(),
                                                                                                        item["cidade"].ToString(),
                                                                                                        item["bairro"].ToString(),
                                                                                                        item["uf"].ToString(),
                                                                                                        item["cpf"].ToString(),
                                                                                                        item["foneCliente"].ToString(),
                                                                                                        item["emailCliente"].ToString())
                                                );

                }

                */


            }

            catch (JsonException e)
            {
                dados.mensagens = "Pedido não encontrado";
            }

            catch (HttpRequestException ex)
            {
                dados.mensagens = "Erro de Conexão: Contate o suporte - " + ex.Message.ToString();
            }

        }

    }






}
