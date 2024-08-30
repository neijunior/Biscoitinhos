using Biscoitinhos.domain.Entidades;

namespace Biscoitinhos.domain.Interfaces.Repositorios
{
  public interface IUnidadeMedidaRepositorio
  {
    Task<ICollection<UnidadeMedida>> SelectAll();
  }
}
