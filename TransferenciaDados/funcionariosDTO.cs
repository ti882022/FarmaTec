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
    public class funcionariosDTO
    {
        // Declaração dos atributos
        public int codigo { get; set; }
        public string nome { get; set; }
        public string usuario { get; set; }

        public string sexo { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public int cargo { get; set; }
        public string mensagens { get; set; }
    }
    public class SalvarFuncionario
    {
        /* public void FuncionariosIncluir(funcionariosDTO dados)
         {
             try
             {
                 //Definir o tipo de comandos do SQL
                 //chamando a Stored Procedure de inclusão de dados
                 MySqlCommand cmd = new MySqlCommand("spInserirFuncionarios", Conexao.obterConexao());
                 cmd.CommandType = CommandType.StoredProcedure;

                 //Popular os parâmetros da procedure

                 cmd.Parameters.AddWithValue("@pnome", dados.nome);
                 cmd.Parameters.AddWithValue("@pfone", dados.telefone);
                 cmd.Parameters.AddWithValue("@psexo", dados.sexo);
                 cmd.Parameters.AddWithValue("@pemail", dados.email);
                 cmd.Parameters.AddWithValue("@pcargo", dados.cargo);


                 //Executar os comandos SQL
                 MySqlDataReader dr = cmd.ExecuteReader();

                 //Verificar a existência de registros

                 if (dr.HasRows)
                 {
                     //Percorre os registros se tiver linhas
                     while (dr.Read())
                     {
                         //Converter int para string
                         dados.codigo = Convert.ToInt32(dr.GetValue(0).ToString());
                     }
                 }

                 dr.Close();

                 Conexao.fecharConexao();

             }
             catch (MySqlException e)
             {
                 dados.mensagens = "ERRO - SalvarFuncionarios - FuncionariosIncluir -" + e.Message.ToString();
             }


         }
        */

        public async Task FuncionariosIncluir(funcionariosDTO dados)
        {
            try
            {
                string URL = "http://localhost/siteturma88/funcionarios/incluir/";

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(URL);

                var data = new Dictionary<string, string>
                {
                    {"txtnomefuncionario", dados.nome},
                    {"txtusuario", dados.usuario},
                    {"txtsexo", dados.sexo},
                    {"txtfonefuncionario", dados.telefone },
                    {"txtemailfuncionario", dados.email },
                    {"txtclassefunc", dados.cargo.ToString()},
                    {"HTTP_ACCEPT", "application/Json" }
                };

                



                var response = await client.PostAsync(URL, new FormUrlEncodedContent(data));

                var result = await response.Content.ReadAsStringAsync();

                JObject obj = JObject.Parse(result);

                JArray arrayFuncionarios = (JArray)obj["RetornoDados"];

                foreach (var item in arrayFuncionarios)
                {
                    dados.codigo = Convert.ToInt32(item["codigo"].ToString());

                }
            }

            catch (JsonException e)
            {
                dados.mensagens = " ERRO - SalvarFuncionarios - FuncionariosIncluir - " + e.Message.ToString();
            }

        }
    }

}
