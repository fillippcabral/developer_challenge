using Core.Dominio.Comandos;
using Core.Dominio.Mediador;
using Dominio.Externo;
using Dominio.Respostas.Aeroporto;
using Infraestrutura.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Comandos.Aeroporto
{
    public class ManipuladorDeObterClimaAeroporto : ManipuladorDoComando<ComandoObterClimaAeroporto, RespostaAeroporto>
    {
        private readonly IMediadorDoDominio _mediadorDoDominio;
        private readonly IArmazenadorClimaAeroporto _armazenadorClimaAeroporto;
        private readonly IArmazenadorLogErro _armazenadorLogErro;

        public ManipuladorDeObterClimaAeroporto(IMediadorDoDominio mediadorDoDominio, IArmazenadorClimaAeroporto armazenadorClimaAeroporto, IArmazenadorLogErro armazenadorLogErro)
        {
            _mediadorDoDominio = mediadorDoDominio;
            _armazenadorClimaAeroporto = armazenadorClimaAeroporto;
            _armazenadorLogErro = armazenadorLogErro;
        }

        public override RespostaAeroporto Manipular(ComandoObterClimaAeroporto comando)
        {
            ApiBrasil api = new ApiBrasil();
            RespostaAeroporto resposta = new RespostaAeroporto();

            if (ComandoInvalido())
                return new();

            var retorno = api.GetClimaAeroporto(comando.CodigoIcao);

            resposta.CodigoIcao = retorno.Result.CodigoIcao;
            resposta.Condicao = retorno.Result.Condicao;
            resposta.CondicaoDesc = retorno.Result.CondicaoDesc;
            resposta.Visibilidade = retorno.Result.Visibilidade;
            resposta.Umidade = retorno.Result.Umidade;
            resposta.DirecaoVento = retorno.Result.DirecaoVento;
            resposta.PressaoAtmosferica = retorno.Result.PressaoAtmosferica;
            resposta.Temp = retorno.Result.Temp;
            resposta.AtualizadoEm = retorno.Result.AtualizadoEm;
            resposta.Vento = retorno.Result.Vento;

            _armazenadorClimaAeroporto.SalvarClimaAeroporto(resposta.Umidade,
                                                            resposta.Visibilidade,
                                                            resposta.CodigoIcao,
                                                            resposta.PressaoAtmosferica,
                                                            resposta.Vento,
                                                            resposta.DirecaoVento,
                                                            resposta.Condicao,
                                                            resposta.CondicaoDesc,
                                                            resposta.Temp,
                                                            resposta.AtualizadoEm);

            return resposta;

            #region Submétodos

            bool ComandoInvalido()
            {
                if (String.IsNullOrEmpty(comando.CodigoIcao))
                {
                    _mediadorDoDominio.Notificacoes.Adicionar("Código ICAO inválido.");
                    _armazenadorLogErro.LogErro(comando.CodigoIcao, "Código ICAO inválido.", "ClimaAeroporto");
                }

                return _mediadorDoDominio.Notificacoes.FoiInterrompido;
            }

            #endregion
        }


    }
}
