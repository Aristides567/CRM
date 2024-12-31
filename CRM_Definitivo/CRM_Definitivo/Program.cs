using BusinessLayer.Services;
using BusinessLayer.Services.InterfacesServices;
using BusinessLayer.Services.InterfacesServices.InterfacesUser;
using BusinessLayer.Services.Users;
using CommonLayer.Entities;
using CommonLayer.Entities.Users;
using CommonLayer.Entities.ViewModel;
using DataAccessLayer.DbConnection;
using DataAccessLayer.DbSqlDataAccess;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.InterfacesRepositories;
using DataAccessLayer.Repositories.InterfacesRepositories.InterfacesUser;
using DataAccessLayer.Repositories.UsersRepositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PresentationLayer.Forms;
using PresentationLayer.Forms.Admin;
using PresentationLayer.Forms.Cliente;
using PresentationLayer.Forms.Empleados;
using PresentationLayer.Reports;
using QuestPDF.Infrastructure;

namespace CRM_Definitivo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            QuestPDF.Settings.License = LicenseType.Community;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<LoginForm>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                    .ConfigureServices((context, services) =>
                    {
                        //FORMS
                        services.AddTransient<UsersForm>();
                        services.AddTransient<LoginForm>();
                        services.AddTransient<MenuForm>();
                        services.AddTransient<ProjectsForm>();
                        services.AddTransient<AddUsersForm>();
                        services.AddTransient<ProfileUserAccountForm>();
                        services.AddTransient<ImageViewerForm>();
                        services.AddTransient<ChangePasswordProfileForm>();
                        services.AddTransient<PermissionForm>();
                        services.AddTransient<HomeUserClientForm>();
                        services.AddTransient<HomeUserEmployeeForm>();
                        services.AddTransient<ProjectEmployeeForm>();
                        services.AddTransient<RequestClientForm>();
                        services.AddTransient<AssignamentTaskEmployeeForm>();
                        services.AddTransient<SendProjectForm>();
                        services.AddTransient<infoProjects>();
                        services.AddTransient<AnswerProjectClient>();
                        services.AddTransient<RecordProjectsForm>();


                        //BUSISNESSLAYER
                        services.AddScoped<IEmployeeServices, EmployeeServices>();
                        services.AddScoped<IAdminsServices, AdminsServices>();
                        services.AddScoped<IClientsServices, ClientsServices>();
                        services.AddScoped<IProjectsClientServices, ProjectsClientServices>();
                        services.AddScoped<IPermisoServices, PermissionServices>();
                        services.AddScoped<IRolServices, RolServices>();
                        services.AddScoped<IProjectsServices, ProjectsServices>();
                        services.AddScoped<IProjectsEmnployeesServices, ProjectsEmnployeesServices>();
                        services.AddScoped<IProjectsClientServices, ProjectsClientServices>();

                        //REPOSITORIES
                        services.AddScoped<IEmployeeRepositories, EmployeeRepositories>();
                        services.AddScoped<IAdminsRepositories, AdminsRepositories>();
                        services.AddScoped<IClientsRepositories, ClientsRepositories>();
                        services.AddScoped<IPermissionRepositories, PermissionRepositories>();
                        services.AddScoped<IRolRepositories,  RolRepositories>();
                        services.AddScoped<IProjectsRepositories, ProjectsRepositories>();
                        services.AddScoped<IProjectsEmployeesRepositories, ProjectsEmployeesRepositories>();
                        services.AddScoped<IProjectsClientsRepositories, ProjectsClientsRepositories>();

                        //REPORTS
                        services.AddScoped<IUserReports, UserReports>();
                        services.AddScoped<IProjectsReports, ProjectsReports>();

                        //SQLDATA
                        services.AddSingleton<ISqlDataAccess, SqlDataAccess>();

                        //ENTITIES
                        services.AddSingleton<EntitieViewModel>();
                        services.AddSingleton<User>();
                        services.AddSingleton<EmailSettings>();

                        //Notificacioations
                    });
        }
    }
}