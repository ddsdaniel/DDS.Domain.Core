using DDS.Domain.Core.Abstractions.Models.ValueObjects;
using Flunt.Validations;
using System.Diagnostics.CodeAnalysis;

namespace DDS.Domain.Core.Models.ValueObjects
{
    public class DiaDoMes : ValueObject<DiaDoMes>
    {
        public int Dia { get; private set; }

        [ExcludeFromCodeCoverage] protected DiaDoMes() { }

        public DiaDoMes(int dia)
        {
            AddNotifications(new Contract()
                .IsBetween(dia, 1, 31, nameof(Dia), "Dia deve ser entre 1 e 31")
                );

            Dia = dia;
        }
    }
}
