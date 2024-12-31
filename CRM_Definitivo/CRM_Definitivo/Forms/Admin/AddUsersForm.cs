using BusinessLayer.Services;
using BusinessLayer.Services.InterfacesServices;
using BusinessLayer.Services.InterfacesServices.InterfacesUser;
using CommonLayer.Entities.Users;
using CommonLayer.Entities.ViewModel;
using FluentValidation.Results;
using Microsoft.Extensions.DependencyInjection;
using PresentationLayer.Forms.Admin;
using PresentationLayer.Resources;
using PresentationLayer.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class AddUsersForm : Form
    {
        private readonly IEmployeeServices _employeeSservices;
        private readonly IAdminsServices _adminsServices;
        private readonly IClientsServices _clientsServices;
        private IRolServices rolServices;
        private readonly IProjectsServices _proyectsServices;
        private readonly IProjectsClientServices _projectsClientServices;
        private UsersForm _formularioPrincipal;
        bool IsEditing = false;
        byte[] imageBytes;
        int idUser = CaptureData.idUser;
        private User _usuario;

        public AddUsersForm(IEmployeeServices employeeSservices, IAdminsServices adminsServices, IClientsServices clientsServices, IRolServices _rolServices, IProjectsServices proyectsServices, IProjectsClientServices projectsClientServices, User usuario = null)
        {
            InitializeComponent();
            _usuario = usuario;
            _employeeSservices = employeeSservices;
            _adminsServices = adminsServices;
            _clientsServices = clientsServices;
            IsEditing = usuario != null;
            rolServices = _rolServices;
            _proyectsServices = proyectsServices;
            _projectsClientServices = projectsClientServices;
            LoadProvincias();
            ConfigureForm();

            profilePictureBox.Image = Properties.Resources.user_icon_icons_com_57997;
        }

        private void ConfigureForm()
        {
            rolComboBox.DataSource = rolServices.GetRol();
            rolComboBox.DisplayMember = "Rol";
            rolComboBox.ValueMember = "idRol";

            if (IsEditing)
            {
                rolComboBox.SelectedValue = _usuario.idRol;
                nameUserTextBox.Text = _usuario.UserAccount;
                emailTextBox.Text = _usuario.Email;
                nameTextBox.Text = _usuario.NameUser;
                lastNameTextBox.Text = _usuario.LastName;
                birthdateDateTimePicker.Value = _usuario.Birthdate;
                numberPhoneTextBox.Text = _usuario.NumberPhone;
                passwordTextBox.Text = _usuario.passworduser;
                imageBytes = _usuario.Image;


                if (imageBytes != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        profilePictureBox.Image = Image.FromStream(ms);
                    }
                }


                if (countrysComboBox.Items.Count > 0)
                {
                    countrysComboBox.SelectedItem = _usuario.Country;
                }

                if (cityListComboBox.Items.Count > 0)
                {
                    cityListComboBox.SelectedItem = _usuario.City;
                }

                statusComboBox.SelectedItem = _usuario.Statususer;

                saveButton.Visible = false;
                editButton.Visible = true;

                addUserLabel.Text = "Editar Usuario";
            }
            else
            {
                saveButton.Visible = true;
                editButton.Visible = false;
            }
        }


        private void ClearFields()
        {
            nameUserTextBox.Clear();
            nameTextBox.Clear();
            lastNameTextBox.Clear();
            numberPhoneTextBox.Clear();
            passwordTextBox.Clear();

            countrysComboBox.SelectedIndex = -1;
            cityListComboBox.SelectedIndex = -1;
            statusComboBox.SelectedIndex = -1;
            rolComboBox.SelectedIndex = -1;
        }


        public void LoadProvincias()
        {

            List<string> Estado = new List<string>()
            {
                "Activo",
                "Inactivo"
            };

            statusComboBox.DataSource = Estado;
            statusComboBox.SelectedIndex = -1;

            List<string> ListaPaises = new List<string>()
            {
                "El Salvador"
            };

            countrysComboBox.DataSource = ListaPaises;
            countrysComboBox.SelectedIndex = -1;



            List<string> ListaCiudad = new List<string>()
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

            cityListComboBox.DataSource = ListaCiudad;
            cityListComboBox.SelectedIndex = -1;
        }

        private void AddUsersForm_Load(object sender, EventArgs e)
        {

        }

        public event EventHandler AddUsuario;
        public event EventHandler EditUsuariosHandler;

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                User newAccount = new User()
                {
                    UserAccount = nameUserTextBox.Text,
                    Email = emailTextBox.Text,
                    idRol = Convert.ToInt32(rolComboBox.SelectedValue),
                    NameUser = nameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    Birthdate = birthdateDateTimePicker.Value,
                    NumberPhone = numberPhoneTextBox.Text,
                    passworduser = passwordTextBox.Text,
                    Country = (string)countrysComboBox.SelectedValue,
                    City = (string)cityListComboBox.SelectedValue,
                    Statususer = (string)statusComboBox.SelectedValue,
                    Image = imageBytes,
                    DateRegistration = DateTime.Now
                };

                UserValidation newAccountValidation = new UserValidation();
                ValidationResult result = newAccountValidation.Validate(newAccount);

                if (!result.IsValid)
                {
                    DisplayValidationErrors(result);
                    return;
                }

                _adminsServices.AddUsers(newAccount);

                MessageBox.Show("La cuenta se ha creado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProvincias();
                AddUsuario?.Invoke(this, EventArgs.Empty);

                var UpdateWorkstation = new Employees
                {
                    workStation = workStationTextBox.Text,
                    comment = professionsTextBox.Text,
                };

                _employeeSservices.UpdateWorkstation(UpdateWorkstation);

                AddUsuario?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la cuenta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (rolComboBox.SelectedValue == null || Convert.ToInt32(rolComboBox.SelectedValue) <= 0)
                {
                    MessageBox.Show("Debe seleccionar un rol válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _usuario.UserAccount = nameUserTextBox.Text;
                _usuario.Email = emailTextBox.Text;
                _usuario.idRol = Convert.ToInt32(rolComboBox.SelectedValue);
                _usuario.NameUser = nameTextBox.Text;
                _usuario.LastName = lastNameTextBox.Text;
                _usuario.Birthdate = birthdateDateTimePicker.Value;
                _usuario.NumberPhone = numberPhoneTextBox.Text;
                _usuario.passworduser = passwordTextBox.Text;
                _usuario.Country = (string)countrysComboBox.SelectedValue;
                _usuario.City = (string)cityListComboBox.SelectedValue;
                _usuario.Statususer = (string)statusComboBox.SelectedValue;

                

                _usuario.DateRegistration = DateTime.Now;

                UserValidation newAccountValidation = new UserValidation();
                ValidationResult result = newAccountValidation.Validate(_usuario);

                if (!result.IsValid)
                {
                    DisplayValidationErrors(result);
                    return;
                }

                _adminsServices.EditUsers(_usuario);

                MessageBox.Show("Usuario editado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                EditUsuariosHandler?.Invoke(this, EventArgs.Empty);

                ClearFields();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void rolComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecteRol = rolComboBox.Text;
            if (IsEditing == true)
            {
                if (rolComboBox.SelectedItem != null && rolComboBox.Text == "Empleado")
                {
                    professionsTextBox.Visible = true;
                    workStationTextBox.Visible = true;
                    professionLabel.Visible = true;
                    workStationLabel.Visible = true;

                    errorProfessionLabel.Visible = true;
                    errorWorkStationLabel.Visible = true;

                    var infoEmployee = _employeeSservices.GetEmployees().Where(id => id.idUser == _usuario.IdUser).FirstOrDefault();

                    if(infoEmployee != null)
                    {
                        professionsTextBox.Text = infoEmployee.comment;
                        workStationTextBox.Text = infoEmployee.workStation;
                    }                  
                }
                else
                {
                    professionsTextBox.Visible = false;
                    workStationTextBox.Visible = false;
                    professionLabel.Visible = false;
                    workStationLabel.Visible = false;

                    errorProfessionLabel.Visible = false;
                    errorWorkStationLabel.Visible = false;
                }
            }
            else
            {
                if (rolComboBox.SelectedItem != null && rolComboBox.Text == "Empleado")
                {
                    professionsTextBox.Visible = true;
                    workStationTextBox.Visible = true;
                    professionLabel.Visible = true;
                    workStationLabel.Visible = true;

                    errorProfessionLabel.Visible = true;
                    errorWorkStationLabel.Visible = true;
                }
                else
                {
                    professionsTextBox.Visible = false;
                    workStationTextBox.Visible = false;
                    professionLabel.Visible = false;
                    workStationLabel.Visible = false;

                    errorProfessionLabel.Visible = false;
                    errorWorkStationLabel.Visible = false;
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
                        errorValidation.SetError(nameUserTextBox, error.ErrorMessage);
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
                    case nameof(User.Email):
                        errorValidation.SetError(emailTextBox, error.ErrorMessage);
                        errorEmailLabel.Text = error.ErrorMessage;
                        break;
                    case nameof(User.Birthdate):
                        errorValidation.SetError(birthdateDateTimePicker, error.ErrorMessage);
                        errorBirthdayLabel.Text = error.ErrorMessage;
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
                        errorValidation.SetError(countrysComboBox, error.ErrorMessage);
                        errorCountryLabel.Text = error.ErrorMessage;
                        break;
                    case nameof(User.City):
                        errorValidation.SetError(cityListComboBox, error.ErrorMessage);
                        errorCityLabel.Text = error.ErrorMessage;
                        break;
                    case nameof(User.Rol):
                        errorValidation.SetError(rolComboBox, error.ErrorMessage);
                        errorRolLabel.Text = error.ErrorMessage;
                        break;
                    case nameof(User.Statususer):
                        errorValidation.SetError(statusComboBox, error.ErrorMessage);
                        errorStatusLabel.Text = error.ErrorMessage;
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
            errorEmailLabel.Text = string.Empty;
            errorBirthdayLabel.Text = string.Empty;
            errorPasswordLabel.Text = string.Empty;
            errorPhoneNumberLabel.Text = string.Empty;
            errorCountryLabel.Text = string.Empty;
            errorCityLabel.Text = string.Empty;
            errorRolLabel.Text = string.Empty;
            errorStatusLabel.Text = string.Empty;
            errorSelectImagenLabel.Text = string.Empty;


            errorValidation.SetError(nameUserTextBox, string.Empty);
            errorValidation.SetError(nameTextBox, string.Empty);
            errorValidation.SetError(lastNameTextBox, string.Empty);
            errorValidation.SetError(emailTextBox, string.Empty);
            errorValidation.SetError(birthdateDateTimePicker, string.Empty);
            errorValidation.SetError(passwordTextBox, string.Empty);
            errorValidation.SetError(numberPhoneTextBox, string.Empty);
            errorValidation.SetError(countrysComboBox, string.Empty);
            errorValidation.SetError(cityListComboBox, string.Empty);
            errorValidation.SetError(rolComboBox, string.Empty);
            errorValidation.SetError(statusComboBox, string.Empty);
            //errorValidation.SetError(profileLinkLabel, string.Empty);
        }

        public int GetidEmployee()
        {
            return Convert.ToInt32(_employeeSservices.GetByIdEmployees(_usuario.IdUser).Select(employee => employee.idEmployee).FirstOrDefault());
        }

        public int GetIdClient()
        {
            return Convert.ToInt32(_clientsServices.GetClients().Where(id => id.idUser == _usuario.IdUser).Select(client => client.idCliente).FirstOrDefault());
        }

        private void DesactiveEmpleoyeeiconButton_Click(object sender, EventArgs e)
        {
            if (_usuario.idRol == 2)
            {
                int idEmployee = GetidEmployee();
                var getTasks = _proyectsServices.GetByIdTaskEmployee(idEmployee).ToList();
                bool taskPending = getTasks.Any(t => t.idStatusTask == 1);

                if (taskPending)
                {
                    MessageBox.Show($"El usuario {_usuario.UserAccount} aun tiene tareas pendientes");
                }
                else
                {
                    var Messageconfirm = MessageBox.Show($"Desea desactivar la cuenta de el usuario {_usuario.UserAccount}?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (Messageconfirm == DialogResult.OK)
                    {
                        int idUser = _usuario.IdUser;
                        string status = "Desactivado";
                        _adminsServices.UpdateStatusUser(idUser, status);
                    }
                }
            }
            else if (_usuario.idRol == 4)
            {
                var idClient = GetIdClient();
                var getProjects = _projectsClientServices.GetsProjectsByIdClient(idClient).ToList();

                bool projectsPending = getProjects.Any(status => status.statusProject == "Terminado");

                if (projectsPending)
                {
                    var Messageconfirm = MessageBox.Show($"Desea desactivar la cuenta de el usuario {_usuario.UserAccount}?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); int idUser = _usuario.IdUser;

                    if (Messageconfirm == DialogResult.OK)
                    {
                        string status = "Desactivado";
                        _adminsServices.UpdateStatusUser(idUser, status);
                    }
                }
                else
                {
                    MessageBox.Show($"No se puede desactivar el usuario {_usuario.UserAccount}, aun tiene proyectos pendientes");
                }
            }
        }

        
    }
}
