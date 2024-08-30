using AutoMapper;
using Biscoitinhos.application.DTO;
using Biscoitinhos.application.Interfaces;
using Biscoitinhos.domain.Interfaces.Servicos;

namespace Biscoitinhos.application.Servicos
{
    public class UnidadeMedidaApp : IUnidadeMedidaApp      
  {
    public readonly IUnidadeMedidaServico _servico;
    public readonly IMapper _iMapper;
    public UnidadeMedidaApp(IMapper iMapper, IUnidadeMedidaServico servico) : base()
    {
      this._iMapper = iMapper;
      this._servico = servico;
    }

    public async Task<ICollection<UnidadeMedidaDTO>> SelectAll()
    {
      var lista = _iMapper.Map<ICollection<UnidadeMedidaDTO>>(await _servico.SelectAll());
      return lista;
    }
  }
}
