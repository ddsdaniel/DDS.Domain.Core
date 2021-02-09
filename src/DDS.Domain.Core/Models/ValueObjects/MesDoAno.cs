using DDS.Domain.Core.Abstractions.Models.ValueObjects;
using Flunt.Validations;
using System.Diagnostics.CodeAnalysis;

namespace DDS.Domain.Core.Models.ValueObjects
{
    public class MesDoAno : ValueObject<MesDoAno>
    {
        public int Mes { get; private set; }

        [ExcludeFromCodeCoverage] protected MesDoAno() { }

        public MesDoAno(int mes)
        {
            AddNotifications(new Contract()
                .IsBetween(mes, 1, 12, nameof(Mes), "Mês deve ser entre 1 e 12")
                );

            Mes = mes;
        }
    }
}
