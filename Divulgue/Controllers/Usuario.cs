using Divulgue.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Divulgue.Controllers
{
    /// <summary>
    /// Usuario
    /// </summary>
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/Usuario")]
    public class Usuario
    {
        /// <summary>
        /// Manter usuario
        /// </summary>        
        /// <param name="requisicao"></param>
        /// <returns>RespostaAPI</returns>
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("Usuario/Manter")]
        public RespostaAPI ManterUsuario(RequisicaoAPI requisicao)
        {
            RespostaAPI resposta = new RespostaAPI();
            try
            {
                Usuario usuario = ((JObject)requisicao.Objeto).ToObject<Usuario>();

            }
            catch (Exception e)
            {
                resposta.Erro = true;
                resposta.Mensagem = e.Message;
            }

            return resposta;
        }
    }
}