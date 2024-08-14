using Biscoitinhos.domain.Entities;

namespace Biscoitinhos.domain.Interfaces.Services
{
  public interface IServiceBase<TEntity> where TEntity : EntityBase
  {
    void Insert(TEntity entity);
    void Delete(int Id);
    void Delete(TEntity entity);
    void Update(TEntity entity);
    TEntity SelectById(int Id);
    IEnumerable<TEntity> SelectAll();
  }  
}
