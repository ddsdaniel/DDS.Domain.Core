using Bogus;
using DDS.Domain.Core.Models.ValueObjects.Seguranca.Senhas;

namespace DDS.Domain.Core.Mocks.Models.ValueObjects
{
    public static class SenhaMock
    {
        public static SenhaMedia ObterValida(int tamanhoMinimo)
        {
            return new Faker<SenhaMedia>()
                .CustomInstantiator(s => new SenhaMedia(s.Internet.Password(tamanhoMinimo,
                                                                            false,
                                                                            "\\w",
                                                                            "1a@"),
                                                        tamanhoMinimo))
                .Generate();
        }

        public static SenhaMedia ObterInvalida()
        {
            return new SenhaMedia("123", 8);
        }

    }
}
