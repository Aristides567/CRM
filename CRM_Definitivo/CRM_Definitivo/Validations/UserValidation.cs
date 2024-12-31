using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities.Users;
using FluentValidation;

namespace PresentationLayer.Validations
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation() 
        {
            RuleLevelCascadeMode = CascadeMode.Stop;
            RuleFor(user => user.UserAccount)
                .NotEmpty().WithMessage("El nombre de usuario es obligatorio.")
                .Length(3, 20).WithMessage("El nombre de usuario debe tener entre 3 y 20 caracteres.")
                .Matches("^[a-zA-Z0-9._]+$").WithMessage("El nombre de usuario solo puede contener letras, números, puntos y guiones bajos.");

            RuleFor(user => user.NameUser)
                .NotEmpty().WithMessage("El nombre es obligatorio.")
                .Length(3, 50).WithMessage("El nombre debe tener entre 3 y 50 caracteres.")
                .Matches("^[a-zA-ZÀ-ÿ\\s]+$").WithMessage("El nombre solo puede contener letras y espacios.");

            RuleFor(user => user.LastName)
                .NotEmpty().WithMessage("El apellido es obligatorio.")
                .Length(3, 50).WithMessage("El apellido debe tener entre 3 y 50 caracteres.")
                .Matches("^[a-zA-ZÀ-ÿ\\s]+$").WithMessage("El apellido solo puede contener letras y espacios.");

            RuleFor(user => user.Email)
                .NotEmpty().WithMessage("El correo electrónico es obligatorio.")
                .EmailAddress().WithMessage("El formato del correo electrónico es inválido.");

            RuleFor(user => user.NumberPhone)
                .NotEmpty().WithMessage("El número de teléfono es obligatorio.")
                .Matches(@"^[\d\+\-]+$").WithMessage("El número de teléfono solo puede contener números, + y -.");

            RuleFor(user => user.passworduser)
                .NotEmpty().WithMessage("La contraseña es obligatoria.")
                .MinimumLength(8).WithMessage("La contraseña debe tener al menos 8 caracteres.")
                .Matches(@"[A-Z]").WithMessage("La contraseña debe incluir al menos una letra mayúscula.")
                .Matches(@"[a-z]").WithMessage("La contraseña debe incluir al menos una letra minúscula.")
                .Matches(@"\d").WithMessage("La contraseña debe incluir al menos un número.")
                .Matches(@"[\W_]").WithMessage("La contraseña debe incluir al menos un carácter especial.");

            RuleFor(user => user.Country)
                .NotEmpty().WithMessage("Debe seleccionar un país.")
                .Must(country => country != "Seleccione un país").WithMessage("Debe seleccionar un país válido.");

            RuleFor(user => user.City)
                .NotEmpty().WithMessage("Debe seleccionar una ciudad.")
                .Must(city => city != "Seleccione una ciudad").WithMessage("Debe seleccionar una ciudad válida.");


            RuleFor(user => user.Birthdate)
                .Must(date => date != DateTime.MinValue).WithMessage("Debe seleccionar una fecha de nacimiento.")
                .Must(date => date <= DateTime.Now).WithMessage("La fecha de nacimiento no puede estar en el futuro.")
                .Must(date => date.Date != DateTime.Now.Date).WithMessage("La fecha de nacimiento no puede ser hoy.");


            //RuleFor(user => user.Image)
            //    .NotEmpty().WithMessage("Debe cargar una imagen de perfil.")
            //    .Must(image => image.Length > 0).WithMessage("La imagen no puede estar vacía.");

        }
    }
}
