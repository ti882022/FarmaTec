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
    public class ClientesDTO
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string mensagens { get; set; }
    }

    public class ListClientes
    {
        public ListClientes() { }

        public int codCliente { get; set; }
        public string nomeCliente { get; set; }
        public string endereco { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public string uf { get; set; }
        public string cpf { get; set; }
        public string foneCliente { get; set; }
        public string emailCliente { get; set; }


        public ListClientes(int codCliente, string nomeCliente, string endereco, string cep, string cidade, string bairro, string uf, string cpf, string foneCliente, string emailCliente)
        {
            this.codCliente = codCliente;
            this.nomeCliente = nomeCliente;
            this.endereco = endereco;
            this.cep = cep;
            this.cidade = cidade;
            this.bairro = bairro;
            this.uf = uf;
            this.cpf = cpf;
            this.foneCliente = foneCliente;
            this.emailCliente = emailCliente;
        }


    }

    public class ConsultarClientes
    {
        public List<ListClientes> listClientes = new List<ListClientes>();


        public async Task MostrarCliente(ClientesDTO dados)
        {

            try
            {
                string URL = "http://localhost/siteturma88/clientes/listar/";

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(URL);

                var data = new Dictionary<string, string>
                {
                    {"txtnomeCliente", dados.nome},
                    {"txtcpfCliente", dados.cpf},
                    {"HTTP_ACCEPT", "application/Json"}


            };

                var response = await client.PostAsync(URL, new FormUrlEncodedContent(data));

                var result = await response.Content.ReadAsStringAsync();
                
                JObject obj = JObject.Parse(result);



                JArray arrayClientes = (JArray)obj["RetornoDados"];

               

                foreach (var item in arrayClientes)
                {


                    listClientes.Add(new ListClientes(Convert.ToInt32(item["codCliente"].ToString()), item["nomeCliente"].ToString(),
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



            }

            catch (JsonException e)
            {
                dados.mensagens = " ERRO - ConsultarClientes  - MostrarCliente - " + e.Message.ToString();
            }

            catch (HttpRequestException ex)
            {
                dados.mensagens = " ERRO - ConsultarClientes  - MostrarCliente - " + ex.Message.ToString();
            }

        }

    }
}