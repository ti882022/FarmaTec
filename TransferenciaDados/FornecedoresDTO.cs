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
    public class FornecedoresDTO
    {
        // Declaração dos atributos
        public int codigo { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string cep { get; set; }
        public string cnpj { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string mensagens { get; set; }

    }

    public class SalvarFornecedores
    {


        public async Task FornecedoresIncluir(FornecedoresDTO dados)
        {
            try
            {
                string URL = "http://10.38.45.24:8080/farmatec-api/fornecedores/incluir/";

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(URL);

                var data = new Dictionary<string, string>
                {
                    {"txtnomeFornecedor", dados.nome},
                    {"txtendereco", dados.endereco + dados.numero.ToString()},
                    {"txtcep", dados.cep },
                    {"txtcidade", dados.cidade },
                    {"txtbairro", dados.bairro},
                    {"txtuf", dados.uf},
                    {"txtcnpj", dados.cnpj},
                    {"txtfoneFornecedor", dados.telefone},
                    {"txtemailFornecedor", dados.email},
                    {"HTTP_ACCEPT", "application/Json" }
                };





                var response = await client.PostAsync(URL, new FormUrlEncodedContent(data));

                var result = await response.Content.ReadAsStringAsync();

                JObject obj = JObject.Parse(result);

                JArray arrayFornecedores = (JArray)obj["RetornoDados"];

                foreach (var item in arrayFornecedores)
                {
                    dados.codigo = Convert.ToInt32(item["codigo"].ToString());

                }
            }

            catch (JsonException e)
            {
                dados.mensagens = " ERRO - SalvarFornecedores - FornecedoresIncluir - " + e.Message.ToString();
            }

        }
    }




}
