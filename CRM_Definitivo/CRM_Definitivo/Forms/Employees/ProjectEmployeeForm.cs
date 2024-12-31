using BusinessLayer.Services;
using BusinessLayer.Services.InterfacesServices;
using BusinessLayer.Services.InterfacesServices.InterfacesUser;
using CommonLayer.Entities.ViewModel;
using FluentValidation;
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

namespace PresentationLayer.Forms.Empleados
{
    public partial class ProjectEmployeeForm : Form
    {
        private readonly IEmployeeServices _usersService;
        private readonly IProjectsServices _listProyectsServices;
        private readonly IProjectsEmnployeesServices _projectsEmnployeesServices;
        byte[] fileByte;

        public ProjectEmployeeForm(IEmployeeServices usersServices, IProjectsServices listProyectsServices, IProjectsEmnployeesServices projects)
        {
            InitializeComponent();
            _usersService = usersServices;
            _listProyectsServices = listProyectsServices;
            _projectsEmnployeesServices = projects;
            LoadData();
            informationProjectPanel.Visible = false;
        }

        public void LoadData()
        {
            taskStatusComboBox.DataSource = _projectsEmnployeesServices.GetStatusTaskEmployees();
            taskStatusComboBox.DisplayMember = "statusTask";
            taskStatusComboBox.ValueMember = "idStatusTask";
            taskStatusComboBox.SelectedIndex = 1;
            var idEmployee = _usersService.GetEmployees()
                .Where(u => u.idUser == CaptureData.idUser)
                .Select(e => e.idEmployee)
                .FirstOrDefault();

            if (idEmployee > 0)
            {
                projectsEmployeeDataGridView.DataSource = _projectsEmnployeesServices.GetsProjects(idEmployee);
                projectsEmployeeDataGridView.Columns["fileTask"].Visible = false;
                projectsEmployeeDataGridView.Columns["idStatusTask"].Visible = false;
                projectsEmployeeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                projectsEmployeeDataGridView.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                projectsEmployeeDataGridView.DefaultCellStyle.ForeColor = Color.Black;
                projectsEmployeeDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                projectsEmployeeDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
                projectsEmployeeDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                projectsEmployeeDataGridView.EnableHeadersVisualStyles = false;
            }
            else
            {
                MessageBox.Show("No se encontró el empleado para el usuario autmenticado.");
            }

        }

        private void projectsEmployeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                informationProjectPanel.Visible = true;
                var idEmployee = _usersService.GetEmployees()
                .Where(u => u.idUser == CaptureData.idUser)
                .Select(e => e.idEmployee)
                .FirstOrDefault();

                int idTask = Convert.ToInt32(projectsEmployeeDataGridView.CurrentRow.Cells["idTask"].Value);
                var idem = _listProyectsServices.GetByIdTaskEmployee(idEmployee);
                var selectedTask = idem.FirstOrDefault(id => id.idTask == idTask);
                if (selectedTask != null)
                {
                    descriptionTaskTextBox.Text = selectedTask.descriptionTask;
                    nameTaskLabel.Text = selectedTask.nameTask;
                    projectNameLabel.Text = selectedTask.codeProject;
                }
                else
                {
                    MessageBox.Show("No se encontró el proyecto seleccionado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void linkFileLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileEmployee = new OpenFileDialog();
            openFileEmployee.Filter = "Todos los archivos (*.*) | *.*";

            if (openFileEmployee.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileEmployee.FileName;


                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        fs.CopyTo(ms);
                        fileByte = ms.ToArray();
                        labelLinkFile.Text = filePath;
                    }
                }
            }
        }



        private void submitButton_Click(object sender, EventArgs e)
        {
            int idTask;
            int updateStatus;
            byte[] updateFile = fileByte;

            var idTaskValidator = new InlineValidator<int>();
            idTaskValidator.RuleFor(id => id)
                           .GreaterThan(0).WithMessage("El ID de la tarea debe ser mayor a 0.");

            if (!int.TryParse(projectsEmployeeDataGridView.CurrentRow.Cells[1].Value.ToString(), out idTask))
            {
                MessageBox.Show("El ID de la tarea debe ser un número válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var idValidationResult = idTaskValidator.Validate(idTask);
            if (!idValidationResult.IsValid)
            {
                MessageBox.Show(string.Join(Environment.NewLine, idValidationResult.Errors.Select(e => e.ErrorMessage)), "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var statusValidator = new InlineValidator<int>();
            statusValidator.RuleFor(status => status)
                           .InclusiveBetween(1, 3).WithMessage("El estado de la tarea debe estar entre 1 y 3.");

            if (!int.TryParse(taskStatusComboBox.SelectedValue?.ToString(), out updateStatus))
            {
                MessageBox.Show("El estado de la tarea debe ser un número válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var statusValidationResult = statusValidator.Validate(updateStatus);
            if (!statusValidationResult.IsValid)
            {
                MessageBox.Show(string.Join(Environment.NewLine, statusValidationResult.Errors.Select(e => e.ErrorMessage)), "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (updateFile == null || updateFile.Length == 0)
            {
                MessageBox.Show("El archivo no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _listProyectsServices.UpdateTaskEmployee(idTask, updateFile, updateStatus);

                MessageBox.Show("Se ha enviado correctamente", "Enviado correctamente", MessageBoxButtons.OK);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al intentar actualizar la tarea: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
