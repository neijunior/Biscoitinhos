using Biscoitinhos.application.Interfaces;
using Biscoitinhos.application.Servicos;
using Biscoitinhos.domain.Interfaces.Repositorios;
using Biscoitinhos.domain.Interfaces.Servicos;
using Biscoitinhos.domain.Servicos;
using Biscoitinhos.infra.Data.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biscoitinhos.infra.IoC
{
  public class DependencyInjection
  {
    public static void Register(IServiceCollection svcCollection)
    {
      //Aplicação
      svcCollection.AddScoped(typeof(IAppBase<,>), typeof(ServicoAppBase<,>));
      svcCollection.AddScoped<ISKUApp, SKUApp>();

      //Domínio
      svcCollection.AddScoped(typeof(IServicoBase<>), typeof(ServicoBase<>)); 
      svcCollection.AddScoped<ISKUServico, SKUServico>();

      //Repositorio
      svcCollection.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));
      svcCollection.AddScoped<ISKURepositorio, SKURepositorio>();
    }
  }
}
