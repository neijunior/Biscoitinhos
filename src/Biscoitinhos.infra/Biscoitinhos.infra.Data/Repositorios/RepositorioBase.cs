using Biscoitinhos.domain.Entidades;
using Biscoitinhos.domain.Interfaces.Repositorios;
using Biscoitinhos.infra.Data.Contextos;
using Microsoft.EntityFrameworkCore;

namespace Biscoitinhos.infra.Data.Repositorios
{
  public class RepositorioBase<TEntity> : IRepositorioBase<TEntity> where TEntity : EntidadeBase
    {
        protected readonly Contexto _contexto;

        public RepositorioBase(Contexto context) : base()
        {
            this._contexto = context;
        }

        public async Task Update(TEntity entity)
        {
            _contexto.InitTransaction();
            _contexto.Set<TEntity>().Attach(entity);
            _contexto.Entry(entity).State = EntityState.Modified;
            _contexto.SendChanges();
        }

        public async Task Delete(int Id)
        {
            var entity = await SelectById(Id);
            if (entity != null)
            {
                _contexto.InitTransaction();
                _contexto.Set<TEntity>().Remove(entity);
                _contexto.SendChanges();
            }
        }

        public async Task Delete(TEntity entity)
        {
            _contexto.InitTransaction();
            _contexto.Set<TEntity>().Remove(entity);
            _contexto.SendChanges();
        }

        public async Task Insert(TEntity entity)
        {
            _contexto.InitTransaction();
            var id = _contexto.Set<TEntity>().Add(entity).Entity.Id;
            _contexto.SendChanges();
            //return id;
        }

        public async Task<ICollection<TEntity>> SelectAll()
        {
            return _contexto.Set<TEntity>().ToList();
        }

        public async Task<TEntity> SelectById(int Id)
        {
            return _contexto.Set<TEntity>().Find(Id);
        }
    }
}
