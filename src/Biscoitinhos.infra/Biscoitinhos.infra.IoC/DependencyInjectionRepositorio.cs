using Biscoitinhos.domain.Interfaces.Repositorios;
using Biscoitinhos.infra.Data.Repositorios;
using Microsoft.Extensions.DependencyInjection;

namespace Biscoitinhos.infra.IoC
{
  public static class DependencyInjectionRepositorio
  {
    public static void RegisterRepositorio(this IServiceCollection svcCollection)
    {
      svcCollection.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));
      svcCollection.AddScoped<ISKURepositorio, SKURepositorio>();
      svcCollection.AddScoped<IUnidadeMedidaRepositorio, UnidadeMedidaRepositorio>();
    }

  }
}
