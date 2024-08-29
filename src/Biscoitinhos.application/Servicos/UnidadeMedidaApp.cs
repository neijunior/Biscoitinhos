using AutoMapper;
using Biscoitinhos.application.DTO;
using Biscoitinhos.application.Interfaces;
using Biscoitinhos.domain.Entidades;
using Biscoitinhos.domain.Interfaces.Servicos;

namespace Biscoitinhos.application.Servicos
{
  public class UnidadeMedidaApp : ServicoAppBase<UnidadeMedida, UnidadeMedidaDTO>, IUnidadeMedidaApp
  {
    public UnidadeMedidaApp(IMapper iMapper, IUnidadeMedidaServico servico) : base(iMapper, servico)
    {
    }
  }
}
