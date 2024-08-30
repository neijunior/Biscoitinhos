using Biscoitinhos.domain.Entidades;

namespace Biscoitinhos.domain.Interfaces.Servicos
{
  public interface IUnidadeMedidaServico
  {
    Task<ICollection<UnidadeMedida>> SelectAll();
  }
}
