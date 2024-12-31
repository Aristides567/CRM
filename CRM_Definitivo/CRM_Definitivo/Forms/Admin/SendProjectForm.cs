using BusinessLayer.Services.InterfacesServices;
using BusinessLayer.Services.InterfacesServices.InterfacesUser;
using CommonLayer.Entities.Projects;
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

namespace PresentationLayer.Forms.Admin
{
    public partial class SendProjectForm : Form
    {
        byte[] fileByte;

        private EntitieViewModel _EntitieViewModel;
        private readonly IProjectsServices _proyectsServices;
        private readonly IEmployeeServices _usersServices;

        public SendProjectForm(EntitieViewModel entitieViewModel, IProjectsServices proyectsServices, IEmployeeServices usersServices)
        {
            _EntitieViewModel = entitieViewModel;
            _proyectsServices = proyectsServices;
            _usersServices = usersServices;
            InitializeComponent();
        }

        private void SendProjectForm_Load(object sender, EventArgs e)
        {
            codeProjectLabel.Text = _EntitieViewModel.EntitieNow.codeProyect;
            descriptionTextBox.Text = _EntitieViewModel.EntitieNow.DescriptionProject;
            nameUserLabel.Text = _EntitieViewModel.EntitieNow.Client;
            nameProjectLabel.Text = _EntitieViewModel.EntitieNow.nameProject;
            dateLabel.Text = _EntitieViewModel.EntitieNow.dateEnd.ToString("dd/MM/yy");

        }

        private void linkLabelFileProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog.Title = "Seleccione el archivo a enviar";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        file.CopyTo(ms);
                        fileByte = ms.ToArray();
                        selectedFileLabel.Text = filePath;
                    }
                }
            }
        }

        private void iconButtonSendProject_Click(object sender, EventArgs e)
        {
            var taskPending = _proyectsServices.GetTaskEmployees().Where(code => code.codeProject == _EntitieViewModel.EntitieNow.codeProyect && code.statusTask == "Pendiente").ToList();
            try
            {
                if (fileByte == null || fileByte.Length == 0)
                {
                    MessageBox.Show("Por favor, seleccione un archivo antes de enviar el proyecto.", "Archivo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                if (_proyectsServices == null)
                {
                    MessageBox.Show("El servicio de proyectos no está inicializado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                if(taskPending.Count > 0)
                {
                    MessageBox.Show("Se requiere que todas las tareas esten completadas para subir el proyecto final", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Projects projects = new Projects();
                    projects.file = fileByte;

                    _proyectsServices.SendProjects(_EntitieViewModel.EntitieNow.codeProyect, projects.file);

                    StatusProjects statusProjects = new StatusProjects();
                    statusProjects.idStatusProject = 7;

                    _proyectsServices.StatusProject(_EntitieViewModel.EntitieNow.codeProyect, statusProjects.idStatusProject);

                    MessageBox.Show("El proyecto ha sido enviado correctamente, estamos en espera de la respuesta del cliente!", "Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
