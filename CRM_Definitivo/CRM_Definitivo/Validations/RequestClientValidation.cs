using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities.Projects;
using FluentValidation;

namespace PresentationLayer.Validations
{
    public class RequestClientValidation : AbstractValidator<RequestProjects>
    {
        public RequestClientValidation()
        {
            RuleLevelCascadeMode = CascadeMode.Stop; 

            RuleFor(project => project.nameProject)
                .NotEmpty().WithMessage("El nombre del proyecto no puede estar vacío.")
                .Length(5, 50).WithMessage("El nombre del proyecto debe tener entre 5 y 50 caracteres.")
                .Matches("^[a-zA-ZÀ-ÿ\\s]+$").WithMessage("El nombre solo puede contener letras y espacios.");

            RuleFor(project => project.descriptionProject)
                .NotEmpty().WithMessage("La descripción del proyecto no puede estar vacía.")
                .MaximumLength(500).WithMessage("La descripción del proyecto no puede exceder los 500 caracteres.");
        }

    }
    
}
