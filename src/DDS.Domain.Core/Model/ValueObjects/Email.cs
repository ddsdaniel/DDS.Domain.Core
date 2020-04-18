using DDS.Domain.Core.Abstractions.Model.ValueObjects;
using Flunt.Validations;
using System.Text.RegularExpressions;

namespace DDS.Domain.Core.Model.ValueObjects
{
    public class Email : ValueObject<Email>
    {
        public string Endereco { get; private set; }

        public Email(string endereco)
        {
            AddNotifications(new Contract()
                .IsTrue(Validar(endereco), nameof(Endereco), "E-mail inválido")
                );

            Endereco = endereco.ToLower();
        }

        private static bool Validar(string endereco)
        {
            var regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            var match = regex.Match(endereco);
            return match.Success;
        }

        public override string ToString() => Endereco;
    }
}
