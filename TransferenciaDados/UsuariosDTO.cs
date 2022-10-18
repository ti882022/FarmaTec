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
  public class UsuariosDTO
    {
        public string nome { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public string email { get; set; }
        public int classeUsuario { get; set; }
        public int logado { get; set; }
       public string mensagens { get; set; }

    }

    public class UsuarioAutenticar
    {

     public async Task ValidarUsuario(UsuariosDTO dados)
        {
            try
            {
                string URL = "http://localhost/siteturma88/usuarios/conectar/";

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(URL);

                var data = new Dictionary<string, string>
                {
                    {"txtnomeusuario", dados.usuario },
                    {"txtsenhausuario", dados.senha },                                      
                    {"HTTP_ACCEPT", "application/Json"}

                };

                var response = await client.PostAsync(URL, new FormUrlEncodedContent(data));

                var result = await response.Content.ReadAsStringAsync();



                JObject obj = JObject.Parse(result);

                JArray arrayUsuarios = (JArray)obj["RetornoDados"];

                foreach (var item in arrayUsuarios)
                {
                    dados.logado = Convert.ToInt32(item["resultado"].ToString());

                }

            }

            catch (JsonException e)
            {
                dados.mensagens = " ERRO - UsuarioAutenticar - ValidarUsuario - \r\n " + e.Message.ToString();
            }

            catch (HttpRequestException ex)
            {
                dados.mensagens = " ERRO -  UsuarioAutenticar - ValidarUsuario - \r\n " + ex.Message.ToString();
            }

        }
    }

}
