﻿using Biscoitinhos.domain.Entidades;

namespace Biscoitinhos.domain.Interfaces.Repositorios
{
    public interface IRepositorioBase<TEntity> where TEntity : EntidadeBase
    {
        Task Insert(TEntity entity);
        Task Delete(Guid Id);
        Task Delete(TEntity entity);
        Task Update(TEntity entity);
        Task<TEntity> SelectById(Guid Id);
        Task<ICollection<TEntity>> SelectAll();
    }
}
