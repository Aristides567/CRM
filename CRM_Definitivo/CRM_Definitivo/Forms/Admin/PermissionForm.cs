using BusinessLayer.Services;
using BusinessLayer.Services.InterfacesServices;
//using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities;
using FluentValidation.Results;
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

namespace PresentationLayer.Forms.Admin
{
    public partial class PermissionForm : Form
    {
        private readonly IRolServices _rolservices;
        private readonly IPermisoServices _permissionServices;
        bool isEditing = false;
        public PermissionForm(IRolServices rolServices, IPermisoServices permisionsServices)
        {
            InitializeComponent();
            _rolservices = rolServices;
            _permissionServices = permisionsServices;
            LoadData();
        }

        private void LoadData()
        {
            DataSources();
            menuDataGridView.Columns["idMenu"].Visible = false;

            permissionDataGridView.Columns["idMenu"].Visible = false;
            permissionDataGridView.Columns["idPermission"].Visible = false;

            rolPermissionDataGridView.Columns["idRolPermission"].Visible = false;
            rolPermissionDataGridView.Columns["idPermission"].Visible = false;



            menuDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            permissionDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rolPermissionDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Diseño para dgv menu
            menuDataGridView.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            menuDataGridView.DefaultCellStyle.ForeColor = Color.Black;
            menuDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            menuDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            menuDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            menuDataGridView.EnableHeadersVisualStyles = false;

            menuDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            menuDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //Diseño para dgvPermission
            permissionDataGridView.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            permissionDataGridView.DefaultCellStyle.ForeColor = Color.Black;
            permissionDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            permissionDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            permissionDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            permissionDataGridView.EnableHeadersVisualStyles = false;

            permissionDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            permissionDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //Diseño para dgvRolPermission
            rolPermissionDataGridView.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            rolPermissionDataGridView.DefaultCellStyle.ForeColor = Color.Black;
            rolPermissionDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            rolPermissionDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            rolPermissionDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            rolPermissionDataGridView.EnableHeadersVisualStyles = false;

            rolPermissionDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rolPermissionDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


        }

        private void DataSources()
        {
            menuDataGridView.DataSource = _permissionServices.GetByMenu();
            permissionDataGridView.DataSource = _permissionServices.GetPermissions();
            rolPermissionDataGridView.DataSource = _permissionServices.GetByRolPermissions();
            ConfigureDataGridView();


            //DATASOURCE DEL MENU 
            selectMenuComboBox.DataSource = _permissionServices.GetByMenu();
            selectMenuComboBox.DisplayMember = "nameForm";
            selectMenuComboBox.ValueMember = "idMenu";

            //DATASOURCE DE PERMISSIONS
            permissionIdComboBox.DataSource = _permissionServices.GetPermissions();
            permissionIdComboBox.DisplayMember = "nameForm";
            permissionIdComboBox.ValueMember = "idPermission";

            //DATASOURCE DE ROLPERMISSIONS
            rolUserComboBox.DataSource = _rolservices.GetRol();
            rolUserComboBox.DisplayMember = "Rol";
            rolUserComboBox.ValueMember = "idRol";
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
            var columnsNewNameMenu = new Dictionary<string, string>
            {
                { "name", "Nombre" },
                { "NameForm", "Nombre del form / objeto a filtrar" }

            };

            var columnsNewNameMenuPermission = new Dictionary<string, string>
            {
                { "nameForm", "Nombre del form / objeto a filtrar" },
                { "idRoles", "Rol del usuario" }
            };

            var columnsNewNameMenuAccess = new Dictionary<string, string>
            {
                { "nameForm", "Nombre Nombre del form / objeto a filtrar" }
            };
            SetNamesColumns(menuDataGridView, columnsNewNameMenu);
            SetNamesColumns(rolPermissionDataGridView, columnsNewNameMenuPermission);
            SetNamesColumns(permissionDataGridView, columnsNewNameMenuAccess);
        }


