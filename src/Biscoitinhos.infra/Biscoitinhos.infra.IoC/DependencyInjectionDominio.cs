using Biscoitinhos.domain.Interfaces.Servicos;
using Biscoitinhos.domain.Servicos;
using Microsoft.Extensions.DependencyInjection;

namespace Biscoitinhos.infra.IoC
{
  public static class DependencyInjectionDominio
  {
    public static void RegisterDominio(this IServiceCollection svcCollection)
    {
      svcCollection.AddScoped(typeof(IServicoBase<>), typeof(ServicoBase<>));
      svcCollection.AddScoped<ISKUServico, SKUServico>();
      svcCollection.AddScoped<IUnidadeMedidaServico, UnidadeMedidaServico>();
    }
  }
}
