using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities.Users;
using FluentValidation;

namespace PresentationLayer.Validations
{
    public class InformationEmployeeValidation : AbstractValidator<Employees>
    {
        public InformationEmployeeValidation() 
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(x => x.comment)
            .NotEmpty().WithMessage("El campo de profesión no puede estar vacío.")
            .Length(3, 100).WithMessage("La profesión no puede tener menos de 3 y más de 100 caracteres.")
            .Matches("^[a-zA-ZÀ-ÿ\\s]+$").WithMessage("El nombre solo puede contener letras y espacios.");


            RuleFor(x => x.workStation)
                .NotEmpty().WithMessage("El campo de puesto de trabajo no puede estar vacío.")
                .Length(3, 50).WithMessage("El puesto de trabajo no puede tener menos de 3 y más de 50 caracteres.")
                .Matches("^[a-zA-ZÀ-ÿ\\s]+$").WithMessage("El nombre solo puede contener letras y espacios.");
        }

    }
    
}
