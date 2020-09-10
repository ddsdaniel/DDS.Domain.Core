using Bogus;
using DDS.Domain.Core.Models.ValueObjects;

namespace DDS.Domain.Core.Mocks.Models.ValueObjects
{
    public static class DiaDoMesMock
    {
        public static DiaDoMes ObterValido()
        {
            return new Faker<DiaDoMes>()
              .CustomInstantiator(e => new DiaDoMes(e.Random.Int(1, 31)))
              .Generate();
        }

        public static DiaDoMes ObterInvalido()
        {
            return new DiaDoMes(0);
        }

        public static DiaDoMes ObterComDia(int dia)
        {
            return new DiaDoMes(dia);
        }
    }
}
