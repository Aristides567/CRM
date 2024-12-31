using PresentationLayer.Forms;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Twilio.TwiML.Voice;
using FluentValidation.Results;
using System.Drawing;
using PresentationLayer.Validations;
using Microsoft.Extensions.DependencyInjection;
using CommonLayer.Entities.Users;
using BusinessLayer.Services.InterfacesServices.InterfacesUser;



namespace PresentationLayer
{
    public partial class NewAccountForm : Form
    {
        private readonly IEmployeeServices _usersServices;
        private readonly IAdminsServices _adminsServices;
        byte[] imageBytes;


        public NewAccountForm(IEmployeeServices usersServices, IAdminsServices adminsServices)
        {
            InitializeComponent();
            _usersServices = usersServices;
            _adminsServices = adminsServices;
            LoadProvincias();

        }

        private void LoadProvincias()
        {
            List<string> ListaPaises = new List<string>
            {
                "El Salvador"

            };

            listCountrysComboBox.DataSource = ListaPaises;
            listCountrysComboBox.SelectedIndex = -1;
            List<string> ListaCiudad = new List<string>
            {
                "Ahuachapán",
                "Sonsonate",
                "Santa Ana",
                "La Libertad",
                "Chalatenango",
                "San Salvador",
                "Cuscatlán",
                "La Paz",
                "San Vicente",
                "Cabañas",
                "Usulután",
                "San Miguel",
                "Morazán",
                "La Unión"
            };
            listCityComboBox.DataSource = ListaCiudad;
            listCityComboBox.SelectedIndex = -1;
        }

        private void CleanFields()
        {
            nameTexBox.Text = "";
            lastNameTexBox.Text = "";
            birthdayDateTimePicker.Value = DateTime.Now;
            numberPhoneTextBox.Text = "";
            passwordTextBox.Text = "";
            listCountrysComboBox.SelectedIndex = -1;
            listCityComboBox.SelectedIndex = -1;
        }
        private void closedPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closedPictureBox_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(closedPictureBox, "Cerrar ventana");
        }

