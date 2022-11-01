using Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Event
{
    public class DeletarEmpresaEvent : EmpresaEvent
    {

        public DeletarEmpresaEvent(string id)
        {
            Id = id;         
            Ativo = false;
        }

        public override bool IsValid()
        {
            ValidationResult = new DeletarEmpresaValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
