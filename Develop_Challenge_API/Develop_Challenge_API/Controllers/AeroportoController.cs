using Core.AspNetCoreWebApi;
using Core.Dominio.Mediador;
using Dominio.Comandos.Aeroporto;
using Dominio.Respostas.Aeroporto;
using Microsoft.AspNetCore.Mvc;

namespace Develop_Challenge_API.Controllers
{
    [ApiController]
    [Route("Aeroporto")]
    public class AeroportoController : ControllerApiBase
    {
        public AeroportoController(IMediadorDoDominio mediador) : base(mediador)
        {
        }

        /// <summary>
        /// Condições atuais no aeroporto
        /// </summary>
        /// <returns>Retorna condições meteorológicas atuais no aeroporto solicitado. Este endpoint utiliza o código ICAO (4 dígitos) do aeroporto.</returns>
        /// <response code="200">Retorna as condições meteorológicas</response>
        [HttpGet]
        [Route("ObterClimaAeroporto")]
        public async Task<ActionResult<RetornoPadraoDaApi<RespostaAeroporto?>>> ObterClimaAeroporto([FromQuery] ComandoObterClimaAeroporto comando)
        {
            var resposta = await _mediador.Comandos.Enviar(comando);
            return EnviarResposta(resposta);
        }

    }
}
