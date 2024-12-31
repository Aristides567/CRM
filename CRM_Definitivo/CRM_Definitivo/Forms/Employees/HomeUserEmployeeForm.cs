using BusinessLayer.Services.InterfacesServices;
using BusinessLayer.Services.InterfacesServices.InterfacesUser;
using CommonLayer.Entities;
using CommonLayer.Entities.ViewModel;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class HomeUserEmployeeForm : Form
    {
        private readonly IProjectsServices _proyectsServices;
        private readonly IEmployeeServices _usersServices;
        private readonly IProjectsClientServices _projectsClientServices;
        private readonly IServiceProvider _serviceProvider;
        int idUser;
        public HomeUserEmployeeForm(IProjectsServices proyectsServices, IEmployeeServices usersServices, IProjectsClientServices projectsClientServices, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _proyectsServices = proyectsServices;
            _usersServices = usersServices;
            _projectsClientServices = projectsClientServices;
            _serviceProvider = serviceProvider;
            idUser = CaptureData.idUser;
            LoadData();
        }

        private void LoadData()
        {
            userAccountLabel.Text = CaptureData.UserAccount;
            timeLabel.Text = DateTime.Now.ToString("g");

            var getIdEmployee = _usersServices.GetEmployees().Where(id => id.idUser == idUser).Select(select => select.idEmployee).FirstOrDefault();
            var projectsCount = _proyectsServices.GetByIdTaskEmployee(getIdEmployee, 1).Count();
            projectsPendingsLabel.Text = projectsCount.ToString();
        }
    }
}
