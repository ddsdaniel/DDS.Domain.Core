﻿using DDS.Domain.Core.Abstractions.Models.Entities;
using DDS.Domain.Core.Abstractions.Models.ValueObjects.Validacoes;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DDS.Domain.Core.Abstractions.Repositories
{
    public interface IRepository<TEntity> : INotifiable
        where TEntity : Entity
    {
        public bool ConsultarSeExiste(Guid id);
        public Task<TEntity> ConsultarPorId(Guid id);
        public IQueryable<TEntity> AsQueryable();
        public Task Adicionar(TEntity entity);
        public Task Atualizar(TEntity entity);
        public Task Excluir(Guid id);
    }
}
