using Biscoitinhos.domain.Entidades;
using Biscoitinhos.domain.Interfaces.Repositorios;
using Biscoitinhos.domain.Interfaces.Servicos;

namespace Biscoitinhos.domain.Servicos
{
  public class UnidadeMedidaServico : ServicoBase<UnidadeMedida>, IUnidadeMedidaServico
  {
    public UnidadeMedidaServico(IUnidadeMedidaRepositorio repositorio) : base(repositorio)
    {

    }
  }
}
