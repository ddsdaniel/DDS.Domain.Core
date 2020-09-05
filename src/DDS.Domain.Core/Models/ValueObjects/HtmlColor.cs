using DDS.Domain.Core.Abstractions.Models.ValueObjects;
using Flunt.Validations;
using System;
using System.Text.RegularExpressions;

namespace DDS.Domain.Core.Models.ValueObjects
{
    public class HtmlColor : ValueObject<HtmlColor>
    {
        public string Codigo { get; private set; }

        protected HtmlColor()
        {

        }

        public HtmlColor(string codigo)
        {
            AddNotifications(new Contract()
                .IsNotNullOrEmpty(codigo, nameof(Codigo), "O código da cor não deve ser nulo ou vazio")
                .IsTrue(Validar(codigo), nameof(Codigo), "Código de cor inválido, deve estar no formato #000000")
                );

            Codigo = codigo;
        }

        private static bool Validar(string codigo)
        {
            if (String.IsNullOrEmpty(codigo))
                return false;

            const string HEX_PATTERN = "^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$";
            var regex = new Regex(HEX_PATTERN);
            var match = regex.Match(codigo);
            return match.Success;
        }

        public override string ToString() => Codigo;
    }
}
