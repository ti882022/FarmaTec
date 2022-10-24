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
        public string senhaNova { get; set; }
        public string email { get; set; }
        public int classeUsuario { get; set; }
        public int logado { get; set; }
        public string mensagens { get; set; }

    }
    public class LoginSistema
    {
        public static string nomeUsuario { get; set; }
        public static string emailUsuario { get; set; }
        public static int classe { get; set; }
    }



    public class UsuarioAutenticar
    {

        public async Task ValidarUsuario(UsuariosDTO dados)
        {
            try
            {
                string URL = "http://10.38.45.24:8080/farmatec-api/usuarios/conectar/";

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(URL);

                var data = new Dictionary<string, string>
                {
                    {"txtusuario", dados.usuario },
                    {"txtsenha", dados.senha },
                    {"HTTP_ACCEPT", "application/Json"}

                };

                var response = await client.PostAsync(URL, new FormUrlEncodedContent(data));

                var result = await response.Content.ReadAsStringAsync();



                JObject obj = JObject.Parse(result);

                JArray arrayUsuarios = (JArray)obj["RetornoDados"];

                foreach (var item in arrayUsuarios)
                {

                    dados.logado = Convert.ToInt32(item["plogado"].ToString());
                   
                    LoginSistema.emailUsuario = item["pemail"].ToString();
                    LoginSistema.nomeUsuario = item["pnome"].ToString();
                    LoginSistema.classe = Convert.ToInt32(item["pcargo"].ToString());
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

        public async Task AlterarSenha(UsuariosDTO dados)
        {
            try
            {
                string URL = "http://10.38.45.24:8080/farmatec-api/usuarios/trocar/";

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(URL);

                var data = new Dictionary<string, string>
                {
                    {"txtnome", dados.nome },
                    {"txtemail", dados.email },
                    {"txtsenha", dados.senha },
                    {"txtsenhanova", dados.senhaNova },
                    {"HTTP_ACCEPT", "application/Json"}

                };

                var response = await client.PostAsync(URL, new FormUrlEncodedContent(data));

                var result = await response.Content.ReadAsStringAsync();



                JObject obj = JObject.Parse(result);

                JArray arrayUsuarios = (JArray)obj["RetornoDados"];

                foreach (var item in arrayUsuarios)
                {
                    dados.logado = Convert.ToInt32(item["plogado"].ToString());
                }

            }

            catch (JsonException e)
            {
                dados.mensagens = " ERRO - UsuarioAutenticar - AlterarSenha - \r\n " + e.Message.ToString();
            }

            catch (HttpRequestException ex)
            {
                dados.mensagens = " ERRO -  UsuarioAutenticar - AlterarSenha - \r\n " + ex.Message.ToString();
            }

        }

        public async Task DesconectarUsuario(UsuariosDTO dados)
        {
            try
            {
                string URL = "http://10.38.45.24:8080/farmatec-api/usuarios/desconectar/";

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(URL);

                var data = new Dictionary<string, string>
                {
                    {"txtnome", dados.nome },
                    {"txtemail", dados.email },
                   
                    {"HTTP_ACCEPT", "application/Json"}

                };

                var response = await client.PostAsync(URL, new FormUrlEncodedContent(data));

                var result = await response.Content.ReadAsStringAsync();



                JObject obj = JObject.Parse(result);

                JArray arrayUsuarios = (JArray)obj["RetornoDados"];

                foreach (var item in arrayUsuarios)
                {
                    dados.logado = Convert.ToInt32(item["plogado"].ToString());
                }

            }

            catch (JsonException e)
            {
                dados.mensagens = " ERRO - UsuarioAutenticar - DesconectarUsuario - \r\n " + e.Message.ToString();
            }

            catch (HttpRequestException ex)
            {
                dados.mensagens = " ERRO -  UsuarioAutenticar - DesconectarUsuario - \r\n " + ex.Message.ToString();
            }

        }

    }

}
