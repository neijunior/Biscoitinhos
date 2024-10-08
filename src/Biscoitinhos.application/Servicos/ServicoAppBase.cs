﻿using AutoMapper;
using Biscoitinhos.application.DTO;
using Biscoitinhos.application.Interfaces;
using Biscoitinhos.domain.Entidades;
using Biscoitinhos.domain.Interfaces.Servicos;

namespace Biscoitinhos.application.Servicos
{
  public class ServicoAppBase<TEntity, TEntidadeDTO> : IAppBase<TEntity, TEntidadeDTO>
      where TEntity : EntidadeBase
      where TEntidadeDTO : BaseDTO
    {
        public readonly IServicoBase<TEntity> _servico;
        public readonly IMapper _iMapper;

        public ServicoAppBase(IMapper iMapper, IServicoBase<TEntity> servico) : base()
        {
            this._iMapper = iMapper;
            this._servico = servico;
        }
        public async Task Delete(Guid Id)
        {
            await _servico.Delete(Id);
        }

        public async Task Delete(TEntity entity)
        {
            await _servico.Delete(entity);
        }

        public async Task Insert(TEntity entity)
        {
            await _servico.Insert(_iMapper.Map<TEntity>(entity));
        }

        public async Task<ICollection<TEntidadeDTO>> SelectAll()
        {
            var lista = _iMapper.Map<ICollection<TEntidadeDTO>>(await _servico.SelectAll());
            return lista;
        }

        public async Task<TEntidadeDTO> SelectById(Guid Id)
        {
            return _iMapper.Map<TEntidadeDTO>(await _servico.SelectById(Id));
        }

        public async Task Update(TEntity entity)
        {
            await _servico.Update(_iMapper.Map<TEntity>(entity));
        }
    }
}
