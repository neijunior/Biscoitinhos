using Biscoitinhos.domain.Entities;
using Biscoitinhos.domain.Interfaces.Repositories;
using Biscoitinhos.infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biscoitinhos.infra.Data.Repositories
{
  public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : EntityBase
  {
    protected readonly Context _context;

    public RepositoryBase(Context context) : base()
    {
      this._context = context;
    }

    public void Update(TEntity entity)
    {
      _context.InitTransaction();
      _context.Set<TEntity>().Attach(entity);
      _context.Entry(entity).State = EntityState.Modified;
      _context.SendChanges();
    }

    public void Delete(int Id)
    {
      var entity = SelectById(Id);
      if (entity != null)
      {
        _context.InitTransaction();
        _context.Set<TEntity>().Remove(entity);
        _context.SendChanges();
      }
    }

    public void Delete(TEntity entity)
    {
      _context.InitTransaction();
      _context.Set<TEntity>().Remove(entity);
      _context.SendChanges();
    }

    public int Insert(TEntity entity)
    {
      _context.InitTransaction();
      var id = _context.Set<TEntity>().Add(entity).Entity.Id;
      _context.SendChanges();
      return id;
    }

    public IEnumerable<TEntity> SelectAll()
    {
      return _context.Set<TEntity>().ToList();
    }

    public TEntity SelectById(int Id)
    {
      return _context.Set<TEntity>().Find(Id);
    }
  }
}
