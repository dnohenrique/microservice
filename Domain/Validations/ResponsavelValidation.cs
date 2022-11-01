using Domain.Entities;
using Domain.Validations.GenericValidations;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Validations
{
    public class ResponsavelValidation : AbstractValidator<Responsavel>
    {
        public ResponsavelValidation()
        {
            RuleFor(c => c.Nome)
                .NotNull()
                    .WithMessage("O Nome do responsável não pode ser nulo")
                .NotEmpty()
                    .WithMessage("Por favor, informar o nome do responsável")
                .Must(c => GenericValidation.ShouldBeBetweenRange(c, 3, 100))
                    .WithMessage("O Nome do responsável deverá ter entre 3 e 100 caracteres");


            //RuleFor(c => c.DataNascimento)
            //        .NotEmpty()
            //            .WithMessage("Favor informar a data de nascimento")
            //        .NotEmpty()
            //            .WithMessage("A data de nascimento não pode ser nula");
            //.Must(DateTimeValidator.IsDateTime)
            //    .WithMessage("Por favor, informar uma Data de Nascimento no formato dd/mm/aaaa")
            //.Must(DateTimeValidator.ShouldBeGreaterThan18)
            //    .WithMessage("A idade do colaborador deverá ser maior ou igual a 18 anos. Ver campo Data de Nascimento");


            //RuleFor(c => c.Cpf)
            //    .SetValidator(c => new CPFValidator());


            RuleFor(c => c.Email)
                .NotEmpty()
                    .WithMessage("O Email do responsável deverá ser informado")
                .NotNull()
                    .WithMessage("O Email do responsável não pode ser null")
                .Must(GenericValidation.ShouldBeLengthValidEmail)
                    .WithMessage("O Email deverá conter entre 6 e 50 caracteres")
                .Must(GenericValidation.ShouldBeEmailValid)
                    .WithMessage("Por favor, informar um Email válido");

            RuleFor(c => c.Telefone)
                .NotEmpty()
                    .WithMessage("Por favor, informar o Telefone do responsável")
                .NotNull()
                    .WithMessage("O Telefone do responsável não pode ser nulo")
                .Must(GenericValidation.ShouldBeLandlinePhoneValid)
                    .WithMessage("Por favor, informar um número de telefone fixo válido");

            RuleFor(c => c.Celular)
                .Must(GenericValidation.ShouldBeCelPhoneValid)
                    .WithMessage("Por favor, informar um número de Celular válido");
        }
    }
}


