namespace PresentationLayer.Forms.Admin
{
    partial class PermissionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuTabPage = new TabPage();
            menuDataGridView = new DataGridView();
            controlMenuGroupBox = new GroupBox();
            errorDescripionMenuLabel = new Label();
            errorNameMenuLabel = new Label();
            nameObjectTextBox = new TextBox();
            nameMenuLabel = new Label();
            nameMenuTextBox = new TextBox();
            nameObjectLabel = new Label();
            iconEditMenusButton = new FontAwesome.Sharp.IconButton();
            iconSaveMenusButton = new FontAwesome.Sharp.IconButton();
            iconDeleteMenusButton = new FontAwesome.Sharp.IconButton();
            permissionTabControl = new TabControl();
            permissionTabPage = new TabPage();
            accessGroupBox = new GroupBox();
            rolUserComboBox = new ComboBox();
            iconEditRolPermissionButton = new FontAwesome.Sharp.IconButton();
            permissionIdComboBox = new ComboBox();
            iconSaveRolPermissionButton = new FontAwesome.Sharp.IconButton();
            permissionIdLabel = new Label();
            rolUserLabel = new Label();
            rolPermissionDataGridView = new DataGridView();
            permissionGroupBox = new GroupBox();
            selectMenuComboBox = new ComboBox();
            iconEditMenuButton = new FontAwesome.Sharp.IconButton();
            iconSaveMenuPermissonButton = new FontAwesome.Sharp.IconButton();
            selectMenuLabel = new Label();
            permissionDataGridView = new DataGridView();
            errorValidation = new ErrorProvider(components);
            menuTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuDataGridView).BeginInit();
            controlMenuGroupBox.SuspendLayout();
            permissionTabControl.SuspendLayout();
            permissionTabPage.SuspendLayout();
            accessGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rolPermissionDataGridView).BeginInit();
            permissionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)permissionDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorValidation).BeginInit();
            SuspendLayout();
            // 
            // menuTabPage
            // 
            menuTabPage.Controls.Add(menuDataGridView);
            menuTabPage.Controls.Add(controlMenuGroupBox);
            menuTabPage.Location = new Point(4, 30);
            menuTabPage.Name = "menuTabPage";
            menuTabPage.Padding = new Padding(3);
            menuTabPage.Size = new Size(1417, 719);
            menuTabPage.TabIndex = 1;
            menuTabPage.Text = "Menus";
            menuTabPage.UseVisualStyleBackColor = true;
            // 
            // menuDataGridView
            // 
            menuDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menuDataGridView.BackgroundColor = Color.LightGray;
            menuDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            menuDataGridView.Location = new Point(3, 294);
            menuDataGridView.Name = "menuDataGridView";
            menuDataGridView.RowHeadersWidth = 51;
            menuDataGridView.Size = new Size(1411, 467);
            menuDataGridView.TabIndex = 0;
            // 
            // controlMenuGroupBox
            // 
            controlMenuGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            controlMenuGroupBox.BackColor = SystemColors.Control;
            controlMenuGroupBox.Controls.Add(errorDescripionMenuLabel);
            controlMenuGroupBox.Controls.Add(errorNameMenuLabel);
            controlMenuGroupBox.Controls.Add(nameObjectTextBox);
            controlMenuGroupBox.Controls.Add(nameMenuLabel);
            controlMenuGroupBox.Controls.Add(nameMenuTextBox);
            controlMenuGroupBox.Controls.Add(nameObjectLabel);
            controlMenuGroupBox.Controls.Add(iconEditMenusButton);
            controlMenuGroupBox.Controls.Add(iconSaveMenusButton);
            controlMenuGroupBox.Controls.Add(iconDeleteMenusButton);
            controlMenuGroupBox.Location = new Point(6, 6);
            controlMenuGroupBox.Name = "controlMenuGroupBox";
            controlMenuGroupBox.Size = new Size(1406, 269);
            controlMenuGroupBox.TabIndex = 8;
            controlMenuGroupBox.TabStop = false;
            controlMenuGroupBox.Text = "Agregar nuevos menus";
            // 
            // errorDescripionMenuLabel
            // 
            errorDescripionMenuLabel.AutoSize = true;
            errorDescripionMenuLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorDescripionMenuLabel.ForeColor = Color.Red;
            errorDescripionMenuLabel.Location = new Point(40, 181);
            errorDescripionMenuLabel.Name = "errorDescripionMenuLabel";
            errorDescripionMenuLabel.Size = new Size(0, 21);
            errorDescripionMenuLabel.TabIndex = 9;
            // 
            // errorNameMenuLabel
            // 
            errorNameMenuLabel.AutoSize = true;
            errorNameMenuLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorNameMenuLabel.ForeColor = Color.Red;
            errorNameMenuLabel.Location = new Point(40, 91);
            errorNameMenuLabel.Name = "errorNameMenuLabel";
            errorNameMenuLabel.Size = new Size(0, 21);
            errorNameMenuLabel.TabIndex = 8;
            // 
            // nameObjectTextBox
            // 
            nameObjectTextBox.Location = new Point(40, 147);
            nameObjectTextBox.Name = "nameObjectTextBox";
            nameObjectTextBox.Size = new Size(436, 30);
            nameObjectTextBox.TabIndex = 7;
            // 
            // nameMenuLabel
            // 
            nameMenuLabel.AutoSize = true;
            nameMenuLabel.Location = new Point(40, 26);
            nameMenuLabel.Name = "nameMenuLabel";
            nameMenuLabel.Size = new Size(174, 21);
            nameMenuLabel.TabIndex = 6;
            nameMenuLabel.Text = "Nombre del menu:";
            // 
            // nameMenuTextBox
            // 
            nameMenuTextBox.Location = new Point(40, 58);
            nameMenuTextBox.Name = "nameMenuTextBox";
            nameMenuTextBox.Size = new Size(436, 30);
            nameMenuTextBox.TabIndex = 2;
            // 
            // nameObjectLabel
            // 
            nameObjectLabel.AutoSize = true;
            nameObjectLabel.Location = new Point(40, 122);
            nameObjectLabel.Name = "nameObjectLabel";
            nameObjectLabel.Size = new Size(288, 21);
            nameObjectLabel.TabIndex = 1;
            nameObjectLabel.Text = "Nombre del el objeto a mostrar:";
            // 
            // iconEditMenusButton
            // 
            iconEditMenusButton.BackColor = Color.FromArgb(255, 128, 0);
            iconEditMenusButton.FlatStyle = FlatStyle.Popup;
            iconEditMenusButton.ForeColor = Color.White;
            iconEditMenusButton.IconChar = FontAwesome.Sharp.IconChar.None;
            iconEditMenusButton.IconColor = Color.Black;
            iconEditMenusButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconEditMenusButton.Location = new Point(206, 212);
            iconEditMenusButton.Name = "iconEditMenusButton";
            iconEditMenusButton.Size = new Size(133, 38);
            iconEditMenusButton.TabIndex = 3;
            iconEditMenusButton.Text = "Editar";
            iconEditMenusButton.UseVisualStyleBackColor = false;
            iconEditMenusButton.Click += iconEditMenusButton_Click;
            // 
            // iconSaveMenusButton
            // 
            iconSaveMenusButton.BackColor = Color.FromArgb(0, 192, 0);
            iconSaveMenusButton.FlatStyle = FlatStyle.Popup;
            iconSaveMenusButton.ForeColor = Color.White;
            iconSaveMenusButton.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSaveMenusButton.IconColor = Color.Black;
            iconSaveMenusButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSaveMenusButton.Location = new Point(40, 212);
            iconSaveMenusButton.Name = "iconSaveMenusButton";
            iconSaveMenusButton.Size = new Size(133, 38);
            iconSaveMenusButton.TabIndex = 5;
            iconSaveMenusButton.Text = "Agregar";
            iconSaveMenusButton.UseVisualStyleBackColor = false;
            iconSaveMenusButton.Click += iconSaveMenusButton_Click;
            // 
            // iconDeleteMenusButton
            // 
            iconDeleteMenusButton.BackColor = Color.Red;
            iconDeleteMenusButton.FlatStyle = FlatStyle.Popup;
            iconDeleteMenusButton.ForeColor = Color.White;
            iconDeleteMenusButton.IconChar = FontAwesome.Sharp.IconChar.None;
            iconDeleteMenusButton.IconColor = Color.Black;
            iconDeleteMenusButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDeleteMenusButton.Location = new Point(385, 212);
            iconDeleteMenusButton.Name = "iconDeleteMenusButton";
            iconDeleteMenusButton.Size = new Size(133, 38);
            iconDeleteMenusButton.TabIndex = 4;
            iconDeleteMenusButton.Text = "Eliminar";
            iconDeleteMenusButton.UseVisualStyleBackColor = false;
            iconDeleteMenusButton.Click += iconDeleteMenusButton_Click;
            // 
            // permissionTabControl
            // 
            permissionTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            permissionTabControl.Controls.Add(permissionTabPage);
            permissionTabControl.Controls.Add(menuTabPage);
            permissionTabControl.Location = new Point(0, 0);
            permissionTabControl.Name = "permissionTabControl";
            permissionTabControl.SelectedIndex = 0;
            permissionTabControl.Size = new Size(1425, 753);
            permissionTabControl.TabIndex = 0;
            // 
            // permissionTabPage
            // 
            permissionTabPage.BackColor = SystemColors.Control;
            permissionTabPage.Controls.Add(accessGroupBox);
            permissionTabPage.Controls.Add(rolPermissionDataGridView);
            permissionTabPage.Controls.Add(permissionGroupBox);
            permissionTabPage.Controls.Add(permissionDataGridView);
            permissionTabPage.Location = new Point(4, 30);
            permissionTabPage.Name = "permissionTabPage";
            permissionTabPage.Padding = new Padding(3);
            permissionTabPage.Size = new Size(1417, 719);
            permissionTabPage.TabIndex = 2;
            permissionTabPage.Text = "Permisos";
            // 
            // accessGroupBox
            // 
            accessGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            accessGroupBox.Controls.Add(rolUserComboBox);
            accessGroupBox.Controls.Add(iconEditRolPermissionButton);
            accessGroupBox.Controls.Add(permissionIdComboBox);
            accessGroupBox.Controls.Add(iconSaveRolPermissionButton);
            accessGroupBox.Controls.Add(permissionIdLabel);
            accessGroupBox.Controls.Add(rolUserLabel);
            accessGroupBox.Location = new Point(730, 22);
            accessGroupBox.Name = "accessGroupBox";
            accessGroupBox.Size = new Size(681, 218);
            accessGroupBox.TabIndex = 6;
            accessGroupBox.TabStop = false;
            accessGroupBox.Text = "Dar acceso:";
            // 
            // rolUserComboBox
            // 
            rolUserComboBox.FormattingEnabled = true;
            rolUserComboBox.Location = new Point(23, 56);
            rolUserComboBox.Name = "rolUserComboBox";
            rolUserComboBox.Size = new Size(379, 29);
            rolUserComboBox.TabIndex = 9;
            // 
            // iconEditRolPermissionButton
            // 
            iconEditRolPermissionButton.BackColor = Color.DodgerBlue;
            iconEditRolPermissionButton.FlatStyle = FlatStyle.Popup;
            iconEditRolPermissionButton.ForeColor = Color.White;
            iconEditRolPermissionButton.IconChar = FontAwesome.Sharp.IconChar.None;
            iconEditRolPermissionButton.IconColor = Color.Black;
            iconEditRolPermissionButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconEditRolPermissionButton.Location = new Point(455, 128);
            iconEditRolPermissionButton.Name = "iconEditRolPermissionButton";
            iconEditRolPermissionButton.Size = new Size(160, 37);
            iconEditRolPermissionButton.TabIndex = 5;
            iconEditRolPermissionButton.Text = "Editar";
            iconEditRolPermissionButton.UseVisualStyleBackColor = false;
            iconEditRolPermissionButton.Click += iconEditRolPermissionButton_Click;
            // 
            // permissionIdComboBox
            // 
            permissionIdComboBox.FormattingEnabled = true;
            permissionIdComboBox.Location = new Point(23, 152);
            permissionIdComboBox.Name = "permissionIdComboBox";
            permissionIdComboBox.Size = new Size(379, 29);
            permissionIdComboBox.TabIndex = 8;
            // 
            // iconSaveRolPermissionButton
            // 
            iconSaveRolPermissionButton.BackColor = Color.FromArgb(0, 192, 0);
            iconSaveRolPermissionButton.FlatStyle = FlatStyle.Popup;
            iconSaveRolPermissionButton.ForeColor = Color.White;
            iconSaveRolPermissionButton.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSaveRolPermissionButton.IconColor = Color.Black;
            iconSaveRolPermissionButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSaveRolPermissionButton.Location = new Point(455, 67);
            iconSaveRolPermissionButton.Name = "iconSaveRolPermissionButton";
            iconSaveRolPermissionButton.Size = new Size(160, 38);
            iconSaveRolPermissionButton.TabIndex = 4;
            iconSaveRolPermissionButton.Text = "Agregar";
            iconSaveRolPermissionButton.UseVisualStyleBackColor = false;
            iconSaveRolPermissionButton.Click += iconSaveRolPermissionButton_Click;
            // 
            // permissionIdLabel
            // 
            permissionIdLabel.AutoSize = true;
            permissionIdLabel.Location = new Point(23, 128);
            permissionIdLabel.Name = "permissionIdLabel";
            permissionIdLabel.Size = new Size(226, 21);
            permissionIdLabel.TabIndex = 2;
            permissionIdLabel.Text = "Coloce el id del permiso:";
            // 
            // rolUserLabel
            // 
            rolUserLabel.AutoSize = true;
            rolUserLabel.Location = new Point(23, 33);
            rolUserLabel.Name = "rolUserLabel";
            rolUserLabel.Size = new Size(224, 21);
            rolUserLabel.TabIndex = 0;
            rolUserLabel.Text = "Coloce el rol del usuario:";
            // 
            // rolPermissionDataGridView
            // 
            rolPermissionDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rolPermissionDataGridView.BackgroundColor = Color.LightGray;
            rolPermissionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rolPermissionDataGridView.Location = new Point(730, 246);
            rolPermissionDataGridView.Name = "rolPermissionDataGridView";
            rolPermissionDataGridView.RowHeadersWidth = 51;
            rolPermissionDataGridView.Size = new Size(681, 468);
            rolPermissionDataGridView.TabIndex = 5;
            // 
            // permissionGroupBox
            // 
            permissionGroupBox.Controls.Add(selectMenuComboBox);
            permissionGroupBox.Controls.Add(iconEditMenuButton);
            permissionGroupBox.Controls.Add(iconSaveMenuPermissonButton);
            permissionGroupBox.Controls.Add(selectMenuLabel);
            permissionGroupBox.Location = new Point(10, 22);
            permissionGroupBox.Name = "permissionGroupBox";
            permissionGroupBox.Size = new Size(697, 218);
            permissionGroupBox.TabIndex = 4;
            permissionGroupBox.TabStop = false;
            permissionGroupBox.Text = "Permisos:";
            // 
            // selectMenuComboBox
            // 
            selectMenuComboBox.FormattingEnabled = true;
            selectMenuComboBox.Location = new Point(23, 77);
            selectMenuComboBox.Name = "selectMenuComboBox";
            selectMenuComboBox.Size = new Size(379, 29);
            selectMenuComboBox.TabIndex = 7;
            // 
            // iconEditMenuButton
            // 
            iconEditMenuButton.BackColor = Color.DodgerBlue;
            iconEditMenuButton.FlatStyle = FlatStyle.Popup;
            iconEditMenuButton.ForeColor = Color.White;
            iconEditMenuButton.IconChar = FontAwesome.Sharp.IconChar.None;
            iconEditMenuButton.IconColor = Color.Black;
            iconEditMenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconEditMenuButton.Location = new Point(455, 108);
            iconEditMenuButton.Name = "iconEditMenuButton";
            iconEditMenuButton.Size = new Size(160, 29);
            iconEditMenuButton.TabIndex = 5;
            iconEditMenuButton.Text = "Editar";
            iconEditMenuButton.UseVisualStyleBackColor = false;
            iconEditMenuButton.Click += iconEditMenuButton_Click;
            // 
            // iconSaveMenuPermissonButton
            // 
            iconSaveMenuPermissonButton.BackColor = Color.FromArgb(0, 192, 0);
            iconSaveMenuPermissonButton.FlatStyle = FlatStyle.Popup;
            iconSaveMenuPermissonButton.ForeColor = Color.White;
            iconSaveMenuPermissonButton.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSaveMenuPermissonButton.IconColor = Color.Black;
            iconSaveMenuPermissonButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSaveMenuPermissonButton.Location = new Point(455, 52);
            iconSaveMenuPermissonButton.Name = "iconSaveMenuPermissonButton";
            iconSaveMenuPermissonButton.Size = new Size(160, 35);
            iconSaveMenuPermissonButton.TabIndex = 4;
            iconSaveMenuPermissonButton.Text = "Agregar";
            iconSaveMenuPermissonButton.UseVisualStyleBackColor = false;
            iconSaveMenuPermissonButton.Click += iconSaveMenuPermissonButton_Click;
            // 
            // selectMenuLabel
            // 
            selectMenuLabel.AutoSize = true;
            selectMenuLabel.Location = new Point(23, 49);
            selectMenuLabel.Name = "selectMenuLabel";
            selectMenuLabel.Size = new Size(194, 21);
            selectMenuLabel.TabIndex = 0;
            selectMenuLabel.Text = "Seleccionar el menu:";
            // 
            // permissionDataGridView
            // 
            permissionDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            permissionDataGridView.BackgroundColor = Color.LightGray;
            permissionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            permissionDataGridView.Location = new Point(8, 246);
            permissionDataGridView.Name = "permissionDataGridView";
            permissionDataGridView.RowHeadersWidth = 51;
            permissionDataGridView.Size = new Size(699, 468);
            permissionDataGridView.TabIndex = 2;
            // 
            // errorValidation
            // 
            errorValidation.ContainerControl = this;
            // 
            // PermissionForm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1428, 753);
            Controls.Add(permissionTabControl);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "PermissionForm";
            Text = "Permisos ";
            menuTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menuDataGridView).EndInit();
            controlMenuGroupBox.ResumeLayout(false);
            controlMenuGroupBox.PerformLayout();
            permissionTabControl.ResumeLayout(false);
            permissionTabPage.ResumeLayout(false);
            accessGroupBox.ResumeLayout(false);
            accessGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rolPermissionDataGridView).EndInit();
            permissionGroupBox.ResumeLayout(false);
            permissionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)permissionDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorValidation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage menuTabPage;
        private TextBox nameObjectTextBox;
        private TextBox nameMenuTextBox;
        private Label nameMenuLabel;
        private FontAwesome.Sharp.IconButton iconSaveMenusButton;
        private FontAwesome.Sharp.IconButton iconDeleteMenusButton;
        private FontAwesome.Sharp.IconButton iconEditMenusButton;
        private Label nameObjectLabel;
        private DataGridView menuDataGridView;
        private TabControl permissionTabControl;
        private TabPage permissionTabPage;
        private GroupBox permissionGroupBox;
        private TextBox textBoxidPermission;
        private Label label5;
        private TextBox textBoxidRol;
        private Label selectMenuLabel;
        private DataGridView permissionDataGridView;
        private FontAwesome.Sharp.IconButton iconEditMenuButton;
        private FontAwesome.Sharp.IconButton iconSaveMenuPermissonButton;
        private GroupBox accessGroupBox;
        private FontAwesome.Sharp.IconButton iconEditRolPermissionButton;
        private FontAwesome.Sharp.IconButton iconSaveRolPermissionButton;
        private Label permissionIdLabel;
        private Label rolUserLabel;
        private DataGridView rolPermissionDataGridView;
        private GroupBox controlMenuGroupBox;
        private ComboBox selectMenuComboBox;
        private ComboBox rolUserComboBox;
        private ComboBox permissionIdComboBox;
        private Label errorDescripionMenuLabel;
        private Label errorNameMenuLabel;
        private ErrorProvider errorValidation;
    }
}