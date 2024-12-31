using BusinessLayer.Services.InterfacesServices;
using BusinessLayer.Services.InterfacesServices.InterfacesUser;
using CommonLayer.Entities.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms.Empleados
{
    public partial class RecordProjectsForm : Form
    {
        private readonly IProjectsServices _proyectsServices;
        private readonly IProjectsClientServices _projectsClientServices;
        private readonly IProjectsEmnployeesServices _projectsEmnployeesServices;
        private readonly IEmployeeServices _employeesServices;
        private readonly IClientsServices _clientsServices;
        int idUser;
        public RecordProjectsForm(IProjectsServices proyectsServices, IEmployeeServices employeesServices, IClientsServices clientsServices, IProjectsClientServices projectsClientServices, IProjectsEmnployeesServices projectsEmnployeesServices)
        {
            InitializeComponent();
            _proyectsServices = proyectsServices;
            _employeesServices = employeesServices;
            _clientsServices = clientsServices;
            _projectsClientServices = projectsClientServices;
            _projectsEmnployeesServices = projectsEmnployeesServices;
            idUser = CaptureData.idUser;
        }

        private void RecordProjectsEmployeeForm_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView(); 
            int idEmployee = Convert.ToInt32(_employeesServices.GetByIdEmployees(idUser).Select(id => id.idEmployee).FirstOrDefault());
            int idClient = Convert.ToInt32(_clientsServices.GetClients().Where(id => id.idUser == idUser).Select(client => client.idCliente).FirstOrDefault());

            recordsProjectdataGridView.DataSource = recordsProjectdataGridView.DataSource = _proyectsServices.GetByIdTaskEmployee(idEmployee).ToList();
            switch (CaptureData.IdRol)
            {
                case 1:
                    LoadProjectsForAdmin();
                    break;
                case 2:
                    LoadProjectsForEmployee(idEmployee);
                    break;
                case 4:
                    LoadProjectsForClient(idClient);
                    break;
                default:
                    MessageBox.Show("Rol no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void ConfigureDataGridView()
        {
            recordsProjectdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadProjectsForAdmin()
        {
            recordsProjectdataGridView.DataSource = _proyectsServices.GetRequestProjectsByStatus("Terminado").ToList();
            ConfigureData();
            HideColumns("file");
        }

        private void LoadProjectsForEmployee(int idEmployee)
        {
            recordsProjectdataGridView.DataSource = _projectsEmnployeesServices.GetTasksByEmployees(idEmployee).ToList();
            ConfigureData();
            HideColumns("idEmployee", "idStatusTask", "statusTask", "fileTask", "dateEnd");
        }


        private void LoadProjectsForClient(int idClient)
        {
            int idStatusProject = 9;
            recordsProjectdataGridView.DataSource = _projectsClientServices.GetsProjectsByIdClient(idClient, idStatusProject).ToList();
            ConfigureData();
            HideColumns("idClient", "file");
        }

        private void HideColumns(params string[] columnNames)
        {
            foreach (string columnName in columnNames)
            {
                if (recordsProjectdataGridView.Columns[columnName] != null)
                {
                    recordsProjectdataGridView.Columns[columnName].Visible = false;
                }
            }
        }

        private void SetNamesColumns(DataGridView dataGridView, Dictionary<String, string> columNames)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (columNames.ContainsKey(column.Name))
                {
                    column.HeaderText = columNames[column.Name];
                }
            }
        }

        private void ConfigureData()
        {
            switch (CaptureData.IdRol)
            {
                case 1:
                    var setNamesDGVAdmin = new Dictionary<string, string>()
                    {
                        { "idProject" , "ID" },
                        { "codeProject" , "Codigo" },
                        { "UserAccount" , "Usuario" },
                        { "nameProject" , "Nombre" },
                        { "descriptionProject" , "Descripcion" },
                        { "statusProject" , "Estado" },
                        { "dateInit" , "Fecha de inicio" },
                        { "dateEnd" , "Fecha de entrega" },
                        { "dateRegistration" , "Registro" }
                    };

                    SetNamesColumns(recordsProjectdataGridView, setNamesDGVAdmin);
                    break;
                case 2:
                    var setNamesDGVEmployee = new Dictionary<string, string>()
                    {
                        { "idProject" , "ID" }, 
                        { "codeProject" , "Codigo" },
                        { "UserAccount" , "Usuario" },
                        { "nameProject" , "Nombre" },
                        { "descriptionProject" , "Descripcion" },
                        { "statusProject" , "Estado" },
                        { "dateRegistration" , "Registro" }
                    };

                    SetNamesColumns(recordsProjectdataGridView, setNamesDGVEmployee);
                    break;
                case 4:
                    var setNamesDGVClient = new Dictionary<string, string>()
                    {
                        { "idProject" , "ID" },
                        { "codeProject" , "Codigo" },
                        { "UserAccount" , "Usuario" },
                        { "nameProject" , "Nombre" },
                        { "descriptionProject" , "Descripcion" },
                        { "statusProject" , "Estado" },
                        { "dateRegistration" , "Registro" }
                    };

                    SetNamesColumns(recordsProjectdataGridView, setNamesDGVClient);
                break;
            }           
        }
    }
}
