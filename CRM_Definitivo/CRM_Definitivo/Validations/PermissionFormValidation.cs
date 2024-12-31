using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;
using FluentValidation;

namespace PresentationLayer.Validations
{
    public  class PermissionFormValidation : AbstractValidator<Menu>
    {
        public PermissionFormValidation() 
        {
            RuleFor(menu => menu.name)
            .NotEmpty().WithMessage("El nombre del menú es obligatorio.")
            .Length(3, 100).WithMessage("El nombre del menú debe tener entre 3 y 100 caracteres.");

            RuleFor(menu => menu.NameForm)
                .NotEmpty().WithMessage("El nombre del formulario es obligatorio.")
                .Length(3, 100).WithMessage("El nombre del formulario debe tener entre 3 y 100 caracteres.");

        }
    }
}
