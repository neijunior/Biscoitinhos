using Biscoitinhos.application.Interfaces;
using Biscoitinhos.application.Servicos;
using Microsoft.Extensions.DependencyInjection;

namespace Biscoitinhos.infra.IoC
{
  public static class DependencyInjectionAplicacao
  {
    public static void RegisterAplicacao(this IServiceCollection svcCollection)
    {
      svcCollection.AddScoped(typeof(IAppBase<,>), typeof(ServicoAppBase<,>));
      svcCollection.AddScoped<ISKUApp, SKUApp>();
      svcCollection.AddScoped<IUnidadeMedidaApp, UnidadeMedidaApp>();

    }
  }
}
