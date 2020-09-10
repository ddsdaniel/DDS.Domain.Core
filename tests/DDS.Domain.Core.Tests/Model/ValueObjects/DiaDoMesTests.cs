using DDS.Domain.Core.Mocks.Models.ValueObjects;
using Xunit;

namespace DDS.Domain.Core.Tests.Model.ValueObjects
{
    public class DiaDoMesTests
    {
        [Fact]
        public void Construtor_DadosValidos_Valid()
        {
            //Arrange & Act
            var diaDoMes = DiaDoMesMock.ObterValido();

            //Assert
            Assert.True(diaDoMes.Valid);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-2)]
        [InlineData(32)]
        [InlineData(40)]
        [InlineData(50)]
        public void Construtor_DadosInvalidos_Invalid(int dia)
        {
            //Arrange & Act
            var diaDoMes = DiaDoMesMock.ObterComDia(dia);

            //Assert
            Assert.True(diaDoMes.Invalid);
        }
    }
}
