using Flunt.Notifications;
using System;

namespace DDS.Domain.Core.Abstractions.Model.Entities
{
    public abstract class Entity : Notifiable
    {
        public Guid Id { get; protected set; }

        public DateTime DataCriacao { get; protected set; }

        public DateTime DataUltimaAlteracao { get; protected set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
            DataCriacao = DateTime.Now;
            DataUltimaAlteracao = DataCriacao;
        }     
    }
}
