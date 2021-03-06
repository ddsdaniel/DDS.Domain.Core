﻿using DDS.Domain.Core.Abstractions.Models.ValueObjects;
using Flunt.Validations;

namespace DDS.Domain.Core.Models.ValueObjects.Seguranca.Senhas
{
    public class SenhaFraca : ValueObject<SenhaFraca>
    {
        public int TamanhoMinimo { get; private set; }
        public string Conteudo { get; private set; }

        public SenhaFraca(string conteudo, int tamanhoMinimo)
        {
            AddNotifications(new Contract()
                .IsNotNullOrEmpty(conteudo, nameof(Conteudo), "O conteúdo da senha não deve ser vazio ou nulo")
                .HasMinLengthIfNotNullOrEmpty(conteudo, tamanhoMinimo, nameof(TamanhoMinimo), $"O conteúdo da senha deve conter pelo menos {tamanhoMinimo} caracteres")
                .IsGreaterOrEqualsThan(tamanhoMinimo, 0, nameof(TamanhoMinimo), "Tamanho mínimo não deve ser negativo")
                );

            Conteudo = conteudo;
            TamanhoMinimo = tamanhoMinimo;
        }

        public override string ToString() => Conteudo;
    }
}
