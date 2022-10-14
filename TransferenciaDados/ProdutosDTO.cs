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
    public class ProdutosDTO
    {
        // Declaração dos atributos
        public int codigo { get; set; }
        public string descricao { get; set; }
        public string marca { get; set; }
        public string fornecedor { get; set; }
        public int catProduto { get; set; }
        public string unidade { get; set; }
        public int estoqueMinimo { get; set; }
         public int preco { get; set; }
        public string imgproduto { get; set; }
        public string mensagens { get; set; }
    }
    public class SalvarProduto
    {


        public async Task ProdutosIncluir(ProdutosDTO dados)
        {
            try
            {
                string URL = "http://localhost/siteturma88/produtos/incluir/";

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(URL);

                var data = new Dictionary<string, string>
                {
                    {"txtdescricao", dados.descricao },
                    {"txtmarca", dados.marca },
                    {"txtfornecedor", dados.fornecedor },
                    {"txtcategoria", dados.catProduto.ToString()},
                    {"txtunidade", dados.unidade },
                    {"txtestoquemin", dados.estoqueMinimo.ToString()},
                    {"txtestoquemin", dados.preco.ToString()},

                    {"txtimagem", dados.imgproduto },
                                       {"HTTP_ACCEPT", "application/Json"}

                };

                var response = await client.PostAsync(URL, new FormUrlEncodedContent(data));

                var result = await response.Content.ReadAsStringAsync();



                JObject obj = JObject.Parse(result);

                JArray arrayProdutos = (JArray)obj["RetornoDados"];

                foreach (var item in arrayProdutos)
                {
                    dados.codigo = Convert.ToInt32(item["codigo"].ToString());

                }

            }

            catch (JsonException e)
            {
                dados.mensagens = " ERRO - SalvarProdutos - ProdutosIncluir - \r\n " + e.Message.ToString();
            }

            catch (HttpRequestException ex)
            {
                dados.mensagens = " ERRO - SalvarProdutos - ProdutosIncluir - \r\n " + ex.Message.ToString();
            }

        }
    }

    public class ListProdutos
    {
        public ListProdutos() { }
        public int codProduto { get; set; }
        public string descricao { get; set; }
        public string marca { get; set; }
        public string fornecedor { get; set; }
        public int catProduto { get; set; }
        public string unidade { get; set; }
        public int estoqueMinimo { get; set; }
        //   public string imgProduto



        public ListProdutos(int codProduto, string descricao, string marca, string fornecedor, int catProduto, string unidade, int estoqueMinimo)
        {
            this.codProduto = codProduto;
            this.descricao = descricao;
            this.marca = marca;
            this.fornecedor = fornecedor;
            this.catProduto = catProduto;
            this.unidade = unidade;
            this.estoqueMinimo = estoqueMinimo;

        }


    }


    public class ConsultarProdutos
    {
        public List<ListProdutos> listProdutos = new List<ListProdutos>();


        public async Task MostrarProduto(ProdutosDTO dados)
        {

            try
            {
                string URL = "http://localhost/siteturma88/produtos/listar/";

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(URL);

                var data = new Dictionary<string, string>
                {
                    {"txtdescricao", dados.descricao},
                    {"txtcodproduto", dados.codigo.ToString()},
                    {"HTTP_ACCEPT", "application/Json"}


            };

                var response = await client.PostAsync(URL, new FormUrlEncodedContent(data));

                var result = await response.Content.ReadAsStringAsync();

                JObject obj = JObject.Parse(result);



                JArray arrayProdutos = (JArray)obj["RetornoDados"];



                foreach (var item in arrayProdutos)
                {


                    listProdutos.Add(new ListProdutos(Convert.ToInt32(item["codProduto"].ToString()), item["descricao"].ToString(),
                                                                                                        item["marca"].ToString(),
                                                                                                        item["fornecedor"].ToString(),
                                                                                                        Convert.ToInt32(item["catProduto"].ToString()),
                                                                                                        item["unidade"].ToString(),
                                                                                                        Convert.ToInt32(item["estoqueMinimo"].ToString()))
                        );
                                                

                }

            }

            catch (JsonException e)
            {
                dados.mensagens = " ERRO - ConsultarProdutos  - MostrarProduto - " + e.Message.ToString();
            }

            catch (HttpRequestException ex)
            {
                dados.mensagens = " ERRO - ConsultarProdutos  - MostrarProduto - " + ex.Message.ToString();
            }

        }

    }



}