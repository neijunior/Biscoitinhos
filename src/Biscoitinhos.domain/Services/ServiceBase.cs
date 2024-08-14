using Biscoitinhos.domain.Entities;
using Biscoitinhos.domain.Interfaces.Repositories;
using Biscoitinhos.domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biscoitinhos.domain.Services
{
  public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : EntityBase
  {
    protected readonly IRepositoryBase<TEntity> _repository;
    public ServiceBase(IRepositoryBase<TEntity> repository)
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
