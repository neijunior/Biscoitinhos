using Biscoitinhos.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biscoitinhos.domain.Interfaces.Repositories
{
  public interface IRepositoryBase<TEntity> where TEntity : EntityBase
  {
    int Insert(TEntity entity);
    void Delete(int Id);
    void Delete (TEntity entity);
    void Update(TEntity entity);
    TEntity SelectById(int Id); 
    IEnumerable<TEntity> SelectAll();  
  }
}
