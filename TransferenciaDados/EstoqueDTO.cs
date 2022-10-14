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
        public int codigo { get; set; }

        public string mensagens { get; set; }
    }

    public class Listestoque
    {
        public Listestoque() { }

        public int codMvto { get; set; }
        public string statusMvto { get; set; }
        public DateTime dataMvto { get; set; }
        public int codProduto { get; set; }
        public int qtdeMvto { get; set; }
        public string descricao { get; set; }


        public Listestoque(int codMvto, string statusMvto, DateTime dataMvto, int codProduto, int qtdeMvto, string descricao)
        {
            this.codMvto = codMvto;
            this.statusMvto = statusMvto;
            this.dataMvto = dataMvto;
            this.codProduto = codProduto;
            this.qtdeMvto = qtdeMvto;
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
                string URL = "http://localhost/siteturma88/produtos/movimentar/";

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(URL);

                var data = new Dictionary<string, string>
                {
                    {"txtcodprod", dados.codigo.ToString()},

                    {"HTTP_ACCEPT", "application/Json"}


            };

                var response = await client.PostAsync(URL, new FormUrlEncodedContent(data));

                var result = await response.Content.ReadAsStringAsync();

                JObject obj = JObject.Parse(result);

                JArray arraymovimentar = (JArray)obj["RetornoDados"];

                foreach (var item in arraymovimentar)
                {


                    listestoques.Add(new Listestoque(Convert.ToInt32(item["codMvto"].ToString()), item["statusMvto"].ToString(),
                                                                                                 Convert.ToDateTime(item["dataMvto"].ToString()),
                                                                                                Convert.ToInt32 (item["codProduto"].ToString()),
                                                                                                 Convert.ToInt32(item["qtdeMvto"].ToString()),
                                                                                                 item["descricao"].ToString()));
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
