using Biscoitinhos.domain.Entidades;
using Biscoitinhos.domain.Interfaces.Repositorios;
using Biscoitinhos.infra.Data.Contextos;

namespace Biscoitinhos.infra.Data.Repositorios
{
  public class SKURepositorio : RepositorioBase<SKU>, ISKURepositorio
  {
    public SKURepositorio(Contexto context) : base(context)
    {
    }
  }
}
