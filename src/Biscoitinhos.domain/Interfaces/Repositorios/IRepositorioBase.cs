using Biscoitinhos.domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biscoitinhos.domain.Interfaces.Repositorios
{
  public interface IRepositorioBase<TEntity> where TEntity : EntidadeBase
  {
    int Insert(TEntity entity);
    void Delete(int Id);
    void Delete (TEntity entity);
    void Update(TEntity entity);
    TEntity SelectById(int Id); 
    IEnumerable<TEntity> SelectAll();  
  }
}