        private void iconSaveMenusButton_Click(object sender, EventArgs e)
        {
            try
            {
                var menu = new Menu
                {
                    name = nameMenuTextBox.Text,
                    NameForm = nameObjectTextBox.Text
                };

                var PermissionFormValidation = new PermissionFormValidation();
                var validationResult = PermissionFormValidation.Validate(menu);

                if (!validationResult.IsValid)
                {
                    DisplayValidationErrors(validationResult);
                    return; 
                }

                if (isEditing)
                {
                    menu.idMenu = int.Parse(menuDataGridView.CurrentRow.Cells[0].Value.ToString());
                    _permissionServices.EditMenu(menu);
                    MessageBox.Show("El menú se ha actualizado de forma exitosa!");
                }
                else
                {
                    _permissionServices.AddMenu(menu);
                    MessageBox.Show("El nuevo menú se ha agregado correctamente!");
                }

                LoadData();
                isEditing = false;

                ClearFields();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Error en el formato de los datos: {ex.Message}", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            nameMenuTextBox.Clear();
            nameObjectTextBox.Clear();
        }

        private void iconEditMenusButton_Click(object sender, EventArgs e)
        {
            if (menuDataGridView.SelectedRows.Count > 0)
            {
                nameMenuTextBox.Text = menuDataGridView.CurrentRow.Cells[1].Value.ToString();
                nameObjectTextBox.Text = menuDataGridView.CurrentRow.Cells[2].Value.ToString();
                isEditing = true;
            }
        }

        private void iconSaveMenuPermissonButton_Click(object sender, EventArgs e)
        {
            var permission = new Permissions();

            if (isEditing)
            {
                permission.idPermission = int.Parse(menuDataGridView.CurrentRow.Cells[0].Value.ToString());
                _permissionServices.EditPermissions(permission);
                LoadData();
                isEditing = false;
            }
            else
            {
                permission.idMenu = Convert.ToInt32(selectMenuComboBox.SelectedValue);

                _permissionServices.AddPermissions(permission);
                LoadData();
                MessageBox.Show("Se ha agregado correctamente!");
            }
        }
 

        private void iconEditMenuButton_Click(object sender, EventArgs e)
        {
            if (permissionDataGridView.SelectedRows.Count > 0)
            {
                selectMenuComboBox.SelectedValue = Convert.ToInt32(permissionDataGridView.CurrentRow.Cells[1].Value.ToString());
                isEditing = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de editar");
            }
        }

        private void iconDeleteMenusButton_Click(object sender, EventArgs e)
        {
            if (menuDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un menu para eliminar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var eliminarConfirmar = MessageBox.Show(
                "¿Está seguro de que desea eliminar este menu?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (eliminarConfirmar == DialogResult.Yes)
            {
                int idMenu = Convert.ToInt32(menuDataGridView.CurrentRow.Cells["idMenu"].Value);
                _permissionServices.DeleteMenu(idMenu);
                LoadData();
            }
        }

        private void iconSaveRolPermissionButton_Click(object sender, EventArgs e)
        {
            var rolPermission = new RolPermission();

            if (isEditing)
            {
                rolPermission.idRolPermission = int.Parse(rolPermissionDataGridView.CurrentRow.Cells[0].Value.ToString());
                rolPermission.idRoles = Convert.ToInt32(rolUserComboBox.SelectedValue);
                rolPermission.idPermission = Convert.ToInt32(permissionIdComboBox.SelectedValue);

                _permissionServices.EditRolPermission(rolPermission);

                MessageBox.Show("Se ha editado el permiso correctamente");
                LoadData();

                isEditing = false;
            }
            else
            {
                rolPermission.idRoles = Convert.ToInt32(rolUserComboBox.SelectedValue);
                rolPermission.idPermission = Convert.ToInt32(permissionIdComboBox.SelectedValue);

                _permissionServices.AddRolPermission(rolPermission);

                MessageBox.Show($"Se ha asignado un nuevo permiso a los {rolUserComboBox.SelectedValue} correctamente!");
                LoadData();
            }
        }



        private void iconEditRolPermissionButton_Click(object sender, EventArgs e)
        {
            if (rolPermissionDataGridView.SelectedRows.Count > 0)
            {
                rolUserComboBox.Text = rolPermissionDataGridView.CurrentRow.Cells["idRoles"].Value.ToString();
                permissionIdComboBox.Text = rolPermissionDataGridView.CurrentRow.Cells["nameForm"].Value.ToString();
                isEditing = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de editar");
            }
        }

        private void DisplayValidationErrors(ValidationResult result)
        {
            errorValidation.Clear();
            ResetErrorLabels();

            foreach (var error in result.Errors)
            {
                switch (error.PropertyName)
                {
                    case nameof(Menu.name):
                        errorValidation.SetError(nameMenuTextBox, error.ErrorMessage);
                        errorNameMenuLabel.Text = error.ErrorMessage;
                        break;
                    case nameof(Menu.NameForm):
                        errorValidation.SetError(nameObjectTextBox, error.ErrorMessage);
                        errorDescripionMenuLabel.Text = error.ErrorMessage;
                        break;
                    default:
                        Console.WriteLine($"Error en un campo no reconocido: {error.PropertyName}");
                        break;
                }
            }
        }

        private void ResetErrorLabels()
        {
            errorNameMenuLabel.Text = string.Empty;
            errorDescripionMenuLabel.Text = string.Empty;

            errorValidation.SetError(nameMenuTextBox, string.Empty);
            errorValidation.SetError(nameObjectTextBox, string.Empty);
        }

        
    }
}
