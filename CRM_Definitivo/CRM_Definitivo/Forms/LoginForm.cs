using System.Data;
using BusinessLayer;
using BusinessLayer.Services;
using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities;
using PresentationLayer.Forms;
using PresentationLayer;
using PresentationLayer.Reports;
using PresentationLayer.Forms.Cliente;
using Microsoft.Extensions.DependencyInjection;
using Twilio.Types;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using System.Net.Mail;
using CommonLayer.Entities.ViewModel;
using DataAccessLayer.Repositories.InterfacesRepositories.InterfacesUser;
using BusinessLayer.Services.InterfacesServices.InterfacesUser;


namespace CRM_Definitivo
{
    public partial class LoginForm : Form
    {
        private readonly IProjectsServices proyectoServices;
        private readonly IEmployeeRepositories usuarioRepositories;
        private readonly IEmployeeServices usuarioServices;
        private readonly IAdminsServices _adminsServices;
        private readonly IUserReports _userReports;
        private readonly IRolServices _rolServices;
        private readonly IServiceProvider _serviceProvider;

        private readonly EmailSettings _emailSettings;

        public LoginForm(IServiceProvider serviceProvider, IEmployeeRepositories _usuarioRepositories, IAdminsServices adminsServices, IEmployeeServices _usuarioServices, IRolServices rolServices, IProjectsServices _proyectoServices, IUserReports userReports, EmailSettings emailSettings)
        {
            InitializeComponent();
            usuarioRepositories = _usuarioRepositories;
            usuarioServices = _usuarioServices;
            _adminsServices = adminsServices;
            _rolServices = rolServices;
            proyectoServices = _proyectoServices;
            _userReports = userReports;
            _serviceProvider = serviceProvider;
            _emailSettings = emailSettings;

        }

        private void closedPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void closedPictureBox_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(closedPictureBox, "Cerrar aplicación");
        }

        private void minimizePictureBox_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(minimizePictureBox, "Minimizar aplicación");
        }

        private void minimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void hidePictureBox_Click(object sender, EventArgs e)
        {
            hidePictureBox.Hide();
            passwordTextBox.UseSystemPasswordChar = true;
            showPictureBox.Show();
        }

        private void hidePictureBox_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(hidePictureBox, "Ocultar contraseña");
        }
        private void showPictureBox_Click(object sender, EventArgs e)
        {
            showPictureBox.Hide();
            passwordTextBox.UseSystemPasswordChar = false;
            hidePictureBox.Show();
        }

        private void showPictureBox_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(showPictureBox, "Mostrar contraseña");
        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            userTextBox.Text = "";
            passwordTextBox.Text = "";

            this.Show();
        }
        private void createAccountLabel_Click(object sender, EventArgs e)
        {
            NewAccountForm createAccount = new NewAccountForm(usuarioServices, _adminsServices);
            createAccount.FormClosing += createAccount_FormClosing;
            createAccount.ShowDialog();
        }

        private void createAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            var user = _adminsServices.Login(userTextBox.Text, passwordTextBox.Text);

            if (user != null)
            {
                CaptureData.idUser = user.IdUser;
                CaptureData.IdRol = user.idRol;
                CaptureData.UserAccount = user.UserAccount;
                CaptureData.NameUser = user.NameUser;
                CaptureData.LastName = user.LastName;
                CaptureData.Email = user.Email;
                CaptureData.DateBirth = user.Birthdate;
                CaptureData.NumberPhone = user.NumberPhone;
                CaptureData.Country = user.Country;
                CaptureData.City = user.City;
                CaptureData.Password = user.passworduser;

                if(user.Statususer == "Desactivado")
                {
                    MessageBox.Show("Su cuenta ha sido bloqueado/baneado por infligir las normas de la empresa", "Mensaje de sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var menuForm = _serviceProvider.GetRequiredService<MenuForm>();
                    this.Hide();
                    menuForm.ShowDialog();
                }              
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta, vuelva a intentarlo");
            }
        }

        private void fortgotPasswordLabel_Click(object sender, EventArgs e)
        {
            var user = _adminsServices.UserSearch(userTextBox.Text).FirstOrDefault();

            string idUserVerification = userTextBox.Text;
            if (user != null)
            {
                Random rnd = new Random();
                int verificationCode = rnd.Next(100000, 999999);

                SendVerificationCode(user.NumberPhone, verificationCode.ToString());

                user.VerificationCode = verificationCode;

                VerificationForm verificationForm = new VerificationForm(user, _emailSettings, usuarioServices, _adminsServices,  idUserVerification);
                verificationForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
            }
        }

        private void SendVerificationCode(string phoneNumber, string code)
        {
            try
            {
                string accountSid = "#"; //Ingresar aca el SID de Twilio;
                string authToken = "#"; //Ingresar aca el TOKEN de Twilio;
                TwilioClient.Init(accountSid, authToken);

                if (!phoneNumber.StartsWith("+"))
                {
                    phoneNumber = "+503" + phoneNumber;
                }

                var message = MessageResource.Create(
                    body: $"Tu código de verificación es: {code}",
                    from: new PhoneNumber("#"), //Ingresar el numero de telefono de Twilio
                    to: new PhoneNumber(phoneNumber)
                );

                MessageBox.Show("Mensaje enviado con SID: " + message.Sid);
            }
            catch (Twilio.Exceptions.ApiException ex)
            {
                MessageBox.Show("Error al enviar mensaje: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }
        
    }
}