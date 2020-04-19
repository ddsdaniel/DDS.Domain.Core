using DDS.Domain.Core.Model.ValueObjects.Seguranca.Senhas;
using Xunit;

namespace DDS.Domain.Core.Tests.Model.ValueObjects.Seguranca.Senhas
{
    public class SenhaForteTests
    {
        [Theory]
        [InlineData("abc123@#$%¨&", 2, true)]
        [InlineData("123ABC@#$%¨&", 2, true)]
        [InlineData("@#$%¨&", 2, false)]
        [InlineData("1a", 2, false)]
        [InlineData("a1", 2, false)]
        [InlineData("aaaa122", 2, false)]
        [InlineData("@@122", 2, false)]
        [InlineData("1234", 1, false)]
        [InlineData("aAA", 1, false)]        
        public void Construtor_DadosConformeTheory_ResultadoConformeTheory(string conteudo, int tamanhoMinimo, bool resultadoEsperado)
        {
            //Arrange & Act
            var senha = new SenhaForte(conteudo, tamanhoMinimo);

            //Assert
            Assert.Equal(resultadoEsperado, senha.Valid);
        }
    }
}
