using Biscoitinhos.domain.Entidades;

namespace Biscoitinhos.domain.Interfaces.Servicos
{
  public interface IServicoBase<TEntity> where TEntity : EntidadeBase
  {
    void Insert(TEntity entity);
    void Delete(int Id);
    void Delete(TEntity entity);
    void Update(TEntity entity);
    TEntity SelectById(int Id);
    IEnumerable<TEntity> SelectAll();
  }  
}
