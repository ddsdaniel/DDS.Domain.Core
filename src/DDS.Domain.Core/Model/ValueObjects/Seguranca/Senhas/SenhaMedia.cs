using Flunt.Validations;
using System;
using System.Linq;

namespace DDS.Domain.Core.Model.ValueObjects.Seguranca.Senhas
{
    public class SenhaMedia : SenhaFraca
    {
        public SenhaMedia(string conteudo, int tamanhoMinimo) : base(conteudo, tamanhoMinimo)
        {
            AddNotifications(new Contract()
                .IfNotNull(conteudo, c => c.Join(new Contract()
                     .IsTrue(ContemLetras(conteudo), nameof(Conteudo), "O conteúdo da senha deve conter pelo menos uma letra")
                     .IsTrue(ContemNumeros(conteudo), nameof(Conteudo), "O conteúdo da senha deve conter pelo menos um número")
                     ))
                );
        }

        private static bool ContemLetras(string texto) => texto.Any(ch => Char.IsLetter(ch));
        private static bool ContemNumeros(string texto) => texto.Any(ch => Char.IsNumber(ch));
    }
}
