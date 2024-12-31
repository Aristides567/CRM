using BusinessLayer.Services;
using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities.ViewModel;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.DependencyInjection;
using PresentationLayer.Validations;
using CommonLayer.Entities.Projects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Services.InterfacesServices.InterfacesUser;

namespace PresentationLayer.Forms.Cliente
{
    public partial class RequestClientForm : Form
    {
        private readonly IEmployeeServices _usersServices;
        private readonly IClientsServices _clientsServices;
        private readonly IProjectsServices _proyectsServices;
        private readonly IProjectsClientServices _projectsClientServices;
        private readonly IServiceProvider _serviceProvider;
        int idClienById;

        private EntitieViewModel _entitieViewModel;
        public RequestClientForm(IEmployeeServices usersServices, IClientsServices clientsServices, IProjectsServices listProyectsServices, IProjectsClientServices projectsClientServices, IServiceProvider serviceProvider, EntitieViewModel entitieViewModel)
        {
            InitializeComponent();
            _usersServices = usersServices;
            _proyectsServices = listProyectsServices;
            _projectsClientServices = projectsClientServices;
            _clientsServices = clientsServices;
            _serviceProvider = serviceProvider;
            _entitieViewModel = entitieViewModel;
        }

        private void RequestClientForm_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            int idUser = CaptureData.idUser;
            var idClientByID = Convert.ToInt32(_clientsServices.GetClients().Where(u => u.idUser == idUser).Select(e => e.idCliente).FirstOrDefault());
            requestProjectDataGridView.DataSource = _projectsClientServices.GetsProjectsByIdClient(idClientByID, 4);

            requestProjectDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            requestProjectDataGridView.Columns["idProject"].Visible = false;
            requestProjectDataGridView.Columns["idClient"].Visible = false;
            requestProjectDataGridView.Columns["UserAccount"].Visible = false;
            requestProjectDataGridView.Columns["file"].Visible = false;
            requestProjectDataGridView.Columns["statusProject"].Visible = false;
            requestProjectDataGridView.Columns["codeProject"].HeaderText = "Codigo";
            requestProjectDataGridView.Columns["nameProject"].HeaderText = "Proyecto";
            requestProjectDataGridView.Columns["descriptionProject"].HeaderText = "Descripcion";

            var pendingStatusId = new List<int> { 7, 6 };
            listProjectDataGridView.DataSource = _projectsClientServices.GetProjectsByIdStatus(idClientByID, pendingStatusId);

            listProjectDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listProjectDataGridView.Columns["idClient"].Visible = false;
            listProjectDataGridView.Columns["UserAccount"].Visible = false;
            listProjectDataGridView.Columns["file"].Visible = false;
            listProjectDataGridView.Columns["codeProject"].HeaderText = "Codigo";
            listProjectDataGridView.Columns["nameProject"].HeaderText = "Proyecto";
            listProjectDataGridView.Columns["descriptionProject"].HeaderText = "Descripcion";
            listProjectDataGridView.Columns["statusProject"].HeaderText = "Estado";
        }

