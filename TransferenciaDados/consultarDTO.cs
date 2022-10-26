﻿using System;
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
    public class ConsultarDTO
    {
        public string usuario { get; set; }
        public string mensagens { get; set; }
    }

    public class ListConsultar
    {
        public string nomeFunc { get; set; }
        public string usuarioFunc { get; set; }
        public string emailFunc { get; set; }
        public int cargoFunc { get; set; }
        public int statusFunc { get; set; }
        public string descricaoCargo{ get; set; }
        public string mensagens { get; set; }

        public ListConsultar(string nome, string email, int classeUsuario, int logado, string descricao)
        {
            this.nomeFunc = nome;
            this.emailFunc = email;
            this.cargoFunc = classeUsuario;
            this.statusFunc = logado;
            this.descricaoCargo = descricao;
        }
    }
    public class ConsultarUsers
    {
        public List<ListConsultar> listusuarios = new List<ListConsultar>();


        public async Task MostrarUsuarios(ConsultarDTO dados)
        {

            try
            {
                string URL = "http://10.38.45.24:8080/farmatec-api/usuarios/listar/";

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(URL);

                var data = new Dictionary<string, string>
                {
                    {"txtusuario", dados.usuario},
                    {"HTTP_ACCEPT", "application/Json"}
                };

                var response = await client.PostAsync(URL, new FormUrlEncodedContent(data));

                var result = await response.Content.ReadAsStringAsync();

                JObject obj = JObject.Parse(result);



                JArray arrayUsuarios = (JArray)obj["RetornoDados"];



                foreach (var item in arrayUsuarios)
                {


                    listusuarios.Add(new ListConsultar(item["nome"].ToString(), 
                                                       item["email"].ToString(),
                                                       (Convert.ToInt32(item["classeUsuario"].ToString())),
                                                       (Convert.ToInt32(item["logado"].ToString())),
                                                        item["descricao"].ToString()));

                }



            }

            catch (JsonException e)
            {
                dados.mensagens = "Cliente não cadastrado.";
            }

            catch (HttpRequestException ex)
            {
                dados.mensagens = "Erro de Conexão: Contate o suporte - " + ex.Message.ToString();
            }




        }


        public async Task EditarCadastro(UsuariosDTO dados)
        {
            try
            {
                string URL = "http://10.38.45.24:8080/farmatec-api/usuarios/atualizar/";

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(URL);

                var data = new Dictionary<string, string>
                {
                    {"txtusuario", dados.usuario},
                    {"txtnome", dados.nome},
                    {"txtemail", dados.email},
                    {"txtclasse", Convert.ToInt32(dados.classeUsuario).ToString()},
                    {"txtlogado", Convert.ToInt32(dados.logado).ToString()},
                    {"HTTP_ACCEPT", "application/Json"}

                };

                var response = await client.PostAsync(URL, new FormUrlEncodedContent(data));

                var result = await response.Content.ReadAsStringAsync();



                JObject obj = JObject.Parse(result);

                JArray arrayUsuarios = (JArray)obj["RetornoDados"];

                foreach (var item in arrayUsuarios)
                {
                    dados.logado = Convert.ToInt32(item["logado"].ToString());
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
