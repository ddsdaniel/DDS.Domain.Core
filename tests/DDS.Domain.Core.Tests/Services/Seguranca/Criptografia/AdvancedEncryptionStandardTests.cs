using Bogus;
using DDS.Domain.Core.Services.Seguranca.Criptografia;
using System;
using Xunit;

namespace DDS.Domain.Core.Tests.Services.Seguranca.Criptografia
{
    public class AdvancedEncryptionStandardTests
    {
        [Fact]
        public void CifrarDecifrar_DadosAleatorios_SucessoNaDecifragem()
        {
            //Arrange
            var mensagem = new Faker("pt_BR").Person.UserName;
            var chaveSecreta = Guid.NewGuid().ToString();
            var algoritmo = new AdvancedEncryptionStandard();

            //Act
            var mensagemCifrada = algoritmo.Cifrar(mensagem, chaveSecreta);
            var mensagemDecifrada = algoritmo.Decifrar(mensagemCifrada, chaveSecreta);

            //Assert
            Assert.NotEqual(mensagem, mensagemCifrada);
            Assert.Equal(mensagem, mensagemDecifrada);
        }
    }
}