        private void minimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void minimizePictureBox_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(minimizePictureBox, "Minimizar ventana");
        }
        private void registerSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string userAccount = userNameTextBox.Text;

                if (_adminsServices.UserExists(userAccount))
                {
                    MessageBox.Show("El nombre de usuario ya está en uso. Por favor, elija otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                User newAccount = new User
                {
                    UserAccount = userAccount,
                    idRol = 4,
                    NameUser = nameTexBox.Text,
                    LastName = lastNameTexBox.Text,
                    Email = emailTextBox.Text,
                    Birthdate = birthdayDateTimePicker.Value,
                    NumberPhone = numberPhoneTextBox.Text,
                    passworduser = HashPassword(passwordTextBox.Text),
                    Country = (string)listCountrysComboBox.SelectedValue,
                    City = (string)listCityComboBox.SelectedValue,
                    Statususer = "Activo",
                    Image = imageBytes,
                    DateRegistration = DateTime.Now,
                };

                UserValidation newAccountValidation = new UserValidation();
                ValidationResult result = newAccountValidation.Validate(newAccount);

                if (!result.IsValid)
                {
                    DisplayValidationErrors(result);
                    return;
                }
                else
                {
                    _adminsServices.AddUsers(newAccount);
                    CleanFields();
                    ShowSuccessNotification(newAccount.UserAccount);
                    MessageBox.Show("La cuenta se ha creado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la cuenta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ShowSuccessNotification(string userName)
        {
            notifyIcon1.BalloonTipTitle = $"Bienvenido {userName}, usted se ha registrado correctamente a los Tilinazos77";
            notifyIcon1.BalloonTipText = "Ver detalles";
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.ShowBalloonTip(3000);
        }

        private string HashPassword(string password)
        {
            return password;
        }
        private void loginLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            //Esto no se toca que se modificara despues(si es que no me da hueva de hacerlo):)
            //System.Diagnostics.Process.Start("https://www.google.com");

            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://www.google.com",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la URL: " + ex.Message);
            }

        }

        private void selectImageUserLabel_Click(object sender, EventArgs e)
        {

            OpenFileDialog photoUser = new OpenFileDialog();
            photoUser.Filter = "Archivos de imagenes (*.png; *.jpg; *.jpeg; *.WEBP) | *.png; *.jpg; *.jpeg; *.WEBP";

            if (photoUser.ShowDialog() == DialogResult.OK)
            {
                photoNewUserPictureBox.Image = System.Drawing.Image.FromFile(photoUser.FileName);

                if (photoNewUserPictureBox.Image != null)
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        photoNewUserPictureBox.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                        imageBytes = memoryStream.ToArray();
                    }
                }
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
                    case nameof(User.UserAccount):
                        errorValidation.SetError(userNameTextBox, error.ErrorMessage);
                        errorUserLabel.Text = error.ErrorMessage;
                        break;
                    case nameof(User.NameUser):
                        errorValidation.SetError(nameTexBox, error.ErrorMessage);
                        errorUserNameLabel.Text = error.ErrorMessage;
                        break;
                    case nameof(User.LastName):
                        errorValidation.SetError(lastNameTexBox, error.ErrorMessage);
                        errorLastNameLabel.Text = error.ErrorMessage;
                        break;
                    case nameof(User.Email):
                        errorValidation.SetError(emailTextBox, error.ErrorMessage);
                        errorEmailLabel.Text = error.ErrorMessage;
                        break;
                    case nameof(User.Birthdate):
                        errorValidation.SetError(birthdayDateTimePicker, error.ErrorMessage);
                        errorBirthDayLabel.Text = error.ErrorMessage;
                        break;
                    case nameof(User.passworduser):
                        errorValidation.SetError(passwordTextBox, error.ErrorMessage);
                        errorPasswordLabel.Text = error.ErrorMessage;
                        break;
                    case nameof(User.NumberPhone):
                        errorValidation.SetError(numberPhoneTextBox, error.ErrorMessage);
                        errorPhoneNumberLabel.Text = error.ErrorMessage;
                        break;
                    case nameof(User.Country):
                        errorValidation.SetError(listCountrysComboBox, error.ErrorMessage);
                        errorCountryLabel.Text = error.ErrorMessage;
                        break;
                    case nameof(User.City):
                        errorValidation.SetError(listCityComboBox, error.ErrorMessage);
                        errorCityLabel.Text = error.ErrorMessage;
                        break;
                    case nameof(User.Image):
                        errorValidation.SetError(selectImageUserLabel, error.ErrorMessage);
                        errorSelectImagen.Text = error.ErrorMessage;
                        break;
                    default:
                        Console.WriteLine($"Error en un campo no reconocido: {error.PropertyName}");
                        break;
                }
            }
        }

        private void ResetErrorLabels()
        {
            errorUserLabel.Text = string.Empty;
            errorUserNameLabel.Text = string.Empty;
            errorLastNameLabel.Text = string.Empty;
            errorEmailLabel.Text = string.Empty;
            errorBirthDayLabel.Text = string.Empty;
            errorPasswordLabel.Text = string.Empty;
            errorPhoneNumberLabel.Text = string.Empty;
            errorCountryLabel.Text = string.Empty;
            errorCityLabel.Text = string.Empty;
            errorSelectImagen.Text = string.Empty;

            errorValidation.SetError(userNameTextBox, string.Empty);
            errorValidation.SetError(nameTexBox, string.Empty);
            errorValidation.SetError(lastNameTexBox, string.Empty);
            errorValidation.SetError(emailTextBox, string.Empty);
            errorValidation.SetError(birthdayDateTimePicker, string.Empty);
            errorValidation.SetError(passwordTextBox, string.Empty);
            errorValidation.SetError(numberPhoneTextBox, string.Empty);
            errorValidation.SetError(listCountrysComboBox, string.Empty);
            errorValidation.SetError(listCityComboBox, string.Empty);
            errorValidation.SetError(selectImageUserLabel, string.Empty);
        }

    }
}   