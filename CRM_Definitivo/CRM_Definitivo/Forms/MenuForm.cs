using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities;
using FontAwesome.Sharp;
using PresentationLayer.Forms.Cliente;
using PresentationLayer.Forms.Empleados;
using Microsoft.VisualBasic;
using PresentationLayer.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using PresentationLayer.Forms.Admin;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Diagnostics.Metrics;
using CRM_Definitivo;
using BusinessLayer.Services;
using CommonLayer.Entities.ViewModel;
using BusinessLayer.Services.InterfacesServices.InterfacesUser;
using BusinessLayer.Services.Users;

namespace PresentationLayer.Forms
{
    public partial class MenuForm : Form
    {
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        private readonly IPermisoServices _permisosServices;
        private readonly IProjectsServices proyectoServices;
        private readonly IEmployeeServices _employeesServices;
        private readonly IAdminsServices _adminsServices;
        private readonly IClientsServices _clientsServices;
        private readonly IRolServices _rolServices;
        private readonly IServiceProvider _provider;
        private readonly IUserReports _userReports;
        private readonly IProjectsEmnployeesServices _projectsEmployeesServices;
        private readonly IProjectsClientServices _projectsClientServices;
        private System.Windows.Forms.Timer timer;

        public MenuForm(IPermisoServices services, IServiceProvider serviceProvider, IEmployeeServices employessServices, IAdminsServices adminsServices , IClientsServices clientsServices, IRolServices rolServices, IProjectsServices _proyectoServices, IProjectsEmnployeesServices projects , IProjectsClientServices projectsClientServices , IUserReports userReports)
        {

            InitializeComponent();
            LoadData();
            _permisosServices = services;
            _provider = serviceProvider;
            _employeesServices = employessServices;
            _adminsServices = adminsServices;
            _clientsServices = clientsServices;
            _rolServices = rolServices;
            proyectoServices = _proyectoServices;
            _projectsEmployeesServices = projects;
            _projectsClientServices = projectsClientServices;
            _userReports = userReports;
            LoadImageProfileUser(CaptureData.idUser);
            loadPermission();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_tick;
            timer.Start();

            Dateandtime();

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath pathSelectedUser = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, idUserPictureBox.Width, idUserPictureBox.Height);
            pathSelectedUser.AddEllipse(0, 0, selectedUserPictureBox.Width, selectedUserPictureBox.Height);

            idUserPictureBox.Region = new Region(path);
            selectedUserPictureBox.Region = new Region(pathSelectedUser);

        }

        public void loadPermission()
        {
            menuGroupBox.Visible = false;

            if (CaptureData.IdRol == 1)
            {
                menuGroupBox.Visible = true;
            }
            else if (CaptureData.IdRol == 2)
            {
                menuGroupBox.Controls.Clear();
                var HomeUserEmployeeForm = _provider.GetRequiredService<HomeUserEmployeeForm>();
                AbrirFormulario(HomeUserEmployeeForm);
            }
            else if (CaptureData.IdRol == 4)
            {
                menuGroupBox.Controls.Clear();
                var HomeUserClientForm = _provider.GetRequiredService<HomeUserClientForm>();
                AbrirFormulario(HomeUserClientForm);
            }
        }



        private void LoadImageProfileUser(int idUser)
        {
            var servicesUser = _adminsServices.GetProfileImage(idUser);
            byte[] imagebyte = servicesUser;

            if (imagebyte != null)
            {
                using (var memoryStream = new MemoryStream(imagebyte))
                {
                    idUserPictureBox.Image = Image.FromStream(memoryStream);

                }
            }
            else
            {
                idUserPictureBox.Image = Properties.Resources.user_icon_icons_com_57997;
            }
        }



        private void LoadData()
        {
            userDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        private void Dateandtime()
        {
            timeUserLabel.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            userAccountLabel.Text = CaptureData.UserAccount;
        }

        private void Timer_tick(object sender, EventArgs e)
        { 
            Dateandtime();
        }

        private List<Control> controlesIniciales;

        private void MenuForm_Load(object sender, EventArgs e)
        {
            nameUserIdLabel.Text = CaptureData.UserAccount;

            controlesIniciales = new List<Control>();
            foreach (Control control in containerPanel.Controls)
            {
                controlesIniciales.Add(control);
            }

            var permisions = _permisosServices.GetPermisos(CaptureData.idUser);

            foreach (IconMenuItem iconMenu in menu.Items)
            {
                bool econtrado = permisions.Any(m => m.NameForm == iconMenu.Name);

                if (econtrado == false)
                {

                    iconMenu.Visible = false;
                }
            }
        }

        private void logoutLabel_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void AbrirFormulario(Form formulario)
        {

            if (this.containerPanel.Controls.Count > 0)
                this.containerPanel.Controls.RemoveAt(0);

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            this.containerPanel.Controls.Add(formulario);
            this.containerPanel.Tag = formulario;

            formulario.Show();
        }
        private void closedPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void closedPictureBox_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(closedPictureBox, "Cerrar Aplicacion");
        }

