using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using AcessoBanco;

using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TransferenciaDados
{
    public class EstoqueDTO
    {
        public int codProduto { get; set; }
        public string descricao { get; set; }

        public string mensagens { get; set; }
    }

    public class Listestoque
    {
        public Listestoque() { }

        public int codProduto { get; set; }
        public string descricao { get; set; }


        public Listestoque(int codProduto, string descricao)
        {
            this.codProduto = codProduto;
            this.descricao = descricao;

        }


    }



    public class ConsultarEstoque
    {
        public List<Listestoque> listestoques = new List<Listestoque>();


        public async Task MostrarEstoque(EstoqueDTO dados)
        {

            try
            {
                string URL = "http://10.38.45.24:8080/farmatec-api/produtos/listarcod/";

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(URL);

                var data = new Dictionary<string, string>
                {
                    {"txtcodprod", dados.codProduto.ToString()},
                    {"txtdescricao", dados.descricao},

                    {"HTTP_ACCEPT", "application/Json"}


            };

                var response = await client.PostAsync(URL, new FormUrlEncodedContent(data));

                var result = await response.Content.ReadAsStringAsync();

                JObject obj = JObject.Parse(result);

                JArray arraylistarcod = (JArray)obj["RetornoDados"];

                foreach (var item in arraylistarcod)
                {


                    listestoques.Add(new Listestoque(Convert.ToInt32(item["codProduto"].ToString()), item["descricao"].ToString())
                        );
                }



            }

            catch (JsonException e)
            {
                dados.mensagens = " ERRO - ConsultarEstoque  - MostrarEstoque - " + e.Message.ToString();
            }

            catch (HttpRequestException ex)
            {
                dados.mensagens = " ERRO - ConsultarEstoque  - MostrarEstoque - " + ex.Message.ToString();
            }

        }

    }




}
