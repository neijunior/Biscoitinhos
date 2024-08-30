using Biscoitinhos.domain.Entidades;
using Biscoitinhos.domain.Interfaces.Repositorios;
using Biscoitinhos.infra.Data.Contextos;

namespace Biscoitinhos.infra.Data.Repositorios
{
  public class UnidadeMedidaRepositorio : IUnidadeMedidaRepositorio
  {
    protected readonly Contexto _contexto;
    public UnidadeMedidaRepositorio(Contexto context) 
    {
      this._contexto = context;
    }

    public async Task<ICollection<UnidadeMedida>> SelectAll()
    {
      return _contexto.Set<UnidadeMedida>().ToList();
    }
  }
}
