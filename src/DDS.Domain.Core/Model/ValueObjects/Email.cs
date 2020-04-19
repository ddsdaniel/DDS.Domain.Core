﻿using DDS.Domain.Core.Abstractions.Model.ValueObjects;
using Flunt.Validations;
using System;
using System.Text.RegularExpressions;

namespace DDS.Domain.Core.Model.ValueObjects
{
    public class Email : ValueObject<Email>
    {
        public string Endereco { get; private set; }

        public Email(string endereco)
        {
            AddNotifications(new Contract()
                .IsNotNullOrEmpty(endereco, nameof(Endereco), "E-mail não deve ser nulo ou vazio")
                .IsTrue(Validar(endereco), nameof(Endereco), "E-mail inválido")
                );

            if (!String.IsNullOrEmpty(endereco))
                Endereco = endereco.ToLower();
        }

        private static bool Validar(string endereco)
        {
            if (String.IsNullOrEmpty(endereco))
                return false;

            var regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            var match = regex.Match(endereco);
            return match.Success;
        }

        public override string ToString() => Endereco;
    }
}
