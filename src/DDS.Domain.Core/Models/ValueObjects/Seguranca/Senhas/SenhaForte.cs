using Flunt.Validations;
using System;
using System.Linq;

namespace DDS.Domain.Core.Models.ValueObjects.Seguranca.Senhas
{
    public class SenhaForte : SenhaMedia
    {
        public SenhaForte(string conteudo, int tamanhoMinimo) : base(conteudo, tamanhoMinimo)
        {
            AddNotifications(new Contract()
                .IsTrue(ContemCaracteresEspeciais(conteudo), nameof(Conteudo), "O conteúdo da senha deve conter pelo menos um caracter especial")
                );
        }

        private static bool ContemCaracteresEspeciais(string texto) => texto.Any(ch => !char.IsLetterOrDigit(ch));
    }
}
