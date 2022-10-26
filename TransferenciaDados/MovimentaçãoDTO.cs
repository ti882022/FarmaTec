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
    public class MovimentaçãoDTO
    {
        public int qtdeMvto { get; set; }
        public int txtstatus { get; set; }

        public int codProduto { get; set; }

        public string descricao { get; set; }

        public string mensagens { get; set; }
    }

    public class Listmovimento
    {
        public Listmovimento() { }

        public int qtdeMvto { get; set; }
        public int txtstatus { get; set; }

        public int codProduto { get; set; }

        public string descricao { get; set; }




        public Listmovimento(int qtdeMvto, int txtstatus, int codProduto, string descricao)
        {
            this.qtdeMvto = qtdeMvto;
            this.txtstatus = txtstatus;
            this.codProduto = codProduto;
            this.descricao = descricao;
        }


    }



    public class SalvarMovimento
    {
        public List<Listmovimento> listestoques = new List<Listmovimento>();


        public async Task Produtosmovimentar(MovimentaçãoDTO dados)
        {
            try
            {
                string URL = "http://10.38.45.24:8080/farmatec-api/produtos/movimentar/";

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(URL);

                var data = new Dictionary<string, string>
                {
                    {"txtstatus",Convert.ToInt32(dados.txtstatus).ToString()},
                    {"txtcodprod", Convert.ToInt32(dados.codProduto).ToString()},
                    {"txtqtde", Convert.ToInt32(dados.qtdeMvto).ToString()},
                    {"txtdesc", dados.descricao},
                    {"HTTP_ACCEPT", "application/Json"}
                };

                var response = await client.PostAsync(URL, new FormUrlEncodedContent(data));

                var result = await response.Content.ReadAsStringAsync();



                JObject obj = JObject.Parse(result);

                JArray arraymovimentar = (JArray)obj["RetornoDados"];

                foreach (var item in arraymovimentar)
                {
                    dados.qtdeMvto = Convert.ToInt32(item["codigo"].ToString());

                }

            }

            catch (JsonException e)
            {
                dados.mensagens = " ERRO - SalvarMovimento - Produtosmovimentar - \r\n " + e.Message.ToString();
            }

            catch (HttpRequestException ex)
            {
                dados.mensagens = " ERRO - SalvarMovimento - Produtosmovimentar - \r\n " + ex.Message.ToString();
            }

        }

    }




}
