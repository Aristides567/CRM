using BusinessLayer.Services.InterfacesServices;
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
    public partial class infoProjects : Form
    {
        public string codeProject { get; set; }
        private int idTasks;

        private readonly IProjectsServices _proyectsServices;
        public infoProjects(IProjectsServices proyectsServices)
        {
            _proyectsServices = proyectsServices;
            InitializeComponent();
        }


        private void infoProjects_Load(object sender, EventArgs e)
        {
            getTaskDataGridView.DataSource = _proyectsServices.GetTasksByCode(codeProject);
            getTaskDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            getTaskDataGridView.Columns["idStatusTask"].Visible = false;
            getTaskDataGridView.Columns["dateEnd"].Visible = false;
            getTaskDataGridView.Columns["fileTask"].Visible = false;
        }

        private void getTaskDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                descriptionTextBox.Text = getTaskDataGridView.Rows[e.RowIndex].Cells["descriptionTask"].Value.ToString();
                taskTextBox.Text = getTaskDataGridView.Rows[e.RowIndex].Cells["nameTask"].Value.ToString();

                downloadTaskLinkLabel.Visible = true;
            }

            var idtaskSelected = getTaskDataGridView.Rows[e.RowIndex].Cells["idTask"].Value.ToString();
            idTasks = Convert.ToInt32(idtaskSelected);
        }


        private void downloadTaskLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                int idTask = idTasks;
                byte[] content = _proyectsServices.DownloadTask(idTask);

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    FileName = "Tarea",
                    Filter = "Todos los archivos|*.*"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    File.WriteAllBytes(filePath, content);

                    MessageBox.Show("Tarea descargada correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la descargar la tarea: " + ex.Message);
            }
        }
    }
}
