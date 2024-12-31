using BusinessLayer.Services;
using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities.Projects;
using CommonLayer.Entities.ViewModel;
using FluentValidation.Results;
using Microsoft.Extensions.DependencyInjection;
using PresentationLayer.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms.Cliente
{
    public partial class AnswerProjectClient : Form
    {
        private readonly IServiceProvider _servicesProvider;
        private readonly IProjectsServices _proyectsServices;
        private readonly IProjectsClientServices _projectsClientServices;
        private byte[] fileByte;

        private EntitieViewModel _entitieViewModel;
        public AnswerProjectClient(IServiceProvider serviceProvider, IProjectsServices projectServices, IProjectsClientServices projectsClientServices, EntitieViewModel entitieViewModel)
        {
            InitializeComponent();
            _servicesProvider = serviceProvider;
            _proyectsServices = projectServices;
            _projectsClientServices = projectsClientServices ?? throw new ArgumentNullException(nameof(projectsClientServices));
            _entitieViewModel = entitieViewModel;
        }
        private void AnswerProyectClient_Load(object sender, EventArgs e)
        {
            descriptionProjectTextBox.Text = _entitieViewModel.EntitieNow.Description;
            codeProjectLabel.Text = _entitieViewModel.EntitieNow.codeProyect;
            nameProjectLabel.Text = _entitieViewModel.EntitieNow.nameProject;
        }


        private void iconApprovedProjectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(_entitieViewModel.EntitieNow.codeProyect))
                {
                    MessageBox.Show("El código del proyecto es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_entitieViewModel.EntitieNow.codeProyect.Length < 5 || _entitieViewModel.EntitieNow.codeProyect.Length > 20)
                {
                    MessageBox.Show("El código del proyecto debe tener entre 5 y 20 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                if (string.IsNullOrEmpty(_entitieViewModel.EntitieNow.nameProject))
                {
                    MessageBox.Show("El nombre del proyecto es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                if (_entitieViewModel.EntitieNow.nameProject.Length > 100)
                {
                    MessageBox.Show("El nombre del proyecto no debe exceder los 100 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }


                _proyectsServices.StatusProject(_entitieViewModel.EntitieNow.codeProyect, 9);

                MessageBox.Show($"El Proyecto '{_entitieViewModel.EntitieNow.nameProject}' ha sido Aceptado.", "Aprobado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void iconRefusedProjectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileByte == null || fileByte.Length == 0)
                {
                    MessageBox.Show("Por favor, seleccione un archivo antes de rechazar el proyecto.", "Archivo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_projectsClientServices == null)
                {
                    MessageBox.Show("El servicio de proyectos de cliente no está inicializado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_entitieViewModel.EntitieNow.idProject <= 0)
                {
                    MessageBox.Show("El ID del proyecto no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(descriptionProjectTextBox.Text))
                {
                    MessageBox.Show("Por favor, ingrese una descripción antes de rechazar el proyecto.", "Descripción requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                reasonForRejection refused = new reasonForRejection
                {
                    idProject = _entitieViewModel.EntitieNow.idProject,
                    fileRefused = fileByte
                };

                _projectsClientServices.InsertReasonForRejection(refused);

                int idStatusProject = 8;
                _proyectsServices.StatusProject(_entitieViewModel.EntitieNow.codeProyect, idStatusProject);

                MessageBox.Show($"El Proyecto '{_entitieViewModel.EntitieNow.nameProject}' ha sido rechazado correctamente.", "Rechazado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void refusedProjectLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Todos los archivos (*.txt)|*.txt";
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
                    }
                }
            }
        }


    }
}
