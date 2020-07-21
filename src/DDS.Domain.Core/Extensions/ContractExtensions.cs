using Flunt.Notifications;
using Flunt.Validations;
using System.Collections.Generic;
using System.Linq;

namespace DDS.Domain.Core.Extensions
{
    public static class ContractExtensions
    {
        public static Contract IsValidArray<T>(this Contract contrato, IEnumerable<T> colecao, string propriedade)
            where T : Notifiable
        {
            contrato.IsNotNull(colecao, propriedade, $"Lista de {propriedade} não pode ser nula")
                    .IfNotNull(colecao, c => c.Join(colecao.ToArray()));

            return contrato;
        }
    }
}
