namespace PresentationLayer
{
    partial class NewAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAccountForm));
            minimizePictureBox = new PictureBox();
            closedPictureBox = new PictureBox();
            titleLabel = new Label();
            registerGroupBox = new GroupBox();
            errorSelectImagen = new Label();
            errorCityLabel = new Label();
            errorCountryLabel = new Label();
            errorPasswordLabel = new Label();
            errorPhoneNumberLabel = new Label();
            errorBirthDayLabel = new Label();
            errorEmailLabel = new Label();
            errorLastNameLabel = new Label();
            errorUserNameLabel = new Label();
            errorUserLabel = new Label();
            selectImageUserLabel = new Label();
            photoNewUserPictureBox = new PictureBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            userLabel = new Label();
            userNameTextBox = new TextBox();
            privacyLabel = new Label();
            loginLabel = new Label();
            existingAccountLabel = new Label();
            registerSaveButton = new FontAwesome.Sharp.IconButton();
            cityLabel = new Label();
            listCityComboBox = new ComboBox();
            listCountrysComboBox = new ComboBox();
            countryLabel = new Label();
            birthdayDateTimePicker = new DateTimePicker();
            phoneNumberLabel = new Label();
            numberPhoneTextBox = new TextBox();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            nameLabel = new Label();
            nameTexBox = new TextBox();
            birthdayLabel = new Label();
            lastNameLabel = new Label();
            lastNameTexBox = new TextBox();
            toolTip1 = new ToolTip(components);
            notifyIcon1 = new NotifyIcon(components);
            errorValidation = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)minimizePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closedPictureBox).BeginInit();
            registerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)photoNewUserPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorValidation).BeginInit();
            SuspendLayout();
            // 
            // minimizePictureBox
            // 
            minimizePictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizePictureBox.BackColor = Color.Transparent;
            minimizePictureBox.Cursor = Cursors.Hand;
            minimizePictureBox.Image = (Image)resources.GetObject("minimizePictureBox.Image");
            minimizePictureBox.Location = new Point(602, 11);
            minimizePictureBox.Name = "minimizePictureBox";
            minimizePictureBox.Size = new Size(39, 32);
            minimizePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            minimizePictureBox.TabIndex = 7;
            minimizePictureBox.TabStop = false;
            minimizePictureBox.Click += minimizePictureBox_Click;
            minimizePictureBox.MouseHover += minimizePictureBox_MouseHover;
            // 
            // closedPictureBox
            // 
            closedPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closedPictureBox.BackColor = Color.Transparent;
            closedPictureBox.Cursor = Cursors.Hand;
            closedPictureBox.Image = Properties.Resources.cerrar__2_;
            closedPictureBox.Location = new Point(647, 11);
            closedPictureBox.Name = "closedPictureBox";
            closedPictureBox.Size = new Size(39, 32);
            closedPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            closedPictureBox.TabIndex = 6;
            closedPictureBox.TabStop = false;
            closedPictureBox.Click += closedPictureBox_Click;
            closedPictureBox.MouseHover += closedPictureBox_MouseHover;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.DodgerBlue;
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(3, 22);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(645, 44);
            titleLabel.TabIndex = 8;
            titleLabel.Text = "Registrarse";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // registerGroupBox
            // 
            registerGroupBox.BackColor = Color.LightGray;
            registerGroupBox.Controls.Add(errorSelectImagen);
            registerGroupBox.Controls.Add(errorCityLabel);
            registerGroupBox.Controls.Add(errorCountryLabel);
            registerGroupBox.Controls.Add(errorPasswordLabel);
            registerGroupBox.Controls.Add(errorPhoneNumberLabel);
            registerGroupBox.Controls.Add(errorBirthDayLabel);
            registerGroupBox.Controls.Add(errorEmailLabel);
            registerGroupBox.Controls.Add(errorLastNameLabel);
            registerGroupBox.Controls.Add(errorUserNameLabel);
            registerGroupBox.Controls.Add(errorUserLabel);
            registerGroupBox.Controls.Add(selectImageUserLabel);
            registerGroupBox.Controls.Add(photoNewUserPictureBox);
            registerGroupBox.Controls.Add(emailLabel);
            registerGroupBox.Controls.Add(emailTextBox);
            registerGroupBox.Controls.Add(userLabel);
            registerGroupBox.Controls.Add(userNameTextBox);
            registerGroupBox.Controls.Add(privacyLabel);
            registerGroupBox.Controls.Add(loginLabel);
            registerGroupBox.Controls.Add(existingAccountLabel);
            registerGroupBox.Controls.Add(titleLabel);
            registerGroupBox.Controls.Add(registerSaveButton);
            registerGroupBox.Controls.Add(cityLabel);
            registerGroupBox.Controls.Add(listCityComboBox);
            registerGroupBox.Controls.Add(listCountrysComboBox);
            registerGroupBox.Controls.Add(countryLabel);
            registerGroupBox.Controls.Add(birthdayDateTimePicker);
            registerGroupBox.Controls.Add(phoneNumberLabel);
            registerGroupBox.Controls.Add(numberPhoneTextBox);
            registerGroupBox.Controls.Add(passwordLabel);
            registerGroupBox.Controls.Add(passwordTextBox);
            registerGroupBox.Controls.Add(nameLabel);
            registerGroupBox.Controls.Add(nameTexBox);
            registerGroupBox.Controls.Add(birthdayLabel);
            registerGroupBox.Controls.Add(lastNameLabel);
            registerGroupBox.Controls.Add(lastNameTexBox);
            registerGroupBox.Location = new Point(26, 49);
            registerGroupBox.Name = "registerGroupBox";
            registerGroupBox.Size = new Size(651, 975);
            registerGroupBox.TabIndex = 9;
            registerGroupBox.TabStop = false;
            // 
            // errorSelectImagen
            // 
            errorSelectImagen.AutoSize = true;
            errorSelectImagen.BackColor = Color.Transparent;
            errorSelectImagen.Font = new Font("Century Gothic", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorSelectImagen.ForeColor = Color.Red;
            errorSelectImagen.Location = new Point(183, 259);
            errorSelectImagen.Name = "errorSelectImagen";
            errorSelectImagen.Size = new Size(0, 17);
            errorSelectImagen.TabIndex = 55;
            // 
            // errorCityLabel
            // 
            errorCityLabel.AutoSize = true;
            errorCityLabel.BackColor = Color.Transparent;
            errorCityLabel.Font = new Font("Century Gothic", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorCityLabel.ForeColor = Color.Red;
            errorCityLabel.Location = new Point(161, 841);
            errorCityLabel.Name = "errorCityLabel";
            errorCityLabel.Size = new Size(0, 17);
            errorCityLabel.TabIndex = 54;
            // 
            // errorCountryLabel
            // 
            errorCountryLabel.AutoSize = true;
            errorCountryLabel.BackColor = Color.Transparent;
            errorCountryLabel.Font = new Font("Century Gothic", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorCountryLabel.ForeColor = Color.Red;
            errorCountryLabel.Location = new Point(160, 772);
            errorCountryLabel.Name = "errorCountryLabel";
            errorCountryLabel.Size = new Size(0, 17);
            errorCountryLabel.TabIndex = 53;
            // 
            // errorPasswordLabel
            // 
            errorPasswordLabel.AutoSize = true;
            errorPasswordLabel.BackColor = Color.Transparent;
            errorPasswordLabel.Font = new Font("Century Gothic", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorPasswordLabel.ForeColor = Color.Red;
            errorPasswordLabel.Location = new Point(165, 712);
            errorPasswordLabel.Name = "errorPasswordLabel";
            errorPasswordLabel.Size = new Size(0, 17);
            errorPasswordLabel.TabIndex = 52;
            // 
            // errorPhoneNumberLabel
            // 
            errorPhoneNumberLabel.AutoSize = true;
            errorPhoneNumberLabel.BackColor = Color.Transparent;
            errorPhoneNumberLabel.Font = new Font("Century Gothic", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorPhoneNumberLabel.ForeColor = Color.Red;
            errorPhoneNumberLabel.Location = new Point(162, 641);
            errorPhoneNumberLabel.Name = "errorPhoneNumberLabel";
            errorPhoneNumberLabel.Size = new Size(0, 17);
            errorPhoneNumberLabel.TabIndex = 51;
            // 
            // errorBirthDayLabel
            // 
            errorBirthDayLabel.AutoSize = true;
            errorBirthDayLabel.BackColor = Color.Transparent;
            errorBirthDayLabel.Font = new Font("Century Gothic", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorBirthDayLabel.ForeColor = Color.Red;
            errorBirthDayLabel.Location = new Point(161, 583);
            errorBirthDayLabel.Name = "errorBirthDayLabel";
            errorBirthDayLabel.Size = new Size(0, 17);
            errorBirthDayLabel.TabIndex = 50;
            // 
            // errorEmailLabel
            // 
            errorEmailLabel.AutoSize = true;
            errorEmailLabel.BackColor = Color.Transparent;
            errorEmailLabel.Font = new Font("Century Gothic", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorEmailLabel.ForeColor = Color.Red;
            errorEmailLabel.Location = new Point(161, 522);
            errorEmailLabel.Name = "errorEmailLabel";
            errorEmailLabel.Size = new Size(0, 17);
            errorEmailLabel.TabIndex = 49;
            // 
            // errorLastNameLabel
            // 
            errorLastNameLabel.AutoSize = true;
            errorLastNameLabel.BackColor = Color.Transparent;
            errorLastNameLabel.Font = new Font("Century Gothic", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorLastNameLabel.ForeColor = Color.Red;
            errorLastNameLabel.Location = new Point(156, 458);
            errorLastNameLabel.Name = "errorLastNameLabel";
            errorLastNameLabel.Size = new Size(0, 17);
            errorLastNameLabel.TabIndex = 48;
            // 
            // errorUserNameLabel
            // 
            errorUserNameLabel.AutoSize = true;
            errorUserNameLabel.BackColor = Color.Transparent;
            errorUserNameLabel.Font = new Font("Century Gothic", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorUserNameLabel.ForeColor = Color.Red;
            errorUserNameLabel.Location = new Point(156, 396);
            errorUserNameLabel.Name = "errorUserNameLabel";
            errorUserNameLabel.Size = new Size(0, 17);
            errorUserNameLabel.TabIndex = 47;
            // 
            // errorUserLabel
            // 
            errorUserLabel.AutoSize = true;
            errorUserLabel.BackColor = Color.Transparent;
            errorUserLabel.Font = new Font("Century Gothic", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorUserLabel.ForeColor = Color.Red;
            errorUserLabel.Location = new Point(161, 334);
            errorUserLabel.Name = "errorUserLabel";
            errorUserLabel.Size = new Size(0, 17);
            errorUserLabel.TabIndex = 46;
            // 
            // selectImageUserLabel
            // 
            selectImageUserLabel.AutoSize = true;
            selectImageUserLabel.Cursor = Cursors.Hand;
            selectImageUserLabel.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            selectImageUserLabel.ForeColor = Color.SteelBlue;
            selectImageUserLabel.Location = new Point(216, 230);
            selectImageUserLabel.Name = "selectImageUserLabel";
            selectImageUserLabel.Size = new Size(222, 18);
            selectImageUserLabel.TabIndex = 10;
            selectImageUserLabel.Text = "Seleccione una foto de perfil";
            selectImageUserLabel.Click += selectImageUserLabel_Click;
            // 
            // photoNewUserPictureBox
            // 
            photoNewUserPictureBox.BorderStyle = BorderStyle.Fixed3D;
            photoNewUserPictureBox.Location = new Point(253, 87);
            photoNewUserPictureBox.Name = "photoNewUserPictureBox";
            photoNewUserPictureBox.Size = new Size(154, 122);
            photoNewUserPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            photoNewUserPictureBox.TabIndex = 44;
            photoNewUserPictureBox.TabStop = false;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(66, 486);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(152, 18);
            emailLabel.TabIndex = 42;
            emailLabel.Text = "Correo Electronico:";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(253, 483);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(332, 26);
            emailTextBox.TabIndex = 4;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new Point(161, 299);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(66, 18);
            userLabel.TabIndex = 38;
            userLabel.Text = "Usuario:";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(253, 299);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(332, 26);
            userNameTextBox.TabIndex = 1;
            // 
            // privacyLabel
            // 
            privacyLabel.BackColor = Color.Transparent;
            privacyLabel.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            privacyLabel.ForeColor = Color.DimGray;
            privacyLabel.Location = new Point(55, 911);
            privacyLabel.Name = "privacyLabel";
            privacyLabel.Size = new Size(548, 71);
            privacyLabel.TabIndex = 37;
            privacyLabel.Text = "*Al registrarse, aceptas nuestros Terminos De Servicios, Politica de Privacidad y recibir  actualizaciones por parte de los InsanosSV";
            privacyLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginLabel
            // 
            loginLabel.Cursor = Cursors.Hand;
            loginLabel.Font = new Font("Century Gothic", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            loginLabel.ForeColor = Color.DodgerBlue;
            loginLabel.Location = new Point(388, 1011);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(81, 30);
            loginLabel.TabIndex = 36;
            loginLabel.Text = "Ingresar";
            loginLabel.TextAlign = ContentAlignment.MiddleLeft;
            loginLabel.Click += loginLabel_Click;
            // 
            // existingAccountLabel
            // 
            existingAccountLabel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            existingAccountLabel.ForeColor = Color.Black;
            existingAccountLabel.Location = new Point(105, 1011);
            existingAccountLabel.Name = "existingAccountLabel";
            existingAccountLabel.Size = new Size(236, 30);
            existingAccountLabel.TabIndex = 35;
            existingAccountLabel.Text = "¿Ya tienes una cuenta? ";
            existingAccountLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // registerSaveButton
            // 
            registerSaveButton.BackColor = Color.DodgerBlue;
            registerSaveButton.FlatStyle = FlatStyle.Popup;
            registerSaveButton.ForeColor = Color.White;
            registerSaveButton.IconChar = FontAwesome.Sharp.IconChar.None;
            registerSaveButton.IconColor = Color.Black;
            registerSaveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            registerSaveButton.Location = new Point(201, 862);
            registerSaveButton.Name = "registerSaveButton";
            registerSaveButton.Size = new Size(248, 46);
            registerSaveButton.TabIndex = 34;
            registerSaveButton.Text = "Registrarse";
            registerSaveButton.UseVisualStyleBackColor = false;
            registerSaveButton.Click += registerSaveButton_Click;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(152, 801);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(67, 18);
            cityLabel.TabIndex = 33;
            cityLabel.Text = "Ciudad:";
            // 
            // listCityComboBox
            // 
            listCityComboBox.FormattingEnabled = true;
            listCityComboBox.Location = new Point(253, 801);
            listCityComboBox.Name = "listCityComboBox";
            listCityComboBox.Size = new Size(332, 26);
            listCityComboBox.TabIndex = 9;
            // 
            // listCountrysComboBox
            // 
            listCountrysComboBox.FormattingEnabled = true;
            listCountrysComboBox.Location = new Point(253, 739);
            listCountrysComboBox.Name = "listCountrysComboBox";
            listCountrysComboBox.Size = new Size(332, 26);
            listCountrysComboBox.TabIndex = 8;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new Point(183, 739);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(40, 18);
            countryLabel.TabIndex = 31;
            countryLabel.Text = "Pais:";
            // 
            // birthdayDateTimePicker
            // 
            birthdayDateTimePicker.Location = new Point(253, 546);
            birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            birthdayDateTimePicker.Size = new Size(332, 26);
            birthdayDateTimePicker.TabIndex = 5;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(150, 609);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(75, 18);
            phoneNumberLabel.TabIndex = 27;
            phoneNumberLabel.Text = "Telefono:";
            // 
            // numberPhoneTextBox
            // 
            numberPhoneTextBox.Location = new Point(253, 608);
            numberPhoneTextBox.Name = "numberPhoneTextBox";
            numberPhoneTextBox.Size = new Size(332, 26);
            numberPhoneTextBox.TabIndex = 6;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(123, 673);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(97, 18);
            passwordLabel.TabIndex = 25;
            passwordLabel.Text = "Contraseña:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(253, 674);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(332, 26);
            passwordTextBox.TabIndex = 7;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(154, 359);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(72, 18);
            nameLabel.TabIndex = 20;
            nameLabel.Text = "Nombre:";
            // 
            // nameTexBox
            // 
            nameTexBox.Location = new Point(253, 359);
            nameTexBox.Name = "nameTexBox";
            nameTexBox.Size = new Size(332, 26);
            nameTexBox.TabIndex = 2;
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new Point(34, 554);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(172, 18);
            birthdayLabel.TabIndex = 22;
            birthdayLabel.Text = "Fecha de Nacimiento:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(156, 427);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(75, 18);
            lastNameLabel.TabIndex = 23;
            lastNameLabel.Text = "Apellido:";
            // 
            // lastNameTexBox
            // 
            lastNameTexBox.Location = new Point(253, 419);
            lastNameTexBox.Name = "lastNameTexBox";
            lastNameTexBox.Size = new Size(332, 26);
            lastNameTexBox.TabIndex = 3;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipClicked += notifyIcon1_BalloonTipClicked;
            // 
            // errorValidation
            // 
            errorValidation.ContainerControl = this;
            // 
            // NewAccountForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 54, 61);
            ClientSize = new Size(700, 1055);
            Controls.Add(registerGroupBox);
            Controls.Add(minimizePictureBox);
            Controls.Add(closedPictureBox);
            Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NewAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrearCuentaForm";
            ((System.ComponentModel.ISupportInitialize)minimizePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)closedPictureBox).EndInit();
            registerGroupBox.ResumeLayout(false);
            registerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)photoNewUserPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorValidation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox minimizePictureBox;
        private PictureBox closedPictureBox;
        private Label titleLabel;
        private GroupBox registerGroupBox;
        private DateTimePicker birthdayDateTimePicker;
        private Label phoneNumberLabel;
        private TextBox numberPhoneTextBox;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Label nameLabel;
        private TextBox nameTexBox;
        private Label birthdayLabel;
        private Label lastNameLabel;
        private TextBox lastNameTexBox;
        private FontAwesome.Sharp.IconButton registerSaveButton;
        private Label cityLabel;
        private ComboBox listCityComboBox;
        private ComboBox listCountrysComboBox;
        private Label countryLabel;
        private ToolTip toolTip1;
        private Label privacyLabel;
        private Label loginLabel;
        private Label existingAccountLabel;
        private Label userLabel;
        private TextBox userNameTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private NotifyIcon notifyIcon1;
        private Label selectImageUserLabel;
        private PictureBox photoNewUserPictureBox;
        private ErrorProvider errorValidation;
        private Label errorCityLabel;
        private Label errorCountryLabel;
        private Label errorPasswordLabel;
        private Label errorPhoneNumberLabel;
        private Label errorBirthDayLabel;
        private Label errorEmailLabel;
        private Label errorLastNameLabel;
        private Label errorUserNameLabel;
        private Label errorUserLabel;
        private Label errorSelectImagen;
    }
}