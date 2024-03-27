using Core.Dominio.Comandos;
using Core.Dominio.Mediador;
using Dominio.Comandos.Aeroporto;
using Dominio.Externo;
using Dominio.Externo.DTOs;
using Dominio.Respostas.Aeroporto;
using Dominio.Respostas.Cidade;
using Infraestrutura.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Comandos.Cidade
{
    public class ManipuladorClimaCidade : ManipuladorDoComando<ComandoObterClimaCidade, RespostaCidade>
    {
        private readonly IMediadorDoDominio _mediadorDoDominio;
        private readonly IArmazenadorClimaCidade _armazenadorClimaCidade;
        private readonly IArmazenadorClima _armazenadorClima;
        private readonly IArmazenadorLogErro _armazenadorLogErro;

        public ManipuladorClimaCidade(IMediadorDoDominio mediadorDoDominio, IArmazenadorClimaCidade armazenadorClimaCidade, IArmazenadorClima armazenadorClima, IArmazenadorLogErro armazenadorLogErro)
        {
            _mediadorDoDominio = mediadorDoDominio;
            _armazenadorClimaCidade = armazenadorClimaCidade;
            _armazenadorClima = armazenadorClima;
            _armazenadorLogErro = armazenadorLogErro;
        }

        public override RespostaCidade Manipular(ComandoObterClimaCidade comando)
        {
            ApiBrasil api = new ApiBrasil();
            RespostaCidade resposta = new RespostaCidade();

            if (ComandoInvalido())
                return new();

            var retorno = api.GetClimaCidade(comando.CodigoCidade);

            resposta.Cidade = retorno.Result.Cidade;
            resposta.Estado = retorno.Result.Estado;
            resposta.AtualizadoEm = retorno.Result.AtualizadoEm;
            resposta.Clima = retorno.Result.Clima;

            var idClimaCidade = _armazenadorClimaCidade.SalvarClimaCidade(resposta.Cidade, resposta.Estado, resposta.AtualizadoEm);

            foreach(var item in resposta.Clima)
            {
                _armazenadorClima.SalvarClima(idClimaCidade, item.Data, item.Condicao, item.CondicaoDesc, item.Min, item.Max, item.IndiceUv);
            }
            
            return resposta;



            #region Submétodos

            bool ComandoInvalido()
            {
                if (String.IsNullOrEmpty(comando.CodigoCidade))
                {
                    _mediadorDoDominio.Notificacoes.Adicionar("Código da Cidade inválido.");
                    _armazenadorLogErro.LogErro(comando.CodigoCidade, "Código da Cidade inválido.", "ClimaCidade");
                }

                return _mediadorDoDominio.Notificacoes.FoiInterrompido;
            }

            #endregion
        }
    }


}
