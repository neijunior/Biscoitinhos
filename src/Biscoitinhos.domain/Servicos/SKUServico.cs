using Biscoitinhos.domain.Entidades;
using Biscoitinhos.domain.Interfaces.Repositorios;
using Biscoitinhos.domain.Interfaces.Servicos;

namespace Biscoitinhos.domain.Servicos
{
  public class SKUServico : ServicoBase<SKU>, ISKUServico
  {
    public SKUServico(ISKURepositorio repositorio) : base(repositorio)
    {

    }
  }
}
