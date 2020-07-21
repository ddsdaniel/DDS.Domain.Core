using DDS.Domain.Core.Abstractions.Model.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DDS.Domain.Core.Abstractions.Services
{
    public interface ICrudService<TEntity> : IService where TEntity : Entity
    {
        Task Adicionar(TEntity entity);
        Task Atualizar(TEntity entity);
        Task<TEntity> ConsultarPorId(Guid id);
        ICollection<TEntity> ConsultarTodos();
        ICollection<TEntity> Pesquisar(string filtro);
        Task Excluir(Guid id);
        Task Commit();
    }
}