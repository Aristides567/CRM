using BusinessLayer.Services;
using BusinessLayer.Services.InterfacesServices;
using BusinessLayer.Services.InterfacesServices.InterfacesUser;
using BusinessLayer.Services.Users;
using CommonLayer.Entities.Users;
using DataAccessLayer.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using PresentationLayer.Reports;
using PresentationLayer.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class UsersForm : Form
    {
        private readonly IRolServices _rolservices;
        private readonly IEmployeeServices _employeesServices;
        private readonly IAdminsServices _adminsServices;
        private readonly IClientsServices _clientsServices;
        private readonly IUserReports _userReports;
        private readonly IProjectsServices _proyects;
        private readonly IProjectsClientServices _projectsClient;

        public UsersForm(IEmployeeServices employeeServices, IAdminsServices adminsServices, IClientsServices clientsServices, IRolServices rolServices, IProjectsServices proyectsServices, IProjectsClientServices projectsClientServices, IUserReports userReports)
        {
            InitializeComponent();
            _employeesServices = employeeServices;
            _adminsServices = adminsServices;
            _clientsServices = clientsServices;
            _rolservices = rolServices;
            _proyects = proyectsServices;
            _projectsClient = projectsClientServices;           
            _userReports = userReports;
            LoadData();

        }

        private void LoadData()
        {
            userDataGridView.DataSource = _adminsServices.GetUsers();
            ConfigureDataGridView();
            userDataGridView.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            userDataGridView.DefaultCellStyle.ForeColor = Color.Black;
            userDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            userDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            userDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            userDataGridView.EnableHeadersVisualStyles = false;

            userDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            userDataGridView.Columns["idUser"].Visible = false;
            userDataGridView.Columns["Image"].Visible = false;
            userDataGridView.Columns["idRol"].Visible = false;
            userDataGridView.Columns["VerificationCode"].Visible = false;

            foreach (DataGridViewColumn column in userDataGridView.Columns)
            {
                if (column.Visible == true && column.Index != 0)
                {
                    searchUserscomboBox.Items.Add(new OpcionCombo() { Valor = column.Name, Texto = column.HeaderText });
                }
            }

            searchUserscomboBox.DisplayMember = "Texto";
            searchUserscomboBox.ValueMember = "Valor";
            searchUserscomboBox.SelectedIndex = 0;


        }

        private void SetNamesColumns(DataGridView dataGridView, Dictionary<string, string> columNames)
        {
            foreach(DataGridViewColumn column in dataGridView.Columns)
            {
                if (columNames.ContainsKey(column.Name))
                {
                    column.HeaderText = columNames[column.Name];
                }
            }
        }

        private void ConfigureDataGridView()
        {
            var columnsNewName = new Dictionary<string, string>
            {
                { "UserAccount", "Usario" },
                { "Rol", "Rol" },
                { "NameUser", "Nombre" },
                { "LastName", "Apellido" },
                { "Email", "Correo" },
                { "NumberPhone", "Contacto" },
                { "passworduser", "Clave" },
                { "Country", "Pais" },
                { "City", "Ciudad" },
                { "Statususer", "Estado" },
                { "dateRegistration", "Registro" }
            };

            SetNamesColumns(userDataGridView, columnsNewName);
        }

        private void AbrirFormulario(Form formulario)
        {
            formulario.Show();
        }

        private void addUserPictureBox_Click(object sender, EventArgs e)
        {
            AddUsersForm formularioAñadir = new AddUsersForm(_employeesServices, _adminsServices, _clientsServices, _rolservices, _proyects, _projectsClient);

            formularioAñadir.AddUsuario += (s, args) =>
            {
                LoadData();
            };

            AbrirFormulario(formularioAñadir);
        }
        private void editUserPictureBox_Click(object sender, EventArgs e)
        {
            if (userDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un usuario para editar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow filaSeleccionada = userDataGridView.SelectedRows[0];
            User usuarioSeleccionado = new User
            {
                IdUser = Convert.ToInt32(filaSeleccionada.Cells["idUser"].Value),
                idRol = Convert.ToInt32(filaSeleccionada.Cells["idRol"].Value.ToString()),
                UserAccount = filaSeleccionada.Cells["UserAccount"].Value.ToString(),
                NameUser = filaSeleccionada.Cells["nameuser"].Value.ToString(),
                LastName = filaSeleccionada.Cells["lastName"].Value.ToString(),
                Birthdate = Convert.ToDateTime(filaSeleccionada.Cells["birthdate"].Value),
                NumberPhone = filaSeleccionada.Cells["numberPhone"].Value.ToString(),
                passworduser = filaSeleccionada.Cells["passworduser"].Value.ToString(),
                Country = filaSeleccionada.Cells["country"].Value.ToString(),
                City = filaSeleccionada.Cells["city"].Value.ToString(),
                Statususer = filaSeleccionada.Cells["statususer"].Value.ToString(),
                Email = filaSeleccionada.Cells["Email"].Value.ToString()
            };

            AddUsersForm editarUsuarioForm = new AddUsersForm(_employeesServices, _adminsServices, _clientsServices, _rolservices, _proyects, _projectsClient , usuarioSeleccionado);
            editarUsuarioForm.EditUsuariosHandler += (s, args) => LoadData();

            AbrirFormulario(editarUsuarioForm);
        }

        private void deleteUserPictureBox_Click(object sender, EventArgs e)
        {
            if (userDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un usuario para eliminar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var eliminarConfirmar = MessageBox.Show(
                "¿Está seguro de que desea eliminar este usuario?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (eliminarConfirmar == DialogResult.Yes)
            {
                int idUser = Convert.ToInt32(userDataGridView.CurrentRow.Cells["idUser"].Value);
                _adminsServices.DeleteUsers(idUser);
                LoadData();
            }
        }

        private void PdfUserPictureBox_Click(object sender, EventArgs e)
        {
            _userReports.GenerateReports();
        }

        private void searchUserIconButton_Click(object sender, EventArgs e)
        {
            string columnFilter = ((OpcionCombo)searchUserscomboBox.SelectedItem).Valor.ToString();
            bool encontrado = false;

            if (userDataGridView.Rows.Count > 0)
            {
                userDataGridView.CurrentCell = null;

                foreach (DataGridViewRow row in userDataGridView.Rows)
                {
                    if (row.Cells[columnFilter].Value != null &&
                        row.Cells[columnFilter].Value.ToString().Trim().ToUpper().Contains(searchUserTextBox.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                        encontrado = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }

                if (!encontrado)
                {
                    MessageBox.Show($"No existe un proyecto llamado {searchUserTextBox.Text}", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cleanSearchUserIconButton_Click(object sender, EventArgs e)
        {
            searchUserTextBox.Clear();

            foreach (DataGridViewRow row in userDataGridView.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
