using DDS.Domain.Core.Abstractions.Models.ValueObjects;
using DDS.Domain.Core.Extensions;
using Flunt.Validations;
using System;

namespace DDS.Domain.Core.Models.ValueObjects
{
    public class IntervaloDatas : ValueObject<IntervaloDatas>
    {
        public DateTime? DataInicial { get; private set; }
        public DateTime? DataFinal { get; private set; }

        protected IntervaloDatas()
        {

        }

        public IntervaloDatas(DateTime? dataInicial, DateTime? dataFinal)
        {
            DataInicial = dataInicial;
            DataFinal = dataFinal;

            AddNotifications(new Contract()
                .IsGreaterOrEqualsThan(DataFinal.GetValueOrMax(), DataInicial.GetValueOrMin(), nameof(DataFinal), "Deve ser maior ou igual que a data inicial")
                );
        }

        public override string ToString()
        {
            if (DataInicial.HasValue && DataFinal.HasValue) return $"De {DataInicial} até {DataFinal}";
            if (DataInicial != null && DataFinal == null) return $"A partir de {DataInicial}";
            if (DataInicial == null && DataFinal != null) return $"Termina em {DataFinal}";
            return "Sempre";
        }

        public bool IsConflitante(IntervaloDatas outroIntervalo)
        {
            return outroIntervalo != null
                && (DataInicial.GetValueOrMin() <= outroIntervalo.DataFinal.GetValueOrMax() && DataFinal.GetValueOrMax() >= outroIntervalo.DataInicial.GetValueOrMin()
                    || outroIntervalo.DataInicial.GetValueOrMin() <= DataFinal.GetValueOrMax() && outroIntervalo.DataFinal.GetValueOrMax() >= DataInicial.GetValueOrMin());
        }

        public bool EstaVigente(DateTime dataHoraBuscada)
        {
            return (DataInicial == null || dataHoraBuscada >= DataInicial.Value) &&
                   (DataFinal == null || dataHoraBuscada <= DataFinal.Value);
        }
    }
}
