using System;

namespace DDS.Domain.Core.Abstractions.Model.ForeignKeys
{
    public abstract class ForeignKey
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public ForeignKey()
        {

        }

        public ForeignKey(Guid id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public override string ToString() => Nome;
    }
}
