using Bogus;
using DDS.Domain.Core.Models.ValueObjects;

namespace DDS.Domain.Core.Mocks.Models.ValueObjects
{
    public static class EmailMock
    {
        public static Email ObterValido()
            => new Faker<Email>()
               .CustomInstantiator(e => new Email(e.Internet.Email()))
               .Generate();

        public static Email ObterInvalido()
            => new Email("invalido");
    }
}
