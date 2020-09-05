using Bogus;
using DDS.Domain.Core.Models.ValueObjects;

namespace DDS.Domain.Core.Mocks.Models.ValueObjects
{
    public static class HtmlColorMock
    {
        public static HtmlColor ObterValido()
        {
            return new Faker<HtmlColor>()
               .CustomInstantiator(p => new HtmlColor(p.Internet.Color()))
               .Generate();
        }
    }
}
