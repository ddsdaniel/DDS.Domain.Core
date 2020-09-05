using DDS.Domain.Core.Models.ValueObjects.Seguranca.Senhas;
using Xunit;

namespace DDS.Domain.Core.Tests.Models.ValueObjects.Seguranca.Senhas
{
    public class SenhaMediaTests
    {
        [Theory]
        [InlineData("1a", 2, true)]
        [InlineData("1A", 2, true)]
        [InlineData("a1", 2, true)]
        [InlineData("A1", 2, true)]
        [InlineData("aaaa122", 2, true)]
        [InlineData("@@122", 2, false)]
        [InlineData("1234", 1, false)]
        [InlineData("aAA", 1, false)]        
        public void Construtor_DadosConformeTheory_ResultadoConformeTheory(string conteudo, int tamanhoMinimo, bool resultadoEsperado)
        {
            //Arrange & Act
            var senha = new SenhaMedia(conteudo, tamanhoMinimo);

            //Assert
            Assert.Equal(resultadoEsperado, senha.Valid);
        }
    }
}
