using CommonLayer.Entities.ViewModel;
using DataAccessLayer.Repositories.InterfacesRepositories;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Reports
{
    public class ProjectsReports : IProjectsReports
    {
        private readonly IProjectsRepositories _projectsRepository;
        private readonly IProjectsClientsRepositories _projectsClientsRepository;
        private readonly IProjectsEmployeesRepositories _projectsEmployeesRepository;
        private readonly EntitieViewModel _entitieViewModel;

        public ProjectsReports(IProjectsRepositories projectsRepository, IProjectsClientsRepositories projectsClientsRepository, IProjectsEmployeesRepositories projectsEmployeesRepository, EntitieViewModel entitieViewModel)
        {
            _projectsRepository = projectsRepository;
            _projectsClientsRepository = projectsClientsRepository;
            _projectsEmployeesRepository = projectsEmployeesRepository;
            _entitieViewModel = entitieViewModel;
        }

        public void GenerateReports()
        {
            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(1, Unit.Centimetre);
                    page.Size(PageSizes.A4);

                    page.Header().Element(ComposeHeader);
                    page.Content().Element(ComposeContent);
                });
            });

            document.GeneratePdfAndShow();
        }

        private void ComposeHeader(IContainer container)
        {
            container.Row(Row =>
            {
                Row.ConstantItem(75).Height(50).Text($"{DateTime.Now.ToShortDateString()}");

                Row.ConstantItem(375)
                .Height(50)
                .Text("Reportes De Proyectos")
                .AlignCenter()
                .FontSize(24)
                .FontColor(Colors.Black);

                Row.ConstantItem(50).Height(50).Placeholder();
            });
        }

        private void ComposeContent(IContainer container)
        {
            container.PaddingVertical(80).Column(column =>
            {
                column.Spacing(5);
                column.Item().Element(ComposeTable);
            });
        }

        private void ComposeTable(IContainer container)
        {
            container.Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                });

                table.Header(header =>
                {
                    header.Cell().Element(CellStyle).Background(Colors.Grey.Lighten1).Text("Codigo").Bold().FontColor(Colors.White);
                    header.Cell().Element(CellStyle).Background(Colors.Grey.Lighten1).Text("Usuario").Bold().FontColor(Colors.White);
                    header.Cell().Element(CellStyle).Background(Colors.Grey.Lighten1).Text("Proyecto").Bold().FontColor(Colors.White);
                    header.Cell().Element(CellStyle).Background(Colors.Grey.Lighten1).Text("Estado").Bold().FontColor(Colors.White);
                    header.Cell().Element(CellStyle).Background(Colors.Grey.Lighten1).Text("Fecha Inicio").Bold().FontColor(Colors.White);
                    header.Cell().Element(CellStyle).Background(Colors.Grey.Lighten1).Text("Fecha Fin").Bold().FontColor(Colors.White);
                    header.Cell().Element(CellStyle).Background(Colors.Grey.Lighten1).Text("Registro").Bold().FontColor(Colors.White);


                    static IContainer CellStyle(IContainer container)
                    {
                        return container.DefaultTextStyle(x => x.SemiBold()).PaddingVertical(10).BorderBottom(1).BorderColor(Colors.Black);
                    }
                });
                var Getstatus = _entitieViewModel.EntitieNow.StatusPDF;

                if(Getstatus == "Todo")
                {
                    var AllProjects = _projectsRepository.GetAllProjects();

                    foreach (var item in AllProjects)
                    {
                        table.Cell().Element(CellStyle).Text($"{item.codeProject}");
                        table.Cell().Element(CellStyle).Text($"{item.UserAccount}");
                        table.Cell().Element(CellStyle).Text($"{item.nameProject}");
                        table.Cell().Element(CellStyle).Text($"{item.statusProject}");
                        table.Cell().Element(CellStyle).Text($"{item.dateInit}");
                        table.Cell().Element(CellStyle).Text($"{item.dateEnd}");
                        table.Cell().Element(CellStyle).Text($"{item.dateRegistration}");

                        static IContainer CellStyle(IContainer container)
                        {
                            return container.BorderBottom(1).PaddingVertical(10).PaddingHorizontal(5).BorderColor(Colors.Grey.Lighten2).PaddingVertical(5);
                        }
                    }
                }
                var projects = _projectsRepository.GetAllProjects().Where(status => status.statusProject == Getstatus);

                foreach (var item in projects)
                {
                    table.Cell().Element(CellStyle).Text($"{item.codeProject}");
                    table.Cell().Element(CellStyle).Text($"{item.UserAccount}");
                    table.Cell().Element(CellStyle).Text($"{item.nameProject}");
                    table.Cell().Element(CellStyle).Text($"{item.statusProject}");
                    table.Cell().Element(CellStyle).Text($"{item.dateInit}");
                    table.Cell().Element(CellStyle).Text($"{item.dateEnd}");
                    table.Cell().Element(CellStyle).Text($"{item.dateRegistration}");

                    static IContainer CellStyle(IContainer container)
                    {
                        return container.BorderBottom(1).PaddingVertical(10).PaddingHorizontal(5).BorderColor(Colors.Grey.Lighten2).PaddingVertical(5);
                    }
                }
            });


        }
    }
}
