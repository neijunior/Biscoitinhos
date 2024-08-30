using Biscoitinhos.application.DTO;
using Biscoitinhos.domain.Entidades;

namespace Biscoitinhos.application.Interfaces
{
  public interface IUnidadeMedidaApp
  {
    Task<ICollection<UnidadeMedidaDTO>> SelectAll();
  }
}
