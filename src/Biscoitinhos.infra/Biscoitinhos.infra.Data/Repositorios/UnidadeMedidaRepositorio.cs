using Biscoitinhos.domain.Entidades;
using Biscoitinhos.domain.Interfaces.Repositorios;
using Biscoitinhos.infra.Data.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biscoitinhos.infra.Data.Repositorios
{
  public class UnidadeMedidaRepositorio : RepositorioBase<UnidadeMedida>, IUnidadeMedidaRepositorio
  {
    public UnidadeMedidaRepositorio(Contexto context) : base(context)
    {
    }
  }
}