        private void minimizarPictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimizarPictureBox_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(minimizarPictureBox, "Minimizar aplicacion");
        }

        private void iconMenuUsersForm_Click(object sender, EventArgs e)
        {
            var IconMenuUsersForm = _provider.GetRequiredService<UsersForm>();
            AbrirFormulario(IconMenuUsersForm);
        }

        private void iconMenuProyectsForm_Click_1(object sender, EventArgs e)
        {
            var IconMenuProyectsForm = _provider.GetRequiredService<ProjectsForm>();
            AbrirFormulario(IconMenuProyectsForm);
        }
        private void iconMenuRecordForm_Click(object sender, EventArgs e)
        {
            var iconMenuRecordForm = _provider.GetRequiredService<RecordProjectsForm>();
            AbrirFormulario(iconMenuRecordForm);
        }
        private void iconMenusSettingsForm_Click(object sender, EventArgs e)
        {

        }
        private void iconMenuAccountForm_Click(object sender, EventArgs e)
        {
            var IconMenuAccountForm = _provider.GetRequiredService<ProfileUserAccountForm>();
            AbrirFormulario(IconMenuAccountForm);
        }


        private void iconMenuItemMenus_Click(object sender, EventArgs e)
        {
            var iconMenuItemMenus = _provider.GetRequiredService<PermissionForm>();
            AbrirFormulario(iconMenuItemMenus);
        }

        private void RestoreInitialControls()
        {
            this.containerPanel.Controls.Clear();

            foreach (Control control in controlesIniciales)
            {
                this.containerPanel.Controls.Add(control);
            }
        }

        private void iconMenuItemHome_Click(object sender, EventArgs e)
        {
            RestoreInitialControls();
        }

        private void administratorUserButton_Click(object sender, EventArgs e)
        {
            userDataGridView.DataSource = _adminsServices.GetAdmins();
            ConfigureDataGridView();
            userDataGridView.Columns["idUser"].Visible = false;
            assignedProjectPanel.Visible = false;
            requestProjectPanel.Visible = false;
        }
        private void employeeUserButton_Click(object sender, EventArgs e)
        {
            userDataGridView.DataSource = _employeesServices.GetEmployees();
            ConfigureDataGridView();
            userDataGridView.Columns["idUser"].Visible = false;
            requestProjectPanel.Visible = false;
            assignedProjectPanel.Visible = true;
        }

        private void clientUserButton_Click(object sender, EventArgs e)
        {
            userDataGridView.DataSource = _clientsServices.GetClients();
            ConfigureDataGridView();
            userDataGridView.Columns["idUser"].Visible = false;
            assignedProjectPanel.Visible = false;
            requestProjectPanel.Visible = true;
        }

        private void ShowInfoEmployees()
        {
            infoEmployeelabel.Visible = true;
            professionEmployeeLabel.Visible = true;
            puestoLabel.Visible = true;
            commentEmployeeLabel.Visible = true;
            professionLabel.Visible = true;
            
        }
        private void HideInfoEmployees()
        {
            infoEmployeelabel.Visible = false;
            professionEmployeeLabel.Visible = false;
            puestoLabel.Visible = false;
            commentEmployeeLabel.Visible = false;
            professionLabel.Visible = false;

        }

        private void SetNamesColumns(DataGridView dataGridView, Dictionary<string, string> columNames)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (columNames.ContainsKey(column.Name))
                {
                    column.HeaderText = columNames[column.Name];
                }
            }
        }

        private void ConfigureDataGridView()
        {
            if(administratorUserButton_Click != null)
            {
                var columnsNewNameAdmin = new Dictionary<string, string>
                {
                    { "idAdmin", "ID" },
                    { "UserAccount", "Usuario" }
                };

                SetNamesColumns(userDataGridView, columnsNewNameAdmin);
            }
            else if (employeeUserButton_Click != null)
            {
                var columnsNewNameEmployee = new Dictionary<string, string>
                {
                    { "idEmployee", "ID" },
                    { "UserAccount", "Usuario " },
                    { "comment", "Profesion" },
                    { "workStation", "Puesto" }
                };

                SetNamesColumns(userDataGridView, columnsNewNameEmployee);
            }
            else if (clientUserButton_Click != null)
            {
                var columnsNewNameClient = new Dictionary<string, string>
                {
                    { "idCliente", "ID" },
                    { "UserAccount", "Usuario" }
                };

                SetNamesColumns(userDataGridView, columnsNewNameClient);
            }
            
        }

        private void userDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idUser = int.Parse(userDataGridView.CurrentRow.Cells[2].Value.ToString());


                HideInfoEmployees();
                panelUsersView.Visible = true;
                var users = _adminsServices.GetByIdUser(idUser);
                var image = _adminsServices.GetProfileImage(idUser);

                byte[] imageBytes = image;

                var SelectedUser = users.Where(u => u.IdUser == idUser).ToList();


                if (SelectedUser.Any())
                {
                    foreach (var user in SelectedUser)
                    {
                        DateTime fechaActual = DateTime.Now;
                        int edad = fechaActual.Year - user.Birthdate.Year;

                        if (fechaActual.Month < user.Birthdate.Month ||
                            (fechaActual.Month == user.Birthdate.Month && fechaActual.Day < user.Birthdate.Day))
                        {
                            edad--;
                        }

                        idUserLabel.Text = user.UserAccount;
                        ageUserLabel.Text = Convert.ToString(edad);
                        cityLabel.Text = user.City;
                        nameUserLabel.Text = user.NameUser;
                        emailIdUserLabel.Text = user.Email;
                        numberPhoneLabel.Text = user.NumberPhone;
                        registrationLabel.Text = Convert.ToString(user.DateRegistration);
                        countryUserLabel.Text = user.Country;

                        if (assignedProjectPanel.Visible == true)
                        {
                            ShowInfoEmployees();
                            var profession = userDataGridView.Rows[e.RowIndex].Cells["workStation"].Value?.ToString();
                            professionEmployeeLabel.Text = profession ?? "No tiene profesion";

                            var comment = userDataGridView.Rows[e.RowIndex].Cells["comment"].Value?.ToString();
                            commentEmployeeLabel.Text = comment ?? "No tiene profesion";

                            var GetidEmployee = _employeesServices.GetEmployees().Where(id => id.idUser == idUser).Select(e => e.idEmployee).FirstOrDefault();
                            var tasks = assignedProjectListBox.DataSource = _projectsEmployeesServices.GetTasksByEmployees(GetidEmployee).ToList();

                            assignedProjectListBox.DataSource = tasks;
                            assignedProjectListBox.DisplayMember = "nameTask"; 
                            assignedProjectListBox.ValueMember = "idTask";
                        }
                        else if (requestProjectPanel.Visible == true)
                        {
                            HideInfoEmployees();
                            var GetIdClient = Convert.ToInt32(_clientsServices.GetClients().Where(id => id.idUser == idUser).Select(id => id.idCliente).FirstOrDefault());
                            requestProjectListBox.DataSource = _projectsClientServices.GetRequestProyectsByIdClient(GetIdClient).ToList();
                        }

                        if (imageBytes != null && imageBytes.Length > 0)
                        {
                            using (var memoryStream = new MemoryStream(imageBytes))
                            {
                                selectedUserPictureBox.Image = Image.FromStream(memoryStream);
                            }
                        }
                        else
                        {
                            selectedUserPictureBox.Image = Properties.Resources.user_icon_icons_com_57997;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("usuario no econtrado");
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado a un usuario ");
            }
        }
        private void selectedUserPictureBox_Click(object sender, EventArgs e)
        {
            var ImageViewerForm = _provider.GetRequiredService<ImageViewerForm>();
            ImageViewerForm.pictureBoxView.Image = selectedUserPictureBox.Image;

            ImageViewerForm.StartPosition = FormStartPosition.CenterScreen;
            ImageViewerForm.ShowDialog();
        }


        private void iconMenuItemProjectsEmployee_Click(object sender, EventArgs e)
        {
            var iconMenuItemProjectsEmployee = _provider.GetRequiredService<ProjectEmployeeForm>();
            AbrirFormulario(iconMenuItemProjectsEmployee);
        }

        private void iconMenuItemRequestClientProjects_Click(object sender, EventArgs e)
        {
            var iconMenuItemRequest = _provider.GetRequiredService<RequestClientForm>();
            AbrirFormulario(iconMenuItemRequest);
        }
    }

}
