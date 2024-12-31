using CommonLayer.Entities;
using DataAccessLayer.DbConnection;
using DataAccessLayer.Repositories;
using Microsoft.Extensions.DependencyInjection;
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
using FluentValidation;
using CommonLayer.Entities.Users;
using CommonLayer.Entities.ViewModel;
using BusinessLayer.Services.InterfacesServices.InterfacesUser;

namespace PresentationLayer.Forms.Cliente
{
    public partial class ProfileUserAccountForm : Form
    {
        private readonly ISqlDataAccess _dbConnection;
        private readonly IEmployeeServices _usersServices;
        private readonly IAdminsServices _adminsServices;
        private readonly IServiceProvider _serviceProvider;
        public ProfileUserAccountForm(ISqlDataAccess dbConnection, IServiceProvider serviceProvider, IEmployeeServices usersServices, IAdminsServices adminsServices)
        {
            InitializeComponent();
            _dbConnection = dbConnection;
            _serviceProvider = serviceProvider;
            LoadProvincias();
            _usersServices = usersServices;
            _adminsServices = adminsServices;
            LoadData();
            LoadImageInPictureBox(CaptureData.idUser);

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, pictureBoxProfileUser.Width, pictureBoxProfileUser.Height);

            pictureBoxProfileUser.Region = new Region(path);
        }


        private void LoadProvincias()
        {
            List<string> ListaPaises = new List<string>
            {
                "El Salvador"

            };

            listCountryComboBox.DataSource = ListaPaises;
            listCountryComboBox.SelectedIndex = -1;
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


        private void LoadData()
        {
            int idUser = CaptureData.idUser;
            var capture = _adminsServices.GetByIdUser(idUser).Where(u => u.IdUser == idUser).ToList();

            foreach (var user in capture)
            {
                //informacion del usuario
                userNameTextBox.Text = user.UserAccount;
                nameTextBox.Text = user.NameUser;
                lastNameTextBox.Text = user.LastName;
                phoneNumberTextBox.Text = user.NumberPhone;
                birthdayDateTimePicker.Value = user.Birthdate;

                //residencia del usuario
                listCountryComboBox.Text = user.Country;
                listCityComboBox.Text = user.City;
            }
        }

        private void LoadImageInPictureBox(int idUser)
        {
            var repo = _adminsServices.GetProfileImage(idUser);
            byte[] imageBytes = repo;

            if (imageBytes != null && imageBytes.Length > 0)
            {
                using (var memoryStream = new MemoryStream(imageBytes))
                {
                    pictureBoxProfileUser.Image = Image.FromStream(memoryStream);
                }
            }
            else
            {
                pictureBoxProfileUser.Image = Properties.Resources.user_icon_icons_com_57997;
            }
        }


        private void photoProfileChangeUserLabel_Click(object sender, EventArgs e)
        {
            OpenFileDialog PhotoProfileUser = new OpenFileDialog();
            PhotoProfileUser.Filter = "Archivos de imagen (*.png; *.jpg; *.jpeg)|*.png;*.jpg;*.jpeg";

            if (PhotoProfileUser.ShowDialog() == DialogResult.OK)
            {
                pictureBoxProfileUser.Image = Image.FromFile(PhotoProfileUser.FileName);

                byte[] imageBytes;
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    pictureBoxProfileUser.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                    imageBytes = memoryStream.ToArray();
                }

                var imageProfile = new User
                {
                    UserAccount = userNameTextBox.Text,
                    IdUser = CaptureData.idUser,
                    NameUser = nameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    NumberPhone = phoneNumberTextBox.Text,
                    Email = CaptureData.Email,
                    Birthdate = birthdayDateTimePicker.Value,
                    passworduser = CaptureData.Password,
                    Statususer = "Activo",
                    Country = listCountryComboBox.SelectedValue?.ToString(),
                    City = listCityComboBox.SelectedValue?.ToString(),
                    Image = imageBytes
                };

                _adminsServices.EditAccountUser(imageProfile);
                LoadData();

            }
        }

