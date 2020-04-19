using DDS.Domain.Core.Model.ValueObjects.Seguranca.Senhas;
using Xunit;

namespace DDS.Domain.Core.Tests.Model.ValueObjects.Seguranca.Senhas
{
    public class SenhaFracaTests
    {
        [Theory]
        [InlineData("123", 1, true)]
        [InlineData("1", 1, true)]
        [InlineData("123", 3, true)]
        [InlineData("123", 0, true)]
        [InlineData("123", -1, false)]
        [InlineData("", 1, false)]
        [InlineData(null, 1, false)]
        [InlineData("123", 4, false)]
        public void Construtor_DadosConformeTheory_ResultadoConformeTheory(string conteudo, int tamanhoMinimo, bool resultadoEsperado)
        {
            //Arrange & Act
            var senha = new SenhaFraca(conteudo, tamanhoMinimo);

            //Assert
            Assert.Equal(resultadoEsperado, senha.Valid);
        }
    }
}
