using AutoMapper;
using Biscoitinhos.application.DTO;
using Biscoitinhos.application.Interfaces;
using Biscoitinhos.domain.Entidades;
using Biscoitinhos.domain.Interfaces.Servicos;

namespace Biscoitinhos.application.Servicos
{
  public class SKUApp : ServicoAppBase<SKU, SKUDTO>, ISKUApp
  {
    public SKUApp(IMapper iMapper, ISKUServico servico) : base(iMapper, servico)
    {
    }
  }
}