        private void saveProfileButton_Click(object sender, EventArgs e)
        {
            byte[] imageBytes;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                pictureBoxProfileUser.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                imageBytes = memoryStream.ToArray();
            }

            var saveProfile = new User()
            {
                UserAccount = userNameTextBox.Text,
                IdUser = CaptureData.idUser,
                NameUser = nameTextBox.Text,
                LastName = lastNameTextBox.Text,
                NumberPhone = phoneNumberTextBox.Text,
                Email = CaptureData.Email,
                Birthdate = birthdayDateTimePicker.Value,
                passworduser = CaptureData.Password,
                Statususer = "Activo",
                Image = imageBytes,
                Country = listCountryComboBox.SelectedValue?.ToString(),
                City = listCityComboBox.SelectedValue?.ToString(),
            };

            UserValidation editProfileValidation = new UserValidation();
            ValidationResult result = editProfileValidation.Validate(saveProfile);

            if (!result.IsValid)
            {
                DisplayValidationErrors(result);
                return; 
            }

            _adminsServices.EditAccountUser(saveProfile);

            MessageBox.Show("Perfil actualizado correctamente!");

            userNameTextBox.Text = saveProfile.UserAccount;
            nameTextBox.Text = saveProfile.NameUser;
            lastNameTextBox.Text = saveProfile.LastName;
            phoneNumberTextBox.Text = saveProfile.NumberPhone;
            birthdayDateTimePicker.Value = saveProfile.Birthdate;

            listCountryComboBox.Text = saveProfile.Country;
            listCityComboBox.Text = saveProfile.City;
        }
        private void changePasswordProfileLabel_Click(object sender, EventArgs e)
        {
            var ChangePasswordProfile = _serviceProvider.GetRequiredService<ChangePasswordProfileForm>();
            ChangePasswordProfile.ShowDialog();
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
                        errorUserNameLabel.Text = error.ErrorMessage;
                        break;
                    case nameof(User.NameUser):
                        errorValidation.SetError(nameTextBox, error.ErrorMessage);
                        errorNameLabel.Text = error.ErrorMessage;
                        break;
                    case nameof(User.LastName):
                        errorValidation.SetError(lastNameTextBox, error.ErrorMessage);
                        errorLastNameLabel.Text = error.ErrorMessage;
                        break;
                    case nameof(User.Birthdate):
                        errorValidation.SetError(birthdayDateTimePicker, error.ErrorMessage);
                        errorBirthdayLabel.Text = error.ErrorMessage;
                        break;
                    case nameof(User.NumberPhone):
                        errorValidation.SetError(phoneNumberTextBox, error.ErrorMessage);
                        errorPhoneNumberLabel.Text = error.ErrorMessage;
                        break;
                    case nameof(User.Country):
                        errorValidation.SetError(listCountryComboBox, error.ErrorMessage);
                        errorCountryLabel.Text = error.ErrorMessage;
                        break;
                    case nameof(User.City):
                        errorValidation.SetError(listCityComboBox, error.ErrorMessage);
                        errorCityLabel.Text = error.ErrorMessage;
                        break;
                    default:
                        Console.WriteLine($"Error en un campo no reconocido: {error.PropertyName}");
                        break;
                }
            }
        }

        private void ResetErrorLabels()
        {
            errorNameLabel.Text = string.Empty;
            errorUserNameLabel.Text = string.Empty;
            errorLastNameLabel.Text = string.Empty;
            errorBirthdayLabel.Text = string.Empty;
            errorPhoneNumberLabel.Text = string.Empty;
            errorCountryLabel.Text = string.Empty;
            errorCityLabel.Text = string.Empty;

            errorValidation.SetError(userNameTextBox, string.Empty);
            errorValidation.SetError(nameTextBox, string.Empty);
            errorValidation.SetError(lastNameTextBox, string.Empty);
            errorValidation.SetError(birthdayDateTimePicker, string.Empty);
            errorValidation.SetError(phoneNumberTextBox, string.Empty);
            errorValidation.SetError(listCityComboBox, string.Empty);
            errorValidation.SetError(listCountryComboBox, string.Empty);
        }

        
    }
}
