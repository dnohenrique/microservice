using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Validations
{
    public class DocumentoValidation : AbstractValidator<Documento>
    {
        public DocumentoValidation()
        {
            RuleFor(c => c.Tipo)
                .Must(ShouldHaveValidDocumentType)
                    .WithMessage("Os únicos tipos de documentos utilizados no cadastro de Empresa são CNPJ e IE");

            RuleFor(c => c)
                .Must(ShouldHaveValidDocument)
                    .WithMessage(d => $"Documento do tipo {d.Tipo} deve ser válido");
        }

        protected bool ShouldHaveValidDocumentType(string tipo)
        {
            var validosTipos = new string[2] { "CNPJ", "IE" };
            return validosTipos.Contains(tipo?.ToUpper());
        }

        protected bool ShouldHaveValidDocument(Documento documento)
        {
            if (documento.Tipo.ToUpper() == "IE")
            {
                return IsValidIE(documento.Numero);
            }
            return GenericValidation.ShouldHaveValidCnpj(documento.Numero);
        }

        private bool IsValidIE(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return true;
            }
            return value.Length >= 3 && value.Length <= 50;
        }

        public static bool ShouldCnpjEqualId(string id, List<Documento> documentos)
        {
            var cnpj = documentos.Any() ? documentos.Find(x => x.Tipo == "CNPJ").Numero : null;
            return id == cnpj;
        }
    }
}
