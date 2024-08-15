using AutoMapper;
using Biscoitinhos.application.DTO;
using Biscoitinhos.application.Interfaces;
using Biscoitinhos.domain.Entidades;
using Biscoitinhos.domain.Interfaces.Servicos;
using Biscoitinhos.domain.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biscoitinhos.application.Servicos
{
  public class ServicoAppBase<TEntity, TEntidadeDTO> : IAppBase<TEntity, TEntidadeDTO>
    where TEntity : EntidadeBase
    where TEntidadeDTO : BaseDTO
  {
    public readonly IServicoBase<TEntity> _servico;
    public readonly IMapper _iMapper;

    public ServicoAppBase(IMapper iMapper, IServicoBase<TEntity> servico): base()
    {
      this._iMapper = iMapper;
      this._servico = servico;
    }
    public void Delete(int Id)
    {
      _servico.Delete(Id);
    }

    public void Delete(TEntity entity)
    {
      _servico.Delete(entity);
    }

    public void Insert(TEntity entity)
    {
      _servico.Insert(_iMapper.Map<TEntity>(entity));
    }

    public IEnumerable<TEntidadeDTO> SelectAll()
    {
      return _iMapper.Map<IEnumerable<TEntidadeDTO>>(_servico.SelectAll());
    }

    public TEntidadeDTO SelectById(int Id)
    {
      return _iMapper.Map<TEntidadeDTO>(_servico.SelectById(Id));
    }

    public void Update(TEntity entity)
    {
      _servico.Update(entity);
    }
  }
}