        private void listProjectDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && listProjectDataGridView.Columns[e.ColumnIndex].Name == "SelectPf")
            {
                DataGridViewRow row = listProjectDataGridView.Rows[e.RowIndex];
                int idProject = Convert.ToInt32(row.Cells["idProject"].Value.ToString());
                string codeProject = row.Cells["codeProject"].Value.ToString();
                string nameProject = row.Cells["nameProject"].Value.ToString();
                string Description = row.Cells["descriptionProject"].Value.ToString();
                string projectStatusId = row.Cells["statusProject"].Value.ToString();
                string progressStatusId = "En progreso";



                if (projectStatusId == progressStatusId)
                {
                    MessageBox.Show($"El proyecto '{nameProject}' (Código: {codeProject}) está en progreso, aun no esta listo.",
                                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var openInfoProjects = _serviceProvider.GetRequiredService<AnswerProjectClient>();

                    SharedData answerValues = new SharedData
                    {
                        codeProyect = codeProject,
                        idProject = idProject,
                        nameProject = nameProject,
                        Description = Description
                    };

                    _entitieViewModel.UpdateEntities(answerValues);


                    openInfoProjects.ShowDialog();
                    loadData();

                }
            }
            else if (e.RowIndex >= 0 && listProjectDataGridView.Columns[e.ColumnIndex].Name == "downloadProject")
            {
                if (listProjectDataGridView.Rows[e.RowIndex].Cells["statusProject"].Value.ToString() == "En progreso")
                {
                    MessageBox.Show($"El proyecto no esta listo y no puede descargarse",
                                   "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    try
                    {
                        string codeProject = listProjectDataGridView.Rows[e.RowIndex].Cells["codeProject"].Value.ToString();
                        byte[] content = _projectsClientServices.getProjectInDB(codeProject);

                        SaveFileDialog saveFileDialog = new SaveFileDialog
                        {
                            FileName = "proyecto",
                            Filter = "Todos los archivos|*.*"
                        };

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = saveFileDialog.FileName;
                            File.WriteAllBytes(filePath, content);

                            MessageBox.Show("Proyecto descargada correctamente");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error en la descargar la tarea: " + ex.Message);
                    }
                }
            }
        }

        private void iconButtonGuardarNP_Click(object sender, EventArgs e)
        {
            try
            {
                int idUser = CaptureData.idUser;

                int idClient = _clientsServices.GetClients()
                    .Where(U => U.idUser == idUser)
                    .Select(c => c.idCliente)
                    .FirstOrDefault();

                if (idClient == 0)
                {
                    MessageBox.Show("No se pudo encontrar un cliente asociado al usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var newProject = new RequestProjects
                {
                    codeProject = GenerateProjectCode(),
                    idClient = idClient,
                    nameProject = nameNewProyectTextBox.Text,
                    descriptionProject = descriptionProjectTextBox.Text
                };

                RequestClientValidation projectValidation = new RequestClientValidation();
                ValidationResult validationResult = projectValidation.Validate(newProject);

                if (!validationResult.IsValid)
                {
                    DisplayValidationErrors(validationResult);
                    return;
                }

                var status = new StatusProjects
                {
                    idStatusProject = 4
                };


                _projectsClientServices.AddNewProject(newProject.codeProject, newProject.idClient, newProject.nameProject, newProject.descriptionProject);

                _proyectsServices.StatusProject(newProject.codeProject, status.idStatusProject);


                MessageBox.Show("Se ha añadido el proyecto!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                nameNewProyectTextBox.Clear();
                descriptionProjectTextBox.Clear();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show($"Error de validación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateProjectCode()
        {
            string year = "24";

            Random random = new Random();
            int randomNumber = random.Next(100, 1000);

            string projectCode = $"U{year}{randomNumber}";

            return projectCode;
        }

        private void DisplayValidationErrors(ValidationResult result)
        {
            errorValidation.Clear();
            ResetErrorLabels();

            foreach (var error in result.Errors)
            {
                switch (error.PropertyName)
                {
                    case nameof(RequestProjects.nameProject):
                        errorValidation.SetError(nameNewProyectTextBox, error.ErrorMessage);
                        errorNameProjectLabel.Text = error.ErrorMessage;
                        break;
                    case nameof(RequestProjects.descriptionProject):
                        errorValidation.SetError(descriptionProjectTextBox, error.ErrorMessage);
                        errorDescriptionLabel.Text = error.ErrorMessage;
                        break;
                    default:
                        Console.WriteLine($"Error en un campo no reconocido: {error.PropertyName}");
                        break;
                }
            }
        }

        private void ResetErrorLabels()
        {
            errorNameProjectLabel.Text = string.Empty;
            errorDescriptionLabel.Text = string.Empty;

            errorValidation.SetError(nameNewProyectTextBox, string.Empty);
            errorValidation.SetError(descriptionProjectTextBox, string.Empty);
        }

        
    }
}
