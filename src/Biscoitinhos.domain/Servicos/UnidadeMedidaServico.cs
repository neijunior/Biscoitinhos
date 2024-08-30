using Biscoitinhos.domain.Entidades;
using Biscoitinhos.domain.Interfaces.Repositorios;
using Biscoitinhos.domain.Interfaces.Servicos;

namespace Biscoitinhos.domain.Servicos
{
  public class UnidadeMedidaServico: IUnidadeMedidaServico
  {   

    protected readonly IUnidadeMedidaRepositorio _repositorio;
    public UnidadeMedidaServico(IUnidadeMedidaRepositorio repositorio)
    {
      this._repositorio = repositorio;
    }

    public async Task<ICollection<UnidadeMedida>> SelectAll()
    {
      return await _repositorio.SelectAll();
    }
  }
}
