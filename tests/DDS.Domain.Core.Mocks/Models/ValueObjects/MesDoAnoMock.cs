using Bogus;
using DDS.Domain.Core.Models.ValueObjects;

namespace DDS.Domain.Core.Mocks.Models.ValueObjects
{
    public static class MesDoAnoMock
    {
        public static MesDoAno ObterValido()
        {
            return new Faker<MesDoAno>()
              .CustomInstantiator(e => new MesDoAno(e.Random.Int(1, 12)))
              .Generate();
        }

        public static MesDoAno ObterInvalido()
        {
            return new MesDoAno(0);
        }

        public static MesDoAno ObterComMes(int mes)
        {
            return new MesDoAno(mes);
        }
    }
}
