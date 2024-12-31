using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation.Results;
using PresentationLayer.Validations;
using CommonLayer.Entities.Users;
using CommonLayer.Entities.ViewModel;
using BusinessLayer.Services.InterfacesServices.InterfacesUser;

namespace PresentationLayer.Forms
{
    public partial class ChangePasswordProfileForm : Form
    {
        private readonly IEmployeeServices _services;
        private readonly IAdminsServices _adminsServices;
        private readonly User _user;
        public ChangePasswordProfileForm(User user, IEmployeeServices services, IAdminsServices adminsServices)
        {
            InitializeComponent();
            _services = services;
            _user = user;
            _adminsServices = adminsServices;
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            if (CaptureData.Password == currentPasswordTextBox.Text)
            {
                if (newPasswordTextBox.Text == confirmPasswordTextBox.Text)
                {
                    _user.IdUser = CaptureData.idUser;
                    _user.passworduser = newPasswordTextBox.Text;


                    UserValidation changePasswordValidation = new UserValidation();
                    ValidationResult result = changePasswordValidation.Validate(_user);
                    if (!result.IsValid)
                    {
                        DisplayValidationErrors(result);
                        return;
                    }

                    _adminsServices.ChangePassword(_user);

                    MessageBox.Show("La contraseña se ha cambiado correctamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden.");
                }
            }
            else
            {
                MessageBox.Show("La contraseña actual es incorrecta.");
            }
        }


        private void DisplayValidationErrors(ValidationResult result)
        {
            errorValidation.Clear();
            ResetErrorLabels();

            foreach (var error in result.Errors)
            {
                switch (error.PropertyName)
                {
                    case nameof(User.passworduser):
                        errorValidation.SetError(newPasswordTextBox, error.ErrorMessage);
                        errorNewPasswordLabel.Text = error.ErrorMessage;
                        break;
                    default:
                        Console.WriteLine($"Error en un campo no reconocido: {error.PropertyName}");
                        break;
                }
            }
        }

        private void ResetErrorLabels()
        {
            errorNewPasswordLabel.Text = string.Empty;
            errorValidation.SetError(newPasswordTextBox, string.Empty);
        }
    }
}
