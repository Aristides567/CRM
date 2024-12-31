using BusinessLayer.Services.InterfacesServices.InterfacesUser;
using BusinessLayer.Services.Users;
using CommonLayer.Entities;
using CommonLayer.Entities.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class VerificationForm : Form
    {
        private string userAccount;
        private readonly User _user;
        private readonly EmailSettings _emailSettings;
        private readonly IEmployeeServices _usuarioServices;
        private readonly IAdminsServices _adminsServices;
        private DateTime _codeTime;

        public VerificationForm(User user, EmailSettings email, IEmployeeServices usuarioServices, IAdminsServices adminsServices, string _userAccount )
        {
            InitializeComponent();
            userAccount = _userAccount;
            _user = user;
            _emailSettings = email;
            _usuarioServices = usuarioServices;
            _adminsServices = adminsServices;
            _codeTime = DateTime.Now;

        }

        private string GenerateCodeVerification()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        public void HabilitarCambioContraseña()
        {
            if (verificationCodeTexBox.Text == _emailSettings.codigoVerificacion)
            {

                SetTimeVerificationGmail(_emailSettings.codigoVerificacion);
            }
        }

        public bool SetTimeVerificationGmail(string codeIngresado)
        {
            if (DateTime.Now - _codeTime > TimeSpan.FromMinutes(10))
            {
                MessageBox.Show("El codigo ha expirado, ha excedido el limite de 10 minutos establecido, mande una nueva solicitud");
                return false;
            }
            else if (codeIngresado != verificationCodeTexBox.Text)
            {
                Console.WriteLine("El código ingresado es incorrecto.");
                return false;
            }

            else
            {
                MessageBox.Show("Código correcto. Formulario de cambio de contraseña habilitado.");
                ChangePasswordForm changePasswordForm = new ChangePasswordForm(_user, _usuarioServices, _adminsServices);
                changePasswordForm.ShowDialog();
                this.Close();
                return true;
            }

        }


        private void iconVerifyButton_Click(object sender, EventArgs e)
        {
            if (_emailSettings.metodoVerificacion == "Correo")
            {
                HabilitarCambioContraseña();
            }
            else
            {
                if (DateTime.Now - _codeTime > TimeSpan.FromMinutes(10))
                {
                    MessageBox.Show("El codigo ha expirado, ha excedido el limite de 10 minutos establecido, mande una nueva solicitud");

                }
                else if (verificationCodeTexBox.Text == _user.VerificationCode.ToString())
                {
                    ChangePasswordForm changePasswordForm = new ChangePasswordForm(_user, _usuarioServices, _adminsServices);
                    changePasswordForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Código incorrecto. Inténtalo de nuevo.");
                }
            }
        }

        private void linkVerificationEmailLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _emailSettings.metodoVerificacion = "Correo";

            _emailSettings.codigoVerificacion = GenerateCodeVerification();

            var user = _adminsServices.GetUsers();

            var users = user.Where(u => u.UserAccount == userAccount).ToList();

            foreach (var getEmail in users)
            {
                var Email = getEmail.Email;
                _emailSettings.EmailDestino = Email;

            }

            //ya una vez creando los 3 datos que ocuparemos se va crear dos objetos para el mensaje y el otro para el enio del mensaje
            MailMessage mailMessage = new MailMessage(_emailSettings.EmailOrigen, _emailSettings.EmailDestino, "Recuperación de contraseña",
            $@"
            <p>Estimado/a {userAccount},</p>

            <p>Hemos recibido una solicitud para restablecer la contraseña de tu cuenta. Para completar el proceso de recuperación de contraseña, utiliza el siguiente código de verificación:</p>

            <p style='font-size: 18px; color: #2E86C1;'><b>{_emailSettings.codigoVerificacion}</b></p>

            <p>Por favor, introduce este código en la pantalla de verificación para restablecer tu contraseña y acceder nuevamente a tu cuenta. Este código es válido solo por un período limitado, por lo que te recomendamos que completes el proceso lo antes posible.</p>

            <p>Si no solicitaste restablecer tu contraseña, puedes ignorar este mensaje. La seguridad de tu cuenta es muy importante para nosotros, y ningún cambio será realizado sin tu autorización.</p>

            <p>Atentamente,</p>
            <p>Equipo de Soporte LosTilinazos77</p>

            <p style='font-size: 12px; color: #888;'>Este es un mensaje automático, por favor no respondas a este correo.</p>
            ");



            mailMessage.IsBodyHtml = true;

            SmtpClient smtpClient = new SmtpClient("smpt.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.Credentials = new System.Net.NetworkCredential(_emailSettings.EmailOrigen, _emailSettings.Contraseña);

            smtpClient.Send(mailMessage);

            smtpClient.Dispose();

            MessageBox.Show("Se le ha enviado correctamente el correo para restablecer la conraseña", "Restablecer contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
