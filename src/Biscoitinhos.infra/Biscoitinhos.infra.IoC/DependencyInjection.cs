using Biscoitinhos.application;
using Biscoitinhos.application.Interfaces;
using Biscoitinhos.application.Servicos;
using Biscoitinhos.domain.Interfaces.Repositorios;
using Biscoitinhos.domain.Interfaces.Servicos;
using Biscoitinhos.domain.Servicos;
using Biscoitinhos.infra.Data.Contextos;
using Biscoitinhos.infra.Data.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Biscoitinhos.infra.IoC
{
  public static class DependencyInjection
  {
    public static void Register(this IServiceCollection svcCollection, IConfiguration configuration)
    {      
      svcCollection.AddAutoMapper(typeof(MappingEntidade).Assembly);

      //Aplicação
      svcCollection.AddScoped(typeof(IAppBase<,>), typeof(ServicoAppBase<,>));
      svcCollection.AddScoped<ISKUApp, SKUApp>();

      //Domínio
      svcCollection.AddScoped(typeof(IServicoBase<>), typeof(ServicoBase<>)); 
      svcCollection.AddScoped<ISKUServico, SKUServico>();

      //Repositorio
      svcCollection.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));
      svcCollection.AddScoped<ISKURepositorio, SKURepositorio>();

      svcCollection.AddSqlConfiguration(configuration);
    }

    private static void AddSqlConfiguration(this IServiceCollection svcCollection, IConfiguration configuration)
    {
      svcCollection.AddDbContext<Contexto>(opt => opt.UseSqlServer(configuration.GetConnectionString("ConnAtivo"), b =>
      {
        b.MigrationsAssembly("Biscoitinhos.infra.Data");
      }));
    }
  }
}
