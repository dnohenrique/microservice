using Domain.Entities;
using Domain.Event;
using FluentValidation;
using FluentValidation.Results;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Validations
{
    public abstract class EmpresaEventValidation<T> : AbstractValidator<T> where T : EmpresaEvent
    {
        protected override bool PreValidate(ValidationContext<T> context, ValidationResult result)
        {
            if (context.InstanceToValidate.Responsavel == null)
            {
                result.Errors.Add(new ValidationFailure("Responsavel", "Dados do Responsavel não informado"));
                return false;
            }
            if (context.InstanceToValidate.Endereco == null)
            {
                result.Errors.Add(new ValidationFailure("Endereco", "Dados do Endereco não informado"));
                return false;
            }
            if (context.InstanceToValidate.Comercial == null)
            {
                result.Errors.Add(new ValidationFailure("Comercial", "Dados do Comercial não informado"));
                return false;
            }
            if (context.InstanceToValidate.Financeiro == null)
            {
                result.Errors.Add(new ValidationFailure("Financeiro", "Dados do Financeiro não informado"));
                return false;
            }
            return true;
        }

        #region Fluent Validations
        protected void ValidarEmpresa()
        {
            RuleFor(c => c.Id)
                 .NotEmpty()
                     .WithMessage("Por favor, informe o Id da Empresa")
                 .NotNull()
                     .WithMessage("O Id do Empresa a ser atualizada não pode ser nulo")
                 .Must(GenericValidation.ShouldHaveValidCnpj)
                     .WithMessage("O Id do Empresa deve ser um CNPJ válido");

            RuleFor(c => c.NomeFantasia)
                .NotEmpty()
                    .WithMessage("Por favor, insira o Nome Fantasia da empresa")
                .Must(c => GenericValidation.ShouldBeBetweenRange(c, 3, 100))
                    .WithMessage("O Nome Fantasia da empresa deverá conter entre 3 e 100 caracteres")
                .NotNull()
                    .WithMessage("O Nome Fantasia da empresa não pode ser nulo");

            RuleFor(c => c.RazaoSocial)
                .NotEmpty()
                    .WithMessage("Por favor, insira a Razão Social da empresa")
                .Must(c => GenericValidation.ShouldBeBetweenRange(c, 3, 100))
                    .WithMessage("A Razão Social da empresa deverá conter entre 3 e 100 caracteres")
                .NotNull()
                    .WithMessage("A Razão Social da empresa não pode ser nulo");

            RuleFor(c => c.Segmento)
                .Must(c => GenericValidation.ShouldBeBetweenRange(c, 3, 40, false))
                    .WithMessage("O Segmento da empresa deverá conter entre 3 e 40 caracteres");

            RuleFor(c => c.Site)
                .Must(c => GenericValidation.ShouldLengthBeGreaterThan(c, 3, false))
                    .WithMessage("O Site da empresa deverá conter pelo menos 3 caracteres");

            RuleFor(c => c.Tipo)
                .NotNull().WithMessage("O Tipo da empresa não pode ser nulo")
                .NotEmpty().WithMessage("Por favor, insira o Tipo da empresa");

            RuleFor(c => c.EmpresaProprietariaId)
                //.NotNull().WithMessage("A Empresa Proprietária não pode ser nulo")
                //.NotEmpty().WithMessage("Por favor, insira a Empresa Proprietária")
                .Must(GenericValidation.ShouldHaveValidEmpresaProprietariaId)
                    .WithMessage("A Empresa Proprietária desta empresa deve ser um CNPJ válido")
                .Must(c => GenericValidation.ShouldBeBetweenRange(c, 3, 100, false))
                    .WithMessage("A Empresa Proprietária desta empresa deverá conter entre 3 e 100 caracteres");

            RuleFor(c => c.CentroCusto)
                .Must(c => GenericValidation.ShouldBeBetweenRange(c, 3, 80, false))
                    .WithMessage("O Centro de Custo da empresa deverá conter entre 3 e 80 caracteres");

            RuleFor(c => c.Alias)
                .Must(c => GenericValidation.ShouldBeBetweenRange(c, 2, 25, false))
                    .WithMessage("O Alias da empresa deverá conter entre 2 e 25 caracteres")
                .Must(c => GenericValidation.ShouldBeAliasValid(c))
                    .WithMessage("O Alias não pode ser 'api' ou 'service'");

            RuleFor(c => c.Coparticipacao).GreaterThan(-1).WithMessage("Valor da coparticipação não pode ser menor que 0");
        }

        protected void ValidarDocumentos()
        {
            RuleFor(c => c.Documentos)
                .Must(ShouldHaveAtLeastOne)
                    .WithMessage("Empresa deve possuir pelo menos um Documento")
                .Must(ShouldHaveCNPJ)
                    .WithMessage("Empresa deve possuir um documento do tipo CNPJ");

            RuleForEach(c => c.Documentos)
                .SetValidator(new DocumentoValidation());
        }

        protected void ValidarResponsavel()
        {
            RuleFor(c => c.Responsavel)
                .SetValidator(new ResponsavelValidation());
        }

        protected void ValidarEndereco()
        {
            RuleFor(c => c.Endereco)
                .SetValidator(new EnderecoValidation());
        }

        protected void ValidarComercial()
        {
            RuleFor(c => c.Comercial)
                .SetValidator(new ComercialValidation());
        }

        protected void ValidarFinanceiro()
        {
            RuleFor(c => c.Financeiro)
                .SetValidator(new FinanceiroValidation());
        }

        protected void ValidarPlanos()
        {
            RuleFor(c => c.Planos)
                .Must(ShouldHaveAtLeastOne)
                    .WithMessage("Empresa deve possuir pelo menos um Plano");

            RuleForEach(c => c.Planos)
                .SetValidator(new PlanoValidation());
        }

        #endregion

        #region Custom Functions
        private bool ShouldHaveAtLeastOne(List<Documento> documentos)
        {
            return documentos != null && documentos.Any();
        }

        private bool ShouldHaveCNPJ(List<Documento> documentos)
        {
            return documentos != null && documentos.Any(d => d.Tipo.ToUpper() == "CNPJ");
        }

        private bool ShouldHaveAtLeastOne(List<Plano> documentos)
        {
            return documentos != null && documentos.Any();
        }
        #endregion

    }
}
