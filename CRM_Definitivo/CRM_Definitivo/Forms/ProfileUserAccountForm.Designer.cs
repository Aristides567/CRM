namespace PresentationLayer.Forms.Cliente
{
    partial class ProfileUserAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileUserAccountForm));
            pictureBoxProfileUser = new PictureBox();
            photoProfileChangeUserLabel = new Label();
            informationUserGroupBox = new GroupBox();
            errorBirthdayLabel = new Label();
            errorPhoneNumberLabel = new Label();
            errorLastNameLabel = new Label();
            errorNameLabel = new Label();
            birthdayDateTimePicker = new DateTimePicker();
            birthdayLabel = new Label();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            phoneNumberTextBox = new TextBox();
            phoneNumberLabel = new Label();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            residenceUserGroupBox = new GroupBox();
            errorCityLabel = new Label();
            errorCountryLabel = new Label();
            listCityComboBox = new ComboBox();
            listCountryComboBox = new ComboBox();
            countryLabel = new Label();
            listCityLabel = new Label();
            saveProfileButton = new FontAwesome.Sharp.IconButton();
            accountUserGroupBox = new GroupBox();
            errorUserNameLabel = new Label();
            userNameTextBox = new TextBox();
            userNameLabel = new Label();
            changePasswordProfileLabel = new Label();
            passwordChangeUserTextBox = new TextBox();
            passwordLabel = new Label();
            errorValidation = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfileUser).BeginInit();
            informationUserGroupBox.SuspendLayout();
            residenceUserGroupBox.SuspendLayout();
            accountUserGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorValidation).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxProfileUser
            // 
            pictureBoxProfileUser.BackColor = Color.White;
            pictureBoxProfileUser.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxProfileUser.Location = new Point(69, 43);
            pictureBoxProfileUser.Name = "pictureBoxProfileUser";
            pictureBoxProfileUser.Size = new Size(193, 176);
            pictureBoxProfileUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProfileUser.TabIndex = 0;
            pictureBoxProfileUser.TabStop = false;
            // 
            // photoProfileChangeUserLabel
            // 
            photoProfileChangeUserLabel.AutoSize = true;
            photoProfileChangeUserLabel.BackColor = Color.Transparent;
            photoProfileChangeUserLabel.Cursor = Cursors.Hand;
            photoProfileChangeUserLabel.Font = new Font("Century Gothic", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            photoProfileChangeUserLabel.ForeColor = Color.Black;
            photoProfileChangeUserLabel.Location = new Point(81, 259);
            photoProfileChangeUserLabel.Name = "photoProfileChangeUserLabel";
            photoProfileChangeUserLabel.Size = new Size(170, 20);
            photoProfileChangeUserLabel.TabIndex = 1;
            photoProfileChangeUserLabel.Text = "Cambiar foto de perfil";
            photoProfileChangeUserLabel.Click += photoProfileChangeUserLabel_Click;
            // 
            // informationUserGroupBox
            // 
            informationUserGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            informationUserGroupBox.Controls.Add(errorBirthdayLabel);
            informationUserGroupBox.Controls.Add(errorPhoneNumberLabel);
            informationUserGroupBox.Controls.Add(errorLastNameLabel);
            informationUserGroupBox.Controls.Add(errorNameLabel);
            informationUserGroupBox.Controls.Add(birthdayDateTimePicker);
            informationUserGroupBox.Controls.Add(birthdayLabel);
            informationUserGroupBox.Controls.Add(lastNameTextBox);
            informationUserGroupBox.Controls.Add(lastNameLabel);
            informationUserGroupBox.Controls.Add(phoneNumberTextBox);
            informationUserGroupBox.Controls.Add(phoneNumberLabel);
            informationUserGroupBox.Controls.Add(nameTextBox);
            informationUserGroupBox.Controls.Add(nameLabel);
            informationUserGroupBox.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            informationUserGroupBox.Location = new Point(314, 24);
            informationUserGroupBox.Name = "informationUserGroupBox";
            informationUserGroupBox.Size = new Size(817, 322);
            informationUserGroupBox.TabIndex = 2;
            informationUserGroupBox.TabStop = false;
            informationUserGroupBox.Text = "Informacion";
            // 
            // errorBirthdayLabel
            // 
            errorBirthdayLabel.AutoSize = true;
            errorBirthdayLabel.BackColor = Color.Transparent;
            errorBirthdayLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorBirthdayLabel.ForeColor = Color.Red;
            errorBirthdayLabel.Location = new Point(13, 296);
            errorBirthdayLabel.Name = "errorBirthdayLabel";
            errorBirthdayLabel.Size = new Size(0, 18);
            errorBirthdayLabel.TabIndex = 11;
            // 
            // errorPhoneNumberLabel
            // 
            errorPhoneNumberLabel.AutoSize = true;
            errorPhoneNumberLabel.BackColor = Color.Transparent;
            errorPhoneNumberLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorPhoneNumberLabel.ForeColor = Color.Red;
            errorPhoneNumberLabel.Location = new Point(13, 237);
            errorPhoneNumberLabel.Name = "errorPhoneNumberLabel";
            errorPhoneNumberLabel.Size = new Size(0, 18);
            errorPhoneNumberLabel.TabIndex = 10;
            // 
            // errorLastNameLabel
            // 
            errorLastNameLabel.AutoSize = true;
            errorLastNameLabel.BackColor = Color.Transparent;
            errorLastNameLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorLastNameLabel.ForeColor = Color.Red;
            errorLastNameLabel.Location = new Point(16, 158);
            errorLastNameLabel.Name = "errorLastNameLabel";
            errorLastNameLabel.Size = new Size(0, 18);
            errorLastNameLabel.TabIndex = 9;
            // 
            // errorNameLabel
            // 
            errorNameLabel.AutoSize = true;
            errorNameLabel.BackColor = Color.Transparent;
            errorNameLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorNameLabel.ForeColor = Color.Red;
            errorNameLabel.Location = new Point(16, 86);
            errorNameLabel.Name = "errorNameLabel";
            errorNameLabel.Size = new Size(0, 18);
            errorNameLabel.TabIndex = 8;
            // 
            // birthdayDateTimePicker
            // 
            birthdayDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            birthdayDateTimePicker.Location = new Point(127, 265);
            birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            birthdayDateTimePicker.Size = new Size(389, 28);
            birthdayDateTimePicker.TabIndex = 7;
            // 
            // birthdayLabel
            // 
            birthdayLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new Point(34, 263);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(67, 21);
            birthdayLabel.TabIndex = 6;
            birthdayLabel.Text = "Fecha:";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lastNameTextBox.Location = new Point(127, 123);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(389, 28);
            lastNameTextBox.TabIndex = 5;
            // 
            // lastNameLabel
            // 
            lastNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(13, 123);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(83, 21);
            lastNameLabel.TabIndex = 4;
            lastNameLabel.Text = "Apellido:";
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            phoneNumberTextBox.Location = new Point(127, 197);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(389, 28);
            phoneNumberTextBox.TabIndex = 3;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(13, 197);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(85, 21);
            phoneNumberLabel.TabIndex = 2;
            phoneNumberLabel.Text = "Telefono:";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            nameTextBox.Location = new Point(127, 40);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(389, 28);
            nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(16, 40);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(82, 21);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Nombre:";
            // 
            // residenceUserGroupBox
            // 
            residenceUserGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            residenceUserGroupBox.Controls.Add(errorCityLabel);
            residenceUserGroupBox.Controls.Add(errorCountryLabel);
            residenceUserGroupBox.Controls.Add(listCityComboBox);
            residenceUserGroupBox.Controls.Add(listCountryComboBox);
            residenceUserGroupBox.Controls.Add(countryLabel);
            residenceUserGroupBox.Controls.Add(listCityLabel);
            residenceUserGroupBox.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            residenceUserGroupBox.Location = new Point(314, 352);
            residenceUserGroupBox.Name = "residenceUserGroupBox";
            residenceUserGroupBox.Size = new Size(817, 212);
            residenceUserGroupBox.TabIndex = 3;
            residenceUserGroupBox.TabStop = false;
            residenceUserGroupBox.Text = "Residenncia";
            // 
            // errorCityLabel
            // 
            errorCityLabel.AutoSize = true;
            errorCityLabel.BackColor = Color.Transparent;
            errorCityLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorCityLabel.ForeColor = Color.Red;
            errorCityLabel.Location = new Point(23, 179);
            errorCityLabel.Name = "errorCityLabel";
            errorCityLabel.Size = new Size(0, 18);
            errorCityLabel.TabIndex = 18;
            // 
            // errorCountryLabel
            // 
            errorCountryLabel.AutoSize = true;
            errorCountryLabel.BackColor = Color.Transparent;
            errorCountryLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorCountryLabel.ForeColor = Color.Red;
            errorCountryLabel.Location = new Point(23, 91);
            errorCountryLabel.Name = "errorCountryLabel";
            errorCountryLabel.Size = new Size(0, 18);
            errorCountryLabel.TabIndex = 12;
            // 
            // listCityComboBox
            // 
            listCityComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listCityComboBox.FormattingEnabled = true;
            listCityComboBox.Location = new Point(127, 131);
            listCityComboBox.Name = "listCityComboBox";
            listCityComboBox.Size = new Size(351, 29);
            listCityComboBox.TabIndex = 17;
            // 
            // listCountryComboBox
            // 
            listCountryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listCountryComboBox.FormattingEnabled = true;
            listCountryComboBox.Location = new Point(127, 48);
            listCountryComboBox.Name = "listCountryComboBox";
            listCountryComboBox.Size = new Size(351, 29);
            listCountryComboBox.TabIndex = 16;
            // 
            // countryLabel
            // 
            countryLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            countryLabel.AutoSize = true;
            countryLabel.Location = new Point(59, 48);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(47, 21);
            countryLabel.TabIndex = 8;
            countryLabel.Text = "Pais:";
            // 
            // listCityLabel
            // 
            listCityLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listCityLabel.AutoSize = true;
            listCityLabel.Location = new Point(23, 131);
            listCityLabel.Name = "listCityLabel";
            listCityLabel.Size = new Size(78, 21);
            listCityLabel.TabIndex = 12;
            listCityLabel.Text = "Ciudad:";
            // 
            // saveProfileButton
            // 
            saveProfileButton.IconChar = FontAwesome.Sharp.IconChar.None;
            saveProfileButton.IconColor = Color.Black;
            saveProfileButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            saveProfileButton.Location = new Point(23, 221);
            saveProfileButton.Name = "saveProfileButton";
            saveProfileButton.Size = new Size(141, 40);
            saveProfileButton.TabIndex = 4;
            saveProfileButton.Text = "Guardar";
            saveProfileButton.UseVisualStyleBackColor = true;
            saveProfileButton.Click += saveProfileButton_Click;
            // 
            // accountUserGroupBox
            // 
            accountUserGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            accountUserGroupBox.Controls.Add(errorUserNameLabel);
            accountUserGroupBox.Controls.Add(saveProfileButton);
            accountUserGroupBox.Controls.Add(userNameTextBox);
            accountUserGroupBox.Controls.Add(userNameLabel);
            accountUserGroupBox.Controls.Add(changePasswordProfileLabel);
            accountUserGroupBox.Controls.Add(passwordChangeUserTextBox);
            accountUserGroupBox.Controls.Add(passwordLabel);
            accountUserGroupBox.Location = new Point(314, 587);
            accountUserGroupBox.Name = "accountUserGroupBox";
            accountUserGroupBox.Size = new Size(817, 277);
            accountUserGroupBox.TabIndex = 3;
            accountUserGroupBox.TabStop = false;
            accountUserGroupBox.Text = "Cuenta";
            // 
            // errorUserNameLabel
            // 
            errorUserNameLabel.AutoSize = true;
            errorUserNameLabel.BackColor = Color.Transparent;
            errorUserNameLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorUserNameLabel.ForeColor = Color.Red;
            errorUserNameLabel.Location = new Point(34, 97);
            errorUserNameLabel.Name = "errorUserNameLabel";
            errorUserNameLabel.Size = new Size(0, 18);
            errorUserNameLabel.TabIndex = 19;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            userNameTextBox.Location = new Point(141, 46);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(281, 26);
            userNameTextBox.TabIndex = 9;
            // 
            // userNameLabel
            // 
            userNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(34, 55);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(67, 20);
            userNameLabel.TabIndex = 8;
            userNameLabel.Text = "Usuario:";
            // 
            // changePasswordProfileLabel
            // 
            changePasswordProfileLabel.AutoSize = true;
            changePasswordProfileLabel.Cursor = Cursors.Hand;
            changePasswordProfileLabel.Font = new Font("Century Gothic", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            changePasswordProfileLabel.ForeColor = SystemColors.Highlight;
            changePasswordProfileLabel.Location = new Point(172, 184);
            changePasswordProfileLabel.Name = "changePasswordProfileLabel";
            changePasswordProfileLabel.Size = new Size(160, 20);
            changePasswordProfileLabel.TabIndex = 2;
            changePasswordProfileLabel.Text = "Cambiar contraseña";
            changePasswordProfileLabel.Click += changePasswordProfileLabel_Click;
            // 
            // passwordChangeUserTextBox
            // 
            passwordChangeUserTextBox.Location = new Point(141, 130);
            passwordChangeUserTextBox.Name = "passwordChangeUserTextBox";
            passwordChangeUserTextBox.Size = new Size(281, 26);
            passwordChangeUserTextBox.TabIndex = 11;
            passwordChangeUserTextBox.Text = "pruebadestacochinada";
            passwordChangeUserTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(16, 130);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(99, 20);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Contraseña:";
            // 
            // errorValidation
            // 
            errorValidation.ContainerControl = this;
            // 
            // ProfileUserAccountForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1271, 933);
            Controls.Add(photoProfileChangeUserLabel);
            Controls.Add(pictureBoxProfileUser);
            Controls.Add(accountUserGroupBox);
            Controls.Add(residenceUserGroupBox);
            Controls.Add(informationUserGroupBox);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1640, 960);
            Name = "ProfileUserAccountForm";
            Text = "Perfil de Usuario";
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfileUser).EndInit();
            informationUserGroupBox.ResumeLayout(false);
            informationUserGroupBox.PerformLayout();
            residenceUserGroupBox.ResumeLayout(false);
            residenceUserGroupBox.PerformLayout();
            accountUserGroupBox.ResumeLayout(false);
            accountUserGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorValidation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxProfileUser;
        private Label photoProfileChangeUserLabel;
        private GroupBox informationUserGroupBox;
        private Label birthdayLabel;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private TextBox phoneNumberTextBox;
        private Label phoneNumberLabel;
        private TextBox nameTextBox;
        private Label nameLabel;
        private GroupBox residenceUserGroupBox;
        private GroupBox accountUserGroupBox;
        private DateTimePicker birthdayDateTimePicker;
        private ComboBox listCityComboBox;
        private ComboBox listCountryComboBox;
        private Label countryLabel;
        private Label listCityLabel;
        private Label errorBirthdayLabel;
        private Label errorPhoneNumberLabel;
        private TextBox passwordChangeUserTextBox;
        private Label passwordLabel;
        private TextBox txt;
        private Label errorLastNameLabel;
        private Label changePasswordProfileLabel;
        private FontAwesome.Sharp.IconButton saveProfileButton;
        private TextBox userNameTextBox;
        private Label userNameLabel;
        private Label errorNameLabel;
        private ErrorProvider errorValidation;
        private Label errorCityLabel;
        private Label errorCountryLabel;
        private Label errorUserNameLabel;
    }
}