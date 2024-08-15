using Biscoitinhos.domain.Entidades;
using Biscoitinhos.domain.Interfaces.Repositorios;
using Biscoitinhos.domain.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biscoitinhos.domain.Servicos
{
  public class ServicoBase<TEntity> : IServicoBase<TEntity> where TEntity : EntidadeBase
  {
    protected readonly IRepositorioBase<TEntity> _repository;
    public ServicoBase(IRepositorioBase<TEntity> repository)
    {
      this._repository = repository;
    }
    public void Delete(int Id)
    {
      _repository.Delete(Id); 
    }

    public void Delete(TEntity entity)
    {
      _repository.Delete(entity);
    }

    public void Insert(TEntity entity)
    {
      _repository.Insert(entity);
    }

    public IEnumerable<TEntity> SelectAll()
    {
      return _repository.SelectAll();
    }

    public TEntity SelectById(int Id)
    {
      return _repository.SelectById(Id);
    }

    public void Update(TEntity entity)
    {
      _repository.Update(entity);
    }
  }
}
