using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities.Projects;
using FluentValidation;

namespace PresentationLayer.Validations
{
    public class AssignamentTaskEmployeeValidation: AbstractValidator<TaskEmployees>
    {
        public AssignamentTaskEmployeeValidation() 
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(x => x.nameTask)
                .NotEmpty().WithMessage("El nombre de la tarea es obligatorio.")
                .Length(3, 100).WithMessage("El nombre de la tarea debe tener entre 3 y 100 caracteres.");

            RuleFor(x => x.descriptionTask)
                .NotEmpty().WithMessage("La descripción de la tarea es obligatoria.")
                .MaximumLength(500).WithMessage("La descripción de la tarea no debe exceder los 500 caracteres.");

            RuleFor(x => x.idEmployee)
                .GreaterThan(0).WithMessage("Debe seleccionar un empleado válido.");

            RuleFor(x => x.dateEnd)
                .GreaterThanOrEqualTo(DateTime.Now).WithMessage("La fecha de finalización no puede ser en el pasado.")
                .Must(date => date.Date > DateTime.Now.Date).WithMessage("La fecha de finalización debe ser después de hoy.");
        }
    }
}
