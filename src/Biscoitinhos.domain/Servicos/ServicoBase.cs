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
    protected readonly IRepositorioBase<TEntity> _repositorio;
    public ServicoBase(IRepositorioBase<TEntity> repositorio)
    {
      this._repositorio = repositorio;
    }
    public void Delete(int Id)
    {
      _repositorio.Delete(Id); 
    }

    public void Delete(TEntity entity)
    {
      _repositorio.Delete(entity);
    }

    public void Insert(TEntity entity)
    {
      _repositorio.Insert(entity);
    }

    public IEnumerable<TEntity> SelectAll()
    {
      return _repositorio.SelectAll();
    }

    public TEntity SelectById(int Id)
    {
      return _repositorio.SelectById(Id);
    }

    public void Update(TEntity entity)
    {
      _repositorio.Update(entity);
    }
  }
}
