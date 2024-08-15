using Biscoitinhos.application.DTO;
using Biscoitinhos.domain.Entidades;

namespace Biscoitinhos.application.Interfaces
{
  public interface IAppBase<TEntity, TEntityDTO> where TEntity : EntidadeBase
                                                 where TEntityDTO : BaseDTO
  {
    void Insert(TEntity entity);
    void Delete(int Id);
    void Delete(TEntity entity);
    void Update(TEntity entity);
    TEntityDTO SelectById(int Id);
    IEnumerable<TEntityDTO> SelectAll();
  }
}
