namespace PresentationLayer.Forms
{
    partial class AddUsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUsersForm));
            addUserLabel = new Label();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            rolComboBox = new ComboBox();
            rolLabel = new Label();
            detailsUserGroupBox = new GroupBox();
            errorStatusLabel = new Label();
            errorPasswordLabel = new Label();
            errorPhoneNumberLabel = new Label();
            errorBirthdayLabel = new Label();
            errorLastNameLabel = new Label();
            errorNameLabel = new Label();
            errorRolLabel = new Label();
            errorEmailLabel = new Label();
            errorUserNameLabel = new Label();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            nameUserLabel = new Label();
            nameUserTextBox = new TextBox();
            birthdateDateTimePicker = new DateTimePicker();
            numberPhoneLabel = new Label();
            numberPhoneTextBox = new TextBox();
            statusComboBox = new ComboBox();
            statusLabel = new Label();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            dateLabel = new Label();
            lastNameLabel = new Label();
            lastNameTextBox = new TextBox();
            countryGroupBox = new GroupBox();
            errorWorkStationLabel = new Label();
            errorProfessionLabel = new Label();
            workStationLabel = new Label();
            workStationTextBox = new TextBox();
            professionLabel = new Label();
            professionsTextBox = new TextBox();
            DesactiveEmpleoyeeiconButton = new FontAwesome.Sharp.IconButton();
            errorSelectImagenLabel = new Label();
            errorCityLabel = new Label();
            errorCountryLabel = new Label();
            dateRegistreDateTimePicker = new DateTimePicker();
            editButton = new FontAwesome.Sharp.IconButton();
            cityLabel = new Label();
            cityListComboBox = new ComboBox();
            saveButton = new FontAwesome.Sharp.IconButton();
            countrysComboBox = new ComboBox();
            countryUserLabel = new Label();
            profilePictureBox = new PictureBox();
            informationPanel = new Panel();
            errorValidation = new ErrorProvider(components);
            detailsUserGroupBox.SuspendLayout();
            countryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).BeginInit();
            informationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorValidation).BeginInit();
            SuspendLayout();
            // 
            // addUserLabel
            // 
            addUserLabel.BackColor = Color.DodgerBlue;
            addUserLabel.Dock = DockStyle.Top;
            addUserLabel.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addUserLabel.Location = new Point(0, 0);
            addUserLabel.Name = "addUserLabel";
            addUserLabel.Size = new Size(1293, 64);
            addUserLabel.TabIndex = 0;
            addUserLabel.Text = "Añadir";
            addUserLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.ForeColor = Color.Black;
            nameLabel.Location = new Point(133, 241);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(82, 21);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Nombre:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(264, 238);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(346, 28);
            nameTextBox.TabIndex = 2;
            // 
            // rolComboBox
            // 
            rolComboBox.FormattingEnabled = true;
            rolComboBox.Location = new Point(266, 172);
            rolComboBox.Name = "rolComboBox";
            rolComboBox.Size = new Size(344, 29);
            rolComboBox.TabIndex = 7;
            rolComboBox.SelectedIndexChanged += rolComboBox_SelectedIndexChanged;
            // 
            // rolLabel
            // 
            rolLabel.AutoSize = true;
            rolLabel.ForeColor = Color.Black;
            rolLabel.Location = new Point(183, 180);
            rolLabel.Name = "rolLabel";
            rolLabel.Size = new Size(39, 21);
            rolLabel.TabIndex = 8;
            rolLabel.Text = "Rol:";
            // 
            // detailsUserGroupBox
            // 
            detailsUserGroupBox.Controls.Add(errorStatusLabel);
            detailsUserGroupBox.Controls.Add(errorPasswordLabel);
            detailsUserGroupBox.Controls.Add(errorPhoneNumberLabel);
            detailsUserGroupBox.Controls.Add(errorBirthdayLabel);
            detailsUserGroupBox.Controls.Add(errorLastNameLabel);
            detailsUserGroupBox.Controls.Add(errorNameLabel);
            detailsUserGroupBox.Controls.Add(errorRolLabel);
            detailsUserGroupBox.Controls.Add(errorEmailLabel);
            detailsUserGroupBox.Controls.Add(errorUserNameLabel);
            detailsUserGroupBox.Controls.Add(emailLabel);
            detailsUserGroupBox.Controls.Add(emailTextBox);
            detailsUserGroupBox.Controls.Add(nameUserLabel);
            detailsUserGroupBox.Controls.Add(nameUserTextBox);
            detailsUserGroupBox.Controls.Add(birthdateDateTimePicker);
            detailsUserGroupBox.Controls.Add(numberPhoneLabel);
            detailsUserGroupBox.Controls.Add(numberPhoneTextBox);
            detailsUserGroupBox.Controls.Add(statusComboBox);
            detailsUserGroupBox.Controls.Add(rolComboBox);
            detailsUserGroupBox.Controls.Add(statusLabel);
            detailsUserGroupBox.Controls.Add(passwordLabel);
            detailsUserGroupBox.Controls.Add(rolLabel);
            detailsUserGroupBox.Controls.Add(passwordTextBox);
            detailsUserGroupBox.Controls.Add(nameLabel);
            detailsUserGroupBox.Controls.Add(nameTextBox);
            detailsUserGroupBox.Controls.Add(dateLabel);
            detailsUserGroupBox.Controls.Add(lastNameLabel);
            detailsUserGroupBox.Controls.Add(lastNameTextBox);
            detailsUserGroupBox.Dock = DockStyle.Left;
            detailsUserGroupBox.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            detailsUserGroupBox.Location = new Point(0, 0);
            detailsUserGroupBox.Name = "detailsUserGroupBox";
            detailsUserGroupBox.Size = new Size(642, 730);
            detailsUserGroupBox.TabIndex = 15;
            detailsUserGroupBox.TabStop = false;
            detailsUserGroupBox.Text = "Datos Del Usuario";
            // 
            // errorStatusLabel
            // 
            errorStatusLabel.AutoSize = true;
            errorStatusLabel.BackColor = Color.Transparent;
            errorStatusLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorStatusLabel.ForeColor = Color.Red;
            errorStatusLabel.Location = new Point(144, 643);
            errorStatusLabel.Name = "errorStatusLabel";
            errorStatusLabel.Size = new Size(0, 18);
            errorStatusLabel.TabIndex = 32;
            // 
            // errorPasswordLabel
            // 
            errorPasswordLabel.AutoSize = true;
            errorPasswordLabel.BackColor = Color.Transparent;
            errorPasswordLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorPasswordLabel.ForeColor = Color.Red;
            errorPasswordLabel.Location = new Point(144, 564);
            errorPasswordLabel.Name = "errorPasswordLabel";
            errorPasswordLabel.Size = new Size(0, 18);
            errorPasswordLabel.TabIndex = 31;
            // 
            // errorPhoneNumberLabel
            // 
            errorPhoneNumberLabel.AutoSize = true;
            errorPhoneNumberLabel.BackColor = Color.Transparent;
            errorPhoneNumberLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorPhoneNumberLabel.ForeColor = Color.Red;
            errorPhoneNumberLabel.Location = new Point(140, 495);
            errorPhoneNumberLabel.Name = "errorPhoneNumberLabel";
            errorPhoneNumberLabel.Size = new Size(0, 18);
            errorPhoneNumberLabel.TabIndex = 30;
            // 
            // errorBirthdayLabel
            // 
            errorBirthdayLabel.AutoSize = true;
            errorBirthdayLabel.BackColor = Color.Transparent;
            errorBirthdayLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorBirthdayLabel.ForeColor = Color.Red;
            errorBirthdayLabel.Location = new Point(144, 425);
            errorBirthdayLabel.Name = "errorBirthdayLabel";
            errorBirthdayLabel.Size = new Size(0, 18);
            errorBirthdayLabel.TabIndex = 29;
            // 
            // errorLastNameLabel
            // 
            errorLastNameLabel.AutoSize = true;
            errorLastNameLabel.BackColor = Color.Transparent;
            errorLastNameLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorLastNameLabel.ForeColor = Color.Red;
            errorLastNameLabel.Location = new Point(144, 358);
            errorLastNameLabel.Name = "errorLastNameLabel";
            errorLastNameLabel.Size = new Size(0, 18);
            errorLastNameLabel.TabIndex = 28;
            // 
            // errorNameLabel
            // 
            errorNameLabel.AutoSize = true;
            errorNameLabel.BackColor = Color.Transparent;
            errorNameLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorNameLabel.ForeColor = Color.Red;
            errorNameLabel.Location = new Point(144, 287);
            errorNameLabel.Name = "errorNameLabel";
            errorNameLabel.Size = new Size(0, 18);
            errorNameLabel.TabIndex = 27;
            // 
            // errorRolLabel
            // 
            errorRolLabel.AutoSize = true;
            errorRolLabel.BackColor = Color.Transparent;
            errorRolLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorRolLabel.ForeColor = Color.Red;
            errorRolLabel.Location = new Point(140, 210);
            errorRolLabel.Name = "errorRolLabel";
            errorRolLabel.Size = new Size(0, 18);
            errorRolLabel.TabIndex = 26;
            // 
            // errorEmailLabel
            // 
            errorEmailLabel.AutoSize = true;
            errorEmailLabel.BackColor = Color.Transparent;
            errorEmailLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorEmailLabel.ForeColor = Color.Red;
            errorEmailLabel.Location = new Point(140, 141);
            errorEmailLabel.Name = "errorEmailLabel";
            errorEmailLabel.Size = new Size(0, 18);
            errorEmailLabel.TabIndex = 25;
            // 
            // errorUserNameLabel
            // 
            errorUserNameLabel.AutoSize = true;
            errorUserNameLabel.BackColor = Color.Transparent;
            errorUserNameLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorUserNameLabel.ForeColor = Color.Red;
            errorUserNameLabel.Location = new Point(140, 74);
            errorUserNameLabel.Name = "errorUserNameLabel";
            errorUserNameLabel.Size = new Size(0, 18);
            errorUserNameLabel.TabIndex = 24;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.ForeColor = Color.Black;
            emailLabel.Location = new Point(31, 101);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(169, 21);
            emailLabel.TabIndex = 22;
            emailLabel.Text = "Correo Electronico:";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(266, 98);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(344, 28);
            emailTextBox.TabIndex = 23;
            // 
            // nameUserLabel
            // 
            nameUserLabel.AutoSize = true;
            nameUserLabel.ForeColor = Color.Black;
            nameUserLabel.Location = new Point(144, 43);
            nameUserLabel.Name = "nameUserLabel";
            nameUserLabel.Size = new Size(75, 21);
            nameUserLabel.TabIndex = 20;
            nameUserLabel.Text = "Usuario:";
            // 
            // nameUserTextBox
            // 
            nameUserTextBox.Location = new Point(266, 43);
            nameUserTextBox.Name = "nameUserTextBox";
            nameUserTextBox.Size = new Size(346, 28);
            nameUserTextBox.TabIndex = 21;
            // 
            // birthdateDateTimePicker
            // 
            birthdateDateTimePicker.Location = new Point(262, 380);
            birthdateDateTimePicker.Name = "birthdateDateTimePicker";
            birthdateDateTimePicker.Size = new Size(346, 28);
            birthdateDateTimePicker.TabIndex = 19;
            // 
            // numberPhoneLabel
            // 
            numberPhoneLabel.AutoSize = true;
            numberPhoneLabel.ForeColor = Color.Black;
            numberPhoneLabel.Location = new Point(130, 458);
            numberPhoneLabel.Name = "numberPhoneLabel";
            numberPhoneLabel.Size = new Size(85, 21);
            numberPhoneLabel.TabIndex = 17;
            numberPhoneLabel.Text = "Telefono:";
            // 
            // numberPhoneTextBox
            // 
            numberPhoneTextBox.Location = new Point(262, 449);
            numberPhoneTextBox.Name = "numberPhoneTextBox";
            numberPhoneTextBox.Size = new Size(346, 28);
            numberPhoneTextBox.TabIndex = 18;
            // 
            // statusComboBox
            // 
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(262, 592);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(346, 29);
            statusComboBox.TabIndex = 15;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.ForeColor = Color.Black;
            statusLabel.Location = new Point(133, 595);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(73, 21);
            statusLabel.TabIndex = 16;
            statusLabel.Text = "Estado:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = Color.Black;
            passwordLabel.Location = new Point(98, 522);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(114, 21);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Contraseña:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(262, 519);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(346, 28);
            passwordTextBox.TabIndex = 8;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.ForeColor = Color.Black;
            dateLabel.Location = new Point(0, 389);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(196, 21);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "Fecha de Nacimiento:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.ForeColor = Color.Black;
            lastNameLabel.Location = new Point(131, 321);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(83, 21);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Apellido:";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(264, 318);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(344, 28);
            lastNameTextBox.TabIndex = 6;
            // 
            // countryGroupBox
            // 
            countryGroupBox.Controls.Add(errorWorkStationLabel);
            countryGroupBox.Controls.Add(errorProfessionLabel);
            countryGroupBox.Controls.Add(workStationLabel);
            countryGroupBox.Controls.Add(workStationTextBox);
            countryGroupBox.Controls.Add(professionLabel);
            countryGroupBox.Controls.Add(professionsTextBox);
            countryGroupBox.Controls.Add(DesactiveEmpleoyeeiconButton);
            countryGroupBox.Controls.Add(errorSelectImagenLabel);
            countryGroupBox.Controls.Add(errorCityLabel);
            countryGroupBox.Controls.Add(errorCountryLabel);
            countryGroupBox.Controls.Add(dateRegistreDateTimePicker);
            countryGroupBox.Controls.Add(editButton);
            countryGroupBox.Controls.Add(cityLabel);
            countryGroupBox.Controls.Add(cityListComboBox);
            countryGroupBox.Controls.Add(saveButton);
            countryGroupBox.Controls.Add(countrysComboBox);
            countryGroupBox.Controls.Add(countryUserLabel);
            countryGroupBox.Dock = DockStyle.Right;
            countryGroupBox.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            countryGroupBox.ForeColor = Color.Black;
            countryGroupBox.Location = new Point(665, 0);
            countryGroupBox.Name = "countryGroupBox";
            countryGroupBox.Size = new Size(628, 730);
            countryGroupBox.TabIndex = 16;
            countryGroupBox.TabStop = false;
            countryGroupBox.Text = "Provinencia";
            // 
            // errorWorkStationLabel
            // 
            errorWorkStationLabel.AutoSize = true;
            errorWorkStationLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorWorkStationLabel.ForeColor = Color.Red;
            errorWorkStationLabel.Location = new Point(151, 460);
            errorWorkStationLabel.Name = "errorWorkStationLabel";
            errorWorkStationLabel.Size = new Size(54, 18);
            errorWorkStationLabel.TabIndex = 44;
            errorWorkStationLabel.Text = "label2";
            errorWorkStationLabel.Visible = false;
            // 
            // errorProfessionLabel
            // 
            errorProfessionLabel.AutoSize = true;
            errorProfessionLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorProfessionLabel.ForeColor = Color.Red;
            errorProfessionLabel.Location = new Point(151, 346);
            errorProfessionLabel.Name = "errorProfessionLabel";
            errorProfessionLabel.Size = new Size(54, 18);
            errorProfessionLabel.TabIndex = 43;
            errorProfessionLabel.Text = "label1";
            errorProfessionLabel.Visible = false;
            // 
            // workStationLabel
            // 
            workStationLabel.AutoSize = true;
            workStationLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            workStationLabel.ForeColor = Color.White;
            workStationLabel.Location = new Point(241, 375);
            workStationLabel.Name = "workStationLabel";
            workStationLabel.Size = new Size(190, 23);
            workStationLabel.TabIndex = 41;
            workStationLabel.Text = "Puesto de trabajo:";
            workStationLabel.Visible = false;
            // 
            // workStationTextBox
            // 
            workStationTextBox.Location = new Point(151, 408);
            workStationTextBox.Name = "workStationTextBox";
            workStationTextBox.Size = new Size(409, 28);
            workStationTextBox.TabIndex = 42;
            workStationTextBox.Visible = false;
            // 
            // professionLabel
            // 
            professionLabel.AutoSize = true;
            professionLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            professionLabel.ForeColor = Color.White;
            professionLabel.Location = new Point(273, 222);
            professionLabel.Name = "professionLabel";
            professionLabel.Size = new Size(101, 23);
            professionLabel.TabIndex = 39;
            professionLabel.Text = "Profesión:";
            professionLabel.Visible = false;
            // 
            // professionsTextBox
            // 
            professionsTextBox.Location = new Point(151, 255);
            professionsTextBox.Multiline = true;
            professionsTextBox.Name = "professionsTextBox";
            professionsTextBox.Size = new Size(409, 76);
            professionsTextBox.TabIndex = 40;
            professionsTextBox.Visible = false;
            // 
            // DesactiveEmpleoyeeiconButton
            // 
            DesactiveEmpleoyeeiconButton.BackColor = Color.Brown;
            DesactiveEmpleoyeeiconButton.FlatAppearance.BorderSize = 0;
            DesactiveEmpleoyeeiconButton.FlatStyle = FlatStyle.Popup;
            DesactiveEmpleoyeeiconButton.ForeColor = Color.White;
            DesactiveEmpleoyeeiconButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            DesactiveEmpleoyeeiconButton.IconColor = Color.White;
            DesactiveEmpleoyeeiconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DesactiveEmpleoyeeiconButton.IconSize = 28;
            DesactiveEmpleoyeeiconButton.ImageAlign = ContentAlignment.MiddleLeft;
            DesactiveEmpleoyeeiconButton.Location = new Point(358, 546);
            DesactiveEmpleoyeeiconButton.Name = "DesactiveEmpleoyeeiconButton";
            DesactiveEmpleoyeeiconButton.Size = new Size(215, 46);
            DesactiveEmpleoyeeiconButton.TabIndex = 37;
            DesactiveEmpleoyeeiconButton.Text = "Desactivar";
            DesactiveEmpleoyeeiconButton.UseVisualStyleBackColor = false;
            DesactiveEmpleoyeeiconButton.Click += DesactiveEmpleoyeeiconButton_Click;
            // 
            // errorSelectImagenLabel
            // 
            errorSelectImagenLabel.AutoSize = true;
            errorSelectImagenLabel.BackColor = Color.Transparent;
            errorSelectImagenLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorSelectImagenLabel.ForeColor = Color.Red;
            errorSelectImagenLabel.Location = new Point(60, 509);
            errorSelectImagenLabel.Name = "errorSelectImagenLabel";
            errorSelectImagenLabel.Size = new Size(0, 18);
            errorSelectImagenLabel.TabIndex = 36;
            // 
            // errorCityLabel
            // 
            errorCityLabel.AutoSize = true;
            errorCityLabel.BackColor = Color.Transparent;
            errorCityLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorCityLabel.ForeColor = Color.Red;
            errorCityLabel.Location = new Point(60, 172);
            errorCityLabel.Name = "errorCityLabel";
            errorCityLabel.Size = new Size(0, 18);
            errorCityLabel.TabIndex = 33;
            // 
            // errorCountryLabel
            // 
            errorCountryLabel.AutoSize = true;
            errorCountryLabel.BackColor = Color.Transparent;
            errorCountryLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorCountryLabel.ForeColor = Color.Red;
            errorCountryLabel.Location = new Point(60, 86);
            errorCountryLabel.Name = "errorCountryLabel";
            errorCountryLabel.Size = new Size(0, 18);
            errorCountryLabel.TabIndex = 32;
            // 
            // dateRegistreDateTimePicker
            // 
            dateRegistreDateTimePicker.Enabled = false;
            dateRegistreDateTimePicker.Location = new Point(160, 155);
            dateRegistreDateTimePicker.Name = "dateRegistreDateTimePicker";
            dateRegistreDateTimePicker.Size = new Size(380, 28);
            dateRegistreDateTimePicker.TabIndex = 15;
            dateRegistreDateTimePicker.Visible = false;
            // 
            // editButton
            // 
            editButton.BackColor = SystemColors.HotTrack;
            editButton.FlatAppearance.BorderSize = 0;
            editButton.FlatStyle = FlatStyle.Popup;
            editButton.ForeColor = Color.White;
            editButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            editButton.IconColor = Color.White;
            editButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editButton.IconSize = 28;
            editButton.ImageAlign = ContentAlignment.MiddleLeft;
            editButton.Location = new Point(125, 546);
            editButton.Name = "editButton";
            editButton.Size = new Size(215, 46);
            editButton.TabIndex = 18;
            editButton.Text = "Editar";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(25, 128);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(78, 21);
            cityLabel.TabIndex = 14;
            cityLabel.Text = "Ciudad:";
            // 
            // cityListComboBox
            // 
            cityListComboBox.FormattingEnabled = true;
            cityListComboBox.Location = new Point(160, 120);
            cityListComboBox.Name = "cityListComboBox";
            cityListComboBox.Size = new Size(383, 29);
            cityListComboBox.TabIndex = 13;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.Green;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Popup;
            saveButton.ForeColor = Color.White;
            saveButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            saveButton.IconColor = Color.White;
            saveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            saveButton.IconSize = 28;
            saveButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveButton.Location = new Point(125, 546);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(215, 46);
            saveButton.TabIndex = 17;
            saveButton.Text = "Añadir";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // countrysComboBox
            // 
            countrysComboBox.FormattingEnabled = true;
            countrysComboBox.Location = new Point(160, 43);
            countrysComboBox.Name = "countrysComboBox";
            countrysComboBox.Size = new Size(383, 29);
            countrysComboBox.TabIndex = 9;
            // 
            // countryUserLabel
            // 
            countryUserLabel.AutoSize = true;
            countryUserLabel.Location = new Point(61, 45);
            countryUserLabel.Name = "countryUserLabel";
            countryUserLabel.Size = new Size(47, 21);
            countryUserLabel.TabIndex = 10;
            countryUserLabel.Text = "Pais:";
            // 
            // profilePictureBox
            // 
            profilePictureBox.Location = new Point(12, 12);
            profilePictureBox.Name = "profilePictureBox";
            profilePictureBox.Size = new Size(55, 41);
            profilePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            profilePictureBox.TabIndex = 38;
            profilePictureBox.TabStop = false;
            // 
            // informationPanel
            // 
            informationPanel.BackColor = Color.LightGray;
            informationPanel.Controls.Add(detailsUserGroupBox);
            informationPanel.Controls.Add(countryGroupBox);
            informationPanel.Dock = DockStyle.Fill;
            informationPanel.Location = new Point(0, 64);
            informationPanel.Name = "informationPanel";
            informationPanel.Size = new Size(1293, 730);
            informationPanel.TabIndex = 19;
            // 
            // errorValidation
            // 
            errorValidation.ContainerControl = this;
            // 
            // AddUsersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1293, 794);
            Controls.Add(profilePictureBox);
            Controls.Add(informationPanel);
            Controls.Add(addUserLabel);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddUsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Añadir Usuarios";
            Load += AddUsersForm_Load;
            detailsUserGroupBox.ResumeLayout(false);
            detailsUserGroupBox.PerformLayout();
            countryGroupBox.ResumeLayout(false);
            countryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).EndInit();
            informationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorValidation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label addUserLabel;
        private Label nameLabel;
        private TextBox nameTextBox;
        private ComboBox rolComboBox;
        private Label rolLabel;
        private Label errorPhoneNumberLabel;
        private ComboBox c;
        private GroupBox detailsUserGroupBox;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private GroupBox countryGroupBox;
        private FontAwesome.Sharp.IconButton saveButton;
        private ComboBox statusComboBox;
        private Label statusLabel;
        private FontAwesome.Sharp.IconButton editButton;
        private DateTimePicker dateRegistreDateTimePicker;
        private Label numberPhoneLabel;
        private TextBox numberPhoneTextBox;
        private Label dateLabel;
        private Label lastNameLabel;
        private TextBox lastNameTextBox;
        private DateTimePicker birthdateDateTimePicker;
        private Label cityLabel;
        private ComboBox cityListComboBox;
        private ComboBox countrysComboBox;
        private Label countryUserLabel;
        private Label nameUserLabel;
        private TextBox nameUserTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Panel informationPanel;
        private Label errorUserNameLabel;
        private ErrorProvider errorValidation;
        private Label errorPasswordLabel;
        private Label errorBirthdayLabel;
        private Label errorLastNameLabel;
        private Label errorNameLabel;
        private Label errorRolLabel;
        private Label errorEmailLabel;
        private Label errorCityLabel;
        private Label errorCountryLabel;
        private Label errorStatusLabel;
        private Label errorSelectImagenLabel;
        private FontAwesome.Sharp.IconButton DesactiveEmpleoyeeiconButton;
        private PictureBox profilePictureBox;
        private Label errorWorkStationLabel;
        private Label errorProfessionLabel;
        private Label workStationLabel;
        private TextBox workStationTextBox;
        private Label professionLabel;
        private TextBox professionsTextBox;
    }
}