using DDS.Domain.Core.Mocks.Models.ValueObjects;
using DDS.Domain.Core.Models.ValueObjects;
using Xunit;

namespace DDS.Domain.Core.Tests.Models.ValueObjects
{
    public class HtmlColorTests
    {
        [Fact]
        public void Construtor_DadosValidos_Valid()
        {
            //Arrange & Act
            var htmlColor = HtmlColorMock.ObterValido();
            
            //Assert
            Assert.True(htmlColor.Valid);
        }

        [Theory]
        [InlineData("#123")]
        [InlineData("#ABC")]
        [InlineData("#1B1")]
        public void Construtor_Tamanho4_Valid(string cor)
        {
            //Arrange & Act
            var htmlColor = new HtmlColor(cor);

            //Assert
            Assert.True(htmlColor.Valid);
        }

        [Theory]
        [InlineData("#123456")]
        [InlineData("#123ABC")]
        [InlineData("#ABC123")]
        [InlineData("#AAAAAA")]
        [InlineData("#FFFFFF")]
        public void Construtor_Tamanho7_Valid(string cor)
        {
            //Arrange & Act
            var htmlColor = new HtmlColor(cor);

            //Assert
            Assert.True(htmlColor.Valid);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("erro")]
        [InlineData("##12345")]
        [InlineData("##123456")]
        [InlineData("#1")]
        [InlineData("#12")]
        [InlineData("#1234")]
        [InlineData("#12345")]
        [InlineData("#1234567")]
        [InlineData("#12345678")]
        [InlineData("#123456789")]
        [InlineData("#12345J")]
        [InlineData("#ABCD")]
        [InlineData("#")]
        public void Construtor_DadosInvalidos_Invalid(string conteudo)
        {
            //Arrange & Act
            var email = new HtmlColor(conteudo);

            //Assert
            Assert.True(email.Invalid);
        }

    }
}
