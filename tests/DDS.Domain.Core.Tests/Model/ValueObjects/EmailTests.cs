using DDS.Domain.Core.Mocks.Models.ValueObjects;
using DDS.Domain.Core.Models.ValueObjects;
using Xunit;

namespace DDS.Domain.Core.Tests.Models.ValueObjects
{
    public class EmailTests
    {
        [Fact]
        public void Construtor_DadosValidos_Valid()
        {
            //Arrange & Act
            var email = EmailMock.ObterValido();

            //Assert
            Assert.True(email.Valid);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("email")]
        [InlineData("email@")]
        [InlineData("email@dominio")]
        [InlineData("@dominio.com")]
        [InlineData("email@@dominio.com")]
        [InlineData("email@dominio@com")]
        public void Construtor_DadosInvalidos_Invalid(string conteudo)
        {
            //Arrange & Act
            var email = new Email(conteudo);

            //Assert
            Assert.True(email.Invalid);
        }
    }
}
